 

using PolyhydraGames.Pathfinder.Data.Properties;

namespace PFCrafting.ViewModels
{
    public abstract class CasterCraftingCostViewModel : CraftingCostViewModel
    {
        public CasterCraftingCostViewModel()
        {
            _casterLevel = 1;
            _spellLevel = 0;
        }
        private int _casterLevel;
        private int _spellLevel;

        public int CasterLevel
        {
            get { return _casterLevel; }
            set
            {
                _casterLevel = value;
                RaisePropertyChanged( );
                CalculateBaseItemCost();
            }
        }

        public int SpellLevel
        {
            get { return _spellLevel; }
            set
            {
                _spellLevel = value;
                RaisePropertyChanged( );
                CalculateBaseItemCost();
            }
        }

        public string CasterLevelTitle => Resource1.CasterLevelTitle;

        public string SpellLevelTitle => Resource1.SpellLevelTitle;
   

 
    }
}