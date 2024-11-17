namespace MauiApp1Eventos.Views;

public partial class EventoDefinido : ContentPage
{
	public EventoDefinido(string valor1, string valor2, int valor3, double valor4, DateTime valor5, DateTime valor6)
	{
		InitializeComponent();

       txt_EventoDef.Text = valor1;
		txt_LocalDef.Text = valor2;
		txt_ParticipantesDef.Text = Convert.ToString(valor3);
		txt_ValorDef.Text = Convert.ToString(valor4);
		txt_InicioDef.Text = Convert.ToString(valor5);
		txt_TerminoDef.Text = Convert.ToString(valor6);

		
		TimeSpan diferenca = valor6 - valor5;

	//	difedata.Text = Console.WriteLine($"Diferença: {diferenca.Days}");

        BindingContext = new Evento
        {
            Nome = valor1,
            Local = valor2,
            Numero = valor3,
			Valor = valor4,
			Inicio = valor5,
			Termino = valor6
		//	Diferenca = ((Convert.ToInt16(valor6)) - (Convert.ToInt16(valor5)))
        };

		lbl_final.Text = $"O evento: {valor1} localizado na {valor2} com {valor3} participantes e valor {valor4}.. ";

    }


	protected async override void OnAppearing()
	{
		base.OnAppearing();

		string dados1 = await SecureStorage.Default.GetAsync("txt_evento");
        string dados2 = await SecureStorage.Default.GetAsync("dados2");
        string dados3 = await SecureStorage.Default.GetAsync("dados3");
		double particFinal = double.Parse(dados3);
        string dados4 = await SecureStorage.Default.GetAsync("dados4");
        double valorFinal = double.Parse(dados4);
		double resultado = particFinal * valorFinal;

		//LBLresultado.Text = "O evento " + dados1 + " localizado na " + dados2 +
		//	"com " + particFinal + " participantes " + valorFinal + "total" +  resultado;

    }
	
}
public class Evento
{
    public string Nome { get; set; }
    public string Local { get; set; }
    public int Numero { get; set; }
	public double Valor { get; set; }
	public DateTime Inicio { get; set; }
	public DateTime Termino { get; set; }
//	public int Diferenca { get; set; }


}