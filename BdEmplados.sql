create database Empleados;
use Empleados;
create table detalles(
Codigo	int 	not null	primary key,
Nombre	varchar(50)	null,
puesto	varchar(30)	not null,
fechaNac	int		not null,
sexo	varchar(10) not null,
Estado	varchar(10)	null
);
select * from detalles;
