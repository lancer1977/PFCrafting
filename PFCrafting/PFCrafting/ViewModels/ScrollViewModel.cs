using PFAssistant.Core.Crafting;
using PFCrafting.ViewModels;
using PolyhydraGames.Pathfinder.Data.Properties;

namespace PFAssistant.Core.ViewModels.Crafting
{
    public class ScrollViewModel
        : CasterCraftingCostViewModel
    {
        public ScrollViewModel()
        {
        Title = (Resource1.ScrollCraftTitle);
    }
        


        protected override int TimeCalculator()
        {
            return ScrollCreation.ScrollTime(BaseItemCost);
        }

        protected override void CalculateCraftItemCost()
        {
            CraftItemCost = ScrollCreation.ScrollCraftCost(SpellLevel, CasterLevel);
        }

        protected override void CalculateBaseItemCost()
        {
            BaseItemCost = ScrollCreation.ScrollBaseCost(SpellLevel, CasterLevel);
        }
    }
}