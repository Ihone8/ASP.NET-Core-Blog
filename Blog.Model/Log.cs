using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URM_DB_Repos.Models
{


    public class Log
    {
        /// <summary>
        /// 日志编号
        /// </summary>
       
        public int LG_RE_ID { get; set; }

       
        public string LG_US_ID { get; set; } //varchar(30) not null ,       --用户ID

       
        public DateTime LG_DT { get; set; } //    datetime default(getdate()), --登入时间


      
        public string LG_CU_IP { get; set; } // varchar(20),					--登入 IP 地址


       
        public string LG_CU_MA { get; set; } // varchar(20),					--登入Mac 地址


        
        public string LG_AC_TY { get; set; } //varchar(20),				--操作类型

        
        public string LG_LG_TY { get; set; } // varchar(20),					--登入类型

        
        public string LG_CU_NM { get; set; } // varchar(20),				--登入名
    }
}
