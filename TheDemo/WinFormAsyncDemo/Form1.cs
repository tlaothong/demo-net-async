using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;

namespace WinFormAsyncDemo
{
    public partial class Form1 : Form
    {
        private readonly int[] validPostIds = { 11, 12, 32, 33, 48, 51, 52, 55 };

        public Form1()
        {
            InitializeComponent();
        }

        private void SyncDemoButton_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(CountNumberUpDown.Value);

            for (int i = 0; i < count; i++)
            {
                var id = validPostIds[i % validPostIds.Length];
                var post = $"https://gorest.co.in/public/v1/posts/{id}".GetJsonAsync<Post>().Result;
                OutputListBox.Items.Add(post.Data.Title);
            }
        }

        private async void AsyncDemoButton_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(CountNumberUpDown.Value);

            for (int i = 0; i < count; i++)
            {
                var id = validPostIds[i % validPostIds.Length];
                var post = await $"https://gorest.co.in/public/v1/posts/{id}".GetJsonAsync<Post>();
                OutputListBox.Items.Add(post.Data.Title);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputListBox.Items.Clear();
        }
    }
}
