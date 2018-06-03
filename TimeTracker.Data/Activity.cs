using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTracker.Data
{
    public class Activity
    {
        public Activity(int _id, string _title, string _description, int _projectID, int _catID, int _userID)
        {
            ID = _id;
            Title = _title;
            Description = _description;
            ProjectID = _projectID;
            CategoryID = _catID;
            userID = _userID;
        }
        public int ID { get; private set; }
        public string Title { get; private set; }     

        public string  Description { get; private set; }

        public int ProjectID { get; private set; }

        public int CategoryID { get; private set; }

        public int userID { get; private set; }
    }
}
