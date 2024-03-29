﻿using ModernDesign.Core;
using System;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel : ObeservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });
        }
    }
}
