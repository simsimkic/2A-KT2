﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.WPF.ViewModels
{
    public class TourGuide_CreateTourViewModel : ViewModelBase
    {
        public ViewModelCommand ShowToursCommand { get; private set; }

        private readonly TourGuide_MainViewModel _mainViewModel;

        public TourGuide_CreateTourViewModel(TourGuide_MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            ShowToursCommand = new ViewModelCommand(ShowTours);
        }

        public void ShowTours(object obj)
        {
            _mainViewModel.ExecuteShowTourGuideToursViewCommand(null);
        }
    }
}
