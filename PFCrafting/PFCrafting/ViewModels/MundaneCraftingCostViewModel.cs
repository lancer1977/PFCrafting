using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using PFCrafting.ViewModels;
using PolyhydraGames.Core.Forms.Helpers;
using PolyhydraGames.Extensions;
using PolyhydraGames.Pathfinder.Data;

namespace PFAssistant.Core.ViewModels.Crafting.Abstracts
{
    public abstract class MundaneCraftingCostViewModel : CraftingCostViewModel
    {
        private int _regularCost;
        private string _selectedItem;
        private string _selectedSize;
        private int _totalBonus;
        private string _totalBonusText;

        public abstract string ItemNameTitle { get; }
        public int RegularCost
        {
            get { return _regularCost; }
            set
            {
                _regularCost = value;
                RaisePropertyChanged( );
                CalculateBaseItemCost();
            }
        }

        protected int TotalBonus
        {
            get { return _totalBonus; }
            set
            {
                if(SetValue(ref _totalBonus, value)) 
                CalculateBaseItemCost();
            }
        }

        public string TotalBonusText
        {
            get { return _totalBonusText; }
            set
            {
                _totalBonusText = value;
                TotalBonus = BonusOptions.IndexOf(value);
                RaisePropertyChanged();
            }
        }

        public string RegularCostTitle => "Regular Cost";

        public string TotalBonusTitle => "Total Bonus";
         
 

        public abstract List<string> ItemNames { get; }

        public string SelectedItem
        {
            get { return _selectedItem; }

            set
            {
                if (_selectedItem == value) return;
                _selectedItem = value;
                RaisePropertyChanged( );
                CalculateRegularCost();
            }
        }

        public string SelectedSize
        {
            get { return _selectedItem; }

            set
            {
                if (_selectedSize == value) return;
                _selectedSize = value;
                RaisePropertyChanged( );
                CalculateRegularCost();
            }
        }

        public List<string> SizeOptions => GeneralDB.SizeNames.ToList();

        protected abstract void CalculateRegularCost();
    }
}