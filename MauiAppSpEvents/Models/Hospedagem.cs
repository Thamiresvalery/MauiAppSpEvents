namespace MauiAppSpEvents.Models
{
    public class Hospedagem
    {
        public Evento ShowSelecionado { get; set; }
        public Evento LocalEvento { get; set; }
        public int QntMulher {  get; set; }
        public int QntHomem {  get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }

        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_mulher = QntMulher * ShowSelecionado.ValorDiariaMulher;
                double valor_homem = QntHomem * ShowSelecionado.ValorDiariaHomem;

                double total = (valor_mulher +  valor_homem) * Estadia;

                return total;
            }
        }
    }
}
