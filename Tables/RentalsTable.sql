USE [291_group2]
GO

/****** Object:  Table [dbo].[Rentals]    Script Date: 21-Mar-2022 10:21:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rentals](
	[TID] [varchar](50) NOT NULL,
	[PickupDate] [date] NULL,
	[PickupTime] [time](7) NULL,
	[ReturnDate] [date] NULL,
	[ReturnTime] [time](7) NULL,
	[CustomerID] [varchar](50) NULL,
	[VIN] [varchar](50) NULL,
	[PickupBID] [varchar](50) NULL,
	[ReturnBID] [varchar](50) NULL,
	[RentValueTotal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[TID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

