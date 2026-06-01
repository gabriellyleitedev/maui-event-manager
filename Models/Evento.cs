using System;

namespace CadastroEventos.Models
{
    public class Evento
    {
        public required string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public required string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        // Diferença entre datas com TimeSpan (Requisito 2)
        public int DuracaoDias
        {
            get
            {
                TimeSpan diferenca = DataTermino.Subtract(DataInicio);
                return Math.Max(1, diferenca.Days); // Garante no mínimo 1 diária/dia
            }
        }

        // Cálculo do custo total (Requisito 1)
        public double CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}