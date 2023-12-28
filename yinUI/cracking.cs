using System.Net;
using System.Text;
using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.Readers;

namespace yinUI
{
    public partial class cracking : Form
    {
        public cracking()
        {
            InitializeComponent();
            string input = "79696E204F6D656761202D205075626C69632076312E3020286D6164652062792064657465637469766529";
            SetLabelText(input);

        }

        private void SetLabelText(string input)
        {
            try
            {

                byte[] binaryData = HexStringToByteArray(input);


                string base64String = Convert.ToBase64String(binaryData);


                string finalString = Encoding.UTF8.GetString(Convert.FromBase64String(base64String));

                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                // Do not be a skid
                shadowLabel1.Text = finalString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private byte[] HexStringToByteArray(string hex)
        {

            hex = hex.Replace(" ", "");


            byte[] byteArray = new byte[hex.Length / 2];
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return byteArray;
        }

        private void yinToggle1_CheckedChanged(object sender)
        {
            if (yinToggle1.Checked) // For some reason works better in if statement
            {

                yinToggle2.Checked = false;
                yinToggle3.Checked = false;
                yinToggle4.Checked = false;
                yinTextBox2.Visible = false;
            }
        }

        private void yinToggle2_CheckedChanged(object sender)
        {
            if (yinToggle2.Checked)
            {
         
                yinToggle1.Checked = false;
            }
        }

        private void yinToggle3_CheckedChanged(object sender)
        {
            if (yinToggle3.Checked) // For some reason works better in if statement
            {
                yinTextBox2.Visible = false;
                yinToggle1.Checked = false;
                yinToggle2.Checked = true;
                yinToggle4.Checked = false;
            }

        }

        private void yinToggle4_CheckedChanged(object sender)
        {
            if (yinToggle4.Checked) // For some reason works better in if statement
            {
                yinToggle1.Checked = false;
                yinToggle2.Checked = true;
                yinToggle3.Checked = false;
                yinTextBox2.Visible = true;
            }
            else
            {
                yinTextBox2.Visible = false;
            }

        }

        private void yinTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private readonly string[] commonDomains = {
            "gmail.com", "hotmail.com", "yahoo.com", "outlook.com", "aol.com", "icloud.com",
            "protonmail.com", "yandex.com", "yandex.ru", "mail.com", "zoho.com", "gmx.com",
            "mail.ru", "live.com", "rocketmail.com", "msn.com", "inbox.com", "me.com", "orange.fr","verizon.net","att.net"
        };

        private void yinButton2_Click(object sender, EventArgs e)
        {
            if (yinToggle1.Checked)
            {
                GenerateUserRockYouCombination();
            }
            else if (yinToggle3.Checked)
            {
                GenerateEmailRockYouCombination();
            }
            else if (yinToggle2.Checked && yinToggle4.Checked)
            {
                GenerateEmailRockYouCombination();
            }
        }

        private void GenerateUserRockYouCombination()
        {
            string extractionPath = AppDomain.CurrentDomain.BaseDirectory;


            string userTxtPath = Path.Combine(extractionPath, "user.txt");
            if (!File.Exists(userTxtPath))
            {
                MessageBox.Show("user.txt not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string[] userLines = File.ReadAllLines(userTxtPath);


            string rockYouTxtPath = Path.Combine(extractionPath, "rockyou.txt");
            if (!File.Exists(rockYouTxtPath))
            {
                MessageBox.Show("rockyou.txt not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] rockYouLines = File.ReadAllLines(rockYouTxtPath);

   
            if (!int.TryParse(yinTextBox1.Text, out int linesToGenerate) || linesToGenerate <= 0)
            {
                MessageBox.Show("Please enter a valid positive number in yinTextBox1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var combinations = GenerateCombinations(userLines, rockYouLines, linesToGenerate);

  
            SaveCombinationsToFile(combinations, "user_pass");
        }

        private void GenerateEmailRockYouCombination()
        {
            string extractionPath = AppDomain.CurrentDomain.BaseDirectory;


            string emailTxtPath = Path.Combine(extractionPath, "email.txt");
            if (!File.Exists(emailTxtPath))
            {
                MessageBox.Show("email.txt not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] emailLines = File.ReadAllLines(emailTxtPath);


            string rockYouTxtPath = Path.Combine(extractionPath, "rockyou.txt");
            if (!File.Exists(rockYouTxtPath))
            {
                MessageBox.Show("rockyou.txt not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string[] rockYouLines = File.ReadAllLines(rockYouTxtPath);

  
            if (!int.TryParse(yinTextBox1.Text, out int linesToGenerate) || linesToGenerate <= 0)
            {
                MessageBox.Show("Please enter a valid positive number in yinTextBox1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

  
            var combinations = GenerateEmailCombinations(emailLines, rockYouLines, linesToGenerate);

     
            SaveCombinationsToFile(combinations, "email_pass");
        }

        private string[] GenerateCombinations(string[] userLines, string[] rockYouLines, int linesToGenerate)
        {
            Random random = new Random();
            return Enumerable.Range(0, linesToGenerate)
                .Select(_ => $"{GetRandomLine(userLines, random)}:{GetRandomLine(rockYouLines, random)}")
                .ToArray();
        }

        private string[] GenerateEmailCombinations(string[] emailLines, string[] rockYouLines, int linesToGenerate)
        {
            Random random = new Random();
            string domain = GetDomain();
            if (string.IsNullOrEmpty(domain))
            {
     
                return new string[0];
            }

            return Enumerable.Range(0, linesToGenerate)
                .Select(_ => $"{GetRandomLine(emailLines, random)}{domain}:{GetRandomLine(rockYouLines, random)}")
                .ToArray();
        }

        private string GetDomain()
        {
            if (yinToggle2.Checked && yinToggle4.Checked)
            {
                string customDomain = yinTextBox2.Text.Trim();
   
                if (customDomain.Contains('@'))
                {
                    return customDomain;
                }
                else
                {
                    MessageBox.Show("Invalid custom domain. Please enter a valid domain", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
            else if (yinToggle2.Checked)
            {
                return $"@{GetRandomLine(commonDomains, new Random())}";
            }
            else
            {
                return string.Empty;
            }
        }

        private string GetRandomLine(string[] lines, Random random)
        {
            return lines[random.Next(lines.Length)];
        }

        private void SaveCombinationsToFile(string[] combinations, string fileType)
        {
            string extractionPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = $"combo{DateTime.Now:yyyyMMddHHmmss}-{fileType}.txt";
            string filePath = Path.Combine(extractionPath, fileName);

            try
            {
                File.WriteAllLines(filePath, combinations);
                MessageBox.Show($"Combinations saved to {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving combinations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void yinTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            yin form2 = new yin(); 
            form2.Show(); 
        }

        private void yinButton3_Click(object sender, EventArgs e)
        {
            string extractionPath = AppDomain.CurrentDomain.BaseDirectory;
            string rockYouTxtPath = Path.Combine(extractionPath, "rockyou.txt");


            if (File.Exists(rockYouTxtPath))
            {
                MessageBox.Show("Download stopped. rockyou.txt already found in the directory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string downloadUrl = "https://raw.githubusercontent.com/zacheller/rockyou/master/rockyou.txt.tar.gz";
            string downloadPath = Path.Combine(extractionPath, "rockyou.txt.tar.gz");


            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(downloadUrl, downloadPath);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error downloading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ExtractTarGz(downloadPath, extractionPath);

   
            if (File.Exists(rockYouTxtPath))
            {
                MessageBox.Show("rockyou.txt has been downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                File.Delete(downloadPath);
            }
            else
            {
                MessageBox.Show("rockyou.txt not found after extraction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExtractTarGz(string tarGzFilePath, string destinationPath)
        {
            using (Stream stream = File.OpenRead(tarGzFilePath))
            using (var reader = ReaderFactory.Open(stream))
            {
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        reader.WriteEntryToDirectory(destinationPath, new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
            }
        }

        private async void yinButton4_Click(object sender, EventArgs e)
        {
            if (yinToggle7.Checked)
            {
                await ScrapeProxies("http", "http.txt",
                    "https://raw.githubusercontent.com/d7emy/Proxy-Wizard/main/output.txt",
                    "https://raw.githubusercontent.com/prxchk/proxy-list/main/http.txt",
                    "https://raw.githubusercontent.com/hookzof/socks5_list/master/proxy.txt",
                    "https://github.com/proxy4parsing/proxy-list/raw/main/http.txt",
                    "https://raw.githubusercontent.com/casals-ar/proxy-list/main/http",
                    "https://raw.githubusercontent.com/vakhov/fresh-proxy-list/master/http.txt",
                    "https://raw.githubusercontent.com/Zaeem20/FREE_PROXIES_LIST/master/http.txt",
                    "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies/http.txt"
                );
            }
            else if (yinToggle6.Checked)
            {
                await ScrapeProxies("socks4", "socks4.txt",
                    "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies/socks4.txt",
                    "https://raw.githubusercontent.com/Zaeem20/FREE_PROXIES_LIST/master/socks4.txt",
                    "https://raw.githubusercontent.com/vakhov/fresh-proxy-list/master/socks4.txt",
                    "https://raw.githubusercontent.com/casals-ar/proxy-list/main/socks4",
                    "https://raw.githubusercontent.com/prxchk/proxy-list/main/socks4.txt"
                );
            }
            else if (yinToggle5.Checked)
            {
                await ScrapeProxies("socks5", "socks5.txt",
                    "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies/socks5.txt",
                    "https://raw.githubusercontent.com/vakhov/fresh-proxy-list/master/socks5.txt",
                    "https://raw.githubusercontent.com/Zaeem20/FREE_PROXIES_LIST/master/socks5.txt",
                    "https://raw.githubusercontent.com/casals-ar/proxy-list/main/socks5",
                    "https://raw.githubusercontent.com/prxchk/proxy-list/main/socks5.txt"
                );
            }
        }

        private async Task ScrapeProxies(string proxyType, string fileName, params string[] urls)
        {
            try
            {
                List<string> proxies = new List<string>();

                foreach (var url in urls)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string content = await client.GetStringAsync(url);
                        content = content.Replace("http://", "");
                        proxies.AddRange(content.Split('\n').Select(line => line.Trim()).Where(line => !string.IsNullOrEmpty(line)));
                    }
                }


                proxies = proxies.Distinct().ToList();


                File.WriteAllLines(fileName, proxies);

                MessageBox.Show($"{proxyType} proxies scraped and saved to {fileName}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void yinToggle7_CheckedChanged(object sender)
        {
            if (yinToggle7.Checked) // For some reason works better in if statement
            {
                yinToggle6.Checked = false;
                yinToggle5.Checked = false;
            }
        }

        private void yinToggle6_CheckedChanged(object sender)
        {
            if (yinToggle6.Checked) // For some reason works better in if statement
            {
                yinToggle7.Checked = false;
                yinToggle5.Checked = false;
            }

        }

        private void yinToggle5_CheckedChanged(object sender)
        {
            if (yinToggle5.Checked) // For some reason works better in if statement
            {
                yinToggle7.Checked = false;
                yinToggle6.Checked = false;
            }

        }
    }
}
