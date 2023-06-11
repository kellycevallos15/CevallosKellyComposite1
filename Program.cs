using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingrediente oIngrediente1 = new Ingrediente("Harina", 1, 200, "gramos");
            Ingrediente oIngrediente2 = new Ingrediente("Leche", 2, 1, "litro");
            Ingrediente oIngrediente3 = new Ingrediente("Huevo", 2, 1, "kilo");

            //creamos el pastel
            PastelComposite oPastel = new PastelComposite("Pastel de leche");
            oPastel.Add(oIngrediente1);
            oPastel.Add(oIngrediente2);
            oPastel.Add(oIngrediente3);

           // Console.WriteLine(oPastel.Costo);

            Ingrediente oIngrediente4 = new Ingrediente("Chocolate",2,1,"litro");
            PastelComposite oPastelChocolateYLeche =new PastelComposite("Pastel compuesto");

            oPastelChocolateYLeche.Add(oIngrediente4);
            oPastelChocolateYLeche.Add(oPastel);

            Console.WriteLine(oPastelChocolateYLeche.CostoTotal);
        }
    }
}
