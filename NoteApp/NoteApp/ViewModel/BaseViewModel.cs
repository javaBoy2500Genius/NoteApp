using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Essentials;
using NoteApp.Model;
using Newtonsoft.Json;

namespace NoteApp.ViewModel
{
    public class BaseViewModel : ObservableObject
    {
        public string ProductList { get => Preferences.Get(nameof(ProductList), $"{JsonConvert.SerializeObject(new List<Product>())}"); set { Preferences.Set(nameof(ProductList), value); OnPropertyChanged(nameof(ProductList)); } }

        public BaseViewModel()
        {
     
        //if (_connectivity == null)
        //    _connectivity = ServiceHelper.GetService<IConnectivity>();
    }
}
}
