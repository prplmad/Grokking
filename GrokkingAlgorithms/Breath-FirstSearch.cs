using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public static class Breath_FirstSearch
    {

        public static bool Breath_FirstSearching(Dictionary<string, string[]> yourFriends, string name)
        {
            Queue<string> friendsQueue = new();
            List<string> searched = new List<string>();
            foreach (var person in yourFriends[name])
            {
                friendsQueue.Enqueue(person);
            }
            while (true)
            {
                string person = friendsQueue.Dequeue();
                foreach (string item in searched)
                {
                    if (String.Compare(person, item) == 0)
                    {
                        goto End;
                    }
                }
            

                if (PersonIsSeller(person))
                {
                    Console.WriteLine($"{person} is Seller!");
                    return true;
                }
                else
                {
                    searched.Add(person);
                    foreach (var friend in yourFriends[person])
                    {
                        friendsQueue.Enqueue(friend);
                    }
                    if (friendsQueue.Count == 0)
                    {
                        Console.WriteLine("Продавца манго не нашли");
                        return false;
                    }
                    continue;
                }
            End:
                continue;
            }
    
        }

        public static bool PersonIsSeller(string name)
        {
            return name.EndsWith('m');
        }
    }
}
