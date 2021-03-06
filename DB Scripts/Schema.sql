USE [LibraryDemo]
GO
ALTER TABLE [dbo].[LibraryTransaction] DROP CONSTRAINT [FK_LibraryTransaction_LibraryTransactionType]
GO
ALTER TABLE [dbo].[LibraryTransaction] DROP CONSTRAINT [FK_LibraryTransaction_Customer]
GO
ALTER TABLE [dbo].[LibraryTransaction] DROP CONSTRAINT [FK_LibraryTransaction_Book]
GO
ALTER TABLE [dbo].[LibraryTransaction] DROP CONSTRAINT [FK_LibraryTransaction_Author]
GO
ALTER TABLE [dbo].[Book] DROP CONSTRAINT [FK_Book_Author]
GO
ALTER TABLE [dbo].[LibraryTransactionType] DROP CONSTRAINT [DF_LibraryTransactionType_IsActive]
GO
ALTER TABLE [dbo].[LibraryTransactionType] DROP CONSTRAINT [DF_LibraryTransactionType_UpdatedDate]
GO
ALTER TABLE [dbo].[LibraryTransactionType] DROP CONSTRAINT [DF_LibraryTransactionType_CreatedDate]
GO
ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [DF_Customer_IsActive]
GO
ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [DF_Customer_UpdatedDate]
GO
ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [DF_Customer_CreatedDate]
GO
ALTER TABLE [dbo].[Book] DROP CONSTRAINT [DF_Book_IsActive]
GO
ALTER TABLE [dbo].[Book] DROP CONSTRAINT [DF_Book_UpdatedDate]
GO
ALTER TABLE [dbo].[Book] DROP CONSTRAINT [DF_Book_CreatedDate]
GO
ALTER TABLE [dbo].[Author] DROP CONSTRAINT [DF_Author_IsActive]
GO
ALTER TABLE [dbo].[Author] DROP CONSTRAINT [DF_Author_UpdatedDate]
GO
ALTER TABLE [dbo].[Author] DROP CONSTRAINT [DF_Author_CreatedDate]
GO
/****** Object:  Table [dbo].[LibraryTransactionType]    Script Date: 7/7/2017 6:23:04 PM ******/
DROP TABLE [dbo].[LibraryTransactionType]
GO
/****** Object:  Table [dbo].[LibraryTransaction]    Script Date: 7/7/2017 6:23:04 PM ******/
DROP TABLE [dbo].[LibraryTransaction]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/7/2017 6:23:04 PM ******/
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 7/7/2017 6:23:04 PM ******/
DROP TABLE [dbo].[Book]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 7/7/2017 6:23:04 PM ******/
DROP TABLE [dbo].[Author]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 7/7/2017 6:23:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorId] [bigint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL
)
GO
/****** Object:  Table [dbo].[Book]    Script Date: 7/7/2017 6:23:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [bigint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Title] [nvarchar](max) NOT NULL,
	[Isbn] [nchar](20) NOT NULL,
	[AuthorId] [bigint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL
)
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/7/2017 6:23:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [bigint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] [nvarchar](max) NOT NULL,
	[MembershipStartDate] [date] NOT NULL,
	[MembershipEndDate] [date] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL
)
GO
/****** Object:  Table [dbo].[LibraryTransaction]    Script Date: 7/7/2017 6:23:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibraryTransaction](
	[LibraryTransactionId] [bigint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[TransactionTypeId] [smallint] NOT NULL,
	[BookId] [bigint] NULL,
	[AuthorId] [bigint] NULL,
	[CustomerId] [bigint] NULL,
	[TransactionDate] [datetime] NOT NULL,
	[Amount] [money] NULL
)
GO
/****** Object:  Table [dbo].[LibraryTransactionType]    Script Date: 7/7/2017 6:23:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibraryTransactionType](
	[LibraryTransactionTypeId] [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] [nchar](20) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL
)
GO
ALTER TABLE [dbo].[Author] ADD  CONSTRAINT [DF_Author_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Author] ADD  CONSTRAINT [DF_Author_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[Author] ADD  CONSTRAINT [DF_Author_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[LibraryTransactionType] ADD  CONSTRAINT [DF_LibraryTransactionType_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[LibraryTransactionType] ADD  CONSTRAINT [DF_LibraryTransactionType_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[LibraryTransactionType] ADD  CONSTRAINT [DF_LibraryTransactionType_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([AuthorId])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]
GO
ALTER TABLE [dbo].[LibraryTransaction]  WITH CHECK ADD  CONSTRAINT [FK_LibraryTransaction_Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([AuthorId])
GO
ALTER TABLE [dbo].[LibraryTransaction] CHECK CONSTRAINT [FK_LibraryTransaction_Author]
GO
ALTER TABLE [dbo].[LibraryTransaction]  WITH CHECK ADD  CONSTRAINT [FK_LibraryTransaction_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
GO
ALTER TABLE [dbo].[LibraryTransaction] CHECK CONSTRAINT [FK_LibraryTransaction_Book]
GO
ALTER TABLE [dbo].[LibraryTransaction]  WITH CHECK ADD  CONSTRAINT [FK_LibraryTransaction_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[LibraryTransaction] CHECK CONSTRAINT [FK_LibraryTransaction_Customer]
GO
ALTER TABLE [dbo].[LibraryTransaction]  WITH CHECK ADD  CONSTRAINT [FK_LibraryTransaction_LibraryTransactionType] FOREIGN KEY([TransactionTypeId])
REFERENCES [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId])
GO
ALTER TABLE [dbo].[LibraryTransaction] CHECK CONSTRAINT [FK_LibraryTransaction_LibraryTransactionType]
GO
