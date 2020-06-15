using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppCodigoEspecificoPlataforma
{
    public partial class EventosExercicio2 : ContentPage
    {
        public EventosExercicio2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Curso de Xamarin Forms","Evento clicked","OK");
        }
    }
}