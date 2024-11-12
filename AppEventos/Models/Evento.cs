using System.Globalization;

namespace AppEventos.Models
{
    public class Evento
    {
        public string nomeEvento { get; set; }
        public int numeroParticipantes { get; set; }
        public string localEvento { get; set; }
        public double custoParticipante { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public string duracao
        {
            get
            {
                TimeSpan diferenca = DataCheckOut - DataCheckIn;
                string data = diferenca.Days.ToString();
                return data;
            }
        }

        public double total
        {
            get
            {
                double valor_total = numeroParticipantes * custoParticipante;

                return valor_total;
            }
        }
    }
}