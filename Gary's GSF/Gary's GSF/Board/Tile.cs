using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gary_s_GSF.Board
{
    internal class Tile
    {
        private List<Unit> units;
        public int XCoordintae { get; set; }
        public int YCoordintae { get; set; }

        public Tile(int xCordinate, int yCordinate)
        {
             XCoordintae= xCordinate;
            YCoordintae= yCordinate;
        }

        public List<Unit> GetUnits() 
        {
            return null;
        }
        public void AddUnit()
        {

        }
        public void RemoveUnit()
        {

        }
        public void RemoveUnits()
        {

        }
    }
}
