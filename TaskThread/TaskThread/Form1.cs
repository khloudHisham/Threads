using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TaskThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            byte[] fileBytes = await client.GetByteArrayAsync(textBox1.Text);
            await File.WriteAllBytesAsync(@"F:\C#44\TaskThread\Download\filefortesting.rar", fileBytes);
            MessageBox.Show("File Downloaded");

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(textBox2.Text);
            string result = await response.Content.ReadAsStringAsync();
            richTextBox1.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
