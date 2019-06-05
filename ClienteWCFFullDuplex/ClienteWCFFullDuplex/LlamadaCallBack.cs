using System;
using System.ServiceModel;
using ClienteWCFFullDuplex.ServiceReference1;
using System.Threading;

namespace ClienteWCFFullDuplex
{
    public class LlamadaACallBack : IService1Callback
    {
        public void EnviarMensaje()
        {
            var instanceContext = new InstanceContext(this);
            var service = new Service1Client(instanceContext);
            service.Conectar("consola");
            Console.Read();

        }

        public void Mostrar(int numero)
        {
            Console.WriteLine(numero);
        }
    }
}
