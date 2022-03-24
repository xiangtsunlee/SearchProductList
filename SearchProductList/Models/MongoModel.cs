using MongoDB.Bson.Serialization.Attributes;
using SearchProductList.Tool;

namespace SearchProductList.Models
{
    //記log到MongoDB格式
    public class MongoModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? ApplicationName { get; set; } 
        public string? ActionData { get; set; } 
        public string? SourceJsonString { get; set; } 
        public ProductListModel? ReturnJsonString { get; set; } 
        public Info? Info { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
    public class Info
    {
        public int? HttpCode { get; set; }
        public string? MethodType { get; set; } 
        public string? Token { get; set; }
        public string? ApiKey { get; set; } = Setting.ApiKey;
    }
}
