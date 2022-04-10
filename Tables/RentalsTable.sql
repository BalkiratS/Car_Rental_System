USE [291_group2]
GO

/****** Object:  Table [dbo].[Rentals]    Script Date: 07-Apr-2022 4:07:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rentals](
	[TID] [int] NOT NULL,
	[PickupDate] [date] NULL,
	[PickupTime] [time](7) NULL,
	[ReturnDate] [date] NULL,
	[ReturnTime] [time](7) NULL,
	[CID] [int] NULL,
	[VIN] [varchar](50) NULL,
	[PickupBID] [int] NULL,
	[ReturnBID] [int] NULL,
	[RentValueTotal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[TID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_Rentals_Branch] FOREIGN KEY([PickupBID])
REFERENCES [dbo].[Branch] ([BID])
GO

ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_Rentals_Branch]
GO

ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_Rentals_Branch1] FOREIGN KEY([ReturnBID])
REFERENCES [dbo].[Branch] ([BID])
GO

ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_Rentals_Branch1]
GO

ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_Rentals_Car] FOREIGN KEY([VIN])
REFERENCES [dbo].[Car] ([VIN])
GO

ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_Rentals_Car]
GO

ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_Rentals_Customer] FOREIGN KEY([CID])
REFERENCES [dbo].[Customer] ([CID])
GO

ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_Rentals_Customer]
GO

