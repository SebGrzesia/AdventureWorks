namespace AdventureWorks.ViewModel
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public bool? MakeFlag { get; set; }
        public string? Color { get; set; }
        public decimal StandardCost { get; set; }
        public decimal PriceDifference { get; set;}

    }
}
