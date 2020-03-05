using System;
using System.Collections.Generic;
using System.Text;

namespace LegalData.Model
{
 public class Lawyer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public Services Service { get; set; }
        public Package  Package { get; set; }
        public bool Status { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
