using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTabs
{
    /// <summary>
    /// Class MenuItem.
    /// </summary>
    public class MenuItem : ObservableObject
    {
        public string Text { get; set; }

        public View Value { get; set; }

    }
}
