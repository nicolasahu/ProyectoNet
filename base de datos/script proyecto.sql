create database banco;

use banco;
go


create table privilegio
(
id int not null identity(1,1),
Descripcion varchar(100),
primary key(id)
);

insert into privilegio values
('Administrador'),('Ejecutivo');

create table usuario
(
id int not null identity(1,1),
nombre_login varchar(150),
contraseña varchar(150),
privilegio int,
primary key (id),
foreign key(privilegio) references privilegio(id),
);
insert into usuario values 
('admin','admin',1);

create table cliente
(
id int not null identity(1,1),
rut varchar(20),
nombre_completo varchar(200),
direccion varchar(200),
ciudad varchar(150),
correo varchar(200),
fecha_nacimiento date,
primary key(id)
);

create table tarjeta_tranferencia
(
id int not null identity (1,1),
numeros varchar(200),
primary key (id)
);


create table cuenta
(
id int not null identity(1,1),
num_cuenta int,
cliente int,
tarjeta_tranferencia int,
saldo money,
primary key(id),
foreign key (cliente) references cliente(id),
foreign key (tarjeta_tranferencia) references tarjeta_tranferencia(id)
);




