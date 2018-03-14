using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace LogicaCollatz
{
    [ServiceContract]
    public interface IcontratoCollatz
    {
        [OperationContract]
        List<int> GetConjeturaCollatz(int numero);
        [OperationContract]
        String GetSaludo();
        String MetodoSincontrato();

    }
}
