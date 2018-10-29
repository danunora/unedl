using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial
{
    public class Dimensions
    {
        protected int width;
        protected int height;
        protected int depth;
        public int getWidth() { return width; }
        public int getHeight() { return height; }
        public int getDepth() { return depth; }
        public void setWidth(int width) { this.width = width; }
        public void setHeight(int height) { this.height = height; }
        public void setDepth(int depth) { this.depth = depth; }
    }

    public class Color
    {
        protected string color;
        public string getColor() { return color; }
        public void setColor(string color) { this.color = color; }
    }

    public class Caja : Dimensions
    {
        protected string material;
        public string getMaterial() { return material; }
        public void setMaterial(string material) { this.material = material; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dimensions dimension = new Dimensions();
            Console.WriteLine("Depth: "+ dimension.getDepth());
            Caja carton = new Caja();
            carton.setMaterial("carton");
            carton.setDepth(20); carton.setHeight(30); carton.setWidth(40;)
            Console.WriteLine("Caja Depth: " + carton.getDepth());
            Console.WriteLine("Caja Material: " + carton.getMaterial());
        }
    }
}
