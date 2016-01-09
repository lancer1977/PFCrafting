//using System;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using System.ComponentModel;
//using PFCrafting.ViewModels;

//namespace PFAssistant.Core.ViewModels.Crafting
//{
//    public class StaffViewModel
//        : CraftingCostViewModel

//    {
//        private ObservableCollection<StaffItemViewModel> _staveSpells;

//        public ObservableCollection<StaffItemViewModel> Items
//        {
//            get { return _staveSpells; }
//            set
//            {
//                _staveSpells = value;
//                RaisePropertyChanged( );
//            }
//        }

//        //public override ICommand MenuCommand
//        //{
//        //    get { return CommandExtensions.ToCommand(() => Items.Add(new StaffItemViewModel())); }
//        //}
//        public override string Title => "Staff Crafting";
//        public override void Start ( )
//        {
//            Items = new ObservableCollection<StaffItemViewModel>();
//            _staveSpells.CollectionChanged += StaveSpellsOnCollectionChanged;
//                //(sender, args) => CalculateBaseItemCost();
//            _staveSpells.Add(new StaffItemViewModel {CasterLevel = 5, ChargeCost = 3, SpellLevel = 2});
//            _staveSpells.Add(new StaffItemViewModel {CasterLevel = 4, ChargeCost = 4, SpellLevel = 1});
//        }

//        protected override int TimeCalculator()
//        {
//            return StaveCreation.StaveTime(BaseItemCost);
//        }

//        protected override void CalculateCraftItemCost()
//        {
//            CraftItemCost = BaseItemCost/2;
//        }

//        protected override void CalculateBaseItemCost()
//        {
//            throw new NotImplementedException();
//           // BaseItemCost = StaveCreation.StaveCost(Items);
//        }

//        private void StaveSpellsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
//        {
//            if (e.NewItems != null)
//                foreach (StaffItemViewModel item in e.NewItems)
//                    item.PropertyChanged += StaveSpell_PropertyChanged;

//            if (e.OldItems != null)
//                foreach (StaffItemViewModel item in e.OldItems)
//                    item.PropertyChanged -= StaveSpell_PropertyChanged;
//        }

//        private void StaveSpell_PropertyChanged(object sender, PropertyChangedEventArgs e)
//        {
//            switch (e.PropertyName)
//            {
//                case "AnnounceCostChange":
//                    CalculateBaseItemCost();
//                    break;
//                case "Delete":
//                    _staveSpells.Remove((StaffItemViewModel) sender);
//                    break;
//            }
//        }
//    }
//}