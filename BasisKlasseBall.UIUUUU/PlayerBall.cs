﻿namespace BasisklasseBall.UIUUUU
{
    public class PlayerBall : Ball
    {
        public PlayerBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, vxin, vyin)
        {
            drawChar = 'X';
            DrawColor = ConsoleColor.Green;
        }

        public void ChangeVelocity(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    vy--;
                    break;

                case ConsoleKey.DownArrow:
                    vy++;
                    break;

                case ConsoleKey.LeftArrow:
                    vx--;
                    break;

                case ConsoleKey.RightArrow:
                    vx++;
                    break;

                default:
                    break;
            }
        }
    }
}