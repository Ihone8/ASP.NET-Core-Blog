using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model
{
    public class BLOG
    {

        ///<summary>
        ///
        ///</summary>

        public int Id { get; set; }


        ///<summary>
        ///
        ///</summary>

        public DateTime? CreateDate { get; set; }


        ///<summary>
        ///
        ///</summary>

        public string Title { get; set; }


        ///<summary>
        ///
        ///</summary>

        public string Content { get; set; }


        ///<summary>
        ///
        ///</summary>

        public string Content_Md { get; set; }


        ///<summary>
        ///
        ///</summary>

        public string CategoryTypeId { get; set; }


        ///<summary>
        ///
        ///</summary>

        public string CategoryTypeName { get; set; }


        ///<summary>
        ///
        ///</summary>

        public string UserID { get; set; }


        ///<summary>
        ///
        ///</summary>

        public string Remark { get; set; }


        ///<summary>
        ///
        ///</summary>

        public int? State { get; set; }


        ///<summary>
        ///
        ///</summary>

        public string BlogId { get; set; }


        public int Visit { get; set; }
    }
}
