using ClienteWF_Duplex.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWF_Duplex
{
    public partial class Form1 : Form, IService1Callback
    {
        Service1Client service;
        public Form1()
        {
            InitializeComponent();
            var instanceContext = new InstanceContext(this);
            service = new Service1Client(instanceContext);
            service.Conectar("formulario");
        }

        public void Mostrar(int numero)
        {
            lblMostrar.Text = numero.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.Sumar();
        }
    }
}
