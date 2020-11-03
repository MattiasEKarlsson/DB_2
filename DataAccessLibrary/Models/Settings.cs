﻿using System;
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
    }
}