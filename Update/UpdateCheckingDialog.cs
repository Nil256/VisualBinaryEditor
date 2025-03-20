using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualBinaryEditor.Utils;

namespace VisualBinaryEditor.Update
{
    public partial class UpdateCheckingDialog : Form
    {
        private const string URL = "https://api.github.com/repos/Nil256/VisualBinaryEditor/releases";
        private static readonly HttpClient client;

        static UpdateCheckingDialog()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "VisualBinaryEditor UpdateCheck");
        }

        private CancellationTokenSource? cancellationTokenSource;

        internal ReleasedVersions Versions { get; private set; }

        public UpdateCheckingDialog()
        {
            InitializeComponent();
            Versions = new ReleasedVersions();
        }

        private void button_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        private async void UpdateCheckingDialog_Load(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            try
            {
                Versions = await GetReleasedUpdatesAsync(cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }
            catch (HttpRequestException httpRequestException)
            {
                string log = $"{DateTime.Now} ({DateTime.UtcNow})\nURL\"{URL}\"の取得に失敗しました。\n以下例外のメッセージとスタックトレース:\n{httpRequestException.ToString()}";
                bool successLogging = Logger.Error(log, out MessageBoxCreater[] failedMessages);
                string message = $"データの取得ができませんでした。\nHTTPステータス: {(int?)httpRequestException.StatusCode}";
                if (successLogging)
                {
                    message += $"\n詳細は{Logger.GetErrorLogFilePath()}を参照してください。";
                }
                MessageBox.Show(message, "GitHubとの通信でエラーが発生しました。", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!successLogging)
                {
                    for (var i = 0; i < failedMessages.Length; i++)
                    {
                        failedMessages[i].ShowDialog();
                    }
                }
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }
            catch
            {
                throw;
            }
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        private static async Task<ReleasedVersions> GetReleasedUpdatesAsync(CancellationToken token)
        {
            using (HttpResponseMessage response = await client.GetAsync(URL, token))
            {
                response.EnsureSuccessStatusCode();
                string rawJson = await response.Content.ReadAsStringAsync(token);
                using (JsonDocument json = JsonDocument.Parse(rawJson))
                {
                    return AnalyzeJson(json);
                }
            }
        }

        private static ReleasedVersions AnalyzeJson(JsonDocument json)
        {
            ReleasedVersions result = new ReleasedVersions();
            JsonElement root = json.RootElement;
            int length = root.GetArrayLength();
            for (var i = 0; i < length; i++)
            {
                JsonElement releaseJsonElement = root[i];
                result.Add(releaseJsonElement);
            }
            return result;
        }
    }
}
