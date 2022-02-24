using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class GameEngine : Map
    {
        private Map gameMap;
        private static readonly char heroTile = 'H', emptyTile = 'X', goblinTile = 'G', obstacleTile = 'O';
        public Map GameMap
        {
            get { return gameMap; }
        }

        public GaneEngine(Map map) // 3.3 ?????
        {
            gameMap = map;

            public bool MovePlayer(MovementEnum direction);
        }
        public void MovePlayer()
        {
            // ?????????? 4.2
        }
        public bool HitSuccess()
        {
            // 4.4 ????

            return false;
        }
        public override string ToString()
        {
            //parse the 2D Tile array from Map to construct the view as a string to then pass to our Form.
                      //  gameMap.tileArray ? 3.3
            
            
            
            return base.ToString();
        }
    }
}
