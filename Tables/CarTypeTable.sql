USE [291_group2]
GO

/****** Object:  Table [dbo].[CarType]    Script Date: 21-Mar-2022 10:19:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CarType](
	[CarTypeID] [varchar](50) NOT NULL,
	[Description] [varchar](50) NULL,
	[DailyRate] [varchar](50) NULL,
	[WeeklyRate] [varchar](50) NULL,
	[MonthlyRate] [varchar](50) NULL,
 CONSTRAINT [PK_CarType] PRIMARY KEY CLUSTERED 
(
	[CarTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

