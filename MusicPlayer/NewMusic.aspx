<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewMusic.aspx.cs" Inherits="NewMusic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Music</title>
    <link rel="stylesheet" href="StyleNewMusic.css" />
    <link rel="icon" href="img/music-icon.png" />
</head>
<body>
    <form id="form1" runat="server" class="form-newMusic">
        <div class="container">
            <main class="hero">
                <div class="main-right">

                    <div class="box-name">
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="margin"></asp:TextBox>
                    </div>

                    <div class="box-author">
                    <asp:Label ID="lblAuthor" runat="server" Text="Author"></asp:Label>
                    <asp:TextBox ID="txtAuthor" runat="server" CssClass="margin"></asp:TextBox>
                    </div>

                    <div class="box-album">
                    <asp:Label ID="lblAlbum" runat="server" Text="Album"></asp:Label>
                    <asp:TextBox ID="txtAlbum" runat="server" CssClass="margin"></asp:TextBox>
                    </div>

                    <div class="box-length">
                    <asp:Label ID="lblLength" runat="server" Text="Length"></asp:Label>
                    <asp:TextBox ID="txtLength" runat="server" CssClass="margin"></asp:TextBox>
                    </div>

                 
                </div>

                <div class="main-left">
                    <div class="box-country">
                        <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                        <asp:DropDownList ID="ddlCountry" runat="server" CssClass="margin extra-margin"></asp:DropDownList>
                    </div>

                    <div class="box-dataCreated">
                        <asp:Label ID="lblDateCreated" runat="server" Text="Date Created"></asp:Label>
                        <asp:TextBox ID="txtDateCreated" runat="server" CssClass="margin"></asp:TextBox>
                    </div>


                    <div class="box-favourite">
                        <asp:CheckBox ID="chkFavourite" runat="server" Text="Favourite" />
                    </div>
                    <div class="box-buttons">
                        <asp:Button ID="btnOk" runat="server" Text="OK" class="btn btn-ok" OnClick="btnOk_Click"/>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-cancel" OnClick="btnCancel_Click"/>
                    </div>
                </div>
            </main>
            <footer class="footer">
                <div class="box-error">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                    </div>
            </footer>
        </div>
    </form>
</body>
</html>
