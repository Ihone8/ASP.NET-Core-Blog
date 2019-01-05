using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model
{
    public class Admin
    {
        public int Id { get; set; }

        public DateTime CreatDate { get; set; }

        public string AName { get; set; }

        public string APassword { get; set; }

        public string Remark { get; set; }

        public int State { get; set; }
    }
}
