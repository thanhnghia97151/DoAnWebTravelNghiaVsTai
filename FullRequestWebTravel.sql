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
	Address nvarchar(250),
	Phone varchar(50),
	Email nvarchar(250),
	Password varchar(50),
	ConfirmedPhone bit default 0 ,
	Status bit default 0
);
go
--insert into Members values('1','nghia','thanhnghia','1/1/2022','quan 12','0988888',N'abc@gmail.com','nghia',0,0)
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
	primary key (MemberID,RoleID)
);
go