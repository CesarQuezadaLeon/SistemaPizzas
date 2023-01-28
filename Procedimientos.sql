use Proyecto

/*-----------------------Procedimientos almacenados---------------------*/
create procedure AltaEmpleados
(
@NombreEmp varchar(50),
@ApePatEmp varchar(50),
@ApeMatEmp varchar(50),
@SexoEmp nvarchar(1), 
@Puesto nvarchar(1),
@NombreCalle char(50),
@NumExt int,
@NumInt int,
@Colonia char(50),
@Municipio char(50),
@CodigoPostal char(5),
@Telefono char,
@HoraEntrada time,
@HoraSalida time,
@Salario money,
@Contraseña nvarchar(10)
)
as insert into
Empleados(NombreEmp,ApePatEmp,ApeMatEmp,SexoEmp,Puesto,NombreCalle,NumExt,NumInt,Colonia,Municipio,CodigoPostal,Telefono,HoraEntrada,HoraSalida,Salario,Contraseña)
values(@NombreEmp,@ApePatEmp,@ApeMatEmp,@SexoEmp,@Puesto,@NombreCalle,@NumExt,@NumInt,@Colonia,@Municipio,@CodigoPostal,@Telefono,@HoraEntrada,@HoraSalida,@Salario,@Contraseña)
go


create procedure AcutualizarEmpleados
(
@IdEmpleado int,
@NombreEmp varchar(50),
@ApePatEmp varchar(50),
@ApeMatEmp varchar(50),
@SexoEmp nvarchar(1), 
@Puesto nvarchar(1),
@NombreCalle char(50),
@NumExt int,
@NumInt int,
@Colonia char(50),
@Municipio char(50),
@CodigoPostal char(5),
@Telefono numeric,
@HoraEntrada time,
@HoraSalida time,
@Salario money,
@Contraseña nvarchar(10)
)
as update Empleados set 
NombreEmp=@NombreEmp,ApePatEmp=@ApePatEmp,ApeMatEmp=@ApeMatEmp,SexoEmp=@SexoEmp,Puesto=@Puesto,NombreCalle=@NombreCalle,NumExt=@NumExt,NumInt=@NumInt,Colonia=@Colonia,Municipio=@Municipio,CodigoPostal=@CodigoPostal,Telefono=@Telefono,HoraEntrada=@HoraEntrada,HoraSalida=@HoraSalida,Salario=@Salario,Contraseña=@Contraseña
where IdEmpleado=@IdEmpleado


create procedure BorrarEmpleado
(
@IdEmpleado int
)
as delete Empleados
where IdEmpleado=@IdEmpleado



create procedure AltaProveedores
(
@NombreProveedor varchar(20),
@ApePatPro varchar(20),
@ApeMatPro varchar(20),
@NombreCalle char(50),
@NumExt int,
@NumInt int,
@Colonia char(50),
@Municipio char(50),
@CodigoPostal char(5),
@Telefono numeric,
@CE nvarchar(50), 
@Marca nvarchar(20)
)
as insert into Proveedores(NombreProveedor,ApePatPro,ApeMatPro,NombreCalle,NumExt,NumInt,Colonia,Municipio,CodigoPostal,Telefono,CE,Marca)
values(@NombreProveedor,@ApePatPro,@ApeMatPro,@NombreCalle,@NumExt,@NumInt,@Colonia,@Municipio,@CodigoPostal,@Telefono,@CE,@Marca)


create procedure ActualizarProveedores
(
@IdProveedor int,
@NombreProveedor varchar(20),
@ApePatPro varchar(20),
@ApeMatPro varchar(20),
@NombreCalle char(50),
@NumExt int,
@NumInt int,
@Colonia char(50),
@Municipio char(50),
@CodigoPostal char(5),
@Telefono numeric,
@CE nvarchar(50), 
@Marca nvarchar(20)
)
as update Proveedores set  
NombreProveedor=@NombreProveedor,ApePatPro=@ApePatPro,ApeMatPro=@ApePatPro,NombreCalle=@NombreCalle,NumExt=@NumExt,NumInt=@NumInt,Colonia=@Colonia,Municipio=@Municipio,CodigoPostal=@CodigoPostal,Telefono=@Telefono,CE=@CE,Marca=@Marca
where IdProveedor=@IdProveedor

create procedure EliminarProveedor 
(
@IdProveedor int
)
as delete Proveedores
where IdProveedor=@IdProveedor

Select * from Empleados

Create procedure AltaMateriaPrima /*in('LAC','CAR','VER','FRU','HAR','GRS'))*/ 
(
@Nombre nvarchar(20),
@TipoMP nvarchar(3), 
@Cantidad int
)
as insert into MateriaPrima(Nombre,TipoMP,Cantidad)
values(@Nombre,@TipoMP,@Cantidad)

Create procedure ActualizarMP /*in('LAC','CAR','VER','FRU','HAR','GRS'))*/ 
(
@IdMateriaPrima int,
@Nombre nvarchar(20),
@TipoMP nvarchar(3),
@Cantidad int
)
as update MateriaPrima set Nombre=@Nombre,TipoMP=@TipoMP,Cantidad=@Cantidad
where IdMateriaPrima=@IdMateriaPrima


create procedure EliminarMP
(@IdMateriaPrima int) as delete MateriaPrima where IdMateriaPrima=@IdMateriaPrima

create procedure AltaPedidoProveedor
(
@Pedido nvarchar(50),
@Cantidad int,
@Precio money,
@FechaPedido datetime,
@Observaciones char(50)
)
as insert into PedidoProveedor(Pedido,Cantidad,Precio,FechaPedido,Observaciones) 
values(@Pedido,@Cantidad,@Precio,@FechaPedido,@Observaciones) 



create procedure ActualizarPedidoProveedor 
(
@IdDetallePP int,
@Pedido nvarchar(50),
@Cantidad int,
@Precio money,
@FechaPedido datetime,
@Observaciones char(50)
)
as update PedidoProveedor set Pedido=@Pedido,Cantidad=@Cantidad,Precio=@Precio,FechaPedido=@FechaPedido,Observaciones=@Observaciones
where IdDetallePP=@IdDetallePP
 

create procedure EliminarDPP
(@IdDetallePP int)as delete PedidoProveedor where IdDetallePP=@IdDetallePP

select*from PedidoProveedor 
select*from Proveedores
----------------------------------------------------------------
create procedure AltaPagosProveedor
(
@FechaPago datetime,
@Pago money,
@IdPedido int
)
as
INSERT INTO	PagosProveedor(FechaDePago,Pago,IdDetallePP)
values(@FechaPago,@Pago,@IdPedido)
go


create procedure ActualizarPagosProveedor
(
@IdPagos int,
@FechaPago datetime,
@Pago money,
@IdPedidos int
)
as
UPDATE PagosProveedor
SET FechaDePago=@FechaPago,Pago=@Pago,IdDetallePP=@IdPedidos
WHERE IdPagosProveedor=@IdPagos
go

create procedure EliminarPagosProveedor
(
@IdPagos int
)
as
DELETE PagosProveedor
WHERE IdPagosProveedor=@IdPagos
go


create procedure AltaDetalleMateriaPrima
(
@FechaEntrada datetime,
@FechaUso datetime,
@Precio money,
@IdMateriaPrima int,
@IdPedido int
)
as
INSERT INTO	DetalleMateriaPrima(FechaEntrada,FechaUso,Precio,IdMateriaPrima,IdDetallePP)
values(@FechaEntrada,@FechaUso,@Precio,@IdMateriaPrima,@IdPedido)
go


create procedure ActualizarDetalleMateriaPrima
(
@IdDetalleMateriaPrima int,
@FechaEntrada datetime,
@FechaUso datetime,
@FechaBaja datetime,
@Precio money,
@IdMateriaPrima int,
@IdPedido int
)
as
UPDATE DetalleMateriaPrima
SET FechaEntrada=@FechaEntrada,FechaUso=@FechaUso,Precio=@Precio,IdMateriaPrima=IdMateriaPrima,IdDetallePP=@IdPedido
WHERE IdDetalleMateriaPrima=@IdDetalleMateriaPrima
go


create procedure EliminarDetalleMateriaPrima
(
@IdDetalleMateriaPrima int
)
as
Delete DetalleMateriaPrima
where IdDetalleMateriaPrima=@IdDetalleMateriaPrima
go


--------------------------------------------------------------------------
create procedure AltaProducto
(
@NombrePro nvarchar(20),
@PrecioPro money,
@Descripcion nvarchar(50),
@Cantidad int
)
as 
insert into Producto(NombrePro,PrecioPro,Descripcion,Cantidad)
values(@NombrePro,@PrecioPro,@Descripcion,@Cantidad)
go


create procedure ActualizarProducto
(
@IdProducto int,
@NombrePro nvarchar(20),
@PrecioPro money,
@Descripcion nvarchar(50),
@Cantidad int
)
as
UPDATE Producto
set NombrePro=@NombrePro,PrecioPro=@PrecioPro,Descripcion=@Descripcion,Cantidad=@Cantidad
where IdProducto=@IdProducto
go

create procedure EliminarProducto
(
@IdProducto int
)
as
DELETE Producto
where IdProducto=@IdProducto 
go

create Procedure AltaDetalleProducto
(
@Categoria nvarchar(6),
@IdMateriaPrima int ,
@IdProducto int
)
as
insert into DetalleProducto(Categoria,IdMateriaPrima,IdProducto)
values(@Categoria,@IdMateriaPrima,@IdProducto)
go

create Procedure ActualizarDetalleProducto
(
@IdDetalleProducto int,
@Categoria nvarchar(6),
@IdMateriaPrima int ,
@IdProducto int
)
as
UPDATE DetalleProducto
SET Categoria=@Categoria,IdMateriaPrima=@IdMateriaPrima,IdProducto=@IdProducto
where IdDetalleProducto=@IdDetalleProducto
go


create Procedure EliminarDetalleProducto
(@IdDetalleProducto int)
as DELETE DetalleProducto where IdDetalleProducto=@IdDetalleProducto
go


Create procedure AltaCliente
(
@NombreC nvarchar(20) ,
@ApePatC varchar(50),
@ApeMatC varchar(50),
@NombreCalle char(50),
@NumExt int ,
@NumInt int ,
@Colonia char(50) ,
@Municipio char(50),
@CodigoPostal char(5) ,
@Telefono numeric,
@CE nvarchar(50) ,
@TipoCliente nvarchar(1)
)
as
insert into Cliente(NombreC,ApePatC,ApeMatC,NombreCalle,NumExt,NumInt,Colonia,Municipio,CodigoPostal,Telefono,CE,TipoCliente)
values(@NombreC,@ApePatC,@ApeMatC,@NombreCalle,@NumExt,@NumInt,@Colonia,@Municipio,@CodigoPostal,@Telefono,@CE,@TipoCliente)
go

Create procedure ActualizarCliente
(
@IdCliente int,
@NombreC nvarchar(20) ,
@ApePatC varchar(50),
@ApeMatC varchar(50),
@NombreCalle char(50),
@NumExt int ,
@NumInt int ,
@Colonia char(50) ,
@Municipio char(50),
@CodigoPostal char(5) ,
@Telefono numeric,
@CE nvarchar(50) ,
@TipoCliente nvarchar(1)
)
as
UPDATE Cliente
set NombreC=@NombreC,ApePatC=@ApePatC,ApeMatC=@ApeMatC,NombreCalle=@NombreCalle,NumExt=@NumExt,NumInt=@NumInt,Colonia=@Colonia,
	Municipio=@Municipio,CodigoPostal=@CodigoPostal,Telefono=@Telefono,CE=@CE,TipoCliente=@TipoCliente
where IdCliente=@IdCliente
go

Create procedure EliminarCliente
(
@IdCliente int
)
as
DELETE Cliente
where IdCliente=@IdCliente
go


create procedure AltaVenta
(
@Monto money ,
@cantidad int)
as
insert into Venta(Monto,cantidad)
values (@Monto,@cantidad)
go

create procedure ActualizarVenta
(
@IdVenta int,
@Monto money ,
@cantidad int)
as
UPDATE Venta
set Monto=@Monto,cantidad=@cantidad
WHERE IdVenta=@IdVenta
go

create procedure EliminarVenta
(
@IdVenta int
)
as
DELETE Venta
where IdVenta=@IdVenta
go

create procedure AltaDetalleVenta
(
@Descuento money,
@cantidad int,
@FechaVenta datetime,
@IdVenta int,
@IdEmpleado int,
@IdProducto int,
@IdCliente int
)
as
insert into DetalleVenta(Descuento,cantidad,FechaVenta,IdVenta,IdEmpleado,IdProducto,IdCliente)
values (@Descuento,@cantidad,@FechaVenta,@IdVenta,@IdEmpleado,@IdProducto,@IdCliente)
GO

create procedure ActualizarDetalleVenta
(
@IdDetalleVenta int,
@Descuento money,
@cantidad int,
@FechaVenta datetime,
@IdVenta int,
@IdEmpleado int,
@IdProducto int,
@IdCliente int
)
as
UPDATE DetalleVenta
set Descuento=@Descuento,cantidad=@cantidad,FechaVenta=@FechaVenta,IdVenta=@IdVenta,IdEmpleado=@IdEmpleado,IdProducto=@IdProducto,IdCliente=@IdCliente
WHERE IdDetalleVenta=@IdDetalleVenta
go

create procedure EliminarDetalleVenta
(
@IdDetalleVenta int
)
as
DELETE DetalleVenta
where IdDetalleVenta=@IdDetalleVenta


Create procedure  AltaVehiculo
(
@NombreV nvarchar(20),
@Marca nvarchar(20),
@Modelo nvarchar(20)
)
as
insert into Vehiculo(NombreVehiculo,Marca,Modelo)
VALUES (@NombreV,@Marca,@Modelo)
go

Create procedure  ActualizarVehiculo
(
@IdUnidad int,
@NombreV char(20),
@Marca nvarchar(20),
@Modelo nvarchar(20)
)
as
UPDATE Vehiculo
set NombreVehiculo=@NombreV,Marca=@Marca,Modelo=@Modelo
where IdUnidad=@IdUnidad
GO


Create procedure  EliminarVehiculo
(
@IdUnidad int
)
AS
DELETE Vehiculo
where IdUnidad=@IdUnidad
go

create procedure Altaviaje
(
@IdDetalleVenta int,
@IdUnidad int,
@Distancia nvarchar(20)
)as
insert into viaje(IdDetalleVenta,IdUnidad,Distancia)
VALUES (@IdDetalleVenta,@IdUnidad,@Distancia)
go

create procedure ActualizarViaje
(
@IdDetalleVenta int,
@IdUnidad int,
@Distancia nvarchar(20)
)as
Update viaje set IdDetalleVenta=@IdDetalleVenta,IdUnidad=@IdUnidad,Distancia=@Distancia
where IdDetalleVenta=@IdDetalleVenta
go

create procedure ElimarViaje
(
@IdDetalleVenta int,
@IdUnidad int,
@Distancia nvarchar(20)
)as
delete viaje
where IdDetalleVenta=@IdDetalleVenta and IdUnidad=@IdUnidad and Distancia=@Distancia
go

--------------------------------------------------------------
/* Ordenar Algunas cosas */

create procedure OrdenarPrecios
as select * from Producto order by PrecioPro desc

create procedure FechadeVenta
as select * from DetalleVenta order by FechaVenta desc

create procedure MontodeVenta
as select * from Venta order by Monto desc

create procedure FechaDePedido
as select PedidoProveedor.FechaPedido from PedidoProveedor order by FechaPedido

exec FechaDePedido
/*busqueda de algunas cosas*/

create procedure BuscarProducto
(
@NombreProduc nvarchar(50)
)
as select * from Producto where NombrePro like @NombreProduc + '%' 

create procedure BuscarFechaPedido
(
@Fechapedido datetime
)
as select * from DetallePedidoVenta where FechaVenta like @Fechapedido + '%' 

create procedure BuscarFechadeVenta
(@Fechadeventa datetime)
as select * from DetalleVenta where FechaVenta like @Fechadeventa

----------------------ejecuciones----------------------------------------
exec AltaEmpleados'Azusena','Mendoza','Lopez','F','V','Privada Chichipinga',4,NULL,'linda Vista','Zacatlan','73310','7971123243','13:00','20:00',1700,'13456789'

exec AltaEmpleados 'Juan','Perez','Aldana','M','V','Ponciano arriaga',4,NULL,'Cienega','Zacatlan','73311',null,'13:00','20:00',1200,'78945613'

Exec AltaEmpleados 'Maria','Garcia','Olmos','M','V','Nicolas Maduro 20',7,null,'centro','chignahuapan','73315','7971157896','10:00 am','18:00 pm',1300,'78945613'

exec AltaPedidoProveedor 'Jamon',150,12,'05-05-2019','buen estado'

exec AltaPedidoProveedor 'piña',22,550,'06-06-2019','Mal estado'

exec AltaPedidoProveedor 'Refresco',12,350,'08-10-2019','buen estado'


exec AltaProveedores 'Gabriel','Sanchez','Amador','Zaragoza 34',4,NULL,'Olmeca','Huauchinango','73510',7971123243,'CocaCola@gmail.com','Coca-Cola'
exec AltaProveedores 'Mario','Aldana','Perez','ciñitas',16,1,'Agustin Iturbide','Tetela de Mendez','73910',7971123243,'Solesinsolesin@gmail.com','Lala'
Exec AltaProveedores 'sophia','Luna','Marin','Hermenegildo',55,66,'Galeana','Atixco','45931',7971123243,'Imprex@gmail.com','Alpura'

exec AltaMateriaPrima 'Queso Villita','LAC',10
exec AltaMateriaPrima 'Naranja','FRU',54
exec AltaMateriaPrima 'Jamon FUD','CAR',12

exec AltaVehiculo 'f150','Italika','2019'
--------------------------------------------------------------
SELECT NombrePro AS Producto
      ,PrecioPro AS PreciosinIva
      ,(PrecioPro * 0.16) AS IVA
 INTO #precioFinalProductos
 FROM Producto
 
 