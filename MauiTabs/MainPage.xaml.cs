namespace MauiTabs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var viewModel = new MainPageViewModel();
            viewModel.Selected = viewModel.MenuItems.FirstOrDefault(m => m.Text == "Detail");
            //BindingContext = new MainPageViewModel();
            BindingContext = viewModel;
        }
    }
}
