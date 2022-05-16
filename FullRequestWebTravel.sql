
create database DBWebTravel
go

use DBWebTravel
go
--drop table Members
create table Members
(
	MemberID varchar(64) not null primary key,
	UserName varchar(250),
	FullName varchar(250),
	Brithday datetime,
	Gender varchar(64),
	Address nvarchar(250),
	Phone varchar(50),
	Email nvarchar(250),
	Password varchar(64) not null,
	ConfirmedPhone bit default 0 ,
	Status bit default 0
);
go
--insert into Members values('2','tai','vantai','1/1/2022','quan 12','Nam','0988888',N'abc@gmail.com','nghia',0,0)
--select * from Roles
--insert into Roles values (NewId(),'Admin','Private Admin')
--insert into Roles values (NewId(),'Employee','Private Employee')
--insert into Roles(RoleName,RoleDesciption)  values ('Customer','Private Customer')
--drop table Roles

create table Roles
(
	RoleID uniqueidentifier not null primary key default NewID(),
	RoleName varchar(16) not null,
	RoleDesciption varchar(250)
);
go
--drop table MemberInRole
create table MemberInRole
(
	MemberID varchar(64) not null,
	RoleID uniqueidentifier not null ,	
	IsDeleted bit not null default 0,
	primary key (MemberID,RoleID),
	foreign key (MemberID) references Members(MemberID),
	foreign key (RoleID) references Roles(RoleID)
);
go

--insert into MemberInRole values('1','D1E85FF0-5841-4E38-AA32-E9083FD4098B',0)

--drop proc AddMemberInRole
create proc AddMemberInRole (
	@MemberId varchar(64),
	@RoleId uniqueidentifier
)
as
	begin
		if exists(select * from MemberInRole where MemberID = @MemberId and RoleID = @RoleId)
			update MemberInRole set IsDeleted = ~IsDeleted where MemberID = @MemberId and RoleID = @RoleId;
	else 
		insert into MemberInRole (MemberID,RoleID) values (@MemberId,@RoleId);
	end
go
--drop proc GetRolesChecked
create proc GetRolesChecked(@Id varchar(64))
as
	select Roles.*,iif(MemberID is null,0,1) as Checked from Roles left join MemberInRole on Roles.RoleID = MemberInRole.RoleID and MemberId =@Id and IsDeleted=0;
go

--exec GetRolesChecked @Id = '1'
--select * from 
---
create proc GetRoleNamesByMemberId(@Id varchar(64))
as
	select RoleName from Roles join MemberInRole on Roles.RoleID = MemberInRole.RoleID and MemberID = @Id;
go

--exec GetRoleNamesByMemberId @Id = '1'

--select * from Members
--insert into Members(MemberID,UserName,Password,Email,Phone) values('gwqwertyuiopasdfghjklzxcvbnm1234567890kqwertyuiopasdfghjklzxcvbn','fdasfas','fdafdas','abc@gmai.com','dafasfdsaf')
--drop table TypeOfTours
create table TypeOfTours
(
	Id varchar(64) not null primary key,
	Type nvarchar(250)
);
go
--drop table TourCategories
create table TourCategories 
(
	TourCategoriesId varchar(64) not null primary key,
	Name nvarchar(250),
	SeoTitle nvarchar(250),
	MetaTitle nvarchar(250),

	ParentId varchar(64),
	CreateDate datetime,
	CreatedBy nvarchar(250),
	ModifiedDate datetime,
	ModifiedBy nvarchar(250),
	TypeOfTourId varchar(64),
	Status bit default 0,
	ShowOnHome bit default 0
	foreign key (TypeOfTourId) references TypeOfTours(Id),
	foreign key (ParentId) references TourCategories(TourCategoriesId)
	
);
go
--drop table TourSchedules
create table TourSchedules
(
	TourScheduleId varchar(64) not null primary key,
	Content ntext
);
go
--drop table Tours
create table Tours
(
	TourId varchar(64) not null primary key,
	Name nvarchar(max),
	MetaTitle varchar(250),
	Code varchar(50),
	Image varchar(50),  
	Schedule nvarchar(250),
	Price decimal(18,0),
	PromotionPrice decimal(18,0),
	Quantity int,
	DepartureDat datetime,
	StartDate datetime,
	EndDate datetime,
	StartPlace nvarchar(250),
	EndPlace nvarchar(250),
	Transport nvarchar(250),
	Detail ntext,
	Note ntext,
	CategoryId varchar(64),
	ScheduleId varchar(64),
	CreatedDate datetime,
	CreatedBy nvarchar(250),
	ModifiedDate datetime,
	ModifiedBy nvarchar(250),
	Status bit default 0,
	TopHot datetime,
	ViewCount int
	foreign key (CategoryId) references TourCategories(TourCategoriesId),
	foreign key (ScheduleId) references TourSchedules(TourScheduleId)
);
go

--drop table TypeOfTours
--drop table TourCategories
--drop table TourSchedule
--drop table Tours
--drop table PolicyCategories

create table PolicyCategories
(
	Id varchar(64) not null primary key,
	Name nvarchar(250),
);
go
--drop table Policies
create table Policies
(
	Id varchar(64) not null primary key,
	Content ntext,
	PolicyCategoryId varchar(64),
	foreign key (PolicyCategoryId) references PolicyCategories(Id)
);
go
--drop table Abouts
create table Abouts
(
	Id varchar(64)not null primary key,
	Name nvarchar(250),
	MetaTitle varchar(250),
	Content ntext,
	Image varchar(300),
	Detail ntext,
	Note ntext,
	CreatedDate datetime,
	CreatedBy nvarchar(150),
	ModifiedDate datetime,
	ModifiedBy nvarchar(150),
	PolicyId varchar(64),
	Status bit default 0,
	foreign key (PolicyId) references Policies(Id)
);
go

--insert into Tours(TourId,Name,MetaTitle,Code,Image,Schedule,Price,PromotionPrice,Quantity,DepartureDat,StartPlace,EndPlace,Transport,Detail,Note,CategoryId,ScheduleId,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy)values('123','abc','abc','abc','abc','abc',123,123,1,'2002-2-2','abc','abc','abc','abc','abc','kdfjlasf','123','2002-1-1','abc','2002-1-1','abc')
--drop table TourMembers
create table TourMembers
(
	MemberId varchar(64) not null ,
	TourId varchar(64) not null,
	PriceSale decimal(18,2),
	NumberTicket int,
	CreatedDate datetime,
	primary key (MemberId,TourId),
	foreign key (MemberId) references Members(MemberID),
	foreign key (TourId) references Tours(TourId)
);
go

create table Tags
(
	TagId varchar(64) not null primary key,
	Name nvarchar(250)
);
go
--drop table NewsCategories
create table NewsCategories
(
	NewsCategoryId varchar(64) not null primary key,
	Name nvarchar(250),
	SeoTitle nvarchar(250),
	MetaTitle nvarchar(250),
	ParentId varchar(64),
	CreatedDate datetime,
	CreatedBy nvarchar(150),
	ModifiedDate datetime,
	ModifiedBy nvarchar(150),
	Status bit default 0,
	ShowOnHome bit default 0,
	foreign key (ParentId) references NewsCategories(NewsCategoryId),
);
go
--drop table News
create table News
(
	NewsId varchar(64) not null primary key,
	Name nvarchar(250),
	MetaTitle varchar(250),
	Description ntext,
	Code varchar(20),
	Image varchar(300),
	Detail ntext,
	Note ntext,
	NewCategoryId varchar(64),
	CreatedDate datetime,
	CreatedBy nvarchar(150),
	ModifiedDate datetime,
	ModifiedBy nvarchar(150),
	Status bit default 0,
	TopHot datetime,
	ViewCount int, 
	foreign key (NewCategoryId) references NewsCategories(NewsCategoryId)
);
go
--drop table NewTags
create table NewTags
(
	NewsId varchar(64) not null,
	TagId varchar(64) not null,
	primary key(NewsId,TagId),
	foreign key (NewsId) references News(NewsId),
	foreign key (TagId) references Tags(TagId)
);
go
--drop table ImageTour
create table ImageTour
(
	ImageId varchar(64) not null default NEWID() primary key,
	ImageUrl varchar(64),
	ImageOriginal nvarchar(250) not null,
	ImageContentType nvarchar(250),
	Size bigint,
	TourId varchar(64),
	Status bit default 0,
	foreign key (TourId) references Tours(TourId)
);
go

--drop table Invoice
create table Invoice
(
	InvoiceId varchar(64) not null primary key ,
	IncoiceDate datetime not null default getdate(),
	[Address] nvarchar(max) not null ,
	MemberId varchar(64) not null references Members(MemberID),
	Status bit 
);
go
--drop table IncoiveDetail
create table InvoiceDetail
(
	InvoiceId varchar(64) not null references Invoice(InvoiceId),
	TourId varchar(64) not null references Tours(TourId),
	Price int not null,
	Quantity smallint not null,
	Payment decimal(18,0),
	QuantityDepartment int,
	Description nvarchar(max),
	PaymentMore bit

);
go
--select * from Tours
create proc GetToursPaging(@Page int, @Size int)
as
	begin

		select * from Tours
			order by TourId
			OFFSET (@Page-1)*@Size rows
			FETCH NEXT @Size ROWS ONLY;
	end;
go
-- drop proc AddInvoice
create proc AddInvoice (
	@InvoiceId varchar(64) ,
	@Address nvarchar(max) ,
	@MemberId varchar(64)
)
as 
	begin
	insert into Invoice(InvoiceId,Address,MemberId,Status) values (@InvoiceId,@Address,@MemberId,0);
	end;
go
--delete Invoice
exec AddInvoice @InvoiceId = 'dssfa', @Address = 'fafdfdsaf', @MemberId = '6zbqfwpeg19j2xm7xnw5ujohcs9d9wgicx2s5rkk5mo5m6jh1kho7wshaiger8rf'
--drop proc GetRolesByMemberId
create proc GetRolesByMemberId(@Id varchar(64))
as
	select Roles.RoleName from Roles join MemberInRole on Roles.RoleID = MemberInRole.RoleID and MemberInRole.MemberID = @Id;


--

--select * from Roles

--exec GetToursPaging @Page =1 , @Size = 4
--select * from TypeOfTours
--select * from TourCategories
--select * from TourSchedules
--select * from Tours
--select * from Members
--select * from TourMembers
--select * from PolicyCategories
--select * from Policies
--select * from Abouts
--select * from Tags
--select * from NewsCategories
--select * from News
--select * from NewTags
--select * from Contacts
--select * from ImageTour

update Members set ConfirmedPhone = 0 where MemberID = '8th53v47v49cc0u40cs8mmabr7waiw4zzygh0qlevk8giqj0lod90keo5327czmx'
delete from Members where MemberID = 'reppixlzyoyjxrowucnc5auolxsou5lwfizl1nbfykq7vvlv0p2ec9936q2boafs'
delete from Tours
delete from TypeOfTours
delete from TourCategories
delete from TourSchedules