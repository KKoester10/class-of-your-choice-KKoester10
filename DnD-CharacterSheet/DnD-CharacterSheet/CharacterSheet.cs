using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterSheet
{
    public class CharacterSheet
    {
        public string Name { get; set; }
        public int ArmorClass { get; set; }
        public Dictionary<string,int> Inventory { get; set; }
        public int HitPoints { get; set; }
        public int Speed { get; set; }
        public int Experiance { get; set; }

        public CharacterSheet()
        {
            
        }

        public void AddItemToInventory(string item , int amount)
        {
            // Add items to inventory
            Inventory.Add(item, amount);
        }
        public void RemoveItemFromInventory(string item, int amount)
        {
            // remove items to inventory
            
        }
        public void DecreaseArmorClass(int userInput)
        {
            // decrease Armor class by user input
            ArmorClass -= userInput;
        }
        public void IncreaseArmorClass(int userInput)
        {
            // increase Armor class by user input
            ArmorClass += userInput;
        }
        public void Attacked()
        {
  
            if (ArmorClass > 25)
            {
                Console.WriteLine("You missed your attack...");
            }
            else
            {
                Console.WriteLine("You were able to hit the killer Robot");
                HitPoints -= 5;
            }
            

        }
        public void Block()
        {
            if (ArmorClass > 20 )
            {
                Console.WriteLine("You blocked the Killer Robots attack!");
            }
            else
            {
                Console.WriteLine("The Killer Robot Hit you!");
                Thread.Sleep(1000);
                HitPoints -= 5;
            }
        }
        public void Run()
        {
            if (Speed > 30)
            {
                Console.WriteLine("You Got away!");
            }
            else
            {
                Console.WriteLine("You can't get away! Help!");
            }
        }
    }
}
