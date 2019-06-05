using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceFullDuplex
{
    public class Cliente
    {
        private IMiServicioDuplexCallback _clienteCallback;
        public IMiServicioDuplexCallback ClientCallback
        {
            get { return _clienteCallback; }
            set { _clienteCallback = value; }
        }
        private string _nombreUsuaio;
        public string NombreUsuario
        {
            get { return _nombreUsuaio; }
            set { _nombreUsuaio = value; }
        }
        public Cliente()
        {
            _clienteCallback = null;
            _nombreUsuaio = "";
        }
    }
}