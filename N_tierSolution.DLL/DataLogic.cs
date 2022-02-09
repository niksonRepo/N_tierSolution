using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using Dapper;
using N_tierSolution.Entity;

namespace N_tierSolution.DLL
{
    public class DataLogic
    { 
        private static SqliteConnection? _dbConnection;

        public DataLogic()
        {
            CreateDbIfNotExistsAndOpenConnection();
        }

        private static void CreateDbIfNotExistsAndOpenConnection()
        {
            var dbFilePath = "@StudentDatabase.sqlite";

            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            _dbConnection = new SqliteConnection($"Data Source={dbFilePath};Version=3");
            _dbConnection.Open();
        }

        public void AddStudent(Students student)
        {
            var query = @"Insert Into Students Values(1, 'John', 'Doe')";
            _dbConnection.Query(query);
        }

        public List<Students> GetStudents()
        {
            var studentQuery = "Select * From Students";

            return _dbConnection.Query<Students>(studentQuery).ToList();
        }



        public bool GetDataFromDb(int age)
        {
            //fake data from db
            return age >= 18;
        }

        public bool AreYouHumanOrNot(string obj)
        {
            return obj == "human";
        }
    }
}