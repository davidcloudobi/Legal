using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegalData.DIL;
using LegalData.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Legal
{
    public class RegLawyerModel : PageModel
    {
        private readonly ILawyersAct _lawyersAct;
        [BindProperty]
        public Lawyer Lawyer { get; set; }
        public string Status { get; set; }

        public Services Services { get; set; }

        public RegLawyerModel(ILawyersAct lawyersAct)
        {
            _lawyersAct = lawyersAct;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (Lawyer != null)
            {
                var reponse = _lawyersAct.Register(Lawyer);
                if (reponse == true)
                {
                    Status = "Successful";
                }
                else
                {
                    Status = "Failed";
                }
                
            }
            return RedirectToPage("./Index");
        }


    }
}