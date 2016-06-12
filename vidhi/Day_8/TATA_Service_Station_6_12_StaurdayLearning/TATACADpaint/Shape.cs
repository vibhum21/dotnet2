using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TATACADpaint
{
    [Serializable]
   public abstract class Shape
    {

       public abstract void Draw(Graphics g);

    }
}
