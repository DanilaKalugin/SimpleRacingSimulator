using System.Collections.Generic;
using System.Linq;
using Entities;
using Kursach5.DAL;

namespace Kursach5.BLL
{
    public class UsersBL
    {
        private readonly UserDAO userDAO;

        public UsersBL()
        {
            userDAO = new UserDAO();
        }

        public int UserPasswordCheck(string Login, string Password)
        {
            return userDAO.UserPasswordCheck(Login, Password);
        }

        public User GetUserInformationByLogin(string Login)
        {
            return userDAO.GetUserInformationByLogin(Login).First();
        }

        public void AddUser(string Name, string Login, string Password, string Country, int SortingType)
        {
            userDAO.AddUser(Name, Login, Password, Country, SortingType);
        }

        public void UpdateUser(string OldName, string NewUserName, string NewLogin, string NewPassword, string NewCountry, int SortingType)
        {
            userDAO.UpdateUser(OldName, NewUserName, NewLogin, NewPassword, NewCountry, SortingType);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return userDAO.GetUsersList();
        }

        public void BlockUser(string User)
        {
            userDAO.BlockUser(User);
        }

        public IEnumerable<PurchaseInfo> GetPurchaseHistoryForThisUser(string _Name)
        {
            return userDAO.GetPurchaseHistoryForThisUser(_Name);
        }

        public void DeleteUser(string User)
        {
            userDAO.DeleteUser(User);
        }

        public IEnumerable<string> GetSortingTypesList()
        {
            return userDAO.GetSortingTypesList().ToList();
        }

        public void SetUnitsSystemForThisUser(string user, User.UnitsSystem unitsSystem)
        {
            userDAO.SetUnitsSystemForThisUser(user, unitsSystem);
        }

        public void ReturnToDefaultUnitsSystem(string _user)
        {
            userDAO.ReturnToDefaultUnitsSystem(_user);
        }
    }
}