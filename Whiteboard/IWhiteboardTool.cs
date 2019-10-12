using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using RodskaNote.Controls;

namespace RodskaNote.Whiteboard
{
    public enum WhiteboardMode
    {
        Marker,
        Select
    }

    public interface IWhiteboardTool
    {
        public void Apply(Controls.Whiteboard board);
        public string Title { get; set; }
        public WhiteboardMode ToolType { get; }
        public DrawingAttributes GetAttributes();
        public Vector2 Size { get; set; }
    }
}
