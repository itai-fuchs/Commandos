using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal  class Game
    {

        private  EnemyFactory enemyFactory = new EnemyFactory();
        private  ComandoFactory comandoFactory = new ComandoFactory();
        private  WeaponFactory weaponFactory = new WeaponFactory();


        public void CreateEnemy(string name)
        {

            enemyFactory.CreateEnemy(name);
        }

     public void CreateComando(string name,string codeName, string kind)
        {
           
            comandoFactory.CreateComando(name, codeName,kind);
        }

        public void CreateWeapon(string name, string manufacturer, int numberOfBullets)
        {
            
            weaponFactory.CreateWeapon(name, manufacturer, numberOfBullets);
        }

        //public void ConsoleMeneu()
        //{
        //    Console.WriteLine("Welcome to our new game!!\nTo create a commando soldier, click 1.\nTo create an enemy, click 2.\nTo create a weapon, click 3.");
        //    switch (Console.ReadLine()) {

        //        case "1":
        //            CreateComando();
        //            break;
        //            case "2":
        //            CreateEnemy();
        //            break;
        //            case "3":
        //            CreateWeapon()
        //                breake;
        //            default:
        //            Console.WriteLine("not valid input");

        //}
     
    }
}
