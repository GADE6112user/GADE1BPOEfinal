using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class Shop
    {
        private Weapon[] weaponArr = new Weapon[4];
        private Random random = new Random(4);
        private Character character = new Character();
        private MeleeWeapon Dagger = new MeleeWeapon();
        private MeleeWeapon Longsword = new MeleeWeapon();
        private RangedWeapon Longbow = new RangedWeapon();
        private RangedWeapon Rifle = new RangedWeapon();

        public Character Character { get => character; set => character = value; }

        public Shop(Character buyer)
        {
            character = buyer;  
        }
        private Weapon RandomWeapon()  // Instructions say randomised 3 weapons but then it says 4 which makes more sense??!!?
        {
            weaponArr[0] = Dagger;
            weaponArr[1] = Longsword;
            weaponArr[2] = Longbow;
            weaponArr[4] = Rifle;
            return weaponArr[random.Next(4)];

        }
        public bool CanBuy(int num)
        {
            if (character.GoldAmount > num)
                return true;
            else
                return false;
        }
        public void Buy(int num)
        {
            character.GoldAmount = character.GoldAmount - num;
            character.PickUp();
            RandomWeapon();

        }
        public string DisplayWeapon(int num)
        {
            return "Buy " + RandomWeapon() + " (" + num + "Gold)";
        }
    }
}
