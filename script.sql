USE [DBSystemIntranet]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 6/07/2019 22:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 6/07/2019 22:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[idCategoria] [int] NULL,
	[PrecioUnitario] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Stock] [int] NULL,
	[Imagen] [varchar](50) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 6/07/2019 22:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NULL,
	[Contrasena] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [varchar](15) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([idCategoria], [Nombre], [Descripcion]) VALUES (1, N'Equipos', N'Informatica')
INSERT [dbo].[Categoria] ([idCategoria], [Nombre], [Descripcion]) VALUES (2, N'Componentes', N'Informatica')
INSERT [dbo].[Categoria] ([idCategoria], [Nombre], [Descripcion]) VALUES (3, N'Perifericos', N'Informatica')
INSERT [dbo].[Categoria] ([idCategoria], [Nombre], [Descripcion]) VALUES (4, N'Telefonia', N'Dispositivos Moviles')
INSERT [dbo].[Categoria] ([idCategoria], [Nombre], [Descripcion]) VALUES (5, N'Tablets', N'Dispositivos Mviles')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (2, 1111, N'Notbook', 1, N'2100', N'Acer Aspire One 521', 15, N'acerA5.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (3, 2222, N'Notbook', 1, N'2500', N'Acer Aspire One 522', 8, N'acerA5.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (4, 3333, N'Notbook', 1, N'2800', N'Acer Aspire One 523', 5, N'acerA5.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (5, 4444, N'Notbook', 1, N'3000', N'Acer Aspire One 524', 13, N'acerA5.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (6, 5555, N'Notbook', 1, N'3200', N'Acer Aspire One 525', 10, N'acerA5.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (7, 6666, N'A-DATA', 2, N'700', N'Acer Disco Duro externo 500 GB', 20, N'acerdisco.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (8, 7777, N'A-DATA', 2, N'850', N'Acer Disco Duro externo 500 GB', 15, N'acerdisco.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (9, 8888, N'A-DATA', 2, N'930', N'DashDrive Choise ', 19, N'choice.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (10, 9999, N'Gaddetpool', 2, N'1200', N'PC-6 IDE a SATA ', 12, N'idesata.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (11, 99991, N'Canon', 3, N'1000', N'Pixma iP2700', 17, N'canon.jpg')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (12, 99992, N'Epson', 3, N'1500', N'Aculaser', 10, N'epson.png')
INSERT [dbo].[Producto] ([idProducto], [Codigo], [Nombre], [idCategoria], [PrecioUnitario], [Descripcion], [Stock], [Imagen]) VALUES (13, 99993, N'Samsung', 4, N'900', N'S10 Plus', 10, N's10.jpg')
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idUsuario], [Email], [Contrasena], [Nombre], [Apellido], [Telefono]) VALUES (1, N'admin@gmail.com', N'123456', N'Administrador', N'Test', N'987564213')
INSERT [dbo].[Usuario] ([idUsuario], [Email], [Contrasena], [Nombre], [Apellido], [Telefono]) VALUES (2, N'example.1@gmail.com', N'12345', N'Limber', N'Mendoza Tolentino', N'976250659')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
/****** Object:  StoredProcedure [dbo].[SP_DBINTRANET_S_PRODUCTO]    Script Date: 6/07/2019 22:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBINTRANET_S_PRODUCTO]
AS
SELECT p.idProducto,p.Codigo,p.Nombre,c.Nombre as nombreC,p.PrecioUnitario,p.Descripcion,p.Stock,p.Imagen
FROM Producto p INNER JOIN Categoria c
ON p.idCategoria=c.idCategoria
GO
/****** Object:  StoredProcedure [dbo].[USP_INTRANETSYSTEM_LOGIN_USUARIO]    Script Date: 6/07/2019 22:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_INTRANETSYSTEM_LOGIN_USUARIO]
@insUsuario varchar(50),
@insContrasena varchar(50)
AS
SELECT u.email, u.contrasena, concat(u.nombre,' ',u.apellido) as nombreCompleto
FROM Usuario u
WHERE u.email = @insUsuario AND u.contrasena = @insContrasena 
GO
