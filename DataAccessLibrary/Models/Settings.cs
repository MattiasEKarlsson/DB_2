using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Settings : ObservableCollection<string>
    {
        public Settings()
        {
            Add("New");
            Add("Active");
            Add("Completed");
        }

        public Settings(int maxNumber, string statusNew, string statusActive, string statusCompleted)
        {
            MaxNumber = maxNumber;
            StatusNew = statusNew;
            StatusActive = statusActive;
            StatusCompleted = statusCompleted;
        }

        public int MaxNumber { get; set; }
        public string StatusNew {get; set;}
        public string StatusActive { get; set; }
        public string StatusCompleted{ get; set; }
    }
}
