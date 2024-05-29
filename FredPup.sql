drop database FredPup;

create database FredPup;
use FredPup;

create table tbRacao(
CodRacao int primary key auto_increment,
tamanho varchar(50) not null,
sabor varchar(50) not null,
marca varchar(50) not null,
animal varchar(50) not null,
total varchar(50) not null
);

create table tbPote(
CodPote int primary key auto_increment,
tamanho varchar(50) not null,
tipo varchar(50) not null,
cor varchar(50) not null,
total varchar(50) not null
);

create table tblogin(
 codigo int primary key auto_increment,
 email varchar(50) not null,
 senha varchar(50) not null
);

create table tbCliente(
CodCli int primary key auto_increment,
nome varchar(50) not null,
email varchar(50) not null,
telefone varchar(20) not null,
imagem varchar(100) not null
);

insert into tblogin(email, senha) values ('fred@gmail.com','1234');

select * from tbRacao;
select * from tbPote;
select * from tbCliente;

create table tbAnimal(
CodPet int primary key auto_increment,
nome varchar(50) not null,
raca varchar(50) not null,
peso varchar(50) not null,
sexo varchar(50) not null,
especie varchar(50) not null,
tutor varchar(50) not null,
telefone varchar(50) not null,
email varchar(50) not null,
imagem varchar(100)
);

create table tbConsultas(
	codConsulta int primary key auto_increment,
    dataConsulta datetime not null,
    receituario varchar(200),
    descricao varchar(200),
    CodPet int,
    FOREIGN KEY (CodPet) REFERENCES tbAnimal(CodPet)
);

create table tbExames(
	codExame int primary key auto_increment,
    dataExame datetime not null,
    diagnostico varchar(200),
    descricao varchar(200),
    CodPet int,
    FOREIGN KEY (CodPet) REFERENCES tbAnimal(CodPet)
);

select * from tbConsultas;
select * from tbExames;
