using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal abstract class Weapon : Item
    {
        protected int damage;
        protected int range; //virtual
        protected int durability;
        protected int cost;
        protected string weaponType;
        private int x;
        private int y;
        private TileType privTileType;

        protected Weapon(int X, int Y, TileType tileType) : base(X, Y, tileType) //symbol from tiletype? 2.1
        {
            x = X;
            y = Y;
            privTileType = tileType;
        }
        public int Damage { get { return damage;} }
        public virtual int Range { get { return range;} }
        public int Durability { get { return durability;} }
        public int Cost { get { return cost;} }
        public string WeaponType { get { return weaponType;} }

    }
}
