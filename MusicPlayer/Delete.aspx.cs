using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    Int32 MusicNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        MusicNo = Convert.ToInt32(Request.QueryString["MusicNo"]);
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the class clsMusicNo called MyMusicNo
        clsMusicCollection MyMusicPlayer = new clsMusicCollection();
        //Int32 MusicNo;
        Boolean Found;
        //copy the data from the interface to the RAM converting the data to Int32
        //MusicNo = Convert.ToInt32(txtMusicNo.Text);
        //invoke the delete method of the object passing in the data enterted by the user and recording the outcome
        Found = MyMusicPlayer.ThisMusic.Find(MusicNo);
        //use the assignment operator to copy the data ROM the interface to the RAM converting the datatype into an Int
        if (Found)
        {
            MyMusicPlayer.Delete();
        }
        Response.Redirect("Default.aspx");
    }
}