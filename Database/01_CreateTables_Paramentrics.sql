CREATE TABLE Usuario
(
	ID INT NOT NULL IDENTITY(1,1),
	Nombre VARCHAR(200) NOT NULL,
	Clave VARCHAR(200) NOT NULL,
	EmpleadoID INT NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Activo BIT NOT NULL,
	FechaCreacion DATETIME NOT NULL,
	FechaActualizacion DATETIME

	CONSTRAINT PK_Usuario PRIMARY KEY (ID)
)

CREATE TABLE Empleado 
(
	ID INT NOT NULL IDENTITY(1,1),
	CompaniaID INT NOT NULL


	CONSTRAINT PK_Empleado PRIMARY KEY (ID)
)

CREATE TABLE EmpleadoPerfil
(
	ID INT NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Apellido VARCHAR(100) NOT NULL,
	Documento VARCHAR(100) NOT NULL,
	EmailPersonal VARCHAR(100) NOT NULL,

	CONSTRAINT PK_EmpleadoPerfil PRIMARY KEY (ID)
)

CREATE TABLE Pais
(
	ID INT NOT NULL,
	Descripcion VARCHAR(100) NOT NULL,
	IsoCode VARCHAR(10) NOT NULL

	CONSTRAINT PK_Pais PRIMARY KEY (ID)
)


CREATE TABLE Lenguaje
(
	ID INT NOT NULL,
	Descripcion VARCHAR(100) NOT NULL,
	IsoCode VARCHAR(10) NOT NULL

	CONSTRAINT PK_Lenguage PRIMARY KEY (ID)
)

CREATE TABLE Recurso
(
	Clave VARCHAR(100) NOT NULL,
	LenguajeID INT NOT NULL,
	Valor VARCHAR(100) NOT NULL


	CONSTRAINT PK_Recurso PRIMARY KEY (Clave, LenguajeID)
)

CREATE TABLE TicketTipo
(
	ID INT NOT NULL,
	Descripcion VARCHAR(50) NOT NULL,

	CONSTRAINT PK_TicketTipo PRIMARY KEY (ID)
)

CREATE TABLE TicketEstado
(
	ID INT NOT NULL,
	Descripcion VARCHAR(50) NOT NULL,

	CONSTRAINT PK_TicketEstado PRIMARY KEY (ID)
)

CREATE TABLE TelefonoTipo
(
	ID INT NOT NULL,
	Descripcion VARCHAR(50) NOT NULL,

	CONSTRAINT PK_TelefonoTipo PRIMARY KEY (ID)

)

-- CONSTRAINTS

ALTER TABLE EmpleadoPerfil ADD CONSTRAINT FK_EmpleadoPerfil_Empleado FOREIGN KEY (ID) REFERENCES Empleado(ID)

ALTER TABLE Recurso ADD CONSTRAINT FK_Recurso_Lenguaje FOREIGN KEY (LenguajeID) REFERENCES Lenguaje(ID)


-- PARAMENTRICAS

--TicketEstado
INSERT INTO TicketEstado(ID,Descripcion) VALUES(1,'Borrador')
INSERT INTO TicketEstado(ID,Descripcion) VALUES(2,'Pendiente')
INSERT INTO TicketEstado(ID,Descripcion) VALUES(3,'Observacion')
INSERT INTO TicketEstado(ID,Descripcion) VALUES(4,'Finalizado')
INSERT INTO TicketEstado(ID,Descripcion) VALUES(5,'Cerrado')
INSERT INTO TicketEstado(ID,Descripcion) VALUES(6,'Inconcluso')


--TelefonoTipo
INSERT INTO TelefonoTipo(ID,Descripcion) VALUES(1,'Oficina')
INSERT INTO TelefonoTipo(ID,Descripcion) VALUES(2,'Personal')
INSERT INTO TelefonoTipo(ID,Descripcion) VALUES(1,'Celular')


--TicketTipo
INSERT INTO TicketTipo(ID,Descripcion) VALUES(1,'Local')
INSERT INTO TicketTipo(ID,Descripcion) VALUES(2,'Redes')
INSERT INTO TicketTipo(ID,Descripcion) VALUES(3,'Infraestructura')
INSERT INTO TicketTipo(ID,Descripcion) VALUES(4,'Seguridad')


--Pais
INSERT INTO Pais(ID,Descripcion,IsoCode) VALUES(1,'Argentina','AR')
INSERT INTO Pais(ID,Descripcion,IsoCode) VALUES(2,'Estados Unidos','US')