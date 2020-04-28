using System;
using System.Collections.Generic;

namespace GanttEF.Models
{
    public partial class GanttData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
        public string Progress { get; set; }
        public int? ParentId { get; set; }
    }
}
