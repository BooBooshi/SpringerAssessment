using NUnit.Framework;
using NUnit.Core;

namespace SeleniumTests
{
    public class Springer
    {
        [Suite] public static TestSuite Suite
        {
            get
            {
                TestSuite suite = new TestSuite("Springer");
                suite.Add(new ClickingOnSearchButton());
                suite.Add(new EnterNumbers());
                suite.Add(new NoResultsMessage());
                return suite;
            }
        }
    }
}
