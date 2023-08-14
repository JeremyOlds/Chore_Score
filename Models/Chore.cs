using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chore_Score.Models
{
    public class Chore
    {
        public string Name {get; set;}
        public bool IsDone {get; set;}
        public double WorkTime {get; set;}
        public string Type {get; set;}

        public Chore(string name, bool isDone, double workTime, string type)
        {
            Name = name;
            IsDone = isDone;
            WorkTime = workTime;
            Type = type;
        }

    }
}