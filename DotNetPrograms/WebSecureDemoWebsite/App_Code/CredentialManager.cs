using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CredentialManager
/// </summary>
public class CredentialManager
{
	public CredentialManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static bool validate(string username,string password)
    {
        bool status = false;
        if (username.Equals("Vibhum") && password.Equals("mohan@21"))
            status = true;
        return status;
    }
}