using BridgeExample;
using Xunit;

namespace BridgeExampleTest
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class BookShould
    {
        private readonly IFormatter _formatter = new StandardFormatter();

        [Fact]
        public void PrintBookPropertiesToConsole()
        {
            Book book = new Book(_formatter)
            {
                Title = "Lots of Patterns",
                Author = "John Sonmez",
                Text = "Blah blah blah..."
            };
            book.Print();

            Assert.True(true);
        }
    }
}
