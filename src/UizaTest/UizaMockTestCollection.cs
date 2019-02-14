using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UizaTest
{
    [CollectionDefinition("uiza-mock-test-collection")]
    public class UizaMockTestCollection :
          ICollectionFixture<InitConfigTest>
    {
    }
}
