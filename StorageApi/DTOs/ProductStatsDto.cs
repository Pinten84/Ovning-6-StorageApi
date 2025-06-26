namespace StorageApi.DTOs
{
    public class ProductStatsDto
    {
        public int TotalCount { get; set; }
        public int TotalInventoryValue { get; set; }
        public double AveragePrice { get; set; }
    }
}