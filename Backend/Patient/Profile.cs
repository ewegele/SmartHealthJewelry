using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
    public class Profile
    {
        private string _loginname;
        private string _password;
        private Patient[] _patients;
        private int _Index;                         //current Patient
        private int _Size;

        public Profile()
        {
            _Size = 4;
            _patients = new Patient[_Size];


            // Initialsierung von Patienten
            _patients[0] = new Patient("Wilhelm", "Becker", 79);
            _patients[0].setContactPerson(new ContactPerson("Gernod","Hassknecht","+14917630548044","ewegele@stud.hs-offenburg.de", new Email()));
            _patients[1] = new Patient("Hannelore", "Mueller", 75);
            _patients[1].setContactPerson(new ContactPerson("Peter","Müller","+4917630548044", "mriebsch@stud.hs-offenburg.de", new Email()));
            _patients[2] = new Patient("Heinrich", "Meier", 85);
            _patients[2].setContactPerson(new ContactPerson("Emma","Meier","+4917630548044","dapelt@stud.hs-offenburg.de",new Email()));
            _patients[3] = new Patient("Gertrud", "Schmitz", 80);
            _patients[3].setContactPerson(new ContactPerson("Schmitzs","Katze","+4917630548044","lbruestl1@stud.hs-offenburg.de",new Email()));
        }


        public string sGetLoginname()
        {
            return _loginname;
        }

        public string sGetPassword()
        {
            return _password;
        }

        public void sSetLoginname(string email)
        {
           _loginname = email;
       }

         public void sSetPassword(string password)
         {
           _password = password;
         }

         public void SetPatient(int index)
         {
             if (index >= 0 && index < _patients.Length)
             {
                 _Index = index;
             }
             else
             {
                 throw new IndexOutOfRangeException("Patient ID is not valid");
             }
         }
         public Patient GetPatient()
         {
             return _patients[_Index];
         }

        public override string ToString()
        {
            return _loginname;
        }
    }
}
