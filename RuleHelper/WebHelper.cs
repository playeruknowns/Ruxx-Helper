using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace RuleHelper
{
    public class WebHelper
    {
        private readonly HttpClient _httpClient;

        public WebHelper()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
        }

        public WebHelper(Func<HttpRequestMessage, X509Certificate2?, X509Chain?, SslPolicyErrors, bool>? serverCertificateCustomValidationCallback)
        {
            serverCertificateCustomValidationCallback ??= (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = serverCertificateCustomValidationCallback
            };
            _httpClient = new HttpClient(handler);
        }

        public async Task<Stream> GetStreamAsync(string url)
        {
            if (string.IsNullOrEmpty(url) ||
                !Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                return Stream.Null;

            return await _httpClient.GetStreamAsync(url);
        }

        protected Task<string> GetHtmlAsync(string url)
        {
            return string.IsNullOrEmpty(url) ? 
                Task.Run(() => string.Empty) : _httpClient.GetStringAsync(url);
        }

        protected async Task<bool> TryDownloadFileAsync(string url, string path, string? fileName = null)
        {
            if (string.IsNullOrEmpty(fileName))
                fileName = DateTime.Now.ToString("yyyyMMddHHmmssfffff") + ".png";

            if (string.IsNullOrEmpty(url)  || 
                string.IsNullOrEmpty(path) ||
                Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                return false;

            byte[]? bytes = default;
            try
            {
                bytes = await _httpClient.GetByteArrayAsync(url);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            if (bytes == null)
                return false;

            // 이미지 byte 배열을 실제 파일로 저장.
            string fullName = Path.Join(path, fileName);
            if (fullName.Length > 255)
                return false;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            File.WriteAllBytes(fullName, bytes);

            return true;
        }
    }
}
