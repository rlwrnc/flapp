using System;

namespace flapp
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new FlappGame())
                game.Run();
        }
    }
}
