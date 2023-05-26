using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp.ViewModel
{
    public class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {

            //if (_connectivity == null)
            //    _connectivity = ServiceHelper.GetService<IConnectivity>();
        }
    }
}
