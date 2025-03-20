using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Red_Dead_Redemption_2.Models;
using Microsoft.EntityFrameworkCore;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;

    }

    // GET: Account
    public IActionResult
Index()
    {
        return View();
    }

    // GET: Account/Signup
    public IActionResult Signup()
    {
        ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "Name");
        return View();
    }

    // POST: Account/Signup
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Signup([Bind("Email,FirstName,LastName,CountryId,Password,ConfirmPassword")] User user)
    {
        if (ModelState.IsValid)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(SignupSuccessful));

        }
        ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "Name", user.CountryId);
        return View(user);
    }

    // GET: Account/SignupSuccessful
    public IActionResult SignupSuccessful()
    {
        return View();
    }

    // GET: Account/Login
    public IActionResult Login()
    {
        return View();
    }

    // POST: Account/Login
    [HttpPost]
    [ValidateAntiForgeryToken]
    public
async Task<IActionResult> Login([Bind("Email,Password")] User user)
    {
        if (ModelState.IsValid)

        {
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);

            if (existingUser != null)

            {
                return RedirectToAction(nameof(LoginSuccessful), new { email = user.Email });
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        }
        return View(user);
    }

    // GET: Account/LoginSuccessful
    public async Task<IActionResult> LoginSuccessful(string email)
    {
        var user = await _context.Users
            .Include(u => u.Country)
            .FirstOrDefaultAsync(m => m.Email == email);

        if (user == null)
        {
            return NotFound();
        }

        return View(user);
    }
}