﻿using DnD_CharacterSheet;

CharacterSheet deadlyRobot = new CharacterSheet();
Random randomNum = new Random();
deadlyRobot.Name = "Bot";
deadlyRobot.ArmorClass = randomNum.Next(1,35);
deadlyRobot.HitPoints = randomNum.Next(1, 15);
deadlyRobot.Speed = 30;
deadlyRobot.AddItemToInventory("gold", 30);
CharacterSheet userCharacter = new CharacterSheet();
CharacterSheet defaultCharacter = new CharacterSheet();

Console.WriteLine("Welcome to your DnD Character Sheet!");
Console.WriteLine("Would you like to use our default values or enter your Own values? \nPlease type 'default' for default or 'user' for user values");
Console.WriteLine("please select numbers 1 or 2.");
Console.WriteLine("1.) User \n2.) Default");

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
                Console.WriteLine("please select numbers 1-3.");
                Console.WriteLine("1.) Add \n2.) Remove \n3.) Exit to Menu");
                switch (Console.ReadLine())
				{
					case "1":
						break;
					case "2":
						break;
					case "3":
						inInventory = false;
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
				}
				Console.Clear();
                Console.WriteLine(userCharacter.Name + "'s Armor Class is now: " + userCharacter.ArmorClass);

            }
			Console.Clear();
			break;
		case "4":
			Console.Clear();
			bool isfighting = true;
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
                    Console.WriteLine("Congradulation!!! You have killed the Evil Killer Robot");
					deadlyRobot.HitPoints = 20;
					Thread.Sleep(5000);
                    userCharacter.Experiance += 200;
                    break;
                }
                Console.WriteLine("Warning if your Character dies game is OVER and Hitpoints are set to 1.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("please select numbers 1-3.");
                Console.WriteLine("1.) Attack \n2.) Block \n3.) Run \n4.) Exit to Menu");
				Console.WriteLine("Name: " + userCharacter.Name);
				Console.WriteLine("Armor Class: " + userCharacter.ArmorClass);
				Console.WriteLine("Hitpoints: " + userCharacter.HitPoints);
				Console.WriteLine("Speed: " + userCharacter.Speed);
				
                switch (Console.ReadLine())
				{
					case "1":
						Console.Clear();
						deadlyRobot.Attacked();
						break;
					case "2":
						Console.Clear();
						userCharacter.Block();
						break;
					case "3":
						Console.Clear();
						userCharacter.Run();
						break;
					case "4":
						Console.Clear();
						Console.WriteLine("You wont be able to get out this way...The way is shut it was made by the DEAD");
						break;
				}
			}
			
			Console.Clear();
			break;
		default:
			break;
	}
}