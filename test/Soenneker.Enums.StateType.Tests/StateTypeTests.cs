using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.StateType.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class StateTypeTests : HostedUnitTest
{
    public StateTypeTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
