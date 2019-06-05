using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceFullDuplex
{
    //SERVICIO
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IMiServicioDuplexCallback))]
    public interface IService1
    {
        [OperationContract(IsOneWay = true)]
        void Sumar();
        [OperationContract(IsOneWay = true)]
        void Conectar(string clienteNombre);
    }
    //CLIENTE
    [ServiceContract]
    public interface IMiServicioDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void Mostrar(int numero);
    }
}
