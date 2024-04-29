IF NOT EXISTS (SELECT * FROM sys.databases WHERE name='CentroConvenciones')
CREATE DATABASE CentroConvenciones
GO

USE CentroConvenciones
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Solicita')
DROP TABLE Solicita
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ExistenciaServicio')
DROP TABLE ExistenciaServicio
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Servicios')
DROP TABLE Servicios
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuario')
DROP TABLE Usuario
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Rol')
DROP TABLE Rol
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Organizador')
DROP TABLE Organizador
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Responsable')
DROP TABLE Responsable
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Evento')
DROP TABLE Evento
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Direccion')
DROP TABLE Direccion
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Salon')
DROP TABLE Salon
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TipoSalon')
DROP TABLE TipoSalon
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TipoEvento')
DROP TABLE TipoEvento
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Contacto_Telefono')
DROP TABLE Contacto_Telefono
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Contacto_Email')
DROP TABLE Contacto_Email
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Contacto')
DROP TABLE Contacto
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Itinerario')
DROP TABLE Itinerario
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Persona')
DROP TABLE Persona
GO

CREATE TABLE Persona
(
  IdPersona INTEGER PRIMARY KEY IDENTITY(1,1),
  Nombre VARCHAR(100) NOT NULL,
);

CREATE TABLE Direccion
(
  IdDireccion INTEGER PRIMARY KEY IDENTITY(1,1),
  DireccionDetallada VARCHAR(150) NOT NULL,
  Municipio VARCHAR(50),
  Departamento VARCHAR(50),
);
GO

CREATE TABLE Organizador
(
  IdPersona INTEGER PRIMARY KEY IDENTITY(1,1),
  Estado BINARY NOT NULL,
  FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona)
);
GO

CREATE TABLE Responsable
(
  IdPersona INTEGER PRIMARY KEY IDENTITY(1,1),
  NombreComercial VARCHAR(150),
  FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona)
);
GO

CREATE TABLE Rol
(
  IdRol INTEGER PRIMARY KEY IDENTITY(1,1),
  NombreRol VARCHAR(75) NOT NULL,
  Descripcion VARCHAR(150) NOT NULL,
);
GO

CREATE TABLE Itinerario
(
  IdItinerario INTEGER PRIMARY KEY IDENTITY(1,1),
  FechaInicio DATE NOT NULL,
  FechaCulminacion DATE NOT NULL,
  HoraInicio TIME NOT NULL,
  HoraCulminacion TIME NOT NULL,
);
GO

CREATE TABLE TipoEvento
(
  IdTipoEvento INTEGER PRIMARY KEY IDENTITY(1,1),
  NombreTipoEvento VARCHAR(75) NOT NULL,
  Descripcion VARCHAR(150),
);
GO

CREATE TABLE Servicios
(
  IdServicio INTEGER PRIMARY KEY IDENTITY(1,1),
  NombreServicio VARCHAR(100) NOT NULL,
  DescripcionServicio VARCHAR(150),
);
GO

CREATE TABLE Contacto
(
  IdContacto INTEGER PRIMARY KEY IDENTITY(1,1),
  EstadoContacto BINARY NOT NULL,
);
GO

CREATE TABLE ExistenciaServicio
(
  IdExistencia INTEGER PRIMARY KEY IDENTITY(1,1),
  CantidadTotal INT NOT NULL,
  IdServicio INT NOT NULL,
  FOREIGN KEY (IdServicio) REFERENCES Servicios(IdServicio)
);
GO

CREATE TABLE Contacto_Telefono
(
  Telefono CHAR(8) NOT NULL,
  IdContacto INT NOT NULL,
  FOREIGN KEY (IdContacto) REFERENCES Contacto(IdContacto)
);
GO

CREATE TABLE Contacto_Email
(
  Email VARCHAR(100) NOT NULL,
  IdContacto INT NOT NULL,
  FOREIGN KEY (IdContacto) REFERENCES Contacto(IdContacto)
);
GO

CREATE TABLE Usuario
(
  IdUsuario INTEGER PRIMARY KEY IDENTITY(1,1),
  Usuario VARCHAR(50) NOT NULL,
  Contrasenia VARCHAR(126) NOT NULL,
  Nombre VARCHAR(100) NOT NULL,
  Estado BIT NOT NULL DEFAULT 1,
  IdRol INT NOT NULL,
  IdDireccion INT NOT NULL,
  IdContacto INT NOT NULL,
  FOREIGN KEY (IdRol) REFERENCES Rol(IdRol),
  FOREIGN KEY (IdDireccion) REFERENCES Direccion(IdDireccion),
  FOREIGN KEY (IdContacto) REFERENCES Contacto(IdContacto),
);
GO

CREATE TABLE TipoSalon
(
  IdTipoSalon INTEGER PRIMARY KEY IDENTITY(1,1),
  NombreTipoSalon VARCHAR(100) NOT NULL,
  ExistenciasTipoSalon INT NOT NULL,
);
GO

CREATE TABLE Salon
(
  IdSalon INTEGER PRIMARY KEY IDENTITY(1,1),
  NombreSalon VARCHAR(100) NOT NULL,
  EstadoSalon VARCHAR(75) NOT NULL,
  Capacidad INT NOT NULL,
  Descripcion VARCHAR(150),
  IdTipoSalon INT NOT NULL,
  FOREIGN KEY (IdTipoSalon) REFERENCES TipoSalon(IdTipoSalon)
);
GO

CREATE TABLE Evento
(
  IdEvento INTEGER PRIMARY KEY IDENTITY(1,1),
  Descripcion VARCHAR(150) NOT NULL,
  EstadoEvento VARCHAR(75) NOT NULL,
  CantidadAsistentes INT NOT NULL,
  Nombre VARCHAR(100) NOT NULL,
  FechaReserva DATE NOT NULL,
  IdItinerario INT NOT NULL,
  IdPersona INT NOT NULL,
  IdTipoEvento INT NOT NULL,
  IdSalon INT NOT NULL,
  FOREIGN KEY (IdItinerario) REFERENCES Itinerario(IdItinerario),
  FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona),
  FOREIGN KEY (IdTipoEvento) REFERENCES TipoEvento(IdTipoEvento),
  FOREIGN KEY (IdSalon) REFERENCES Salon(IdSalon)
);
GO

CREATE TABLE Solicita
(
  IdSolicitud INTEGER PRIMARY KEY IDENTITY(1,1),
  Detalle VARCHAR(100) NOT NULL,
  Cantidad INT NOT NULL,
  IdEvento INT NOT NULL,
  IdExistencia INT NOT NULL,
  FOREIGN KEY (IdEvento) REFERENCES Evento(IdEvento),
  FOREIGN KEY (IdExistencia) REFERENCES ExistenciaServicio(IdExistencia),
  UNIQUE (IdEvento, IdExistencia)
);
GO

INSERT INTO Rol (NombreRol, Descripcion) 
VALUES 
	('Administrador', 'Puede hacer todo dentro del sistema'),
	('Digitador', 'Puede realizar reservas'),
	('Supervisor', 'Puede gestionar los servicios adicionales'),
	('Director', 'Puede gestionar los reportes');
INSERT INTO Direccion (DireccionDetallada, Municipio, Departamento)
VALUES 
	('Ciudad', 'Quetzaltenango', 'Quetzaltenango'),
	('Ciudad', 'Colotenango', 'Huehuetenango'),
	('Ciudad', 'Momostenango', 'Totonicapan'),
	('Ciudad', 'Quetzaltenango', 'Quetzaltenango');
INSERT INTO Contacto (EstadoContacto)
VALUES 
	(1),
	(1),
	(1),
	(1);
INSERT INTO Contacto_Telefono (Telefono, IdContacto)
VALUES 
	('64913620', 1),
	('86254136', 2),
	('52632301', 3),
	('26514035', 4);
INSERT INTO Contacto_Email (Email, IdContacto)
VALUES 
	('alex@ggmail.com', 1),
	('samuel@ggmail.com', 2),
	('juan@ggmail.com', 3),
	('pedro@ggmail.com', 4);
INSERT INTO Usuario (Usuario, Contrasenia, Nombre, Estado, IdRol, IdDireccion, IdContacto)
VALUES 
	('alex', 'alex', 'Alex Bollen', 1, 1, 1, 1),
	('samuel', 'samuel', 'Samuel Quijivix', 1, 2, 2, 2),
	('juan', 'juan', 'Juan Perez', 1, 3, 3, 3),
	('pedro', 'pedro', 'Pedro Lopez', 1, 4, 4, 4);