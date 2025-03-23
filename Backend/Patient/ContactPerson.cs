using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
    public class ContactPerson
    {
        private String _firstname;
        private String _lastname;
        private String _phonenumber;
        private String _email;
        private NotificationMethod _notificationMethod;


        public ContactPerson(string firstname, string lastname, string phonenumber, string email, NotificationMethod notificationMethod )
        {
            _firstname = firstname;
            _lastname = lastname;
            _phonenumber = phonenumber;
            _email = email;
            _notificationMethod = notificationMethod;
        }

        public override string ToString()
        {
            return _firstname + " " + _lastname;
        }

        public void SetNotificationMethod(NotificationMethod notificationMethod)
        {
            _notificationMethod = notificationMethod;
        }

        public void Notify(string message)
        {
            if(_notificationMethod.GetType() == typeof(SMS))
            {
                SMS.Send(_phonenumber,message);
            }
            else
            {
                Notify("Warning",message);
            }
        }

        public void Notify(string subject, string message)
        {
            Email.Send(_email,subject,message);
        }
    }
}
