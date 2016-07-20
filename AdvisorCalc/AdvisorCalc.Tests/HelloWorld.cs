using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdvisorCalc.Tests
{
    public class HelloWorld
    {
        [Fact]
        public void IsThisThingOn()
        {
            Assert.Equal(2, 1 + 1);
        }
    }
}
