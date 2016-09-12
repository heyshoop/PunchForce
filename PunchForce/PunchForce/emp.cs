using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchForce
{
    public class emp
    {
        private String empName;
        private String bs64Name;
        private String objectId;
        private String passwd;

        public string EmpName
        {
            get
            {
                return empName;
            }

            set
            {
                empName = value;
            }
        }

        public string ObjectId
        {
            get
            {
                return objectId;
            }

            set
            {
                objectId = value;
            }
        }

        public string Passwd
        {
            get
            {
                return passwd;
            }

            set
            {
                passwd = value;
            }
        }

        public string Bs64Name
        {
            get
            {
                return bs64Name;
            }

            set
            {
                bs64Name = value;
            }
        }
    }
}
