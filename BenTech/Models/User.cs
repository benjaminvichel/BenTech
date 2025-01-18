using System;

namespace BenTech.Models
{
    public class User
    {
        private static User instance;
        public string Username { get;private  set; }
        public Boolean Is_admin { get; private set; }
      
        private User(string username,Boolean is_admin)
        {
            Username = username;
            Is_admin = is_admin;
        }

        public static User Instance(string username, bool isAdmin)
        {
            if (instance == null)
            {
                instance = new User(username, isAdmin);
            }
            else
            {
                // Atualize a instância existente com os novos dados
                instance.Username = username;
                instance.Is_admin = isAdmin;
            }
            return instance;
        }


    }
}