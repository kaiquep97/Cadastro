using Cadastro.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cadastro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaPage : ContentPage
	{
        private ListaViewModel vm;

        public ListaPage ()
		{
			InitializeComponent ();
            vm = new ListaViewModel();
            BindingContext = vm;
		}

        private void Gerar_Clicked(object sender,EventArgs e)
        {
            if (vm.GeraRelatorio())
                DisplayAlert("Relatorio", "Lista gerada com sucesso.\n Procure por relatorio.csv em documentos", "OK");
            else
                DisplayAlert("Ops!", "Ocorreu um erro na geração do relatorio","OK");
        }
	}
}