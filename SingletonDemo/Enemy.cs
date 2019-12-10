using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Enemy
    {
        private static Enemy _enemy = null;

        public string Name { get; private set; }

        private Enemy()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);

            switch(randomNumber)
            {
                case 0: Name = "Conan the Slayer"; break;
                case 1: Name = "Olga the Fearless"; break;
                case 2: Name = "Draca FireBreath"; break;
                case 3: Name = "Lord Pain"; break;
            }
        }

        public static Enemy GetEnemy()
        {

            if (_enemy == null)
            {
                _enemy = new Enemy();
            }
            return _enemy;
        }


    }
}
