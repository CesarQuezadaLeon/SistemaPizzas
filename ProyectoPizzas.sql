create database Proyecto


/*drop database Proyecto*/
use Proyecto


create table Empleados
(
IdEmpleado int not null primary key identity(1,1), 
NombreEmp varchar(50)not null,
ApePatEmp varchar(50)not null,
ApeMatEmp varchar(50)null,
SexoEmp nvarchar(1) constraint Csexo check(SexoEmp in('M','F')) not null, 
Puesto nvarchar(1) constraint Cpuesto check(Puesto in('V','R','G','C'))not null, /*Vendedor,Gerente,Cocinero,Repartidor */
NombreCalle char(50)  null default 'Docimicilio Conocido',
NumExt int null default 0,
NumInt int null default 0,
Colonia char(50) not null,
Municipio char(50) not null,
CodigoPostal char(5) not null constraint CP check(CodigoPostal like '[0-9][0-9][0-9][0-9][0-9]'),
Telefono char(10) null  Default 'S/N',
HoraEntrada time not null,
HoraSalida time not null,
Salario money not null constraint CsalarioCHECK (Salario > 1000 AND Salario < 2000),
Contraseña nvarchar(10) not null
)

create table Proveedores
(
IdProveedor int identity(1,1) primary key not null,
NombreProveedor varchar(20) not null,
ApePatPro varchar(20) not null,
ApeMatPro varchar(20) null,
NombreCalle char(50) not null default 'Docimicilio Conocido',
NumExt int not null default 'S/N',
NumInt int null,
Colonia char(50) not null,
Municipio char(50) not null,
CodigoPostal char(5) not null constraint CodigoPostalProvee check(CodigoPostal like '[0-9][0-9][0-9][0-9][0-9]'),
Telefono numeric Default '000-000-0000',
CE nvarchar(50) null Default 'Sin Correo Electronico',
Marca nvarchar(20) not null
)

Create table MateriaPrima
(
IdMateriaPrima int identity(1,1) primary key not null,
Nombre nvarchar(20) not null,
Cantidad int not null,
TipoMP nvarchar(3) not null constraint CtipoMP check(TipoMP in('LAC','CAR','VER','FRU','HAR','GRS'))
) 

create table PedidoProveedor
(
IdDetallePP int not null primary key identity(1,1),
Pedido nvarchar(50) not null,
Cantidad int not null,
Precio money not null,
FechaPedido datetime not null constraint CfechapedidoCHECK (FechaPedido > '01-01-2019' AND FechaPedido < getdate()),
Observaciones char(50) not null,
)

create table DetallePedido
(
IdDetallePP int not null foreign key references PedidoProveedor(IdDetallePP),
IdProveedor int not null foreign key references Proveedores(IdProveedor),
)

create Table PagosProveedor
(
IdPagosProveedor int primary key not null identity(1,1),
FechaDePago datetime not null,
Pago money not null,
IdDetallePP int not null foreign key references PedidoProveedor(IdDetallePP)
)

Create table DetalleMateriaPrima
(
IdDetalleMateriaPrima int not null primary key identity(1,1),
FechaEntrada datetime not null constraint CfechaEnCHECK (FechaEntrada > '01-01-2019' AND FechaEntrada < getdate()),
FechaUso datetime not null default getdate(),
Precio money not null,
IdMateriaPrima int not null foreign key references MateriaPrima(IdMateriaPrima),
IdDetallePP int not null foreign key references PedidoProveedor(IdDetallePP)
)

create table Producto
(
IdProducto int identity(1,1) primary key not null,
NombrePro nvarchar(20) not null,
PrecioPro money not null,
Descripcion nvarchar(50) not null,
Cantidad int not null,
)

create table DetalleProducto
(
IdDetalleProducto int not null primary key identity(1,1),
Categoria nvarchar(6)not null constraint Ccategoria check(Categoria in('Pizza','Churro','Elado','Bebida')),
IdMateriaPrima int not null foreign key references MateriaPrima(IdMateriaPrima),
IdProducto int not null foreign key references Producto(IdProducto)
)

Create table Cliente
(
IdCliente int identity(1,1) primary key not null,
NombreC nvarchar(20) not null,
ApePatC varchar(50)not null,
ApeMatC varchar(50)null,
NombreCalle char(50) null default 'Docimicilio Conocido',
NumExt int not null default 'S/N',
NumInt int null,
Colonia char(50) not null,
Municipio char(50) not null,
CodigoPostal char(5) not null constraint CPcleinte check(CodigoPostal like '[0-9][0-9][0-9][0-9][0-9]'),
Telefono numeric Default '000-000-0000',
CE nvarchar(50) null Default 'Sin Correo Electronico',
TipoCliente nvarchar(1) not null constraint CTipoCliente check(TipoCliente in('F','P')),/*frecuente,Premium*/
)

create table Venta
(
IdVenta int not null primary key identity(1,1),
Monto money not null,
cantidad int not null
)

create table DetalleVenta
(
IdDetalleVenta int not null primary key identity(1,1),
Descuento money null,
cantidad int not null,
FechaVenta datetime not null,
IdVenta int not null foreign key references Venta(IdVenta),
IdEmpleado int not null foreign key references Empleados(IdEmpleado),
IdProducto int not null foreign key references Producto(IdProducto),
IdCliente int null foreign key references Cliente(IdCliente),
)

create table viaje 
( 
IdDetalleVenta int not null foreign key references DetalleVenta(IdDetalleVenta),
IdUnidad int not null foreign key references Vehiculo(IdUnidad),
Distancia nvarchar(20) not null
)

Create table Vehiculo
(
IdUnidad int identity(80,1) primary key not null,
NombreVehiculo nvarchar(20) not null,
Marca nvarchar(20) not null,
Modelo nvarchar(20) not null,
)
select IdEmpleado,Contraseña from Empleados
select * from Empleados
select * from Proveedores
select * from MateriaPrima
select * from PedidoProveedor
select * from PagosProveedor
select * from DetalleMateriaPrima
select * from Producto
select * from DetalleProducto
select * from Cliente
select * from Venta
select * from DetalleVenta
select * from Vehiculo


insert into Vehiculo(NombreVehiculo,Marca,Modelo)values ('Z250','Italika','2018'),
  ('r15','yamaha','210'),
  ('sedan','volkswagen','1990'),
  ('Tornado','vento','2020')
