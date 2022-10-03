using System;
namespace CSharp
{
    public class Box
    {
        // member variable
        private int length = 3;
        private int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", length, height, width, volume = length*height*width);
        }

        // setter
        public void SetLength(int length)
        {
            this.length = length;
        }
        private void SetHeight(int height) // only accesible from the class itslef or child classes (inheritance)
        {
            this.height = height;
        }
        // getter
        public int GetLength()
        {
            return this.length;
        }

        // properties (they start with a Capital letter)
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        // prop command
        public int Width { get; set; }
    }
}

