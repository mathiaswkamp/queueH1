using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace queueH1
{
    class Program
    {
        static void Main(string[] args)
        {
            // opretter nyt gui object
            gui Gui = new gui();

            // kalder gui funktionen renderMenu
            Gui.renderMenu();

            // opretter en ny queue og kalder den callDoctor
            Queue<CallDoctor> callDoctor = new Queue<CallDoctor>();

            bool start = false;
            // while loop der aldrig stopper
            while (!start)
            {
                // int userinput til at brugeren kan vælge i menuen
                int userinput = int.Parse(Console.ReadLine());

                // switch statement til at switche på hvad brugeren vælger i menuen
                switch (userinput)
                {
                    case 1:

                        Console.Write("Insert name of the caller: ");
                        string userInputName = Console.ReadLine();
                        string userInputcpr = Console.ReadLine();
                        // opretter nyt object i queuen
                        callDoctor.Enqueue(new CallDoctor() {Name = userInputName, Cpr = userInputcpr});
                        Console.Clear();
                        Gui.renderMenu();
                        break;


                    case 2:
                        Console.Clear();
                        // dequeue´er den første som er tilføjet til queue´en
                        CallDoctor FirstToleave = callDoctor.Dequeue();
                        Console.WriteLine("the first person that was added is: {0} with cpr {1} been deleted from the queue ", FirstToleave.Name);
                        Thread.Sleep(2000);
                        Console.Clear();
                        Gui.renderMenu();

                        break;


                    case 3:
                        Console.Clear();
                        // counter hvor mange objecter der er i queue´en
                        Console.WriteLine("there is: {0} people left in queue ",callDoctor.Count());
                        Thread.Sleep(2000);
                        Console.Clear();
                        Gui.renderMenu();


                        break;

                        // Camilla jeg forstår ikke hvad jeg kan gøre med min og max i dette tilfælde ?
                    case 4:
                        Console.Clear();
                        Console.WriteLine("The minimum value is: {0}, the maximum value is. {1} ", callDoctor.Min(), callDoctor.Max());
                        

                        break;


                    case 5:
                        Console.Clear();
                        Console.WriteLine("insert a name that you wants to check if it exists in the queue:");
                        string UserSearchName = Console.ReadLine();

                        // konverteter min queue til et array
                        CallDoctor [] callerArray = callDoctor.ToArray();

                        //string[] callerArray = {"mathias", "john"};

                        // hvis jeg udkommenterer linjen over denne så og kommenterer linjen hvor jeg konverterer min queue til et array. Så kan man søge efter et navn
                        // ellers så kan jeg ikke få dette til at virke
                        int indexnumber = -1;

                        // denne returnerer et nummer til index hvis det som brugeren søger på eksisterer i queue´en / arrayet
                        int index = Array.IndexOf(callerArray, UserSearchName);

                        // tjekker om nummeret er større end -1 da det vil det være hvis objektet brugeren søger på er i queue´en / arrayet
                        if (index > indexnumber)
                        {

                            Console.WriteLine("{0} exists in the queue ",UserSearchName);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not in the queue",UserSearchName);
                        }


                        Thread.Sleep(2000);
                        Gui.renderMenu();

                        break;
                        
                    case 6:
                        // udskriver alle objekter i queue´en
                        Console.Clear();
                        foreach (CallDoctor callDoc in callDoctor)
                        {
                            Console.WriteLine("{0}} with cpr nummer of {1}", callDoc.Name, callDoc.Cpr);
                        }

                        Thread.Sleep(3000);
                        Console.Clear();
                        Gui.renderMenu();
                        break;


                    case 7:
                        Console.Clear();
                        break;


                    default:
                        break;
                }
            }
        }






        //

       
        //CallDoctor SoonToLeave = Calldoctor.Peek();

        //Console.WriteLine("the next person in the queue is :{0}", SoonToLeave.Name);
    }
}