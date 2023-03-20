using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threads20_03
{
    internal class UzivatelManager
    {
        private List<Uzivatel> uzivateli = new List<Uzivatel>();
        
        public bool AddUser()
        {
            Uzivatel uzivatel = CreateUzivatel();

            return false;
        }

        private Uzivatel CreateUzivatel()
        {
            String? name = null;
            String password;
            UserRights userRights;

            while (name == null)
            {
                name = CreateUzivatelName();
            }

            password = CreatePassword();
            userRights = AddRights();

        }

        private UserRights AddRights()
        {
            throw new NotImplementedException();
        }

        private string CreatePassword()
        {
            throw new NotImplementedException();
        }

        private string? CreateUzivatelName()
        {
            String name = null;
            Console.WriteLine("Please enter user name");
            name = Console.ReadLine();
            if (!UzivatelCheck(name))
            {
                return null;
            }
            return name;
        }

        private bool UzivatelCheck(string? name)
        {

        }

    }
}
