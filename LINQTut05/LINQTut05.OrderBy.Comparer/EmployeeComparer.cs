using LINQTut05.Shared;
using System;
using System.Collections.Generic;


namespace LINQTut05.OrderBy.Comparer
{
    internal class EmployeeComparer : IComparable<Employee>
    {
        public string EmployeeNo { get; set; }

        public int CompareTo(Employee? other)
        {
            // "2017-FI-1343" => "2017", "FI", "1343"

            var e1Year = Convert.ToInt32(this.EmployeeNo.Split('-')[0]);
            var e2Year = Convert.ToInt32(other.EmployeeNo.Split('-')[0]);

            var e1Seq = Convert.ToInt32(this.EmployeeNo.Split('-')[2]);
            var e2Seq = Convert.ToInt32(other.EmployeeNo.Split('-')[2]);


            if (e1Year == e2Year)
            {
                return e1Seq.CompareTo(e2Seq);
            }
            else
            {
                return e1Year.CompareTo(e2Year);
            }
        }
    }
}
