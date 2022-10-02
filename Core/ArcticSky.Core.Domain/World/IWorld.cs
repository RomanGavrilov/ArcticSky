using System;

namespace ArcticSky.Core.Domain.World
{
    public interface IWorld
    {
        public TimeSpan ElapsedTimeSinceWorldCreation();
    }
}
