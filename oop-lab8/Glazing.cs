using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab8
{
    public class Glazing
    {
        private double Width { get; set; }
        private double Height { get; set; }
        private TypesOfMateial Material { get; set; }
        private GlazingType NumOfChambers { get; set; }
        private bool Windowsill { get; set; }

        public Glazing()
        {
            Width = 0;
            Height = 0;
            Material = TypesOfMateial.Wood;
            NumOfChambers = GlazingType.SingleChamber;
            Windowsill = false;
        }
        public Glazing(double width, double height, TypesOfMateial material, GlazingType numOfChambers, bool windowsill)
        {
            Width = width;
            Height = height;
            Material = material;
            NumOfChambers = numOfChambers;
            Windowsill = windowsill;
        }
        public double GetArea()
        {
            double area = Width * Height;
            return area;
        }
        public double CalcPrice()
        { 
            double priceListValue = 0, price = 0;
            switch (NumOfChambers)
            {
                case GlazingType.SingleChamber:
                    switch (Material)
                    {
                        case TypesOfMateial.Wood:
                            priceListValue = 0.25;
                            break;
                        case TypesOfMateial.Metal:
                            priceListValue = 0.05;
                            break;
                        case TypesOfMateial.MetalPlastic:
                            priceListValue = 0.15;
                            break;
                    }
                    break;
                case GlazingType.DoubleChamber:
                    switch (Material)
                    {
                        case TypesOfMateial.Wood:
                            priceListValue = 0.30;
                            break;
                        case TypesOfMateial.Metal:
                            priceListValue = 0.10;
                            break;
                        case TypesOfMateial.MetalPlastic:
                            priceListValue = 0.20;
                            break;
                    }
                    break;
            }
            switch (Windowsill)
            {
                case false:
                    price = GetArea() * priceListValue;
                    break;
                case true:
                    price = GetArea() * priceListValue + 35.0;
                    break;
            }
            return price;
        }
    }
   public enum TypesOfMateial
    {
        Wood,
        Metal,
        MetalPlastic
    }
    public enum GlazingType
    { 
        SingleChamber,
        DoubleChamber
    }

}
