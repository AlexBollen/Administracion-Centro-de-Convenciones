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

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Evento')
DROP TABLE Evento
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Organizador')
DROP TABLE Organizador
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Responsable')
DROP TABLE Responsable
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

DROP PROC InsertarEvento;
DROP PROC InsertarItinerario;
DROP PROC InsertarPersona;
DROP PROC InsertarResponsable;
DROP PROC ListarEventos;
DROP PROC ListarOrganizadores;
DROP PROC ListarSalones;
DROP PROC ListarTipoEvento;

CREATE TABLE Persona
(
  IdPersona INTEGER PRIMARY KEY IDENTITY(1,1),
  NombrePersona VARCHAR(100) NOT NULL,
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
  IdOrganizador INTEGER PRIMARY KEY IDENTITY(1,1),
  Estado BIT NOT NULL DEFAULT 1,
  IdPersona INT NOT NULL,
  FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona)
);
GO

CREATE TABLE Responsable
(
  IdResponsable INTEGER PRIMARY KEY IDENTITY(1,1),
  NombreComercial VARCHAR(100),
  IdPersona INT NOT NULL,
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
  HoraInicio VARCHAR(25) NOT NULL,
  HoraCulminacion VARCHAR(25) NOT NULL,
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
  Nombre VARCHAR(100) NOT NULL,
  Descripcion VARCHAR(150) NOT NULL,
  EstadoEvento VARCHAR(75) NOT NULL,
  CantidadAsistentes INT NOT NULL,
  FechaReserva DATE NOT NULL,
  IdItinerario INT NOT NULL,
  IdResponsable INT NOT NULL,
  IdOrganizador INT NOT NULL,
  IdTipoEvento INT NOT NULL,
  IdSalon INT NOT NULL,
  FOREIGN KEY (IdItinerario) REFERENCES Itinerario(IdItinerario),
  FOREIGN KEY (IdResponsable) REFERENCES Responsable(IdResponsable),
  FOREIGN KEY (IdOrganizador) REFERENCES Organizador(IdOrganizador),
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
INSERT INTO TipoSalon (NombreTipoSalon, ExistenciasTipoSalon)
VALUES
	('Eventos grandes', 10),
	('Conferencias', 5),
	('Bodas', 3),
	('Fiestas privadas', 2);
INSERT INTO Salon(NombreSalon, EstadoSalon, Capacidad, Descripcion, IdTipoSalon)
VALUES
	('Palacio de eventos', 'Disponible', 500, '', 1),
	('Jardín encantado', 'Disponible', 250, '', 1),
	('Horizonte dorado', 'Disponible', 220, 'Un ambiente armonioso y memorable, ideal para eventos sociales, conciertos o presentaciones artísticas', 1),
	('Sinfonía de eventos', 'Disponible', 350, 'Perfecto para eventos de premiación, lanzamientos de productos, etc.', 1),
	('Grand Atrium', 'Disponible', 370, '', 1),
	('Festival de alegría', 'Disponible', 400, 'Evoca un ambiente festivo y divertido, ideal para fiestas infantiles, eventos familiares o celebraciones comunitarias.', 1),
	('Esplandor', 'Disponible', 280, 'Transmite lujo, opulencia y sofisticación, perfecto para eventos de alta gama.', 1),
	('Paraíso Mágico', 'Disponible', 250, 'Ideal para eventos que buscan crear una atmósfera única y memorable.', 1),
	('Salón real', 'Disponible', 375, 'Inspirado en la grandiosidad de los templos antiguos, lugar sagrado donde las celebraciones adquieren un significado especial', 1),
	('Espacio imperial', 'Disponible', 240, 'Espacio perfecto para eventos que buscan dejar una impresión duradera y memorable en los asistentes.', 1),
	('Ágora', 'Disponible', 150, 'Perfecto para salas de conferencias donde se llevan a cabo eventos como congresos, seminarios o talleres.', 2),
	('Circulo de ideas', 'Disponible', 100, 'Ambiente de colaboración e intercambio de conocimientos.', 2),
	('Foro del pensamiento', 'Disponible', 130, ' Espacio para la reflexión y el análisis profundo.', 2),
	('Simposio', 'Disponible', 110, 'Se asocia con reuniones académicas o profesionales de alto nivel.', 2),
	('Convergencia', 'Disponible', 75, 'Evoca la unión de diferentes perspectivas y puntos de vista.', 2),
	('Jadrín de ensueño', 'Disponible', 200, 'Evoca un ambiente romántico y mágico, perfecto para bodas al aire libre', 3),
	('Romance encantado', 'Disponible', 250, 'Evoca un ambiente íntimo y romántico', 3),
	('Atrio', 'Disponible', 210, 'Un nombre clásico y atemporal que denota un espacio abierto y versátil', 3),
	('Oasis', 'Disponible', 75, '', 4),
	('El amigo', 'Disponible', 90, '', 4);
INSERT INTO Itinerario (FechaInicio, FechaCulminacion, HoraInicio, HoraCulminacion)
VALUES
	('2024-05-01', '2024-05-01', '9:00:00', '17:00:00');
INSERT INTO TipoEvento (NombreTipoEvento, Descripcion)
VALUES
	('Boda', 'Celebración de matrimonios'),
	('Fiesta', 'Celebración de cumpleaños, graduaciónes, etc.'),
	('Conferencia', 'Conferencias, simposios, debates, etc.'),
	('Concierto', 'Conciertos musicales'),
	('Exposición', 'Presentaciones de productos, ideas, empresas, etc.'),
	('Feria comercial', 'Ventas de productos');
INSERT INTO Persona (NombrePersona)
VALUES
	('Pedro David Gómez Bolaños'),
	('Juan Luis Hernández');
INSERT INTO Organizador (Estado, IdPersona)
VALUES
	(1, 1);
INSERT INTO Responsable (NombreComercial, IdPersona)
VALUES
	(NULL, 2);
INSERT INTO Evento (Nombre, Descripcion, EstadoEvento, CantidadAsistentes, FechaReserva, IdItinerario, IdResponsable, IdOrganizador, IdTipoEvento, IdSalon)
VALUES
	('Boda Hernández-Dominguez', 'Celebración de matrimonio de señor Juan Hernández y Luisa Dominguez', 'Finalizado', 150, '2024-01-15', 1, 1, 1, 1, 16)
