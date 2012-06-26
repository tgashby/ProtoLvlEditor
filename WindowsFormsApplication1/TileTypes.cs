using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proto_LvlEditor
{
   class TileTypes
   {
      private String displayName;
      private String fileName;

      public TileTypes(String displayName, String fileName)
      {
         this.displayName = displayName;
         this.fileName = fileName;
      }

      public String DisplayName
      {
         get
         {
            return displayName;
         }
      }

      public String FileName
      {
         get
         {
            return fileName;
         }
      }
   }
}
