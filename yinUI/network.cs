using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace yinUI
{
    public partial class network : Form
    {
        public network()
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
                shadowLabel2.Text = finalString;
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

        private void yinButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            yin form2 = new yin();
            form2.Show(); 
            richTextBox1.Visible = false;
        }

        private void shadowLabel1_Click(object sender, EventArgs e)
        {

        }


        private void transparentPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yinTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string GetPublicIPAddress()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://api.ipify.org").Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
        private void yinButton2_Click(object sender, EventArgs e)
        {

            yinButton2.Visible = false;
            string publicIPAddress = GetPublicIPAddress();
            shadowLabel1.Text = publicIPAddress;
        }



        private CancellationTokenSource pingCancellation;

        private async void yinButton3_Click(object sender, EventArgs e)
        {
            string ipAddress = yinTextBox1.Text.Trim();
            richTextBox1.Visible = true;

            richTextBox1.Clear();

        
            Ping pingSender = new Ping();

           
            pingCancellation = new CancellationTokenSource();

            
            for (int i = 1; i <= 50; i++)
            {
                
                if (pingCancellation.IsCancellationRequested)
                {
                    break;
                }

                PingReply pingReply = await pingSender.SendPingAsync(ipAddress);
                string resultString = $"Ping #{i}: Status={pingReply.Status.ToString()}";
                if (pingReply.Status == IPStatus.Success)
                {
                    resultString += $", RoundtripTime={pingReply.RoundtripTime} ms, " +
                                     $"TimeToLive={pingReply.Options.Ttl}, " +
                                     $"BufferLength={pingReply.Buffer.Length}";
                }
                resultString += "\n";
                richTextBox1.AppendText(resultString);
                await Task.Delay(1000);
            }

           
            pingCancellation.Dispose();
        }


        private void yinGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void shadowLabel2_Click(object sender, EventArgs e)
        {

        }

        private void transparentPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void yinButton4_Click(object sender, EventArgs e)
        {
            if (pingCancellation != null)
            {
                pingCancellation.Cancel();
            }
        }

        private async void yinButton5_Click(object sender, EventArgs e)
        {
      
            string domain = yinTextBox2.Text.Trim();

      
            if (!Uri.TryCreate("http://" + domain, UriKind.Absolute, out Uri uri))
            {
                MessageBox.Show("Invalid domain", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            string ipAddress = await GetIpAddressAsync(uri.Host);
            if (ipAddress == null)
            {
                MessageBox.Show("Could not get IP address of the domain", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

    
            bool isCloudflare = await IsCloudflareIpAsync(ipAddress);
            if (isCloudflare)
            {
   
                string[] subdomains = new string[] { "autoconfig", "autodiscover", "ftp", "webdisk", "whm", "www", "mail", "blog", "shop", "forum", "news", "api", "m", "en", "mobile", "cdn", "secure", "apps", "dev", "help", "download", "admin", "static", "beta", "staging", "portal", "media", "support", "events", "test", "jobs", "billing", "docs", "app", "members", "cpanel", "webmail", "login" };
                foreach (string subdomain in subdomains)
                {
                    string subdomainIp = await GetIpAddressAsync(subdomain + "." + uri.Host);
                    if (subdomainIp != null && !await IsCloudflareIpAsync(subdomainIp))
                    {
                        MessageBox.Show($"Found non-Cloudflare IP address for {subdomain}.{uri.Host}: {subdomainIp}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        richTextBox2.Text = subdomainIp;
                        return;
                    }
                }

                MessageBox.Show("Could not resolve Cloudflare IP", ":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
         
                MessageBox.Show($"IP address for {uri.Host} is not Cloudflare: {ipAddress}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox2.Text = ipAddress;
            }
        }

        private async Task<string> GetIpAddressAsync(string host)
        {
            try
            {
                IPHostEntry entry = await Dns.GetHostEntryAsync(host);
                return entry.AddressList[0].ToString();
            }
            catch
            {
                return null;
            }
        }

        private async Task<bool> IsCloudflareIpAsync(string ipAddress)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync($"https://www.findip.net/?ip={ipAddress}");
                    return response.Contains("Cloudflare");
                }
            }
            catch
            {
                return false;
            }
        }





        private void yinTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinTextBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void yinButton6_Click(object sender, EventArgs e)
        {
            string ipAddress = yinTextBox3.Text.Trim();
            string url = "https://ipwhois.app/json/" + ipAddress;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        string responseFromServer = reader.ReadToEnd();
                        JObject json = JObject.Parse(responseFromServer);

                        richTextBox3.Text = "City: " + (string)json["city"] + "\n";
                        richTextBox3.Text += "Region: " + (string)json["region"] + "\n";
                        richTextBox3.Text += "Country: " + (string)json["country"] + "\n";
                        richTextBox3.Text += "Latitude: " + (string)json["latitude"] + "\n";
                        richTextBox3.Text += "Longitude: " + (string)json["longitude"] + "\n";
                        richTextBox3.Text += "ISP: " + (string)json["isp"] + "\n";
                        richTextBox3.Text += "Org: " + (string)json["org"] + "\n";
                        richTextBox3.Text += "Timezone: " + (string)json["timezone"] + "\n";
                        richTextBox3.Text += "Currency: " + (string)json["currency"] + "\n";
                        richTextBox3.Text += "Type: " + (string)json["type"] + "\n";
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    using (WebResponse response = ex.Response)
                    {
                        HttpWebResponse httpResponse = (HttpWebResponse)response;
                        Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                    }
                }
                else
                {
                    Console.WriteLine("An error occurred: {0}", ex.Message);
                }
            }
        }


        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinGroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void yinTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void yinButton7_Click(object sender, EventArgs e)
        {
            string domain = yinTextBox4.Text;
            string output = "";

            try
            {
      
                IPHostEntry host = await Dns.GetHostEntryAsync(domain);

            
                output = "DNS records for " + domain + ":\n\n";
                foreach (IPAddress ip in host.AddressList)
                {
                    output += ip.ToString() + " (" + ip.AddressFamily.ToString() + ")\n";
                }
                output += "";
                foreach (string alias in host.Aliases)
                {
                    output += "CNAME: " + alias + "\n";
                }

       
                HttpClient client = new HttpClient();
                string url = "https://dns.google/resolve?name=" + domain + "&type=MX";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(json);
                JArray mxRecords = data["Answer"] as JArray;

       
                if (mxRecords != null && mxRecords.Count > 0)
                {
                    output += "MX records for " + domain + ":\n\n";
                    foreach (var record in mxRecords)
                    {
                        output += record["data"] + " (priority " + record["preference"] + ")\n";
                    }
                }
                else
                {
                    output += "No MX records found for " + domain + "\n";
                }
            }
            catch (Exception ex)
            {
                output = "Error retrieving DNS and MX records: " + ex.Message;
            }

        
            richTextBox4.Text = output;
        }







        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
