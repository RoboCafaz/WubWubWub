namespace WubEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTest = new System.Windows.Forms.ToolStripButton();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabZoom = new System.Windows.Forms.TabPage();
            this.tabTranslation = new System.Windows.Forms.TabPage();
            this.tabRotation = new System.Windows.Forms.TabPage();
            this.tabHazards = new System.Windows.Forms.TabPage();
            this.tabBeats = new System.Windows.Forms.TabPage();
            this.tabSongDetails = new System.Windows.Forms.TabPage();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip.SuspendLayout();
            this.tabList.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 580);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(464, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "Status Bar";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Enabled = false;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.MaximumSize = new System.Drawing.Size(0, 24);
            this.TopToolStripPanel.MinimumSize = new System.Drawing.Size(0, 24);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripTest});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(464, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripNew.Text = "New";
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpen.Text = "Open";
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(32, 22);
            this.toolStripSave.Text = "Save";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTest
            // 
            this.toolStripTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripTest.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTest.Image")));
            this.toolStripTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTest.Name = "toolStripTest";
            this.toolStripTest.Size = new System.Drawing.Size(23, 22);
            this.toolStripTest.Text = "toolStripTest";
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Enabled = false;
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Enabled = false;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(464, 554);
            this.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.tabSongDetails);
            this.tabList.Controls.Add(this.tabBeats);
            this.tabList.Controls.Add(this.tabHazards);
            this.tabList.Controls.Add(this.tabRotation);
            this.tabList.Controls.Add(this.tabTranslation);
            this.tabList.Controls.Add(this.tabZoom);
            this.tabList.Location = new System.Drawing.Point(3, 3);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(458, 550);
            this.tabList.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabList.TabIndex = 0;
            // 
            // tabZoom
            // 
            this.tabZoom.Location = new System.Drawing.Point(4, 22);
            this.tabZoom.Name = "tabZoom";
            this.tabZoom.Size = new System.Drawing.Size(450, 524);
            this.tabZoom.TabIndex = 4;
            this.tabZoom.Text = "Zoom";
            this.tabZoom.UseVisualStyleBackColor = true;
            // 
            // tabTranslation
            // 
            this.tabTranslation.Location = new System.Drawing.Point(4, 22);
            this.tabTranslation.Name = "tabTranslation";
            this.tabTranslation.Size = new System.Drawing.Size(450, 524);
            this.tabTranslation.TabIndex = 5;
            this.tabTranslation.Text = "Translations";
            this.tabTranslation.UseVisualStyleBackColor = true;
            // 
            // tabRotation
            // 
            this.tabRotation.Location = new System.Drawing.Point(4, 22);
            this.tabRotation.Name = "tabRotation";
            this.tabRotation.Size = new System.Drawing.Size(450, 524);
            this.tabRotation.TabIndex = 2;
            this.tabRotation.Text = "Rotation";
            this.tabRotation.UseVisualStyleBackColor = true;
            // 
            // tabHazards
            // 
            this.tabHazards.Location = new System.Drawing.Point(4, 22);
            this.tabHazards.Name = "tabHazards";
            this.tabHazards.Padding = new System.Windows.Forms.Padding(3);
            this.tabHazards.Size = new System.Drawing.Size(450, 524);
            this.tabHazards.TabIndex = 1;
            this.tabHazards.Text = "Hazards";
            this.tabHazards.UseVisualStyleBackColor = true;
            // 
            // tabBeats
            // 
            this.tabBeats.Location = new System.Drawing.Point(4, 22);
            this.tabBeats.Name = "tabBeats";
            this.tabBeats.Size = new System.Drawing.Size(450, 524);
            this.tabBeats.TabIndex = 3;
            this.tabBeats.Text = "BPM";
            this.tabBeats.UseVisualStyleBackColor = true;
            // 
            // tabSongDetails
            // 
            this.tabSongDetails.Location = new System.Drawing.Point(4, 22);
            this.tabSongDetails.Name = "tabSongDetails";
            this.tabSongDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabSongDetails.Size = new System.Drawing.Size(450, 524);
            this.tabSongDetails.TabIndex = 0;
            this.tabSongDetails.Text = "Song Details";
            this.tabSongDetails.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Enabled = false;
            this.toolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tabList);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(464, 554);
            this.toolStripContainer.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            // 
            // toolStripContainer.LeftToolStripPanel
            // 
            this.toolStripContainer.LeftToolStripPanel.Enabled = false;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, -1);
            this.toolStripContainer.Name = "toolStripContainer";
            // 
            // toolStripContainer.RightToolStripPanel
            // 
            this.toolStripContainer.RightToolStripPanel.Enabled = false;
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(464, 578);
            this.toolStripContainer.TabIndex = 2;
            this.toolStripContainer.Text = "toolStripContainer";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            this.toolStripContainer.TopToolStripPanel.MaximumSize = new System.Drawing.Size(0, 24);
            this.toolStripContainer.TopToolStripPanel.MinimumSize = new System.Drawing.Size(0, 24);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 602);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.statusStrip);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 640);
            this.MinimumSize = new System.Drawing.Size(480, 640);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WubEdit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripSplitButton toolStripSave;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripTest;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabSongDetails;
        private System.Windows.Forms.TabPage tabBeats;
        private System.Windows.Forms.TabPage tabHazards;
        private System.Windows.Forms.TabPage tabRotation;
        private System.Windows.Forms.TabPage tabTranslation;
        private System.Windows.Forms.TabPage tabZoom;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
    }
}

