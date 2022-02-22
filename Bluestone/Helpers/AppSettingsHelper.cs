using System;

namespace Bluestone.Helpers
{
    public class AppSettingsHelper
    {
#if DEBUG
        public const string BaseUrl = "https://admin.joinme.co.in/";
#elif RELEASE
        public const string BaseUrl = "https://admin.joinme.co.in/";
#endif
    }
}
