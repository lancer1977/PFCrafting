using PFCrafting.ViewModels;
using Xamarin.Forms;

namespace PFCrafting.Views.Crafting
{
    public partial class ConsumeableAbsoluteView : ContentPage
    {
        private CasterCraftingCostViewModel _model;

        public CasterCraftingCostViewModel Model
        {
            get { return _model; }
        }

        public ConsumeableAbsoluteView(CasterCraftingCostViewModel model)
        {
            InitializeComponent();
            _model = model;

            this.BindingContext = Model;
        }
    }
}
