using BridgeExample;
using Xunit;

namespace BridgeExampleTest
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class BackwardsFormatterShould
    {
        [Fact]
        public void FormatValueBackwards()
        {
            BackwardsFormatter formatter = new BackwardsFormatter();
            string formatted = formatter.Format("Title", "The Animal Farm");

            Assert.Equal("Title: mraF laminA ehT", formatted);
        }
    }
}
