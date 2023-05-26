using NoteApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoteApp
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm = new MainPageViewModel();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (e.NewTextValue != null && e.NewTextValue != e.OldTextValue&&!string.IsNullOrWhiteSpace(e.NewTextValue))
                {
                    var p = vm.Products.FirstOrDefault(x => x.Name.Contains(e.NewTextValue));
                    if (p != null && p.Name != vm.Name)
                    {
                        vm.Name = p.Name;
                        return;
                    }
                }
            }catch { return; }
        }

        private void Entry_TextChanged1(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (e.NewTextValue != null && e.NewTextValue != e.OldTextValue && !string.IsNullOrWhiteSpace(e.NewTextValue))
                {
                    var p = vm.Products.FirstOrDefault(x => x.Description.Contains(e.NewTextValue));
                    if (p != null && p.Description != vm.Description)
                    {
                        vm.Description = p.Description;
                        return;
                    }
                }
            }catch { return; }
        }
        private void Entry_TextChanged2(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (e.NewTextValue != null && e.NewTextValue != e.OldTextValue && !string.IsNullOrWhiteSpace(e.NewTextValue))
                {
                    var p = vm.Products.FirstOrDefault(x => x.Category.Contains(e.NewTextValue));
                    if (p != null && p.Category != vm.Category)
                    {
                        vm.Category = p.Category;
                        return;
                    }
                }
            }catch(Exception ex) { return; }
        }
        private void Entry_TextChanged3(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue != null && e.NewTextValue != e.OldTextValue && !string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                try
                {
                    var p = vm.Products.FirstOrDefault(x => x.prise.ToString().Contains(e.NewTextValue));
                    if (p != null && p.prise != vm.Price)
                    {
                        vm.Price = p.prise;
                        return;
                    }
                }catch (Exception) {
                    return;
                }
             
            }
        }

        private void Entry_TextChanged4(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (e.NewTextValue != null && e.NewTextValue != e.OldTextValue && !string.IsNullOrWhiteSpace(e.NewTextValue))
                {
                    var p = vm.Products.FirstOrDefault(x => x.count.ToString().Contains(e.NewTextValue));
                    if (p != null && p.count != vm.Count)
                    {
                        vm.Count = p.count;
                        return;
                    }
                }
            }catch(Exception) { return; }
         
        }
    }
}
