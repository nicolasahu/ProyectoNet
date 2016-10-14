create database banco;
go
use banco;

create table ciudad(
	id int not null identity(1,1),
	nombre varchar(100),
	primary key(id),
);

create table privilegio(
	id int not null identity(1,1),
	Descripcion varchar(100),
	primary key(id)
);

insert into privilegio values ('Administrador'),('Ejecutivo'),('Cliente');

create table usuario(
	id int not null identity(1,1),
	nombre_login varchar(150),
	contraseña varchar(150),
	privilegio int,
	primary key (id),
	foreign key(privilegio) references privilegio(id),
);

insert into usuario values ('admin','admin',1);
insert into usuario values ('ejec1','ejec',2);
insert into usuario values ('user1','user1',3);


create table administrador(
	id int not null identity(1,1),
	rut varchar(20),
	nombre varchar(50),
	usuario int,
	foreign key(usuario) references usuario(id),
	primary key(id),
);

create table ejecutivo(
	id int not null identity(1,1),
	rut varchar(20),
	nombre varchar(100),
	usuario int,
	foreign key(usuario) references usuario(id),
	primary key(id),
);

create table cliente(
	id int not null identity(1,1),
	rut varchar(20),
	nombre_completo varchar(200),
	direccion varchar(200),
	ciudad int,
	correo varchar(200),
	fecha_nacimiento date,
	usuario int,
	primary key(id),
	foreign key(usuario) references usuario(id),
	foreign key(ciudad) references ciudad(id),
);

create table cuenta(
	id int not null identity(1,1),
	num_cuenta int,
	cliente int,
	saldo money,
	fecha_creacion date,
	ejecutivo int,
	activo bit,
	primary key(id),
	foreign key (cliente) references cliente(id),
	foreign key(ejecutivo) references ejecutivo(id),
);

--select*from cuenta;
--select*from cliente;


create table tarjeta_tranferencia(
	id int not null identity (1,1),
	numeros varchar(200),
	cuenta int,
	primary key (id),
	foreign key(cuenta) references cuenta(id),
);

--select*from tarjeta_tranferencia;

create table transferencia(
	id int not null identity(1,1),
	monto money,
	fecha date,
	cuentaO int,
	cuentaD int,
	comentario varchar(500),
	primary key(id),
	foreign key(cuentaO) references cuenta(id),
	foreign key(cuentaD) references cuenta(id),
);
--select*from cuenta;
--select*from transferencia;
create table credito(
	id int not null identity(1,1),
	cuenta int,
	estado bit,
	ejecutivo int,
	monto money,
	primary key(id),
	foreign key(cuenta) references cuenta(id),
	foreign key(ejecutivo) references ejecutivo(id),
);

--update ejecutivo set nombre='EmilioEjecutivox', rut='222-2', usuario='2' where id='2'
--select*from ejecutivo;

insert into administrador values('Emilio','111-1',1);
insert into ejecutivo values('EmilioEjec','222-2',2);
insert into ejecutivo values('222-2','EmilioEjec',2);
insert into ciudad values('Rancagua');
insert into cliente values('333-3','ElMejorCliente', 'SiempreViva123', 1, 'correo@dominio.cl', '21/10/1992',3);

--select*from ciudad;
--select*from ejecutivo;

--select*from usuario;
--delete from ejecutivo where id=1;
--select*from cliente;select*from usuario;

--update ciudad set nombre='Valparaiso' where id=3;