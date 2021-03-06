USE [Empleados]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 04/06/2022 13:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[edad] [smallint] NOT NULL,
	[sueldo] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id], [nombre], [dni], [edad], [sueldo]) VALUES (1, N'Pedro', 72740442, 25, CAST(1450 AS Decimal(18, 0)))
INSERT [dbo].[Empleado] ([id], [nombre], [dni], [edad], [sueldo]) VALUES (2, N'Samuel', 74125896, 35, CAST(1025 AS Decimal(18, 0)))
INSERT [dbo].[Empleado] ([id], [nombre], [dni], [edad], [sueldo]) VALUES (3, N'Jacobo', 85236974, 22, CAST(900 AS Decimal(18, 0)))
INSERT [dbo].[Empleado] ([id], [nombre], [dni], [edad], [sueldo]) VALUES (4, N'Angel', 85479623, 44, CAST(1500 AS Decimal(18, 0)))
INSERT [dbo].[Empleado] ([id], [nombre], [dni], [edad], [sueldo]) VALUES (5, N'Luisa', 85236471, 33, CAST(3000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
