USE [291_group2]
GO

/****** Object:  Table [dbo].[Branch]    Script Date: 07-Apr-2022 4:07:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Branch](
	[BID] [int] NOT NULL,
	[Description] [varchar](50) NULL,
	[Street_address1] [varchar](50) NULL,
	[Street_address2] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Province] [varchar](50) NULL,
	[PostalCode] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[BID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

