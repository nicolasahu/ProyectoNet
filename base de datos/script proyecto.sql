--drop database banco;
--use bd_cds;
create database banco;
go
use banco;

create table ciudad(
	id int not null identity(1,1),
	nombre varchar(100),
	primary key(id),
);

insert into ciudad values('Rancagua'),('Valparaiso'),('Santiago'),('Vina del mar');

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
insert into usuario values ('user2','user2',3);


create table administrador(
	id int not null identity(1,1),
	rut varchar(20),
	nombre varchar(50),
	usuario int,
	foreign key(usuario) references usuario(id),
	primary key(id),
);

insert into administrador values('Emilio','111-1',1);


create table ejecutivo(
	id int not null identity(1,1),
	rut varchar(20),
	nombre varchar(100),
	usuario int,
	foreign key(usuario) references usuario(id),
	primary key(id),
);

insert into ejecutivo values('222-2','EmilioEjec',2);

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

insert into cliente values('333-3','ElMejorCliente', 'SiempreViva123', 1, 'correo@dominio.cl', '21/10/1992',3);
insert into cliente values('444-4','ElMejorCliente2', 'NuncaMuerta123', 1, 'correo2@dominio.cl', '21/10/1982',4);
insert into cliente values('000-0','RepresentanteLegal', 'BancoEstado123', 1, 'correo2@dominio.cl', '21/10/1882',1);

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

--select*from cuenta where ejecutivo=1;
insert into cuenta values(123, 1, '$10000', getDate(), 1, 1);
insert into cuenta values(132, 2, '$10000', getDate(), 1, 1);
insert into cuenta values(112, 3, '$10000000000000', getDate(), 1, 1);

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
insert into transferencia values('40000', getDate(), 2, 1, 'Pago Servicios');


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

--select*from cuenta;
--select*from ejecutivo;
--select*from credito;
insert into credito values(2,1,1,'100000');
--hacer insert transferencia, cuenta origen :banco cuenta destino: cuenta, comentario: aprobacion credito
insert into transferencia values('1000000', getDate(), 3, 1, 'Credito de consumo aprobado');

