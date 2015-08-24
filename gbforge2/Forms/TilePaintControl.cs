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
    
    public partial class TilePaintControl : UserControl
    {
        public Tile CurrentTile;

        bool _painting = false;
         
        public TilePaintControl()
        {
            InitializeComponent();
            CurrentTile = new Tile();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var graphics = e.Graphics;
            var brush = new SolidBrush(BackColor);
            graphics.FillRectangle(brush, 0, 0, Width, Height);
            DrawTile(graphics);
            DrawGrid(graphics);
        }

        void DrawTile(Graphics g)
        {
            if(CurrentTile == null)
            {
                return;
            }
            var brush = new SolidBrush(TypeToColor(TileColor.Color_0));
            var width = GetPixelWidth();
            for(var x = 0; x < 8; x++)
            {
                for(var y = 0; y < 8; y++)
                {
                    brush.Color = TypeToColor(CurrentTile[x, y]);
                    g.FillRectangle(brush, x * width, y * width, width, width);
                }
            }
        }

        void DrawGrid(Graphics g)
        {
            var perLine = GetPixelWidth();
            var len = perLine * 8;
            var pen = new Pen(Color.Black);
            pen.Width = 1;
            for(var i = 0; i <= 8; i++)
            {
                var pos = i * perLine;
                g.DrawLine(pen, 0, pos, len, pos);
                g.DrawLine(pen, pos, 0, pos, len);
            }
        }

        public int GetPixelWidth()
        {
            return Width / 8;
        }

        public Color TypeToColor(TileColor type)
        {
            var palette = Model.Instance.Palette;
            return palette.ColorForIndex(type);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                _painting = true;
                ColorTileAt(e.X, e.Y);
            }
            else if(e.Button == MouseButtons.Right)
            {
                EyedropperAt(e.X, e.Y);
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if(!_painting)
            {
                return;
            }
            ColorTileAt(e.X, e.Y);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _painting = false;
            ColorTileAt(e.X, e.Y);
        }

        void ConvertToTileCoords(ref int x, ref int y)
        {
            x = x / GetPixelWidth();
            y = y / GetPixelWidth();
        }

        void EyedropperAt(int x, int y)
        {
            if (CurrentTile == null)
            {
                return;
            }
            ConvertToTileCoords(ref x, ref y);
            var color = CurrentTile[x, y];
            if(color != TileColor.Unset)
            {
                Model.Instance.SetPaintColor(color);
            }
        }

        void ColorTileAt(int x, int y)
        {
            if(CurrentTile == null)
            {
                return;
            }
            ConvertToTileCoords(ref x, ref y);
            var color = Model.Instance.PaintColor;
            if(CurrentTile[x, y] == color)
            {
                return;
            }

            CurrentTile[x, y] = color;
            Refresh();
        }
    }
}
