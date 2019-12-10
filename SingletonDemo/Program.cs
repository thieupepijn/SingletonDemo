using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        //Demo program for the singleton pattern
        //Suppose that in a game there is one unique random enemy
        //which throughout a gemesession should be the same. A perfect
        //usecase for the singleton pattern.

        static void Main(string[] args)
        {        
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(EnemyEncounter());
            }
           
            Console.ReadKey();

        }

        private static string EnemyEncounter()
        {
            Enemy enemy = Enemy.GetEnemy();

            return string.Format("{0} is approaching !", enemy.Name);

        }


    }
}
