using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Views : ContentPage
    {
        public Views()
        {
            InitializeComponent();
            dtpFecha.MinimumDate = new DateTime(1950, 2, 15);
            dtpFecha.DateSelected += DtpFecha_DateSelected;
            edComentario.Completed += EdComentario_Completed;

        }

        private void EdComentario_Completed(object sender, EventArgs e)
        {
            DisplayAlert("Finalizado", "Terminado de editar", "Listo");
        }

        private void DtpFecha_DateSelected(object sender, DateChangedEventArgs e)
        {

            DisplayAlert("Fecha", e.NewDate.ToString(), "aceptar");
        }

        private void BtnEnviarClicked(object sender, EventArgs args)
        {
            DisplayAlert("Ingreso", "Bienvenido", "Aceptar");
        }

    }
}