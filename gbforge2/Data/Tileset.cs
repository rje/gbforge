using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbforge2.Data
{
    public class Tileset
    {

        public event Action<Tileset> OnTilesetChanged;

        public string Name;
        public List<Tile> Tiles = new List<Tile>(128);
    }
}
