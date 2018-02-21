using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleListBinding.ViewModels
{
    public class ViewModelBase: BindableObject
    {
        private bool _isBusy;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }
    }
}
