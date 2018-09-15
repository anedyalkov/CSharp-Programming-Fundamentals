namespace _04.Social_Media_Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var likeResult = new Dictionary<string, int>();
            var dislikeResult = new Dictionary<string, int>();

            var postCommentsDict = new Dictionary<string, Dictionary<string, List<string>>>();

            string input;
            while ((input = Console.ReadLine()) != "drop the media")
            {
                var inputElements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var format = inputElements[0];
                var postName = inputElements[1];

                switch (format)
                {
                    case "post":
                        if (!postCommentsDict.ContainsKey(postName))
                        {
                            postCommentsDict[postName] = new Dictionary<string, List<string>>();
                        }
                        if (!likeResult.ContainsKey(postName))
                        {
                            likeResult[postName] = 0;
                        }
                        if (!dislikeResult.ContainsKey(postName))
                        {
                            dislikeResult[postName] = 0;
                        }
                        break;
                    case "like":
                        likeResult[postName] += 1;
                        break;
                    case "dislike":
                        dislikeResult[postName] += 1;
                        break;
                    case "comment":
                        var author = inputElements[2];
                       
                        if (!postCommentsDict[postName].ContainsKey(author))
                        {
                            postCommentsDict[postName][author] = new List<string>();
                        }

                        for (int i = 3; i < inputElements.Length; i++)
                        {
                            postCommentsDict[postName][author].Add(inputElements[i]);
                        }
                        break;
                    default:
                        break;
                }

            }

            foreach (var kvp in postCommentsDict)
            {
                var postName = kvp.Key;
                var authorComments = kvp.Value;

                Console.Write($"Post: {postName} ");
                Console.Write($"| Likes: {likeResult[postName]} ");
                Console.WriteLine($"| Dislikes: {dislikeResult[postName]} ");
                Console.WriteLine($"Comments:");

                if (authorComments.Count == 0)
                {
                    Console.WriteLine($"None");
                }

                foreach (var authorComment in authorComments)
                {                 
                    var author = authorComment.Key;
                    var comment = authorComment.Value;

                    Console.WriteLine($"*  {author}: {string.Join(" ", comment)}");              
                }
            }
        }
    }
}
