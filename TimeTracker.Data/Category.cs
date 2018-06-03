using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTracker.Data
{
    public class Category
    {
        public Category(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }

        public int ID { get; private set; }

        public string Name { get; set; }
    }
}
