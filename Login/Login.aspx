<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="resources/CSS/styles.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="formulario_login" runat="server">
                <div class="form-control">
                    <div class="row">
                        <asp:label class="h2" ID="lblBienvenida" runat="server" Text="Please Sign in"></asp:label>
                    </div>
                    <div>
                        <asp:Label ID="lblUser" runat="server" Text="User Name"></asp:Label>
                        <asp:TextBox ID="tbUser" cssClass="form-control" runat="server" placeholder="User Name"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="tbPassword" cssClass="form-control" TextMode="password" runat="server" placeholder="Password"></asp:TextBox>
                    </div>
                    <hr />
                    <div class="row">
                        <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button ID="btnLogin" CssClass="btn btn-primary btn-dark" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
  
    
    
</body>
</html>
