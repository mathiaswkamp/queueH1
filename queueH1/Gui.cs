using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using queueH1;

namespace queueH1 
{

    /// <summary>
    /// Gui klassen
    /// har en methode renderMenu som uskriver min menu som man kan vælge fra
    /// </summary>
    class gui
    {
        public void renderMenu()
        {

            Console.WriteLine("=============================================");
            Console.WriteLine("         H1 Queue operations menu ");
            Console.WriteLine("=============================================");

            Console.WriteLine("1. Add persons");
            Console.WriteLine("2. Delete person");
            Console.WriteLine("3. Show the number of persons");
            Console.WriteLine("4. Show min and max persons");
            Console.WriteLine("5. Find a person");
            Console.WriteLine("6. Show all persons");
            Console.WriteLine("7. Exit");
        }
    }
}