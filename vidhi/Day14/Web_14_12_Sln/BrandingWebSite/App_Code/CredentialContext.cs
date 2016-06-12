using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

 
public class CredentialContext
{
	public CredentialContext()
	{
		 
	}


    public bool Authenticate(string userName, string password)
    {
        bool status = false;
        if(userName=="sachin" && password=="pass@word1")
        {
            status=true;
        }
        return status;

    }

    public bool ChangePassword(string userName, string oldpassword, string newpassword)
    {
        /////// accessing DAL

        return true;

    }

    public bool IsUserExist(string userName)
    {
        return true;

    }
    public List<User> GetAllMemebers()
    {
        //get data from all credentials

        return new List<User>();

    }

}