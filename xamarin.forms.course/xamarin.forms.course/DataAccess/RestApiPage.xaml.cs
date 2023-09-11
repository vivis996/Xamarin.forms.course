using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using xamarin.forms.course.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace xamarin.forms.course.DataAccess
{
    public partial class RestApiPage : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _posts;

        public RestApiPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await this._client.GetStringAsync(Url);

            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            this._posts = new ObservableCollection<Post>(posts);
            this.postsListView.ItemsSource = this._posts;

            base.OnAppearing();
        }

        async void OnAdd(object sender, EventArgs e)
        {
            var post = new Post
            {
                Title = $"Title {DateTime.Now.Ticks}",
            };

            var content = JsonConvert.SerializeObject(post);
            await this._client.PostAsync(Url, new StringContent(content));
            this._posts.Insert(0, post);
        }

        async void OnUpdate(object sender, EventArgs e)
        {
            if (!this._posts.Any())
                return;

            var post = this._posts.First();
            post.Title += " Updated";

            var content = JsonConvert.SerializeObject(post);
            await this._client.PutAsync($"{Url}/{post.Id}", new StringContent(content));
        }

        async void OnDelete(object sender, EventArgs e)
        {
            if (!this._posts.Any())
                return;
            var post = this._posts.First();
            await this._client.DeleteAsync($"{Url}/{post.Id}");
            this._posts.Remove(post);
        }
    }
}
