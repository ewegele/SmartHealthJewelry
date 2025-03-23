using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BackendCS
{
   public class ProfileChangements
   {
      public int LogIn(string loginname, string password)
      {
         if (LoginnameAlreadyExisting(loginname))
         {
            if (correctPassword(loginname, password))
            {
               setProfile(loginname, password);
               return 0;
            }
            return 1;
         }
         return 2;
      }

      public bool SignIn(string loginname, string password)
      {
         if (LoginnameAlreadyExisting(loginname))
         {
            return false;
         }
         //neuer User
         Dictionary<string, string> users = getUsers();
         users.Add(loginname, password);
         saveNewUsers(users);

         setProfile(loginname, password);

         return true;
      }


      private void setProfile(string loginname, string password)
      {
         Backend.Instance().GetProfile().sSetPassword(password);
         Backend.Instance().GetProfile().sSetLoginname(loginname);
      }



      private static bool LoginnameAlreadyExisting(string loginname)
      {
         return (getUsers().ContainsKey(loginname));
      }



      private static bool correctPassword(string loginname, string password)
      {
         return (getUsers()[loginname] == password);
      }



      public static Dictionary<string, string> getUsers()
      {
         // Load the JSON string from the settings file
         string jsonDic = Properties.Settings.Default.Users;

         // Deserialize the JSON string back to a dictionary
         Dictionary<string, string> users = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonDic);
         if (users == null)
         {
            users = new Dictionary<string, string>();
         }
         return users;
      }


      private static void saveNewUsers(Dictionary<string, string> users)
      {
         // Serialize the dictionary to a JSON string
         string jsonDic = JsonConvert.SerializeObject(users);

         // Save the JSON string to the settings file
         Properties.Settings.Default.Users = jsonDic;
         Properties.Settings.Default.Save();
      }
   }
}
