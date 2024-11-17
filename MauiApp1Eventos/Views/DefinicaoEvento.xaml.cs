namespace MauiApp1Eventos.Views;

public partial class DefinicaoEvento : ContentPage
{
    public DefinicaoEvento()
    {
        InitializeComponent();

                
    }

   // protected override void OnAppearing()
  //  {
    //    base.OnAppearing();
    //    SecureStorage.Default.RemoveAll();
    //    SecureStorage.Default.SetAsync("dados3","0");
    //    SecureStorage.Default.SetAsync("dados4", "0");

  //  }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string dados1 = txt_evento.Text;
            string dados2 = txt_local.Text;
            int dados3 = Convert.ToInt16(txt_participantes.Text);
            double dados4 = Convert.ToUInt16(txt_valor.Text);
            DateTime dados5 = dtpck_inicio.Date;
            DateTime dados6 = dtpck_termino.Date;
       

        await Navigation.PushAsync(new EventoDefinido(dados1,dados2,dados3,dados4,dados5,dados6));
        }
        catch (Exception ex) 
        {
            await DisplayAlert("Ops", ex.Message, "Fechar");
        }
        
    }
}

