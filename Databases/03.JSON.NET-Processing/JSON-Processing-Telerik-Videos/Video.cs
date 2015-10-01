namespace JSON_Processing_Telerik_Videos
{
    using Newtonsoft.Json;

    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }

        [JsonProperty("published")]
        public string Date { get; set; }

    }
}
