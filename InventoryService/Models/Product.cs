namespace InventoryService.Models
{
    public class Product
    {
        public int Id { get; set; }

        // Nome do produto deve ser obrigatório
        public required string Nome { get; set; }
        // Descrição pode ser opcional
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
