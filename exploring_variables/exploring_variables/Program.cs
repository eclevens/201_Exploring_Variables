namespace exploring_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            //string
            string heroFirstName = "Ella";
            string heroLastName = "Clevens";
            string heroFullName;
            string villainTitle = "Slay Vampire Queen";
            string minionTitle = "Baby Waby Vampire Spawn";
            string villainName;
            string minion1Name;
            string minion2Name;
            //integers
            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;


            //Begin code instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the glorious hero and cat lover: " + heroFullName);

            villainName = "Victoria";
            minion1Name = "Cinnamon";
            minion2Name = "Vanilla";

            Console.WriteLine(heroFullName + "'s arch rival is " + villainName + ", the " + villainTitle);
            Console.WriteLine(villainName + " the " + villainTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minion2Name);

            //Are you prepared to fight?
            Console.WriteLine("The fighters enter the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            //Time to fight!

            //Bad guys attack our hero!
            //Boss turn first
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            //Current health - damage done then store new health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //minions attack
            Console.WriteLine("Now the evil minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            //Current health - damage and store
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            //Current health - damage and store
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero's turn to attack
            Console.WriteLine(heroFullName + " attacks each villain for " + heroStrength + " damage");
            //calculate healths
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;
            //display in console
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //the minions are defeated!
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //end of round buff
            Console.WriteLine(heroFullName + " has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " eats some cheesecake to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //final round of fight
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            //Boss attacks first
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            //current health - damage and store
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Hero attacks
            Console.WriteLine(heroFullName + " attacks " + villainName + " the " + villainTitle + " for " + heroStrength + " damage!");
            //math
            bossHealth -= heroStrength;
            //display results
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");
            //results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A's to the winner!");
        }
    }
}