USE [291_group2]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 21-Mar-2022 10:21:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[CID] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Phonenumber] [varchar](50) NULL,
	[DateofBirth] [date] NULL,
	[Street_address1] [varchar](50) NULL,
	[Street_address2] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Province] [varchar](50) NULL,
	[PostalCode] [varchar](50) NULL,
	[Insurance] [varchar](50) NULL,
	[Membership] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

