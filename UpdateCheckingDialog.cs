using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualBinaryEditor
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
            catch
            {
                throw;
            }
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        private async Task<ReleasedVersions> GetReleasedUpdatesAsync(CancellationToken token)
        {
            using (HttpResponseMessage response = await client.GetAsync(URL, token))
            {
                string rawJson = await response.Content.ReadAsStringAsync(token);
                using (JsonDocument json = JsonDocument.Parse(rawJson))
                {
                    return AnalyzeJson(json);
                }
            }
        }

        private ReleasedVersions AnalyzeJson(JsonDocument json)
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
