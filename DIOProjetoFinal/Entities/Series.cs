using DIOProjetoFinal.Enums;

namespace DIOProjetoFinal.Entities
{
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
    }
}
