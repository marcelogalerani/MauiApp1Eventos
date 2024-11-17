namespace MauiApp1Eventos.Models
{
    public class Evento
    {
        public required string txt_evento {  get; set; }
        public required string txtLocal { get; set; }
        public int txt_participantes { get; set; }
        public int txt_valor { get; set; }
        public DateTime dtpck_inicio { get; set; }
        public DateTime dtpck_termino { get; set; }
        
    }
}
