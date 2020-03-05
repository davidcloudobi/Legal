using System;
using System.Collections.Generic;
using System.Text;

namespace LegalData.Model
{
   public class Appointment
    {
        public Guid Id { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Client { get; set; }

    }
}
