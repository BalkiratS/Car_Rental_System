USE [291_group2]
GO

/****** Object:  Table [dbo].[CarType]    Script Date: 2022-04-12 12:27:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CarType](
	[CarTypeID] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[DailyRate] [decimal](18, 2) NULL,
	[WeeklyRate] [decimal](18, 2) NULL,
	[MonthlyRate] [decimal](18, 2) NULL,
 CONSTRAINT [PK_CarType] PRIMARY KEY CLUSTERED 
(
	[CarTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

