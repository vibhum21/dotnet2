using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CredentialContext
/// </summary>
public class CredentialContext
{
	public CredentialContext()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool Authenticate(string userName, string password)
    {
        bool status = false;
        if (userName == "sachin" && password == "pass@word1")
        {
            status = true;
        }
        return status;

    }
}