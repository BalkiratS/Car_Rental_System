USE [291_group2]
GO

/****** Object:  Table [dbo].[Car]    Script Date: 21-Mar-2022 10:20:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Car](
	[VIN] [varchar](50) NOT NULL,
	[Make] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Year] [numeric](18, 0) NULL,
	[NumberofSeats] [numeric](18, 0) NULL,
	[Colour] [varchar](50) NULL,
	[InsuranceNumber] [varchar](50) NULL,
	[OdomoeterNumber] [numeric](18, 0) NULL,
	[BID] [varchar](50) NULL,
	[CarType] [varchar](50) NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[VIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

