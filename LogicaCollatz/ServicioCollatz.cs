using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCollatz
{
    public class ServicioCollatz : IcontratoCollatz
    {
        public List<int> GetConjeturaCollatz(int numero)
        {
            List<int> datos = new List<int>();
            datos.Add(numero);
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                datos.Add(numero);
            }
            return datos;
        }

        public string GetSaludo()
        {
            return "Bienvenido al WCF-post";
        }

        public string MetodoSincontrato()
        {
            return "no me verás jamás";
        }
    }
}
