using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Negocio
{
    public class ControladorRetencionImpuesto: Negocios
    {
        ModeloRetencionImpuesto cn = new ModeloRetencionImpuesto();
        public Tuple<DataTable,string> ConsultaRetencion()
        {
            DataTable dt;
            
            var result= cn.ConsultaRetencion();

            dt = PreparaRetenciones(result.Item1);

            dt = AddColumnOld(dt, "OldWtCode", "WTCode");

            return Tuple.Create(dt,result.Item2);

        }

        public Tuple<int, string> EliminaRetencion(string retencionImpuesto)
        {
            return cn.EliminaRetencion(retencionImpuesto);
        }

        public DataTable PreparaRetenciones(DataTable dt)
        {
            DataTable newTable = dt;

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.ToString() == "Category" && row[column].ToString() == ((char)Categoria.Pago).ToString())
                    {
                        row[column] = Categoria.Pago.ToString();

                    }

                    if (column.ToString() == "Category" && row[column].ToString() == ((char)Categoria.Factura).ToString())
                    {
                        row[column] = Categoria.Factura.ToString();

                    }

                    if (column.ToString() == "BaseType" && row[column].ToString() == ((char)TipoBase.IVA).ToString())
                    {
                        row[column] = TipoBase.IVA.ToString();

                    }

                    if (column.ToString() == "BaseType" && row[column].ToString() == ((char)TipoBase.Neto).ToString())
                    {
                        row[column] = TipoBase.Neto.ToString();

                    }

                    if (column.ToString() == "Inactive" && row[column].ToString() == ((char)EstadosActivo.Activo).ToString())
                    {
                        row[column] = false;

                    }

                    if (column.ToString() == "Inactive" && row[column].ToString() == ((char)EstadosActivo.Inactivo).ToString())
                    {
                        row[column] = true;

                    }
                }

            }

            return newTable;
        }

        public char GetCategoria(string categoria)
        {
            char caracter = 'N';

            if (categoria == Categoria.Pago.ToString())
            {
                caracter = (char)Categoria.Pago;

            }
            else

            if (categoria == Categoria.Factura.ToString())
            {
                caracter = (char)Categoria.Factura;

            }


            return caracter;
        }

        public string GetCategoria(char caracter)
        {
            string categoria = null;

            if (caracter == (char)Categoria.Pago)
            {
               categoria = Categoria.Pago.ToString();

            }
            else

            if (caracter == (char)Categoria.Factura)
            {
                categoria = Categoria.Factura.ToString();

            }


            return categoria;
        }

        public char GetBaseType(string basetype)
        {
            char caracter = 'N';

            if (basetype == TipoBase.IVA.ToString())
            {
                caracter = (char)TipoBase.IVA;

            }
            else

            if (basetype == TipoBase.Neto.ToString())
            {
                caracter = (char)TipoBase.Neto;

            }

            return caracter;
        }

        public string GetBaseType(char basetype)
        {
            string stringBaseType = null;

            if (basetype == (char)TipoBase.IVA)
            {
                stringBaseType = TipoBase.IVA.ToString();

            }
            else

            if (basetype == (char)TipoBase.Neto)
            {
                stringBaseType = TipoBase.Neto.ToString();

            }

            return stringBaseType;
        }

        public char GetInactive(bool estado)
        {
            char caracter = 'N';

            if (estado == true)
            {
                caracter = (char)EstadosActivo.Inactivo;

            }
            else

            if (estado == false)
            {
                caracter = (char)EstadosActivo.Activo;

            }


            return caracter;
        }

        enum Categoria { Pago = 'P', Factura='I' };
        enum TipoBase { Neto = 'N', IVA = 'V'};
        enum EstadosActivo { Inactivo = 'Y', Activo = 'N' };

        public Tuple<int,string> InsertaRetenciones(List<RetencionImpuesto> listaRetenciones)
        {
            return cn.InsertaRetenciones(listaRetenciones);
        }
    }
}
