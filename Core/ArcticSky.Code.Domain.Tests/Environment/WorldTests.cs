using System.Threading;
using ArcticSky.Core.Domain.World;
using Xunit;

namespace ArcticSky.Code.Domain.Tests.Environment
{
    public class WorldTests
    {
        [Fact]
        public void Should_create_new_world_with_timer()
        {
            var world = World.Instance;
            Thread.Sleep(100);
        }
    }
}
