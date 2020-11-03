using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Case
    {
        public int CaseId { get; set; }
        public string ClientName { get; set; }
        public string Title { get; set; }
        public string Problem { get; set; }
        public string Status { get; set; }
        public DateTime Created = DateTime.Now;

        public string DisplayCaseId => $"CaseId: {CaseId}";
        public string DisplayClientName => $"ClientName: {ClientName}";
        public string DisplayTitle => $"Title: {Title}";
        public string DisplayProblem => $"Problem: {Problem}";
        public string DisplayStatus => $"Status: {Status}";
        public string DisplayCreated => $"Created: {Created}";

        public Case(string clientname, string title, string problem, string status)
        {
            ClientName = clientname;
            Title = title;
            Problem = problem;
            Status = status;
            Created = DateTime.Now;

        }

        public Case(int caseid, string clientname, string title, string problem, string status, DateTime created)
        {
            CaseId = caseid;
            ClientName = clientname;
            Title = title;
            Problem = problem;
            Status = status;
            Created = DateTime.Now;
        }

        public Case()
        {

        }




    }
}
