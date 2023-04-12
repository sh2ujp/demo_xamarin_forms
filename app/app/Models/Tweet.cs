using System;
using System.Collections.Generic;
using System.Text;

namespace app.Models
{
    public class Tweet
    {
        public string Id { get; set; }
        public string Text{ get; set; }
        public string CreationDateTime{ get; set; }
        public string UserId{ get; set; }
        public string UserName{ get; set; }
        public string UserPseudo{ get; set; }
    }
}
