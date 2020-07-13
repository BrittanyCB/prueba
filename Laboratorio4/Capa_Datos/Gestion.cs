using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.Entidad;

namespace Capa_Datos
{
    public class Gestion
    {
        List<Datos> listadoData;
        public List<Datos> listadoDatos()
        {
            listadoData = new List<Datos>(); 
            Datos objDatos = new Datos();
            objDatos.IdFactura = 0101;
            objDatos.numLinea = 001;
            objDatos.codProduct = "A001";
            objDatos.detProduct = "Blusa";
            objDatos.cantProduct = 2;
            objDatos.costUnitario = 5000;
            objDatos.totalLinea = 5000;
            listadoData.Add(objDatos);
            objDatos = new Datos() { IdFactura = 0202, numLinea = 002, codProduct = "B002", detProduct = "Camisa", cantProduct = 5, costUnitario= 7000,totalLinea= 7500 };
            listadoData.Add(objDatos);
            objDatos = new Datos() { IdFactura = 0303, numLinea = 003, codProduct = "C003", detProduct = "Pantalon", cantProduct= 1, costUnitario=15000, totalLinea= 16000 };
            listadoData.Add(objDatos);
            return listadoData;

        }
    }
}
