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
	public partial class PerfilPage : ContentPage
	{
		public PerfilPage ()
		{
			InitializeComponent ();
            BotaoVoltar.Clicked += FecharPaginaAtual;
            BotaoSair.Clicked += VoltarRoot;
        }
        public async void FecharPaginaAtual(Object o, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        public async void VoltarRoot(Object o, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }



    }
}