using CocoMobileShopApp.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocoMobileShopApp.Controller
{
    public class UsersController
    {
          
       
        public User Login(string Email , string Password)
        {

            var context = new AppContext();
            //do Encryption for password
            var user = context.Users.Include(b => b.Branches).SingleOrDefault(u => u.Email == Email && u.Password == Password);
            return user;
        }
    }
}
