using NUnit.Framework;
using System.Linq;
using Assert = NUnit.Framework.Assert;


namespace MartianRobots.Tests
{
    [TestFixture]
    public class SampleTests
    {
        [Test]
        public void SampleInput_ProducesSampleOutput()
        {
            var input = @"5 3
                        1 1 E
RFRFRFRF
3 2 N
FRRFLLFFRRFLL
0 3 W
LLFFFLFLFL
";

            var output = Simulation.Run(input).ToArray();

            Assert.That(output, Is.EqualTo(new[] { "1 1 E", "3 3 N LOST", "2 3 S" }));
        }
    }
}
