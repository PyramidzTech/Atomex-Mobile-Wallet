﻿using System;
using atomex.ViewModel;
using Xamarin.Forms;

namespace atomex
{
    public partial class ConversionsListPage : ContentPage
    {

        private ConversionViewModel _conversionViewModel;

        public ConversionsListPage()
        {
            InitializeComponent();
        }

        public ConversionsListPage(ConversionViewModel conversionViewModel)
        {
            InitializeComponent();
            if (conversionViewModel != null)
            {
                _conversionViewModel = conversionViewModel;
                BindingContext = conversionViewModel;
            }
        }
        private async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                await Navigation.PushAsync(new SwapInfoPage(e.Item as SwapViewModel));
            }
        }
        private async void OnCreateSwapButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConversionFirstStepPage(_conversionViewModel));
        }
    }
}