using System.Linq;
using PolyhydraGames.Core.ViewModel;

namespace PFCrafting.ViewModels
{
    public abstract class CraftingCostViewModel : ViewModelBase
    {
        private int _baseItemCost;
        private int _craftItemCost;
    
   

      


        protected int BaseItemCost
        {
            get { return _baseItemCost; }
            set
            {
                if (!SetValue(ref _baseItemCost, value)) return;
                RaisePropertyChanged("BaseCost");
                CalculateCraftItemCost();
            }
        }

 


        protected int CraftItemCost
        {
            get { return _craftItemCost; }
            set
            {
                if (!SetValue(ref _craftItemCost, value)) return;
          
                RaisePropertyChanged("CraftingCost");
                RaisePropertyChanged("CraftingTime");
            }
        }

     

        public virtual string BaseCost => $"{BaseItemCost} Gold";

        public virtual string CraftingCost => $"{CraftItemCost} Gold";

        public virtual string CraftingTime => $"{TimeCalculator()} Hours";

        //public static Dictionary<string, int> BonusRange { get { return _bonusRange; } }
        public static string[] BonusOptionsStatic => new[]
        { 
            "Masterwork",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10"
        };

        public string[] BonusOptions => BonusOptionsStatic;

        //  public int[] BonusRange { get { return Enumerable.Range(0, 10).ToArray(); } }
        public int[] CasterLevelOptions => Enumerable.Range(1, 20).ToArray();

        public int[] SpellLevelOptions => Enumerable.Range(0, 10).ToArray();

        public string BaseCostTitle => "Base Cost";

        public string CraftCostTitle => "Crafted Cost";

        public string CraftTimeTitle => "Crafting Time";

        protected abstract int TimeCalculator(); //Returns time calculation
        protected abstract void CalculateCraftItemCost(); //Sets CraftItemCost
        protected abstract void CalculateBaseItemCost(); //Sets BaseItemCost

 
    }
}