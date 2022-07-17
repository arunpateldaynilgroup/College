using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _22___Mvc_Data_Entry.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Please Enter ID")] 
        public int CustID { get; set; }
        [Required(ErrorMessage = "Please Enter Name")] 
        public string CustName { get; set; }
        [Required(ErrorMessage = "Please Enter Address")] 
        public string CustAdd { get; set; }
    }
}