namespace projeto3DS.Models
{
    public class Lanche
    {
        public string descricaocurta { get; set; }
        public string descricaodetalhada { get; set; }
        public Boolean em_estoque { get; set; }
        public int lancheId { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string imagemURL { get; set; }
        public string lanchepreferido { get; set; }
        public string imagemminiatura { get; set; }
        public int categoriaId { get; set; }
        public string categoria { get; set; }
    }
}
