using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Services
{
    public static class DataAccess
    {


        private static readonly string _dbpath = @"Server=tcp:ecwin20.database.windows.net,1433;Initial Catalog=MattiasDB;Persist Security Info=False;User ID=sqlAdmin;Password=bytmig123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static async Task AddAsync(Case cases)
        {
            using (SqlConnection sqlConn = new SqlConnection(_dbpath))
            {
                sqlConn.Open();

                var query = "INSERT INTO Cases (ClientName, Title, Problem, Status, Created) VALUES(@ClientName, @Title, @Problem, @Status, @Created)";
                SqlCommand cmd = new SqlCommand(query, sqlConn);


                cmd.Parameters.AddWithValue("@ClientName", cases.ClientName);
                cmd.Parameters.AddWithValue("@Title", cases.Title);
                cmd.Parameters.AddWithValue("@Problem", cases.Problem);
                cmd.Parameters.AddWithValue("@Status", cases.Status);
                cmd.Parameters.AddWithValue("@Created", cases.Created);


                await cmd.ExecuteReaderAsync();

                sqlConn.Close();
            }

        }

        public static async Task UpdateAsync(int id, string status)
        {
            using (SqlConnection sqlConn = new SqlConnection(_dbpath))
            {
                sqlConn.Open();

                var query = "UPDATE Cases SET Status = @Status WHERE CaseId = @CaseId";
                SqlCommand cmd = new SqlCommand(query, sqlConn);

                cmd.Parameters.AddWithValue("@CaseId", id);
                cmd.Parameters.AddWithValue("@Status", status);

                await cmd.ExecuteReaderAsync();

                sqlConn.Close();
            }

        }

        public static async Task DeleteAll()
        {
            using (SqlConnection sqlConn = new SqlConnection(_dbpath))
            {
                sqlConn.Open();

                var query = "DELETE FROM Cases";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                await cmd.ExecuteReaderAsync();
                sqlConn.Close();
            }

        }

        public static IEnumerable<Case> GetAllAsync()
        {
            var caselist = new List<Case>();
            using (SqlConnection sqlConn = new SqlConnection(_dbpath))
            {
                sqlConn.Open();

                var query = "SELECT * FROM Cases";
                SqlCommand cmd = new SqlCommand(query, sqlConn);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    int CaseId = result.GetInt32(0);
                    string ClientName = result.GetString(1);
                    string Title = result.GetString(2);
                    string Problem = result.GetString(3);
                    string Status = result.GetString(4);
                    DateTime Created = result.GetDateTime(5);

                    caselist.Add(new Case(CaseId, ClientName, Title, Problem, Status, Created));
                }

                sqlConn.Close();

                return caselist;
            }
        }

        public static IEnumerable<Case> GetAllFalse()
        {

            var caseList = new List<Case>();
            using (SqlConnection conn = new SqlConnection(_dbpath))
            {
                conn.Open();
                var query = "SELECT * FROM Cases WHERE Cases.Status = 'New'";


                SqlCommand cmd = new SqlCommand(query, conn);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    int CaseId = result.GetInt32(0);
                    string ClientName = result.GetString(1);
                    string Title = result.GetString(2);
                    string Problem = result.GetString(3);
                    string Status = result.GetString(4);
                    DateTime Created = result.GetDateTime(5);




                    caseList.Add(new Case(CaseId, ClientName, Title, Problem, Status, Created));
                }
                conn.Close();
                return caseList;

            }
        }

        public static IEnumerable<Case> GetAllCompleted()
        {

            var caseList = new List<Case>();

            using (SqlConnection conn = new SqlConnection(_dbpath))
            {
                conn.Open();
                var query = "SELECT * FROM Cases WHERE Cases.Status = 'Completed'";


                SqlCommand cmd = new SqlCommand(query, conn);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    int CaseId = result.GetInt32(0);
                    string ClientName = result.GetString(1);
                    string Title = result.GetString(2);
                    string Problem = result.GetString(3);
                    string Status = result.GetString(4);
                    DateTime Created = result.GetDateTime(5);

                    caseList.Add(new Case(CaseId, ClientName, Title, Problem, Status, Created));
                }
                conn.Close();
                return caseList;

            }
        }


    }
}
