using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1234
{
    internal class Ball
    {
        // 屬性
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public int VelocityX { get; set; }
        public int VelocityY { get; set; }
        // 建構子
        public Ball(int x, int y, int radius, int vx, int vy, Color color)
        {
            X = x;
            Y = y;
            Radius = radius;
            Color = color;
            // 初始化球的速度
            VelocityX = vx;
            VelocityY = vy;
        }
        // 加入其他方法

        // TODO - 繪製球
        internal void Draw(Graphics gr)
        {
            gr.FillEllipse(new SolidBrush(this.Color), X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }

        // 移動球
        public void Move(int left, int top, int right, int Bottom)
        {
            // TODO - 根據速度更新球的位置
            X += VelocityX;
            Y += VelocityY;
            //
            // 水平方向: 檢查球是否碰到牆壁
            if (X - Radius <= left)
            {
                VelocityX = -VelocityX; // 球反彈
                X = left + Radius; // 避免球超出邊界
            }
            else if (X + Radius >= right)
            {
                VelocityX = -VelocityX; // 球反彈
                X = right - Radius; // 避免球超出邊界
            }

            // TODO: 垂直方向: 檢查球是否碰到牆壁? 下方牆壁==>遊戲結束!
            if (Y - Radius <= top)
            {
                VelocityY = -VelocityY;
                Y = top + Radius;
            }
            else if (Y + Radius >= Bottom)
            {
                // TODO : fail ?
                VelocityY = -VelocityY;
                Y = Bottom - Radius;
            }
        }

        // 檢查碰撞事件 : 球是否與任一磚塊或擋板發生碰撞
        public void CheckCollision(Paddle paddle, Brick[,] bricks, Action onGameOver, Action onWin)
        {
            // (A) 逐一檢查: 球是否與所有的磚塊發生碰撞
            bool brickHit = false;
            //     => 磚塊消失, 球反彈!
            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                for (int j = 0; j < bricks.GetLength(1); j++)
                {
                    // 如果磚塊存在
                    Brick brick = bricks[i, j];
                    if (brick != null)
                    {
                        if (X + Radius >= brick.X && X - Radius <= brick.X + brick.Width &&
                            Y + Radius >= brick.Y && Y - Radius <= brick.Y + brick.Height)
                        {
                            VelocityY = -VelocityY; // 球反彈
                            // 磚塊消失
                            bricks[i, j] = null;

                            // TODO: 檢查是否所有磚塊都消失 ==> 遊戲結束
                            brickHit = true;
                            // break : 一次只讓ㄧ個磚塊消失 
                            break;
                        }
                    }
                }
                if (brickHit) break;
            }
            // (B) 檢查球是否與擋板發生碰撞
            //     => 球反彈!
            if (X + Radius >= paddle.X && X - Radius <= paddle.X + paddle.Width &&
                               Y + Radius >= paddle.Y && Y - Radius <= paddle.Y + paddle.Height)
            {
                // 球反彈
                VelocityY = -VelocityY;
                Y = paddle.Y - Radius - 1;
                // 確保球不會黏在擋板上 ==> 還有努力空間!
                if (Y < paddle.Y)
                    Y = paddle.Y - Radius - 1;
                else if (Y > paddle.Y + paddle.Height)
                    Y = paddle.Y + paddle.Height + Radius + 1;
            }
            bool allBricksCleared = true;
            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                for (int j = 0; j < bricks.GetLength(1); j++)
                {
                    if (bricks[i, j] != null)
                    {
                        allBricksCleared = false;
                        break;
                    }
                }
                if (!allBricksCleared) break;
            }
            if (allBricksCleared)
            {
                onWin();
            }

            // 檢查球是否超出底部邊界
            if (Y + Radius >= paddle.Y + paddle.Height)
            {
                onGameOver();
            }
        }

    }
}
