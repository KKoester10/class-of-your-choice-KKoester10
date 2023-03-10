using DnD_CharacterSheet;

Console.WriteLine("Welcome to your DnD Character Sheet!");
Console.WriteLine("Would you like to use our default values or enter your Own values?");
Console.WriteLine("Select numbers 1 or 2.");
Console.WriteLine("1.) User \n2.) Default");
CharacterSheet userCharacter = new CharacterSheet();
CharacterSheet defaultCharacter = new CharacterSheet();
CharacterSheet deadlyRobot = new CharacterSheet();
Random randomNum = new Random();
deadlyRobot.Name = "Bot";
deadlyRobot.ArmorClass = randomNum.Next(1,35);
deadlyRobot.HitPoints = randomNum.Next(1, 15);
deadlyRobot.Speed = 30;

if (Console.ReadLine() == "1")
{ 
	Console.WriteLine("Enter the name of your character");
	userCharacter.Name = Console.ReadLine();
    Console.WriteLine("Enter the Armor Class of your character");
    userCharacter.ArmorClass = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the Hit Points of your character");
    userCharacter.HitPoints = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the Speed of your character");
    userCharacter.Speed = int.Parse(Console.ReadLine());
	Console.Clear();
}
else
{
	defaultCharacter.Name = "Jedidia";
	defaultCharacter.ArmorClass = 15;
	defaultCharacter.HitPoints = 15;
	defaultCharacter.Speed = 30;
	userCharacter = defaultCharacter;
		
}
Console.Clear();
var isrunning = true;
while (isrunning)
{
    Console.WriteLine("MENU");
	Console.WriteLine("What would you like to do with your character?");
	Console.WriteLine("1.) End Application \n2.) Mananing Items in your Inventory. \n3.) Managing your Armor Class \n4.) Battle a Killer Robot" );
	switch (Console.ReadLine())
	{
		case "1":
			isrunning = false;
			break;
		case "2":
			Console.Clear();
			Console.WriteLine("Would you like to 'Add' to your inventory ? Or would you like to 'Remove' from your Inventory?");
			bool inInventory = true;
			while (inInventory)
			{
                Console.WriteLine("Select numbers 1-3.");
                Console.WriteLine("1.) Add \n2.) Remove \n3.) Exit to Menu");
                switch (Console.ReadLine())
				{
					case "1":
                        Console.Clear();
                        Console.WriteLine("Enter the item's name");
						var item = Console.ReadLine();
						Console.WriteLine("Enter the amount of the item you have");
						var amount = Console.ReadLine();
                        userCharacter.AddItemToInventory(item, int.Parse(amount));
                        break;
					case "2":
                        Console.Clear();
                        Console.WriteLine("Enter the name of the item you would like to remove.");
						var itemR = Console.ReadLine();
						Console.WriteLine("Enter the the amount you want removed");
						var amountR = int.Parse(Console.ReadLine());
						userCharacter.RemoveItemFromInventory(itemR,amountR);
						break;
					case "3":
						inInventory = false;
						break;
                    default:
						Console.Clear();
                        Console.WriteLine("Sorry I dont understand");
                        break;
                }
			}
			Console.Clear();
			break;
		case "3":
			Console.Clear();
			Console.WriteLine("Would you like to increase your Armor Class? Or would you like to decrease your Armor Class?");
			bool managingArmorClass = true;
			while (managingArmorClass)
			{
				Console.WriteLine("please select numbers 1-3.");
				Console.WriteLine("1.) Increase \n2.) Decrease \n3.) Exit to Menu" );
				switch (Console.ReadLine())
				{
					case "1":
						Console.WriteLine("Please enter an amount you would like to add");
						userCharacter.IncreaseArmorClass(int.Parse(Console.ReadLine()));
						break;
					case "2":
						Console.WriteLine("Please enter an amount you would like to decrease");
						userCharacter.DecreaseArmorClass(int.Parse(Console.ReadLine()));
						break;
					case "3":
						managingArmorClass = false;
						break;
                    default:
                        Console.WriteLine("Sorry I dont understand");
                        break;
                }
                Console.WriteLine(userCharacter.Name + "'s Armor Class is now: " + userCharacter.ArmorClass);
            }
			Console.Clear();
			break;
		case "4":
			Console.Clear();
			bool isfighting = true;
			Console.WriteLine("Warning if your Character dies game is OVER and Hitpoints are set to 1.");
			while (isfighting)
			{
               if (userCharacter.HitPoints <= 0)
				{
					Console.WriteLine(userCharacter.Name + " has been horribly injured by a killer Robot!");
					userCharacter.HitPoints = randomNum.Next(1,5);
                    Thread.Sleep(5000);
                    break;
				}
                if (deadlyRobot.HitPoints <= 0)
                {
                    Console.WriteLine("Congradulation!!! You have killed the Evil Killer Robot \nYou have gained 200 Experiance");
					deadlyRobot.HitPoints = randomNum.Next(10,20);
                    userCharacter.Experiance += 200;
					Console.WriteLine($"{userCharacter.Name} Experiance Amount is {userCharacter.Experiance}");
					Thread.Sleep(5000);
                    break;
                }
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("please select numbers 1-3.");
                Console.WriteLine("1.) Attack \n2.) Block \n3.) Run \n4.) Exit to Menu");
				Console.WriteLine($"Your Character \nName: {userCharacter.Name}\nArmor Class: {userCharacter.ArmorClass}\nHitpoints: {userCharacter.HitPoints}\nSpeed: {userCharacter.Speed}");
                switch (Console.ReadLine())
				{
					case "1":
						deadlyRobot.Attacked();
						break;
					case "2":
						userCharacter.Block();
						break;
					case "3":
						userCharacter.Run();
						break;
					case "4":
						Console.Clear();
						Console.WriteLine("You wont be able to get out this way...The way is shut it was made by the DEAD");
						Thread.Sleep(3000);
						Console.WriteLine("Just kidding Thanks for playing!");
                        Thread.Sleep(5000);
						isfighting = false;
                        Console.Clear();
						break;
					default:
						Console.Clear();
						Console.WriteLine("Sorry I dont understand");
						break;
				}
			}
			Console.Clear();
			break;
        default:
            Console.WriteLine("Sorry I dont understand");
            break;
    }
}
Console.Clear();
Console.WriteLine("Thank you for playing!");
Thread.Sleep(5000);