namespace AnimeApi.Model
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Studio { get; set; }
        public string Director { get; set; }
        public int Episodes { get; set; }
        public string Status { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
        public int GenersId { get; set; }
    }
}
