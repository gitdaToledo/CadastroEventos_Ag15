namespace CadastroEventos.Models
{
    public class Contratacao
    {
        public string Evento { get; set; }
        public Local EnderecoSelecionado {  get; set; }
        public int QttAdultos { get; set; }

        public int Qttcrianca { get; set; }

        public TimeSpan HrInicioSelecionada { get; set; }

        public TimeSpan HrFinalSelecionada { get; set; }

        public DateTime DataSelecionada { get; set; }


       public double ValorTotal
        {
            get
            {
                double ValorAdultos = QttAdultos * EnderecoSelecionado.ValorAdultos;
                double Valorcrianca = Qttcrianca * EnderecoSelecionado.Valorcrianca;

                double total = (ValorAdultos + Valorcrianca);

                return total;
            }
        }

    }
}
