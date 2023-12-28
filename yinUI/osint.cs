using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Text;



namespace yinUI
{
    public partial class osint : Form
    {
        private ClientWebSocket webSocket;

        public osint()
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

        private async void yinButton1_Click(object sender, EventArgs e)
        {
            string username = yinTextBox1.Text;
            string websocketUrl = $"wss://www.handlefinder.com/api/v1/handles/{username}";

            using (webSocket = new ClientWebSocket())
            {
          
                webSocket.Options.SetRequestHeader("Accept-Encoding", "gzip, deflate, br");
       

                try
                {
                    await webSocket.ConnectAsync(new Uri(websocketUrl), CancellationToken.None);

                    if (webSocket.State == WebSocketState.Open)
                    {
                    
                        await ReceiveMessages();
                    }
                    else
                    {
                        MessageBox.Show("WebSocket connection failed. State: " + webSocket.State);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("WebSocket connection error: " + ex.Message);
                }
            }
        }

        private async Task ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            while (webSocket.State == WebSocketState.Open)
            {
                try
                {
                    WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        UpdateRichTextBox(message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error receiving WebSocket message: " + ex.Message);
                    break;
                }
            }
        }

        private void UpdateRichTextBox(string message)
        {
      
            if (richTextBox2.InvokeRequired)
            {
                richTextBox2.Invoke(new Action(() => richTextBox2.AppendText(message + Environment.NewLine)));
            }
            else
            {
                richTextBox2.AppendText(message + Environment.NewLine);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
      
            webSocket?.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None).Wait();
            base.OnFormClosing(e);
        }

        private void yinTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void yinButton2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            yin form2 = new yin(); 
            form2.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void yinButton3_Click(object sender, EventArgs e)
        {
      
        }

        private void shadowLabel1_Click(object sender, EventArgs e)
        {

        }

        private void yinTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void yinButton3_Click_1(object sender, EventArgs e)
        {
            string phoneNumber = yinTextBox3.Text;
            string apiUrl = "https://free-lookup.net/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
             
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}{phoneNumber}");

                    if (response.IsSuccessStatusCode)
                    {
                    
                        string htmlContent = await response.Content.ReadAsStringAsync();

              
                        HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                        htmlDoc.LoadHtml(htmlContent);

             
                        string owner = GetInnerText(htmlDoc, "Owner");
                        string location = GetInnerText(htmlDoc, "Location");
                        string carrier = GetInnerText(htmlDoc, "Carrier");
                        string lineType = GetInnerText(htmlDoc, "Line Type");
                        string localTime = GetInnerText(htmlDoc, "Local Time");

                        richTextBox1.Text = $"Owner: {owner}\nLocation: {location}\nCarrier: {carrier}\nLine Type: {lineType}\nLocal Time: {localTime}";
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private string GetInnerText(HtmlAgilityPack.HtmlDocument htmlDoc, string label)
        {

            var labelNode = htmlDoc.DocumentNode.SelectSingleNode($"//li[contains(., '{label}')]");

            if (labelNode != null)
            {

                var infoNode = labelNode.SelectSingleNode("div[@class='report-summary__lock-wrap']");

  
                return infoNode?.InnerText.Trim() ?? "N/A";
            }

            return "N/A";
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void yinButton4_Click(object sender, EventArgs e)
        {
            string email = yinTextBox2.Text;
            string apiUrl = $"https://api.haveibeenbreached.com/?contact={email}";

            using (HttpClient client = new HttpClient())
            {
                try
                {

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
                    client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
                    client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9");
                    client.DefaultRequestHeaders.Add("DNT", "1");
                    client.DefaultRequestHeaders.Add("Origin", "https://haveibeenpwned.com");
                    client.DefaultRequestHeaders.Referrer = new Uri("https://haveibeenpwned.com/");
                    client.DefaultRequestHeaders.Add("Sec-Ch-UA", "\"Google Chrome\";v=\"100\", \"Chromium\";v=\"100\", \"Not=A?Brand\";v=\"24\"");
                    client.DefaultRequestHeaders.Add("Sec-Ch-UA-Mobile", "?0");
                    client.DefaultRequestHeaders.Add("Sec-Ch-UA-Platform", "\"Windows\"");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-site");
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.75 Safari/537.36");


                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {

                        string jsonContent = await response.Content.ReadAsStringAsync();

         
                        var breaches = JsonConvert.DeserializeObject<List<Breach>>(jsonContent);

                  
                        DisplayBreaches(breaches);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void DisplayBreaches(List<Breach> breaches)
        {

            richTextBox3.Clear();

            if (breaches != null && breaches.Count > 0)
            {
 
                foreach (var breach in breaches)
                {
                    richTextBox3.AppendText($"Name: {breach.Name}\n");
                    richTextBox3.AppendText($"Title: {breach.Title}\n");
                    richTextBox3.AppendText($"Domain: {breach.Domain}\n");
                    richTextBox3.AppendText($"Breach Date: {breach.BreachDate}\n");
                    richTextBox3.AppendText($"Pwned: {breach.PwnCount}\n");
                    richTextBox3.AppendText($"Data Leaked: {string.Join(", ", breach.DataClasses)}\n");
                    richTextBox3.AppendText("\n-----------------\n\n");
                }
            }
            else
            {
                richTextBox3.AppendText("Breach not found for the given email.\n");
            }
        }

        public class Breach
        {
            public string? Name { get; set; }
            public string? Title { get; set; }
            public string? Domain { get; set; }
            public string? BreachDate { get; set; }
            public int PwnCount { get; set; }
            public List<string> DataClasses { get; set; } 
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void yinButton5_Click(object sender, EventArgs e)
        {
            string email = yinTextBox4.Text;
            string apiUrl = $"https://emailrep.io/query/{email}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
   
                    client.DefaultRequestHeaders.Add("DNT", "1");
                    client.DefaultRequestHeaders.Add("Host", "emailrep.io");
                    client.DefaultRequestHeaders.Add("Pragma", "no-cache");
                    client.DefaultRequestHeaders.Add("Referer", $"https://emailrep.io/{email}");
                    client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Google Chrome\";v=\"117\", \"Chromium\";v=\"117\", \"Not=A?Brand\";v=\"24\"");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/117.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
                    client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
                    client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));
                    client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("br"));
                    client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("en-US"));
                    client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("en"));
                    client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue { NoCache = true };

          
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
       
                        string jsonContent = await response.Content.ReadAsStringAsync();

                 
                        UpdateRichTextBox4(jsonContent);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        private void UpdateRichTextBox4(string message)
        {

            if (richTextBox4.InvokeRequired)
            {
                richTextBox4.Invoke(new Action(() => richTextBox4.AppendText(message + Environment.NewLine)));
            }
            else
            {
                richTextBox4.AppendText(message + Environment.NewLine);
            }
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
