using LoanCalculator.Core.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanCalculator.Core.Domain
{
    public class EmploymentLengthApprovalRule : ILoanQualificationRule
    {
        public const String RULE_NAME = "Length of Employment";

        public string RuleName { get => RULE_NAME; }

        public bool CheckLoanApprovalRule(LoanApplication application)
        {
            if (application.YearsEmployed <= 2)
            {
                return false;
            }
            return true;
        }
    }
}