namespace SearchProductList.Models
{
    //token回傳
    public class TokenModel
    {
        public Token? Data { get; set; }
        public string? rDesc { get; set; }
        public string? rCode { get; set; }
        public DateTime TokenExpires { get; set; }
    }
    public class Token
    {
        public string? AccessToken { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ExpireDateTime { get; set; }
    }
}
