namespace Inventory.Models
{
    public class InventoryModel
    {
        public string Cnpj { get; set; }
        public string Ean { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }

        override public string ToString()
        {
            return $"{Cnpj};{Ean};{Descricao};{Quantidade};{Valor};{Status}";
        }
    }

   
}
