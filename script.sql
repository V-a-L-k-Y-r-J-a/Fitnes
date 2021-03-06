USE [fitness]
GO
/****** Object:  Table [dbo].[Coach]    Script Date: 20.06.2022 19:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coach](
	[IdCo] [int] IDENTITY(1,1) NOT NULL,
	[FristNam] [nvarchar](50) NOT NULL,
	[LastNam] [nvarchar](50) NOT NULL,
	[Patromym] [nvarchar](50) NOT NULL,
	[Phones] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Coach] PRIMARY KEY CLUSTERED 
(
	[IdCo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessons]    Script Date: 20.06.2022 19:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[IdLessins] [int] IDENTITY(1,1) NOT NULL,
	[TrainingTime] [time](7) NOT NULL,
	[TrainingType] [nvarchar](50) NOT NULL,
	[TrainingDate] [datetime] NOT NULL,
	[IdCo] [int] NOT NULL,
	[IdPer] [int] NOT NULL,
 CONSTRAINT [PK_Lessons] PRIMARY KEY CLUSTERED 
(
	[IdLessins] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 20.06.2022 19:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[IdPer] [int] IDENTITY(1,1) NOT NULL,
	[FristNames] [nvarchar](50) NOT NULL,
	[LastNames] [nvarchar](50) NOT NULL,
	[Patronymics] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](11) NOT NULL,
	[MedicalCart] [nvarchar](50) NOT NULL,
	[TypeTraining] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[IdPer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonList]    Script Date: 20.06.2022 19:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonList](
	[IdList] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[IdLessons] [int] NOT NULL,
	[IdTra] [int] NOT NULL,
 CONSTRAINT [PK_PersonList] PRIMARY KEY CLUSTERED 
(
	[IdList] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Training]    Script Date: 20.06.2022 19:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Training](
	[IdTra] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TrainingPlace] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Training] PRIMARY KEY CLUSTERED 
(
	[IdTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20.06.2022 19:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[FristName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[Post] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Coach] ON 

INSERT [dbo].[Coach] ([IdCo], [FristNam], [LastNam], [Patromym], [Phones], [Description]) VALUES (1, N'Виктория', N'Муравьева', N'Алиевна', N'89234556545', N'Тренер по гимнастики')
SET IDENTITY_INSERT [dbo].[Coach] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([IdPer], [FristNames], [LastNames], [Patronymics], [Phone], [MedicalCart], [TypeTraining]) VALUES (3, N'Анастасия', N'Журавлева', N'Григорьевна', N'89235440989', N'00000011', N'Фитнес')
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
SET IDENTITY_INSERT [dbo].[Training] ON 

INSERT [dbo].[Training] ([IdTra], [Name], [TrainingPlace]) VALUES (1, N'Фитнес', N'500р')
SET IDENTITY_INSERT [dbo].[Training] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([IdUser], [FristName], [LastName], [Patronymic], [Post], [Login], [Pass]) VALUES (1, N'Александра', N'Беркут', N'Алексадровна', N'Администратор', N'Admin', N'admin')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Lessons]  WITH CHECK ADD  CONSTRAINT [FK_Lessons_Coach1] FOREIGN KEY([IdLessins])
REFERENCES [dbo].[Coach] ([IdCo])
GO
ALTER TABLE [dbo].[Lessons] CHECK CONSTRAINT [FK_Lessons_Coach1]
GO
ALTER TABLE [dbo].[Lessons]  WITH CHECK ADD  CONSTRAINT [FK_Lessons_Person1] FOREIGN KEY([IdLessins])
REFERENCES [dbo].[Person] ([IdPer])
GO
ALTER TABLE [dbo].[Lessons] CHECK CONSTRAINT [FK_Lessons_Person1]
GO
ALTER TABLE [dbo].[PersonList]  WITH CHECK ADD  CONSTRAINT [FK_PersonList_Lessons] FOREIGN KEY([IdLessons])
REFERENCES [dbo].[Lessons] ([IdLessins])
GO
ALTER TABLE [dbo].[PersonList] CHECK CONSTRAINT [FK_PersonList_Lessons]
GO
ALTER TABLE [dbo].[PersonList]  WITH CHECK ADD  CONSTRAINT [FK_PersonList_Training1] FOREIGN KEY([IdList])
REFERENCES [dbo].[Training] ([IdTra])
GO
ALTER TABLE [dbo].[PersonList] CHECK CONSTRAINT [FK_PersonList_Training1]
GO
ALTER TABLE [dbo].[PersonList]  WITH CHECK ADD  CONSTRAINT [FK_PersonList_User1] FOREIGN KEY([IdList])
REFERENCES [dbo].[User] ([IdUser])
GO
ALTER TABLE [dbo].[PersonList] CHECK CONSTRAINT [FK_PersonList_User1]
GO
