using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsFormsPlane
{
    public interface IFighter
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        
        void DrawFighter(Graphics g);
    }
}
