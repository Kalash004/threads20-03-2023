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


        public List<Uzivatel> GetUzivateliPodlePrav(UserRights rights)
        {
            var users = uzivateli.AsParallel().Where(uziv => uziv.UzivatelPrava == rights).ToList();
            return users;
        }

        public Uzivatel GetUzivatelPodleHesla(string heslo)
        {
            var user = uzivateli.AsParallel().First(user => user.UzivatelPassword.Equals(heslo));
            return user;
        }

        public bool AddUser()
        {
            Uzivatel uzivatel = CreateUzivatel();
            uzivateli.Add(uzivatel);
            return true;
        }

        public bool AddUser(Uzivatel uziv)
        {
            uzivateli.Add(uziv);
            return true;
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
            password = CreatePassword(name);
            userRights = AddRights(name);
            return new Uzivatel(name, password, userRights);
        }

        private UserRights AddRights(string name)
        {
            UserRights thisUserRights;
            int ans = -1;
            Console.WriteLine($"Please write number of the user right you want to add to the user : {name}");
            foreach (int i in Enum.GetValues(typeof(UserRights)))
            {
                Console.WriteLine($"{i} : {Enum.GetName(typeof(UserRights), i)}");
            }
            try
            {
                ans = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return (UserRights)ans;
        }

        private string CreatePassword(string name)
        {
            Console.WriteLine($"Please enter password for the user {name}");
            var pas = Console.ReadLine();
            Console.WriteLine("Password added");
            return pas;
        }

        private string? CreateUzivatelName()
        {
            String name = null;
            Console.WriteLine("Please enter user name");
            name = Console.ReadLine();
            if (!UzivatelCheck(name))
            {
                Console.WriteLine("User with same name was already created");
                return null;
            }
            Console.WriteLine("Name added");
            return name;
        }

        private bool UzivatelCheck(string? name)
        {
            if (uzivateli.Any(uziv => uziv.UzivatelLoginName.Equals(name)))
            {
                return false;
            }
            return true;
        }

    }
}
