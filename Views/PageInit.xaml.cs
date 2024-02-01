using System.Security.Cryptography.X509Certificates;

namespace PM02P01202;

public partial class PageInit : ContentPage
{

    Controllers.PersonasControllers PersonDB;

    public PageInit()
    {
        InitializeComponent();
   

    }
   
    private async void btnprocesar_Clicked(object sender, EventArgs e)
    {
        var person = new Models.Personas

        {

            Nombres = nombres.Text,
            Apellidos = apellidos.Text,
            FechaNac = FechaNac.Date,
            telefono = telefono.Text
        };

        if (await App.Database.StorePerson(person) > 0)
        {

            await DisplayAlert("Aviso", "Registro ingresado con exito!!", "OK");
        }
    }

}



