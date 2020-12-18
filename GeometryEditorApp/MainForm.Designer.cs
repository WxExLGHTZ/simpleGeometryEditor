namespace GeometryEditorApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemopen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPolyline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.showLinesButton = new System.Windows.Forms.ToolStripButton();
            this.showCirclesButton = new System.Windows.Forms.ToolStripButton();
            this.showPolylinesButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripMenuItemopen,
            this.toolStripMenuItemSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemNew.Image")));
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(253, 26);
            this.toolStripMenuItemNew.Text = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // toolStripMenuItemopen
            // 
            this.toolStripMenuItemopen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemopen.Image")));
            this.toolStripMenuItemopen.Name = "toolStripMenuItemopen";
            this.toolStripMenuItemopen.Size = new System.Drawing.Size(253, 26);
            this.toolStripMenuItemopen.Text = "toolStripMenuItemOpen";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemSave.Image")));
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(253, 26);
            this.toolStripMenuItemSave.Text = "Save";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLineToolStripMenuItem,
            this.addCircleToolStripMenuItem,
            this.addPolylineToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addLineToolStripMenuItem
            // 
            this.addLineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addLineToolStripMenuItem.Image")));
            this.addLineToolStripMenuItem.Name = "addLineToolStripMenuItem";
            this.addLineToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.addLineToolStripMenuItem.Text = "Line";
            this.addLineToolStripMenuItem.ToolTipText = "Add Line";
            // 
            // addCircleToolStripMenuItem
            // 
            this.addCircleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addCircleToolStripMenuItem.Image")));
            this.addCircleToolStripMenuItem.Name = "addCircleToolStripMenuItem";
            this.addCircleToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.addCircleToolStripMenuItem.Text = "Circle";
            this.addCircleToolStripMenuItem.ToolTipText = "Add Circle";
            // 
            // addPolylineToolStripMenuItem
            // 
            this.addPolylineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPolylineToolStripMenuItem.Image")));
            this.addPolylineToolStripMenuItem.Name = "addPolylineToolStripMenuItem";
            this.addPolylineToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.addPolylineToolStripMenuItem.Text = "Polyline";
            this.addPolylineToolStripMenuItem.ToolTipText = "Add Polyline";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator2,
            this.toolStripButtonLine,
            this.toolStripButtonCircle,
            this.toolStripButtonPolyline,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.showLinesButton,
            this.showCirclesButton,
            this.showPolylinesButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1067, 47);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(29, 44);
            this.toolStripButtonNew.Text = "toolStripButtonNew";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(29, 44);
            this.toolStripButtonOpen.Text = "toolStripButtonOpen";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(29, 44);
            this.toolStripButtonSave.Text = "toolStripButtonSave";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(40, 44);
            this.toolStripButtonLine.Text = "Line";
            this.toolStripButtonLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonLine.ToolTipText = "Add Line";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonCircle
            // 
            this.toolStripButtonCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCircle.Image")));
            this.toolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircle.Name = "toolStripButtonCircle";
            this.toolStripButtonCircle.Size = new System.Drawing.Size(50, 44);
            this.toolStripButtonCircle.Text = "Circle";
            this.toolStripButtonCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCircle.ToolTipText = "Add Cicle";
            this.toolStripButtonCircle.Click += new System.EventHandler(this.toolStripButtonCircle_Click);
            // 
            // toolStripButtonPolyline
            // 
            this.toolStripButtonPolyline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPolyline.Image")));
            this.toolStripButtonPolyline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPolyline.Name = "toolStripButtonPolyline";
            this.toolStripButtonPolyline.Size = new System.Drawing.Size(64, 44);
            this.toolStripButtonPolyline.Text = "Polyline";
            this.toolStripButtonPolyline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonPolyline.ToolTipText = "Add Polyline";
            this.toolStripButtonPolyline.Click += new System.EventHandler(this.toolStripButtonPolyline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 44);
            this.toolStripLabel1.Text = "Show:";
            // 
            // showLinesButton
            // 
            this.showLinesButton.Checked = true;
            this.showLinesButton.CheckOnClick = true;
            this.showLinesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLinesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showLinesButton.Image = ((System.Drawing.Image)(resources.GetObject("showLinesButton.Image")));
            this.showLinesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showLinesButton.Name = "showLinesButton";
            this.showLinesButton.Size = new System.Drawing.Size(46, 44);
            this.showLinesButton.Text = "Lines";
            this.showLinesButton.Click += new System.EventHandler(this.showLinesButton_Click);
            // 
            // showCirclesButton
            // 
            this.showCirclesButton.Checked = true;
            this.showCirclesButton.CheckOnClick = true;
            this.showCirclesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCirclesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showCirclesButton.Image = ((System.Drawing.Image)(resources.GetObject("showCirclesButton.Image")));
            this.showCirclesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showCirclesButton.Name = "showCirclesButton";
            this.showCirclesButton.Size = new System.Drawing.Size(56, 44);
            this.showCirclesButton.Text = "Circles";
            this.showCirclesButton.Click += new System.EventHandler(this.showCirclesButton_Click);
            // 
            // showPolylinesButton
            // 
            this.showPolylinesButton.Checked = true;
            this.showPolylinesButton.CheckOnClick = true;
            this.showPolylinesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPolylinesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showPolylinesButton.Image = ((System.Drawing.Image)(resources.GetObject("showPolylinesButton.Image")));
            this.showPolylinesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showPolylinesButton.Name = "showPolylinesButton";
            this.showPolylinesButton.Size = new System.Drawing.Size(70, 44);
            this.showPolylinesButton.Text = "Polylines";
            this.showPolylinesButton.Click += new System.EventHandler(this.showPolylinesButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 666);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(216, 20);
            this.toolStripStatusLabel.Text = "Messages from the application.";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 77);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1067, 589);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.Resize += new System.EventHandler(this.pictureBox_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Geometry Editor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPolylineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircle;
        private System.Windows.Forms.ToolStripButton toolStripButtonPolyline;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton showLinesButton;
        private System.Windows.Forms.ToolStripButton showCirclesButton;
        private System.Windows.Forms.ToolStripButton showPolylinesButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemopen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

