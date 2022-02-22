using Xamarin.Forms;

namespace Bluestone.Services.Toast
{
    public interface IToastMessageService
    {
        void LongAlert(string message);

        void ShortAlert(string message);
    }
}
