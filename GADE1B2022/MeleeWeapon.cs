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
        int durability;
        int damage;
        int cost;
        public Type MeleeWeapon([int X], [int Y], int intWeaponType) // [] optional?
        {
            x = X;
            y = Y;

            if (MeleeWeaponType.Dagger.Equals(intWeaponType))
            {
                string weapontype = "Dagger";
                durability = 10;
                damage = 3;
                cost = 3;
            }
            if (MeleeWeaponType.Longsword.Equals(intWeaponType))
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


