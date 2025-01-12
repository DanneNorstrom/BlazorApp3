namespace BlazorApp3.Models
{
    public class Machine
    {
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Datato { get; set; } = string.Empty;
        public string Datafrom { get; set; } = string.Empty;
    }
}
