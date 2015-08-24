using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbforge2.Data
{
    public enum TileColor : int
    {
        Unset = -1,
        Color_0,
        Color_1,
        Color_2,
        Color_3
    }

    public class Tile
    {
        public event Action<Tile> OnTileChanged;
        const int WIDTH = 8;
        public TileColor[] Data = new TileColor[WIDTH * WIDTH];

        public TileColor this[int x, int y]  {
            get
            {
                if(!IsValidIndex(x, y))
                {
                    return TileColor.Unset;
                }
                return Data[x + y * WIDTH];
            }
            set
            {
                if(!IsValidIndex(x, y))
                {
                    return;
                }
                Data[x + y * WIDTH] = value;
                FireTileChangedEvent();
            }
        }

        bool IsValidIndex(int x, int y)
        {
            return x >= 0 && x < WIDTH && y >= 0 && y < WIDTH;
        }

        void FireTileChangedEvent()
        {
            if(OnTileChanged != null)
            {
                OnTileChanged.Invoke(this);
            }
        }
    }
}
