using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace queueH1
{

    /// <summary>
    /// klassen CallDoctor har 2 attributer, name og Cpr
    /// som skal bruges til at oprette objekter af denne klasse
    /// </summary>
    class CallDoctor
    {

        
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string cpr;

        public string Cpr
        {
            get { return cpr; }
            set { cpr = value; }
        }


        



    }
}