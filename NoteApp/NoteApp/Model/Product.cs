using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp.Model
{
    public class Product
    {
        public string Id { get; set; } = new Guid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public double prise { get; set; }

        public int count { get; set; }

        public double total { get { return prise * count; } }

        public DateTime CreateDate { get; set; }    



    }
}
