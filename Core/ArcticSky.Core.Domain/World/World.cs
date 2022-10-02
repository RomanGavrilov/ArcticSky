using System;
using System.Diagnostics;

namespace ArcticSky.Core.Domain.World
{
    public class World : IWorld
    {
        private static World _instance;
        private bool _disposed;
        private static object _lock = new object();
        private Stopwatch Timer { get; }

        private World()
        {
            Timer.Start();
        }

        public static World Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock(_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new World();
                        }
                    }
                }

                return _instance;
            }
        }

        public TimeSpan ElapsedTime()
        {
            return Timer.Elapsed;
        }
    }
}
