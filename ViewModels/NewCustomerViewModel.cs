using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Filmovi.Models;

namespace Filmovi.ViewModels
{
    public class NewCustomerViewModel
    {
        public List<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}