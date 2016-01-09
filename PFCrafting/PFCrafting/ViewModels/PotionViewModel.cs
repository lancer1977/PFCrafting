using PFAssistant.Core.Crafting;
using PFCrafting.ViewModels;
using PolyhydraGames.Pathfinder.Data.Properties;

namespace PFAssistant.Core.ViewModels.Crafting
{
    public class PotionViewModel
        : CasterCraftingCostViewModel
    {
        //myFunc = PotionCreation.PotionBaseCost;
        //                    timeFunc = PotionCreation.PotionTime;

        public PotionViewModel()
        {
            Title = Resource1.PotionCraftTitle;
        }
 
    protected override int TimeCalculator()
        {
            return PotionCreation.Time(BaseItemCost);
        }

        protected override void CalculateCraftItemCost()
        {
            CraftItemCost = PotionCreation.CraftingCost(SpellLevel, CasterLevel);
        }

        protected override void CalculateBaseItemCost()
        {
            BaseItemCost = PotionCreation.BaseCost(SpellLevel, CasterLevel);
        }
    }
}