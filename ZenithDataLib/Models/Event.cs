
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Event
    {
        public int EventId { get; set; }
        // [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        public DateTime EventFrom { get; set; }
        public DateTime EventTo { get; set; }
        public string EnteredBy { get; set; }
        public int ActivityId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
