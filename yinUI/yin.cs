using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace yinUI
{
    public partial class yin : Form
    {
        public yin()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            yinTextBox4.Visible = false;
            yinToggle1.Visible = false;

        }

        private void yinButton1_Click(object sender, EventArgs e)
        {

            string message = yinTextBox2.Text;
            string phoneNumber = yinTextBox1.Text;

            using (var client = new WebClient())
            {
                var values = new NameValueCollection
        {
            { "phone", phoneNumber },
            { "message", message },
            { "key", "textbelt" },
        };

                byte[] response;
                try
                {
                    response = client.UploadValues("http://textbelt.com/text", values);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Error sending the request: " + ex.Message);
                    return;
                }

                string responseString = Encoding.UTF8.GetString(response);
                MessageBox.Show(responseString);
            }
        }


        private void yinTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yinComboBox2.SelectedItem.ToString() == "Delete")
            {
                yinTextBox3.Enabled = true; 
                yinToggle1.Visible = false; 
            }
            else if (yinComboBox2.SelectedItem.ToString() == "Spam")
            {
                yinTextBox3.Enabled = true; 
                yinToggle1.Visible = true; 
                yinTextBox4.Visible = false;
            }
            else if (yinComboBox2.SelectedItem.ToString() == "")
            {
                yinTextBox3.Enabled = false; 
                yinToggle1.Visible = false; 
                yinTextBox4.Visible = false;
            }
            else
            {
                yinTextBox3.Enabled = false; 
                yinTextBox4.Visible = false;
                yinToggle1.Visible = false;
            }
        }

        private bool stopSpamming = false;
        private bool IsDiscordWebhookUrl(string url)
        {
            return url.StartsWith("https://discord.com/api/webhooks/")
                || url.StartsWith("https://discordapp.com/api/webhooks/");
        }
        private void yinButton2_Click(object sender, EventArgs e)
        {
            string webhookLink = yinTextBox3.Text.Trim();

            if (!IsDiscordWebhookUrl(webhookLink))
            {
                MessageBox.Show("Invalid Discord webhook URL.");
                return;
            }
            if (yinComboBox2.SelectedItem.ToString() == "Delete")
            {
                string webhookLinkdel = yinTextBox3.Text.Trim(); 
                string curlCommand = $"curl -X DELETE {webhookLinkdel}";

              
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "curl";
                psi.Arguments = $"-X DELETE \"{webhookLink}\"";
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;

                using (Process process = new Process())
                {
                    process.StartInfo = psi;
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                   
                }
            }
            else if (yinComboBox2.SelectedItem.ToString() == "Spam")
            {
                string webhookLink1 = yinTextBox3.Text.Trim(); 
                string text1 = "https://yin.sh";
                stopSpamming = false;
                while (!stopSpamming)
                {
                    try
                    {
                        using (WebClient client = new WebClient())
                        {
                            client.Headers.Add("Content-Type", "application/json");
                            string data = "{\"content\":\"" + text1 + "\"}";
                            client.UploadString(webhookLink1, "POST", data);
                        }

                
                    }
                    catch (WebException ex)
                    {
                        if (ex.Status == WebExceptionStatus.ProtocolError)
                        {
                            HttpWebResponse response = (HttpWebResponse)ex.Response;
                            if (response.StatusCode == HttpStatusCode.TooManyRequests)
                            {
                                stopSpamming = true;
                                MessageBox.Show("Rate-limited! Stop spamming.");
                            }
                        }
                    }
                }

                if (yinToggle1.Checked)
                {
                    string webhookLinkCustomSpam = yinTextBox3.Text.Trim(); 
                    string text = yinTextBox4.Text.Trim(); 

                    stopSpamming = false;
                    while (!stopSpamming)
                    {
                        try
                        {
                            using (WebClient client = new WebClient())
                            {
                                client.Headers.Add("Content-Type", "application/json");
                                string data = "{\"content\":\"" + text + "\"}";
                                client.UploadString(webhookLinkCustomSpam, "POST", data);
                            }

                            
                        }
                        catch (WebException ex)
                        {
                            if (ex.Status == WebExceptionStatus.ProtocolError)
                            {
                                HttpWebResponse response = (HttpWebResponse)ex.Response;
                                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                                {
                                    stopSpamming = true;
                                }
                            }
                        }
                    }
                }
            }
        }



        private void yinTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinToggle1_CheckedChanged(object sender)
        {
            if (yinToggle1.Checked)
            {
                yinTextBox4.Visible = true;
            }
            else
            {
                yinTextBox4.Visible = false;
            }
        }

        private void yinButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            network form3 = new network(); 
            form3.Show();
        }

        private void yinButton4_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            osint form4 = new osint(); 
            form4.Show();
        }

        private void shadowLabel1_Click(object sender, EventArgs e)
        {

        }

        private void yinBackground1_Click(object sender, EventArgs e)
        {

        }

        private void yinButton5_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            cracking form5 = new cracking();
            form5.Show();
        }
    }
}