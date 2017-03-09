using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatebraAssignmet
{
    class Program
    {
         static void Main(string[] args)
        {
            //create object of the country class
            Country uk = new Country();
            uk.Name = "United Kingdom";
            uk.President = "Theresa May";
            uk.Landmass = 945999f;
            uk.GDP = 51.4m;
            uk.States = new List<string> { "London", "Manchester", "Liverpool" };
            //print out country info
            uk.PrintProfile();

            //create another object
            Country nigeria = new Country();
            nigeria.Name = "Nigeria";
            nigeria.President = "Buhari";
            nigeria.Landmass = 945999f;
            nigeria.GDP = 51.4m;
            nigeria.States = new List<string> { "Lagos", "Abuja", "Ogun" };
            nigeria.AddState("Oyo");
            nigeria.AddState("Kastina");
            nigeria.PrintProfile();
            nigeria.PrintState();

            //create cameroun object
            Country cameroun = new Country();
            cameroun.Name = "Cameroun";
            cameroun.President = "Paul Biya";
            cameroun.Landmass = 23443f;
            cameroun.GDP = 50m;
            cameroun.States = new List<string> { "Littoral", "Extreme-Nord", "Adamaoua" };
            cameroun.PrintProfile();

            Console.ReadLine();
        }
    }
  }

