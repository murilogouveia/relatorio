namespace relatorio.Models
{
    public class RelatorioPublicador
    {
        public int Id { get; set; }

        public int PublicadorId { get; set; }

        public Publicador Publicador { get; set; }

        public int RelatorioMensalId { get; set; }

        public RelatorioMensal RelatorioMensal { get; set; }

        public int Publicacoes { get; set; }
        
        public int Videos { get; set; }
        
        public int HorasCampo { get; set; }
        
        public int HorasLDC { get; set; }
        
        public int Revisitas { get; set; }
        
        public int Estudos { get; set; }

        public string Observacoes { get; set; }

    }
}