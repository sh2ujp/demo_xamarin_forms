using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using app.Droid.Services;
using app.Models;
using app.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(TwitterService))]
namespace app.Droid.Services
{
    internal class TwitterService : ITweeterService
    {
        public void OnInit()
        {

        }

        public bool Authenticate(string username, string password)
        {
            return username.Equals("name") && password.Equals("password");
        }

        public List<Tweet> GetTweets(string str)
        {
            var tweetsList = new List<Tweet>();

            tweetsList.Add(new Tweet
            {
                Id = "1",
                CreationDateTime = "2/04/2023",
                UserId = "3",
                UserName = "Perceval",
                UserPseudo = "Philosophe et Diplômate",
                Text = "Aujourd'hui il fait beau, mais encore frais, mais beau !"
            });

            tweetsList.Add(new Tweet
            {
                Id = "2",
                CreationDateTime = "7/04/2023",
                UserId = "7",
                UserName = "Mathieux",
                UserPseudo = "Ma-ti-yeux",
                Text = "J'aime bien quand il fait beau"
            });

            tweetsList.Add(new Tweet
            {
                Id = "3",
                CreationDateTime = "10/04/2023",
                UserId = "1",
                UserName = "Roah Bourrgond'",
                UserPseudo = "Sâlssi'Fi!",
                Text = "Arthour, pas changer assiette pour fromage"
            });

            tweetsList.Add(new Tweet
            {
                Id = "4",
                CreationDateTime = "11/04/2023",
                UserId = "3",
                UserName = "Perceval",
                UserPseudo = "Philosophe et Diplômate",
                Text = "L’humilité, c’est pas quand il y a des infiltrations ?"
            });

            tweetsList.Add(new Tweet
            {
                Id = "5",
                CreationDateTime = "12/04/2023",
                UserId = "10",
                UserName = "Merlin l'Enchanteur",
                UserPseudo = "JE SUIS DRUIIIDE!!!",
                Text = "Qu’est-ce-qui est petit et marron ?"
            });

            return tweetsList;
        }
    }
}