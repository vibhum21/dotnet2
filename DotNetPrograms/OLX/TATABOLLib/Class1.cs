using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATABOLLib
{
    public class Credential
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public Credential()
        {

        }
        public Credential(int id,string ln,string pwd)
        {
            this.Id = id;
            this.LoginName = ln;
            this.Password = pwd;
        }
        public override string ToString()
        {
            return Id+" "+LoginName + " " + Password;
        }
    }
}
