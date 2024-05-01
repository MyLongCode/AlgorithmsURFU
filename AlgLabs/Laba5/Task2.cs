using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AlgLabs.Laba5
{
    public class Task2
    {

        public static bool CheckKey(string key)
        {
            string path = "test.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] text = reader.ReadToEnd().Split('\n');
                text = text.Select(t => t.Replace('\n', ' ')).ToArray();
                foreach(var item in text)
                {
                    if (item.Split()[0] == key) return true;
                }
                
            }
            return false;
        }

        public static void AddKey(string key, string value)
        {
            string path = "test.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLineAsync($"{key} {value}");
            }
        }

        public static void DeleteKey(string key)
        {
            string path = "test.txt";
            string[] text;
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd().Split('\n');
                for(var i = 0; i < text.Length; i++)
                {
                    if (text[i].Contains(key))
                        text[i] = text[i].Replace(text[i], "");
                }
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach(var item in text)
                    writer.WriteLineAsync(item);
            }
        }

        public static void UpdateKey(string key, string value)
        {
            string path = "test.txt";
            string[] text;
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd().Split('\n');
                for (var i = 0; i < text.Length; i++)
                {
                    if (text[i].Contains(key))
                        text[i] = text[i].Replace(text[i], $"{key} {value}");
                }
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (var item in text)
                    writer.WriteLineAsync(item);
            }
        }

        public static string PrintKey(string key)
        {
            string path = "test.txt";
            string[] text;
            string answer = "ERROR";
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd().Split('\n');
                for (var i = 0; i < text.Length; i++)
                {
                    if (text[i].Contains(key))
                        answer = text[i];
                }
            }
            return answer;
        }

        public static void Solution()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int length = int.Parse(Console.ReadLine());
            string path = "test.txt";
            for(int i = 0; i < length; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "ADD")
                {
                    string key = input[1];
                    string value = input[2];
                    if (!CheckKey(key)) AddKey(key, value);
                    else Console.WriteLine("ERROR");
                }
                if (input[0] == "DELETE")
                {
                    if (!CheckKey(input[1])) DeleteKey(input[1]);
                    else Console.WriteLine("ERROR");
                }
                if(input[0] == "UPDATE")
                {
                    string key = input[1];
                    string value = input[2];
                    if (!CheckKey(key)) UpdateKey(key, value);
                    else Console.WriteLine("ERROR");
                }
                if (input[0] == "PRINT")
                {
                    Console.WriteLine(PrintKey(input[1]));
                }
            }

        }
    }
}
