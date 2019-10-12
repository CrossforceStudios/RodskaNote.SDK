using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Media;

namespace RodskaNote.Whiteboard.BuiltIn
{
    public class BlackMarker: MarkerBase
    {
        public BlackMarker() : base("Black", Colors.Black)
        {

        }

        public override StylusTip GetTip()
        {
            return StylusTip.Ellipse;
        }
    }
}
