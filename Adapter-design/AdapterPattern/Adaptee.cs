using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Adaptee
    {
        public string[][] GetDevelopers()
        {
            string[][] Developers = new string[4][];
            Developers[0] = new string[] { "100", "Abenezer", "Tall" };
            Developers[1] = new string[] { "101", "Amanuel", "Player" };
            Developers[2] = new string[] { "102", "Tariku", "Short" };
            Developers[3] = new string[] { "103", "Nugusa", "Defender" };
            return Developers;
        }
    }
}
