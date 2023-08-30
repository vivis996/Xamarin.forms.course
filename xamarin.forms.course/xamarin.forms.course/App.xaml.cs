﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin.forms.course
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new StackPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
