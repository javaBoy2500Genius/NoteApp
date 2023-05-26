using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Input;
using System.Net.Sockets;
using System.Net.Http;
using Xamarin.Forms;
using NoteApp.Model;
using Newtonsoft.Json;

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


        public List<Product> Products { get { return JsonConvert.DeserializeObject<List<Product>>(ProductList); } }
        public MainPageViewModel() { 
        }


        private RelayCommand pechatCommand;

        public ICommand PechatCommand
        {
            get
            {
                if (pechatCommand == null)
                {
                    pechatCommand = new RelayCommand(Pechat);
                }

                return pechatCommand;
            }
        }


        private async void Pechat()
        {
            if (res(Name) || res(Description) || res((Category)))
            {
                //alert
                return;
            }
            CreateDate=DateTime.Now;
                if (Price < 0 || Count < 0)
                {
                    //alert
                    return;
                }
             var p   = new Product { Name = Name, Description=Description, CreateDate=CreateDate,Category=Category,count=Count,prise=Price};
                try
                {
                string printerIPAddress = "192.168.31.63"; // Replace with the printer's IP address
                int printerPort = 9100; // Replace with the printer's port number

                Socket printerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                printerSocket.Connect(printerIPAddress, printerPort);

                if (printerSocket.Connected)
                {
                   



                    string message = $"| Name - {Name}\n|Description - {Description}|\n";
                    string res = "\n\n\n__________________________|\n";
                    
                   
                    res += message;
                    res += "|____________________________________|\n";
                    byte[] messageBytes = Encoding.ASCII.GetBytes(res);

                    printerSocket.Send(messageBytes);

                    // Close the socket after printing
                    printerSocket.Close();
                }
                else
                {
                    // Failed to connect to the printer
                }
            }catch(Exception ex) { 
            
             Console.WriteLine(ex.ToString());
            //alert
            }

            var list =  JsonConvert.DeserializeObject<List<Product>>(ProductList);

            list.Add(p);
            Name = "";
            Description = "";
            Category = "";
            count = 0;
            price = 0;

            ProductList = JsonConvert.SerializeObject(list);

        }

        private bool res(string str)
        {
            if(string.IsNullOrEmpty(str)||string.IsNullOrWhiteSpace(str)) 
                return true;
            return false;
        }
        }
}
