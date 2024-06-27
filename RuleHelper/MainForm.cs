
namespace RuleHelper
{
    public partial class frmMain : Form
    {
        private string _baseUrl = string.Empty;

        private Size ThumbnailSize = new Size(128, 128);

        public frmMain()
        {
            InitializeComponent();

            spcImage.SplitterDistance = 1;

            ImglThumbnail.Dispose();
            ImglThumbnail = new ImageList();
            ImglThumbnail.ImageSize = new Size(128, 128);

            lstvThumbnail.View = View.LargeIcon;
            lstvThumbnail.LargeImageList = ImglThumbnail;
        }

        /// <summary>
        /// Search 버튼을 클릭했을 때 발생하는 이벤트
        /// Url 텍스트 박스에 입력한 url을 탐색한 후 해당 url에 이미지가 있다면 썸네일 이미지를 받아 리스트뷰를 채운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeachUrl(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text) ||
                !Uri.IsWellFormedUriString(txtUrl.Text, UriKind.RelativeOrAbsolute))
                return;

            // set base url
            int pid = txtUrl.Text.LastIndexOf("&pid=");
            if (pid != -1)
                _baseUrl = txtUrl.Text.Substring(0, pid);
            else
                _baseUrl = txtUrl.Text;

            // 썸네일 / 페이지 설정
            SetThumbnail(txtUrl.Text);
            SetPagination();
        }

        /// <summary>
        /// 리스트뷰에서 아이템을 클릭하면 발생하는 이벤트
        /// 우측의 이미지 뷰어에서 썸네일 이미지를 크게 볼 수 있다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayDetailImage(object sender, EventArgs e)
        {
            if (lstvThumbnail.SelectedItems.Count == 0)
                return;

            string? page = lstvThumbnail.SelectedItems[0].Tag as string;
            if (string.IsNullOrEmpty(page))
                return;

            Task.Run(async () =>
            {
                string imageSrc = await RuxxHelper.Instance.GetDetailImageLink(page);

                using Stream imageStream = await RuxxHelper.Instance.GetStreamAsync(imageSrc);

                Image image = Image.FromStream(imageStream);

                Invoke((Action)(() =>
                {
                    picbDetailImage.Image?.Dispose();
                    picbDetailImage.Image = image;
                }));
            });
        }

        /// <summary>
        /// 페이지를 선택하는 콤보박스에서 페이지를 선택했을 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectPageIndex(object sender, EventArgs e)
        {
            if (cmbGotoPage.Items.Count == 0)
                return;

            string newUrl = $"{_baseUrl}&pid={cmbGotoPage.SelectedIndex * 42}";
            SetThumbnail(newUrl);
        }

        /// <summary>
        /// 썸네일을 표시한다.
        /// </summary>
        private void SetThumbnail(string url)
        {
            if (string.IsNullOrEmpty(url) ||
                !Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                return;

            // 썸네일 초기화
            lstvThumbnail.Items.Clear();
            ImglThumbnail.Images.Clear();

            Task.Run(async () =>
            {
                // 썸네일 표시
                string[] thumbs = await RuxxHelper.Instance.GetThumbnailLinks(url);
                string[] details = await RuxxHelper.Instance.GetDetailPageLinks(url);
                for (int i = 0; i < thumbs.Length; i++)
                {
                    string thumbUrl = thumbs[i];
                    string detailPageUrl = details[i];

                    using Stream thumbStream = await RuxxHelper.Instance.GetStreamAsync(thumbUrl);
                    using Image original = Image.FromStream(thumbStream);
                    using Image thumb = CreateThumbnail(original, ThumbnailSize.Width, ThumbnailSize.Height);

                    Invoke((Action)(() =>
                    {
                        ImglThumbnail.Images.Add(thumb);

                        ListViewItem item = new ListViewItem()
                        {
                            ImageIndex = i,
                            Text = (i + 1).ToString(),
                            Tag = detailPageUrl
                        };
                        lstvThumbnail.Items.Add(item);
                    }));
                }
            });
            //}, _setThumbCancel.Token);
        }

        /// <summary>
        /// 페이지를 설정한다.
        /// </summary>
        private void SetPagination()
        {
            Task.Run(async () =>
            {
                // 페이지 표시
                int lastImageIndex = await RuxxHelper.Instance.GetLastPageIndex(txtUrl.Text);
                int pageCount = lastImageIndex / 42 + 1;
                object[] pages = Enumerable.Range(1, pageCount).Cast<object>().ToArray();

                Invoke((Action)(() =>
                {
                    txtpagination.Text = $"[page] {1}-{pageCount}";
                    txtGotoPage.Text = "1";
                    cmbGotoPage.Items.Clear();
                    cmbGotoPage.Items.AddRange(pages);
                }));
            });
        }

        private Image CreateThumbnail(Image image, int thumbWidth, int thumbHeight)
        {
            int width, height;
            if (image.Width > image.Height)
            {
                width = thumbWidth;
                height = (image.Height * thumbWidth) / image.Width;
            }
            else
            {
                height = thumbHeight;
                width = (image.Width * thumbHeight) / image.Height;
            }

            Image thumbnail = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(thumbnail))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }

            return thumbnail;
        }
    }
}
