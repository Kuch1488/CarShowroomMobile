using Xamarin.Essentials;

namespace CarShowroomMobile
{
    public class Constants
    {
        public static string RestUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://carshowroom.somee.com" : "http://carshowroom.somee.com";
    }
}
