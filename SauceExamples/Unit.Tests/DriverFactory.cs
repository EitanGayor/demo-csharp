namespace Unit.Tests
{
    public class DriverFactory
    {
        public IDriver CreateRemoteDriver(string testBrowser, string testBrowserVersion, string testOs)
        {
            return new RemoteDriver(testBrowser, testBrowserVersion, testOs);
        }
    }
}