using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gary_s_GSF.Board
{
    internal class Tile
    {
        public int YCordinate { get; set; }
        public int XCordinate { get; set;}

        public Tile(int yCordinate, int xCordinate)
        {
            YCordinate = yCordinate;
            XCordinate = xCordinate;
        }

        public void GetUnits() 
        { 
        }
        public void SetUnits()
        {

        }
    }
}
