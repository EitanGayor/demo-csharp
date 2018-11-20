namespace Unit.Tests
{
    public class RemoteDriver : IDriver
    {
        private readonly string _browserVersion;
        private readonly string _browser;
        private string _operatingSystem;

        public RemoteDriver(string browser, string browserVersion, string operatingSystem)
        {
            _browser = browser;
            _browserVersion = browserVersion;
            _operatingSystem = operatingSystem;
        }
    }
}