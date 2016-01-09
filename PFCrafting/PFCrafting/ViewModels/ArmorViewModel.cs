using System.Collections.Generic;
using System.Linq;
using PFAssistant.Core.Crafting;
using PFAssistant.Core.ViewModels.Crafting.Abstracts;
using PolyhydraGames.Pathfinder.Data.Services.Armor;

namespace PFCrafting.ViewModels
{
    public class ArmorViewModel
        : MundaneCraftingCostViewModel
    {
        private readonly IArmorService _armorService;

        public ArmorViewModel(IArmorService armorService)
        {
            _armorService = armorService;
            Title = "Armor";
        }

        public override List<string> ItemNames => _armorService.Names().ToList(); 
        public override string ItemNameTitle => "Armor Type";

        protected override int TimeCalculator()
        {
            // myFunc = ArmsCreation.ArmorCraftCost;
            //                    timeFunc = 
            return ArmsCreation.ArmsAndArmorTime(BaseItemCost);
        }

        protected override void CalculateCraftItemCost()
        {
            CraftItemCost = BaseItemCost/2;
        }

        protected override void CalculateBaseItemCost()
        {
            BaseItemCost = ArmsCreation.ArmorCraftCost(TotalBonus, RegularCost);
        }

        protected override void CalculateRegularCost()
        {
            RegularCost = _armorService.Item(SelectedItem).CostGold();
        }
    }
}