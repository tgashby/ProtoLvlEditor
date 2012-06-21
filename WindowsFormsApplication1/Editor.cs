using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Proto_LvlEditor
{
   public partial class Editor : Form
   {
      XmlDocument xmlDoc;

      Tile currTile;

      public Editor()
      {
         InitializeComponent();
         xmlDoc = new XmlDocument();

         // Add in the XNA context
         this.xnaContext = new XNAContext();
         this.splitContainer1.Panel1.Controls.Add(this.xnaContext);
         this.xnaContext.Dock = System.Windows.Forms.DockStyle.Fill;
         this.xnaContext.Location = new System.Drawing.Point(0, 0);
         this.xnaContext.Name = "xnaContext";
         this.xnaContext.Size = new System.Drawing.Size(795, 962);
         this.xnaContext.TabIndex = 0;
         this.xnaContext.Text = "xnaContext";
         this.xnaContext.MouseMove += new MouseEventHandler(xnaContext_MouseMove);
         this.xnaContext.Click += new EventHandler(xnaContext_Click);
      }

      private void smileyButton_Click(object sender, EventArgs e)
      {
         currTile = xnaContext.addTile("smiley");
      }

      private void frownyButton_Click(object sender, EventArgs e)
      {
         currTile = xnaContext.addTile("frowny");
         // xnaContext.undo();
      }

      private void xnaContext_Click(object sender, System.EventArgs e)
      {
              xnaContext.placeTile(currTile);
              currTile = null;
      }

      private void xnaContext_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
      {
         if (currTile != null)
         {
            currTile.pos.X = e.X - (e.X % currTile.image.Width);
            currTile.pos.Y = e.Y - (e.Y % currTile.image.Height);
         }
      }

      private void loadToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Stream myStream = null;
         OpenFileDialog openFileDialog1 = new OpenFileDialog();

         openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
         openFileDialog1.FilterIndex = 2;
         openFileDialog1.RestoreDirectory = true;

         if (openFileDialog1.ShowDialog() == DialogResult.OK)
         {
            try
            {
               if ((myStream = openFileDialog1.OpenFile()) != null)
               {
                  using (myStream)
                  {
                     // Insert code to read the stream here.
                  }
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
         }
      }

      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Stream myStream;
         SaveFileDialog saveFileDialog1 = new SaveFileDialog();

         saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
         saveFileDialog1.FilterIndex = 2;
         saveFileDialog1.RestoreDirectory = true;

         if (saveFileDialog1.ShowDialog() == DialogResult.OK)
         {
            if ((myStream = saveFileDialog1.OpenFile()) != null)
            {
               // Code to write the stream goes here.
               myStream.Close();
            }
         }
      }

      private void clearToolStripMenuItem_Click(object sender, EventArgs e)
      {
         xnaContext.clearTiles();
      }
   }
}
