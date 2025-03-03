USE [Proyecto_FinalP2]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[idClient] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](20) NOT NULL,
	[Cedula] [varchar](15) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Celular] [varchar](20) NOT NULL,
	[Usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Celular] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[idFactura] [int] IDENTITY(0,1) NOT NULL,
	[TotalPago] [money] NOT NULL,
	[InteresTotal] [decimal](18, 0) NOT NULL,
	[Prestamo] [int] NOT NULL,
	[Cliente] [int] NOT NULL,
	[Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prestamos](
	[idPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[Interes] [int] NOT NULL,
	[Tiempo] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[idUsuario] [int] NULL,
	[idCliente] [int] NULL,
	[estado] [varchar](20) NOT NULL,
	[monto] [money] NULL,
	[pagoextra] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUser] [int] IDENTITY(0,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Estado] [varchar](8) NOT NULL,
	[Acceso] [varchar](20) NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[Clave] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Prestamos] ADD  DEFAULT ('Prestamo Activo') FOR [estado]
GO
ALTER TABLE [dbo].[Prestamos] ADD  DEFAULT ((0)) FOR [pagoextra]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [fk_usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuarios] ([idUser])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [fk_usuario]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [fk_cli] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Clientes] ([idClient])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [fk_cli]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [fk_pre] FOREIGN KEY([Prestamo])
REFERENCES [dbo].[Prestamos] ([idPrestamo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [fk_pre]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [fk_us] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuarios] ([idUser])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [fk_us]
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [fk_cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([idClient])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [fk_cliente]
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [fk_user] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUser])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [fk_user]
GO
/****** Object:  StoredProcedure [dbo].[AnularPrestamo]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AnularPrestamo]
@idPrestamo int
as 
update Prestamos set estado='Prestamo Anulado' Where idPrestamo=@idPrestamo

GO
/****** Object:  StoredProcedure [dbo].[BuscarCliente]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarCliente]
@nombre varchar(20)
as 
Select * From Clientes 
Where Nombre like @nombre+ '%'

GO
/****** Object:  StoredProcedure [dbo].[BuscarPrestamoID]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarPrestamoID]
@id int
as
Select p.idPrestamo as ID,c.Cedula, c.Nombre+' '+c.Apellido as Cliente,p.monto as Monto
,p.Interes,p.Fecha as 'Fecha Prestamo',p.Tiempo as 'Periodo en Años',p.estado as 'Estado del Prestamo',p.pagoextra as 'Pagos Adicionales', u.Nombre as Empleado
from Clientes  c
Inner join Prestamos p on c.idClient=p.idCliente
inner join Usuarios u on p.idUsuario=u.idUser
where p.idPrestamo = @id

GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuario]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Buscar Usuarios
create procedure [dbo].[BuscarUsuario]
@nombreUsuario varchar(50)
as 
Select * From Usuarios Where Nombre like '%'+@nombreUsuario +'%'

GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarCliente]
@id int
as
delete from Clientes Where idClient=@id

GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarUsuario]
@id int
as
delete from Usuarios Where idUser=@id

GO
/****** Object:  StoredProcedure [dbo].[ExportarClientes]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ExportarClientes]
as
Select idClient as ID,Cedula,Nombre,Apellido,FechaNacimiento,Edad,Direccion,Telefono,Celular From Clientes
order by idClient asc
GO
/****** Object:  StoredProcedure [dbo].[ExportarPrestamos]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ExportarPrestamos]
as
Select c.Cedula, c.Nombre+' '+c.Apellido,p.monto 
,p.Interes,p.Fecha,p.Tiempo,p.estado,p.pagoextra, u.Nombre
from Clientes  c
Inner join Prestamos p on c.idClient=p.idCliente
inner join Usuarios u on p.idUsuario=u.idUser
order by p.idPrestamo asc
GO
/****** Object:  StoredProcedure [dbo].[ExportarUsuarios]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ExportarUsuarios]
as
Select idUser as ID,Nombre,Correo,Estado,Acceso,Usuario,Clave From Usuarios
order by ID asc
GO
/****** Object:  StoredProcedure [dbo].[GenerarFactura]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GenerarFactura]
@cedula varchar(15)
as
Select c.Cedula, c.Nombre+' '+c.Apellido as Cliente,c.Direccion,c.Telefono,c.Celular,p.monto
,p.Interes,p.Fecha,p.Tiempo ,p.pagoextra , u.Nombre, f.TotalPago ,f.InteresTotal
from Clientes  c
Inner join Prestamos p on c.idClient=p.idCliente
inner join Usuarios u on p.idUsuario=u.idUser
inner Join Factura f on p.idPrestamo = f.Prestamo
where c.Cedula = @cedula

GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarCliente]
@nombre varchar(20),@apellido varchar(20),@cedula varchar(15),@fecha dateTime,@edad int,@direccion varchar(100),@telefono varchar(20),
@celular varchar(20)
as
Insert into Clientes(Nombre,Apellido,Cedula,FechaNacimiento,Edad,Direccion,Telefono,Celular) Values(@nombre,@apellido,@cedula,@fecha,@edad,@direccion,@telefono,@celular)

GO
/****** Object:  StoredProcedure [dbo].[InsertarFactura]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarFactura]
@pago money,@interes decimal,@idPrestamo int,@idCliente int,@idUsuario int
as
insert into Factura(TotalPago,InteresTotal,Prestamo,Cliente,Usuario)values(@pago,@interes,@idPrestamo,@idCliente,@idUsuario) 

GO
/****** Object:  StoredProcedure [dbo].[InsertarPrestamo]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarPrestamo]
@interes int,@tiempo int,@fecha datetime,
@idUsuario int, @idCliente int, @estado varchar(20),@monto money
as 
insert into Prestamos (Interes,Tiempo,Fecha,idUsuario,idCliente,estado,monto)
 Values(@interes,@tiempo,@fecha,@idUsuario,@idCliente,@estado,@monto)

GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarUsuario]
@nombre varchar(50),@correo varchar(50),@estado varchar(8),@acceso varchar(20),@usuario varchar(20),@clave varchar(100)
as
Insert into Usuarios (Nombre,Correo,Estado,Acceso,Usuario,Clave) Values(@nombre,@correo,@estado,@acceso,@usuario,@clave)

GO
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarCliente]
@id int ,@nombre varchar(20),@apellido varchar(20),@cedula varchar(15),@fecha dateTime,@edad int,@direccion varchar(100),@telefono varchar(10),
@celular varchar(10)
as
Update Clientes set Nombre=@nombre,Apellido=@apellido,Cedula=@cedula,FechaNacimiento=@fecha,Edad=@edad,Direccion=@direccion,Telefono=@telefono,Celular=@celular
where idClient=@id

GO
/****** Object:  StoredProcedure [dbo].[ModificarPrestamo]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarPrestamo]
@id int,@interes int,@tiempo int,@fecha datetime,@idUsuario int,
 @idCliente int,@estado varchar(20), @monto money
as 
Update Prestamos set Interes=@interes,Tiempo=@tiempo,Fecha=@fecha,
idUsuario=@idUsuario,idCliente=@idCliente,estado=@estado,monto=@monto
Where idPrestamo=@id

GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarUsuario]
@id int,@nombre varchar(50),@correo varchar(50),@estado varchar(8),@acceso varchar(20),@usuario varchar(20),@clave varchar(100)
as
Update Usuarios set Nombre=@nombre, Correo=@correo,  Estado=@estado, Acceso=@acceso,Usuario=@usuario, Clave=@clave
Where idUser = @id;

GO
/****** Object:  StoredProcedure [dbo].[MostrarPrestamos]    Script Date: 22/03/2020 16:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarPrestamos]
as
Select p.idPrestamo as ID,p.idCliente as 'ID Cliente',c.Cedula, c.Nombre+' '+c.Apellido as Cliente,p.monto as Monto
,p.Interes,p.Fecha as 'Fecha Prestamo',p.Tiempo as 'Periodo en Años',p.estado as 'Estado del Prestamo',p.pagoextra as 'Pagos Adicionales', u.Nombre as Empleado
from Clientes  c
Inner join Prestamos p on c.idClient=p.idCliente
inner join Usuarios u on p.idUsuario=u.idUser
order by p.Fecha asc

GO
