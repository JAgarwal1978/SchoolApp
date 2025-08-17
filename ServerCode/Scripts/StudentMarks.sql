USE [StudentDB]
GO

/****** Object:  Table [dbo].[StudentMarks]    Script Date: 16/08/2025 08:59:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentMarks](
	[MarkID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[MarksObtained] [decimal](5, 2) NULL,
	[TotalMarks] [decimal](5, 2) NULL,
	[Grade] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MarkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[StudentMarks] ADD  DEFAULT ((100.00)) FOR [TotalMarks]
GO

ALTER TABLE [dbo].[StudentMarks]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO


