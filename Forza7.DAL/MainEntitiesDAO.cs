using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;
using System.Configuration;
using System.Data;

namespace Kursach5.DAL
{
    public class MainEntitiesDAO : IDisposable
    {
        private SqlConnection _connection;

        public static string GetConnectionString()
        {
            var currentConnection = ConfigurationManager.AppSettings["CurrentConnectionString"];
            var connectionString = ConfigurationManager.ConnectionStrings[currentConnection].ConnectionString;
            return connectionString;
        }

        public MainEntitiesDAO()
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

        public IEnumerable<Manufacturer> GetManufacturersList()
        {
            using (SqlCommand command = new SqlCommand("GetAllManufacturers", _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Number = (int)reader["ManufacturerID"];
                        string Name = (string)reader["ManufacturerName"];
                        string Country = (string)reader["ManufacturerCountry"];
                        string ShortTitle = (string)reader["ManufacturerShortName"];
                        yield return new Manufacturer(Number, Name, Country, ShortTitle);
                    }
                }
            }
        }

        public void ResetPurchaseHistory(string UserName)
        {
            using (SqlCommand command = new SqlCommand("ResetPurchaseHistory", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@User", SqlDbType.NVarChar, 25);
                command.Prepare();
                command.Parameters[0].Value = UserName;
                var result = command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Car> GetCarsList(string user)
        {
            using (SqlCommand command = new SqlCommand("GetAllCars", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@User", SqlDbType.NVarChar, 25);
                command.Prepare();
                command.Parameters[0].Value = user;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Number = (int)reader["CarID"];
                        int Year = (int)reader["ModelYear"];
                        string Manufacturer = (string)reader["ManufacturerName"];
                        string Model = (string)reader["Model"];
                        string Division = (string)reader["DivisionTitle"];
                        int Price = (int)reader["Price"];
                        float Speed = (float)(double)reader["Speed"];
                        float Handling = (float)(double)reader["Handling"];
                        float Acceleration = (float)(double)reader["Acceleration"];
                        float Brake = (float)(double)reader["Brake"];
                        int Power = (int)reader["EnginePower"];
                        int Torque = (int)reader["Torque"];
                        int Weight = (int)reader["CarWeight"];
                        int FrontWeight = (int)reader["Front"];
                        int PI = (int)reader["PerformanceIndex"];
                        string Drive = (string)reader["Drive"];
                        string EnginePlacement = (string)reader["EnginePlacement"];
                        string Tier = (string)reader["CollectionLevelTitle"];
                        int Points = (int)reader["CollectionPoints"];
                        string ShortTitle = (string)reader["ShortModelTitle"];
                        bool IsFE = (bool)reader["IsFE"];
                        bool IsBought = (bool)reader["IsBought"];

                        yield return new Car(Year, Manufacturer, Model, Division, Price, Speed, Handling, Acceleration, Brake, Power, Torque, Weight, FrontWeight, PI, Drive, EnginePlacement, IsBought, Tier, Points, ShortTitle, IsFE, Number - 1);
                    }
                }
            }
        }

        public void AddManufacturer(Manufacturer manufacturerWithNewInfo)
        {
            using (SqlCommand command = new SqlCommand("AddManufacturer", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@NewManufacturerTitle", SqlDbType.NVarChar, 50));
                command.Parameters.Add(new SqlParameter("@NewManufacturerShortTitle", SqlDbType.NVarChar, 40));
                command.Parameters.Add(new SqlParameter("@NewManufacturerCountry", SqlDbType.NVarChar, 3));
                command.Prepare();
                command.Parameters[0].Value = manufacturerWithNewInfo.Title;
                command.Parameters[1].Value = manufacturerWithNewInfo.ShortTitle;
                command.Parameters[2].Value = manufacturerWithNewInfo.Country;
                command.ExecuteNonQuery();
            }
        }

        public int GetBalance(string user)
        {
            int budget;
            using (SqlCommand command = new SqlCommand("GetBalance", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter balance = new SqlParameter("@CurrentBalance", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(balance);
                command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 25));

                command.Prepare();

                command.Parameters[1].Value = user;
                var result = command.ExecuteScalar();
                budget = (int)balance.Value;
            }
            return budget;
        }

        public void ChangeCarStatus(int year, string manufacturer, string model, string user)
        {
            using (SqlCommand command = new SqlCommand("ChangeCarStatus", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Year", SqlDbType.SmallInt));
                command.Parameters.Add(new SqlParameter("@Manufacturer", SqlDbType.NVarChar, 50));
                command.Parameters.Add(new SqlParameter("@Model", SqlDbType.NVarChar, 70));
                command.Parameters.Add(new SqlParameter("@User", SqlDbType.NVarChar, 25));

                command.Prepare();

                command.Parameters[0].Value = year;
                command.Parameters[1].Value = manufacturer;
                command.Parameters[2].Value = model;
                command.Parameters[3].Value = user;

                var result = command.ExecuteNonQuery();
            }
        }

        public int GetCollectorTier(out int score, out int lower, out int upper, string user)
        {
            int level;
            using (SqlCommand command = new SqlCommand("GetCollectorLevel", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@User", SqlDbType.NVarChar, 25);

                SqlParameter currentScore = new SqlParameter("@CurrentScore", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                SqlParameter currentLevel = new SqlParameter("@Level", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                SqlParameter lowerBorder = new SqlParameter("@LowerBorder", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                SqlParameter upperBorder = new SqlParameter("@UpperBorder", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Prepare();
                command.Parameters["@User"].Value = user;
                command.Parameters.Add(currentLevel);
                command.Parameters.Add(lowerBorder);
                command.Parameters.Add(upperBorder);
                command.Parameters.Add(currentScore);

                var result = command.ExecuteScalar();

                score = (int)currentScore.Value;
                level = (int)currentLevel.Value;
                lower = (int)lowerBorder.Value;
                upper = (int)upperBorder.Value;
            }
            return level;
        }

        public void UpdateCar(Car oldCarStats, Car newCarStats)
        {
            using (SqlCommand command = new SqlCommand("UpdateCar", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@OldYear", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@OldManufacturer", SqlDbType.NVarChar, 50));
                command.Parameters.Add(new SqlParameter("@OldModel", SqlDbType.NVarChar, 70));
                command.Parameters.Add(new SqlParameter("@Year_NewValue", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Manufacturer_NewValue", SqlDbType.NVarChar, 50));
                command.Parameters.Add(new SqlParameter("@Model_NewValue", SqlDbType.NVarChar, 70));
                command.Parameters.Add(new SqlParameter("@Price_NewValue", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Speed_NewValue", SqlDbType.Float));
                command.Parameters.Add(new SqlParameter("@Handling_NewValue", SqlDbType.Float));
                command.Parameters.Add(new SqlParameter("@Acceleration_NewValue", SqlDbType.Float));
                command.Parameters.Add(new SqlParameter("@Brake_NewValue", SqlDbType.Float));
                command.Parameters.Add(new SqlParameter("@PerformanceIndex_NewValue", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@CollectionPoints_NewValue", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@CollectionTier_NewValue", SqlDbType.NVarChar, 15));
                command.Parameters.Add(new SqlParameter("@ShortModelTitle_NewValue", SqlDbType.NVarChar, 25));
                command.Parameters.Add(new SqlParameter("@Power_NewValue", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Torque_NewValue", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Weight_NewValue", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@FrontWeight_NewValue", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Division_NewValue", SqlDbType.NVarChar, 25));
                command.Parameters.Add(new SqlParameter("@Drive_NewValue", SqlDbType.NVarChar, 1));
                command.Parameters.Add(new SqlParameter("@EnginePlacement_NewValue", SqlDbType.NVarChar, 1));
                command.Parameters.Add(new SqlParameter("@IsFE", SqlDbType.Bit));
                command.Prepare();

                command.Parameters[0].Value = oldCarStats.Year;
                command.Parameters[1].Value = oldCarStats.manufacturer;
                command.Parameters[2].Value = oldCarStats.Model;
                command.Parameters[3].Value = newCarStats.Year;
                command.Parameters[4].Value = newCarStats.manufacturer;
                command.Parameters[5].Value = newCarStats.Model;
                command.Parameters[6].Value = newCarStats.Price;
                command.Parameters[7].Value = newCarStats.Speed;
                command.Parameters[8].Value = newCarStats.Handling;
                command.Parameters[9].Value = newCarStats.Acceleration;
                command.Parameters[10].Value = newCarStats.Brake;
                command.Parameters[11].Value = newCarStats.PI;
                command.Parameters[12].Value = newCarStats.CollectionPoints;
                command.Parameters[13].Value = newCarStats.CollectionTier;
                command.Parameters[14].Value = newCarStats.ShortTitle;
                command.Parameters[15].Value = newCarStats.Power;
                command.Parameters[16].Value = newCarStats.Torque;
                command.Parameters[17].Value = newCarStats.Weight;
                command.Parameters[18].Value = newCarStats.Front;
                command.Parameters[19].Value = newCarStats.Division;
                command.Parameters[20].Value = newCarStats.Drive;
                command.Parameters[21].Value = newCarStats.EnginePlacement;
                command.Parameters[22].Value = newCarStats.IsFE;

                var result = command.ExecuteNonQuery();
            }
        }

        public void AddCar(Car carWithNewStats)
        {
            using (SqlCommand command = new SqlCommand("AddCar", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Manufacturer", SqlDbType.NVarChar, 50));
                command.Parameters.Add(new SqlParameter("@Model", SqlDbType.NVarChar, 70));
                command.Parameters.Add(new SqlParameter("@Division", SqlDbType.NVarChar, 25));
                command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Speed", SqlDbType.Float));
                command.Parameters.Add(new SqlParameter("@Handling", SqlDbType.Float));
                command.Parameters.Add(new SqlParameter("@Acceleration", SqlDbType.Float));
                command.Parameters.Add(new SqlParameter("@Brake", SqlDbType.Float));
                command.Parameters.Add(new SqlParameter("@Power", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Torque", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Weight", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@FrontWeight", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@PerformanceIndex", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Drive", SqlDbType.NVarChar, 1));
                command.Parameters.Add(new SqlParameter("@EnginePlacement", SqlDbType.NVarChar, 1));
                command.Parameters.Add(new SqlParameter("@IsFE", SqlDbType.Bit));
                command.Parameters.Add(new SqlParameter("@CollectionPoints", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@CollectionTier", SqlDbType.NVarChar, 15));
                command.Parameters.Add(new SqlParameter("@ShortModelTitle", SqlDbType.NVarChar, 25));
                command.Prepare();

                command.Parameters[0].Value = carWithNewStats.Year;
                command.Parameters[1].Value = carWithNewStats.manufacturer;
                command.Parameters[2].Value = carWithNewStats.Model;
                command.Parameters[3].Value = carWithNewStats.Division;
                command.Parameters[4].Value = carWithNewStats.Price;
                command.Parameters[5].Value = carWithNewStats.Speed;
                command.Parameters[6].Value = carWithNewStats.Handling;
                command.Parameters[7].Value = carWithNewStats.Acceleration;
                command.Parameters[8].Value = carWithNewStats.Brake;
                command.Parameters[9].Value = carWithNewStats.Power;
                command.Parameters[10].Value = carWithNewStats.Torque;
                command.Parameters[11].Value = carWithNewStats.Weight;
                command.Parameters[12].Value = carWithNewStats.Front;
                command.Parameters[13].Value = carWithNewStats.PI;
                command.Parameters[14].Value = carWithNewStats.Drive;
                command.Parameters[15].Value = carWithNewStats.EnginePlacement;
                command.Parameters[16].Value = carWithNewStats.IsFE;
                command.Parameters[17].Value = carWithNewStats.CollectionPoints;
                command.Parameters[18].Value = carWithNewStats.CollectionTier;
                command.Parameters[19].Value = carWithNewStats.ShortTitle;

                var result = command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Country> GetCountriesList()
        {
            using (SqlCommand command = new SqlCommand("GetAllCountries", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Prepare();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Code = (string)reader["CountryCode"];
                        string Name = (string)reader["CountryName"];

                        yield return new Country(Code, Name);
                    }
                }
            }
        }

        public IEnumerable<string> GetDivisionsList()
        {
            using (SqlCommand command = new SqlCommand("GetAllDivisions", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Prepare();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Division = (string)reader["DivisionTitle"];
                        yield return Division;
                    }
                }
            }
        }

        public IEnumerable<string> GetCollectionTierTitlesList()
        {
            using (SqlCommand command = new SqlCommand(@"GetCollectionTiers", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Prepare();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string TierTitle = (string)reader["CollectionLevelTitle"];
                        yield return TierTitle;
                    }
                }
            }
        }

        public void UpdateManufacturer(Manufacturer newManufacturerInfo)
        {
            using (SqlCommand command = new SqlCommand("UpdateManufacturer", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ManufacturerNumber", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@NewManufacturerTitle", SqlDbType.NVarChar, 50));
                command.Parameters.Add(new SqlParameter("@NewManufacturerShortTitle", SqlDbType.NVarChar, 40));
                command.Parameters.Add(new SqlParameter("@NewManufacturerCountry", SqlDbType.NVarChar, 3));

                command.Prepare();

                command.Parameters[0].Value = newManufacturerInfo.Number;
                command.Parameters[1].Value = newManufacturerInfo.Title;
                command.Parameters[2].Value = newManufacturerInfo.ShortTitle;
                command.Parameters[3].Value = newManufacturerInfo.Country;
                var result = command.ExecuteNonQuery();
            }
        }

        public void AddDivision(string DivisionTitle)
        {
            using (SqlCommand command = new SqlCommand("AddDivision", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@DivisionName", SqlDbType.NVarChar, 25));
                command.Prepare();
                command.Parameters[0].Value = DivisionTitle;
                var result = command.ExecuteNonQuery();
            }
        }

        public void UpdateDivision(string OldDivisionTitle, string NewDivisionTitle)
        {
            using (SqlCommand command = new SqlCommand("UpdateDivision", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@OldTitle", SqlDbType.NVarChar, 25));
                command.Parameters.Add(new SqlParameter("@NewTitle", SqlDbType.NVarChar, 25));
                command.Prepare();
                command.Parameters[0].Value = OldDivisionTitle;
                command.Parameters[1].Value = NewDivisionTitle;
                var result = command.ExecuteNonQuery();
            }
        }
    }
}