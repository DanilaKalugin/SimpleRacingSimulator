using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Entities;
using Kursach5.DAL;

namespace Kursach5.BLL
{
    public class CarsBL
    {
        public enum FilterOption { Power, Weight, PerformanceIndex, Year, Price }
        private readonly MainEntitiesDAO mainEntitiesDAO;

        public CarsBL()
        {
            mainEntitiesDAO = new MainEntitiesDAO();
        }

        public IEnumerable<Manufacturer> GetManufacturersList()
        {
            return mainEntitiesDAO.GetManufacturersList();
        }

        public List<List<Car>> GetCarsAndGroupsList(string user, User.SortingType ParameterNumber, out List<string> newGroups, int lowerPower, int upperPower, FilterOption OptionNumber)
        {
            List<string> groups = new List<string>();
            List<Car> carsList = mainEntitiesDAO.GetCarsList(user).OrderBy(car => car.manufacturer).ThenByDescending(car => car.Year).ThenByDescending(car => car.PI).ToList();
            List<Car> filteredCarsList = new List<Car>();
            switch (OptionNumber)
            {
                case FilterOption.Power:
                    {
                        filteredCarsList = carsList.Where(car => car.Power >= lowerPower && car.Power <= upperPower).ToList();
                        break;
                    }
                case FilterOption.Weight:
                    {
                        filteredCarsList = carsList.Where(car => car.Weight >= lowerPower && car.Weight <= upperPower).ToList();
                        break;
                    }
                case FilterOption.PerformanceIndex:
                    {
                        filteredCarsList = carsList.Where(car => car.PI >= lowerPower && car.PI <= upperPower).ToList();
                        break;
                    }
                case FilterOption.Year:
                    {
                        filteredCarsList = carsList.Where(car => car.Year >= lowerPower && car.Year <= upperPower).ToList();
                        break;
                    }
                case FilterOption.Price:
                    {
                        filteredCarsList = carsList.Where(car => car.Price >= lowerPower && car.Price <= upperPower).ToList();
                        break;
                    }
            }
            List<Car> OwnedCars = filteredCarsList.Select(s => s).Where(car => car.WasBought).ToList();

            switch (ParameterNumber)
            {
                case User.SortingType.Manufacturer:
                    {
                        groups = GetManufacturersList().Select(manufacturer => manufacturer.Title).OrderBy(title => title).ToList();
                        groups = groups.Where(str => filteredCarsList.Count(car => car.manufacturer == str) > 0).ToList();
                        break;
                    }
                case User.SortingType.Division:
                    {
                        groups = GetDivisionsList().ToList();
                        groups = groups.Where(str => filteredCarsList.Count(car => car.Division == str) > 0).ToList();
                        break;
                    }
                case User.SortingType.Class:
                    {
                        groups = GetClassesList(user).ToList();
                        groups = groups.Where(str => filteredCarsList.Count(car => car.carClass().ToString() == str) > 0).ToList();
                        break;
                    }
                case User.SortingType.Year:
                    {
                        List<int> yearsList = GetDecadesList(user).ToList();
                        yearsList = yearsList.Where(year => filteredCarsList.Count(car => car.Year >= year && car.Year <= year + 9) > 0).ToList();
                        foreach (int year in yearsList)
                        {
                            groups.Add(year.ToString());
                        }
                        break;
                    }
                case User.SortingType.Price:
                    {
                        List<int> pricesList = GetPricesList(user).OrderBy(price => price).ToList();
                        for (int i = 0; i < pricesList.Count - 1; i++)
                        {
                            if (filteredCarsList.Count(car => car.Price >= pricesList[i] && car.Price < pricesList[i + 1]) > 0)
                            {
                                groups.Add(pricesList[i].ToString());
                            }
                        }
                        if (filteredCarsList.Count(car => car.Price >= pricesList[pricesList.Count - 1]) > 0)
                        {
                            groups.Add(pricesList[pricesList.Count - 1].ToString());
                        }
                        break;
                    }
                case User.SortingType.Country:
                    {
                        List<Country> countries = GetCountriesList().ToList();
                        List<Manufacturer> manufacturers = GetManufacturersList().ToList();
                        manufacturers = manufacturers.Where(str => filteredCarsList.Count(car => car.manufacturer == str.Title) > 0).ToList();
                        countries = countries.Where(country => manufacturers.Count(manufacturer => manufacturer.Country == country.CountryCode) > 0).OrderBy(country => country.CountryName).ToList();
                        groups = countries.Select(country => country.CountryCode).ToList();
                        break;
                    }
            }
            groups.Insert(0, "My Cars");
            List<List<Car>> cars = new List<List<Car>>();
            for (int j = 0; j < groups.Count; j++)
            {
                cars.Add(new List<Car>());
            }
            cars[0] = OwnedCars;
            switch (ParameterNumber)
            {
                case User.SortingType.Manufacturer:
                    {
                        for (int j = 1; j < groups.Count; j++)
                        {
                            cars[j] = filteredCarsList.Where(car => car.manufacturer == groups[j]).ToList();
                        }
                        break;
                    }
                case User.SortingType.Division:
                    {
                        for (int j = 1; j < groups.Count; j++)
                        {
                            cars[j] = filteredCarsList.Where(car => car.Division == groups[j]).OrderByDescending(car => car.Year).ToList();
                        }
                        break;
                    }
                case User.SortingType.Class:
                    {
                        for (int j = 1; j < groups.Count; j++)
                        {
                            cars[j] = filteredCarsList.Where(car => car.carClass().ToString() == groups[j]).OrderByDescending(car => car.PI).ThenByDescending(car => car.Year).ToList();
                        }
                        break;
                    }
                case User.SortingType.Year:
                    {
                        for (int j = 1; j < groups.Count; j++)
                        {
                            int Year = int.Parse(groups[j]);
                            cars[j] = filteredCarsList.Where(car => car.Year >= Year && car.Year <= Year + 9).OrderByDescending(car => car.Year).ThenByDescending(car => car.PI).ToList();
                        }
                        break;
                    }
                case User.SortingType.Price:
                    {
                        for (int j = 1; j < groups.Count - 1; j++)
                        {
                            cars[j] = filteredCarsList.Where(car => car.Price >= int.Parse(groups[j]) && car.Price < int.Parse(groups[j + 1])).OrderBy(car => car.Price).ToList();
                        }
                        cars[groups.Count - 1] = filteredCarsList.Where(car => car.Price >= int.Parse(groups[groups.Count - 1])).OrderBy(car => car.Price).ToList();
                        break;
                    }
                case User.SortingType.Country:
                    {
                        for (int j = 1; j < groups.Count; j++)
                        {
                            List<string> manufacturersInCountry = GetManufacturersList().Where(manufacturer => manufacturer.Country == groups[j]).Select(manufacturer => manufacturer.Title).ToList();
                            cars[j] = filteredCarsList.Where(car => manufacturersInCountry.IndexOf(car.manufacturer) != -1).ToList();
                            cars[j] = cars[j].OrderByDescending(car => car.Year).ToList();
                        }
                        break;
                    }
            }

            newGroups = groups;
            switch (ParameterNumber)
            {
                case User.SortingType.Class:
                    {
                        for (int i = 1; i < newGroups.Count; i++)
                        {
                            newGroups[i] = "CLASS " + newGroups[i];
                        }
                        break;
                    }
                case User.SortingType.Year:
                    {
                        for (int i = 1; i < newGroups.Count; i++)
                        {
                            newGroups[i] = newGroups[i] + "s";
                        }
                        break;
                    }
                case User.SortingType.Manufacturer:
                    {
                        newGroups = GetManufacturersList().Where(str => filteredCarsList.Count(car => car.manufacturer == str.Title) > 0).OrderBy(manufacturer => manufacturer.Title).Select(manufacturer => manufacturer.ShortTitle).ToList();
                        newGroups.Insert(0, "My Cars");
                        break;
                    }
                case User.SortingType.Price:
                    {
                        for (int i = 1; i < newGroups.Count; i++)
                        {
                            newGroups[i] = int.Parse(newGroups[i]).ToString("N0", CultureInfo.InvariantCulture) + "CR+";
                        }
                        break;
                    }
                case User.SortingType.Country:
                    {
                        newGroups = GetCountriesList().Where(country => groups.IndexOf(country.CountryCode) != -1).OrderBy(country => country.CountryName).Select(country => country.CountryName).ToList();
                        newGroups.Insert(0, "My Cars");
                        break;
                    }
            }
            return cars;
        }

        public void ChangeCarStatus(Car car, string user)
        {
            mainEntitiesDAO.ChangeCarStatus(car.Year, car.manufacturer, car.Model, user);
        }

        public int GetBalance(string user)
        {
            return mainEntitiesDAO.GetBalance(user);
        }

        public int GetCollectorTier(out int score, out int lower, out int upper, string user)
        {
            return mainEntitiesDAO.GetCollectorTier(out score, out lower, out upper, user);
        }

        public void ResetPurchaseHistory(string UserName)
        {
            mainEntitiesDAO.ResetPurchaseHistory(UserName);
        }

        public void UpdateCar(Car OldCarStats, Car NewCarStats)
        {
            mainEntitiesDAO.UpdateCar(OldCarStats, NewCarStats);
        }

        public List<Country> GetCountriesList()
        {
            return mainEntitiesDAO.GetCountriesList().ToList();
        }

        public List<string> GetDivisionsList()
        {
            return mainEntitiesDAO.GetDivisionsList().OrderBy(str => str).ToList();
        }

        public List<int> GetDecadesList(string user)
        {
            return mainEntitiesDAO.GetCarsList(user).Select(car => (car.Year / 10 * 10)).OrderByDescending(str => str).Distinct().ToList();
        }

        public List<string> GetClassesList(string user)
        {
            return mainEntitiesDAO.GetCarsList(user).OrderByDescending(car => car.PI).Select(car => car.carClass().ToString()).Distinct().ToList();
        }

        public List<string> GetCollectionTierTitlesList()
        {
            return mainEntitiesDAO.GetCollectionTierTitlesList().ToList();
        }

        private List<int> GetPricesList(string user)
        {
            List<int> pricesBefore50000 = mainEntitiesDAO.GetCarsList(user).Where(car => car.Price < 50000).Select(car => car.Price / 5000 * 5000).Distinct().ToList();
            List<int> pricesBefore200000 = pricesBefore50000.Union(mainEntitiesDAO.GetCarsList(user).Where(car => car.Price >= 50000 && car.Price < 200000).Select(car => car.Price / 10000 * 10000).Distinct()).ToList();
            List<int> pricesBefore500000 = pricesBefore200000.Union(mainEntitiesDAO.GetCarsList(user).Where(car => car.Price >= 200000 && car.Price < 500000).Select(car => car.Price / 25000 * 25000).Distinct()).ToList();
            List<int> pricesBefore1000000 = pricesBefore500000.Union(mainEntitiesDAO.GetCarsList(user).Where(car => car.Price >= 500000 && car.Price < 1000000).Select(car => car.Price / 50000 * 50000).Distinct()).ToList();
            List<int> allPrices = pricesBefore1000000.Union(mainEntitiesDAO.GetCarsList(user).Where(car => car.Price >= 1000000).Select(car => car.Price / 250000 * 250000).Distinct()).ToList();
            return allPrices;
        }

        public List<Car> GetUnSortedCarList()
        {
            return mainEntitiesDAO.GetCarsList("").OrderBy(car => car.manufacturer).ThenByDescending(car => car.Year).ThenBy(car => car.Model).ToList();
        }

        public void AddCar(Car carWithNewStats)
        {
            mainEntitiesDAO.AddCar(carWithNewStats);
        }

        public void AddDivision(string DivisionTitle)
        {
            mainEntitiesDAO.AddDivision(DivisionTitle);
        }

        public void UpdateDivision(string oldTitle, string newTitle)
        {
            mainEntitiesDAO.UpdateDivision(oldTitle, newTitle);
        }
    }
}