using PFAssistant.Core.Crafting;
using PFCrafting.ViewModels;
using PolyhydraGames.Pathfinder.Data.Properties;

namespace PFAssistant.Core.ViewModels.Crafting
{
    public class WandViewModel : CasterCraftingCostViewModel
    { 
        public WandViewModel()
        {
            Title = Resource1.WandCraftTitle;
        }
        protected override int TimeCalculator()
        {
            return WandCreation.WandTime(BaseItemCost);
        }

        protected override void CalculateCraftItemCost()
        {
            CraftItemCost = WandCreation.WandCraftCost(SpellLevel, CasterLevel);
        }

        protected override void CalculateBaseItemCost()
        {
            BaseItemCost = WandCreation.WandBaseCost(SpellLevel, CasterLevel);
        }
    }
}