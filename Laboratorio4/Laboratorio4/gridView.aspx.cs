using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Datos.Entidad;

namespace Laboratorio4
{
    public partial class gridView : System.Web.UI.Page
    {
        Gestion objDatos;
        List<Datos> auxLista;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargaGrid();
            }


        }
        void cargaGrid()
        {
            objDatos = new Gestion();
            auxLista = objDatos.listadoDatos();
            gridDatos.DataSource = auxLista;
            gridDatos.DataBind();
        }

        protected void gridDatos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridDatos, "Select$" + e.Row.RowIndex);
            }

        }

        protected void gridDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow fila in gridDatos.Rows)
            {

                if (fila.RowIndex == gridDatos.SelectedIndex)
                {
                    txtID.Text = fila.Cells[0].Text; 
                    txtnumLinea.Text = fila.Cells[1].Text;
                    txtcodProduct.Text = fila.Cells[2].Text;
                    txtdetProduct.Text = fila.Cells[3].Text;
                    txtcantProduct.Text = fila.Cells[4].Text;
                    txtcostUnitario.Text = fila.Cells[5].Text;
                    txttotalLinea.Text = fila.Cells[6].Text;
                    fila.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                }
                else
                {
                    fila.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }

            }

            cargaGrid();
        }
    }
}