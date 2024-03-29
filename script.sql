USE [master]
GO
/****** Object:  Database [UpWork-08-08-2019]    Script Date: 8/26/2019 11:45:05 PM ******/
CREATE DATABASE [UpWork-08-08-2019]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UpWork-08-08-2019', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\UpWork-08-08-2019.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UpWork-08-08-2019_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\UpWork-08-08-2019_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [UpWork-08-08-2019] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UpWork-08-08-2019].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UpWork-08-08-2019] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET ARITHABORT OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UpWork-08-08-2019] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UpWork-08-08-2019] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UpWork-08-08-2019] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UpWork-08-08-2019] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET RECOVERY FULL 
GO
ALTER DATABASE [UpWork-08-08-2019] SET  MULTI_USER 
GO
ALTER DATABASE [UpWork-08-08-2019] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UpWork-08-08-2019] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UpWork-08-08-2019] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UpWork-08-08-2019] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UpWork-08-08-2019] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'UpWork-08-08-2019', N'ON'
GO
ALTER DATABASE [UpWork-08-08-2019] SET QUERY_STORE = OFF
GO
USE [UpWork-08-08-2019]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[surname] [nvarchar](100) NULL,
	[password] [nvarchar](1000) NULL,
	[token] [nvarchar](1000) NULL,
	[email] [nvarchar](50) NULL,
	[isAdmin] [bit] NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AmAndDepartaments]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AmAndDepartaments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[departamentID] [int] NULL,
	[amID] [int] NULL,
	[assignedTime] [datetime] NULL,
 CONSTRAINT [PK_AmAndClients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AmUsers]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AmUsers]
AS
SELECT        dbo.Admins.id, dbo.AmAndDepartaments.departamentID, dbo.AmAndDepartaments.amID
FROM            dbo.Admins INNER JOIN
                         dbo.AmAndDepartaments ON dbo.Admins.id = dbo.AmAndDepartaments.amID
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[surname] [nvarchar](100) NULL,
	[password] [nvarchar](1000) NULL,
	[token] [nvarchar](500) NULL,
	[email] [nvarchar](100) NULL,
	[createdDate] [datetime] NULL,
	[createdBy] [int] NULL,
	[isActive] [bit] NULL,
	[lastModifiedBy] [int] NULL,
	[companyID] [int] NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[address] [nvarchar](500) NULL,
	[contactperson] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[createdDate] [datetime] NULL,
	[createdBy] [int] NULL,
	[isActive] [bit] NULL,
	[activedate] [datetime] NULL,
	[lastModifiedBy] [int] NULL,
 CONSTRAINT [PK_Departaments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepartamentUsers]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartamentUsers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clientID] [int] NULL,
	[departamentID] [int] NULL,
	[assignedTime] [datetime] NULL,
 CONSTRAINT [PK_DepartamentUsers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clientID] [int] NULL,
	[datetime] [datetime] NULL,
	[message] [text] NULL,
	[name] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[subject] [nvarchar](500) NULL,
	[cellPhone] [nvarchar](100) NULL,
 CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogHistories]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogHistories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clientID] [int] NULL,
	[date] [datetime] NULL,
	[logStatus] [char](10) NULL,
 CONSTRAINT [PK_LogHostories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ticketID] [int] NULL,
	[subject] [nvarchar](100) NULL,
	[message] [text] NULL,
	[filename] [text] NULL,
	[datetime] [datetime] NULL,
	[from] [bit] NULL,
	[fromID] [int] NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 8/26/2019 11:45:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clientID] [int] NULL,
	[subject] [nvarchar](100) NULL,
	[message] [text] NULL,
	[filename] [text] NULL,
	[status] [char](10) NULL,
	[datetime] [datetime] NULL,
	[departmentID] [int] NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([id], [name], [surname], [password], [token], [email], [isAdmin]) VALUES (1, N'Tuncay', N'Huseynov', N'UCyzOSTMtm3F+KNm4dcYh38iIN+Q8GdiOydwxm8+sp0=', N'NBWqzKhgaBJoB5hP3V5GLw==', N'tuncayhuseynov@gmail.com', 1)
INSERT [dbo].[Admins] ([id], [name], [surname], [password], [token], [email], [isAdmin]) VALUES (17, N'Tuncay', N'Huseynov', N'3pFnph2hyJHQE9SFosUwOlMBfuhzpsSxpeye660tmks=', N'uNepCB2HgCKjfk7tlbjLAw==', N'thuseynov2020@ada.edu.az', 0)
INSERT [dbo].[Admins] ([id], [name], [surname], [password], [token], [email], [isAdmin]) VALUES (22, N'Sam', N'Admin', N'7pVC+qR8DIHqw5sNDI2W9rxHR0oIWLIj8v2c8YcsrcU=', N'OhHcbuqC/BCmvqEdwKJ1gw==', N'admin@sam.com', 0)
SET IDENTITY_INSERT [dbo].[Admins] OFF
SET IDENTITY_INSERT [dbo].[AmAndDepartaments] ON 

INSERT [dbo].[AmAndDepartaments] ([id], [departamentID], [amID], [assignedTime]) VALUES (1, 12, 17, CAST(N'2019-08-18T20:39:48.843' AS DateTime))
INSERT [dbo].[AmAndDepartaments] ([id], [departamentID], [amID], [assignedTime]) VALUES (3, 12, 22, CAST(N'2019-08-26T22:56:31.613' AS DateTime))
INSERT [dbo].[AmAndDepartaments] ([id], [departamentID], [amID], [assignedTime]) VALUES (4, 18, 22, CAST(N'2019-08-26T22:56:31.613' AS DateTime))
SET IDENTITY_INSERT [dbo].[AmAndDepartaments] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([id], [name], [surname], [password], [token], [email], [createdDate], [createdBy], [isActive], [lastModifiedBy], [companyID]) VALUES (1, N'Tunjay', N'Huseynov', N'5591980', N'5591980', N'thuseynov@gmail.com', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Clients] ([id], [name], [surname], [password], [token], [email], [createdDate], [createdBy], [isActive], [lastModifiedBy], [companyID]) VALUES (8, N'Tuncay', N'Huseynov', N'DNEumtX4gOjOn8zWcWkHCRDhMWWzI53ThEKPMhfDyCI=', N'Dqxugy5K9AIMv5dPUD16xg==', N'tuncayhuseynov@gmail.com', NULL, NULL, 1, NULL, 12)
INSERT [dbo].[Clients] ([id], [name], [surname], [password], [token], [email], [createdDate], [createdBy], [isActive], [lastModifiedBy], [companyID]) VALUES (11, N'Tuncay Huseynov', N'Huseynov', N'L9H24gnUNoyWt4HFi2beab/qvdk1ntCBUGXWGj3r2aA=', N'anoufge4E8mWHiZWQVs8Fw==', N'thuseynov2020@ada.edu.az', NULL, NULL, 1, NULL, 17)
INSERT [dbo].[Clients] ([id], [name], [surname], [password], [token], [email], [createdDate], [createdBy], [isActive], [lastModifiedBy], [companyID]) VALUES (12, N'Rajes', N'C', N'FkemUPuF2OyDE0dBRWvLAo/ZPSrgkIi27EMRXMA0mvE=', N'93+uht6xNVWx9UV2oSLI0Q==', N'r@SAM1.com', NULL, NULL, 1, NULL, 18)
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([id], [name], [address], [contactperson], [email], [createdDate], [createdBy], [isActive], [activedate], [lastModifiedBy]) VALUES (12, N'Microsoft', N'LA', N'Tunjay', N'thuseynov2020@ada.edu.az', CAST(N'2019-08-23T12:14:54.250' AS DateTime), 1, 1, NULL, NULL)
INSERT [dbo].[Companies] ([id], [name], [address], [contactperson], [email], [createdDate], [createdBy], [isActive], [activedate], [lastModifiedBy]) VALUES (17, N'Google', N'San Francisco', N'Tunjay', N'tuncayhuseynov@gmail.com', CAST(N'2019-08-26T17:38:57.190' AS DateTime), 1, 1, NULL, NULL)
INSERT [dbo].[Companies] ([id], [name], [address], [contactperson], [email], [createdDate], [createdBy], [isActive], [activedate], [lastModifiedBy]) VALUES (18, N'SAM1', N'La, 1345', N'BHAVSH', N'be@c.com', CAST(N'2019-08-26T22:21:39.527' AS DateTime), 1, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Companies] OFF
SET IDENTITY_INSERT [dbo].[DepartamentUsers] ON 

INSERT [dbo].[DepartamentUsers] ([id], [clientID], [departamentID], [assignedTime]) VALUES (6, 8, 12, CAST(N'2019-08-23T23:03:33.653' AS DateTime))
INSERT [dbo].[DepartamentUsers] ([id], [clientID], [departamentID], [assignedTime]) VALUES (9, 11, 17, CAST(N'2019-08-26T17:39:13.557' AS DateTime))
SET IDENTITY_INSERT [dbo].[DepartamentUsers] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([id], [Name]) VALUES (1, N'General')
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Feedbacks] ON 

INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (81, 8, CAST(N'2019-08-24T05:31:51.893' AS DateTime), N'Good', N'Tuncay Huseynov', N'tuncayhuseynov@gmail.com', N'My Subject', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (82, 8, CAST(N'2019-08-24T05:33:39.163' AS DateTime), N'Good 2', N'Tuncay Huseynov', N'tuncayhuseynov@gmail.com', N'My Subject', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (83, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (84, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (85, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (86, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (87, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (88, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (89, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (90, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (91, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (92, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (93, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (94, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (95, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (96, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (97, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (98, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (99, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (100, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (101, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (102, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (103, 8, CAST(N'2019-08-24T21:35:19.363' AS DateTime), N'This is a good feedback', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Hello', NULL)
INSERT [dbo].[Feedbacks] ([id], [clientID], [datetime], [message], [name], [email], [subject], [cellPhone]) VALUES (104, 8, CAST(N'2019-08-26T22:14:16.870' AS DateTime), N'Fone', N'Tuncay', N'tuncayhuseynov@gmail.com', N'Okay', NULL)
SET IDENTITY_INSERT [dbo].[Feedbacks] OFF
SET IDENTITY_INSERT [dbo].[LogHistories] ON 

INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (87, 8, CAST(N'2019-08-24T00:30:14.880' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (88, 8, CAST(N'2019-08-24T00:34:32.277' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (89, 8, CAST(N'2019-08-24T00:35:20.567' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (90, 8, CAST(N'2019-08-24T05:16:27.560' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (91, 8, CAST(N'2019-08-24T05:18:22.073' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (92, 8, CAST(N'2019-08-24T05:22:12.503' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (93, 8, CAST(N'2019-08-24T05:23:48.313' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (94, 8, CAST(N'2019-08-24T05:28:27.153' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (95, 8, CAST(N'2019-08-24T05:30:49.863' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (96, 8, CAST(N'2019-08-24T05:31:41.063' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (97, 8, CAST(N'2019-08-24T05:33:17.377' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (98, 8, CAST(N'2019-08-24T18:27:45.260' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (99, 8, CAST(N'2019-08-24T18:30:48.170' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (100, 8, CAST(N'2019-08-24T18:31:58.690' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (101, 8, CAST(N'2019-08-24T18:32:48.287' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (102, 8, CAST(N'2019-08-24T18:36:03.650' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (103, 8, CAST(N'2019-08-24T18:36:51.223' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (104, 8, CAST(N'2019-08-24T18:41:38.637' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (105, 8, CAST(N'2019-08-24T18:42:46.283' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (106, 8, CAST(N'2019-08-24T18:45:51.683' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (107, 8, CAST(N'2019-08-24T19:35:41.067' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (108, 8, CAST(N'2019-08-24T19:39:04.143' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (109, 8, CAST(N'2019-08-24T19:39:32.500' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (110, 8, CAST(N'2019-08-24T19:40:01.937' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (111, 8, CAST(N'2019-08-24T19:42:26.847' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (112, 8, CAST(N'2019-08-24T19:43:53.990' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (113, 8, CAST(N'2019-08-24T20:48:42.637' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (114, 8, CAST(N'2019-08-24T20:50:13.117' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (115, 8, CAST(N'2019-08-24T20:53:25.747' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (116, 8, CAST(N'2019-08-24T20:57:53.000' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (117, 8, CAST(N'2019-08-24T20:58:54.700' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (118, 8, CAST(N'2019-08-24T20:59:29.453' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (119, 8, CAST(N'2019-08-24T21:01:54.030' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (120, 8, CAST(N'2019-08-24T21:05:45.110' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (121, 8, CAST(N'2019-08-24T21:07:31.633' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (122, 8, CAST(N'2019-08-24T21:11:11.650' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (123, 8, CAST(N'2019-08-24T21:12:11.893' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (124, 8, CAST(N'2019-08-24T21:12:45.267' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (125, 8, CAST(N'2019-08-24T21:14:24.940' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (126, 8, CAST(N'2019-08-24T21:16:19.647' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (127, 8, CAST(N'2019-08-24T21:22:51.323' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (128, 8, CAST(N'2019-08-24T21:25:02.597' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (129, 8, CAST(N'2019-08-24T21:25:35.487' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (130, 8, CAST(N'2019-08-24T21:27:49.253' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (131, 8, CAST(N'2019-08-24T21:30:17.343' AS DateTime), N'o         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (132, 8, CAST(N'2019-08-24T21:30:18.497' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (137, 8, CAST(N'2019-08-24T21:34:48.113' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (138, 8, CAST(N'2019-08-24T21:36:00.687' AS DateTime), N'o         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (139, 8, CAST(N'2019-08-24T21:36:01.700' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (140, 8, CAST(N'2019-08-24T22:00:34.913' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (141, 8, CAST(N'2019-08-25T01:06:29.810' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (142, 8, CAST(N'2019-08-25T05:14:54.833' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (143, 8, CAST(N'2019-08-25T15:50:20.707' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (144, 8, CAST(N'2019-08-25T20:42:38.623' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (145, 8, CAST(N'2019-08-25T20:52:13.913' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (146, 8, CAST(N'2019-08-25T21:40:04.330' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (147, 8, CAST(N'2019-08-25T21:43:56.687' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (148, 8, CAST(N'2019-08-25T21:45:28.530' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (149, 8, CAST(N'2019-08-25T21:58:34.777' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (150, 8, CAST(N'2019-08-25T21:59:29.820' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (151, 8, CAST(N'2019-08-25T22:05:57.320' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (152, 8, CAST(N'2019-08-25T22:07:12.350' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (153, 11, CAST(N'2019-08-26T17:39:29.413' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (154, 8, CAST(N'2019-08-26T21:44:44.660' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (155, 8, CAST(N'2019-08-26T22:09:03.853' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (156, 8, CAST(N'2019-08-26T22:10:41.333' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (157, 8, CAST(N'2019-08-26T22:11:08.950' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (158, 8, CAST(N'2019-08-26T22:12:13.110' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (159, 12, CAST(N'2019-08-26T22:47:32.973' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (160, 8, CAST(N'2019-08-26T22:54:32.210' AS DateTime), N'i         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (161, 8, CAST(N'2019-08-26T22:54:36.707' AS DateTime), N'o         ')
INSERT [dbo].[LogHistories] ([id], [clientID], [date], [logStatus]) VALUES (162, 12, CAST(N'2019-08-26T22:54:45.990' AS DateTime), N'i         ')
SET IDENTITY_INSERT [dbo].[LogHistories] OFF
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([id], [ticketID], [subject], [message], [filename], [datetime], [from], [fromID]) VALUES (3, 17, NULL, N'Next problem', NULL, CAST(N'2019-08-24T21:23:19.923' AS DateTime), 1, 8)
INSERT [dbo].[Messages] ([id], [ticketID], [subject], [message], [filename], [datetime], [from], [fromID]) VALUES (4, 17, NULL, N'Message Sent', NULL, CAST(N'2019-08-24T21:25:14.110' AS DateTime), 1, 8)
INSERT [dbo].[Messages] ([id], [ticketID], [subject], [message], [filename], [datetime], [from], [fromID]) VALUES (5, 17, NULL, N'Problem', NULL, CAST(N'2019-08-24T21:25:45.307' AS DateTime), 1, 8)
INSERT [dbo].[Messages] ([id], [ticketID], [subject], [message], [filename], [datetime], [from], [fromID]) VALUES (13, 18, NULL, N'Progressing', NULL, CAST(N'2019-08-25T01:15:22.610' AS DateTime), 0, 1)
INSERT [dbo].[Messages] ([id], [ticketID], [subject], [message], [filename], [datetime], [from], [fromID]) VALUES (14, 18, NULL, N'The Problem Is Done', NULL, CAST(N'2019-08-26T18:00:56.257' AS DateTime), 0, 17)
INSERT [dbo].[Messages] ([id], [ticketID], [subject], [message], [filename], [datetime], [from], [fromID]) VALUES (15, 21, NULL, N'I will Close it', NULL, CAST(N'2019-08-26T18:17:23.823' AS DateTime), 0, 17)
INSERT [dbo].[Messages] ([id], [ticketID], [subject], [message], [filename], [datetime], [from], [fromID]) VALUES (16, 23, NULL, N'Reply', N'C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\wwwroot\files/2019082622511266811_0D7K4JZNABjK2RMQyM5zVQ.png C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\wwwroot\files/2019082622511266983DCartoonPlanetCity7.jpg ', CAST(N'2019-08-26T22:51:12.677' AS DateTime), 1, 12)
INSERT [dbo].[Messages] ([id], [ticketID], [subject], [message], [filename], [datetime], [from], [fromID]) VALUES (17, 23, NULL, N'Right now', NULL, CAST(N'2019-08-26T22:54:00.583' AS DateTime), 0, 1)
SET IDENTITY_INSERT [dbo].[Messages] OFF
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([id], [clientID], [subject], [message], [filename], [status], [datetime], [departmentID]) VALUES (17, 8, N'My Subject', N'Some error', N'C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\wwwroot\files/2019082421020712373DCartoonPlanetCity7.jpg ', N'c         ', CAST(N'2019-08-24T21:02:07.140' AS DateTime), 1)
INSERT [dbo].[Tickets] ([id], [clientID], [subject], [message], [filename], [status], [datetime], [departmentID]) VALUES (18, 8, N'Secon Suject', N'Some PRoblem', NULL, N'c         ', CAST(N'2019-08-24T21:14:48.963' AS DateTime), 1)
INSERT [dbo].[Tickets] ([id], [clientID], [subject], [message], [filename], [status], [datetime], [departmentID]) VALUES (20, 8, N'Third Subject', N'Error', NULL, N'n         ', CAST(N'2019-08-24T21:16:30.253' AS DateTime), 1)
INSERT [dbo].[Tickets] ([id], [clientID], [subject], [message], [filename], [status], [datetime], [departmentID]) VALUES (21, 8, N'Secon Suject', N'The same', NULL, N'p         ', CAST(N'2019-08-24T21:23:01.773' AS DateTime), 1)
INSERT [dbo].[Tickets] ([id], [clientID], [subject], [message], [filename], [status], [datetime], [departmentID]) VALUES (22, 11, N'My Subject', N'Some Kind of problems', NULL, N'n         ', CAST(N'2019-08-26T17:39:46.353' AS DateTime), 1)
INSERT [dbo].[Tickets] ([id], [clientID], [subject], [message], [filename], [status], [datetime], [departmentID]) VALUES (23, 12, N'Unable to Login', N'Unable to login', N'C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\wwwroot\files/2019082622483556081_0D7K4JZNABjK2RMQyM5zVQ.png ', N'n         ', CAST(N'2019-08-26T22:48:35.563' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
ALTER TABLE [dbo].[AmAndDepartaments]  WITH CHECK ADD  CONSTRAINT [AmAndClients_From_Am] FOREIGN KEY([amID])
REFERENCES [dbo].[Admins] ([id])
GO
ALTER TABLE [dbo].[AmAndDepartaments] CHECK CONSTRAINT [AmAndClients_From_Am]
GO
ALTER TABLE [dbo].[AmAndDepartaments]  WITH CHECK ADD  CONSTRAINT [AmAndClients_From_Company] FOREIGN KEY([departamentID])
REFERENCES [dbo].[Companies] ([id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[AmAndDepartaments] CHECK CONSTRAINT [AmAndClients_From_Company]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [Client_created_admin] FOREIGN KEY([createdBy])
REFERENCES [dbo].[Admins] ([id])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [Client_created_admin]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [Client_From_Company] FOREIGN KEY([companyID])
REFERENCES [dbo].[Companies] ([id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [Client_From_Company]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [Client_modified_admin] FOREIGN KEY([lastModifiedBy])
REFERENCES [dbo].[Admins] ([id])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [Client_modified_admin]
GO
ALTER TABLE [dbo].[Companies]  WITH CHECK ADD  CONSTRAINT [Companies_From_Admin] FOREIGN KEY([createdBy])
REFERENCES [dbo].[Admins] ([id])
GO
ALTER TABLE [dbo].[Companies] CHECK CONSTRAINT [Companies_From_Admin]
GO
ALTER TABLE [dbo].[Companies]  WITH CHECK ADD  CONSTRAINT [Companies_Modified_Admin] FOREIGN KEY([lastModifiedBy])
REFERENCES [dbo].[Admins] ([id])
GO
ALTER TABLE [dbo].[Companies] CHECK CONSTRAINT [Companies_Modified_Admin]
GO
ALTER TABLE [dbo].[DepartamentUsers]  WITH CHECK ADD  CONSTRAINT [User_From_Company] FOREIGN KEY([departamentID])
REFERENCES [dbo].[Companies] ([id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DepartamentUsers] CHECK CONSTRAINT [User_From_Company]
GO
ALTER TABLE [dbo].[DepartamentUsers]  WITH CHECK ADD  CONSTRAINT [Users_From_client] FOREIGN KEY([clientID])
REFERENCES [dbo].[Clients] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DepartamentUsers] CHECK CONSTRAINT [Users_From_client]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [Feedbacks_From_Clients] FOREIGN KEY([clientID])
REFERENCES [dbo].[Clients] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [Feedbacks_From_Clients]
GO
ALTER TABLE [dbo].[LogHistories]  WITH CHECK ADD  CONSTRAINT [Histories_From_Clients] FOREIGN KEY([clientID])
REFERENCES [dbo].[Clients] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LogHistories] CHECK CONSTRAINT [Histories_From_Clients]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [Messages_From_Ticket] FOREIGN KEY([ticketID])
REFERENCES [dbo].[Tickets] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [Messages_From_Ticket]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [Tickets_From_Clients] FOREIGN KEY([clientID])
REFERENCES [dbo].[Clients] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [Tickets_From_Clients]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [Tickets_From_Department] FOREIGN KEY([departmentID])
REFERENCES [dbo].[Departments] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [Tickets_From_Department]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Admins"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "AmAndDepartaments"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AmUsers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AmUsers'
GO
USE [master]
GO
ALTER DATABASE [UpWork-08-08-2019] SET  READ_WRITE 
GO
