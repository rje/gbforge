using System.Windows.Forms;

namespace gbforge2
{
    partial class MainView
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ColorPicker = new gbforge2.Forms.ColorPicker();
            this.TilePainter = new gbforge2.Forms.TilePaintControl();
            this.TilesetTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TilesetSelectionPanel = new System.Windows.Forms.Panel();
            this.ActiveTilesetLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.TilesetTableLayout.SuspendLayout();
            this.TilesetSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer.Panel1.Controls.Add(this.ColorPicker);
            this.SplitContainer.Panel1.Controls.Add(this.TilePainter);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.TilesetTableLayout);
            this.SplitContainer.Size = new System.Drawing.Size(1610, 1102);
            this.SplitContainer.SplitterDistance = 1306;
            this.SplitContainer.TabIndex = 0;
            // 
            // ColorPicker
            // 
            this.ColorPicker.BackColor = System.Drawing.SystemColors.Control;
            this.ColorPicker.Location = new System.Drawing.Point(166, 808);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(240, 60);
            this.ColorPicker.TabIndex = 1;
            // 
            // TilePainter
            // 
            this.TilePainter.Location = new System.Drawing.Point(166, 264);
            this.TilePainter.Name = "TilePainter";
            this.TilePainter.Size = new System.Drawing.Size(512, 512);
            this.TilePainter.TabIndex = 0;
            // 
            // TilesetTableLayout
            // 
            this.TilesetTableLayout.ColumnCount = 1;
            this.TilesetTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TilesetTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TilesetTableLayout.Controls.Add(this.TilesetSelectionPanel, 0, 0);
            this.TilesetTableLayout.Controls.Add(this.listView1, 0, 1);
            this.TilesetTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilesetTableLayout.Location = new System.Drawing.Point(0, 0);
            this.TilesetTableLayout.Name = "TilesetTableLayout";
            this.TilesetTableLayout.RowCount = 2;
            this.TilesetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.18182F));
            this.TilesetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.81818F));
            this.TilesetTableLayout.Size = new System.Drawing.Size(298, 1100);
            this.TilesetTableLayout.TabIndex = 0;
            // 
            // TilesetSelectionPanel
            // 
            this.TilesetSelectionPanel.Controls.Add(this.ActiveTilesetLabel);
            this.TilesetSelectionPanel.Controls.Add(this.button2);
            this.TilesetSelectionPanel.Controls.Add(this.comboBox1);
            this.TilesetSelectionPanel.Controls.Add(this.button1);
            this.TilesetSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilesetSelectionPanel.Location = new System.Drawing.Point(3, 3);
            this.TilesetSelectionPanel.Name = "TilesetSelectionPanel";
            this.TilesetSelectionPanel.Size = new System.Drawing.Size(292, 161);
            this.TilesetSelectionPanel.TabIndex = 5;
            // 
            // ActiveTilesetLabel
            // 
            this.ActiveTilesetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveTilesetLabel.AutoSize = true;
            this.ActiveTilesetLabel.Location = new System.Drawing.Point(3, 14);
            this.ActiveTilesetLabel.Name = "ActiveTilesetLabel";
            this.ActiveTilesetLabel.Size = new System.Drawing.Size(129, 25);
            this.ActiveTilesetLabel.TabIndex = 1;
            this.ActiveTilesetLabel.Text = "Active Tileset";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(133, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(214, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 170);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(292, 927);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Controls.Add(this.SplitContainer);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(1610, 1102);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.TilesetTableLayout.ResumeLayout(false);
            this.TilesetSelectionPanel.ResumeLayout(false);
            this.TilesetSelectionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private Forms.TilePaintControl TilePainter;
        private Forms.ColorPicker ColorPicker;
        private Label ActiveTilesetLabel;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Panel TilesetSelectionPanel;
        private TableLayoutPanel TilesetTableLayout;
        private ListView listView1;
    }
}
