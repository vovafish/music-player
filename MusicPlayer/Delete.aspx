<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete</title>
    <link rel="stylesheet" href="StyleDelete.css" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500&display=swap" rel="stylesheet" />
    <link rel="icon" href="img/music-icon.png" />
</head>
<body>
    <form id="form1" runat="server" class="form-delete">
        
        
            <section class="hero">
               <!-- <asp:TextBox ID="txtMusicNo" runat="server"></asp:TextBox> -->
                <asp:Label ID="lblDelete" runat="server" Text="Are you sure want to delete this song?"></asp:Label>
                <div class="delete-button">
                    <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="btn btnYes" OnClick="btnYes_Click"/>
                    <asp:Button ID="btnNo" runat="server" Text="No" CssClass="btn btnNo" OnClick="btnNo_Click"/>
                </div>
                <div class="delete-error">
                    <asp:Label ID="lblError" runat="server" CssClass="lblError"></asp:Label>
                </div>
            </section>
            <main class="main-img">
                <img src="img/delete-icon.png" class="img"/>
            </main>
      
        
    </form>
</body>
</html>
