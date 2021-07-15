using Flurl.Http;
using System;
using System.Windows.Forms;

namespace WinFormAsyncDemo
{
    public partial class Form1 : Form
    {
        private readonly int[] validPostIds = { 11, 12, 32, 33, 48, 51, 52, 55 };

        public Form1()
        {
            InitializeComponent();
        }

        private const string WebApiUrl = "https://gorest.co.in/public/v1/posts";

        private void SyncDemoButton_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(CountNumberUpDown.Value);

            for (int i = 0; i < count; i++)
            {
                var id = validPostIds[i % validPostIds.Length];
                var post = $"{WebApiUrl}/{id}".GetJsonAsync<Post>().Result;
                OutputListBox.Items.Add(post.Data.Title);
            }
        }

        private async void AsyncDemoButton_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(CountNumberUpDown.Value);

            for (int i = 0; i < count; i++)
            {
                var id = validPostIds[i % validPostIds.Length];
                var post = await $"{WebApiUrl}/{id}".GetJsonAsync<Post>();
                OutputListBox.Items.Add(post.Data.Title);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputListBox.Items.Clear();
        }
    }
}
