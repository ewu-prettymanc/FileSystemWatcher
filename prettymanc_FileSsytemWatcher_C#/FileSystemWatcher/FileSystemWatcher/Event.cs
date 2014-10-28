using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileSystemWatcher
{
    // A class that stores event data
    class Event
    {
        public string Extension{get; set; }
        public string Name{get;set;}
        public string Path{get;set;}
        public string OldName{get;set;}
        public string OldPath{get;set;}
        public string EventType{get;set;}
        public DateTime Time { get; set; }

        public Event()
        {
            Extension = "";
            Name = "";
            Path = "";
            OldName = "";
            OldPath = "";
            EventType = "";
        }
    }
}
