using DataAccessLibrary.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class SetStatus : ObservableCollection<string>
    {
        public SetStatus() 
        {
            Add(DataAccess.GetStatusSettings(0));
            Add(DataAccess.GetStatusSettings(1));
            Add(DataAccess.GetStatusSettings(2));
        }

        public SetStatus(int maxNumber, string statusNew, string statusActive, string statusCompleted)
        {
            MaxNumber = maxNumber;
            StatusNew = statusNew;
            StatusActive = statusActive;
            StatusCompleted = statusCompleted;
        }

        public int MaxNumber { get; set; }
        public string StatusNew { get; set; }
        public string StatusActive { get; set; }
        public string StatusCompleted { get; set; }
    }
}
