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