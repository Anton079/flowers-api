namespace flowers_api.Flowers.Dtos
{
    public class DeleteFlowerRequest
    {
        public string Type { get; set; }
        public int? Price { get; set; }
        public int? Rating { get; set; }
    }
}
