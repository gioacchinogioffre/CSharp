using System;
namespace CSharp
{
    public class Box
    {
        // member variable
        private int length = 3; // only accesible from the class itself because its private
        private int height;
        // public int width;
        private int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", length, height, Width, volume = length*height*Width);
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
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

        // PROPERTIES (they start with a Capital letter)
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0) height = -value;
                else this.height = value;
            }
        }

        // prop command / short approach to create a property when we don't need additional logic (don't need to create a variable either)
        public int Width { get; set; }

        public int Volume 
        {
            get { return this.length * this.height * this.Width; }
        }

    }
}

