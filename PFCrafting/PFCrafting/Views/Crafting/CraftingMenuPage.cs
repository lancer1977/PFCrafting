using Xamarin.Forms;

namespace PFCrafting.Views.Crafting
{
    public class CraftingMenuPage : ContentPage
    {
        public CraftingMenuPage()
        {
            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform<int>(20, 0, 0), 0, 0),
                //Children =
                //{
                //    new SlidingTrayButton<ArmorViewModel>(),
                //    new SlidingTrayButton<WeaponViewModel>(),
                //     new SlidingTrayButton<PotionViewModel>(),
                //    new SlidingTrayButton<ScrollViewModel>(),
                //     new SlidingTrayButton<WandViewModel>()
                //}
            };
           Title = "Menu";
            BackgroundColor = Color.Gray.WithLuminosity(0.2); 
            Icon = Device.OS == TargetPlatform.iOS ? "Icon.png" : null;
        }
    }
}
