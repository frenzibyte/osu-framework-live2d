﻿using System;
using osu.Framework.Platform;

namespace osu.Framework.Live2D.Tests
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            bool benchmark = args.Length > 0 && args[0] == @"-benchmark";

            using (GameHost host = Host.GetSuitableHost(@"osu-framework-live2d"))
            {
                if (benchmark)
                    host.Run(new AutomatedVisualTestGame());
                else
                    host.Run(new VisualTestGame());
            }
        }
    }
}
