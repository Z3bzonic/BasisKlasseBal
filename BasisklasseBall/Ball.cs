namespace BasisklasseBall
{
    public class Ball
    {
        public int X
        { get { return x; } }

        public int Y
        { get { return y; } }

        public ConsoleColor DrawColor { get; set; }
        public int Xin { get; }
        public int Yin { get; }
        public int Vxin { get; }
        public int Vyin { get; }

        private int x = 0;
        private int y = 0;
        public int vx = 0;
        public int vy = 0;
        public int pvx = 0;
        public int pvy = 0;
        protected char drawChar = 'O';

        public Ball(int xin, int yin, int vxin, int vyin, ConsoleColor color)
        {
            x = xin;
            y = yin;
            vx = vxin;
            vy = vyin;
            DrawColor = color;
        }

        public Ball(int xin, int yin, int vxin, int vyin)
        {
            Xin = xin;
            Yin = yin;
            Vxin = vxin;
            Vyin = vyin;
        }

        public void Update()
        {
            x += vx;
            y += vy;
            if (x >= Console.WindowWidth || x < 0)
            {
                vx *= -1;
                x += vx;
            }
            if (y >= Console.WindowHeight || y < 0)
            {
                vy *= -1;
                y += vy;
            }
            CheckHit();
        }

        public void UpdatePLayer()
        {
            Update();
            pvx = vx;
            pvy = vy;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = DrawColor;
            Console.Write(drawChar);
        }

        public bool CheckHit()
        {
            if (vx == pvx && vy == pvy)
                return true;

            return false;
        }
    }
}