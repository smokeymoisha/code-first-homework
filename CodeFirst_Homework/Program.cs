using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new ObjectiveManager();

            var objectives = manager.GetAllObjectives();

            foreach(var obj in objectives)
            {
                Console.WriteLine($"ID: {obj.Id}, Text: {obj.Text}");
            }

            manager.CompleteObjectiveById(2);

            Console.ReadKey();
        }
    }
}
