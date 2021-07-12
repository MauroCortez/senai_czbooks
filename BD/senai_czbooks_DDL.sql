CREATE DATABASE senai_czbooks

USE senai_czbooks

CREATE TABLE TipoUsuario
(
	idTipoUsuario	INT PRIMARY KEY IDENTITY
	,TipoUsuario		VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Usuario
(
	idUsuario		INT PRIMARY KEY IDENTITY
	,idTipoUsuario	INT FOREIGN KEY REFERENCES	TipoUsuario(idTipoUsuario)
	,Usuario		VARCHAR(200)	NOT NULL UNIQUE
	,Senha			VARCHAR(200)	NOT NULL
);
GO

CREATE TABLE Empresa
(
	idEmpresa		INT PRIMARY KEY IDENTITY
	,NomeFantasia	VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Livro
(
	idLivro			INT PRIMARY KEY IDENTITY
	,idUsuario		INT FOREIGN KEY REFERENCES Usuario(idUsuario)
	,idEmpresa		INT FOREIGN KEY REFERENCES Empresa(idEmpresa)
	,Titulo			VARCHAR(200)	NOT NULL
	,Sinopse		VARCHAR(2000)	NOT NULL
	,Categoria		VARCHAR(200)	NOT NULL
	,DataPublicacao DATE			NOT NULL
	,Preco			VARCHAR(200)	NOT NULL
);
GO