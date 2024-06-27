using System.Net;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace RuleHelper
{
    public class RuxxHelper : WebHelper
    {
        #region SINGLETON
        private static RuxxHelper _instance;
        public static RuxxHelper Instance
        {
            get
            {
                _instance ??= new RuxxHelper();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        #endregion

        private const string LINK_BASE = @"https://rule34.xxx";

        private RuxxHelper() { }

        /// <summary>
        /// 썸네일 이미지 링크를 배열로 반환한다.
        /// </summary>
        /// <param name="url">ruxx에서 검색을 하고 난 직후 나오는 페이지의 url</param>
        /// <returns>썸네일 이미지의 링크 배열</returns>
        public async Task<string[]> GetThumbnailLinks(string url)
        {
            HtmlDocument htmlDoc = await GetHtmlDocument(url);

            var imageList = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='image-list']");
            var imageNodes = imageList?.SelectNodes("span/a/img");

            if (imageNodes == null)
                return Array.Empty<string>();

            return imageNodes.Select(x => x.GetAttributeValue("src", "")).ToArray();
        }

        /// <summary>
        /// 원본 이미지 페이지의 링크를 배열로 반환한다.
        /// </summary>
        /// <param name="url">ruxx에서 검색을 하고 난 직후 나오는 페이지의 url</param>
        /// <returns>원본 이미지 페이지의 링크 배열</returns>
        public async Task<string[]> GetDetailPageLinks(string url)
        {
            HtmlDocument htmlDoc = await GetHtmlDocument(url);

            var imageList = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='image-list']");
            var imageNodes = imageList?.SelectNodes("span/a");

            if (imageNodes == null)
                return Array.Empty<string>();

            return imageNodes.Select(x => LINK_BASE + x.GetAttributeValue("href", "")).ToArray();
        }

        /// <summary>
        /// 원본 이미지 링크를 반환한다.
        /// </summary>
        /// <param name="url">원본 이미지 페이지 url</param>
        /// <returns>원본 이미지 url</returns>
        public async Task<string> GetDetailImageLink(string url)
        {
            return (await GetHtmlDocument(url))
                .DocumentNode
                .SelectSingleNode("//img[@id='image']")
                .GetAttributeValue("src", "");
        }

        /// <summary>
        /// 검색한 url의 가장 마지막 인덱스를 반환한다.
        /// Ruxx에서 검색했을 시 페이지 하단에 해당하는 이미지가 얼마나 있는지 확인할 수 있지 않은가? 그 것이다.
        /// </summary>
        /// <param name="url">검색할 url</param>
        /// <returns>검색어의 마지막 인덱스</returns>
        public async Task<int> GetLastPageIndex(string url)
        {
            string lastPageUrl = (await GetHtmlDocument(url)).DocumentNode.SelectSingleNode("//div[@class='pagination']")
                .SelectNodes("a")
                .Last().GetAttributeValue("href", "");

            string lastIndex = lastPageUrl.Split('=').Last();

            if (int.TryParse(lastIndex, out int index))
                return index;
            return -1;
        }

        [Obsolete]
        /// <summary>
        /// 테스트용도로 생성한 메서드
        /// </summary>
        /// <returns></returns>
        private async Task<string[]> GetImageLinksAsync()
        {
            string aurora_url = @"https://rule34.xxx/index.php?page=post&s=list&tags=aurora_%28league_of_legends%29";
            string html = await GetHtmlAsync(aurora_url);
            
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var imageList = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='image-list']");
            var imageNodes = imageList.SelectNodes("span/a");
            int count = 1;
            foreach (var image in imageNodes)
            {
                string detailImagePageLink = LINK_BASE + image.GetAttributeValue("href", "");
                string detailPageHtml = await GetHtmlAsync(detailImagePageLink);

                HtmlDocument detailPageHtmlDoc = new HtmlDocument();
                detailPageHtmlDoc.LoadHtml(detailPageHtml);

                var imageSrcBase = detailPageHtmlDoc.DocumentNode.SelectSingleNode("//img[@id='image']");
                string src = imageSrcBase.GetAttributeValue("src", "");
                
                await Task.Run(async () =>
                {
                    await TryDownloadFileAsync(src, "D:\\_ruxx");
                    Console.WriteLine($"다운로드 완료!![{count++}/{imageNodes.Count}] :: {src}");
                });
            }

            return Array.Empty<string>();
        }

        /// <summary>
        /// url에 대한 HtmlDocument를 반환한다.
        /// </summary>
        /// <param name="url">Html을 탐색할 url</param>
        /// <returns>url에 대한 HtmlDocument 객체</returns>
        private async Task<HtmlDocument> GetHtmlDocument(string url)
        {
            string html = await GetHtmlAsync(url);
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            
            return htmlDocument;
        }
    }
}
