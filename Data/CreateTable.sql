
create database UBlog
go
use UBlog
go
create table Admin
(
	Id int primary key identity(1,1),
	CreatDate datetime default(getdate()) null,
	AName nvarchar(25) not null,
	APassword nvarchar(255) not null,
	Remark nvarchar(255) null,
	[State] int default(0) null, 
)
go
create table Category
(
	Id int primary key identity(1,1),
	CreateDate datetime default(getdate()),
	CName nvarchar(25) ,
	CId nvarchar(25) ,
	Remark nvarchar(255),
	[State] int default(0),
)
create table Blog
(
	Id int primary key identity(1,1),
	CreateDate datetime default(getdate()),
	Title nvarchar(255) not null ,
	Content ntext null,
	Content_Md ntext null,
	BlogId nvarchar(255) null,
	CategoryTypeId nvarchar(25) null,
	CategoryTypeName nvarchar(25) null,
	UserID nvarchar(25) null,
	Remark nvarchar(255) null,
	[State] int default(0) null,
	Visit int null default(0),
)
select * from Admin ;
select * from Category;
select * from Blog;
