using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class EnemyFactory
    {
 
        
            private List<Enemy> enemies;

            public EnemyFactory()
            {
                enemies = new List<Enemy>();
            }


            public void CreateEnemy(string name)
            {
                Enemy enemy = new Enemy(name);
                enemies.Add(enemy);
            }

   
            public List<Enemy> GetEnemies()
            {
                return enemies;
            }
        }
    }

