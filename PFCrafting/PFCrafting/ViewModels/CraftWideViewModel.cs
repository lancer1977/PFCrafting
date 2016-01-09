using PFAssistant.Core.ViewModels.Crafting;
using PolyhydraGames.Core.IOC;
using PolyhydraGames.Core.ViewModel;

namespace PFCrafting.ViewModels
{
    public class CraftWideViewModel : ViewModelBase
    {
        private ArmorViewModel _armorViewModel;
        private PotionViewModel _potionViewModel;
        private ScrollViewModel _scrollViewModel; 
        private WandViewModel _wandViewModel;
        private WeaponViewModel _weaponViewModel;

        public WeaponViewModel WeaponViewModel
            => _weaponViewModel ?? (_weaponViewModel = IOC.Get<WeaponViewModel>());

        public ArmorViewModel ArmorViewModel
            => _armorViewModel ?? (_armorViewModel = IOC.Get<ArmorViewModel>());

        public ScrollViewModel ScrollViewModel
            => _scrollViewModel ?? (_scrollViewModel = IOC.Get<ScrollViewModel>());

        public PotionViewModel PotionViewModel
            => _potionViewModel ?? (_potionViewModel = IOC.Get<PotionViewModel>());

        public WandViewModel WandViewModel
            => _wandViewModel ?? (_wandViewModel = IOC.Get<WandViewModel>());

        //public StaffViewModel StaffViewModel
        //    => _staffViewModel ?? (_staffViewModel = IOC.Get<StaffViewModel>());
 

      
    }
}