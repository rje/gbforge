using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gbforge2.Data;

namespace gbforge2.Forms
{
    public partial class ColorPicker : UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();
            Model.Instance.OnPaletteChange += delegate { Refresh(); };
            Model.Instance.OnPaintColorChange += delegate { Refresh(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            DrawSwatches(e.Graphics);
            DrawSelection(e.Graphics);
        }

        void DrawSelection(Graphics g)
        {
            var idx = (int)Model.Instance.PaintColor;
            var width = GetSwatchWidth();
            var x = idx * width;
            var col = Color.Magenta;
            var pen = new Pen(col);
            pen.Width = 2;
            g.DrawRectangle(pen, x + 1, 1, width - 2, width - 2);
        }

        void DrawSwatches(Graphics g)
        {
            var palette = Model.Instance.Palette;
            var width = GetSwatchWidth();
            var brush = new SolidBrush(palette.ColorForIndex(TileColor.Color_0));
            for (var i = 0; i < 4; i++)
            {
                var col = palette.ColorForIndex((TileColor)i);
                brush.Color = col;
                var x = i * width;
                g.FillRectangle(brush, x, 0, width, width);
            }
        }

        int GetSwatchWidth()
        {
            return Width / 4;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            var x = e.X / GetSwatchWidth();
            if(x < 0 || x >= 4)
            {
                return;
            }
            var color = (TileColor)x;
            Model.Instance.SetPaintColor(color);
        }
    }
}
