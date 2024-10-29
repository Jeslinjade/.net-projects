using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClsEmployeeP
    {
        int EmpId, EAge;
        string EName, EAddress;
        public int PEmpId
        {
            set
            {
                EmpId = value;
            }
            get
            {
                return EmpId;
            }
        }
        public int PEAge
        {
            set
            {
                EAge = value;
            }
            get
            {
                return EAge;
            }
        }
        public string PEname
        {
            set
            {
                EName = value;
            }
            get
            {
                return EName;
            }
        }
        public string PEaddress
        {
            set
            {
                EAddress = value;
            }
            get
            {
                return EAddress;
            }
        }
    }
}
