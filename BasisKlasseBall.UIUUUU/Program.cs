using BasisklasseBall;
using BasisklasseBall.UIUUUU;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Ball> ballz = new();
        ballz.Add(new Ball(0, 0, 0, 0, (ConsoleColor)1));
        Console.CursorVisible = false;
        Console.WindowHeight = 20;
        Console.WindowWidth = 30;
        PlayerBall player = new PlayerBall(0, 0, 0, 0);
        var currenLevel = 1;
        var rnd = new Random();
        var timer = 0;

        while (currenLevel < 10)
        {
            Console.Clear();

            //Ball
            foreach (var ball in ballz.ToList())
            {
                ball.Update();
                ball.Draw();
                var currentBall = ball;

                //SpelerBall
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    player.ChangeVelocity(key);
                }

                player.Update();
                player.Draw();

                //Check collisions

                if (currentBall.CheckHit())
                {
                    ballz.Remove(ball);
                }

                if (ballz.Count == 0)
                {
                    Console.SetCursorPosition(15, 10);
                    Console.WriteLine("NEXT LEVEL in 2 sec!");
                    Thread.Sleep(2000);
                    currenLevel++;

                    for (var i = 0; i < currenLevel; i++)
                    {
                        ballz.Add(new Ball(rnd.Next(0, 20), rnd.Next(0, 20), rnd.Next(0, 20), rnd.Next(0, 20), (ConsoleColor)rnd.Next(0, 10)));
                    }
                    Console.Clear();
                }

                System.Threading.Thread.Sleep(100);
                timer++;
            }
        }
        Console.WriteLine($"Uitgespeeld op {timer / 1000} seconden");
    }
}