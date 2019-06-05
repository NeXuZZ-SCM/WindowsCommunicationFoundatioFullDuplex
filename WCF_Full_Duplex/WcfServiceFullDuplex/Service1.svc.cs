using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceFullDuplex
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        private static int count = 0;
        public static List<Cliente> clientes;
       

        public Service1()
        {
            clientes = new List<Cliente>();
        }

        IMiServicioDuplexCallback GetCurrentCallBack()
        {
            return OperationContext.Current.GetCallbackChannel<IMiServicioDuplexCallback>();
        }

        public void Sumar()
        {
            count += 1;
            foreach (Cliente item in clientes)
            {
             
                    item.ClientCallback.Mostrar(count);
                
            }
            
        }

        public void Conectar(string clienteNombre)
        {
            Cliente cliente = new Cliente();
            cliente.NombreUsuario = clienteNombre;
            cliente.ClientCallback = this.GetCurrentCallBack();
            clientes.Add(cliente);
        }
    }
}
