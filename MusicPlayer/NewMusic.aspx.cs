using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewMusic : System.Web.UI.Page
{
    Int32 MusicNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        MusicNo = Convert.ToInt32(Request.QueryString["MusicNo"]);
        if (IsPostBack != true)
        {
            DisplayCountries();
            if (MusicNo != -1)
            {
                DisplayMusic(MusicNo);
            }
        }
    }

    void DisplayMusic(Int32 MusicNo)
    {
        clsMusic MyMusicPlayer = new clsMusic();
        MyMusicPlayer.Find(MusicNo);
        txtName.Text = MyMusicPlayer.Name;
        txtAuthor.Text = MyMusicPlayer.Author;
        txtAlbum.Text = MyMusicPlayer.Album;
        txtLength.Text = MyMusicPlayer.Length;
        txtDateCreated.Text = MyMusicPlayer.DateCreated.ToString("dd/MM/yyyy");
        ddlCountry.SelectedValue = Convert.ToString(MyMusicPlayer.Country);
        ddlCountry.SelectedValue = Convert.ToString(MyMusicPlayer.Country);
        chkFavourite.Checked = MyMusicPlayer.Favourite;
        

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        string ErrorMsg;
        
        clsMusic ThisMusic = new clsMusic();

        ErrorMsg = ThisMusic.MusicValid(
            txtName.Text,
            txtAuthor.Text,
            txtAlbum.Text,
            txtLength.Text, // mb delete this one
            txtDateCreated.Text);

        if (ErrorMsg == "")
        {
            clsMusicCollection MusicPlayer = new clsMusicCollection();

            if (MusicNo == -1)
            {

                MusicPlayer.ThisMusic.Name = txtName.Text;
                MusicPlayer.ThisMusic.Author = txtAuthor.Text;
                MusicPlayer.ThisMusic.Album = txtAlbum.Text;
                MusicPlayer.ThisMusic.Length = txtLength.Text;
                MusicPlayer.ThisMusic.Country = Convert.ToString(ddlCountry.SelectedValue);
                MusicPlayer.ThisMusic.DateCreated = Convert.ToDateTime(txtDateCreated.Text);
                MusicPlayer.Add();
            }
            else
            {
                MusicPlayer.ThisMusic.MusicNo = Convert.ToInt32(MusicNo);
                MusicPlayer.ThisMusic.Name = txtName.Text;
                MusicPlayer.ThisMusic.Author = txtAuthor.Text;
                MusicPlayer.ThisMusic.Album = txtAlbum.Text;
                MusicPlayer.ThisMusic.Length = txtLength.Text;
                MusicPlayer.ThisMusic.Country = Convert.ToString(ddlCountry.SelectedValue);
                MusicPlayer.ThisMusic.DateCreated = Convert.ToDateTime(txtDateCreated.Text);
                MusicPlayer.Update();
            }
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = ErrorMsg;
        }
    }

    Int32 DisplayCountries()
    {
        clsCoutryCollection Countries = new clsCoutryCollection();
        string CountryNo;
        string Country;
        Int32 Index = 0;
        while (Index < Countries.Count)
        {
            CountryNo = Convert.ToString(Countries.AllCountries[Index].CountryNo);
            Country = Countries.AllCountries[Index].Country;
            ListItem NewCountry = new ListItem(Country, CountryNo);
            ddlCountry.Items.Add(NewCountry);
            Index++;
        }
        return Countries.Count; 
    }
}