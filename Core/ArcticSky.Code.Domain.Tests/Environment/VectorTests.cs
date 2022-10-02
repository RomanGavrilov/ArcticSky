using ArcticSky.Core.Domain.World;
using Xunit;

namespace ArcticSky.Code.Domain.Tests
{
    public class VectorTests
    {
        [Fact]
        public void Should_return_true_for_equal_positions()
        {
            Assert.Equal(new Vector(1, 2, 3), new Vector(1, 2, 3));
            Assert.NotEqual(new Vector(0, 0, -1), new Vector(1, 2, 3));
            Assert.Equal(Vector.Zero, new Vector(0, 0, 0));
            Assert.Equal(Vector.Identity, new Vector(1, 1, 1));
        }

        [Fact]
        public void Should_add_vectors()
        {
            var a = new Vector(-1, 2, 3);
            var b = new Vector(-2, 4, 6);
            Assert.Equal(a + a, b);
            Assert.Equal(a + a + a + a, b + b);
        }

        [Fact]
        public void Should_substract_vectors()
        {
            var a = new Vector(1, 2, 3);
            Assert.Equal(a - a, Vector.Zero);
            Assert.Equal(a - a - a, a.Inverse);
        }

        [Fact]
        public void Should_multiply_vectors()
        {
            var a = new Vector(1, 2, 3);
            var result = new Vector(1, 4, 9);

            Assert.Equal(a * a, result);
            Assert.Equal(a * Vector.Zero, Vector.Zero);
            Assert.Equal(a * a.Inverse, result.Inverse);
            Assert.Equal(a * Vector.Identity, a);
            Assert.Equal(a * Vector.Identity.Inverse, a.Inverse);
        }

    }
}
