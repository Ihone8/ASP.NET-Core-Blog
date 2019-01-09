using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using Blog.Model;
namespace Blog.DAL
{
    public class BlogDAL
    {

        public string ConnStr { get; set; }

        public BlogDAL(string connstr)
        {
            this.ConnStr = connstr;
        }


        /// <summary>
        /// 获取整个列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BLOG> GetList()
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                return _connection.Query<BLOG>("select * from BLOG where State = 0");
            }
        }

        public int GetCountByCategoryTypeId(int Id)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                return (int)_connection.ExecuteScalar("select count(*) from Blog where CategoryTypeId = @Id and state = 0", new { @Id = Id });
            }
        }
        /// <summary>
        /// 获得单条数据
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns></returns>
        public BLOG GetOne(int Id)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                return _connection.QueryFirst<BLOG>("select * from BLOG where Id=@Id and State = 0", new { Id = Id });
            }
        }

        /// <summary>
        /// 添加博客
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(BLOG entity)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                if (_connection.Execute("insert into Blog(Title,Content,Content_Md,CategoryTypeId,CategoryTypeName, UserID, Remark, BlogId,Visit)values(@Title, @Content, @Content_Md, @CategoryTypeId,@CategoryTypeName, @UserID, @Remark, @BlogId,0)", entity) > 0)
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// 删除博客。
        /// </summary>
        /// <param name="Id">博客Id</param>
        /// <param name="IsDelete">是否删删除。 true => 删除该数据。false => 修改状态。打上删除标记 </param>
        /// <returns></returns>
        public bool Delete(int Id, bool IsDelete = false)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                if (IsDelete)
                {
                    if (_connection.Execute("delete from Blog where Id=@Id", new { Id = Id }) > 0)
                    {
                        return true;
                    }
                }
                else
                {
                    if (_connection.Execute("update  Blog set State = 1 where  Id=@Id", new { Id = Id }) > 0)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// 更新博客内容
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        public bool Update(BLOG blog)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                if (_connection.Execute("UPDATE [Blog] SET [Title] = @Title ,[Content] = @Content,[Content_Md] = @Content_Md,[CategoryTypeId]=@CategoryTypeId,[CategoryTypeName]=@CategoryTypeName ,[Remark] = @Remark, [Visit] =@Visit WHERE Id=@Id", blog) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// 获取博客总数量
        /// </summary>
        /// <returns></returns>
        public int GetCount(string where = "")
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                string sql = " select count(*) from Blog where State = 0 ";
                if (!string.IsNullOrEmpty(where))
                {
                    sql += $" and  {where}";
                }
                return (int)_connection.ExecuteScalar(sql);
            }
        }

        public List<Blog.Model.BLOG> GetBlogListByPaging(string orderstr, int PageSize, int PageIndex, string strWhere)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                if (!string.IsNullOrEmpty(strWhere))
                {
                    strWhere = " where " + strWhere;
                }
                string sql = string.Format(
                       "select * from [blog] {0} order by {1} offset {2} rows fetch next {3} rows only",
                       strWhere,
                       orderstr,
                       PageIndex * PageSize,
                       PageSize
                   );
                return _connection.Query<Blog.Model.BLOG>(sql).ToList();
            }
        }
    }
}
