namespace RssSample
{
    public class NewsItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime PubDate { get; set; }
        public string Author { get; internal set; }
        public string ImageUrl { get; internal set; }
    }
}
