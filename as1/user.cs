using as1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as1
{
    public class user
    {
        string username;
        string password;
        int user_id;
        enum user_type { staff , customer}
        public user (string username, string password)
        {
            this.username = username;
            this.password = password;
        }


        public bool create_user(string username, string password)
        {
            if(username != null && password != null)
            {
                return false;
            }

            return false;
        }
        
        public bool delete_user(string user_id)
        { return false; }
    }
}
