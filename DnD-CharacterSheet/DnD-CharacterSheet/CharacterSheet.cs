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

        public CharacterSheet()
        {

        }

        public void AddItemToInventory()
        {
            Inventory.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        public void RemoveItemFromInventory()
        {
            
        }
        public void DecreaseArmorClass()
        {

        }
        public void IncreaseArmorClass()
        {

        }
        public void AttackBot()
        {
          
        }
    }
}
