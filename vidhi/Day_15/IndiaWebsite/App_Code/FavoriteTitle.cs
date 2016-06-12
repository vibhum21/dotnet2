using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FavoriteTitle
/// </summary>
public class FavoriteTitle
{
    private ArrayList list;

    public FavoriteTitle()
    {
        list = new ArrayList();
    }
    public void AddTitle(string ID)
    {
        list.Add(ID);
    }
    public void RemoveTitle(string ID)
    {
        list.Remove(ID);
    }
    public bool IsInFavoritesList(string ID)
    {
        bool status = false;
        foreach (string s in list)
        {
            if (s == ID)
            {
                status = true;
                return status;
            }
        }
        return status;
    }


    public ArrayList GetFavorites()
    {
        //Queries the MyComics database and
        //returns a DataSet containing information 
        //about all the comics whose IDs appear 
        //in the array
        return list;
    }
}