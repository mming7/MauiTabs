using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiTabs.Views;

namespace MauiTabs
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty] private List<MenuItem>? _menuItems;
        [ObservableProperty] private MenuItem? _selected;

        public MainPageViewModel()
        {
            MenuItems = new List<MenuItem>
        {
            new MenuItem { Text = "Detail", PageType = typeof(DetailPage) },
            new MenuItem { Text = "Units", PageType = typeof(UnitsPage) },
            new MenuItem { Text = "SpSit", PageType = typeof(SpSitPage) }
        };

            Selected = MenuItems[0];
        }

        partial void OnSelectedChanged(MenuItem? value)
        {
            // Load the selected page dynamically
            if (value?.PageType != null)
            {
                var page = Activator.CreateInstance(value.PageType) as ContentPage;
                SelectedPageContent = page?.Content;
            }
        }

        [ObservableProperty]
        private View? _selectedPageContent;
    }

}