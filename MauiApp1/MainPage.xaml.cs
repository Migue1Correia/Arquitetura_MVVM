using MauiApp1.ViewModels;

namespace MauiApp1
{ 
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Aqui é o Plug da View com o ViewModel.

            BindingContext = new MainViewModel();

        }

    }
     
}
