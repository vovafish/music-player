using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCountry
/// </summary>
public class clsCountry
{
    
    public clsCountry()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private Int32 mCountryNo;

    public Int32 CountryNo
    {
        get
        {
            return mCountryNo;
        }
        set
        {
            mCountryNo = value;
        }
    }
    private string mCountry;

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
}