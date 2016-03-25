using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Sergine.Model;

namespace Sergine.Model.Test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dnx.html
    public class NodeTest
    {   
        [Fact]
        void CanCreateNodeUsingDefaultCtor()
        {
            Node node = new Node();
            Assert.NotNull(node);
        }
    }
}
