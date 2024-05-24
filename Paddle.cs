using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1234
{
    internal class Paddle
    {
        // 屬性
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        // 建構子
        public Paddle(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
        }

        // 加入其他方法

        // 繪製擋板

        // TODO: 左右移動擋板
        internal void Draw(Graphics gr)
        {
            gr.FillRectangle(new SolidBrush(Color.Blue), X, Y, Width, Height);
        }

        //
        public void Move(int vx, int panelWidth)
        {
            X += vx;
            if (X < 0) X = 0;
            if (X + Width > panelWidth) X = panelWidth - Width;
        }
    }
}
