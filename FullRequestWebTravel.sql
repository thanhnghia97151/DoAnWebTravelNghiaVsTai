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
	Password varchar(50),
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

exec GetRolesChecked @Id = '1'
select * from 
---
create proc GetRoleNamesByMemberId(@Id varchar(64))
as
	select RoleName from Roles join MemberInRole on Roles.RoleID = MemberInRole.RoleID and MemberID = @Id

exec GetRoleNamesByMemberId @Id = '1'