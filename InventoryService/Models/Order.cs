namespace InventoryService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        // Status do pedido (obrigatório)
        public required string Status { get; set; } = "Pendente";

        public decimal ValorTotal { get; set; }

        // Inicializamos a coleção para não dar null
        public ICollection<OrderItem> Itens { get; set; } = new List<OrderItem>();
    }
}
