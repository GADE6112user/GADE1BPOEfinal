using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    public abstract class Item : Tile
    {
        private string itemType = "";
        public Item GoldDrop;
        public Item(int X, int Y, TileType tileType) : base(X, Y, tileType) //This data is delegated to Tile through the constructor initialiser. ? 2.1 task 2
        {

        }
        public override string ToString(Tile Item)
        {
            
            itemType = Item.tileType; // 2.1 ??

            return itemType;


        }
    }
}
