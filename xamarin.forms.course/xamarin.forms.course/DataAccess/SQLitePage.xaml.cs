using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SQLite;
using xamarin.forms.course.DataAccess.Persistence;
using xamarin.forms.course.Models;
using Xamarin.Forms;

namespace xamarin.forms.course.DataAccess
{
    public partial class SQLitePage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;

        public SQLitePage()
        {
            InitializeComponent();

            this._connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            await this._connection.CreateTableAsync<Recipe>();
            var recipes = await this._connection.Table<Recipe>().ToListAsync();
            this._recipes = new ObservableCollection<Recipe>(recipes);
            this.recipesListView.ItemsSource = this._recipes;

            base.OnAppearing();
        }

        async void OnAdd(object sender, EventArgs e)
        {
            var recipe = new Recipe
            {
                Name = $"Recipe {DateTime.Now.Ticks}",
            };
            await this._connection.InsertAsync(recipe);
            this._recipes.Add(recipe);
        }

        async void OnUpdate(object sender, EventArgs e)
        {
            if (!this._recipes.Any())
                return;

            var recipe = this._recipes.First();
            recipe.Name += " Updated";

            await this._connection.UpdateAsync(recipe);
        }

        async void OnDelete(object sender, EventArgs e)
        {
            if (!this._recipes.Any())
                return;

            var recipe = this._recipes.First();
            await this._connection.DeleteAsync(recipe);
            this._recipes.Remove(recipe);
        }
    }
}
