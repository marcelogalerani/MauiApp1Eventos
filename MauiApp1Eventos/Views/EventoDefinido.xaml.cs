using Microsoft.Maui.Platform;

namespace MauiApp1Eventos.Views;

public partial class EventoDefinido : ContentPage
{
	public EventoDefinido(string valor1, string valor2, int valor3, double valor4, DateTime valor5, DateTime valor6)
	{
		InitializeComponent();

   		txt_EventoDef.Text = $"Evento: {valor1}";
		txt_LocalDef.Text = $"Local : {valor2}";
				
		TimeSpan diferenca = valor6 - valor5;
		double custoTotal = 0;
		custoTotal = valor3 * valor4;

        difedata.Text = $"A duração do Evento é de {diferenca.Days} dia(s), com valor total de R${custoTotal}.";
						
        BindingContext = new Evento
        {
            Nome = valor1,
            Local = valor2,
            Numero = valor3,
			Valor = valor4,
			Inicio = valor5,
			Termino = valor6		
        };

		lbl_final.Text = $"O evento: {valor1}, com Local na(o) {valor2}, com {valor3}" +
			$" participantes e valor individual de R$ {valor4}, com início em {valor5} e término em {valor6} ";
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

}