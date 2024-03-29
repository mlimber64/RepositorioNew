USE [DBTest]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[ApellidoPaterno] [varchar](50) NULL,
	[ApellidoMaterno] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[DNI] [int] NULL,
	[Activo] [bit] NULL,
	[FechaCreacion] [varchar](50) NULL,
	[FechaActualizacion] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[IdVenta] [int] NULL,
	[idProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[Precio] [varchar](50) NULL,
	[Total] [varchar](50) NULL,
	[FechaCreacion] [varchar](50) NULL,
	[FechaActulizacion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[idTipo] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[PrecioCompra] [varchar](50) NULL,
	[PrecioVenta] [varchar](50) NULL,
	[StockActual] [varchar](50) NULL,
	[StockMin] [varchar](50) NULL,
	[Activo] [bit] NULL,
	[FechaCreacion] [varchar](50) NULL,
	[FechaActualizacion] [varchar](50) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Activo] [bit] NULL,
	[FechaCreacion] [varchar](50) NULL,
	[FechaActualizacion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/08/2019 01:40:57 ******/
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
	[Telefono] [int] NULL,
	[DNI] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NULL,
	[Total] [varchar](50) NULL,
	[Activo] [bit] NULL,
	[FechaCreacion] [varchar](50) NULL,
	[FechaActualizacion] [varchar](50) NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [Telefono], [DNI], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (1, N'Juan', N'Perez', N'Martinez', 44258963, 78521436, 1, NULL, NULL)
INSERT [dbo].[Cliente] ([idCliente], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [Telefono], [DNI], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (2, N'Luis', N'Sanchez', N'Vasquez', 44659874, 32569842, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
INSERT [dbo].[DetalleVenta] ([IdVenta], [idProducto], [Cantidad], [Precio], [Total], [FechaCreacion], [FechaActulizacion]) VALUES (1, 1, 2, N'265', N'530', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([idProducto], [idTipo], [Nombre], [Descripcion], [PrecioCompra], [PrecioVenta], [StockActual], [StockMin], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (1, 2, N'Samsung', N'Samsung', N'250', N'265', N'10', N'5', 1, NULL, NULL)
INSERT [dbo].[Producto] ([idProducto], [idTipo], [Nombre], [Descripcion], [PrecioCompra], [PrecioVenta], [StockActual], [StockMin], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (2, 1, N'Lenovo', N'15'' A9', N'2000', N'2500', N'15', N'3', 1, NULL, NULL)
INSERT [dbo].[Producto] ([idProducto], [idTipo], [Nombre], [Descripcion], [PrecioCompra], [PrecioVenta], [StockActual], [StockMin], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (1002, 2, N'lenovo', N'Disco Duro 1TB, 8GB RAM', N'2600', N'2950', N'20', N'2', 1, NULL, NULL)
INSERT [dbo].[Producto] ([idProducto], [idTipo], [Nombre], [Descripcion], [PrecioCompra], [PrecioVenta], [StockActual], [StockMin], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (1003, 1, N'Dell', N'aaaa', N'123', N'1234', N'12', N'34', 1, NULL, NULL)
INSERT [dbo].[Producto] ([idProducto], [idTipo], [Nombre], [Descripcion], [PrecioCompra], [PrecioVenta], [StockActual], [StockMin], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (1004, 2, N'HP', N'15'' Disco 1TB', N'2600', N'2750', N'10', N'25', 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[TipoProducto] ON 

INSERT [dbo].[TipoProducto] ([idTipo], [Nombre], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (1, N'PC', 1, NULL, NULL)
INSERT [dbo].[TipoProducto] ([idTipo], [Nombre], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (2, N'Laptop', 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TipoProducto] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idUsuario], [Email], [Contrasena], [Nombre], [Apellido], [Telefono], [DNI]) VALUES (1, N'admin@gmail.com', N'123456', N'Administrador', N'Test', 987564213, 32146587)
INSERT [dbo].[Usuario] ([idUsuario], [Email], [Contrasena], [Nombre], [Apellido], [Telefono], [DNI]) VALUES (2, N'example.1@gmail.com', N'12345', N'Limber', N'Mendoza Tolentino', 976250657, 96325148)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([idVenta], [idCliente], [Total], [Activo], [FechaCreacion], [FechaActualizacion]) VALUES (1, 1, N'5000', 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Venta] OFF
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Venta] ([idVenta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TipoProducto] FOREIGN KEY([idTipo])
REFERENCES [dbo].[TipoProducto] ([idTipo])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_TipoProducto]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_BUSCARXDNI_CLIENTE]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_BUSCARXDNI_CLIENTE](
@filDNI int
)
AS
SELECT idCliente,CONCAT(Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno)as apellidos,DNI
FROM Cliente
WHERE DNI=@filDNI
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_I_CLIENTE]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_I_CLIENTE](
@insnombre varchar(50),
@insappat varchar(50),
@insapmat varchar(50),
@instelf int,
@insdni int
)
AS
INSERT Cliente(Nombre,ApellidoPaterno,ApellidoMaterno,Telefono,DNI)
VALUES(@insnombre,@insappat,@insapmat,@instelf,@insdni)
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_I_PRODUCTO]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_I_PRODUCTO](
@instipo int,
@insnombre varchar(50),
@insdesc varchar(50),
@insprcom varchar(50),
@insprvent varchar(50),
@insstockact varchar(50),
@insstockmin varchar(50)
)AS
INSERT Producto(idTipo,Nombre,Descripcion,PrecioCompra,PrecioVenta,StockActual,StockMin)
VALUES(@instipo,@insnombre,@insdesc,@insprcom,@insprvent,@insstockact,@insstockmin)
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_S_CLIENTE]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_S_CLIENTE]
AS
SELECT idCliente,Nombre,CONCAT(ApellidoPaterno,'  ',ApellidoMaterno)as nomCom,Telefono,DNI
FROM Cliente
ORDER BY idCliente
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_S_COMBOPRODUCTO]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_S_COMBOPRODUCTO](
@cboid int
)
AS
SELECT idProducto,Nombre
FROM Producto
WHERE idTipo = @cboid
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_S_DETALLEVENTA]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_S_DETALLEVENTA]
AS
SELECT detv.IdVenta,p.Nombre,detv.Cantidad,detv.Precio,detv.Total
FROM DetalleVenta detv INNER JOIN Venta v 
ON detv.IdVenta = v.idVenta INNER JOIN Producto p
ON detv.idProducto = p.idProducto
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_S_PRODUCTO]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_S_PRODUCTO]
AS
SELECT p.idProducto,tp.Nombre as Tipo,p.Nombre,p.Descripcion,p.PrecioCompra,p.PrecioVenta,p.StockActual,p.StockMin
FROM Producto p INNER JOIN TipoProducto tp
ON p.idTipo = tp.idTipo
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_S_TIPOPRODUCTO]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_S_TIPOPRODUCTO]
AS
SELECT idTipo,Nombre
FROM TipoProducto
ORDER BY idTipo
GO
/****** Object:  StoredProcedure [dbo].[SP_DBTEST_S_VENTA]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DBTEST_S_VENTA]
AS
SELECT vta.idVenta,CONCAT(clt.Nombre,' ',clt.ApellidoPaterno,' ',clt.ApellidoMaterno)as apellido,vta.Total
FROM Venta vta INNER JOIN Cliente clt
ON vta.idCliente = clt.idCliente
GO
/****** Object:  StoredProcedure [dbo].[USP_DBTEST_LOGIN_USUARIO]    Script Date: 3/08/2019 01:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_DBTEST_LOGIN_USUARIO]
@insUsuario varchar(50),
@insContrasena varchar(50)
AS
SELECT u.email, u.contrasena, concat(u.nombre,' ',u.apellido) as nombreCompleto
FROM Usuario u
WHERE u.email = @insUsuario AND u.contrasena = @insContrasena 
GO
