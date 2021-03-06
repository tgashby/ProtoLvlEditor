﻿namespace Proto_LvlEditor
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
         this.controlsPanel = new System.Windows.Forms.Panel();
         this.tileSelection = new System.Windows.Forms.ListBox();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tilesLabel = new System.Windows.Forms.Label();
         this.controlsPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // controlsPanel
         // 
         this.controlsPanel.Controls.Add(this.tilesLabel);
         this.controlsPanel.Controls.Add(this.tileSelection);
         this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.controlsPanel.Location = new System.Drawing.Point(0, 0);
         this.controlsPanel.Name = "controlsPanel";
         this.controlsPanel.Size = new System.Drawing.Size(209, 962);
         this.controlsPanel.TabIndex = 0;
         // 
         // tileSelection
         // 
         this.tileSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tileSelection.FormattingEnabled = true;
         this.tileSelection.ItemHeight = 16;
         this.tileSelection.Location = new System.Drawing.Point(3, 26);
         this.tileSelection.Name = "tileSelection";
         this.tileSelection.Size = new System.Drawing.Size(203, 116);
         this.tileSelection.TabIndex = 2;
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
         // tilesLabel
         // 
         this.tilesLabel.AutoSize = true;
         this.tilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tilesLabel.Location = new System.Drawing.Point(3, 3);
         this.tilesLabel.Name = "tilesLabel";
         this.tilesLabel.Size = new System.Drawing.Size(45, 20);
         this.tilesLabel.TabIndex = 3;
         this.tilesLabel.Text = "Tiles:";
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
         this.Load += new System.EventHandler(this.initTiles);
         this.controlsPanel.ResumeLayout(false);
         this.controlsPanel.PerformLayout();
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
      private System.Windows.Forms.SplitContainer splitContainer1;
      private XNAContext xnaContext;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
      private System.Windows.Forms.ListBox tileSelection;
      private System.Windows.Forms.Label tilesLabel;
   }
}

