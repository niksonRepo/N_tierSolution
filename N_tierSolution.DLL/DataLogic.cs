﻿using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using Dapper;
using N_tierSolution.Entity;

namespace N_tierSolution.DLL
{
    public class DataLogic
    {
        private static SQLiteConnection? _dbConnection;

        public DataLogic()
        {
            CreateDbIfNotExistsAndOpenConnection();
            CreateDataStructureIfNotExists();
        }

        private static void CreateDbIfNotExistsAndOpenConnection()
        {
            var dbFilePath = "@StudentDatabase.sqlite";

            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            if (_dbConnection == null)
            {
                _dbConnection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;");
                _dbConnection.Open();
            }
        }

        private static void CreateDataStructureIfNotExists()
        {
            var tablesCountQuery = @"SELECT count(*) FROM sqlite_master WHERE type='table' AND name='Students'";
            var count = _dbConnection.Query<int>(tablesCountQuery).FirstOrDefault();
            
            if (count == 0)
            {
                var createTablesQuery = @" CREATE TABLE Students(
	                                            Id int IDENTITY(1,1) NOT NULL,
	                                            Name text NULL,
	                                            Surname text NULL,
	                                            Primary Key (Id)
	                                            );

                                            Insert Into Students
                                            Values (1,'John','Doe');
                                            ";
                _dbConnection.Query<int>(createTablesQuery);
            }
        }

        public void AddStudent(Students student)
        {
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