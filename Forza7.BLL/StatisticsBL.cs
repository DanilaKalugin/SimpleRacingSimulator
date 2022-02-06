using Entities;
using Kursach5.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Kursach5.BLL
{
    public class StatisticsBL
    {
        private readonly MainEntitiesDAO entitiesDAO;
        private readonly UserDAO userDAO;

        public enum Direction { Ascending, Descending }
        public enum SortingCriterion { Power, Price, Weight, PowerToWeight }
        public enum UserSortingCriterion { Balance, Level, Cars}
        public StatisticsBL()
        {
            entitiesDAO = new MainEntitiesDAO();
            userDAO = new UserDAO();
        }

        public List<Car> GetSortedCarsList(Direction direction, SortingCriterion criterion)
        {
            List<Car> cars = entitiesDAO.GetCarsList("").ToList();
            switch (criterion)
            {
                case SortingCriterion.Power:
                    {
                        if (direction == Direction.Ascending)
                        {
                            cars = cars.OrderBy(car => car.Power).ToList();
                        }
                        else
                        {
                            cars = cars.OrderByDescending(car => car.Power).ToList();
                        }
                        break;
                    }
                case SortingCriterion.Price:
                    {
                        if (direction == Direction.Ascending)
                        {
                            cars = cars.OrderBy(car => car.Price).ToList();
                        }
                        else
                        {
                            cars = cars.OrderByDescending(car => car.Price).ToList();
                        }
                        break;
                    }
                case SortingCriterion.Weight:
                    {
                        if (direction == Direction.Ascending)
                        {
                            cars = cars.OrderBy(car => car.Weight).ToList();
                        }
                        else
                        {
                            cars = cars.OrderByDescending(car => car.Weight).ToList();
                        }
                        break;
                    }
                case SortingCriterion.PowerToWeight:
                    {
                        if (direction == Direction.Ascending)
                        {
                            cars = cars.OrderBy(car => car.PowerToWeight()).ToList();
                        }
                        else
                        {
                            cars = cars.OrderByDescending(car => car.PowerToWeight()).ToList();
                        }
                        break;
                    }
            }
            return cars;
        }

        public List<Manufacturer> GetSortedManufacturersList(Direction direction)
        {
            List<Car> cars = entitiesDAO.GetCarsList("").ToList();
            List<Manufacturer> manufacturers = entitiesDAO.GetManufacturersList().OrderBy(manufacturer => manufacturer.Title).ToList();
            switch (direction)
            {
                case Direction.Ascending:
                    {
                        manufacturers = manufacturers.OrderBy(manufacturer => cars.Count(car => car.manufacturer == manufacturer.Title)).ToList();
                        break;
                    }
                case Direction.Descending:
                    {
                        manufacturers = manufacturers.OrderByDescending(manufacturer => cars.Count(car => car.manufacturer == manufacturer.Title)).ToList();
                        break;
                    }
            }
            return manufacturers;
        }

        public List<Country> GetSortedCountriesList(Direction direction)
        {
            List<Manufacturer> manufacturers = entitiesDAO.GetManufacturersList().OrderBy(manufacturer => manufacturer.Title).ToList();
            List<Country> countries = entitiesDAO.GetCountriesList().OrderBy(country => country.CountryName).ToList();
            switch (direction)
            {
                case Direction.Ascending:
                    {
                        countries = countries.OrderBy(country => manufacturers.Count(manufacturer => manufacturer.Country == country.CountryCode)).Where(country => manufacturers.Count(manufacturer => manufacturer.Country == country.CountryCode) > 0).ToList();
                        break;
                    }
                case Direction.Descending:
                    {
                        countries = countries.OrderByDescending(country => manufacturers.Count(manufacturer => manufacturer.Country == country.CountryCode)).Where(country => manufacturers.Count(manufacturer => manufacturer.Country == country.CountryCode) > 0).ToList();
                        break;
                    }
            }
            return countries;
        }

        public List<SortingCriterion> GetSortingCriteria()
        {
            List<SortingCriterion> sortingCriterions = new List<SortingCriterion>();
            sortingCriterions.Add(SortingCriterion.Power);
            sortingCriterions.Add(SortingCriterion.Price);
            sortingCriterions.Add(SortingCriterion.Weight);
            sortingCriterions.Add(SortingCriterion.PowerToWeight);
            return sortingCriterions;
        }

        public List<UserSortingCriterion> GetSortingCriterions()
        {
            List<UserSortingCriterion> sortingCriteria = new List<UserSortingCriterion>();
            sortingCriteria.Add(UserSortingCriterion.Balance);
            sortingCriteria.Add(UserSortingCriterion.Level);
            sortingCriteria.Add(UserSortingCriterion.Cars);
            return sortingCriteria;
        }

        public List<User> GetSortedUsersList(Direction direction, UserSortingCriterion criterion)
        {
            List<User> users = userDAO.GetUsersList().ToList();
            switch (criterion)
            {
                case UserSortingCriterion.Balance:
                    {
                        if (direction == Direction.Ascending)
                        {
                            users = users.OrderBy(user => user.Balance).ToList();
                        }
                        else
                        {
                            users = users.OrderByDescending(user => user.Balance).ToList();
                        }
                        break;
                    }
                case UserSortingCriterion.Level:
                    {
                        if (direction == Direction.Ascending)
                        {
                            users = users.OrderBy(user => user.CollectorLevel).ToList();
                        }
                        else
                        {
                            users = users.OrderByDescending(user => user.CollectorLevel).ToList();
                        }
                        break;
                    }
                case UserSortingCriterion.Cars:
                    {
                        if (direction == Direction.Ascending)
                        {
                            users = users.OrderBy(user => user.CountOfCars).ToList();
                        }
                        else
                        {
                            users = users.OrderByDescending(user => user.CountOfCars).ToList();
                        }
                        break;
                    }
            }
            return users;
        }
    }
}