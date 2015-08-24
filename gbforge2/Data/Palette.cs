using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbforge2.Data
{
    public class Palette
    {
        public List<Color> Colors = new List<Color>()
        {
            Color.FromArgb(255, 215, 232, 148),
            Color.FromArgb(255, 174, 196, 64),
            Color.FromArgb(255, 82, 127, 57),
            Color.FromArgb(255, 32, 70, 49),
        };
        public Color Unset = Color.Magenta;

        public Color ColorForIndex(TileColor idx)
        {
            if(idx == TileColor.Unset)
            {
                return Unset;
            }
            else
            {
                return Colors[(int)idx];
            }
        }
    }
}
