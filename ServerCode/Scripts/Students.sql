USE [StudentDB]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 16/08/2025 08:57:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[Gender] [char](1) NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](15) NULL,
	[Address] [nvarchar](255) NULL,
	[CityID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO


