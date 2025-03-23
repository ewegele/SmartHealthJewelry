using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
    internal class GUIBackend
    {
        private List<Profile> _profiles;

        public void AddProfile(Profile profile)
        {
            _profiles.Add(profile);
        }

        public void RemoveProfile(Profile profile)
        {
            _profiles.Remove(profile);

        }

        public void StartMonitoring() {}
        public void StopMonitoring() {}
        public void UpdateGUI() {}
    }
}
