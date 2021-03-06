USE [master]
GO
/****** Object:  Database [QuanLyTourDuLichTrucTuyen]    Script Date: 27/03/2022 16:05:31 ******/
CREATE DATABASE [QuanLyTourDuLichTrucTuyen]

GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTourDuLichTrucTuyen].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET QUERY_STORE = OFF
GO
USE [QuanLyTourDuLichTrucTuyen]
GO
/****** Object:  Table [dbo].[Abouts]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abouts](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[Content] [ntext] NULL,
	[Image] [varchar](300) NULL,
	[Detail] [ntext] NULL,
	[Note] [ntext] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[PolicyId] [smallint] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Abouts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Content] [ntext] NULL,
	[CreatedDate] [datetime] NULL,
	[MemberId] [bigint] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeedBacks]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeedBacks](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[Email] [varchar](250) NULL,
	[Phone] [varchar](50) NULL,
	[Content] [ntext] NULL,
	[CreatedDate] [datetime] NULL,
	[MemberId] [bigint] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_FeedBacks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](300) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[TourId] [bigint] NULL,
	[NewsId] [bigint] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[AboutID] [bigint] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberRoles]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberRoles](
	[MemberID] [bigint] NOT NULL,
	[RoleID] [bigint] NOT NULL,
 CONSTRAINT [PK_MemberRoles] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC,
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](250) NULL,
	[FullName] [nvarchar](250) NULL,
	[Birthday] [datetime] NULL,
	[Address] [nvarchar](250) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [nvarchar](250) NULL,
	[Password] [varchar](50) NULL,
	[ConfirmedPhone] [bit] NULL,
	[ConfirmedEmail] [bit] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[Description] [ntext] NULL,
	[Code] [varchar](20) NULL,
	[Image] [varchar](300) NULL,
	[MoreImages] [xml] NULL,
	[Detail] [ntext] NULL,
	[Note] [ntext] NULL,
	[NewsID] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[Status] [bit] NULL,
	[TopHot] [datetime] NULL,
	[ViewCount] [int] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewsCategories]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewsCategories](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[ParentID] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[Status] [bit] NULL,
	[ShowOnHome] [bit] NULL,
 CONSTRAINT [PK_NewsCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewsTags]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewsTags](
	[NewsID] [bigint] NOT NULL,
	[TagID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NewsTags] PRIMARY KEY CLUSTERED 
(
	[NewsID] ASC,
	[TagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Policies]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policies](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Content] [ntext] NULL,
	[PolicyId] [smallint] NULL,
 CONSTRAINT [PK_Policies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PolicyCategories]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolicyCategories](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_PolicyCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleName] [nchar](10) NULL,
	[RoleDescription] [nvarchar](250) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slides]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slides](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Image] [varchar](300) NULL,
	[DisplayOrder] [int] NULL,
	[Link] [nvarchar](250) NULL,
	[Description] [ntext] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[MemberId] [bigint] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Slides] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[ID] [varchar](50) NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TourCategories]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourCategories](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[ParentID] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[TypeOfTourId] [smallint] NULL,
	[Status] [bit] NULL,
	[ShowOnHome] [bit] NULL,
 CONSTRAINT [PK_TourCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TourMembers]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourMembers](
	[MemberId] [bigint] NOT NULL,
	[TourId] [bigint] NOT NULL,
	[PriceSale] [decimal](18, 2) NULL,
	[NumberTicket] [smallint] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_TourMembers] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC,
	[TourId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tours]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tours](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[Code] [varchar](20) NULL,
	[Image] [varchar](300) NULL,
	[MoreImages] [xml] NULL,
	[Schedule] [nvarchar](250) NULL,
	[Price] [decimal](18, 0) NULL,
	[PromotionPrice] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
	[DepartureDay] [datetime] NULL,
	[StartPlace] [nvarchar](250) NULL,
	[EndPlace] [nvarchar](250) NULL,
	[Transport] [nvarchar](300) NULL,
	[Detail] [ntext] NULL,
	[Note] [ntext] NULL,
	[CategoryID] [bigint] NULL,
	[ScheduleId] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[Status] [bit] NULL,
	[TopHot] [datetime] NULL,
	[ViewCount] [int] NULL,
 CONSTRAINT [PK_Tours] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TourSchedules]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourSchedules](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Content] [ntext] NULL,
 CONSTRAINT [PK_TourSchedules] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfTours]    Script Date: 27/03/2022 16:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfTours](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](500) NULL,
 CONSTRAINT [PK_TypeOfTours] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PolicyCategories] ON 

INSERT [dbo].[PolicyCategories] ([ID], [Name]) VALUES (1, N'Đặt tour')
INSERT [dbo].[PolicyCategories] ([ID], [Name]) VALUES (2, N'Bảo mật')
SET IDENTITY_INSERT [dbo].[PolicyCategories] OFF
GO
ALTER TABLE [dbo].[Abouts]  WITH CHECK ADD  CONSTRAINT [FK_Abouts_Policies] FOREIGN KEY([PolicyId])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].[Abouts] CHECK CONSTRAINT [FK_Abouts_Policies]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Members] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Members]
GO
ALTER TABLE [dbo].[FeedBacks]  WITH CHECK ADD  CONSTRAINT [FK_FeedBacks_Members] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[FeedBacks] CHECK CONSTRAINT [FK_FeedBacks_Members]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Abouts] FOREIGN KEY([AboutID])
REFERENCES [dbo].[Abouts] ([ID])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Abouts]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_News] FOREIGN KEY([NewsId])
REFERENCES [dbo].[News] ([ID])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_News]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Tours] FOREIGN KEY([TourId])
REFERENCES [dbo].[Tours] ([ID])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Tours]
GO
ALTER TABLE [dbo].[MemberRoles]  WITH CHECK ADD  CONSTRAINT [FK_MemberRoles_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[MemberRoles] CHECK CONSTRAINT [FK_MemberRoles_Members]
GO
ALTER TABLE [dbo].[MemberRoles]  WITH CHECK ADD  CONSTRAINT [FK_MemberRoles_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[MemberRoles] CHECK CONSTRAINT [FK_MemberRoles_Roles]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_NewsCategories] FOREIGN KEY([NewsID])
REFERENCES [dbo].[NewsCategories] ([ID])
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_NewsCategories]
GO
ALTER TABLE [dbo].[NewsTags]  WITH CHECK ADD  CONSTRAINT [FK_NewsTags_News] FOREIGN KEY([NewsID])
REFERENCES [dbo].[News] ([ID])
GO
ALTER TABLE [dbo].[NewsTags] CHECK CONSTRAINT [FK_NewsTags_News]
GO
ALTER TABLE [dbo].[NewsTags]  WITH CHECK ADD  CONSTRAINT [FK_NewsTags_Tags] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tags] ([ID])
GO
ALTER TABLE [dbo].[NewsTags] CHECK CONSTRAINT [FK_NewsTags_Tags]
GO
ALTER TABLE [dbo].[Policies]  WITH CHECK ADD  CONSTRAINT [FK_Policies_PolicyCategories] FOREIGN KEY([PolicyId])
REFERENCES [dbo].[PolicyCategories] ([ID])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_PolicyCategories]
GO
ALTER TABLE [dbo].[Slides]  WITH CHECK ADD  CONSTRAINT [FK_Slides_Members] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[Slides] CHECK CONSTRAINT [FK_Slides_Members]
GO
ALTER TABLE [dbo].[TourCategories]  WITH CHECK ADD  CONSTRAINT [FK_TourCategories_TypeOfTours] FOREIGN KEY([TypeOfTourId])
REFERENCES [dbo].[TypeOfTours] ([ID])
GO
ALTER TABLE [dbo].[TourCategories] CHECK CONSTRAINT [FK_TourCategories_TypeOfTours]
GO
ALTER TABLE [dbo].[TourMembers]  WITH CHECK ADD  CONSTRAINT [FK_TourMembers_Members] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[TourMembers] CHECK CONSTRAINT [FK_TourMembers_Members]
GO
ALTER TABLE [dbo].[TourMembers]  WITH CHECK ADD  CONSTRAINT [FK_TourMembers_Tours] FOREIGN KEY([TourId])
REFERENCES [dbo].[Tours] ([ID])
GO
ALTER TABLE [dbo].[TourMembers] CHECK CONSTRAINT [FK_TourMembers_Tours]
GO
ALTER TABLE [dbo].[Tours]  WITH CHECK ADD  CONSTRAINT [FK_Tours_TourCategories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[TourCategories] ([ID])
GO
ALTER TABLE [dbo].[Tours] CHECK CONSTRAINT [FK_Tours_TourCategories]
GO
ALTER TABLE [dbo].[Tours]  WITH CHECK ADD  CONSTRAINT [FK_Tours_TourSchedules] FOREIGN KEY([ScheduleId])
REFERENCES [dbo].[TourSchedules] ([ID])
GO
ALTER TABLE [dbo].[Tours] CHECK CONSTRAINT [FK_Tours_TourSchedules]
GO
USE [master]
GO
ALTER DATABASE [QuanLyTourDuLichTrucTuyen] SET  READ_WRITE 
GO
