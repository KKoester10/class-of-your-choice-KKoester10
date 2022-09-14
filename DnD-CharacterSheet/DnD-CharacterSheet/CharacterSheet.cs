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
        public Dictionary<String,int> Inventory{ get; set; }
        public int HitPoints { get; set; }
        public int Speed { get; set; }
        public int Experiance { get; set; }

        public CharacterSheet()
        {
            
        }

        public void AddItemToInventory(string item , int amount)
        {
            // Add items to inventory
           // Inventory.Add(item, amount);
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
        public void Attack()
        {
            // attack will be - 5 points from bots health

        }
        public void Block()
        {
            if (ArmorClass > 20 )
            {
                Console.WriteLine("You blocked the Robots attack!");
            }
            else
            {
                Console.WriteLine("Robot Hit you!");
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
