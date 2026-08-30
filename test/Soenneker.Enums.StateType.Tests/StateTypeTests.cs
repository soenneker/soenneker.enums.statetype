using Soenneker.Tests.HostedUnit;
using System.Linq;
using System.Threading.Tasks;

namespace Soenneker.Enums.StateType.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class StateTypeTests : HostedUnitTest
{
    public StateTypeTests(Host host) : base(host)
    {
    }

    [Test]
    public async Task Values_are_unique_and_abbreviations_are_case_insensitive()
    {
        int distinctValues = StateType.List.Select(state => state.Value).Distinct().Count();

        await Assert.That(distinctValues).IsEqualTo(StateType.List.Count);
        await Assert.That(StateType.FromValue(52)).IsEqualTo(StateType.DistrictOfColumbia);
        await Assert.That(StateType.FromAbbreviation("dc")).IsEqualTo(StateType.DistrictOfColumbia);
    }
}
