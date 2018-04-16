using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Singleton
{
    public static class EventLog
    {
        private const string filePath = "eventLog.txt";

        private static bool instantlySaveToFile;
        private static List<string> events = null;

        public static void Initialize(bool instantlySaveToFile = true)
        {
            EventLog.instantlySaveToFile = instantlySaveToFile;
            if(File.Exists(filePath))
                events = File.ReadAllLines(filePath).ToList();
            else
                events = new List<string>();
        }

        public static void Save()
        {
            File.WriteAllLines(filePath, events.ToArray());
        }

        public static void AddEvent(string @event)
        {
            events.Add(@event);
            if(instantlySaveToFile)
                Save();
        }
        
    }
}