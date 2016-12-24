namespace DrawingTest
{
    partial class Form1
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePenColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblPenSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblHelpText = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveToPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdPng = new System.Windows.Forms.SaveFileDialog();
            this.saveBGColorInPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastRedrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antialiasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizePlus = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.redrawToolStripMenuItem,
            this.stopDrawingToolStripMenuItem,
            this.penSizePlus,
            this.penSizeMinus});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToPNGToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.MouseLeave += new System.EventHandler(this.openToolStripMenuItem_MouseLeave);
            this.openToolStripMenuItem.MouseEnter += new System.EventHandler(this.openToolStripMenuItem_MouseEnter);
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.MouseLeave += new System.EventHandler(this.saveToolStripMenuItem_MouseLeave);
            this.saveToolStripMenuItem.MouseEnter += new System.EventHandler(this.saveToolStripMenuItem_MouseEnter);
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.exitToolStripMenuItem_MouseLeave);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.exitToolStripMenuItem_MouseEnter);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.MouseLeave += new System.EventHandler(this.clearToolStripMenuItem_MouseLeave);
            this.clearToolStripMenuItem.MouseEnter += new System.EventHandler(this.clearToolStripMenuItem_MouseEnter);
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Checked = true;
            this.optionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showListToolStripMenuItem,
            this.fastRedrawToolStripMenuItem,
            this.penSizeButtonsToolStripMenuItem,
            this.antialiasingToolStripMenuItem,
            this.saveBGColorInPNGToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // redrawToolStripMenuItem
            // 
            this.redrawToolStripMenuItem.Enabled = false;
            this.redrawToolStripMenuItem.Name = "redrawToolStripMenuItem";
            this.redrawToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.redrawToolStripMenuItem.Text = "Redraw";
            this.redrawToolStripMenuItem.MouseLeave += new System.EventHandler(this.redrawToolStripMenuItem_MouseLeave);
            this.redrawToolStripMenuItem.MouseEnter += new System.EventHandler(this.redrawToolStripMenuItem_MouseEnter);
            this.redrawToolStripMenuItem.Click += new System.EventHandler(this.redrawToolStripMenuItem_Click);
            // 
            // stopDrawingToolStripMenuItem
            // 
            this.stopDrawingToolStripMenuItem.Name = "stopDrawingToolStripMenuItem";
            this.stopDrawingToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.stopDrawingToolStripMenuItem.Text = "Stop Drawing";
            this.stopDrawingToolStripMenuItem.Visible = false;
            this.stopDrawingToolStripMenuItem.MouseLeave += new System.EventHandler(this.stopDrawingToolStripMenuItem_MouseLeave);
            this.stopDrawingToolStripMenuItem.MouseEnter += new System.EventHandler(this.stopDrawingToolStripMenuItem_MouseEnter);
            this.stopDrawingToolStripMenuItem.Click += new System.EventHandler(this.stopDrawingToolStripMenuItem_Click);
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "draw";
            this.sfd.Filter = "Draw Files (*.draw)|*.draw";
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "draw";
            this.ofd.Filter = "Draw Files (*.draw)|*.draw";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundColorToolStripMenuItem,
            this.changePenColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change BG Color";
            this.changeBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundColorToolStripMenuItem_Click);
            // 
            // changePenColorToolStripMenuItem
            // 
            this.changePenColorToolStripMenuItem.Name = "changePenColorToolStripMenuItem";
            this.changePenColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changePenColorToolStripMenuItem.Text = "Change Pen Color";
            this.changePenColorToolStripMenuItem.Click += new System.EventHandler(this.changePenColorToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPenSize,
            this.tslblHelpText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(806, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblPenSize
            // 
            this.tslblPenSize.BackColor = System.Drawing.SystemColors.Control;
            this.tslblPenSize.Name = "tslblPenSize";
            this.tslblPenSize.Size = new System.Drawing.Size(56, 17);
            this.tslblPenSize.Text = "Pen Size: ";
            // 
            // tslblHelpText
            // 
            this.tslblHelpText.BackColor = System.Drawing.SystemColors.Control;
            this.tslblHelpText.Name = "tslblHelpText";
            this.tslblHelpText.Size = new System.Drawing.Size(0, 17);
            this.tslblHelpText.Visible = false;
            // 
            // saveToPNGToolStripMenuItem
            // 
            this.saveToPNGToolStripMenuItem.Enabled = false;
            this.saveToPNGToolStripMenuItem.Name = "saveToPNGToolStripMenuItem";
            this.saveToPNGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToPNGToolStripMenuItem.Text = "Save to PNG";
            this.saveToPNGToolStripMenuItem.MouseLeave += new System.EventHandler(this.saveToPNGToolStripMenuItem_MouseLeave);
            this.saveToPNGToolStripMenuItem.MouseEnter += new System.EventHandler(this.saveToPNGToolStripMenuItem_MouseEnter);
            this.saveToPNGToolStripMenuItem.Click += new System.EventHandler(this.saveToPNGToolStripMenuItem_Click);
            // 
            // sfdPng
            // 
            this.sfdPng.DefaultExt = "png";
            this.sfdPng.Filter = "Draw Files (*.png)|*.png";
            // 
            // saveBGColorInPNGToolStripMenuItem
            // 
            this.saveBGColorInPNGToolStripMenuItem.Checked = global::DrawingTest.Properties.Settings.Default.saveBgPNG;
            this.saveBGColorInPNGToolStripMenuItem.CheckOnClick = true;
            this.saveBGColorInPNGToolStripMenuItem.Name = "saveBGColorInPNGToolStripMenuItem";
            this.saveBGColorInPNGToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveBGColorInPNGToolStripMenuItem.Text = "Save BG Color in PNG";
            this.saveBGColorInPNGToolStripMenuItem.CheckedChanged += new System.EventHandler(this.saveBGColorInPNGToolStripMenuItem_CheckedChanged);
            this.saveBGColorInPNGToolStripMenuItem.MouseLeave += new System.EventHandler(this.saveBGColorInPNGToolStripMenuItem_MouseLeave);
            this.saveBGColorInPNGToolStripMenuItem.MouseEnter += new System.EventHandler(this.saveBGColorInPNGToolStripMenuItem_MouseEnter);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(636, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 512);
            this.listBox1.TabIndex = 2;
            this.listBox1.TabStop = false;
            this.listBox1.Visible = global::DrawingTest.Properties.Settings.Default.showList;
            // 
            // showListToolStripMenuItem
            // 
            this.showListToolStripMenuItem.Checked = global::DrawingTest.Properties.Settings.Default.showList;
            this.showListToolStripMenuItem.CheckOnClick = true;
            this.showListToolStripMenuItem.Name = "showListToolStripMenuItem";
            this.showListToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showListToolStripMenuItem.Text = "Show List";
            this.showListToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showListToolStripMenuItem_CheckedChanged);
            this.showListToolStripMenuItem.MouseLeave += new System.EventHandler(this.showListToolStripMenuItem_MouseLeave);
            this.showListToolStripMenuItem.MouseEnter += new System.EventHandler(this.showListToolStripMenuItem_MouseEnter);
            // 
            // fastRedrawToolStripMenuItem
            // 
            this.fastRedrawToolStripMenuItem.Checked = global::DrawingTest.Properties.Settings.Default.fastRedraw;
            this.fastRedrawToolStripMenuItem.CheckOnClick = true;
            this.fastRedrawToolStripMenuItem.Name = "fastRedrawToolStripMenuItem";
            this.fastRedrawToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fastRedrawToolStripMenuItem.Text = "Fast Redraw";
            this.fastRedrawToolStripMenuItem.CheckedChanged += new System.EventHandler(this.fastRedrawToolStripMenuItem_CheckedChanged);
            this.fastRedrawToolStripMenuItem.MouseLeave += new System.EventHandler(this.fastRedrawToolStripMenuItem_MouseLeave);
            this.fastRedrawToolStripMenuItem.MouseEnter += new System.EventHandler(this.fastRedrawToolStripMenuItem_MouseEnter);
            // 
            // penSizeButtonsToolStripMenuItem
            // 
            this.penSizeButtonsToolStripMenuItem.Checked = global::DrawingTest.Properties.Settings.Default.altPenSize;
            this.penSizeButtonsToolStripMenuItem.CheckOnClick = true;
            this.penSizeButtonsToolStripMenuItem.Name = "penSizeButtonsToolStripMenuItem";
            this.penSizeButtonsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.penSizeButtonsToolStripMenuItem.Text = "Alternate Pen Sizing";
            this.penSizeButtonsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.penSizeButtonsToolStripMenuItem_CheckedChanged);
            this.penSizeButtonsToolStripMenuItem.MouseLeave += new System.EventHandler(this.penSizeButtonsToolStripMenuItem_MouseLeave);
            this.penSizeButtonsToolStripMenuItem.MouseEnter += new System.EventHandler(this.penSizeButtonsToolStripMenuItem_MouseEnter);
            // 
            // antialiasingToolStripMenuItem
            // 
            this.antialiasingToolStripMenuItem.Checked = global::DrawingTest.Properties.Settings.Default.antiAlias;
            this.antialiasingToolStripMenuItem.CheckOnClick = true;
            this.antialiasingToolStripMenuItem.Name = "antialiasingToolStripMenuItem";
            this.antialiasingToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.antialiasingToolStripMenuItem.Text = "Antialiasing";
            this.antialiasingToolStripMenuItem.CheckedChanged += new System.EventHandler(this.antialiasingToolStripMenuItem_CheckedChanged);
            this.antialiasingToolStripMenuItem.MouseLeave += new System.EventHandler(this.antialiasingToolStripMenuItem_MouseLeave);
            this.antialiasingToolStripMenuItem.MouseEnter += new System.EventHandler(this.antialiasingToolStripMenuItem_MouseEnter);
            // 
            // penSizePlus
            // 
            this.penSizePlus.Name = "penSizePlus";
            this.penSizePlus.Size = new System.Drawing.Size(27, 20);
            this.penSizePlus.Text = "+";
            this.penSizePlus.Visible = global::DrawingTest.Properties.Settings.Default.altPenSize;
            this.penSizePlus.MouseLeave += new System.EventHandler(this.penSizePlus_MouseLeave);
            this.penSizePlus.MouseEnter += new System.EventHandler(this.penSizePlus_MouseEnter);
            this.penSizePlus.Click += new System.EventHandler(this.penSizePlus_Click);
            // 
            // penSizeMinus
            // 
            this.penSizeMinus.Name = "penSizeMinus";
            this.penSizeMinus.Size = new System.Drawing.Size(24, 20);
            this.penSizeMinus.Text = "-";
            this.penSizeMinus.Visible = global::DrawingTest.Properties.Settings.Default.altPenSize;
            this.penSizeMinus.MouseLeave += new System.EventHandler(this.penSizeMinus_MouseLeave);
            this.penSizeMinus.MouseEnter += new System.EventHandler(this.penSizeMinus_MouseEnter);
            this.penSizeMinus.Click += new System.EventHandler(this.penSizeMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 564);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Drawing Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWheel);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePenColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopDrawingToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblPenSize;
        private System.Windows.Forms.ToolStripMenuItem fastRedrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tslblHelpText;
        private System.Windows.Forms.ToolStripMenuItem penSizeButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penSizePlus;
        private System.Windows.Forms.ToolStripMenuItem penSizeMinus;
        private System.Windows.Forms.ToolStripMenuItem antialiasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToPNGToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdPng;
        private System.Windows.Forms.ToolStripMenuItem saveBGColorInPNGToolStripMenuItem;

    }
}

