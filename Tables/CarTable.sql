USE [291_group2]
GO

/****** Object:  Table [dbo].[Car]    Script Date: 07-Apr-2022 4:07:42 PM ******/
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
	[Color] [varchar](50) NULL,
	[InsuranceNumber] [varchar](50) NULL,
	[OdometerNumber] [numeric](18, 0) NULL,
	[BID] [int] NULL,
	[CarTypeID] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[VIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Branch] FOREIGN KEY([BID])
REFERENCES [dbo].[Branch] ([BID])
GO

ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Branch]
GO

ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Car] FOREIGN KEY([VIN])
REFERENCES [dbo].[Car] ([VIN])
GO

ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Car]
GO

ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_CarType] FOREIGN KEY([CarTypeID])
REFERENCES [dbo].[CarType] ([CarTypeID])
GO

ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_CarType]
GO

