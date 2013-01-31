namespace WubEdit
{
    partial class WubEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WubEditor));
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
            this.toolStripPublish = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabSongDetails = new System.Windows.Forms.TabPage();
            this.labelChecksum = new System.Windows.Forms.Label();
            this.textBoxChecksum = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxSimCreator = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.labelArtist = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.labelSongName = new System.Windows.Forms.Label();
            this.textBoxSongName = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.songLabel = new System.Windows.Forms.Label();
            this.textBoxFilepath = new System.Windows.Forms.TextBox();
            this.tabBeats = new System.Windows.Forms.TabPage();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.tabHazards = new System.Windows.Forms.TabPage();
            this.tabRotation = new System.Windows.Forms.TabPage();
            this.tabTranslation = new System.Windows.Forms.TabPage();
            this.tabZoom = new System.Windows.Forms.TabPage();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.waveformPainter = new NAudio.Gui.WaveformPainter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            this.tabList.SuspendLayout();
            this.tabSongDetails.SuspendLayout();
            this.tabBeats.SuspendLayout();
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
            this.toolStripTest,
            this.toolStripPublish,
            this.toolStripSeparator2});
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
            // toolStripPublish
            // 
            this.toolStripPublish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPublish.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPublish.Image")));
            this.toolStripPublish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPublish.Name = "toolStripPublish";
            this.toolStripPublish.Size = new System.Drawing.Size(23, 22);
            this.toolStripPublish.Text = "Publish";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.tabList.Size = new System.Drawing.Size(458, 370);
            this.tabList.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabList.TabIndex = 0;
            // 
            // tabSongDetails
            // 
            this.tabSongDetails.Controls.Add(this.labelChecksum);
            this.tabSongDetails.Controls.Add(this.textBoxChecksum);
            this.tabSongDetails.Controls.Add(this.labelAuthor);
            this.tabSongDetails.Controls.Add(this.textBoxSimCreator);
            this.tabSongDetails.Controls.Add(this.labelDuration);
            this.tabSongDetails.Controls.Add(this.textBoxDuration);
            this.tabSongDetails.Controls.Add(this.labelYear);
            this.tabSongDetails.Controls.Add(this.textBoxYear);
            this.tabSongDetails.Controls.Add(this.labelAlbum);
            this.tabSongDetails.Controls.Add(this.textBoxAlbum);
            this.tabSongDetails.Controls.Add(this.labelArtist);
            this.tabSongDetails.Controls.Add(this.textBoxArtist);
            this.tabSongDetails.Controls.Add(this.labelSongName);
            this.tabSongDetails.Controls.Add(this.textBoxSongName);
            this.tabSongDetails.Controls.Add(this.buttonBrowse);
            this.tabSongDetails.Controls.Add(this.songLabel);
            this.tabSongDetails.Controls.Add(this.textBoxFilepath);
            this.tabSongDetails.Location = new System.Drawing.Point(4, 22);
            this.tabSongDetails.Name = "tabSongDetails";
            this.tabSongDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabSongDetails.Size = new System.Drawing.Size(450, 344);
            this.tabSongDetails.TabIndex = 0;
            this.tabSongDetails.Text = "Song Details";
            this.tabSongDetails.UseVisualStyleBackColor = true;
            // 
            // labelChecksum
            // 
            this.labelChecksum.AutoSize = true;
            this.labelChecksum.Location = new System.Drawing.Point(17, 35);
            this.labelChecksum.Name = "labelChecksum";
            this.labelChecksum.Size = new System.Drawing.Size(60, 13);
            this.labelChecksum.TabIndex = 16;
            this.labelChecksum.Text = "Checksum:";
            // 
            // textBoxChecksum
            // 
            this.textBoxChecksum.Enabled = false;
            this.textBoxChecksum.Location = new System.Drawing.Point(83, 32);
            this.textBoxChecksum.Name = "textBoxChecksum";
            this.textBoxChecksum.Size = new System.Drawing.Size(361, 20);
            this.textBoxChecksum.TabIndex = 15;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(14, 191);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(64, 13);
            this.labelAuthor.TabIndex = 14;
            this.labelAuthor.Text = "Sim Creator:";
            // 
            // textBoxSimCreator
            // 
            this.textBoxSimCreator.Location = new System.Drawing.Point(84, 188);
            this.textBoxSimCreator.Name = "textBoxSimCreator";
            this.textBoxSimCreator.Size = new System.Drawing.Size(361, 20);
            this.textBoxSimCreator.TabIndex = 13;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(28, 61);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 12;
            this.labelDuration.Text = "Duration:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Enabled = false;
            this.textBoxDuration.Location = new System.Drawing.Point(84, 58);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(361, 20);
            this.textBoxDuration.TabIndex = 11;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(46, 165);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Year:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(84, 162);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(361, 20);
            this.textBoxYear.TabIndex = 9;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(39, 139);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(39, 13);
            this.labelAlbum.TabIndex = 8;
            this.labelAlbum.Text = "Album:";
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(84, 136);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(361, 20);
            this.textBoxAlbum.TabIndex = 7;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(40, 113);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(33, 13);
            this.labelArtist.TabIndex = 6;
            this.labelArtist.Text = "Artist:";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(84, 110);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(361, 20);
            this.textBoxArtist.TabIndex = 5;
            // 
            // labelSongName
            // 
            this.labelSongName.AutoSize = true;
            this.labelSongName.Location = new System.Drawing.Point(40, 87);
            this.labelSongName.Name = "labelSongName";
            this.labelSongName.Size = new System.Drawing.Size(38, 13);
            this.labelSongName.TabIndex = 4;
            this.labelSongName.Text = "Name:";
            // 
            // textBoxSongName
            // 
            this.textBoxSongName.Location = new System.Drawing.Point(84, 84);
            this.textBoxSongName.Name = "textBoxSongName";
            this.textBoxSongName.Size = new System.Drawing.Size(361, 20);
            this.textBoxSongName.TabIndex = 3;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(369, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(23, 9);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(54, 13);
            this.songLabel.TabIndex = 1;
            this.songLabel.Text = "Song File:";
            // 
            // textBoxFilepath
            // 
            this.textBoxFilepath.Enabled = false;
            this.textBoxFilepath.Location = new System.Drawing.Point(83, 6);
            this.textBoxFilepath.Name = "textBoxFilepath";
            this.textBoxFilepath.Size = new System.Drawing.Size(280, 20);
            this.textBoxFilepath.TabIndex = 0;
            // 
            // tabBeats
            // 
            this.tabBeats.Controls.Add(this.textBoxStart);
            this.tabBeats.Controls.Add(this.labelStartTime);
            this.tabBeats.Location = new System.Drawing.Point(4, 22);
            this.tabBeats.Name = "tabBeats";
            this.tabBeats.Size = new System.Drawing.Size(450, 344);
            this.tabBeats.TabIndex = 3;
            this.tabBeats.Text = "BPM";
            this.tabBeats.UseVisualStyleBackColor = true;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(69, 3);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 1;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(5, 6);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(58, 13);
            this.labelStartTime.TabIndex = 0;
            this.labelStartTime.Text = "Start Time:";
            // 
            // tabHazards
            // 
            this.tabHazards.Location = new System.Drawing.Point(4, 22);
            this.tabHazards.Name = "tabHazards";
            this.tabHazards.Padding = new System.Windows.Forms.Padding(3);
            this.tabHazards.Size = new System.Drawing.Size(450, 344);
            this.tabHazards.TabIndex = 1;
            this.tabHazards.Text = "Hazards";
            this.tabHazards.UseVisualStyleBackColor = true;
            // 
            // tabRotation
            // 
            this.tabRotation.Location = new System.Drawing.Point(4, 22);
            this.tabRotation.Name = "tabRotation";
            this.tabRotation.Size = new System.Drawing.Size(450, 344);
            this.tabRotation.TabIndex = 2;
            this.tabRotation.Text = "Rotation";
            this.tabRotation.UseVisualStyleBackColor = true;
            // 
            // tabTranslation
            // 
            this.tabTranslation.Location = new System.Drawing.Point(4, 22);
            this.tabTranslation.Name = "tabTranslation";
            this.tabTranslation.Size = new System.Drawing.Size(450, 344);
            this.tabTranslation.TabIndex = 5;
            this.tabTranslation.Text = "Translations";
            this.tabTranslation.UseVisualStyleBackColor = true;
            // 
            // tabZoom
            // 
            this.tabZoom.Location = new System.Drawing.Point(4, 22);
            this.tabZoom.Name = "tabZoom";
            this.tabZoom.Size = new System.Drawing.Size(450, 344);
            this.tabZoom.TabIndex = 4;
            this.tabZoom.Text = "Zoom";
            this.tabZoom.UseVisualStyleBackColor = true;
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
            this.toolStripContainer.ContentPanel.Controls.Add(this.button4);
            this.toolStripContainer.ContentPanel.Controls.Add(this.button3);
            this.toolStripContainer.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer.ContentPanel.Controls.Add(this.buttonRewind);
            this.toolStripContainer.ContentPanel.Controls.Add(this.waveformPainter);
            this.toolStripContainer.ContentPanel.Controls.Add(this.tabList);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(464, 554);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = ">>|";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "|>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonRewind
            // 
            this.buttonRewind.Location = new System.Drawing.Point(7, 375);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(30, 23);
            this.buttonRewind.TabIndex = 2;
            this.buttonRewind.Text = "|<<";
            this.buttonRewind.UseVisualStyleBackColor = true;
            // 
            // waveformPainter
            // 
            this.waveformPainter.Location = new System.Drawing.Point(7, 404);
            this.waveformPainter.Name = "waveformPainter";
            this.waveformPainter.Size = new System.Drawing.Size(450, 147);
            this.waveformPainter.TabIndex = 1;
            this.waveformPainter.Text = "waveformPainter1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // WubEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 602);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.statusStrip);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 640);
            this.MinimumSize = new System.Drawing.Size(480, 640);
            this.Name = "WubEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WubEdit";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.tabSongDetails.ResumeLayout(false);
            this.tabSongDetails.PerformLayout();
            this.tabBeats.ResumeLayout(false);
            this.tabBeats.PerformLayout();
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
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.TextBox textBoxFilepath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ToolStripButton toolStripPublish;
        private System.Windows.Forms.Label labelSongName;
        private System.Windows.Forms.TextBox textBoxSongName;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxSimCreator;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelChecksum;
        private System.Windows.Forms.TextBox textBoxChecksum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private NAudio.Gui.WaveformPainter waveformPainter;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

