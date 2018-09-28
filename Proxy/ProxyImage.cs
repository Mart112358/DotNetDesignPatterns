namespace DotNetDesignPatterns.Proxy
{
    //on System B 
    public class ProxyImage : IImage
    {
        private readonly string _filename;
        private RealImage _image;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void DisplayImage()
        {
            if (_image == null) _image = new RealImage(_filename);
            _image.DisplayImage();
        }
    }
}