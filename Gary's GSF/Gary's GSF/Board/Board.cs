namespace Gary_s_GSF.Board
{
    public class Board
    {
        private int _x;
        private int _y;
        private List<Tile> _tiles;
        public int Width { get; set; }
        public int Height { get; set; }
        public int X 
        { 
            get { return _x; }
            set
            {
                // Make sure the X is not negative and does not get out of the board.
                if((X >= 0) && (X <= Width))
                    _x = X;
                throw new IndexOutOfRangeException("The X should not exceed the width"); // Edit this exception
            }
        }
        public int Y
        {
            get { return _y; }
            set
            {
                // Make sure the Y is not negative and does not get out of the board.
                if ((Y >= 0) && (Y <= Height))
                    _y = Y;
                throw new IndexOutOfRangeException("The X should not exceed the width"); // Edit this exception
            }
        }

        public Board(int width , int height)
        {
            Width= width;
            Height= height;
            InitializeTiles();
        }

        private void InitializeTiles()
        {
            for (int x = 0; x <= Width; x++)
            {
                for (int y = 0; y <= Height; y++)
                {
                    Tile tile = new Tile(x, y);
                    _tiles.Add(tile);
                }
            }
        }

        public Tile GetTile(int x, int y)
        {
            return;
        }
        public void AddUnit()
        {

        }
        public void RemoveUnit()
        {

        }

        public void MoveUnit()
        {

        }
        public void ShowUnits()
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