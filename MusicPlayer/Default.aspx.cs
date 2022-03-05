using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayMusics("");
        }
    }

    

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 MusicNo;
        if (lstMusic.SelectedIndex != -1)
        {
            MusicNo = Convert.ToInt32(lstMusic.SelectedValue);
            Response.Redirect("Delete.aspx?MusicNo=" + MusicNo);

        }
        else
        {
            lblError.Text = "You must select in item off the list to delete it";

        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewMusic.aspx?MusicNo=-1");
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all musics
        DisplayMusics("");
    }

    Int32 DisplayMusics(string NameFilter)
    {
        Int32 MusicNo;
        string Name;
        string Author;
        //create an instance of the music collection class
        clsMusicCollection MusicPlayer = new clsMusicCollection();
        MusicPlayer.FilterByMusicName(NameFilter);

        Int32 RecordCount; //var to store count of records
        Int32 Index = 0; //var to store index for loop
        RecordCount = MusicPlayer.Count; //get the count of records from the tblMusic table
        lstMusic.Items.Clear();
        while (Index < RecordCount) //while there are records to process
        {
            MusicNo = MusicPlayer.MusicList[Index].MusicNo; //get the PK
            Name = MusicPlayer.MusicList[Index].Name; //get the Name
            Author = MusicPlayer.MusicList[Index].Author; //get the Author

            //create the new entry for the list box
            ListItem NewEntry = new ListItem(Author + " - " + Name, MusicNo.ToString());
            lstMusic.Items.Add(NewEntry); //add music to the list
            Index++; //move the index to the next record
        }
        return RecordCount; //return the count of records found
    }

    public void GetRandomMusicRecords()
    {
        clsMusicCollection MusicPlayer = new clsMusicCollection();
        //MusicPlayer
        

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 MusicNo;
        if (lstMusic.SelectedIndex != -1)
        {
            MusicNo = Convert.ToInt32(lstMusic.SelectedValue);
            Response.Redirect("NewMusic.aspx?MusicNo=" + MusicNo);

        }
        else
        {
            lblError.Text = "You must select in item off the list to edit it";

        }
        
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        DisplayMusics(txtName.Text);
    }
}