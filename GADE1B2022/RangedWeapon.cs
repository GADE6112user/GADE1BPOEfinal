using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class RangedWeapon : Weapon
    {
        private int x;
        private int y;

        public RangedWeapon(Enum WeaponType, int Durability)
        { 

        }
        public RangedWeapon([int X], [int Y], Enum RangedWeaponType) // [] optional?
        {
            x = X;
            y = Y;

            if (int RangedWeaponType == 0)
            {
                string weapontype = "Rifle";
                int durability = 3;
                int range = 3;
                int damage = 5;
                int cost = 7;
            }
            if (int RangedWeaponType == 1)
            {
                string weapontype = "Longbow";
                int durability = 4;
                int range = 2;
                int damage = 4;
                int cost = 6;
            }
        }
        public enum RangedWeaponType
        {
            Rifle,
            Longbow
        }
        public override int Range
        {
            get { return base.Range; }
        }
    }
}
