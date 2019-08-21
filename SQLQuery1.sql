CREATE TABLE [dbo].[CuentasPorCobrar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NULL,
	[Prestamo] [decimal](18, 2) NULL,
	[Cuota] [decimal](18, 2) NULL,
	[Interes] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 0) NULL,
	[Meses] [int] NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_CuentasPorCobrar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 8/15/2019 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](20) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[Fecha_de_Nacimiento] [date] NULL,
	[Estado_Civil] [varchar](20) NULL,
	[Fecha_de_Ingreso] [date] NULL,
	[IdPuesto] [int] NOT NULL,
	[Salario] [decimal](18, 2) NULL,
	[Estado] [varchar](50) NULL,
	[NoCuenta] [varchar](50) NULL,
	[FechaSalida] [date] NULL,
	[Comentario] [varchar](500) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[nominaPrueba]    Script Date: 8/15/2019 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[nominaPrueba]
as select e.id,e.Cedula ,e.NoCuenta, e.Nombre+' '+e.Apellido as Empleado,e.Salario,[Seguro medico]=0.00,[AFP]=0.00,ISR=0.00,c.Cuota as Otros,[Sueldo neto]=0.00,c.Id as CuentaID
 from Empleado E left join
 CuentasPorCobrar C on  e.Id=c.IdEmpleado and c.Balance !=0
 where e.Estado='Activo'
GO
/****** Object:  Table [dbo].[Posicion]    Script Date: 8/15/2019 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posicion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Posicion] [varchar](50) NULL,
	[IdDepartamento] [int] NOT NULL,
 CONSTRAINT [PK_Posicion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 8/15/2019 2:10:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Departamento] [varchar](50) NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[a]    Script Date: 8/15/2019 2:10:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[a]
as
SELECT e.Cedula, e.Nombre,e.Apellido,

  E.Salario as [Sueldo bruto] ,ISR1=(E.Salario-34685)*0.15, 

AFP=(E.Salario*0.0287),
 
 SEG_SOCIAL=(E.Salario*0.0304)

 
  FROM Empleado E INNER JOIN
Posicion P ON E.IdPuesto=P.Id INNER JOIN
Departamentos D ON D.Id=p.Id 
GO
/****** Object:  View [dbo].[b]    Script Date: 8/15/2019 2:10:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[b]
as
SELECT        E.Cedula, E.Nombre, E.Apellido, E.Salario AS [Sueldo bruto], E.Salario * 0.0287 AS AFP, E.Salario * 0.0304 AS SEG_SOCIAL, E.Salario * 0.0287 + E.Salario * 0.0304 AS Descuentos, E.Id, 
                         E.Salario - (E.Salario * 0.0287 + E.Salario * 0.0304) AS Sueldo_Neto, C.Cuota AS Otros,c.Id as CuentaId
FROM            dbo.Empleado AS E INNER JOIN
                         dbo.Posicion AS P ON E.IdPuesto = P.Id INNER JOIN
                         dbo.Departamentos AS D ON D.Id = P.IdDepartamento LEFT  JOIN
                         dbo.CuentasPorCobrar AS C ON C.IdEmpleado = E.Id and c.balance!=0

GO
/****** Object:  Table [dbo].[CuentasPorCobrar_Entrada]    Script Date: 8/15/2019 2:10:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentasPorCobrar_Entrada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CuentaId] [int] NOT NULL,
	[Pago] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NULL,
	[No.Cuota] [int] NULL,
 CONSTRAINT [PK_CuentasPorCobrar_Entrada] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Nomina]    Script Date: 8/15/2019 2:10:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Nomina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Nomina] [int] NOT NULL,
	[Id_Empleado] [int] NOT NULL,
	[Sueldo neto] [decimal](18, 2) NULL,
	[AFP] [decimal](18, 2) NULL,
	[Seg_Med] [decimal](18, 2) NULL,
	[ISR] [decimal](18, 2) NULL,
	[Otros] [decimal](18, 2) NULL,
	[Salario] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Detalle_Nomina] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ISR]    Script Date: 8/15/2019 2:10:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ISR](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Escala] [decimal](18, 2) NULL,
	[Escala_Mensual] [decimal](18, 2) NULL,
	[Limite] [decimal](18, 2) NULL,
	[Porcentaje] [decimal](18, 2) NULL,
	[Monto_Fijo] [decimal](18, 2) NULL,
	[Fecha_de_Inicio] [date] NULL,
	[Ultima_Modificacion] [date] NULL,
 CONSTRAINT [PK_ISR] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nomina]    Script Date: 8/15/2019 2:10:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nomina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Dolar] [decimal](18, 2) NULL,
	[Usuario] [int] NOT NULL,
	[Estatus] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Nomina] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nomina_TSS]    Script Date: 8/15/2019 2:10:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nomina_TSS](
	[Id] [nchar](10) NULL,
	[id_nomina] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasa de Deducciones]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasa de Deducciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Valor] [decimal](18, 4) NULL,
	[Limite] [decimal](18, 2) NULL,
	[Fecha_De_Inicio] [date] NULL,
	[Ultima_Modificacion] [date] NULL,
 CONSTRAINT [PK_Tasa de Deducciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDeduccion]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDeduccion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ISR] [decimal](18, 2) NOT NULL,
	[AFP] [decimal](18, 2) NOT NULL,
	[SEG_MED] [decimal](18, 2) NOT NULL,
	[SEG_SOC] [decimal](18, 2) NOT NULL,
	[OTROS_DESCUENTOS] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblDeduccion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](25) NULL,
	[Password] [varchar](50) NULL,
	[Rol] [varchar](25) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CuentasPorCobrar_Entrada]  WITH CHECK ADD  CONSTRAINT [FK_CuentasPorCobrar_Entrada_CuentasPorCobrar] FOREIGN KEY([CuentaId])
REFERENCES [dbo].[CuentasPorCobrar] ([Id])
GO
ALTER TABLE [dbo].[CuentasPorCobrar_Entrada] CHECK CONSTRAINT [FK_CuentasPorCobrar_Entrada_CuentasPorCobrar]
GO
ALTER TABLE [dbo].[Detalle_Nomina]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Nomina_Empleado] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[Detalle_Nomina] CHECK CONSTRAINT [FK_Detalle_Nomina_Empleado]
GO
ALTER TABLE [dbo].[Detalle_Nomina]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Nomina_Nomina] FOREIGN KEY([Id_Nomina])
REFERENCES [dbo].[Nomina] ([Id])
GO
ALTER TABLE [dbo].[Detalle_Nomina] CHECK CONSTRAINT [FK_Detalle_Nomina_Nomina]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Posicion] FOREIGN KEY([IdPuesto])
REFERENCES [dbo].[Posicion] ([Id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Posicion]
GO
ALTER TABLE [dbo].[Posicion]  WITH CHECK ADD  CONSTRAINT [FK_Posicion_Departamentos] FOREIGN KEY([IdDepartamento])
REFERENCES [dbo].[Departamentos] ([Id])
GO
ALTER TABLE [dbo].[Posicion] CHECK CONSTRAINT [FK_Posicion_Departamentos]
GO
/****** Object:  StoredProcedure [dbo].[_cargar_nomina]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[_cargar_nomina]

as
		select b.Cedula,b.Nombre,b.Apellido,b.AFP, B.SUELDO,b.Seg_social ,
 [Impuesto sobre la renta]=
 
 (B.Sueldo-i.Escala_Mensual)*i.Porcentaje+(i.Monto_fijo/12)
 
 
 ,suelto_neto= b.sueldo- (B.Sueldo-i.Escala_Mensual)*i.Porcentaje+(i.Monto_fijo/12)

 
 from b
		inner join ISR I on
      	b.Sueldo >= I.Escala_Mensual and b.Sueldo<=I.limite


GO
/****** Object:  StoredProcedure [dbo].[_cargar_nomina2]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[_cargar_nomina2]
as
select e.id,e.Cedula ,e.NoCuenta, e.Nombre+' '+e.Apellido as Empleado,e.Salario,[Seguro medico]=0.00,[AFP]=0.00,ISR=0.00,c.Cuota as Otros,[Sueldo neto]=0.00,c.Id as CuentaID
 from Empleado E left join
 CuentasPorCobrar C on  e.Id=c.IdEmpleado and c.Balance !=0
 where e.Estado='Activo'

GO
/****** Object:  StoredProcedure [dbo].[_cargar_nomina3]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[_cargar_nomina3]
@dollar decimal (18,2)
as
		select b.Cedula,b.Nombre,b.Apellido,b.[Sueldo bruto],b.AFP, b.Seg_social as [Seguro social] ,
 [Impuesto sobre la renta]=
 
(( (b.[Sueldo bruto]*@dollar)-i.Escala_Mensual)*i.Porcentaje+(i.Monto_fijo/12))/@dollar
 
 
 ,[Sueldo neto]= ((b.[Sueldo bruto]*@dollar)- ((b.[Sueldo bruto]*@dollar)-i.Escala_Mensual)*i.Porcentaje+(i.Monto_fijo/12))/@dollar

 
 from b
		inner join ISR I on
      	(b.[Sueldo bruto]*@dollar) >= I.Escala_Mensual and (b.[Sueldo bruto]*@dollar)<=I.limite



GO
/****** Object:  StoredProcedure [dbo].[_Nueva_Nomina_]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


		CREATE procedure [dbo].[_Nueva_Nomina_]
	 @dollar decimal(18,2),@usuario int,@Estatus varchar(50),@fecha date
		as
		insert into Nomina (Fecha,Dolar,Usuario,Estatus) values(@fecha, @dollar,@usuario,@Estatus)


	Select @@IDENTITY as codigo

GO
/****** Object:  StoredProcedure [dbo].[_Nuevo_Detalle_Nomina_]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_Nuevo_Detalle_Nomina_]
           @Id_Nomina int,
           @Id_Empleado int,
           @Sueldo_neto decimal(18,2),
           @AFP decimal(18,2),
           @Seg_Med decimal(18,2),
          @ISR decimal(18,2),
          @Otros decimal(18,2),
		  @salario decimal(18,2)
		     

		  as

		  
INSERT INTO [dbo].[Detalle_Nomina]
([Id_Nomina]
           ,[Id_Empleado]
           ,[Sueldo neto]
           ,[AFP]
           ,[Seg_Med]
           ,[ISR]
           ,[Otros],salario)
     VALUES
           
           (@Id_Nomina, 
  @Id_Empleado,
           @Sueldo_neto,
           @AFP,
           @Seg_Med,          
		   @ISR, 
           @Otros,@salario)
		   select @@IDENTITY as Id
GO
/****** Object:  StoredProcedure [dbo].[_Reporte_Tss]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec _cargar_nomina2 @dollar = 50.46
CREATE procedure [dbo].[_Reporte_Tss]
--@Id int
as
select e.Id, e.Cedula,e.Nombre,e.Apellido,


e.Salario,[Seguro Familiar de Salud]=convert(decimal(18,2) ,e.Salario*0.0709)
,AFP=convert(decimal(18,2),e.Salario*0.071),SRL=convert(decimal(18,2),e.Salario*0.011),
Infotep=convert(decimal(18,2),e.Salario*0.01) from Empleado E
where (SELECT DATEDIFF(MONTH,FechaSalida,GETDATE()) AS 'Total de meses')<=3 or Estado='Activo'
GO
/****** Object:  StoredProcedure [dbo].[_Select_nomina_]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_Select_nomina_]
as
select max(Id)+1 as IdNomina,DATEDIFF(DAY,max(Fecha),GETDATE()) as [Dias de ultima nomina] from Nomina
GO
/****** Object:  StoredProcedure [dbo].[_store_nomina_13]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_store_nomina_13]
as
SELECT e.Id, E.Nombre,[Sueldo #13]=CONVERT(decimal(18,2), SUM(D.salario)/12 ),COUNT(NOMBRE)AS PAGOS,d.Salario FROM Empleado E INNER JOIN 
Detalle_Nomina D ON D.Id_Empleado=E.Id INNER JOIN
Nomina N ON D.Id_Nomina=N.Id 
where year(n.Fecha) = year(getdate())

GROUP BY e.id, E.Nombre,d.Salario 
GO
/****** Object:  StoredProcedure [dbo].[_store_nomina_13_1]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[_store_nomina_13_1]
as
SELECT
e.id,e.Cedula ,e.NoCuenta, e.Nombre+' '+e.Apellido as Empleado,Salario=CONVERT(decimal(18,2), SUM(D.salario)/12 ),[Seguro medico]=0.00,[AFP]=0.00,ISR=0.00, Otros=0.00,[Sueldo neto]=0.00

 --e.Id, E.Nombre,,COUNT(NOMBRE)AS PAGOS,d.Salario 
 FROM Empleado E INNER JOIN 
Detalle_Nomina D ON D.Id_Empleado=E.Id INNER JOIN
Nomina N ON D.Id_Nomina=N.Id 
where year(n.Fecha) = year(getdate())

GROUP BY e.id,e.Cedula ,e.NoCuenta,e.Nombre,e.Apellido,d.Salario 
--e.id ,e.NoCuenta, e.Nombre+' '+e.Apellido as Empleado,Salario=CONVERT(decimal(18,2), SUM(D.salario)/12 ),[Seguro medico]=0.00,[AFP]=0.00,ISR=0.00, Otros=0.00,[Sueldo neto]=0.00
GO
/****** Object:  StoredProcedure [dbo].[_Store_Nuevo_Prestamo]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[_Store_Nuevo_Prestamo]

@IdEmpleado int, @Prestamo decimal(18,2),@Cuota decimal(18,2),@Interes decimal(18,2),@Meses int,@Fecha date
as

INSERT INTO [dbo].[CuentasPorCobrar]
           ([IdEmpleado]
           ,[Prestamo]
           ,[Cuota],
		  [Interes],balance
           ,[Meses]
           ,[Fecha])
     VALUES
           (@IdEmpleado, @Prestamo,@Cuota,@Interes,@Prestamo,@Meses,@Fecha)

select @@IDENTITY as PrestamoRG

select * from CuentasPorCobrar
GO
/****** Object:  StoredProcedure [dbo].[_Store_Pago]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_Store_Pago]

@Id int,@IdNomina int
as

INSERT INTO [dbo].[CuentasPorCobrar_Entrada]
           ([CuentaId]
           ,[Pago]
           ,[Fecha]
           ,[No.Cuota])
     VALUES
           (@Id,(select cuota from CuentasPorCobrar where Id=@Id),GETDATE(),@IdNomina)
		 		   select @@IDENTITY as cw

		   update CuentasPorCobrar set balance-=Cuota,Meses-=1 where @Id=Id
		     select @@ROWCOUNT as cantidad
			
GO
/****** Object:  StoredProcedure [dbo].[_Store_Update_Prestamo]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_Store_Update_Prestamo]
@Id int, 
@Prestamo decimal(18,2),
@Cuota decimal(18,2),
@Meses int
as 
update CuentasPorCobrar set Balance=@Prestamo,Cuota=@Cuota,Meses=@Meses where Id=@Id
select @@ROWCOUNT as ID
GO
/****** Object:  StoredProcedure [dbo].[_store_vista_estado_prestamo]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_store_vista_estado_prestamo]
as
select e.Id, e.Cedula, e.Nombre,c.Prestamo, c.Prestamo,c.Cuota,c.Meses,c.Balance,count(Pago) as Cuotas,SUM(Pago) as [Cantidad pagada]   from Empleado E inner join 
CuentasPorCobrar C on e.Id=c.IdEmpleado  
left join CuentasPorCobrar_Entrada D on d.CuentaId=c.Id 
group by e.Id, e.Cedula, e.Nombre,c.Prestamo, c.Prestamo,c.Cuota,c.Meses,c.Balance,Pago
GO
/****** Object:  StoredProcedure [dbo].[_store_vista_estado_prestamo_empleado]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[_store_vista_estado_prestamo_empleado]

@Id int
as
select e.Id, e.Cedula, e.Nombre,c.Prestamo, c.Balance,c.Cuota,c.Meses,c.Balance,c.Id as [Prestamo no.]   from Empleado E inner join 
CuentasPorCobrar C on e.Id=c.IdEmpleado  
left join CuentasPorCobrar_Entrada D on d.CuentaId=c.Id 
left join Nomina N on n.Id=d.[No.Cuota]
where E.Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[_store_vista_Prestamo]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[_store_vista_Prestamo]

--se busca los empleados que no tengan un prestamo activo.
as
SELECT e.Id,c.Id as [cuenta], E.Cedula,E.Nombre,E.Apellido,e.Telefono,e.Email,P.Posicion,D.Departamento,e.Salario,e.NoCuenta,c.balance FROM Empleado E
 INNER JOIN Posicion P  ON E.IdPuesto=P.Id
 INNER JOIN Departamentos D ON D.Id=P.IdDepartamento
 left join CuentasPorCobrar c on e.Id=c.IdEmpleado 
 where e.Estado='Activo'
  
GO
/****** Object:  StoredProcedure [dbo].[_Valores_ISR]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_Valores_ISR]
@Salario decimal(18,2)
as
select * from ISR where @Salario between Escala_Mensual and Limite


SELECT        Nombre, Valor, Limite
FROM            dbo.[Tasa de Deducciones]
GO
/****** Object:  StoredProcedure [dbo].[_Valores_Seg_Social]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE
 procedure [dbo].[_Valores_Seg_Social]
as
SELECT        Nombre, Valor, Limite
FROM            dbo.[Tasa de Deducciones]
SELECT        Nombre
FROM            Empleado
GO
/****** Object:  StoredProcedure [dbo].[_ver_nomina]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_ver_nomina]
@id int
as
SELECT        Empleado.Id, dbo.Empleado.Cedula, dbo.Empleado.Nombre, dbo.Empleado.Apellido, dbo.Empleado.Salario, dbo.Detalle_Nomina.AFP, dbo.Detalle_Nomina.Seg_Med, dbo.Detalle_Nomina.ISR, dbo.Detalle_Nomina.Otros, 
                         b.descuentos,dbo.Detalle_Nomina.[Sueldo neto] as sueldo_neto
FROM            dbo.Detalle_Nomina INNER JOIN
                         dbo.Empleado ON dbo.Detalle_Nomina.Id_Empleado = dbo.Empleado.Id INNER JOIN
                         dbo.Nomina ON dbo.Detalle_Nomina.Id_Nomina = dbo.Nomina.Id
						 inner join b on b.Id=Empleado.Id
						 
						 where Nomina.Id=@id
GO
/****** Object:  StoredProcedure [dbo].[_Ver_Nomina_individual]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_Ver_Nomina_individual]
@IdEmpleado int ,@idNomina int
as


select n.Fecha,n.Id as [Nomina no.],n.Dolar,e.Id,e.Cedula,
 e.Nombre+' '+e.Apellido As Nombre,d.Departamento,p.Posicion,e.Salario,
 
 q.ISR,
 q.Seg_Med,
 q.AFP,
  q.Otros,
  Descuentos=(Q.AFP+q.ISR+q.Seg_Med+q.Otros         ),
  q.[Sueldo neto]



from Empleado E inner join Posicion P 
on e.IdPuesto=p.Id 
inner join Departamentos D 
on d.Id=p.IdDepartamento
inner join Detalle_Nomina Q on q.Id_Empleado=e.Id
inner join Nomina N on N.Id=q.Id_Nomina
left join CuentasPorCobrar l on l.IdEmpleado=e.Id
where Id_Empleado=@IdEmpleado and n.Id=@idNomina
order by n.Id
 
GO
/****** Object:  StoredProcedure [dbo].[_ver_nominaD]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_ver_nominaD]
@id int
as
SELECT       Nomina.Id,Nomina.Fecha,Nomina.Dolar ,Empleado.Id, dbo.Empleado.Cedula, dbo.Empleado.Nombre, dbo.Empleado.Apellido, dbo.Empleado.Salario, dbo.Detalle_Nomina.AFP, dbo.Detalle_Nomina.Seg_Med, dbo.Detalle_Nomina.ISR, dbo.Detalle_Nomina.Otros, 
                        convert(decimal(18,2), b.descuentos),dbo.Detalle_Nomina.[Sueldo neto] as sueldo_neto
FROM            dbo.Detalle_Nomina INNER JOIN
                         dbo.Empleado ON dbo.Detalle_Nomina.Id_Empleado = dbo.Empleado.Id INNER JOIN
                         dbo.Nomina ON dbo.Detalle_Nomina.Id_Nomina = dbo.Nomina.Id
						 inner join b on b.Id=Empleado.Id
						 
						 where Nomina.Id=@id
GO
/****** Object:  StoredProcedure [dbo].[p]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[p] as 
select * from nominaPrueba
GO
/****** Object:  StoredProcedure [dbo].[store_Actualizar_Departamento]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Actualizar_Departamento]
@Id int, @Departamento varchar(50)
as
UPDATE Departamentos set Departamento=@Departamento WHERE @Id=Id

SELECT @@ROWCOUNT AS CANTIDADAFECTADA
GO
/****** Object:  StoredProcedure [dbo].[store_Actualizar_Posicion]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Actualizar_Posicion]
@Id int,@Posicion varchar(50),@IdDepartamento int
as
UPDATE Posicion SET Posicion=@Posicion,IdDepartamento=@IdDepartamento where Id=@Id

SELECT @@ROWCOUNT AS CANTIDADAFECTADA
GO
/****** Object:  StoredProcedure [dbo].[store_Eliminar_Departamento]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Eliminar_Departamento]
@Id int
as
Delete from Departamentos where Id=@Id
SELECT @@ROWCOUNT AS CANTIDADAFECTADA
GO
/****** Object:  StoredProcedure [dbo].[store_Eliminar_Empleado]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Eliminar_Empleado]
@Id int
as

update Empleado set Estado='Cancelado', FechaSalida=Getdate() where Id=@Id

select @@ROWCOUNT as cantidadAfectada
GO
/****** Object:  StoredProcedure [dbo].[store_Eliminar_Posicion]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[store_Eliminar_Posicion]
@Id int
as

delete from Posicion where Id=@Id

select @@ROWCOUNT as cantidadAfectada
GO
/****** Object:  StoredProcedure [dbo].[store_Modificar_Empleado]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[store_Modificar_Empleado]
 @Id int,@Cedula varchar(20), @Nombre varchar(50) , @Apellido varchar(50), @Direccion varchar(50), @Telefono  varchar(15), @Email varchar(50), @Fecha_de_Nacimiento date, @Estado_Civil varchar(20), @Fecha_de_Ingreso date, @IdPuesto int, @Salario Decimal(18,2),  @NoCuenta varchar(50)

AS 
UPDATE Empleado SET Cedula=@Cedula, Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion, Telefono=@Telefono, Email=@Email, Fecha_de_Nacimiento=@Fecha_de_Nacimiento, Estado_Civil=@Estado_Civil, IdPuesto=@IdPuesto, Salario=@Salario,  NoCuenta=@NoCuenta		WHERE @Id=Id															

select @@ROWCOUNT as EmpleadoID



GO
/****** Object:  StoredProcedure [dbo].[store_Nueva_Posicion]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Nueva_Posicion]
@Posicion varchar(50),@id int
AS 
INSERT INTO Posicion(Posicion,IdDepartamento) values (@Posicion,@id)
select @@IDENTITY as PosicionId
GO
/****** Object:  StoredProcedure [dbo].[store_Nuevo_Departamento]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Nuevo_Departamento]
@Departamento varchar(50)
as 
INSERT INTO	Departamentos (Departamento) VALUES (@Departamento)
 

select @@IDENTITY as Id




GO
/****** Object:  StoredProcedure [dbo].[store_Nuevo_Empleado]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Nuevo_Empleado]

@Cedula varchar(20),
           @Nombre varchar(50),
           @Apellido varchar(50),
           @Direccion varchar(50),
           @Telefono varchar(15),
           @Email varchar(50),
           @Fecha_de_Nacimiento date,
           @Estado_Civil varchar(20),
           @Fecha_de_Ingreso date,
           @IdPuesto int,
           @Salario decimal(18,2),
           @Estado varchar(50),
           @NoCuenta varchar(50)
as


INSERT INTO [dbo].[Empleado]
           ([Cedula]
           ,[Nombre]
           ,[Apellido]
           ,[Direccion]
           ,[Telefono]
           ,[Email]
           ,[Fecha_de_Nacimiento]
           ,[Estado_Civil]
           ,[Fecha_de_Ingreso]
           ,[IdPuesto]
           ,[Salario]
           ,[Estado]
           ,[NoCuenta])
     VALUES
           (@Cedula, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @Fecha_de_Nacimiento, @Estado_Civil, @Fecha_de_Ingreso, @IdPuesto, @Salario, @Estado, @NoCuenta)


		   SELECT @@IDENTITY AS EMPLEADOID
GO
/****** Object:  StoredProcedure [dbo].[store_Validar_Departamento]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[store_Validar_Departamento]
@Departamento varchar(50)
as

select count(Departamento) from Departamentos where Departamento=@Departamento
GO
/****** Object:  StoredProcedure [dbo].[store_Validar_Puesto]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[store_Validar_Puesto]
@Departamento int,@posicion varchar(50)
as

select count(Posicion) from Posicion where IdDepartamento=@Departamento and Posicion=@posicion
GO
/****** Object:  StoredProcedure [dbo].[store_Vista_Departamento]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Vista_Departamento]
AS 
SELECT * FROM Departamentos
GO
/****** Object:  StoredProcedure [dbo].[store_Vista_Empleado]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Vista_Empleado]
as


SELECT        dbo.Empleado.Id, dbo.Empleado.Cedula, dbo.Empleado.Nombre, dbo.Empleado.Apellido, dbo.Empleado.Direccion, dbo.Empleado.Telefono, dbo.Empleado.Email, dbo.Empleado.Fecha_de_Nacimiento as [Fecha de Nacimiento], 
                         dbo.Empleado.Estado_Civil, dbo.Empleado.Fecha_de_Ingreso as [Fecha de Ingreso], dbo.Posicion.Posicion, dbo.Empleado.Salario, dbo.Empleado.NoCuenta, dbo.Empleado.Estado, dbo.Departamentos.Departamento
FROM            dbo.Departamentos INNER JOIN
                         dbo.Posicion ON dbo.Departamentos.Id = dbo.Posicion.IdDepartamento INNER JOIN
                         dbo.Empleado ON dbo.Posicion.Id = dbo.Empleado.IdPuesto
						 where Empleado.Estado='Activo'
GO
/****** Object:  StoredProcedure [dbo].[store_Vista_nomina]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[store_Vista_nomina]
as

SELECT        dbo.Nomina.Id as Codigo,dbo.Nomina.Fecha, dbo.Nomina.Dolar,sum(Detalle_Nomina.[Sueldo neto])as [Total a Pagar],sum(Detalle_Nomina.AFP) as [Gastos en Afp descontados],sum(Detalle_Nomina.Seg_Med) as [Gastos en seg. social descontados],sum(Detalle_Nomina.ISR) as [Gastos en impuestos sobre la renta descontados],Nomina.Estatus, dbo.Usuarios.NombreUsuario AS [Realizada por:]

FROM            dbo.Detalle_Nomina INNER JOIN 
                         dbo.Nomina ON dbo.Detalle_Nomina.Id_Nomina = dbo.Nomina.Id INNER JOIN
                         dbo.Usuarios ON dbo.Nomina.Usuario = dbo.Usuarios.Id


GROUP BY dbo.Nomina.Id,dbo.Nomina.Fecha, dbo.Nomina.Dolar, dbo.Usuarios.NombreUsuario, Nomina.Estatus
GO
/****** Object:  StoredProcedure [dbo].[store_Vista_Posicion]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Vista_Posicion]
as

SELECT p.Id, P.Posicion AS Puestos,D.Departamento from Posicion p INNER JOIN Departamentos D 
ON P.IdDepartamento=D.Id
GO
/****** Object:  StoredProcedure [dbo].[store_Vista_Puestos]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[store_Vista_Puestos]
AS 
SELECT * FROM Posicion ORDER BY Posicion

GO
/****** Object:  StoredProcedure [dbo].[stp_actualizardesc]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_actualizardesc]

@Id int,
@ISR FLOAT,
@AFP FLOAT,
@SEG_MED FLOAT,
@SEG_SOC FLOAT,
@OTROS_DESCUENTOS FLOAT
	
AS
update tblDeduccion set ISR=@ISR,AFP=@AFP,SEG_MED=@SEG_MED,SEG_SOC=@SEG_SOC,OTROS_DESCUENTOS=@OTROS_DESCUENTOS where Id=@Id
select @@ROWCOUNT as Cantidad





GO
/****** Object:  StoredProcedure [dbo].[stp_guardardesc]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[stp_guardardesc]
(
@ISR decimal(18,2),
@AFP decimal(18,2),
@SEG_MED decimal(18,2),
@SEG_SOC decimal(18,2),
@OTROS_DESCUENTOS decimal(18,2)
)
	
AS
insert into tblDeduccion (ISR, AFP, SEG_MED, SEG_SOC, OTROS_DESCUENTOS)
values ( @ISR, @AFP, @SEG_MED, @SEG_SOC, @OTROS_DESCUENTOS)

select @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[stpverdes]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[stpverdes]


AS
BEGIN
	
SELECT Id,ISR,AFP,SEG_MED,SEG_SOC,OTROS_DESCUENTOS  from tblDeduccion
	
	
END	

GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_usuario]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_Actualizar_usuario] 
(
@Id int,
@Nombre varchar(50),
@Usuario varchar(50),
@Contraseña varchar(50)

)
	
AS
update tblUsuario set Nombre=@Nombre, Usuario=@Usuario,Contraseña=@Contraseña where Id=@Id

select @@ROWCOUNT as Cantidad


GO
/****** Object:  StoredProcedure [dbo].[usp_eliminar_usuario]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  PROCEDURE [dbo].[usp_eliminar_usuario]
@Id int


AS
BEGIN

delete from tblUsuario where Id=@Id

select @@ROWCOUNT as CantidadAfectada

END


GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Usuario]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  PROCEDURE [dbo].[usp_Insertar_Usuario]
(
@Nombre varchar(50),
@Usuario varchar(50),
@Contraseña varchar(50)

)
	
AS
insert into tblUsuario (Nombre,Contraseña,Usuario)
values (@Nombre,@Contraseña,@Usuario)

select @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[usp_PLogin_ValidarLogin]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE  PROCEDURE [dbo].[usp_PLogin_ValidarLogin]
@Usuario varchar(100),
@Contraseña varchar(100)

	
AS
BEGIN
	select Id, Usuario, contraseña from tblUsuario where Usuario=@Usuario and Contraseña=@Contraseña 
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Ver_Usuario]    Script Date: 8/15/2019 2:10:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ver_Usuario]


AS
BEGIN
	
SELECT Nombre,Usuario,Contraseña from tblUsuario
	
	
END	


GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "E"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "P"
            Begin Extent = 
               Top = 6
               Left = 281
               Bottom = 119
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 120
               Left = 281
               Bottom = 216
               Right = 451
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'b'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'b'
GO
USE [master]
GO
ALTER DATABASE [Sistema_de_Nomina] SET  READ_WRITE 
GO
