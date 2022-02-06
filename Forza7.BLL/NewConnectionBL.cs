using Kursach5.DAL;

namespace Kursach5.BLL
{
    public class NewConnectionBL
    {
        private readonly NewConnectionDAO newConnectionDAO;

        public NewConnectionBL()
        {
            newConnectionDAO = new NewConnectionDAO();
        }

        public void DeployDatabase(string ConnectionTitle, string ServerName, bool IntegratedSecurity, out int result, out string message, string UserName = "", string UserPassword = "")
        {
            newConnectionDAO.DeployDataBase(ConnectionTitle, ServerName, IntegratedSecurity, out result, out message, UserName, UserPassword);
        }
    }
}