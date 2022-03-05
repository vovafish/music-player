<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MusicPlayer</title>
    <link rel="stylesheet" href="StyleDefault.css" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500&display=swap" rel="stylesheet" />
    <link rel="icon" href="img/music-icon.png" />
   
</head>
<body>
    <form id="form1" runat="server" class="form-default">
        

        <!-- <asp:Label ID="lblMusicName" runat="server" Text="Please Enter a Music Name"></asp:Label> -->
       
        <div class="container restriction">
        <section class="music-search">
            <div>
                <asp:TextBox ID="txtName" runat="server" placeholder="Search Music" CssClass="holder"></asp:TextBox>
                <div class="music-search--btn">
                    <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnApply_Click" CssClass="btn" />
                    <asp:Button ID="btnDisplayAll" runat="server" Text="Dispaly All" CssClass="btn" OnClick="btnDisplayAll_Click"/>
                </div>
            </div>
            <div>
                <img src="img/logo.png" alt="logo" class="logo"/>
            </div>
            <!-- music-search--btn -->
        </section>
        <!-- music-search -->
       </div>

        <div class="container">
        <section class="music-content">
            <div class="music-content--output">
                <asp:ListBox ID="lstMusic" runat="server" CssClass="list"></asp:ListBox>
                <asp:Label ID="lblError" runat="server" Text="" CssClass="error"></asp:Label>
            </div>

            <div class="btn-functionality">
                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btnAdd" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btnEdit" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btnDelete" OnClick="btnDelete_Click" />
            </div>
        </section>
       </div>
        
        <footer class="music-copyright">

            <p class="copyright">&copy; Made By Vladimirs Ribakovs 2020/2021</p>
 
        </footer>
    </form>
</body> 
</html>
