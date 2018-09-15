namespace _03.Forum_Topics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var forumTopics = new Dictionary<string, HashSet<string>>();

            string input;
            while ((input = Console.ReadLine()) != "filter")
            {
                var inputElements = input.Split(new char[] { ' ','-','>',','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var topic = inputElements[0];

                for (int i = 1; i < inputElements.Length; i++)
                {
                    if (!forumTopics.ContainsKey(topic))
                    {
                        forumTopics[topic] = new HashSet<string>();
                    }

                    forumTopics[topic].Add(inputElements[i]);
                }
            }

           var tags = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var kvp in forumTopics)
            {
                var topic = kvp.Key;
                var topicTags = kvp.Value;

                var allTagsExist = true;

                foreach (var tag in tags)
                {
                  
                    if (topicTags.Contains(tag))
                    {
                        continue;
                    }
                    else
                    {
                        allTagsExist = false;
                        break;
                        
                    }
                }

                if (allTagsExist==true)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #", topicTags)}");
                }
            }
        }
    }
}
