using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageCalculatorArray wageCalculator = new EmpWageCalculatorArray();
            wageCalculator.addCompanyEmpWage("TATA", 25, 18, 80);
            wageCalculator.addCompanyEmpWage("Apple", 50, 28, 120);
            wageCalculator.compEmployeeWage();
        }
    }
}