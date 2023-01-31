<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Prueba.Usuarios.WEB2.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

 
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.2/font/bootstrap-icons.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" />

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="form-control card card-body">
             
                <div class="input-group">
                    <asp:Label ID="Label7" CssClass="form-control" runat="server" Text="ID:"></asp:Label>
                    <asp:TextBox ID="tbIdUsuario" CssClass="form-control" runat="server" ></asp:TextBox>
                </div>
                <br />
                <div class="input-group">
                    <asp:Label ID="Label1" CssClass="form-control" runat="server" Text="Nombres:"></asp:Label>
                    <asp:TextBox ID="tbNombres" CssClass="form-control" runat="server" ></asp:TextBox>
                </div>
                <br />
                <div class="input-group">
                    <asp:Label ID="Label3" CssClass="form-control" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                    <asp:TextBox ID="tbFecha" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                 <br />
                <div class="input-group">
                     <asp:Label ID="Label2" CssClass="form-control" runat="server" Text="Sexo:"></asp:Label>
                    <asp:DropDownList ID="ddl_sexo"  CssClass="form-control" runat="server"  ></asp:DropDownList>
                  
                      </div>
                <br />

                 </div>
            


        </div>
    </form>
</body>
</html>
