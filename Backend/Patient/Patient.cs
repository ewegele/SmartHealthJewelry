using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BackendCS.Event;

namespace BackendCS
{
    public class Patient
    {
        private string _firstname;
        private string _lastname;
        private int _age;
        private List<ContactPerson> _contacts;
        private HealthData _healthData;

        public Patient(string firstname, string lastname, int age)
        {
                _firstname = firstname;
                _lastname = lastname;
                _age = age;
                _contacts = new List<ContactPerson>();
                _healthData = new HealthData();
        }

        public void setContactPerson(ContactPerson contact)
        {
            _contacts.Add(contact);

            
            // For Testing
            //NotifyContacts("New Contact " + contact.ToString() + " added to contact list from " + _firstname + " " + _lastname);
        }

        public void NotifyContacts(string message)
        {
            foreach (var contact in _contacts)
            {
                contact.Notify(message);
            }
        }

        public void NotifyContacts(string subject, string message)
        {
            foreach (var contact in _contacts)
            {
                contact.Notify(subject,message);
            }
        }

        public override string ToString()
        {
            return _firstname + " " + _lastname;
        }
    }
}
