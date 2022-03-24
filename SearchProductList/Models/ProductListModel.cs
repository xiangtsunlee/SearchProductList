namespace SearchProductList.Models
{
    //ProductList回傳
    public class ProductListModel
    {
        public GetNProductListOutputModel Data { get; set; }
        public string rDesc { get; set; }
        public string rCode { get; set; }
        public DateTime TokenExpires { get; set; }
    }
    public class GetNProductListOutputModel
    {
        /// <summary>
        /// 搜尋產品總數量
        /// </summary>
        public int ListCount { get; set; }
        /// <summary>
        /// 搜尋結果
        /// </summary>
        public List<SearchListElement> SearchList { get; set; }
        /// <summary>
        /// 產品種類
        /// </summary>
        public List<ProductTypeElement> ProductType { get; set; }
        /// <summary>
        /// 產品國家
        /// </summary>
        public List<ProductCountryElement> ProductCountry { get; set; }
        /// <summary>
        /// 產品城市
        /// </summary>
        public List<ProductCityElement> ProductCity { get; set; }
        /// <summary>
        /// 價格區間
        /// </summary>
        public List<PriceIntervalElement> PriceRange { get; set; }
        public class SearchListElement
        {
            /// <summary>
            /// 產品編碼
            /// </summary>
            public string ETID { get; set; }

            /// <summary>
            /// 狀態
            /// </summary>
            public bool IsShelf { get; set; }

            /// <summary>
            /// 牌價幣別
            /// </summary>
            public string BrandCurr { get; set; }

            /// <summary>
            /// 產品名稱
            /// </summary>
            public string ETName { get; set; }

            /// <summary>
            /// 圖檔位置
            /// </summary>
            public string PicUrl { get; set; }

            /// <summary>
            /// 票券類型
            /// </summary>
            public string VoucherType { get; set; }

            /// <summary>
            /// 上架日期(yyyy-MM-ddTHH:mm:ss zzz)
            /// </summary>
            public DateTime LaunchDate { get; set; }

            /// <summary>
            /// 上架時間(HH:mm)
            /// </summary>
            public string LaunchTime { get; set; }

            /// <summary>
            /// 預先曝光
            /// </summary>
            public string AdvanceTime { get; set; }

            /// <summary>
            /// 最早可訂購日期
            /// </summary>
            public string EarliestAllowDate { get; set; }

            /// <summary>
            /// 雄獅推薦 0：正常，1：推薦
            /// </summary>
            public bool LionRecommend { get; set; }

            /// <summary>
            /// 售價幣別
            /// </summary>
            public string SaleCurr { get; set; }

            /// <summary>
            /// 供貨狀態 0：正常，1：前台顯示補貨中
            /// </summary>
            public bool Status { get; set; }

            /// <summary>
            /// 扣量狀態 0：可訂購，1：下單不扣數量
            /// </summary>
            public bool DeductStatus { get; set; }

            /// <summary>
            /// 直客價
            /// </summary>
            public decimal? AMT_D { get; set; }

            /// <summary>
            /// 同業價
            /// </summary>
            public decimal? AMT_W { get; set; }

            /// <summary>
            /// B2E企業價
            /// </summary>
            public decimal? AMT_E { get; set; }

            /// <summary>
            /// 可訂購數量
            /// </summary>
            public int Qty { get; set; }

            /// <summary>
            /// 最低訂購量
            /// </summary>
            public int LowQty { get; set; }

            /// <summary>
            /// 牌價幣別名稱
            /// </summary>
            public string BrandCurrName { get; set; }

            /// <summary>
            /// 牌價價格
            /// </summary>
            public decimal BrandPrice { get; set; }

            /// <summary>
            /// 產品價格
            /// </summary>
            public decimal? ProductPrice { get; set; }

            /// <summary>
            /// 產品E價(B2E) 換成NTD
            /// </summary>
            public decimal? ProductEPrice { get; set; }

            /// <summary>
            /// 雄獅嚴選牌價價格
            /// </summary>
            public decimal NPListPrice { get; set; }

            /// <summary>
            /// 雄獅嚴選產品價格
            /// </summary>
            public decimal NPAmtD { get; set; }

            /// <summary>
            /// 雄獅嚴選連結
            /// </summary>
            public string NPURL { get; set; }

            /// <summary>
            /// 週點擊次數
            /// </summary>
            public int WeekCount { get; set; }

            /// <summary>
            /// 總點擊次數
            /// </summary>
            public int TotalCount { get; set; }

            /// <summary>
            /// 行銷活動
            /// </summary>
            public string Promoting { get; set; }

            /// <summary>
            /// 行銷說明
            /// </summary>
            public string PromoteDescription { get; set; }

            /// <summary>
            /// 搜尋結果標籤
            /// </summary>
            public TagsElement Tags { get; set; }

            /// <summary>
            /// 產品種類(供篩選)
            /// </summary>
            public List<ProductTypeElement> ProductType { get; set; }

            /// <summary>
            /// 產品國家城市(供篩選)
            /// </summary>
            public List<PlaceOriginElement> PlaceOrigin { get; set; }

            /// <summary>
            /// 關鍵字(供篩選)
            /// </summary>
            public List<KeyWordElement> KeyWord { get; set; }

            /// <summary>
            /// 地標商圈行政區域(供篩選)
            /// </summary>
            public List<LandmarkElement> Landmark { get; set; }


            public List<MainBuildingElement> MainBuilding { get; set; }

            public class ProductTypeElement
            {
                /// <summary>
                /// 產品種類
                /// </summary>
                public string WebKind { get; set; }

                /// <summary>
                /// 產品種類名稱
                /// </summary>
                public string WebKindName { get; set; }

                #region .2層式種類.
                /// <summary>
                /// 父種類 Code
                /// </summary>
                public string ParentID { get; set; }
                /// <summary>
                /// 父種類名稱
                /// </summary>
                public string ParentName { get; set; }
                #endregion
            }

            public class PlaceOriginElement
            {
                /// <summary>
                /// 國家縮寫
                /// </summary>
                public string CountryID { get; set; }

                /// <summary>
                /// 國家名稱
                /// </summary>
                public string CountryName { get; set; }

                /// <summary>
                /// 城市縮寫
                /// </summary>
                public string CityID { get; set; }

                /// <summary>
                /// 城市名稱
                /// </summary>
                public string CityName { get; set; }
            }

            public class KeyWordElement
            {
                /// <summary>
                /// 產品關鍵字
                /// </summary>
                public string KeyWord { get; set; }
            }

            public class LandmarkElement
            {
                /// <summary>
                /// 地標商圈行政區國家代碼
                /// </summary>
                public string AreaCountryID { get; set; }

                /// <summary>
                /// 地標商圈行政區城市代碼
                /// </summary>
                public string AreaCityID { get; set; }

                /// <summary>
                /// 區域類別 1：地標，2：商圈，3：行政區
                /// </summary>
                public string AreaType { get; set; }

                /// <summary>
                /// 區域代碼
                /// </summary>
                public string AreaID { get; set; }

                /// <summary>
                /// 區域名稱
                /// </summary>
                public string AreaName { get; set; }
            }

            public class MainBuildingElement
            {
                /// <summary>
                /// 代碼類別
                /// </summary>
                public string Type { get; set; }

                /// <summary>
                /// 主館別、行銷字詞
                /// </summary>
                public string MainID { get; set; }

                /// <summary>
                /// 主館名、行銷字詞
                /// </summary>
                public string MainName { get; set; }

                /// <summary>
                /// 次館別
                /// </summary>
                public string SecondaryID { get; set; }

                /// <summary>
                /// 次館名
                /// </summary>
                public string SecondaryName { get; set; }
            }

            public class TagsElement
            {
                /// <summary>
                /// N天前可免費取消
                /// </summary>
                public string NCancel { get; set; }
                /// <summary>
                /// N天
                /// </summary>
                public string NCanceldays { get; set; }
                /// <summary>
                /// 立即確認
                /// </summary>
                public string InstantConfirm { get; set; }
                /// <summary>
                /// 立即確認值
                /// </summary>
                public bool InsConAnswer { get; set; }
                /// <summary>
                /// 隨遊SUIYO(標籤文字)
                /// </summary>
                public string SuiyoText { get; set; }
                /// <summary>
                /// 是否為隨遊產品
                /// </summary>
                public bool IsSuiyoProd { get; set; }
                /// <summary>
                /// 高鐵聯票方案TAG(bool)
                /// </summary>
                public bool IsTHSR { get; set; }
                /// <summary>
                /// 高鐵聯票方案文字(標籤文字)
                /// </summary>
                public string THSRText { get; set; }
            }
        }
        public class ProductTypeElement
        {
            /// <summary>
            /// 產品種類
            /// 子種類代碼
            /// </summary>
            public string WebKind { get; set; }
            /// <summary>
            /// 產品種類名稱
            /// 子種類名稱
            /// </summary>
            public string WebKindName { get; set; }

            #region .2層式種類.
            /// <summary>
            /// 父種類 Code
            /// 父種類ID
            /// </summary>
            public string ParentID { get; set; }
            /// <summary>
            /// 父種類名稱
            /// </summary>
            public string ParentName { get; set; }
            #endregion
        }
        public class ProductCountryElement
        {
            /// <summary>
            /// 國家縮寫
            /// </summary>
            public string CountryID { get; set; }
            /// <summary>
            /// 國家名稱
            /// </summary>
            public string CountryName { get; set; }
        }
        public class ProductCityElement
        {
            /// <summary>
            /// 城市縮寫
            /// </summary>
            public string CityID { get; set; }
            /// <summary>
            /// 城市名稱
            /// </summary>
            public string CityName { get; set; }
        }
        public class PriceIntervalElement
        {
            /// <summary>
            /// 區間最高價
            /// </summary>
            public int? TopPrice { get; set; }
            /// <summary>
            /// 區間最低價
            /// </summary>
            public int? DownPrice { get; set; }
        }
    }
}
