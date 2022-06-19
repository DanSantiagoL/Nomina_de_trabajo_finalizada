using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina_de_trabajo_finalizada
{
    internal class Data
    {
        private double Document1;
        private string FirstName1;
        private string LastName1;
        private double Salary1;
        private double WorkedDays1;
        private double TotalIncome1;
        private double Accrual1;
        private double Health1;
        private double Pension1;
        private double SubTransportation1;

        public double Document { get => Document1; set => Document1 = value; }
        public string FirstName { get => FirstName1; set => FirstName1 = value; }
        public string LastName { get => LastName1; set => LastName1 = value; }
        public double Salary { get => Salary1; set => Salary1 = value; }
        public double WorkedDays { get => WorkedDays1; set => WorkedDays1 = value; }
        public double TotalIncome { get => TotalIncome1; set => TotalIncome1 = value; }
        public double Accrual { get => Accrual1; set => Accrual1 = value; }
        public double Health { get => Health1; set => Health1 = value; }
        public double Pension { get => Pension1; set => Pension1 = value; }
        public double SubTransportation { get => SubTransportation1; set => SubTransportation1 = value; }
    }
}
