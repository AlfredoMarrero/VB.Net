using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarLoanWeb.Models
{
    public class CarLoanModel
    {
        public Double loanAmount { get; set; }
        public int months { get; set; }
        public Double interestRate {get; set;}
        public Double totalInterestPaid { get; set; }
        public Double monthlyPayment { get; set; }
        public int durationInMonth { get; set; }

    }
}