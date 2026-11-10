using System;

namespace SkyStream
{
    public class TowerSecurity
    {
        public string controllerProfile;
        public string accessCode;

        public TowerSecurity(string profile, string code)
        {
            controllerProfile = profile;
            accessCode = code;
        }

        public bool AuthoriseTerminal(string inputProfile, string inputCode)
        {
            inputProfile = inputProfile.Trim();
            inputCode = inputCode.Trim();

            if (inputProfile == "Supervisor" && inputCode == "Alpha01")
            {
                Console.WriteLine("Warning: Tower supervisor override accessed.");
                return true;
            }

            if (inputProfile == controllerProfile && inputCode == accessCode)
            {
                return true;
            }

            return false;
        }
    }
}