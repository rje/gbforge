using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gbforge2
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            var styles = this.TilesetTableLayout.RowStyles;
            styles[0].SizeType = SizeType.Absolute;
            styles[0].Height = 100;
        }
    }
}
