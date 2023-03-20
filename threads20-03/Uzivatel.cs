using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threads20_03
{
    public enum UserRights
    {
        Admin,
        Staff,
        User,
    }

    internal class Uzivatel
    {
        private String uzivatelLoginName;
        private String uzivatelPassword;
        private UserRights uzivatelPrava;

        public Uzivatel(string uzivatelLoginName, string uzivatelPassword, UserRights uzivatelPrava)
        {
            this.uzivatelLoginName = uzivatelLoginName;
            this.uzivatelPassword = uzivatelPassword;
            this.uzivatelPrava = uzivatelPrava;
        }
        public string UzivatelLoginName { get => uzivatelLoginName; set => uzivatelLoginName = value; }
        public string UzivatelPassword { get => uzivatelPassword; set => uzivatelPassword = value; }
        public UserRights UzivatelPrava { get => uzivatelPrava; set => uzivatelPrava = value; }
    }
}
