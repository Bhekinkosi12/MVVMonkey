﻿using MVVMonkey.Core.Services;
using Xamarin.Forms;

namespace MVVMonkey.Core.ViewModel
{
    public abstract class ViewModelBase : NotifyPropertyChangedBase
    {
        public INavigationService NavigationService { get; }
        public IDisplayAlertService DisplayAlertService { get; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(out _title, value); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(out _isBusy, value); }
        }

        public ViewModelBase(string title = "")
        {
            NavigationService = DependencyService.Get<INavigationService>();
            DisplayAlertService = DependencyService.Get<IDisplayAlertService>();
            Title = title;
        }
    }
}
