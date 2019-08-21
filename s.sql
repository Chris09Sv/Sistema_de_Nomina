create procedure PagoDeNomina
@Id int
as

select e.Nombre+' '+e.Apellido as Nombre,e.NoCuenta,n.Id as Referencia,Concepto='Pago de Nomina',e.Email,d.[Sueldo neto] as Monto from Empleado E
inner join Detalle_Nomina D on e.Id=d.Id_Empleado
inner join Nomina N on d		.Id_Nomina=n.Id
where n.Id=@Id