﻿CREATE TABLE EMPRESA(
	IDEMPRESA			UNIQUEIDENTIFIER			NULL,
	RAZAOSOCIAL			NVARCHAR(150)				NULL,
	CNPJ				NVARCHAR(14)				NULL UNIQUE,
	CONTATO				NVARCHAR(15)				NULL,
	EMAIL				NVARCHAR(70)				NULL,
	PRIMARY KEY (IDEMPRESA))
GO

CREATE TABLE COMPRADOR(
	IDCOMPRADOR			UNIQUEIDENTIFIER			NULL,
	NOME				NVARCHAR(150)				NULL,
	CPF					NVARCHAR(11)				NULL UNIQUE,
	CONTATO				NVARCHAR(15)				NULL UNIQUE,
	EMAIL				NVARCHAR(50)				NULL,

	PRIMARY KEY (IDCOMPRADOR))
GO

CREATE TABLE PRODUTO(
	IDPRODUTO			UNIQUEIDENTIFIER			NULL,
	NOME				NVARCHAR(150)				NULL UNIQUE,
	QUANTIDADE			DECIMAL(2)					NULL,
	PRECO				DECIMAL(7,2)				NULL,
	IDEMPRESA			UNIQUEIDENTIFIER			NULL,
	IDCOMPRADOR			UNIQUEIDENTIFIER			NULL,

	PRIMARY KEY (IDPRODUTO),
	FOREIGN KEY (IDEMPRESA) REFERENCES EMPRESA(IDEMPRESA),
	FOREIGN KEY (IDCOMPRADOR) REFERENCES COMPRADOR(IDCOMPRADOR))
GO