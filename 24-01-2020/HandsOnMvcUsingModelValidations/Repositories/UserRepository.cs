using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMvcUsingModelValidations.Models;
namespace HandsOnMvcUsingModelValidations.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>()
        {

        new User()
        {
            Name = "devika",
                Country = "India",
                Uname = "dev530",
                Pwd = "12345"

            }
        }; 
        public UserRepository()
        {
           
        }
        public void Add(User item)
        {
            list.Add(item);
        }
         
        public User Validate(string uname,string pswd)
        {
            foreach(var item in list)
            {
                if(item.Uname==uname && item.Pwd==pswd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
