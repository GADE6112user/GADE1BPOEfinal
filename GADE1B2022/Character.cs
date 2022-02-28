using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    public class Character : Tile
    { //left on 2.5 poe
        protected int hp;
        protected int maxHp;
        protected int damage;
        protected int x;
        protected int y;
        protected int range;
        protected Tile[] CharacterVison = new Tile[3];
        public readonly Character ctype;
        protected int goldAmount;
        //private Weapon weapon;
        public Character()
        {

        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public int GoldAmount
        {
            get { return goldAmount; }
            set { goldAmount = value; }
        }
        protected int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public enum MovementEnum
        {
            No_Movement = 5,
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4
        }
        public MovementEnum movement
        {
            get { return movement; }
            set { movement = value; }
        }
        // public Character(int Hp, int MaxHp, int Damage,  )
        public virtual void Attack(Character target)
        {
            //Attacks a target and decreases its health by the attacking character’s damage. This is declared as virtual for later overriding by specific enemy types.
            target.hp = target.hp - this.damage;
        }
        public bool IsDead()
        {
            if (this.hp > 0)
            return false;
            else return true;
        }
        public void PickUp(Weapon weapon)
        {
            //pick up weapon from shop
        }

        public virtual bool CheckRange(Enemy target)
        {
            //Checks if a target is in range of a character(barehanded range is always 1, but this will be extended with weapon types later). It determines distance via the DistanceTo() method and returns true or false.
            int enemyX = target.EnemyX;
            int enemyY = target.EnemyY;
            if ((Math.Abs(this.x - enemyX) <= this.range) ||
                   (Math.Abs(this.y - enemyY) <= this.range)) // 2.3
                return true;
            else return false;
            return true;
        }
        private int DistanceTo(Enemy target)
        {
            //used by CheckRange(): Determines the absolute distance(number of spaces needed to move – e.g.diagonal is one up + one across = 2) between a character and its target.
            int dist = (this.x - target.x) + (this.y - target.y);
            return dist;
        }
        public void Move(MovementEnum move)
        {
            //Edits a unit’s X and Y values to move it up / down / left / right based on the identifier from the enum.
            if (move == MovementEnum.No_Movement)
                return;
            if (move == MovementEnum.Up)
                this.y++;
            if (move == MovementEnum.Down)
                this.y--;
            if (move == MovementEnum.Left)
                this.x--;
            if (move == MovementEnum.Right)
                this.x++;


        }
        public virtual MovementEnum ReturnMove(Character target)
        {
            // ..MovementEnum movement = new MovementEnum();
            return target.movement;
        }
        public abstract MovementEnum ()  // 2.3 ??
        {
            
        }
        public abstract override ToString()
        {
            return "";
        }
    }
}

