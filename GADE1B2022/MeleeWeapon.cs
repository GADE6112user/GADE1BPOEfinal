using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class MeleeWeapon : Weapon
    {
        private int intWeaponType;
        private int x;
        private int y;
        public MeleeWeapon([int X], [int Y], enum MeleeWeaponType) // [] optional?
        {
            x = X;
            y = Y;

            if (int MeleeWeaponType == 0)
            {
                string weapontype = "Dagger";
                int durability = 10;
                int damage = 3;
                int cost = 3;
            }
            if (int MeleeWeaponType == 1)
            {
                string weapontype = "Longsword";
                int durability = 6;
                int damage = 4;
                int cost = 5;
            }
        }
        public enum MeleeWeaponType
        {
            Dagger,
            Longsword
        }
        public override int Range
        {
            get { return 1; }
        }
    }
}
