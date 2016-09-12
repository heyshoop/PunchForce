using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchForce
{
    public class job
    {
        private emp emp;
        private String bgrq;//最近报工日期
        private String data;//日期
        private String datajq;//日期精确到秒
        private String workType;//出勤类型
        private String overTime;//加班时间
        private String workTime;//报工人天数
        private String place;//工作地点
        private String placeId;//工作地点ID
        private String project;//项目
        private String projectId;//项目ID
        private String quarter;//宿舍
        private String quarterId;//宿舍ID
        private String pcType;//电脑情况
        private String desc;//工作说明
        private String sheetId;//表单主键
        private String organName;//公司名称
        private String organId;//公司ID
        private String deptName;//部门名称
        private String deptId;//部门ID

        public emp Emp
        {
            get
            {
                return emp;
            }

            set
            {
                emp = value;
            }
        }

        public string Bgrq
        {
            get
            {
                return bgrq;
            }

            set
            {
                bgrq = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Datajq
        {
            get
            {
                return datajq;
            }

            set
            {
                datajq = value;
            }
        }

        public string WorkType
        {
            get
            {
                return workType;
            }

            set
            {
                workType = value;
            }
        }

        public string OverTime
        {
            get
            {
                return overTime;
            }

            set
            {
                overTime = value;
            }
        }

        public string WorkTime
        {
            get
            {
                return workTime;
            }

            set
            {
                workTime = value;
            }
        }

        public string Place
        {
            get
            {
                return place;
            }

            set
            {
                place = value;
            }
        }

        public string PlaceId
        {
            get
            {
                return placeId;
            }

            set
            {
                placeId = value;
            }
        }

        public string Project
        {
            get
            {
                return project;
            }

            set
            {
                project = value;
            }
        }

        public string ProjectId
        {
            get
            {
                return projectId;
            }

            set
            {
                projectId = value;
            }
        }

        public string Quarter
        {
            get
            {
                return quarter;
            }

            set
            {
                quarter = value;
            }
        }

        public string QuarterId
        {
            get
            {
                return quarterId;
            }

            set
            {
                quarterId = value;
            }
        }

        public string PcType
        {
            get
            {
                return pcType;
            }

            set
            {
                pcType = value;
            }
        }

        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

        public string SheetId
        {
            get
            {
                return sheetId;
            }

            set
            {
                sheetId = value;
            }
        }

        public string OrganName
        {
            get
            {
                return organName;
            }

            set
            {
                organName = value;
            }
        }

        public string OrganId
        {
            get
            {
                return organId;
            }

            set
            {
                organId = value;
            }
        }

        public string DeptName
        {
            get
            {
                return deptName;
            }

            set
            {
                deptName = value;
            }
        }

        public string DeptId
        {
            get
            {
                return deptId;
            }

            set
            {
                deptId = value;
            }
        }
    }
}
