using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareApp.Models
{
    public class ATask
    {
        public string Name { get; set; }
        public int Id { get; set; }
       
        public ATask()
        {
        }

        public ATask(string name) 
        {
            Name = name;
        }
    }
}
