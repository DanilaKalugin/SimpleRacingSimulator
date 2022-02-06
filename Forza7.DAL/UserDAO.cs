using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;
using System.Configuration;
using System.Data;

namespace Kursach5.DAL
{
    public class UserDAO : IDisposable
    {
        private SqlConnection _connection;

        public static string GetConnectionString()
        {
            var currentConnection = ConfigurationManager.AppSettings["CurrentConnectionString"];
            var connectionString = ConfigurationManager.ConnectionStrings[currentConnection].ConnectionString;
            return connectionString;
        }

        public UserDAO()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection(GetConnectionString());
            _connection.Open();
            _connection.StateChange += ConnectionStateChange;
        }

        void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Broken)
            {
                InitConnection();
            }
        }

        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }

        public int UserPasswordCheck(string Login, string Password)
        {
            using (SqlCommand command = new SqlCommand("UserAuthorization", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Login", SqlDbType.NVarChar, 20);
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 10);
                SqlParameter OperationResult = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(OperationResult);

                command.Prepare();

                command.Parameters[0].Value = Login;
                command.Parameters[1].Value = Password;

                command.ExecuteNonQuery();
                return (int)OperationResult.Value;
            }
        }

        public IEnumerable<User> GetUserInformationByLogin(string Login)
        {
            using (SqlCommand command = new SqlCommand("GetUserInformationByLogin", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Login", SqlDbType.NVarChar, 20);
                command.Prepare();

                command.Parameters[0].Value = Login;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Name = (string)reader["UserName"];
                        bool IsAdmin = (bool)reader["IsAdmin"];
                        string Country = (string)reader["UserCountry"];
                        bool IsBlocked = (bool)reader["IsBlocked"];
                        User.SortingType type = (User.SortingType)reader["SortingType"];
                        User.UnitsSystem system = (User.UnitsSystem)reader["UnitsSystem"];
                        int CarID = (int)reader["Car"];
                        yield return new User(Name, Login, IsAdmin, Country, IsBlocked, type, system, CarID - 1);
                    }
                }
            }
        }

        public void AddUser(string Name, string Login, string Password, string Country, int sortingType)
        {
            using (SqlCommand command = new SqlCommand("AddUser", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 25);
                command.Parameters.Add("@Login", SqlDbType.NVarChar, 20);
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 15);
                command.Parameters.Add("@Country", SqlDbType.NVarChar, 3);
                command.Parameters.Add("@SortingType", SqlDbType.Int);

                command.Prepare();

                command.Parameters[0].Value = Name;
                command.Parameters[1].Value = Login;
                command.Parameters[2].Value = Password;
                command.Parameters[3].Value = Country;
                command.Parameters[4].Value = sortingType;
                command.ExecuteNonQuery();
            }
        }

        public void UpdateUser(string oldName, string newName, string newLogin, string newPassword, string newCountry, int sortingType)
        {
            using (SqlCommand command = new SqlCommand("UpdateUser", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@OldName", SqlDbType.NVarChar, 25);
                command.Parameters.Add("@NewName", SqlDbType.NVarChar, 25);
                command.Parameters.Add("@NewLogin", SqlDbType.NVarChar, 20);
                command.Parameters.Add("@NewPassword", SqlDbType.NVarChar, 15);
                command.Parameters.Add("@NewCountry", SqlDbType.NVarChar, 3);
                command.Parameters.Add("@NewSortingType", SqlDbType.Int);

                command.Prepare();

                command.Parameters[0].Value = oldName;
                command.Parameters[1].Value = newName;
                command.Parameters[2].Value = newLogin;
                command.Parameters[3].Value = newPassword;
                command.Parameters[4].Value = newCountry;
                command.Parameters[5].Value = sortingType;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetUsersList()
        {
            using (SqlCommand command = new SqlCommand("GetAllUsers", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Prepare();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Name = (string)reader["UserName"];
                        int Balance = (int)reader["Balance"];
                        int Level = (int)reader["CollectorLevel"];
                        string Country = (string)reader["UserCountry"];
                        bool IsBlocked = (bool)reader["IsBlocked"];
                        bool IsAdmin = (bool)reader["IsAdmin"];
                        int CountOfCars = (int)reader["Cars"];
                        yield return new User(Name, Balance, Level, Country, IsBlocked, IsAdmin, CountOfCars);
                    }
                }
            }
        }

        public void BlockUser(string _Name)
        {
            using (SqlCommand command = new SqlCommand("UserBlocking", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 25);

                command.Prepare();

                command.Parameters[0].Value = _Name;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PurchaseInfo> GetPurchaseHistoryForThisUser(string _Name)
        {
            using (SqlCommand command = new SqlCommand("GetPurchaseHistoryForSelectedUser", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 25);

                command.Prepare();

                command.Parameters[0].Value = _Name;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string model = (string)reader["ShortModelTitle"];
                        DateTime timeOfPurchase = (DateTime)reader["TimeOfPurchase"];
                        string operationType = (string)reader["OperationTypeTitle"];
                        int balance = (int)reader["Balance"];
                        int collectorScore = (int)reader["CollectorScore"];
                        yield return new PurchaseInfo(model, timeOfPurchase.ToString(), operationType, balance, collectorScore);
                    }
                }
            }
        }

        public void DeleteUser(string _user)
        {
            using (SqlCommand command = new SqlCommand("DeleteUser", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 25);

                command.Prepare();

                command.Parameters[0].Value = _user;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<string> GetSortingTypesList()
        {
            using (SqlCommand command = new SqlCommand("GetAllSortingTypes", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Prepare();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string SortingType = (string)reader["SortingTypeTitle"];
                        yield return SortingType;
                    }
                }
            }
        }

        public void SetUnitsSystemForThisUser(string user, User.UnitsSystem unitsSystem)
        {
            using (SqlCommand command = new SqlCommand("SetDefaultUnitsSystemForSelectedUser", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 25);
                command.Parameters.Add("@UnitsSystem", SqlDbType.Int);

                command.Prepare();

                command.Parameters[0].Value = user;
                command.Parameters[1].Value = (int)unitsSystem;

                command.ExecuteNonQuery();
            }
        }

        public void ReturnToDefaultUnitsSystem(string _user)
        {
            using (SqlCommand command = new SqlCommand("ReturnToStandardUnitsSystemForThisCountry", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 25);

                command.Prepare();

                command.Parameters[0].Value = _user;
                command.ExecuteNonQuery();
            }
        }
    }
}