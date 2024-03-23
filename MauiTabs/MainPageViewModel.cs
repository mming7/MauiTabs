using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiTabs.Views;

namespace MauiTabs
{
    public partial class MainPageViewModel : ObservableObject
    {
        
        [ObservableProperty] public List<MenuItem>? menuItems;
        [ObservableProperty] public MenuItem? selected;
        partial void OnSelectedChanged(MenuItem? value)
        {
            Debug.WriteLine($"Selected changed to: {value?.Text}");
        }
        public MainPageViewModel()
        {
            MenuItems = new List<MenuItem>
            {
            new MenuItem { Text = "Detail", Value = new DetailPage().DetailView},
            new MenuItem { Text = "Units", Value = new UnitsPage().UnitsView },
            new MenuItem { Text = "SpSit", Value = new SpSitPage().SpSitView }
            };

            Selected = MenuItems[0];
        }
    }

}