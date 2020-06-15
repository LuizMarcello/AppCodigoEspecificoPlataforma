using System;

using Xamarin.Forms;

namespace AppCodigoEspecificoPlataforma
{
    public partial class EventosPage : ContentPage
    {
        public EventosPage()
        {
            InitializeComponent();
        }

        int contador;
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button.Text = string.Format("{0} Cliques!",contador++);
        }
    }
}