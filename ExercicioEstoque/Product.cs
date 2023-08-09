using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstoque
{
    public class Product
    {
        public string name;
        public double price;
        public int quantity;


        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double ValorTotalEmEstoque()
        {
            return price * quantity;
        }

        public void AdicionarAoEstoque(int quantity)
        {
            this.quantity += quantity;
        }

        public void RemoverDoEstoque(int quantity)
        {
            this.quantity -= quantity;
        }
    }
}
