using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Comments
    {
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public DateTime Created = DateTime.Now;
        public int CaseId { get; set; }

        public Comments(int commentId, string comment, DateTime created, int caseId)
        {
            CommentId = commentId;
            Comment = comment;
            Created = created;
            CaseId = caseId;
        }

        public Comments(string comment, int caseId)
        {
            
            Comment = comment;
            CaseId = caseId;

        }

        public Comments()
        {

        }

        public Comments(string comment, DateTime created)
        {
            Comment = comment;
            Created = created;
            
        }
    }
}
