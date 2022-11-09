Create Table Usuarios
(usuario Varchar(100),
contraseña varchar(100))

insert into Usuarios values ('Admin1', '1234')
insert into Usuarios values ('User1', '112233')
insert into Usuarios values ('Thiago', '114084')
insert into Usuarios values ('Nico', '114403')

create procedure PA_CONS_USUARIOS
as
begin 
select * from Usuarios
end

-----------Modificacion Producto-------
create procedure PA_UPD_PROD
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


alter table productos
add estado varchar(50)
update productos 
set estado = 'Activo'


create procedure PA_BAJA_PROD
@nro int
as
begin
update productos
set estado = 'Baja'
where cod_producto = @nro
end

exec PA_BAJA_PROD 15

select * from productos











-------Carga Cliente---
select * from clientes
create procedure PA_INSERT_CLIENTE
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
------Combos Cliente----
create procedure PA_CONS_TIPODOC
as
begin
select * from tipos_doc
end

create procedure PA_CONS_BARRIOS_CBA
as
begin
select cod_barrio, barrio
from barrios
where cod_localidad = 543
end

create procedure PA_CONS_TIPO_CLI
as
begin 
select * from tipo_cliente
end

delete from productos 
where descripcion like 'prueba%'
select * from productos