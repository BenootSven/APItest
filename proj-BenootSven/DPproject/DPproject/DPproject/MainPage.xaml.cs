﻿using DPproject.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DPproject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            test();
        }

        private async void test()
        {
            EdamamRecepten ReceptenList = await EdamamManeger.GetRecepies();
            await DisplayAlert("ok", ReceptenList.Q, "close");
           // lvwRecepten.ItemsSource = ReceptenList;
            //Debug.WriteLine(ReceptenList);
        }
    }
}
