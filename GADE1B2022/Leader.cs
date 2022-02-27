using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{

    internal class Leader : Enemy
    {

        private int x;
        private int y;
        private Character target;

        public Character Target
        {
            get { return target; }
            set { target = value; }
        }
        public Leader (int X, int Y)
        {
            x = X;
            y = Y;
            this.hp = 20;
            this.damage = 2;
        }
        public override MovementEnum ReturnMove(Character target)
        {
            int value = new Random().Next(4);
           // Enum movement = new Enum (MovementEnum.)
            if ((this.x - target.X) <= (this.y - target.Y)) {
                if ((this.x + 1 - target.X) < (this.x - target.X)) {
                    return MovementEnum.Left;
                } else {
                    return MovementEnum.Right;
                }
            } else if ((this.x - target.X) > (this.y - target.Y)) {
                if ((this.y + 1 - target.Y) < (this.y - target.Y)) {
                    return MovementEnum.Up;
                } else {
                    return MovementEnum.Down;
                }
            } // if (spaceIsOccupied) 
            else if(value == 0)
                    return MovementEnum.Up;
            else if(value == 1)
                    return MovementEnum.Down;
            else if(value == 2)
                    return MovementEnum.Left;
            else if(value == 3)
                    return MovementEnum.Right;           
            else 
                return MovementEnum.No_Movement;
        }
        public static Enum GetRandomEnumValue(this Type t)
        {
            return Enum.GetValues(t)          // get values from Type provided
                .OfType<Enum>()               // casts to Enum
                .OrderBy(e => Guid.NewGuid()) // mess with order of results
                .FirstOrDefault();            // take first item in result
        }
    }
}
