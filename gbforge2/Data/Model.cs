using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbforge2.Data
{
    public class Model
    {
        #region singleton
        private static Model _instance;

        public static Model Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Model();
                }
                return _instance;
            }
        }
        #endregion


        public event Action OnPaintColorChange;
        public event Action OnPaletteChange;
        public event Action<Tileset> OnTilesetAdded;
        public event Action OnActiveTilesetChanged;
      
        public readonly Palette Palette = new Palette();
        public TileColor PaintColor { get; private set; } = TileColor.Color_0;

        public List<Tileset> Tilesets { get; private set; }

        public Tileset ActiveTileset { get; private set; }

        private Model()
        {
            Tilesets = new List<Tileset>();
        }

        public Tileset FindTileset(string name)
        {
            return Tilesets.Find((x) => name.Equals(x.Name));
        }

        public void AddTileset(Tileset toAdd)
        {
            Tilesets.Add(toAdd);
        }

        public void SetPaintColor(TileColor c)
        {
            if(PaintColor == c)
            {
                return;
            }
            PaintColor = c;
            FireOnPaintColorChanged();
        }

        public void AddTileset(string name)
        {
            var toAdd = new Tileset();
            toAdd.Name = name;
            Tilesets.Add(toAdd);
            FireOnTilesetAdded(toAdd);
            SelectTileset(name);
        }

        public void SelectTileset(string name)
        {
            ActiveTileset = FindTileset(name);
            FireOnActiveTilesetChanged();
        }

        void FireOnActiveTilesetChanged()
        {
            OnActiveTilesetChanged?.Invoke();
        }

        void FireOnTilesetAdded(Tileset newTileset)
        {
            OnTilesetAdded?.Invoke(newTileset);
        }

        void FireOnPaintColorChanged()
        {
            OnPaintColorChange?.Invoke();
        }

        void FireOnPaletteChanged()
        {
            OnPaletteChange?.Invoke();
        }
    }
}
