using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoFiap
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BotaoSaldo.Clicked += AbrirSaldoClicked;
            BotaoPerfil.Clicked += AbrirPerfilClicked;
            BotaoSair.Clicked += FecharPaginaMain;


        }
        public  void AbrirSaldoClicked(Object o, EventArgs e)
        {
             Navigation.PushAsync(new SaldoPage());

        }
        public async void AbrirPerfilClicked(Object o, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilPage());

        }

        public async void FecharPaginaMain(Object o, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
