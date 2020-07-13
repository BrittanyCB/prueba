<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gridView.aspx.cs" EnableEventValidation="false" Inherits="Laboratorio4.gridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridDatos" runat="server" 
                AutoGenerateColumns="false"  
                DataKeyNames="IdFactura" 
                BackColor="White" 
                BorderColor="#999999" 
                BorderStyle="None" 
                BorderWidth="1px" 
                CellPadding="3" 
                GridLines="Vertical" 
                OnRowDataBound="gridDatos_RowDataBound" OnSelectedIndexChanged="gridDatos_SelectedIndexChanged"              
                >
                <Columns>
                    <asp:BoundField DataField="IdFactura" HeaderText="ID Factura" />
                    <asp:BoundField DataField="numLinea" HeaderText="Numero Linea" />
                    <asp:BoundField DataField="codProduct" HeaderText="Codigo Producto" />
                    <asp:BoundField DataField="detProduct" HeaderText="Detalle Producto" />
                    <asp:BoundField DataField="cantProduct" HeaderText="Cantidad" />
                    <asp:BoundField DataField="costUnitario" HeaderText="Costo Unitario" />
                    <asp:BoundField DataField="totalLinea" HeaderText="Total" />
                </Columns>
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <br />
               <table>
                <tr>
                    <td>ID Factura</td>
                    <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Numero Linea</td>
                    <td><asp:TextBox ID="txtnumLinea" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Codigo Producto</td>
                    <td><asp:TextBox ID="txtcodProduct" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Detalle Producto</td>
                    <td><asp:TextBox ID="txtdetProduct" runat="server"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>Cantidad</td>
                    <td><asp:TextBox ID="txtcantProduct" runat="server"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>Costo Unitario</td>
                    <td><asp:TextBox ID="txtcostUnitario" runat="server"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>Total</td>
                    <td><asp:TextBox ID="txttotalLinea" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
