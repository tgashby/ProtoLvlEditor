using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Proto_LvlEditor
{
   class Tile
   {
      public Vector2 pos;
      public Texture2D image;
      public string type;

      public Tile(string imgName, ContentManager content)
      {
         image = content.Load<Texture2D>(imgName);
         pos = Vector2.Zero;
         type = imgName;
      }
   }
}
