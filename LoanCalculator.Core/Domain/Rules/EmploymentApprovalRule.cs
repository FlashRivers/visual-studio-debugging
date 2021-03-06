﻿using LoanCalculator.Core.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanCalculator.Core.Domain
{
    public class IncomeApprovalRule : ILoanQualificationRule
    {
        public const String RULE_NAME = "Stated Income";

        public string RuleName { get => RULE_NAME; }

        public bool CheckLoanApprovalRule(LoanApplication application)
        {
            if (application.AnnualIncome <= application.LoanAmount)
            {
                return (application.AnnualIncome >= application.LoanAmount / 2);
            }

            return true;
        }


    }
}
