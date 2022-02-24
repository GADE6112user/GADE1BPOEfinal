using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class Map
    {
        private int[,] tileArray;

        const int tilesX = 100;
        const int tilesY = 100;
        const int tilesLayer = 5;
        Tile tm = new Tile(tilesLayer, tilesX, tilesY); // 
        private int numberOfEnemies = 0;
        Hero Herochar = new Hero(); //A Hero object to represent the player character
        // This character array will be updated at all times to show the status of the map.Remember when initializing your map that it must be bordered with Obstacle tiles around the outside to prevent Character movement outside of the map.
        private Enemy[] enemyArray = new Enemy[];
        Random Random = new Random(); // A Random object for randomising numbers.


        public Map (int width, int height, int NumberOfEnemies)
        {
            tilesX = width;
            tilesY = height;
            numberOfEnemies = NumberOfEnemies;
            //and creates a new 2D Tile array of that size, as well as setting the width and height variables.
            Enemy[] enemy = new Enemy[Random.Next(NumberOfEnemies)];
            Create(); // create the Hero, and loops through the enemy’s array calling Create() to create each enemy and puts them in the Tile map.It then calls UpdateVision() which updates the vision arrays of each Character with the Tiles around the character.
        }
        public void UpdateVision()
        {
           // Updates the vision array for each Character (the hero and each enemy) by saving the character values of the map at the north, south, east and west position from the X and Y positions of the unit.
        }
        private Tile Create(TileEnum type)
        {
          //  This method is used to create objects and also place them on the map.The method receives what to create (Hero, Enemy and later Gold, MeleeWeapon etc.). It then generates a unique X and Y position(or rerolls a position until one exists).Then, based on the type to be created it creates a Hero or Enemy(both of which are Tiles by inheritance) with the X and Y position.
        }
        private void Create()
        {
            throw new NotImplementedException();
        }


// -------------------You will need to create your own other methods inside of the Map class to allow it to integrate with the game overall.------------------------
    }
}
