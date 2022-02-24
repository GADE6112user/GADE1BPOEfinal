using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    public class Gold : Item
    {
        private int goldDrop;
        Random rnd = new Random();
        goldDrop = rnd.NextInt(2,3); // ???
        public Item GoldDrop
        {
            get { return goldDrop } // 
        }
        public Gold()
        {
            goldDrop = 0;
        }

    }
}
