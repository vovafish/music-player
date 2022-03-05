using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsMusic
/// </summary>
public class clsMusic
{
    public clsMusic()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    
    private Int32 mMusicNo;
    public Int32 MusicNo
    {
        get
        {
            //sends date out of the property
            return mMusicNo;
        }
        set
        {
            //allows data into the property
            mMusicNo = value;
        }
    }

    private string mName;
    public string Name
    {
        get
        {
            //sends date out of the property
            return mName;
        }
        set
        {
            //allows data into the property
            mName = value;
        }
    }

    private string mAuthor;
    public string Author
    {
        get
        {
            //sends date out of the property
            return mAuthor;
        }
        set
        {
            //allows data into the property
            mAuthor = value;
        }
    }

    private string mAlbum;
    public string Album
    {
        get
        {
            //sends date out of the property
            return mAlbum;
        }
        set
        {
            //allows data into the property
            mAlbum = value;
        }
    }


    private string mLength;
    public string Length
    {
        get
        {
            //sends date out of the property
            return mLength;
        }
        set
        {
            //allows data into the property
            mLength = value;
        }
    }

    private DateTime mDateCreated;
    public DateTime DateCreated
    {
        get
        {
            //sends date out of the property
            return mDateCreated;
        }
        set
        {
            //allows data into the property
            mDateCreated = value;
        }
    }

    private Boolean mFavourite;
    public Boolean Favourite
    {
        get
        {
            //sends date out of the property
            return mFavourite;
        }
        set
        {
            //allows data into the property
            mFavourite = value;
        }
    }

    public string mCountry;

    public string Country
    {
        get
        {
            return mCountry;
        }
        set
        {
            mCountry = value;
        }
    }

    public string MusicValid(
        string Name,
        string Author,
        string Album,
        string Length,
        string DateCreated)
    //this is used to validate the data in a new address
    //it accepts six parameters and returns a string containing the text of the errors (if any)
    //otherwise of no errors it returns a blank string
    {
        string ErrorMsg;
        ErrorMsg = ""; //initialise the var with the blank string  
        //check the min length of the house no
        if (Name.Length == 0)
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Name no is blank. ";
        }
        //check the max length of the house no
        if (Name.Length > 50)
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Name no must be less than 50 characters. ";
        }
        //check the min length of the street
        if (Author.Length == 0)
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Author is blank. ";
        }
        //check the max length of the street
        if (Author.Length > 50)
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Author must be less than 50 characters. ";
        }
        //check the min length for the town
        if (Album.Length == 0)
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Album is blank. ";
        }
        //check the max length for the town
        if (Album.Length > 50)
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Album must be less than 50 characters. ";
        }
        //check the min length for the post code
        if (Length.Length == 0)
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Length is blank. ";
        }

        
        
        if (Length.Length > 8)
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Length must be less than 8 characters. ";
        }
        

        //test if the date is valid
        try//try the operation
        {
            //var to store the date
            DateTime Temp;
            //assign the date to the temporary var
            Temp = Convert.ToDateTime(DateCreated);
        }
        catch//if it failed report an error
        {
            //set the error messsage
            ErrorMsg = ErrorMsg + "Date added is not valid. ";
        }
        //if there were no errors
        if (ErrorMsg == "")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "There were the following errors : " + ErrorMsg;
        }

    }

    public Boolean Find(Int32 MusicNo)
    {
        clsDataConnection dBConnection = new clsDataConnection();
        dBConnection.AddParameter("@MusicNo", MusicNo);
        dBConnection.Execute("sproc_tblMusic_FilfterByMusicNo");
        if (dBConnection.Count == 1)
        {
            mMusicNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["MusicNo"]);
            mName = Convert.ToString(dBConnection.DataTable.Rows[0]["Name"]);
            mAuthor = Convert.ToString(dBConnection.DataTable.Rows[0]["Author"]);
            mAlbum = Convert.ToString(dBConnection.DataTable.Rows[0]["Album"]);
            mLength = Convert.ToString(dBConnection.DataTable.Rows[0]["Length"]);
            mDateCreated = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DateCreated"]);

            try
            {
                mFavourite = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["mFavourite"]);
            }
            catch
            {
                mFavourite = true;
            }

            return true;
        }
        else
        {
            return false;
        }
    }

}