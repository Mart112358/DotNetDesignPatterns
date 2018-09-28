namespace DotNetDesignPatterns.Proxy
{
    public class ProxyTest
    {
        public static void Test()
        {
            var image1 = new ProxyImage("HiRes_10MB_Photo1");
            var image2 = new ProxyImage("HiRes_10MB_Photo2");

            image1.DisplayImage(); // loading necessary
            image1.DisplayImage(); // loading unnecessary
            image2.DisplayImage(); // loading necessary
            image2.DisplayImage(); // loading unnecessary
            image1.DisplayImage(); // loading unnecessary
        }
    }
}