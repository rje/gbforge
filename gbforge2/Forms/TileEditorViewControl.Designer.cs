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
            this.TilesetTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TilesetSelectionPanel = new System.Windows.Forms.Panel();
            this.ActiveTilesetLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColorPicker = new gbforge2.Forms.ColorPicker();
            this.TilePainter = new gbforge2.Forms.TilePaintControl();
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
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.SplitContainer.Size = new System.Drawing.Size(878, 597);
            this.SplitContainer.SplitterDistance = 712;
            this.SplitContainer.SplitterWidth = 2;
            this.SplitContainer.TabIndex = 0;
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
            this.TilesetTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TilesetTableLayout.Name = "TilesetTableLayout";
            this.TilesetTableLayout.RowCount = 2;
            this.TilesetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.18182F));
            this.TilesetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.81818F));
            this.TilesetTableLayout.Size = new System.Drawing.Size(162, 595);
            this.TilesetTableLayout.TabIndex = 0;
            // 
            // TilesetSelectionPanel
            // 
            this.TilesetSelectionPanel.Controls.Add(this.ActiveTilesetLabel);
            this.TilesetSelectionPanel.Controls.Add(this.button2);
            this.TilesetSelectionPanel.Controls.Add(this.comboBox1);
            this.TilesetSelectionPanel.Controls.Add(this.button1);
            this.TilesetSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilesetSelectionPanel.Location = new System.Drawing.Point(2, 2);
            this.TilesetSelectionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TilesetSelectionPanel.Name = "TilesetSelectionPanel";
            this.TilesetSelectionPanel.Size = new System.Drawing.Size(158, 86);
            this.TilesetSelectionPanel.TabIndex = 5;
            // 
            // ActiveTilesetLabel
            // 
            this.ActiveTilesetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveTilesetLabel.AutoSize = true;
            this.ActiveTilesetLabel.Location = new System.Drawing.Point(2, 8);
            this.ActiveTilesetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActiveTilesetLabel.Name = "ActiveTilesetLabel";
            this.ActiveTilesetLabel.Size = new System.Drawing.Size(71, 13);
            this.ActiveTilesetLabel.TabIndex = 1;
            this.ActiveTilesetLabel.Text = "Active Tileset";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(72, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(116, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(2, 92);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(158, 501);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ColorPicker
            // 
            this.ColorPicker.BackColor = System.Drawing.SystemColors.Control;
            this.ColorPicker.Location = new System.Drawing.Point(91, 438);
            this.ColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(131, 33);
            this.ColorPicker.TabIndex = 1;
            // 
            // TilePainter
            // 
            this.TilePainter.Location = new System.Drawing.Point(91, 143);
            this.TilePainter.Margin = new System.Windows.Forms.Padding(2);
            this.TilePainter.Name = "TilePainter";
            this.TilePainter.Size = new System.Drawing.Size(279, 277);
            this.TilePainter.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Controls.Add(this.SplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(878, 597);
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
