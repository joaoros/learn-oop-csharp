using System;
namespace poo_s4_3 
{

    public class Retangulo 
    {

        public double Width, Height;

        public double Area() 
        {
            return Width * Height;
        }

        public double Perimetro() 
        {
            return 2 * (Width + Height);
        }

        public double Diagonal() 
        {
            return Math.Sqrt(Width*Width + Height*Height);
        }
    }
}
