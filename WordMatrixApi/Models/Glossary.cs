namespace WordMatrixApi.Models
{
    public class Glossary
    {
        public string Id { get; set; }
        public string Word { get; set; }

        public short Length { get; set; }

        public string? Theme { get; set; }
    }

}
