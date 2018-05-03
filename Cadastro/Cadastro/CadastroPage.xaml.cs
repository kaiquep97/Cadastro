using Cadastro.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cadastro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroPage : ContentPage
	{
		public CadastroPage ()
		{
			InitializeComponent ();
            BindingContext = new CadastroViewModel();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<string>(this, "Mensagem", (msg) => {
                DisplayAlert("Ops!", msg, "OK");
            });
            MessagingCenter.Subscribe<string>(this, "OkButton", (msg) => {
                DisplayAlert("Cadastro", "Cadastro realizado com sucesso!", "OK");
                this.Navigation.PopAsync();
            });
        }
    }
}