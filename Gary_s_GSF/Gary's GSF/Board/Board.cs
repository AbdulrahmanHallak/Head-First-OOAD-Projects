using Gary_s_GSF.Units;
namespace Gary_s_GSF.Board
{
    internal class Board
    {
        private List<List<Tile>> _tiles;
        public int Width { get; set; }
        public int Height { get; set; }

        public Board(int width , int height)
        {
            Width= width;
            Height= height;
            InitializeTiles();
        }

        private void InitializeTiles()
        {
            // A list for the X coordinate, where each index reprensent the x
            // and has a list with all y coordinate associated with the x.
            _tiles = new List<List<Tile>>(Width);
            for (int x = 0; x <= Width; x++)
            {
                var ycoordinates = new List<Tile>(Height);
                for (int y = 0; y <= Height; y++)
                { 
                    Tile tile = new Tile(x, y);
                    ycoordinates.Add(tile); 
                }
                _tiles.Add(ycoordinates);
            }
        }

        public Tile GetTile(int x, int y)
        {
            return _tiles[x][y];
        }
        public void AddnUnit(Unit unit , int x , int y)
        {
            Tile tile = GetTile(x, y);
            tile.AddUnit();
        }
        public void RemoveUnit(Unit unit , int x , int y)
        {
            Tile tile = GetTile(x, y);
            tile.RemoveUnit();
        }
        public void RemoveUnits(int x, int y)
        {
            Tile tile = GetTile(x, y);
            tile.RemoveUnits();
        }
        public List<Unit> GetUnits(int x, int y)
        {
            var tile = GetTile(x, y);
            return tile.GetUnits();

        }
        public void MoveUnit()
        {

        }
        public void AddTerrain()
        {

        }
        public void RemoveTerrain()
        {

        }
        public void Battle()
        {

        }

    }
}