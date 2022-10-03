using System;
namespace CSharp
{
    public class Box
    {
        // member variable
        private int length = 3;
        public int height;
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
        // getter
        public int GetLength()
        {
            return this.length;
        }
    }
}

