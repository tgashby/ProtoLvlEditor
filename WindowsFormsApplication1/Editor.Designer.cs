namespace Proto_LvlEditor
{
   partial class Editor
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
         this.controlsPanel = new System.Windows.Forms.Panel();
         this.tileSelection = new System.Windows.Forms.ListBox();
         this.frownyButton = new System.Windows.Forms.Button();
         this.smileyButton = new System.Windows.Forms.Button();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.controlsPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // controlsPanel
         // 
         this.controlsPanel.Controls.Add(this.tileSelection);
         this.controlsPanel.Controls.Add(this.frownyButton);
         this.controlsPanel.Controls.Add(this.smileyButton);
         this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.controlsPanel.Location = new System.Drawing.Point(0, 0);
         this.controlsPanel.Name = "controlsPanel";
         this.controlsPanel.Size = new System.Drawing.Size(209, 962);
         this.controlsPanel.TabIndex = 0;
         // 
         // tileSelection
         // 
         this.tileSelection.FormattingEnabled = true;
         this.tileSelection.Items.AddRange(new object[] {
            "Smiley",
            "Frowny"});
         this.tileSelection.Location = new System.Drawing.Point(3, 114);
         this.tileSelection.Name = "tileSelection";
         this.tileSelection.Size = new System.Drawing.Size(203, 43);
         this.tileSelection.TabIndex = 2;
         this.tileSelection.SelectedIndexChanged += new System.EventHandler(this.tileSelector_SelectedIndexChanged);
         // 
         // frownyButton
         // 
         this.frownyButton.Image = ((System.Drawing.Image)(resources.GetObject("frownyButton.Image")));
         this.frownyButton.Location = new System.Drawing.Point(110, 6);
         this.frownyButton.Name = "frownyButton";
         this.frownyButton.Size = new System.Drawing.Size(93, 102);
         this.frownyButton.TabIndex = 1;
         this.frownyButton.UseVisualStyleBackColor = true;
         this.frownyButton.Click += new System.EventHandler(this.frownyButton_Click);
         // 
         // smileyButton
         // 
         this.smileyButton.Image = ((System.Drawing.Image)(resources.GetObject("smileyButton.Image")));
         this.smileyButton.Location = new System.Drawing.Point(3, 3);
         this.smileyButton.Name = "smileyButton";
         this.smileyButton.Size = new System.Drawing.Size(94, 105);
         this.smileyButton.TabIndex = 0;
         this.smileyButton.UseVisualStyleBackColor = true;
         this.smileyButton.Click += new System.EventHandler(this.smileyButton_Click);
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
         this.splitContainer1.IsSplitterFixed = true;
         this.splitContainer1.Location = new System.Drawing.Point(0, 24);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.controlsPanel);
         this.splitContainer1.Size = new System.Drawing.Size(1008, 962);
         this.splitContainer1.SplitterDistance = 795;
         this.splitContainer1.TabIndex = 1;
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
         this.menuStrip1.TabIndex = 2;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
         this.saveToolStripMenuItem.Text = "Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
         // 
         // loadToolStripMenuItem
         // 
         this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
         this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
         this.loadToolStripMenuItem.Text = "Load";
         this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
         // 
         // clearToolStripMenuItem
         // 
         this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
         this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
         this.clearToolStripMenuItem.Text = "Clear";
         this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
         // 
         // Editor
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1008, 986);
         this.Controls.Add(this.splitContainer1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Editor";
         this.Text = "Elementals Level Editor";
         this.controlsPanel.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel controlsPanel;
      private System.Windows.Forms.Button frownyButton;
      private System.Windows.Forms.Button smileyButton;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private XNAContext xnaContext;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
      private System.Windows.Forms.ListBox tileSelection;
   }
}

