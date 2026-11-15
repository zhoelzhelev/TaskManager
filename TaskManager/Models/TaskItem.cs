using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public string Name { get; set; } = null!;
        public string Acctivity { get; set; } = null!;
        public string Time { get; set; } = null!;
        public string ImageURL { get; set; } = null!;
    }
}
