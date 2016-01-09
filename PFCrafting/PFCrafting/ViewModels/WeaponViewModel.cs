using System.Collections.Generic;
using System.Linq;
using PFAssistant.Core.Crafting;
using PFAssistant.Core.ViewModels.Crafting.Abstracts;
using PolyhydraGames.Core.IOC;
using PolyhydraGames.Pathfinder.Data.Services.Weapon;

namespace PFAssistant.Core.ViewModels.Crafting
{
    public class WeaponViewModel
        : MundaneCraftingCostViewModel
    {
        private readonly IWeaponDataService _weaponService;

        public WeaponViewModel(IWeaponDataService weaponService)
        {
            _weaponService = weaponService;
            Title = "Weapon";
        }

        public override List<string> ItemNames => _weaponService.Names().ToList();
    
 
        public override string ItemNameTitle => "Weapon Type";
        protected override int TimeCalculator()
        { 
            return ArmsCreation.ArmsAndArmorTime(BaseItemCost);
        }

        protected override void CalculateCraftItemCost()
        {
            CraftItemCost = BaseItemCost/2;
        }

        protected override void CalculateBaseItemCost()
        {
            BaseItemCost = ArmsCreation.ArmsCraftCost(TotalBonus, RegularCost);
        }

        protected override void CalculateRegularCost()
        {
            RegularCost = _weaponService.Item(SelectedItem).CostGold();
        }
    }
}