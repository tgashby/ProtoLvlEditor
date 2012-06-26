using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using Microsoft.Xna.Framework;
using System.Text.RegularExpressions;
using System.Collections;

namespace Proto_LvlEditor
{
   public partial class Editor : Form
   {
      Tile currTile;
      ArrayList tileTypes;
      int mouseX, mouseY;

      public Editor()
      {
         tileTypes = new ArrayList();
         tileTypes.Add(new TileTypes("Smiley", "smiley"));
         tileTypes.Add(new TileTypes("Frowney", "frowny"));

         InitializeComponent();

         this.tileSelection.SelectedIndex = -1;

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
         this.xnaContext.KeyDown += new KeyEventHandler(xnaContext_KeyDown);
         this.xnaContext.KeyUp += new KeyEventHandler(xnaContext_KeyUp);
      }

      void xnaContext_KeyUp(object sender, KeyEventArgs e)
      {
         int DELETE_KEY = 46;

         if (e.KeyValue == DELETE_KEY)
         {
            xnaContext.removeTile(currTile);
            currTile = null;
         }
      }

      private void xnaContext_KeyDown(object sender, KeyEventArgs e)
      {
         Console.WriteLine(e.KeyValue);
         if (e.Shift && currTile != null)
         {
            duplicateTile();
         }
      }

      public static Control FindFocusedControl(Control control)
      {
         ContainerControl container = control as ContainerControl;
         while (container != null)
         {
            control = container.ActiveControl;
            container = control as ContainerControl;
         }
         return control;
      }

      private void duplicateTile()
      {
          if (getTileAtMouse() != null)
          {
              xnaContext.placeTile(currTile);
              currTile = xnaContext.addTile(currTile.type);
          }
      }

      private void smileyButton_Click(object sender, EventArgs e)
      {
         currTile = xnaContext.addTile("smiley");

         // Set XNA context to focus so that duplication works
         this.xnaContext.Focus();
      }

      private void frownyButton_Click(object sender, EventArgs e)
      {
         currTile = xnaContext.addTile("frowny");
         // xnaContext.undo();

         // Set XNA context to focus so that duplication works
         this.xnaContext.Focus();
      }

      private void xnaContext_Click(object sender, System.EventArgs e)
      {
          if (currTile == null)
          {
              currTile = getTileAtMouse();
          }
          else
          {
              xnaContext.placeTile(currTile);
              currTile = null;
          }

          this.xnaContext.Focus();
      }

      private Tile getTileAtMouse()
      {
          int x = mouseX;
          int y = mouseY;

          foreach (Tile t in xnaContext.getTiles())
          {
              if (x > t.pos.X && x < t.pos.X + t.image.Width &&
                  y > t.pos.Y && y < t.pos.Y + t.image.Height)
              {
                  return t;
              }
          }

          return null;
      }

      private void xnaContext_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
      {
         if (currTile != null)
         {
            currTile.pos.X = e.X - (e.X % currTile.image.Width);
            currTile.pos.Y = e.Y - (e.Y % currTile.image.Height);
         }

         mouseX = e.X;
         mouseY = e.Y;
      }

      private void loadToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Stream myStream = null;
         OpenFileDialog openFileDialog1 = new OpenFileDialog();

         openFileDialog1.Filter = "map files (*.mp)|*.mp";
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
                     StreamReader sr = new StreamReader(myStream);

                     XElement xml = XElement.Parse(sr.ReadToEnd());
                     loadMap(xml);
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

         saveFileDialog1.Filter = "map files (*.mp)|*.mp";
         saveFileDialog1.FilterIndex = 2;
         saveFileDialog1.RestoreDirectory = true;

         if (saveFileDialog1.ShowDialog() == DialogResult.OK)
         {
            if ((myStream = saveFileDialog1.OpenFile()) != null)
            {
               byte[] bytes = saveMap();
               myStream.Write(bytes, 0, bytes.Length);
               myStream.Close();
            }
         }
      }

      private byte[] saveMap()
      {
         XElement map = new XElement("map",
            from Tile t in xnaContext.getTiles()
            select new XElement("tile",
               new XAttribute("type", t.type),
               new XAttribute("loc", t.pos)));

         return Encoding.ASCII.GetBytes(map.ToString());
      }

      private void clearToolStripMenuItem_Click(object sender, EventArgs e)
      {
         xnaContext.clearTiles();
      }

      private void loadMap(XElement xml)
      {
         xnaContext.clearTiles();
         Tile t;

         foreach (XElement tile in xml.Elements("tile"))
         {
            t = xnaContext.addTile(tile.Attribute("type").Value);
            t.pos = parseVector2(tile.Attribute("loc").Value);
         }
      }

      private Vector2 parseVector2(string p)
      {
         Vector2 vec;

         string[] s = Regex.Split(p, @"\D+");

         vec.X = float.Parse(s[1]);
         vec.Y = float.Parse(s[2]);

         return vec;
      }

      private void tileSelector_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (this.tileSelection.SelectedIndex != -1)
         {
            String selected = ((TileTypes)this.tileSelection.SelectedItem).FileName;

            currTile = this.xnaContext.addTile(selected);
         }
      }

      private void initTiles(object sender, EventArgs e)
      {
         this.tileSelection.DataSource = tileTypes;
         this.tileSelection.DisplayMember = "DisplayName";
         this.tileSelection.ValueMember = "FileName";

         this.tileSelection.SelectedIndexChanged += new EventHandler(tileSelector_SelectedIndexChanged);
      }
   }
}
