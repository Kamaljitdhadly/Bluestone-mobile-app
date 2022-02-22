using System.Globalization;
using System.Threading;

[assembly: Xamarin.Forms.Dependency(typeof(Bluestone.Helpers.LocalizeHelper))]
namespace Bluestone.Helpers
{
    public class LocalizeHelper : ILocalizeHelper
    {
        public CultureInfo GetCurrentCultureInfo()
        {
            return new System.Globalization.CultureInfo("en");
        }

        public void SetLocale(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}
