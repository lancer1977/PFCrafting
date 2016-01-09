using System.Collections.Generic;
using PFAssistant.Core.ViewModels.Crafting;

namespace PFCrafting.ViewModels
{
    public   class CraftMenuViewModel : PolyhydraGames.Core.ViewModel.ViewModelBase
    {
        public CraftMenuViewModel()
        {
            Title = "Crafting Menu";
            // _Character = new Character(service);
            MenuItems = new List<MenuItem>
            {
                new MenuItem("Weapon Forge", typeof (WeaponViewModel)),
                new MenuItem("Armor Forge", typeof (ArmorViewModel)),
                new MenuItem("Wand Table", typeof (WandViewModel)),
                new MenuItem("Potion Table", typeof (PotionViewModel)),
                new MenuItem("Scroll Table", typeof (ScrollViewModel)),
              //  new MenuItem("Staff Table", typeof (StaffViewModel))
            };
        }

        public List<MenuItem> MenuItems { get; private set; }
         

     
    }
}