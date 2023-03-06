using System;

namespace Human
{
    class Manifest
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Manifest(string vName)
        {
            name = vName;
        }
    }
}