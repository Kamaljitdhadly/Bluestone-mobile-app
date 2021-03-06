using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.Threading.Tasks;

namespace Bluestone.Helpers
{
    internal static class PermissionsHelper
    {
        internal static async Task<bool> RequestStorrageAccess()
        {
            var currentStatus = await CrossPermissions.Current.CheckPermissionStatusAsync<StoragePermission>();
            if (currentStatus != PermissionStatus.Granted)
            {
                var status = await CrossPermissions.Current.RequestPermissionAsync<StoragePermission>();
                return status == PermissionStatus.Granted;
            }
            else
            {
                return true;
            }
        }

        internal static async Task<bool> RequestCameraAccess()
        {
            var currentStatus = await CrossPermissions.Current.CheckPermissionStatusAsync<CameraPermission>();
            if (currentStatus != PermissionStatus.Granted)
            {
                var status = await CrossPermissions.Current.RequestPermissionAsync<CameraPermission>();
                return status == PermissionStatus.Granted;
            }
            else
            {
                return true;
            }
        }

        internal static async Task<bool> RequestPhotosAccess()
        {
            var currentStatus = await CrossPermissions.Current.CheckPermissionStatusAsync<PhotosPermission>();
            if (currentStatus != PermissionStatus.Granted)
            {
                var status = await CrossPermissions.Current.RequestPermissionAsync<PhotosPermission>();
                return status == PermissionStatus.Granted;
            }
            else
            {
                return true;
            }
        }
    }
}
