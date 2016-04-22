using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavBarDemo
{
    public class NavNodeData
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        //public bool IsRoot { get; set; }
        public bool IsExpansed { get; set; }
        public string Title { get; set; }
        public List<NavNodeData> Children { get; set; }
    }
}
