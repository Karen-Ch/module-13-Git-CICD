﻿using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using person_wpf_demo.Models;
using person_wpf_demo.Data.Repositories;
using person_wpf_demo.Utils;
using person_wpf_demo.Utils.Commands;
using person_wpf_demo.Services.Interfaces;


namespace person_wpf_demo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private INavigationService _navigationService;

        public INavigationService NavigationService
        {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged();
            }
        }

        public ICommand NavigateToPersonsViewCommand { get; set; }
        public ICommand NavigateToNewPersonViewCommand { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToPersonsViewCommand = new RelayCommand(() => NavigationService.NavigateTo<PersonsViewModel>());
            NavigateToNewPersonViewCommand = new RelayCommand(() => NavigationService.NavigateTo<NewPersonViewModel>());
            NavigationService.NavigateTo<PersonsViewModel>();
        }
    }
}

