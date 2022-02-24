using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class Mage : Enemy
    {
        private int x;
        private int y;
        private int enemyX; 
        private int enemyY;
        public Mage(int X, int Y)
        {
            this.hp = 5;
            this.damage = 5;
        }
        public override Movement ReturnMove()
        {
            this.movement = Movement.No_Movement;
            return this.movement;
        }
        public override bool CheckRange(Enemy target)
        {
            enemyX = target.EnemyX;
            enemyY = target.EnemyY;
            if ((Math.Abs(this.x - enemyX) <= 1) ||
                   (Math.Abs(this.y - enemyY) <= 1)) // 2.3
                return true;
            else return false;

        }
    }
}
