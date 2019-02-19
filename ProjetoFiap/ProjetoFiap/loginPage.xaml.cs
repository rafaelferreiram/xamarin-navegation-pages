using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoFiap
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class loginPage : ContentPage
	{
		public loginPage ()
		{
			InitializeComponent ();
            BotaoLogin.Clicked += AbrirMenuClicked;

		}
        public async void AbrirMenuClicked(Object o, EventArgs e) {
            await Navigation.PushAsync(new MainPage());

        }
    }
}