namespace SearchProductList.Tool
{
    public class Setting
    {
        private static IConfiguration Configuration { get; set; }

        static Setting()
        {
            Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        }

        public static string ApiKey { get { return Configuration.GetSection("Setting:ApiKey").Value; } }
        public static string RoadUrl { get { return Configuration.GetSection("Setting:RoadUrl").Value; } }
        public static string ApiSecret { get { return Configuration.GetSection("Setting:ApiSecret").Value; } }
        public static string AuthToken { get { return Configuration.GetSection("Setting:AuthToken").Value; } }
        public static string ActionData { get { return Configuration.GetSection("Setting:ActionData").Value; } }
        public static string SourceJsonString { get { return Configuration.GetSection("Setting:SourceJsonString").Value; } }
    }
}
