using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace NoteApp.ViewModel
{
    public class MainPageViewModel:BaseViewModel
    {
        private string name, description, category;
        private double price;
        private int count;
        private DateTime createDate;

        public string Name { get { return name; } set { name = value;OnPropertyChanged(nameof(Name)); } }
        public string Description { get { return description; } set { description = value;OnPropertyChanged(nameof(Description)); } }
        public string Category { get { return category; } set { category = value;OnPropertyChanged(nameof(Category)); } }

        public int Count { get { return count; } set { count = value; OnPropertyChanged(nameof(Count)); } }

        public double Price { get { return price; } set { price=value;OnPropertyChanged(nameof(Price)); } }
        public DateTime CreateDate { get { return createDate; } set { createDate = value;OnPropertyChanged(nameof(CreateDate)); } }
        public MainPageViewModel() { 
        }
    }
}
