using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAL;

namespace BLL
{
    public class BusinessLogic
    {
       
        public string ReturnName(string user, string pass)
        {
            string FullName;
            DataAccess Name = new DataAccess();
            FullName = Name.SearchUsers(user, pass);
            return FullName;
        }
        public bool AddingValue(string user, string pass, string FullName)
        {
            bool validity;
            DataAccess CheckValid = new DataAccess();
            validity = CheckValid.AddAccount(user, pass, FullName);
            return validity;
        }

             
    }
}
