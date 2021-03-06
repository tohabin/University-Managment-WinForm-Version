USE [master]
GO
/****** Object:  Database [UniversityManagmentTbiDB]    Script Date: 18-12-18 9:38:49 AM ******/
CREATE DATABASE [UniversityManagmentTbiDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UniversityManagmentTbiDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\UniversityManagmentTbiDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UniversityManagmentTbiDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\UniversityManagmentTbiDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityManagmentTbiDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET  MULTI_USER 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [UniversityManagmentTbiDB]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](20) NULL,
	[Name] [varchar](50) NULL,
	[Credit] [decimal](3, 2) NULL,
	[Description] [varchar](100) NULL,
	[DeptId] [int] NULL,
	[Semester] [varchar](20) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CourseAssignToTeacher]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseAssignToTeacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NULL,
	[CourseId] [int] NULL,
	[DeptId] [int] NULL,
 CONSTRAINT [PK_CourseAssignToTeacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EnrollCourse]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnrollCourse](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[CourseId] [int] NULL,
 CONSTRAINT [PK_EnrollCourse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Semester]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Semester](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
 CONSTRAINT [PK_Semester] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[ContactNo] [varchar](20) NULL,
	[Date] [date] NULL,
	[Address] [varchar](100) NULL,
	[DeptId] [int] NULL,
	[RegistraionNo] [varchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](20) NULL,
	[DeptId] [int] NULL,
	[Designation] [varchar](20) NULL,
	[CreditToBeTaken] [decimal](5, 2) NULL,
	[RemainingCredit] [decimal](5, 2) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[CourseAssignToTeacherView]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW  [dbo].[CourseAssignToTeacherView] AS


select ct.Id, ct.TeacherId,ct.CourseId,ct.DeptId,c.Code,c.Name as CourseName,c.Semester,t.Name AS TeacherName  From CourseAssignToTeacher as ct
Inner JOIN Course as c ON c.Id = ct.CourseId
Inner JOIN Teacher as t ON t.Id = ct.TeacherId



GO
/****** Object:  View [dbo].[StudentWithDepartmentViewModel]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW  [dbo].[StudentWithDepartmentViewModel]
AS

SELECT s.Id AS StudentId, s.RegistraionNo, s.Name AS StudentName, s.Email, s.ContactNo, s.Date, s.Address, s.DeptId AS DepartmentId, d.Code, d.Name AS DepartmentName  
FROM Student AS s
INNER JOIN Department AS d
ON s.DeptId = d.Id


GO
/****** Object:  View [dbo].[TeacherWithDepartmentView]    Script Date: 18-12-18 9:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[TeacherWithDepartmentView] AS
SELECT t.Id AS TeacherId, t.Name AS TeacherName, t.Address, t.Email, t.Contact, t.DeptId, t.Designation, t.CreditToBeTaken, d.Code, d.Name AS DeptName
FROM Teacher AS t
INNER JOIN Department AS D
ON T.DeptId = D.Id;


GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([Id], [Code], [Name], [Credit], [Description], [DeptId], [Semester]) VALUES (1, N'Progrming1', N'C Programing', CAST(3.00 AS Decimal(3, 2)), N'compulsory', 1, NULL)
INSERT [dbo].[Course] ([Id], [Code], [Name], [Credit], [Description], [DeptId], [Semester]) VALUES (2, N'Langauge1', N'English', CAST(1.00 AS Decimal(3, 2)), N'optional', 5, NULL)
INSERT [dbo].[Course] ([Id], [Code], [Name], [Credit], [Description], [DeptId], [Semester]) VALUES (3, N'Langauge2', N'Spenish', CAST(1.00 AS Decimal(3, 2)), N'optional', 1, NULL)
INSERT [dbo].[Course] ([Id], [Code], [Name], [Credit], [Description], [DeptId], [Semester]) VALUES (4, N'Programing2', N'C++', CAST(3.00 AS Decimal(3, 2)), N'compulsory', 1, NULL)
INSERT [dbo].[Course] ([Id], [Code], [Name], [Credit], [Description], [DeptId], [Semester]) VALUES (5, N'Math1', N'Matrix', CAST(3.00 AS Decimal(3, 2)), N'compulsory', 5, N'1st')
INSERT [dbo].[Course] ([Id], [Code], [Name], [Credit], [Description], [DeptId], [Semester]) VALUES (7, N'Math2', N'Matrix2', CAST(3.00 AS Decimal(3, 2)), N'compulsory', 1, N'2nd')
INSERT [dbo].[Course] ([Id], [Code], [Name], [Credit], [Description], [DeptId], [Semester]) VALUES (8, N'Math3', N'Linear Algebra', CAST(2.00 AS Decimal(3, 2)), N'Compulsory', 1, N'3rd')
SET IDENTITY_INSERT [dbo].[Course] OFF
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Code], [Name]) VALUES (1, N'CSE', N'Computer Science & Engineering')
INSERT [dbo].[Department] ([Id], [Code], [Name]) VALUES (4, N'EEE', N'Electrical & Electornics Engenieering')
INSERT [dbo].[Department] ([Id], [Code], [Name]) VALUES (5, N'PHARMACY', N'Pharmacy')
INSERT [dbo].[Department] ([Id], [Code], [Name]) VALUES (6, N'PHY', N'Physics')
INSERT [dbo].[Department] ([Id], [Code], [Name]) VALUES (7, N'BBA', N'Bachelor of Business Administration')
INSERT [dbo].[Department] ([Id], [Code], [Name]) VALUES (11, N'MBBS', N'MBBS')
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[EnrollCourse] ON 

INSERT [dbo].[EnrollCourse] ([Id], [StudentId], [CourseId]) VALUES (1, 1, 1)
INSERT [dbo].[EnrollCourse] ([Id], [StudentId], [CourseId]) VALUES (2, 1, 2)
SET IDENTITY_INSERT [dbo].[EnrollCourse] OFF
SET IDENTITY_INSERT [dbo].[Semester] ON 

INSERT [dbo].[Semester] ([Id], [Name]) VALUES (1, N'1st')
INSERT [dbo].[Semester] ([Id], [Name]) VALUES (2, N'2nd')
INSERT [dbo].[Semester] ([Id], [Name]) VALUES (3, N'3rd')
INSERT [dbo].[Semester] ([Id], [Name]) VALUES (4, N'4th')
INSERT [dbo].[Semester] ([Id], [Name]) VALUES (5, N'5th')
INSERT [dbo].[Semester] ([Id], [Name]) VALUES (6, N'6th')
INSERT [dbo].[Semester] ([Id], [Name]) VALUES (7, N'7th')
INSERT [dbo].[Semester] ([Id], [Name]) VALUES (8, N'8th')
SET IDENTITY_INSERT [dbo].[Semester] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (1, N'Toha', N'toha.bin@mail.com', N'01913595121', CAST(0xB73D0B00 AS Date), N'Mehedibag', 1, N'CSE-2018-001')
INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (3, N'Asif', N'asif.uddin@mail.com', N'01811234567', CAST(0xD53D0B00 AS Date), N'ChokBazar', 4, N'EEE-2018-001')
INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (21, N'sakkor', N'sakkor@mail.com', N'01900000000', CAST(0xF13E0B00 AS Date), N'BohdarHat', 1, N'CSE-2018-002')
INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (22, N'Atul', N'atul@gmail.com', N'01910000000', CAST(0xE83E0B00 AS Date), N'Agrrabad', 1, N'CSE-2018-003')
INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (23, N'dsfdfs', N'dfsa', N'dfsa', CAST(0x7B3D0B00 AS Date), N'dfsa', 1, N'CSE-2017-000')
INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (24, N'somrat', N'ghd', N'ghfdhgd', CAST(0x7B3D0B00 AS Date), N'ghdghdf', 1, N'CSE-2017-001')
INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (27, N'fdas', N'fas', N'dfas', CAST(0xE83E0B00 AS Date), N'dfas', 1, N'CSE-2018-004')
INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (28, N'Yesmin Ruma', N'yr@mail.com', N'01910000000', CAST(0xF63E0B00 AS Date), N'chowbazar', 5, N'PHARMACY-2018-000')
INSERT [dbo].[Student] ([Id], [Name], [Email], [ContactNo], [Date], [Address], [DeptId], [RegistraionNo]) VALUES (29, N'Abdul', N'ab@email.com', N'01813456789', CAST(0xF63E0B00 AS Date), N'Khulna', 11, N'abc-2018-000')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([Id], [Name], [Address], [Email], [Contact], [DeptId], [Designation], [CreditToBeTaken], [RemainingCredit]) VALUES (1, N'Hakim', N'Chowbazar', N'hakim@mail.com', N'01910000000', 1, N'Professor', CAST(20.00 AS Decimal(5, 2)), CAST(20.00 AS Decimal(5, 2)))
INSERT [dbo].[Teacher] ([Id], [Name], [Address], [Email], [Contact], [DeptId], [Designation], [CreditToBeTaken], [RemainingCredit]) VALUES (2, N'Mannan', N'Kotowali', N'manan@mail.com', N'01910000000', 1, N'Professor', CAST(12.00 AS Decimal(5, 2)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Teacher] ([Id], [Name], [Address], [Email], [Contact], [DeptId], [Designation], [CreditToBeTaken], [RemainingCredit]) VALUES (3, N'Azhar', N'Chowbazar', N'azhar@mail.com', N'01913595121', 1, N'Lecturer', CAST(15.00 AS Decimal(5, 2)), CAST(15.00 AS Decimal(5, 2)))
INSERT [dbo].[Teacher] ([Id], [Name], [Address], [Email], [Contact], [DeptId], [Designation], [CreditToBeTaken], [RemainingCredit]) VALUES (4, N'Yeasin Arafat', N'Bhodarhat', N'ya@mail.com', N'01910000000', 7, N'Lecturer', CAST(10.00 AS Decimal(5, 2)), CAST(10.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[Teacher] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Department]    Script Date: 18-12-18 9:38:49 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Department] ON [dbo].[Department]
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Department_1]    Script Date: 18-12-18 9:38:49 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Department_1] ON [dbo].[Department]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Student]    Script Date: 18-12-18 9:38:49 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Student] ON [dbo].[Student]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Department] FOREIGN KEY([DeptId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Department]
GO
ALTER TABLE [dbo].[CourseAssignToTeacher]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssignToTeacher_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[CourseAssignToTeacher] CHECK CONSTRAINT [FK_CourseAssignToTeacher_Course]
GO
ALTER TABLE [dbo].[CourseAssignToTeacher]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssignToTeacher_Teacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([Id])
GO
ALTER TABLE [dbo].[CourseAssignToTeacher] CHECK CONSTRAINT [FK_CourseAssignToTeacher_Teacher]
GO
ALTER TABLE [dbo].[EnrollCourse]  WITH CHECK ADD  CONSTRAINT [FK_EnrollCourse_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[EnrollCourse] CHECK CONSTRAINT [FK_EnrollCourse_Course]
GO
ALTER TABLE [dbo].[EnrollCourse]  WITH CHECK ADD  CONSTRAINT [FK_EnrollCourse_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[EnrollCourse] CHECK CONSTRAINT [FK_EnrollCourse_Student]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Department] FOREIGN KEY([DeptId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Department]
GO
USE [master]
GO
ALTER DATABASE [UniversityManagmentTbiDB] SET  READ_WRITE 
GO
