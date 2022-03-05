using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCoutryCollection
/// </summary>
public class clsCoutryCollection
{
    clsDataConnection Countries = new clsDataConnection();
    public clsCoutryCollection()
    {

        Countries.Execute("sproc_tblCountry_SelectAll");
    }

    public Int32 Count
    {
        get
        {
            return Countries.Count;
        }
    }

    public List<clsCountry> AllCountries
    {
        get
        {
            List<clsCountry> mAllCountries = new List<clsCountry>();
            Int32 Index = 0;
            while (Index < Countries.Count)
            {
                clsCountry NewCountry = new clsCountry();
                NewCountry.CountryNo = Convert.ToInt32(Countries.DataTable.Rows[Index]["CountryNo"]);
                NewCountry.Country = Convert.ToString(Countries.DataTable.Rows[Index]["Country"]);
                mAllCountries.Add(NewCountry);
                Index++;
            }
            return mAllCountries;
        }
    }
}