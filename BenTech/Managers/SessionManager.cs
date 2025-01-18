using BenTech.Models;

namespace BenTech
{
    class SessionManager
    {
        private static SessionManager instance;
        public bool IsLoggedIn { get; private set; } = false;
        public User CurrentUser { get; private set; }
        private SessionManager()
        {
            IsLoggedIn = false;
        }
        public static SessionManager Instance
        {
            get
            {
                return instance ?? (instance = new SessionManager());
            }
        }

        public bool Login(string username, string password)
        {
            var databaseRepository = new DatabaseRepository();
            var (userNameFromDb,isAdminFromDb) = databaseRepository.Login(username, password);
            if (!string.IsNullOrEmpty(userNameFromDb))
            {
                CurrentUser = User.Instance(userNameFromDb, isAdminFromDb);
                return true;
            }
            return false;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            CurrentUser = null;
        }
    }

}
