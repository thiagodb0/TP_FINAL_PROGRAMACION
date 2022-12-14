USE [master]
GO
/****** Object:  Database [AUTOMOTRIZ]    Script Date: 09/11/2022 15:15:17 ******/
CREATE DATABASE [AUTOMOTRIZ]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AUTOMOTRIZ', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AUTOMOTRIZ.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AUTOMOTRIZ_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AUTOMOTRIZ_log.ldf' , SIZE = 1600KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AUTOMOTRIZ] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AUTOMOTRIZ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AUTOMOTRIZ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET ARITHABORT OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AUTOMOTRIZ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AUTOMOTRIZ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AUTOMOTRIZ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AUTOMOTRIZ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AUTOMOTRIZ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AUTOMOTRIZ] SET  MULTI_USER 
GO
ALTER DATABASE [AUTOMOTRIZ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AUTOMOTRIZ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AUTOMOTRIZ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AUTOMOTRIZ] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AUTOMOTRIZ] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AUTOMOTRIZ]
GO
/****** Object:  Table [dbo].[barrios]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[barrios](
	[cod_barrio] [int] IDENTITY(1,1) NOT NULL,
	[cod_localidad] [int] NULL,
	[barrio] [varchar](80) NULL,
 CONSTRAINT [pk_cod_barrio] PRIMARY KEY CLUSTERED 
(
	[cod_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[cod_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nom_cliente] [nvarchar](50) NOT NULL,
	[ape_cliente] [nvarchar](50) NOT NULL,
	[calle] [nvarchar](50) NOT NULL,
	[altura] [int] NULL,
	[cod_barrio] [int] NOT NULL,
	[cod_tipo_doc] [int] NULL,
	[cod_tipo_cliente] [int] NULL,
	[documento] [int] NULL,
	[nro_tel] [bigint] NULL,
	[e-mail] [nvarchar](50) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[cod_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_factura]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_factura](
	[cod_detalle_factura] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NULL,
	[precio_venta] [money] NULL,
	[cod_factura] [int] NULL,
	[cod_producto] [int] NOT NULL,
 CONSTRAINT [PK_detalle_factura] PRIMARY KEY CLUSTERED 
(
	[cod_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[factura]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[factura](
	[cod_factura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cod_cliente] [int] NULL,
	[cod_forma_pago] [int] NOT NULL,
	[cod_plan] [int] NOT NULL,
	[cod_vendedor] [int] NULL,
	[estado] [varchar](20) NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[cod_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[forma_pago]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[forma_pago](
	[cod_forma_pago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](80) NULL,
 CONSTRAINT [pk_id_forma_pago] PRIMARY KEY CLUSTERED 
(
	[cod_forma_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[localidades]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[localidades](
	[cod_localidad] [int] IDENTITY(1,1) NOT NULL,
	[cod_provincia] [int] NULL,
	[localidad] [varchar](100) NULL,
 CONSTRAINT [pk_cod_localidad] PRIMARY KEY CLUSTERED 
(
	[cod_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marcas]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marcas](
	[cod_marca] [int] NOT NULL,
	[marca] [varchar](100) NULL,
 CONSTRAINT [pk_id_marca] PRIMARY KEY CLUSTERED 
(
	[cod_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modelos]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modelos](
	[cod_modelo] [int] NOT NULL,
	[modelo] [varchar](100) NULL,
 CONSTRAINT [pk_id_modelo] PRIMARY KEY CLUSTERED 
(
	[cod_modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PEDIDOS]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS](
	[cod_pedido] [int] IDENTITY(1,1) NOT NULL,
	[nro_factura] [int] NULL,
	[cod_producto] [int] NULL,
	[cantidad] [int] NULL,
	[fecha_entrega] [datetime] NULL,
 CONSTRAINT [pk_cod_pedido] PRIMARY KEY CLUSTERED 
(
	[cod_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[planes]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[planes](
	[cod_plan] [int] IDENTITY(1,1) NOT NULL,
	[cant_cuotas] [int] NULL,
	[interes_mens] [decimal](6, 2) NULL,
 CONSTRAINT [pk_cod_plan] PRIMARY KEY CLUSTERED 
(
	[cod_plan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[productos]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productos](
	[cod_producto] [int] NOT NULL,
	[descripcion] [varchar](100) NULL,
	[pre_unitario] [money] NULL,
	[cod_tipo_prod] [int] NULL,
	[stock] [int] NULL,
	[stock_min] [int] NULL,
	[cod_modelo] [int] NULL,
	[cod_marca] [int] NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [pk_cod_producto] PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincias](
	[cod_provincia] [int] IDENTITY(1,1) NOT NULL,
	[provincia] [varchar](50) NULL,
 CONSTRAINT [pk_cod_provincia] PRIMARY KEY CLUSTERED 
(
	[cod_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_cliente]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_cliente](
	[cod_tipo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](80) NULL,
 CONSTRAINT [pk_cod_tipocliente] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_prod]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_prod](
	[cod_tipo_prod] [int] NOT NULL,
	[descripcion] [varchar](200) NULL,
 CONSTRAINT [pk_cod_tipo_prod] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipos_doc]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_doc](
	[cod_tipo_doc] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](80) NULL,
 CONSTRAINT [pk_cod_tipo_doc] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[usuario] [varchar](100) NULL,
	[contraseña] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vendedores]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vendedores](
	[cod_vendedor] [int] NOT NULL,
	[nombre] [varchar](80) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[cod_barrio] [int] NOT NULL,
	[tipo_doc] [int] NOT NULL,
	[nro_doc] [bigint] NOT NULL,
	[calle] [varchar](100) NOT NULL,
	[altura] [int] NULL,
 CONSTRAINT [pk_cod_vendedor] PRIMARY KEY CLUSTERED 
(
	[cod_vendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[barrios]  WITH CHECK ADD  CONSTRAINT [fk_cod_localidad] FOREIGN KEY([cod_localidad])
REFERENCES [dbo].[localidades] ([cod_localidad])
GO
ALTER TABLE [dbo].[barrios] CHECK CONSTRAINT [fk_cod_localidad]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_barrios] FOREIGN KEY([cod_barrio])
REFERENCES [dbo].[barrios] ([cod_barrio])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_barrios]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_tipo_cliente] FOREIGN KEY([cod_tipo_cliente])
REFERENCES [dbo].[tipo_cliente] ([cod_tipo_cliente])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_tipo_cliente]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_tipo_documento] FOREIGN KEY([cod_tipo_doc])
REFERENCES [dbo].[tipos_doc] ([cod_tipo_doc])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_tipo_documento]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [FK_detalle_factura_factura] FOREIGN KEY([cod_factura])
REFERENCES [dbo].[factura] ([cod_factura])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [FK_detalle_factura_factura]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [FK_detalle_factura_producto] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[productos] ([cod_producto])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [FK_detalle_factura_producto]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_cliente] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[clientes] ([cod_cliente])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_cliente]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_forma_pago] FOREIGN KEY([cod_forma_pago])
REFERENCES [dbo].[forma_pago] ([cod_forma_pago])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_forma_pago]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_planes] FOREIGN KEY([cod_plan])
REFERENCES [dbo].[planes] ([cod_plan])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_planes]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_vendedores] FOREIGN KEY([cod_vendedor])
REFERENCES [dbo].[vendedores] ([cod_vendedor])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_vendedores]
GO
ALTER TABLE [dbo].[localidades]  WITH CHECK ADD  CONSTRAINT [fk_cod_provincia] FOREIGN KEY([cod_provincia])
REFERENCES [dbo].[Provincias] ([cod_provincia])
GO
ALTER TABLE [dbo].[localidades] CHECK CONSTRAINT [fk_cod_provincia]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [fk_nro_factura] FOREIGN KEY([nro_factura])
REFERENCES [dbo].[factura] ([cod_factura])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [fk_nro_factura]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [fk_producto] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[productos] ([cod_producto])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [fk_producto]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_cod_marca] FOREIGN KEY([cod_marca])
REFERENCES [dbo].[marcas] ([cod_marca])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_cod_marca]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_cod_modelo] FOREIGN KEY([cod_modelo])
REFERENCES [dbo].[modelos] ([cod_modelo])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_cod_modelo]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_tipo_prod] FOREIGN KEY([cod_tipo_prod])
REFERENCES [dbo].[tipo_prod] ([cod_tipo_prod])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_tipo_prod]
GO
ALTER TABLE [dbo].[vendedores]  WITH CHECK ADD  CONSTRAINT [fk_cod_barrio] FOREIGN KEY([cod_barrio])
REFERENCES [dbo].[barrios] ([cod_barrio])
GO
ALTER TABLE [dbo].[vendedores] CHECK CONSTRAINT [fk_cod_barrio]
GO
ALTER TABLE [dbo].[vendedores]  WITH CHECK ADD  CONSTRAINT [fk_tipo_doc] FOREIGN KEY([tipo_doc])
REFERENCES [dbo].[tipos_doc] ([cod_tipo_doc])
GO
ALTER TABLE [dbo].[vendedores] CHECK CONSTRAINT [fk_tipo_doc]
GO
/****** Object:  StoredProcedure [dbo].[AutosSinVender]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AutosSinVender]
as
select p.descripcion, pre_unitario,tp.descripcion,stock,stock_min,marca
 from productos p join tipo_prod tp on tp.cod_tipo_prod=p.cod_tipo_prod
join Marcas M on M.cod_Marca=p.cod_Marca
join Modelos Mo on Mo.cod_modelo=p.cod_modelo 
 where p.cod_producto not in (select d.cod_producto from detalle_factura d)
 and p.cod_tipo_prod = 1
GO
/****** Object:  StoredProcedure [dbo].[clientesCantCompras]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[clientesCantCompras]
@cant int
as
select c.ape_cliente+' '+c.nom_cliente cliente,calle,altura,barrio 
 from clientes c join barrios b on b.cod_barrio=c.cod_barrio
 where @cant< ( select count (*)
				from factura f
				where f.cod_cliente = c.cod_cliente )
GO
/****** Object:  StoredProcedure [dbo].[ClientesPromedio]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClientesPromedio]
@nombre varchar(20)
as
select c.cod_cliente 'Codigo', c.nom_cliente + ' ' + c.ape_cliente 'Cliente',
sum(cantidad*precio_venta) 'Total', sum(cantidad*precio_venta)/ count(distinct 
f.cod_factura) 'Promedio'
, min(fecha) 'Primera'
from clientes c join factura f on f.cod_cliente = c.cod_cliente
join detalle_factura df on df.cod_factura = f.cod_factura
where c.nom_cliente like @nombre+'%'
group by c.cod_cliente, c.nom_cliente, c.ape_cliente
GO
/****** Object:  StoredProcedure [dbo].[FacturadoXVendedor]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FacturadoXVendedor]
as
select year(fecha) 'Año', month(fecha) 'Mes',v.apellido+' '+v.nombre 
'Vendedor',sum(cantidad * precio_venta) 'Total', 
sum(cantidad*precio_venta) / count(distinct f.cod_factura) 'Promedio'
from factura f join detalle_factura df on df.cod_factura = f.cod_factura
join Vendedores v on v.cod_Vendedor=f.cod_vendedor
group by year(fecha), month(fecha),v.cod_vendedor,v.apellido+' '+v.nombre 
GO
/****** Object:  StoredProcedure [dbo].[FechaVendedores]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FechaVendedores]
@cod int
as
select v.nombre + ' ' +v.apellido 'Nombre',min(fecha)'Primera',max(fecha) 'Ultima'
from factura f 
join vendedores v on v.cod_vendedor=f.cod_vendedor
where f.cod_vendedor =  @cod
group by v.nombre,v.apellido 
GO
/****** Object:  StoredProcedure [dbo].[PA_BAJA_FACT]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_BAJA_FACT]
@nro int
as
begin 
update factura 
set estado = 'Baja'
where cod_factura = @nro
end
GO
/****** Object:  StoredProcedure [dbo].[PA_BAJA_PROD]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_BAJA_PROD]
@nro int
as
begin
update productos
set estado = 'Baja'
where cod_producto = @nro
end
GO
/****** Object:  StoredProcedure [dbo].[PA_CAROS_BARATOS]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_CAROS_BARATOS]
as
begin
declare @cantCaros int
declare @cantBaratos int
select @cantCaros = count(cod_producto) from productos where pre_unitario > ( select avg(pre_unitario) from productos)
select @cantBaratos = count(cod_producto) from productos where pre_unitario < ( select avg(pre_unitario) from productos)
end
select @cantCaros, @cantBaratos
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_BARRIOS_CBA]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[PA_CONS_BARRIOS_CBA]
as
begin
select cod_barrio, barrio
from barrios
where cod_localidad = 543
end
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_CLIENTES]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PA_CONS_CLIENTES]
	as
	begin 
	select cod_cliente, nom_cliente + ' ' + ape_cliente as nom_cliente from clientes
	end
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_FACTURAS]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[PA_CONS_FACTURAS]
as
begin 
select cod_factura  ,fecha, c.cod_cliente ,nom_cliente + ' ' + ape_cliente 'Cliente', v.cod_vendedor, nombre + ' ' + apellido 'Vendedor'
, fp.cod_forma_pago, descripcion
from factura f join clientes c on c.cod_cliente = f.cod_cliente
join vendedores v on v.cod_vendedor = f.cod_vendedor
join forma_pago fp on fp.cod_forma_pago = f.cod_forma_pago
where estado = 'Activo'
end
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_FORMA]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_CONS_FORMA]
	as
	begin
	select * from forma_pago
	end
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_MARCA]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_CONS_MARCA]
as
begin
select * from marcas
end
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_MODELOS]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_CONS_MODELOS]
AS
BEGIN 
SELECT * FROM modelos
END
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_TIPO_CLI]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_CONS_TIPO_CLI]
as
begin 
select * from tipo_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_TIPODOC]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_CONS_TIPODOC]
as
begin
select * from tipos_doc
end
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_USUARIOS]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_CONS_USUARIOS]
as
begin 
select * from Usuarios
end
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_VENDEDORES]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_CONS_VENDEDORES]
	as
	begin 
	select cod_vendedor, nombre+' '+ apellido 'nom_vendedor'  from vendedores
	end
GO
/****** Object:  StoredProcedure [dbo].[PA_INSERT_CLIENTE]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_INSERT_CLIENTE]
@nombre varchar(100),
@apellido varchar(100),
@calle varchar (100),
@altura int,
@barrio int,
@tipoDoc int,
@tipoCli int ,
@doc int,
@telefono bigint,
@mail varchar(200)
as
begin 
insert into clientes values (@nombre, @apellido, @calle,@altura,@barrio,@tipoDoc,@tipoCli,@doc,@telefono,@mail)
end
GO
/****** Object:  StoredProcedure [dbo].[PA_INSERT_DETALLE]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_INSERT_DETALLE]
	@nro_fact int,
	@cantidad int,
	@precio money,
	@producto int
	as
	begin
	insert into detalle_factura values (@cantidad, @precio, @nro_fact, @producto)
	end
GO
/****** Object:  StoredProcedure [dbo].[PA_INSERT_MAESTRO]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE procedure [dbo].[PA_INSERT_MAESTRO]
	@cod_cliente int,
	@forma_pago int,
	@vendedor int,
	@nro_fact int output
	as
	begin 
	insert into factura values (GETDATE(), @cod_cliente, @forma_pago, 1, @vendedor, 'Activo')
	set @nro_fact = SCOPE_IDENTITY();
	end
GO
/****** Object:  StoredProcedure [dbo].[PA_INSERT_PRODUCTO]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PA_INSERT_PRODUCTO]
@cod int,
@desc varchar(200),
@precio money,
@cod_tipo int,
@stock int,
@stockmin int,
@model int,
@cod_marca int
as 
begin 
insert into productos values (@cod, @desc,@precio,@cod_tipo,@stock, @stockmin, @model, @cod_marca, 'Activo')
end
GO
/****** Object:  StoredProcedure [dbo].[PA_PROX_FACT]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PA_PROX_FACT]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(cod_factura)+1  FROM factura);
END
GO
/****** Object:  StoredProcedure [dbo].[PA_UPD_PROD]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_UPD_PROD]
@cod int,
@desc varchar(200),
@precio money,
@cod_tipo int,
@stock int,
@stockmin int,
@model int,
@cod_marca int
as 
begin 
update productos
set descripcion = @desc,
pre_unitario = @precio,
cod_tipo_prod = @cod_tipo,
stock = @stock, 
stock_min = @stockmin,
cod_modelo = @model,
cod_marca = @cod_marca
where cod_producto = @cod
end
GO
/****** Object:  StoredProcedure [dbo].[ProductosSuperiorPromedio]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductosSuperiorPromedio]
 as
  select p.descripcion, pre_unitario,tp.descripcion,stock,stock_min,marca
 from productos p join tipo_prod tp on tp.cod_tipo_prod = p.cod_tipo_prod
join Marcas M on M.cod_Marca=p.cod_Marca
join Modelos Mo on Mo.cod_modelo=p.cod_modelo 
 where pre_unitario >(Select AVG (pre_unitario) from productos)
GO
/****** Object:  StoredProcedure [dbo].[Produstos_no_vendidos_Y_Vendidos]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Produstos_no_vendidos_Y_Vendidos]
@cant int
as
select p.cod_producto 'Codigo', p.descripcion 'Producto', tp.descripcion 'Tipo', 'No se vendio' 
observacion
from productos p join tipo_prod tp on tp.cod_tipo_prod = p.cod_tipo_prod
where p.cod_producto not in (select cod_producto from detalle_factura)
union
select p.cod_producto 'Codigo', p.descripcion 'Producto', tp.descripcion 'Tipo', 'Se vendio mas' 
observacion
from productos p join detalle_factura df on df.cod_producto = p.cod_producto
join tipo_prod tp on tp.cod_tipo_prod = p.cod_tipo_prod
join factura f on f.cod_factura = df.cod_factura
where @cant < (select sum(cantidad) from detalle_factura df1 
 where df1.cod_producto = p.cod_producto)
and datediff(year,fecha, getdate()) = 1
order by 4 asc
GO
/****** Object:  StoredProcedure [dbo].[PromedioMes]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PromedioMes]
@anio1 int,
@anio2 int
as
 select year(fecha) 'Año', month(fecha) 'Mes', sum(cantidad * precio_venta) 'Total', 
 sum(cantidad*precio_venta) / count(distinct f.cod_factura) 'Promedio'
 from factura f join detalle_factura df on df.cod_factura = f.cod_factura
 where YEAR(fecha) between @anio1 and @anio2
 group by year(fecha), month(fecha)
order by 1 asc,2 asc
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_AUTOS]    Script Date: 09/11/2022 15:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CONSULTAR_AUTOS]
as
select * from productos
where estado = 'Activo'
GO
USE [master]
GO
ALTER DATABASE [AUTOMOTRIZ] SET  READ_WRITE 
GO
