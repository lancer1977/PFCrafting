using System.Windows.Input;
using PolyhydraGames.Core.Forms.Helpers;
using PolyhydraGames.Core.ViewModel;
using PolyhydraGames.Extensions;

namespace PFAssistant.Core.ViewModels.Crafting
{
    public class StaffItemViewModel : ViewModelBase 
    {
        private static int _lastSlot;
        private int _casterLevel;
        private int _chargeCost;
        private string _name;
        private int _spellLevel;

        public StaffItemViewModel()
        {
            Title = "Staff Crafting";
        CasterLevel = 1;
            SpellLevel = 0;
            ChargeCost = 1;
            Number = _lastSlot + 1;
            _lastSlot = Number;
        }

        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value); }
        }

        public ICommand GoDeleteItem
        {
            get { return CommandExtensions.ToCommand(() => RaisePropertyChanged("Delete")); }
        }

        public int Number { get; }

        public int CasterLevel
        {
            get { return _casterLevel; }
            set
            {
                if (value.Between(1, 20) && SetValue(ref _casterLevel,value)) 
                    AnnounceCostChange();
            }
        }

        public int ChargeCost
        {
            get { return _chargeCost; }
            set
            {
                if (value.Between(1, 10) && SetValue(ref _chargeCost, value))
                    AnnounceCostChange(); 
            }
        }

        public int Id { get; set; }

        public int SpellLevel
        {
            get { return _spellLevel; }
            set
            {
                if (value.Between(1, 9) && SetValue(ref _spellLevel, value))
                    AnnounceCostChange();
            }
        }

        public int CalculateCost(int i)
        {
            return (CasterLevel*SpellLevel*i)/ChargeCost;
        }

        public void AnnounceCostChange()
        {
            RaisePropertyChanged("AnnounceCostChange");
        }

        public override string ToString()
        {
            return "CL:" + CasterLevel + " SL:" + SpellLevel + " CC:" + ChargeCost +
                   " Calc400:" + CalculateCost(400);
        }

     
    }
}