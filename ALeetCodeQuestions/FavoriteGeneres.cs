using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALQ
{
    class FavoriteGeneres
    {
        public void FavGenere(Dictionary<string,List<string>> userSongs, Dictionary<string,List<string>> songGenres)
        {
            Dictionary<string, string> songToGenre = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> userToGenre = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            //create a dictionary where key is song and value is genre
            foreach(var songGenere in songGenres)
            {
               foreach(var song in songGenere.Value)
                {
                    if(!songToGenre.ContainsKey(song))
                    {
                        songToGenre.Add(song, songGenere.Key);
                    }
                }
            }
            //create a dictionary where key is user name and value is a dictionary with key as genre and value as count of that genre for the user
            foreach(var user in userSongs)
            {
               foreach(var song in user.Value)
                {
                    if(!userToGenre.ContainsKey(user.Key))
                    {
                        Dictionary<string, int> temp = new Dictionary<string, int>();
                        temp.Add(songToGenre[song], 1);
                        userToGenre.Add(user.Key, temp);
                    }
                    else
                    {
                        if(userToGenre[user.Key].ContainsKey(songToGenre[song]))
                        {
                            userToGenre[user.Key][songToGenre[song]]++;
                        }
                        else
                        {
                            Dictionary<string, int> temp = new Dictionary<string, int>();
                            temp.Add(songToGenre[song], 1);
                            userToGenre[user.Key].Add(songToGenre[song], 1);
                        }
                    }
                }
               
            }
            //read the dictionary created above and get the top genres for each user
            for(int i=0;i<userToGenre.Count;i++)
            {
                var dict  = userToGenre.ElementAt(i).Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                var topElement = dict.ElementAt(0).Value;
                result.Add(userToGenre.ElementAt(i).Key, new List<string>());
                for(int j=0;j<dict.Count;j++)
                {
                    if(dict.ElementAt(j).Value==topElement)
                    {
                        result[userToGenre.ElementAt(i).Key].Add(dict.ElementAt(j).Key);
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
