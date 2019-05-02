using System;
using System.Collections.Generic;


namespace Testing
{
    class Program
    {
        public static void Main(string[] args)
        { }

        public static List<string> Tasks = new List<string> { "take a shower", "do laundry", "feed the cats", "buy groceries", "call your brother" };

        public static void AddTask(string t)
        {
            Tasks.Add(t);
        }
        public static bool FinishTask(string f)
        {
            if (Tasks.Contains(f))
            {
                Tasks.Remove(f);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GetTask(int i)
        {
            try
            {
                return Tasks[i];
            }
            catch (IndexOutOfRangeException)
            {
                return "error";
            }
        }
    }
}
    

