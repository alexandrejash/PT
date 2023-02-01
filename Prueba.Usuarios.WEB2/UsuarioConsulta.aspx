<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioConsulta.aspx.cs" Inherits="Prueba.Usuarios.WEB2.UsuarioConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.2/font/bootstrap-icons.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" />

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    
    <form id="form1" runat="server">
        <div>








        </div>




        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="consultar" />

       
                <asp:GridView ID="gv" BorderStyle="None" runat="server" class="table center mx-auto table-striped table-hover"  >
                    <Columns>
                     
                        <asp:TemplateField HeaderText="Modificar">
                            <ItemTemplate>
                                <div class="btn-group">
                                  
                                   
                                    <asp:LinkButton runat="server" ID="BtnUpdate" class="btn btn-outline-secondary "><span class=" bi bi-pencil-square"  style="color: yellowgreen;" title="Editar"></span> </asp:LinkButton>
                                    <asp:LinkButton runat="server" type="button" ID="BtnDelete" title="Eliminar" class="btn btn-outline-secondary">
                                         <span class=" bi bi-trash3"  style="color: red;"></span> 
                                    </asp:LinkButton>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
    
    </form>
</body>
</html>
