using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTracker.Data
{
    public class Project
    {
        public Project(int _id, string _nameEn, string _nameFR)
        {
            ID = _id;
            NameEN = _nameEn;
            NameFR = _nameFR;
        }

        public int ID { get; private set; }

        public string NameEN { get; private set; }

        public string NameFR { get; private set; }


    }
}
