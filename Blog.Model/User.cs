using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model
{


    public class User
    {
        /// <summary>
        /// 代码
        /// </summary>
       
        public string us_code { get; set; } 

        /// <summary>
        /// 姓名
        /// </summary>
       
        public string us_name { get; set; } 

        /// <summary>
        /// 职务
        /// </summary>
       
        public string us_title { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
       
        public string us_sex { get; set; } 

        /// <summary>
        /// 公司
        /// </summary> 
        public string us_company { get; set; } 

        /// <summary>
        /// /电话
        /// </summary>
        
        public string us_tel { get; set; } 

        /// <summary>
        /// 传真
        /// </summary>
        
        public string us_fax { get; set; } 


        /// <summary>
        /// 手机
        /// </summary>
        
        public string us_mobile { get; set; } 


        /// <summary>
        /// EMail
        /// </summary>
        
        public string us_email { get; set; } 


        /// <summary>
        /// 登录帐号
        /// </summary>
       
        public string us_account { get; set; }

        /// <summary>
        /// 登入密码
        /// </summary>
       
        public string us_password { get; set; } 

        /// <summary>
        /// 类型
        /// </summary>
       
        public string us_type { get; set; } 


        /// <summary>
        /// 备注
        /// </summary>
        
        public string us_memo { get; set; } 

        /// <summary>
        /// 最近是否更新0-无更新，1-更新，2-新添加
        /// </summary>
        
        public int us_ifupdate { get; set; } 


        /// <summary>
        /// 注册日期
        /// </summary>
        
        public DateTime us_raisedate { get; set; } 

        /// <summary>
        /// 开户行
        /// </summary>
        
        public string us_bank { get; set; } 

        /// <summary>
        /// 开户行账号
        /// </summary>
        
        public string us_bankaccount { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        
        public string icq { get; set; } 


        /// <summary>
        /// 出生日期
        /// </summary>
        
        public DateTime birthday { get; set; } 

        /// <summary>
        /// MSN
        /// </summary>
        
        public string msn { get; set; } 



        /// <summary>
        /// MSN
        /// </summary>
        
        public string skype { get; set; } 


        /// <summary>
        /// 是否禁用
        /// </summary>
       
        public int disabled { get; set; } 

        /// <summary>
        /// 登录状态
        /// </summary>
        
        public int state { get; set; } 


        /// <summary>
        /// 是否要KEY登录
        /// </summary>
       
        public int usingkey { get; set; } 


        /// <summary>
        /// 登录时长
        /// </summary>
       
        public int onlinetime { get; set; } 


        /// <summary>
        /// 身份证号码
        /// </summary>
        
        public string us_zip { get; set; } 


        /// <summary>
        /// 家庭地址
        /// </summary>
       
        public string us_address { get; set; } 
        /// <summary>
        /// 是否作删除标记，0：未删除；1：删除
        /// </summary>
      
        public int deleteflag { get; set; } 

        /// <summary>
        /// 删除人
        /// </summary>
      
        public string deleteid { get; set; } 

        /// <summary>
        /// 删除时间
        /// </summary>
        
        public DateTime deletedate { get; set; } 


        /// <summary>
        /// 办公电话
        /// </summary>
        
        public string us_officephone { get; set; } 
        /// <summary>
        /// 记录流水号，序列自增
        /// </summary>
      
        public int c_userid { get; set; } 

        /// <summary>
        /// 办公电话
        /// </summary>
        
        public string status { get; set; } 


        /// <summary>
        /// 头像
        /// </summary>
       
        public string us_photo { get; set; } 


        /// <summary>
        /// 微信号
        /// </summary>
        
        public string us_weixin_code { get; set; } 

        /// <summary>
        /// 籍贯
        /// </summary>
        
        public string vu_native { get; set; } 


        /// <summary>
        /// 民族
        /// </summary>
        
        public string vu_nation { get; set; } 

        /// <summary>
        /// 是否结婚
        /// </summary>
       
        public string vu_marriage { get; set; } 

        /// <summary>
        /// 政治面貌
        /// </summary>
        
        public string vu_political { get; set; } 

        /// <summary>
        /// 健康情况
        /// </summary>
        
        public string vu_health { get; set; } 

        /// <summary>
        /// 参加工作时间
        /// </summary>
       
        public DateTime vu_workdate { get; set; }

        /// <summary>
        /// 工龄
        /// </summary>
        
        public int vu_workage { get; set; } 

        /// <summary>
        /// 学历
        /// </summary>
       
        public string vu_education { get; set; } 

        /// <summary>
        /// 毕业学校
        /// </summary>
        
        public string vu_school { get; set; } 
        /// <summary>
        /// 毕业时间
        /// </summary>
       
        public DateTime vu_graduatedate { get; set; } 

        /// <summary>
        /// 所获证书
        /// </summary>
        
        public string vu_certificate { get; set; } 

        /// <summary>
        /// 身高
        /// </summary>
       
        public float vu_height { get; set; } 
        /// <summary>
        /// 体重
        /// </summary>
       
        public float vu_weight { get; set; } 

        /// <summary>
        /// 血型
        /// </summary>
       
        public string vu_blood { get; set; } 

        /// <summary>
        /// QQ
        /// </summary>
        
        public string us_qq { get; set; } 

        /// <summary>
        /// Logo
        /// </summary>
        
        public string us_logo { get; set; } 
    }
}
