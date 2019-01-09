function LoadPagingByPageIndex(pageIndex, CategoryTypeId) {
    layui.use(['laypage', 'layer', 'laydate'], function () {
        var laypage = layui.laypage;
        var layer = layui.layer;
        var key = $.trim($('#txtkey').val());  //标题关键字
        var postdata = {
            Title: key,
            PageSize: PageSize,
            CategoryType: CategoryTypeId,
            PageIndex: pageIndex - 1
        };
        var Url = "/Admin/Home/GetBlogListByPaging";
        $.post(Url, postdata, function (data) {
            // 第一页
            if (pageIndex == 1) {
                laypage.render({
                    elem: 'page',
                    count: data.total,
                    //skin: '#5fb878',
                    //skip: false,
                    limit: PageSize,
                    jump: function (obj, first) {
                        if (!first) {
                            $('#pageIndex').html(obj.curr);
                            LoadPagingByPageIndex(obj.curr);
                        }
                    }
                });
            }
            $("#pageCount").html(data.pageCount);  // 共多少页
            $("#totalCount").html(data.total);    // 多少条记录
            $('#pageIndex').html(pageIndex);
            var Html = "";
            $.each(data.data, function (i, obj) {
                Html += "<article class='article article-type-post' itemscope itemprop='blogPost'>";
                Html += "<div class='article-meta'><a href='javascript:;' class='article-date' ><time datetime='' itemprop='datePublished'>" + obj.createDate + "</time></a></div>";
                Html += "<div class='article-inner' ><input type='hidden' class='isFancy' /><header class='article-header'><h1 itemprop='name'><a class='article-title' style='width:780px;display:block' href='/Home/ShowBlogDetails/" + obj.id + "'>" + obj.title + "</a></h1></header>";
                Html += " <div class='article-entry' itemprop='articleBody'>" + obj.title + "</div>";
                Html += " <div class='article-info article-info-index'><div class='article-tag tagcloud'><ul class='article-tag-list'><li class='article-tag-list-item'><a class='article-tag-list-link color1' asp-action='Tag' asp-controller='Home' asp-route-tag='" + obj.categoryTypeName + "'>" + obj.categoryTypeName + "</a></li></ul>";
                Html += " </div><div class='clearfix'></div></div></div></article>";
            });
            $("#BlogList").html(Html);

        })
    })
}