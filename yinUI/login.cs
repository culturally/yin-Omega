using System.Text;

namespace yinUI
{
    public partial class login : Form
    {
        public login()
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



        private void yinButton1_Click(object sender, EventArgs e)
        {
            string encryptedKey = "MHh5MW4=";

            byte[] encryptedBytes = Convert.FromBase64String(encryptedKey);
            string key = Encoding.UTF8.GetString(encryptedBytes);

            if (yinTextBox1.Text == key)
            {
                MessageBox.Show("Success!");
                this.Hide(); 
                yin form2 = new yin(); 
                form2.Show();
            }
        }

        private void yinTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yinBackground1_Click(object sender, EventArgs e)
        {

        }
    }
}


