using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace LegalData.Model
{
  public  class User:IdentityUser
    {
        public string DisplayName { get; set; }
        public string Location { get; set; }
        public Package Package { get; set; }
        public bool Status { get; set; }
        public DateTime SubStart  { get; set; }
        public DateTime SubEnd { get; set; }
    }
}
