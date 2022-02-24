using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    public abstract class Character
    {
        protected int hp;
        protected int maxHp;
        protected int damage;
        protected Tile[] CharacterVison = new Tile[3];
        public readonly Character ctype;
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
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
        public enum Movement
        {
            No_Movement,
            Up,
            Down,
            Left,
            Right
        }
        public Movement movement
        {
            get { return movement; }
            set { movement = value; }
        }
        // public Character(int Hp, int MaxHp, int Damage,  )
        public virtual void Attack(Character target)
        {
            //Attacks a target and decreases its health by the attacking character’s damage. This is declared as virtual for later overriding by specific enemy types.

        }
        public bool IsDead()
        {
            return false;
        }

        public virtual bool CheckRange(Character target)
        {
            //Checks if a target is in range of a character(barehanded range is always 1, but this will be extended with weapon types later). It determines distance via the DistanceTo() method and returns true or false.
            return false;
        }
        private int DistanceTo(target)
        {
            //used by CheckRange(): Determines the absolute distance(number of spaces needed to move – e.g.diagonal is one up + one across = 2) between a character and its target.
            return 0;
        }
        public void Move(MovementEnum move)
        {
            //Edits a unit’s X and Y values to move it up / down / left / right based on the identifier from the enum.
        }
        public abstract  MovementEnum () ReturnMove(MovementEnum move = 0); // 2.3 ??
        {
            
        }
        public abstract override ToString()
        {
            return;
        }
    }
}

