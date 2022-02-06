using Kursach5.DAL;
using System.Collections.Generic;
using System.Linq;
using Entities;
using System;

namespace Kursach5.BLL
{
    public class ManufacturersBL
    {
        private readonly MainEntitiesDAO mainEntitiesDAO;
        public enum SortingType { Country, FirstLetter };

        public ManufacturersBL()
        {
            mainEntitiesDAO = new MainEntitiesDAO();
        }

        public List<List<Manufacturer>> GetManufacturerslistGroupByParameter(out List<string> newGroups, SortingType Parameter)
        {
            List<string> groups = new List<string>();
            List<Manufacturer> manufacturersList = mainEntitiesDAO.GetManufacturersList().OrderBy(manufacturer => manufacturer.Title).ToList();
            List<Country> countries = mainEntitiesDAO.GetCountriesList().ToList();
            switch (Parameter)
            {
                case SortingType.Country:
                    {
                        countries = countries.Where(str => manufacturersList.Count(manufacturer => manufacturer.Country == str.CountryCode) > 0).OrderBy(country => country.CountryName).ToList();
                        groups = countries.Select(country => country.CountryName).ToList();
                        break;
                    }
                case SortingType.FirstLetter:
                    {
                        List<char> Firstletters = GetFirstLettersOfTitleList().ToList();
                        foreach (char s in Firstletters)
                        {
                            groups.Add(s.ToString());
                        }
                        break;
                    }
            }
            List<List<Manufacturer>> manufacturers = new List<List<Manufacturer>>();
            for (int i = 0; i < groups.Count; i++)
            {
                manufacturers.Add(new List<Manufacturer>());
            }
            switch (Parameter)
            {
                case SortingType.Country:
                    {
                        for (int i = 0; i < manufacturers.Count; i++)
                        {
                            manufacturers[i] = manufacturersList.Where(manufacturer => manufacturer.Country == countries[i].CountryCode).ToList();
                        }
                        break;
                    }
                case SortingType.FirstLetter:
                    {
                        for (int i = 0; i < manufacturers.Count; i++)
                        {
                            manufacturers[i] = manufacturersList.Where(manufacturer => manufacturer.Title[0] == groups[i][0]).ToList();
                        }
                        break;
                    }
            }
            if (Parameter == SortingType.FirstLetter)
            {
                newGroups = groups;
            }
            else
            {
                newGroups = countries.Select(country => country.CountryName).ToList();
            }
            return manufacturers;
        }

        private List<char> GetFirstLettersOfTitleList()
        {
            List<Manufacturer> manufacturers = mainEntitiesDAO.GetManufacturersList().ToList();
            return manufacturers.Select(manufacturer => manufacturer.Title[0]).Distinct().OrderBy(ch => ch).ToList();
        }

        public void UpdateManufacturer(Manufacturer newManufacturerInfo)
        {
            mainEntitiesDAO.UpdateManufacturer(newManufacturerInfo);
        }

        public int GetCarsCountForManufacturer(Manufacturer manufacturer)
        {
            List<Car> cars = mainEntitiesDAO.GetCarsList("").ToList();
            return cars.Where(car => car.manufacturer == manufacturer.Title).Count();
        }

        public void AddManufacturer(Manufacturer manufacturerWithNewInfo)
        {
            mainEntitiesDAO.AddManufacturer(manufacturerWithNewInfo);
        }
    }
}