using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Products
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }

        public virtual int GetSizePrice()
        {
            if (Size == "s")
            {
                Price = 10;
            }
            else if (Size == "m")
            {
                Price = 20;
            }
            else if (Size == "l")
            {
                Price = 30;
            }
            return Price;
        }

        public virtual int GetTotal()
        {

            return GetSizePrice();
        }
    }

        public class Tshirt : Products
    {
        
    }

    public class Golfer : Products
    {
        public override int GetSizePrice()
        {
            if (Size == "s")
            {
                Price = 10*2;
            }
            else if (Size == "m")
            {
                Price = 20*2;
            }
            else if (Size == "l")
            {
                Price = 30*2;
            }
            return Price;
        }
    }

    public class Jeans : Products
    {

    }

    public class FormalPants : Products
    {
        public override int GetSizePrice()
        {
            if (Size == "s")
            {
                Price = 10 + 30;
            }
            else if (Size == "m")
            {
                Price = 20 + 30;
            }
            else if (Size == "l")
            {
                Price = 30 + 30;
            }
            return Price;
        }

    }
    
    public class Program 
    {
        static void Main(string[] args)
        {
            List<Products> baskets = new List<Products>();

            var tshirt = new Tshirt();
            tshirt.Name = "DC Comics";
            tshirt.Size = "m";
            baskets.Add(tshirt);

            var G = new Golfer();
            G.Name = "Polo";
            G.Size = "s";
            baskets.Add(G);

            var J = new Jeans();
            J.Name = "Guess";
            J.Size = "l";
            baskets.Add(J);

            var FP = new FormalPants();
            FP.Name = "DH";
            FP.Size = "l";
            baskets.Add(FP);

            //foreach (Products basket in baskets)
            //{
            //    Console.WriteLine(basket.Name + " cost: R" + basket.GetTotal());
            //}
            //Console.WriteLine("----------------------------------------------------------------");
            
            Console.WriteLine("Your total price is R" + baskets.Sum(i => i.GetTotal()));
            Console.Read();
        }

     }

  }

   



