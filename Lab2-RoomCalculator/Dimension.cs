using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_RoomCalculator
{
    class Dimension
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Dimension(double Length, double Width, double Height)
        {
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;
            PrintCalcs();
        }

        public double GetArea()
        {
            return Math.Round((Length * Width), 2);
        }

        public double GetPerimeter()
        {
            return Math.Round(2 * (Length + Width), 2);
        }

        public double GetVolume()
        {
            return Math.Round(Length * Width * Height, 2);
        }

        public void PrintCalcs()
        {
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
            Console.WriteLine($"Volume: {GetVolume()}");
        }
    }
}
