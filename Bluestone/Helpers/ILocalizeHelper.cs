using System.Globalization;
namespace Bluestone.Helpers
{
    public interface ILocalizeHelper
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }
}
