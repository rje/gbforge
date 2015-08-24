using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbforge2.Data
{
    public class Model
    {
        private Model()
        {
            Tilesets = new List<Tileset>();
        }

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

        public event Action OnPaintColorChange;
        public event Action OnPaletteChange;

        public readonly Palette Palette = new Palette();
        public TileColor PaintColor
        {
            get
            {
                return _paintColor;
            }
        }
        TileColor _paintColor = TileColor.Color_0;
        List<Tileset> Tilesets;

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
            _paintColor = c;
            FireOnPaintColorChanged();
        }

        void FireOnPaintColorChanged()
        {
            if(OnPaintColorChange != null)
            {
                OnPaintColorChange.Invoke();
            }
        }

        void FireOnPaletteChanged()
        {
            if(OnPaletteChange != null)
            {
                OnPaletteChange.Invoke();
            }
        }
    }
}
