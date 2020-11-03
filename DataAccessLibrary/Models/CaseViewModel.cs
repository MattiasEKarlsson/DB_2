using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class CaseViewModel
    {
        public ObservableCollection<Case> cases { get; } = new ObservableCollection<Case>();

        public CaseViewModel()
        {
        }
    }
}
