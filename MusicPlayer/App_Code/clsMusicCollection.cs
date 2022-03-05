using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsMusicCollection
/// </summary>
public class clsMusicCollection
{
    clsDataConnection dBConnection = new clsDataConnection();
    clsMusic mThisMusic = new clsMusic();
    public clsMusicCollection()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Boolean Delete()
    {
        try
        {
            //create an instance of the data connection calss called MyDatabase
            clsDataConnection MyDatabase = new clsDataConnection();
            //add the MusicNo parameter passed to this funcion to the list of parameter to use in the database
            MyDatabase.AddParameter("@MusicNo", mThisMusic.MusicNo);
            //execute to stored procedure in the database
            MyDatabase.Execute("sproc_tblMusic_Delete");
            //set the return value for the function
            return true;
        }
        catch //do this only if the code above failed for some reason
        {
            //report back that there was an error
            return false;
        }
    }

    public List<clsMusic> MusicList
    {
        get
        {
            //create an array list of type clsMusic
            List<clsMusic> mMusicList = new List<clsMusic>();
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
                //create a connection to the database
                //dBConnection = new clsDataConnection();
                //send a post code filter to the query
                //dBConnection.AddParameter("@Name", "");
                //execute the query
            //dBConnection.Execute("sproc_tblMusic_FilterByMusicName");
            //get he count of records
            RecordCount = dBConnection.Count;
            //keep looping till all records are proccessed
            while (Index < RecordCount)
            {
                //create a blank music page
                clsMusic NewMusic = new clsMusic();
                //copy the data from the table to the RAM
                NewMusic.MusicNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["MusicNo"]);
                NewMusic.Name = Convert.ToString(dBConnection.DataTable.Rows[Index]["Name"]);
                NewMusic.Author = Convert.ToString(dBConnection.DataTable.Rows[Index]["Author"]);
                NewMusic.Album = Convert.ToString(dBConnection.DataTable.Rows[Index]["Album"]);
                NewMusic.Length = Convert.ToString(dBConnection.DataTable.Rows[Index]["Length"]);
                NewMusic.DateCreated = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["DateCreated"]);
                NewMusic.Favourite = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["Favourite"]);
                //add the blank page to the array list 
                mMusicList.Add(NewMusic);
                Index++;
            }
            return mMusicList;
        }
    }

    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {   /*
            //create a connection to the data base
            clsDataConnection dBConnection = new clsDataConnection();
            //send a post code filter to the query
            dBConnection.AddParameter("@Name", "");
            //execute the query
            dBConnection.Execute("sproc_tblMusic_FilterByMusicName");
            */
            //return the count of records
            return dBConnection.Count;
        }
    }

    public Int32 Add()
    {
        clsDataConnection NewDBMusic = new clsDataConnection();
        NewDBMusic.AddParameter("@Name", mThisMusic.Name);
        NewDBMusic.AddParameter("@Author", mThisMusic.Author);
        NewDBMusic.AddParameter("@Album", mThisMusic.Album);
        NewDBMusic.AddParameter("@Length", mThisMusic.Length);
        NewDBMusic.AddParameter("@DateCreated", mThisMusic.DateCreated);
        NewDBMusic.AddParameter("@Favourite", mThisMusic.Favourite);

        return NewDBMusic.Execute("sproc_tblMusic_Insert");
    }

    public void Update()
    {
        clsDataConnection ExistingDBMusic = new clsDataConnection();
        ExistingDBMusic.AddParameter("@MusicNo", mThisMusic.MusicNo);
        ExistingDBMusic.AddParameter("@Name", mThisMusic.Name);
        ExistingDBMusic.AddParameter("@Author", mThisMusic.Author);
        ExistingDBMusic.AddParameter("@Album", mThisMusic.Album);
        ExistingDBMusic.AddParameter("@Length", mThisMusic.Length);
        ExistingDBMusic.AddParameter("@DateCreated", mThisMusic.DateCreated);
        ExistingDBMusic.AddParameter("@Favourite", mThisMusic.Favourite);

        ExistingDBMusic.Execute("sproc_tblMusic_Update");
    }

    public void FilterByMusicName(string Name)
    {
        dBConnection = new clsDataConnection();
        dBConnection.AddParameter("@Name", Name);
        dBConnection.Execute("sproc_tblMusic_FilterByMusicName");
    }

    public clsMusic ThisMusic
    {
        get
        {
            return mThisMusic;
        }
        set
        {
            mThisMusic = value;
        }
    }
}