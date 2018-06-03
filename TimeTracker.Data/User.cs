using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTracker.Data
{
    public class User
    {
        public User(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }

        public int ID { get; private set; }

        public string Name { get; private set; }

    }
}
