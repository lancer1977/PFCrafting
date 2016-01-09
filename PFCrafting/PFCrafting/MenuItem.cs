using System;
using System.Windows.Input;
using PolyhydraGames.Core.Forms.Helpers;
using PolyhydraGames.Core.Interfaces;
using PolyhydraGames.Core.IOC;

namespace PFCrafting.ViewModels
{
    public class MenuItem
    {
        public MenuItem(string title, Type viewModelType)
        {
            Title = title;
            ViewModelType = viewModelType;
            ShowCommand = CommandExtensions.ToCommand(
                () => IOC.Get<INavigationManager>().ShowViewModel(ViewModelType)
                );
        }

        public string Title { get; private set; }
        public Type ViewModelType { get; }
        public ICommand ShowCommand { get; private set; }
    }
}