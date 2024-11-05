using Microsoft.AspNetCore.Mvc;
using Red_Dead_Redemption_2.Models;
using System.Diagnostics;

namespace Red_Dead_Redemption_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Story()
        {
            return View();
        }

        public IActionResult Characters()
        {
            List<Character> characters = new List<Character>()
            {
                new Character {
                    Name = "Dutch van der Linde",
                    Role = "Gang Leader",
                    Bio = "The leader of a sizeable gang of outlaws and misfits. Idealistic, anarchic, charismatic, well-read, well-lived, but possibly starting to unravel under the pressures of the encroaching modern world.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/RtjZOFI4Gt1bg3SPF1QphVsVHhd1Hbk8.png?w=440&thumb=false",
                    Quote = "They're chasing us hard, because we represent everything that they fear."},
                new Character { 
                    Name = "Hosea Matthews", 
                    Role = "Second-in-Command",
                    Bio = "A master con artist, gentleman and thief, Hosea has been Dutch's closest friend and right-hand man for over twenty years. Intelligent and quick-witted, he can talk his way into, or out of, just about anything.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/X29Bo4IaMwqE6JVz6zdKWhW6IQMutDTB.png?w=440&thumb=false",
                    Quote = " wish I had acquired wisdom at less of a price."},
                new Character { 
                    Name = "Arthur Morgan", 
                    Role = "Third-in-Command/Lead Enforcer", 
                    Bio = "Dutch's most dependable and capable enforcer since he was a boy, the outlaw life is all Arthur has ever known. Sharp, cool-headed, and ruthless, but with his own sense of honor. A man who gets the job done.", 
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/ItkSm1W2jhIgufHLePQbVxp7EA5NNRGZ.png?w=440&thumb=false",
                    Quote = "We're thieves in a world that don't want us no more."},
                new Character { 
                    Name = "John Marston", 
                    Role = "Gunman",
                    Bio = "Once an orphaned street kid taken under Dutch's wing at the age of twelve, John has always had to live by his wits. Shrewd, fearless and strong-willed, he and Arthur are Dutch’s proudest protégés.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/aC64Dg8Gv1pQODVQfwweU0JHAZvlXmPL.png?w=440&thumb=false",
                    Quote = "Guess about all I got left now is doubts. Doubts and scars."},
                new Character { 
                    Name = "Charles Smith", 
                    Role = "Gunman/Hunter", 
                    Bio = "A relatively recent recruit to the gang, Charles is quiet and reserved but extremely competent in everything he does and virtually unbeatable in a fight. A decent, honest man who also happens to be deadly.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/WTCzJ2w3YRYyKWN1yLZPyNwwC35wGWnD.png?w=440&thumb=false",
                    Quote = "The amount of hell we've raised, we're owed some back."},
                new Character { 
                    Name = "Micah Bell", 
                    Role = "Gunman",
                    Bio = "A career criminal and hitman. Wild and unpredictable but he lives for the action.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/n5Io5Af7Lrj1zpeIyEBfNUPmuz9wQF3S.png?w=440&thumb=false",
                    Quote = "I believe there's winners and losers... and nothing else besides."},
                new Character { 
                    Name = "Bill Williamson", 
                    Role = "Gunman",
                    Bio = "An ex-soldier discharged from the army, possibly dishonorably. Hot headed, he tends to act first and think later but is tough, dedicated and always ready to fight.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/VhdHuBngVv6KyWtVpGjSj3LmjIfxWRrb.png?w=440&thumb=false",
                    Quote = "Don't try anything stupid and we won't do anything unkind."},
                new Character { 
                    Name = "Lenny Summers", 
                    Role = "Gunman",
                    Bio = "Young Lenny has been on the run since he was 15 years old after killing the men who murdered his father. Smart, educated, competent and ambitious, he is always ready to do his part.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/JnWeDItBxiSUsg4MhlGQ3hoMo4O9NUo2.png?w=440&thumb=false",
                    Quote = "Living free out here, Like this... I wouldn't have it any other way."},
                new Character { 
                    Name = "Sean Macguire", 
                    Role = "Gunman",
                    Bio = "A cocky young Irish thief and stick-up man who comes from a long line of criminals and political dissidents. He always wants a piece of the action and believes in himself…perhaps a little too much.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/BT8wreUN2oI7j8QUpNbsThtqKh2wis98.png?w=440&thumb=false",
                    Quote = "Just leave it to me. I can talk a dog off a meat wagon."},
                new Character { 
                    Name = "Javier Escuella", 
                    Role = "Gunman",
                    Bio = "A notorious bounty hunter and Mexican revolutionary. Javier immediately had a strong connection to Dutch’s ideals. Very committed, passionate and loyal.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/q0OFVAH5uJLSCewH2dRUs8L2A8slOzmE.png?w=440&thumb=false",
                    Quote = "If we have to fight, we fight. If we have to run, we'll run. If we must die, we'll die, but... We'll stay free."},
                new Character { 
                    Name = "Karen Jones", 
                    Role = "Gunwoman/Handmaid",
                    Bio = "A consummate scam artist and trigger woman who can drink pretty much anybody under the table. Bold and full of fun, she loves the outlaw life and wouldn’t have it any other way.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/GVdYdoREWdHAoQuQSN1XLw1GtwzLO9eU.png?w=440&thumb=false",
                    Quote = "Running scams, robbing banks, screwing over the rich and horrible."},
                new Character { 
                    Name = "Sadie Adler", 
                    Role = "Gunwoman",
                    Bio = "A widow who is hellbent on taking revenge upon those who killed her husband. Relentless and afraid of nothing and no one. The wrong woman to cross, but very loyal to those she loves.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/L3LkDiinGfGY7I6nGMnsIGFeKAe5rGHB.png?w=440&thumb=false",
                    Quote = "Nobody's taking nothing from me ever again."},
                new Character {
                    Name = "Abigail Roberts", 
                    Role = "Thief",
                    Bio = "An orphan who grew up scraping out a living in dive bars and brothels in the West, Abigail is a strong, straight-talking woman who has seen a lot of life and knows what it takes to survive against the odds.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/g8mqbH88VNXkvmq0RXJV3tjHivQ0KPvE.png?w=440&thumb=false",
                    Quote = "If they so much as put one bruise on him I swear, I'll bring the fires of hell on them myself."},
                new Character { 
                    Name = "Susan Grimshaw", 
                    Role = "Camp Administrator",
                    Bio = "The undisputed boss and arbiter of justice in the camp, everything would have fallen apart years ago without Susan in charge. Tenacious and iron-willed, she stands for no nonsense.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/VN5DtIf9JnAYNnBtODisI1z5A1GOSEFO.png?w=440&thumb=false",
                    Quote = "I swear half of you would just rot in your own filth, if nobody kept you in check."},
                new Character { 
                    Name = "Molly O'Shea", 
                    Role = "Caretaker",
                    Bio = "A Dublin girl and the object of Dutch’s affection, for now at least, Molly is too high-strung for a life on the run and it’s all starting to take a toll on her.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/owl6rLWsDHshxsXZHKc6HRry5VY1odMC.png?w=440&thumb=false",
                    Quote = "You're playing a dangerous game."},
                new Character { 
                    Name = "Tilly Jackson", 
                    Role = "Handmaid",
                    Bio = "An outlaw from the age of 12, Tilly ran with another gang before joining up with Dutch. Savvy, resilient and dependable, she can more than handle herself and isn’t afraid to speak her mind.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/vpkkM6SzQwzIpIupfkINn5Lkz8ZaOHzB.png?w=440&thumb=false",
                    Quote = "Most of us grew up hungry and scared and alone, one way or another."},
                new Character { 
                    Name = "Mary-Beth Gaskill", 
                    Role = "Thief/Handmaid",
                    Bio = "A kind, good-natured young woman, which makes her the perfect criminal. By the time people realize they’ve been duped, Mary-Beth is already on her way home with the money.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/QqzbQcBmcJtqIhL5P4rQAyc90rFlbkIS.png?w=440&thumb=false",
                    Quote = "Gentlemen, I think I've got something good."},
                new Character { 
                    Name = "Simon Pearson", 
                    Role = "Camp Butcher",
                    Bio = "The camp’s butcher and cook, Pearson served a short stint in the navy that he likes to talk about at length. A loud, jolly degenerate who is somewhat in denial about the turn his life has taken.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/AuiOc7iezzuHX9Kj5ejxOoqYD0teLYfy.png?w=440&thumb=false",
                    Quote = "The people are happy and well fed. I think perhaps we'll be ok."},
                new Character { 
                    Name = "Leopold Strauss", 
                    Role = "Loanshark",
                    Bio = "Originally hailing from Austria, Herr Strauss is responsible for keeping the gang’s books and running their money lending operation. A serious, somewhat shifty and unemotional man, he has all the qualities a loan shark needs.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/UmAQxc7wxXUEFq2Qfwgo6AGrePll8YUd.png?w=440&thumb=false",
                    Quote = "It's a nasty world out there, and it's catching up with us..."},
                new Character { 
                    Name = "Jack Marston", 
                    Role = "John's and Abigail's son",
                    Bio = "Young Jack has grown up with the gang, although everyone has done their best to shield him from the more nefarious elements, especially his mother Abigail. He loves everything about nature and the outdoor life, and is carefully watched over by his many aunts and uncles.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/H044vTICeqgE6VmpgMv8W3C8OA9yRAWa.png?w=440&thumb=false",
                    Quote = "Did you catch the bad guys?"},
                new Character { 
                    Name = "Uncle", 
                    Role = "Thief/Drunkard",
                    Bio = "A hanger-on and good-time guy, Uncle is always around when the whiskey is open and never around when there’s any work to be done. If he wasn’t so entertaining, Dutch would have cut him loose years ago.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/8pJkUM0yvuGyrVDQXF4vnhPqGjls5B1L.png?w=440&thumb=false",
                    Quote = "People call me lazy. I'm not lazy. Just don't like working. There's a difference."},
                new Character { 
                    Name = "Josiah Trelawny", 
                    Role = "Conman/Informant",
                    Bio = "A flamboyant conjurer, conman and trickster, Trelawny is a very hard man to pin down but he’s always able to bring good leads.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/PjFxmJnUyLJzVXTyMG2V7gmVuRRtlLMO.png?w=440&thumb=false",
                    Quote = "How can romance ever be silly? It's all we have."},
                new Character { 
                    Name = "Reverend Swanson", 
                    Role = "Priest",
                    Bio = "An ex clergyman now lost to debauchery, Swanson has fallen a long way from the standards he once set himself. If he hadn’t saved Dutch’s life in the past, it’s unlikely the gang would have kept him around for this long.",
                    ImageUrl = "https://image.api.playstation.com/cdn/EP1004/CUSA08519_00/ZnqzovDjVL5m7EnZdU2kq6KNab1nh9vV.png?w=440&thumb=false",
                    Quote = "I had real suffering and I lost everything, my vocation, my faith, my family ..."},
            };

            return View(characters);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Weaponry()
        {
            return View();
        }
    }
}
