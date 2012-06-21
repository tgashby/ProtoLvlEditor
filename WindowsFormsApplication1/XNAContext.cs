#region File Description
//-----------------------------------------------------------------------------
// SpriteFontControl.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
#endregion

namespace Proto_LvlEditor
{
    /// <summary>
    /// Example control inherits from GraphicsDeviceControl, which allows it to
    /// render using a GraphicsDevice. This control shows how to use ContentManager
    /// inside a WinForms application. It loads a SpriteFont object through the
    /// ContentManager, then uses a SpriteBatch to draw text. The control is not
    /// animated, so it only redraws itself in response to WinForms paint messages.
    /// </summary>
    class XNAContext : GraphicsDeviceControl
    {
        ContentManager content;
        SpriteBatch spriteBatch;
        List<Tile> tiles;
        List<List<Tile>> states;
        public int currentState;

        /// <summary>
        /// Initializes the control, creating the ContentManager
        /// and using it to load a SpriteFont.
        /// </summary>
        protected override void Initialize()
        {
            content = new ContentManager(Services, "Content");

            spriteBatch = new SpriteBatch(GraphicsDevice);

            tiles = new List<Tile>();

            states = new List<List<Tile>>();

            currentState = 0;

            Application.Idle += delegate { Invalidate(); };
        }


        /// <summary>
        /// Disposes the control, unloading the ContentManager.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                content.Unload();
            }

            base.Dispose(disposing);
        }


        /// <summary>
        /// Draws the control, using SpriteBatch and SpriteFont.
        /// </summary>
        protected override void Draw()
        {
            GraphicsDevice.Clear(Color.White);            

            // Draw
            spriteBatch.Begin();

            foreach (Tile t in tiles)
            {
               spriteBatch.Draw(t.image, t.pos, Color.White);
            }
            
            spriteBatch.End();
        }

        public Tile addTile(string tileName)
        {
           Tile t = new Tile(tileName, content);
           tiles.Add(t);

           return t;
        }

        //This function should be called when placing a tile. It will overwrite
        // Anything that currently occupies that position.
        public void placeTile(Tile entry)
        {
            int latestIndex = tiles.IndexOf(entry);

            if (entry == null)
            {
                return;
            }
           /* for (int i = currentState; i < 11; i++)
            {
                states[i].Clear();
            }*/
            if (currentState == 11)
            {
                states.RemoveAt(0);
                states.Add(new List<Tile>());
                currentState--;
            }
            else if (currentState == states.Count)
            {
                states.Add(new List<Tile>());
            }
            states[currentState].Clear();
            foreach (Tile t in tiles)
            {
                if (tiles.IndexOf(t) != latestIndex)
                {
                    states[currentState].Add(t);
                }
            }
            currentState++;

            foreach (Tile current in tiles)
            {
                if (current.pos == entry.pos && tiles.IndexOf(current) != latestIndex)
                {
                    tiles.Remove(current);
                    break;
                }
            }
        }

        public void undo()
        {
            if (currentState > 0)
            {
                currentState--;
                tiles.Clear();
                foreach (Tile t in states[currentState])
                {
                    tiles.Add(t);
                }
            }
        }

        public void clearTiles()
        {
           tiles = new List<Tile>();
        }

        public List<Tile> getTiles()
        {
           return tiles;
        }
    }
}
