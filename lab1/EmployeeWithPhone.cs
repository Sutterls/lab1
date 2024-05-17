using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class EmployeeWithPhone : Employee /// сотрудники с номерами телефона
    {
        public string? PhoneNumber { get; set; } ///из-за длины номеров телефона и вариативного написания
    }
}
