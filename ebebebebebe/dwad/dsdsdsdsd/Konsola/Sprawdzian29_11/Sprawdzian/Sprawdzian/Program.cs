using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian
{
    class DynamicTable
    {
        public double[] tabela = [1.0, 2.0, 3.0];

        public void addItem(double newItem)
        {
            for(int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] == tabela.Length)
                { 
                    tabela[i] =+ newItem;
                }
            }
        }

        public void deleteItem(int deleteIndex)
        {
            for(int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] == deleteIndex)
                {
                    tabela[i] = 0;
                }
            }
        }

        public String Tostring()
        {
            StringBuilder sb = new StringBuilder();
            foreach(int i in tabela)
            { 
                sb.Append(i+" ");
            }

            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicTable table = new DynamicTable();

            Console.WriteLine("Tabica przed zmianą: "+ table.Tostring());

            table.addItem(5.0);
            table.deleteItem(1);

            Console.Write("Tabela po zmianie: "+ table.Tostring());

            Console.ReadKey();
        }
    }
}
