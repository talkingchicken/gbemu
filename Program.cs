using System;

namespace gbemu
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new GbEmu())
                game.Run();
        }
    }
}
