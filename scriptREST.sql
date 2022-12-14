Create Database [REST]

/****** Object:  Table [dbo].[Gateway]    Script Date: 9/2/2022 2:13:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gateway](
	[idGateway] [int] IDENTITY(1,1) NOT NULL,
	[uniqueSerialNum] [nvarchar](max) NOT NULL,
	[humanReadable] [nvarchar](max) NULL,
	[IPv4] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Gateway] PRIMARY KEY CLUSTERED 
(
	[idGateway] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PeriphericalDevice]    Script Date: 9/2/2022 2:13:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeriphericalDevice](
	[idPD] [int] IDENTITY(1,1) NOT NULL,
	[UID] [int] NULL,
	[vendor] [nvarchar](max) NULL,
	[dateCreated] [datetime] NULL,
	[idGateway] [int] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_PeriphericalDevice] PRIMARY KEY CLUSTERED 
(
	[idPD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gateway] ON 

INSERT [dbo].[Gateway] ([idGateway], [uniqueSerialNum], [humanReadable], [IPv4]) VALUES (1, N'usn1', N'hr1', N'192.164.201.23')
INSERT [dbo].[Gateway] ([idGateway], [uniqueSerialNum], [humanReadable], [IPv4]) VALUES (2, N'usn2', N'hr2', N'192.164.201.24')
INSERT [dbo].[Gateway] ([idGateway], [uniqueSerialNum], [humanReadable], [IPv4]) VALUES (3, N'usn3', N'hr3', N'192.164.201.25')
INSERT [dbo].[Gateway] ([idGateway], [uniqueSerialNum], [humanReadable], [IPv4]) VALUES (5, N'usn5', NULL, N'192.164.201.30')
INSERT [dbo].[Gateway] ([idGateway], [uniqueSerialNum], [humanReadable], [IPv4]) VALUES (6, N'usn10', N'hr10', N'192.164.201.10')
SET IDENTITY_INSERT [dbo].[Gateway] OFF
GO
SET IDENTITY_INSERT [dbo].[PeriphericalDevice] ON 

INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (1, 123456789, N'cards', CAST(N'2022-08-04T00:00:00.000' AS DateTime), 3, 1)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (2, 987654321, N'mouse', CAST(N'2022-08-11T00:00:00.000' AS DateTime), 3, NULL)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (3, 123654789, N'keyboard', CAST(N'2022-08-12T00:00:00.000' AS DateTime), 3, 0)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (4, 987456321, N'pendrive', CAST(N'2022-07-06T00:00:00.000' AS DateTime), 3, 0)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (5, 321654987, N'hard disk drive', CAST(N'2022-01-20T00:00:00.000' AS DateTime), 3, 1)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (6, 741852963, N'cell phone', CAST(N'2022-02-10T00:00:00.000' AS DateTime), 3, 1)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (7, 147258369, N'SSD', CAST(N'2022-06-17T00:00:00.000' AS DateTime), 3, 0)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (8, 963852741, N'DVD', CAST(N'2022-09-13T00:00:00.000' AS DateTime), 3, 1)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (9, 852741963, N'CD', CAST(N'2022-08-02T00:00:00.000' AS DateTime), 3, 1)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (10, 111111111, N'Extenal HD', CAST(N'2022-08-24T00:00:00.000' AS DateTime), 3, NULL)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (19, 0, N'VENDORusn1-1', CAST(N'2022-06-15T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (20, 32, N'vendor|usn2-1', CAST(N'2022-07-14T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[PeriphericalDevice] ([idPD], [UID], [vendor], [dateCreated], [idGateway], [status]) VALUES (21, 13, N'vendor|usn2-2', CAST(N'2022-09-09T00:00:00.000' AS DateTime), 2, 1)
SET IDENTITY_INSERT [dbo].[PeriphericalDevice] OFF
GO
ALTER TABLE [dbo].[PeriphericalDevice]  WITH CHECK ADD  CONSTRAINT [FK_PeriphericalDevice_Gateway] FOREIGN KEY([idGateway])
REFERENCES [dbo].[Gateway] ([idGateway])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PeriphericalDevice] CHECK CONSTRAINT [FK_PeriphericalDevice_Gateway]
GO
