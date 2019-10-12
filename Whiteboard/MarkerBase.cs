using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using RodskaNote.Controls;
using System.Numerics;

namespace RodskaNote.Whiteboard.BuiltIn
{
    public abstract class MarkerBase: IWhiteboardTool
    {
        public Color Color { get; set; }
        public string Title { get; set; }
        public WhiteboardMode ToolType { get => WhiteboardMode.Marker; }

        public abstract StylusTip GetTip();

        private double _width;

        private double _height;

        public Vector2 Size
        {
            get => new Vector2((float)_width, (float)_height); 
            set
            {
                _width = value.X; _height = value.Y;
            }
        }
        public MarkerBase(string title, Color initialColor)
        {
            Title = title;
            Color = initialColor;
        }

        public DrawingAttributes GetAttributes()
        {
            return new DrawingAttributes()
            {
                Color = Color,
                StylusTip = GetTip(),
                Width = Size.X,
                Height = Size.Y,
                IgnorePressure = true
            };
        }

        public void Apply(Controls.Whiteboard board)
        {
            board.whiteBoardCanvas.DefaultDrawingAttributes = GetAttributes();
        }


    }
}
