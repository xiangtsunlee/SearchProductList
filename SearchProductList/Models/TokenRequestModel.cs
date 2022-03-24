namespace SearchProductList.Models
{
    //取token
    public class TokenRequest
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string Checksum { get; set; }
    }
}
