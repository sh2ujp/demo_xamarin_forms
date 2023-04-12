using app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace app.Services
{
    public interface ITweeterService
    {
        Boolean Authenticate(String username, String password);
        List<Tweet> GetTweets(string str);
    }
}
