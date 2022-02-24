using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    public enum TileType
    {
        Hero,
        Enemy,
        Gold,
        Weapon
    }
    public abstract class Tile
    {
        protected int x;
        protected int y;
        
        public readonly TileType ttype;
        // public Tile(int a, int b)
        //  {
        //     this.X = a;
        //     this.Y = b;
        //  }
        public int X  
        {
            get { return x; }   
            set { x = value; }  
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Type tileType
        {
            get { return typeof(TileType); }
            
        }
        public Tile(int X, int Y, TileType tileType)
        {
            this.x = X;
            this.y = Y;
            //this.TileType = tileType;
            ttype = (TileType)Enum.Parse(typeof(TileType), tileType.ToString());
        }


    }
}
