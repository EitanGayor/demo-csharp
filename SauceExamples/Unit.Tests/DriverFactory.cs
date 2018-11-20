namespace Unit.Tests
{
    public class DriverFactory
    {
        public IDriver CreateRemoteDriver(string testBrowser, string testBrowserVersion, string testOs)
        {
            return new RemoteDriver(testBrowser, testBrowserVersion, testOs);
        }
    }

    public class RemoteDriver : IDriver
    {
        private readonly string _testBrowserVersion;
        private readonly string _testBrowser;
        private string _testOs;

        public RemoteDriver(string testBrowser, string testBrowserVersion, string testOs)
        {
            _testBrowser = testBrowser;
            _testBrowserVersion = testBrowserVersion;
            _testOs = testOs;
        }
    }
}