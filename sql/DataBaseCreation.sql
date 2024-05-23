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

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Contacto')
DROP TABLE Contacto
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Itinerario')
DROP TABLE Itinerario
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Persona')
DROP TABLE Persona
GO

IF OBJECT_ID('dbo.InsertarEvento') IS NOT NULL
BEGIN
	DROP PROC InsertarEvento;
END;
IF OBJECT_ID('dbo.InsertarItinerario') IS NOT NULL
BEGIN
	DROP PROC InsertarItinerario;
END;
IF OBJECT_ID('dbo.InsertarPersona') IS NOT NULL
BEGIN
	DROP PROC InsertarPersona;
END;
IF OBJECT_ID('dbo.InsertarResponsable') IS NOT NULL
BEGIN
	DROP PROC InsertarResponsable;
END;
IF OBJECT_ID('dbo.ListarEventos') IS NOT NULL
BEGIN
	DROP PROC ListarEventos;
END;
IF OBJECT_ID('dbo.ListarOrganizadores') IS NOT NULL
BEGIN
	DROP PROC ListarOrganizadores;
END;
IF OBJECT_ID('dbo.ListarSalon') IS NOT NULL
BEGIN
	DROP PROC ListarSalon;
END;
IF OBJECT_ID('dbo.ListarTipoSalon') IS NOT NULL
BEGIN
	DROP PROC ListarTipoSalon;
END;
IF OBJECT_ID('dbo.ListarTipoEvento') IS NOT NULL
BEGIN
	DROP PROC ListarTipoEvento;
END;
IF OBJECT_ID('dbo.ActualizarEvento') IS NOT NULL
BEGIN
	DROP PROC ActualizarEvento;
END;
IF OBJECT_ID('dbo.ListarUsuarios') IS NOT NULL
BEGIN
	DROP PROC ListarUsuarios;
END;
IF OBJECT_ID('dbo.ListarServicios') IS NOT NULL
BEGIN
	DROP PROC ListarServicios;
END;
IF OBJECT_ID('dbo.ListarRoles') IS NOT NULL
BEGIN
	DROP PROC ListarRoles;
END;
IF OBJECT_ID('dbo.InsertarUsuario') IS NOT NULL
BEGIN
	DROP PROC InsertarUsuario;
END;
IF OBJECT_ID('dbo.InsertarDireccion') IS NOT NULL
BEGIN
	DROP PROC InsertarDireccion;
END;
IF OBJECT_ID('dbo.InsertarServicio') IS NOT NULL
BEGIN
	DROP PROC InsertarServicio;
END;
IF OBJECT_ID('dbo.InsertarExistenciaServicio') IS NOT NULL
BEGIN
	DROP PROC InsertarExistenciaServicio;
END;
IF OBJECT_ID('dbo.InsertarContacto') IS NOT NULL
BEGIN
	DROP PROC InsertarContacto;
END;
IF OBJECT_ID('dbo.ActualizarUsuario') IS NOT NULL
BEGIN
	DROP PROC ActualizarUsuario;
END;
IF OBJECT_ID('dbo.InsertarSalon') IS NOT NULL
BEGIN
	DROP PROC InsertarSalon;
END;
IF OBJECT_ID('dbo.ActualizarSalones') IS NOT NULL
BEGIN
	DROP PROC ActualizarSalones;
END;
IF OBJECT_ID('dbo.InsertarTipoSalon') IS NOT NULL
BEGIN
	DROP PROC InsertarTipoSalon;
END;
IF OBJECT_ID('dbo.ActualizarTipoSalones') IS NOT NULL
BEGIN
	DROP PROC ActualizarTipoSalones;
END;
IF OBJECT_ID('dbo.ActualizarExistenciasTipoSalon') IS NOT NULL
BEGIN
	DROP PROC ActualizarExistenciasTipoSalon;
END;
IF OBJECT_ID('dbo.InsertarTipoEvento') IS NOT NULL
BEGIN
	DROP PROC InsertarTipoEvento;
END;
IF OBJECT_ID('dbo.ActualizarTipoEvento') IS NOT NULL
BEGIN
	DROP PROC ActualizarTipoEvento;
END;
IF OBJECT_ID('dbo.InsertarOrganizadores') IS NOT NULL
BEGIN
	DROP PROC InsertarOrganizadores;
END;
IF OBJECT_ID('dbo.ActualizarOrganizador') IS NOT NULL
BEGIN
	DROP PROC ActualizarOrganizador;
END;
IF OBJECT_ID('dbo.ActualizarServicio') IS NOT NULL
BEGIN
	DROP PROC ActualizarServicio;
END;
IF OBJECT_ID('dbo.ActualizarAsignacionEspecifica') IS NOT NULL
BEGIN
	DROP PROC ActualizarAsignacionEspecifica;
END;
IF OBJECT_ID('dbo.ObtenerExistenciasServicios') IS NOT NULL
BEGIN
	DROP PROC ObtenerExistenciasServicios;
END;
IF OBJECT_ID('dbo.ListarAsignacionEventos') IS NOT NULL
BEGIN
	DROP PROC ListarAsignacionEventos;
END;
IF OBJECT_ID('dbo.AsignacionServicio') IS NOT NULL
BEGIN
	DROP PROC AsignacionServicio;
END;
IF OBJECT_ID('dbo.ObtenerFechaEvento') IS NOT NULL
BEGIN
	DROP PROC ObtenerFechaEvento;
END;
IF OBJECT_ID('dbo.ObtenerServiciosEvento') IS NOT NULL
BEGIN
	DROP PROC ObtenerServiciosEvento;
END;
IF OBJECT_ID('dbo.InsertarAsignacionServicio') IS NOT NULL
BEGIN
	DROP PROC InsertarAsignacionServicio;
END;

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
  EstadoOrganizador VARCHAR(75) NOT NULL,
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
  Telefono CHAR(8) NOT NULL,
  Email VARCHAR(100) NOT NULL,
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
  Servicios BIT NOT NULL DEFAULT 0,
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
INSERT INTO Contacto (EstadoContacto, Telefono, Email)
VALUES 
	(1, '64913620', 'alex@ggmail.com'),
	(1, '86254136', 'samuel@ggmail.com'),
	(1, '52632301', 'juan@ggmail.com'),
	(1, '26514035', 'pedro@ggmail.com');
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
	('Jard�n encantado', 'Disponible', 250, '', 1),
	('Horizonte dorado', 'Disponible', 220, 'Un ambiente armonioso y memorable, ideal para eventos sociales, conciertos o presentaciones art�sticas', 1),
	('Sinfon�a de eventos', 'Disponible', 350, 'Perfecto para eventos de premiaci�n, lanzamientos de productos, etc.', 1),
	('Grand Atrium', 'Disponible', 370, '', 1),
	('Festival de alegr�a', 'Disponible', 400, 'Evoca un ambiente festivo y divertido, ideal para fiestas infantiles, eventos familiares o celebraciones comunitarias.', 1),
	('Esplandor', 'Disponible', 280, 'Transmite lujo, opulencia y sofisticaci�n, perfecto para eventos de alta gama.', 1),
	('Para�so M�gico', 'Disponible', 250, 'Ideal para eventos que buscan crear una atm�sfera �nica y memorable.', 1),
	('Sal�n real', 'Disponible', 375, 'Inspirado en la grandiosidad de los templos antiguos, lugar sagrado donde las celebraciones adquieren un significado especial', 1),
	('Espacio imperial', 'Disponible', 240, 'Espacio perfecto para eventos que buscan dejar una impresi�n duradera y memorable en los asistentes.', 1),
	('�gora', 'Disponible', 150, 'Perfecto para salas de conferencias donde se llevan a cabo eventos como congresos, seminarios o talleres.', 2),
	('Circulo de ideas', 'Disponible', 100, 'Ambiente de colaboraci�n e intercambio de conocimientos.', 2),
	('Foro del pensamiento', 'Disponible', 130, ' Espacio para la reflexi�n y el an�lisis profundo.', 2),
	('Simposio', 'Disponible', 110, 'Se asocia con reuniones acad�micas o profesionales de alto nivel.', 2),
	('Convergencia', 'Disponible', 75, 'Evoca la uni�n de diferentes perspectivas y puntos de vista.', 2),
	('Jadr�n de ensue�o', 'Disponible', 200, 'Evoca un ambiente rom�ntico y m�gico, perfecto para bodas al aire libre', 3),
	('Romance encantado', 'Disponible', 250, 'Evoca un ambiente �ntimo y rom�ntico', 3),
	('Atrio', 'Disponible', 210, 'Un nombre cl�sico y atemporal que denota un espacio abierto y vers�til', 3),
	('Oasis', 'Disponible', 75, '', 4),
	('El amigo', 'Disponible', 90, '', 4);
INSERT INTO Itinerario (FechaInicio, FechaCulminacion, HoraInicio, HoraCulminacion)
VALUES
	('2024-05-01', '2024-05-01', '9:00:00', '17:00:00'),
	('2024-05-01', '2024-05-01', '14:00:00', '19:00:00');
INSERT INTO TipoEvento (NombreTipoEvento, Descripcion)
VALUES
	('Boda', 'Celebraci�n de matrimonios'),
	('Fiesta', 'Celebraci�n de cumplea�os, graduaci�nes, etc.'),
	('Conferencia', 'Conferencias, simposios, debates, etc.'),
	('Concierto', 'Conciertos musicales'),
	('Exposici�n', 'Presentaciones de productos, ideas, empresas, etc.'),
	('Feria comercial', 'Ventas de productos');
INSERT INTO Persona (NombrePersona)
VALUES
	('Pedro David G�mez Bola�os'),
	('Juan Luis Hern�ndez'),
	('Luis Enrique Ju�rez'),
	('Pedro L�pez P�rez');
INSERT INTO Organizador (EstadoOrganizador, IdPersona)
VALUES
	('Ocupado', 1),
	('Ocupado', 4);
INSERT INTO Responsable (NombreComercial, IdPersona)
VALUES
	(NULL, 2),
	(NULL, 3);
INSERT INTO Servicios (NombreServicio, DescripcionServicio)
VALUES
	('Mesas', 'Mesas de alta calidad para todo tipo de eventos'),
	('Manteles', 'Manteles de alta calidad que aportar�n un toque de elegancia y sofisticaci�n a tus mesas.'),
	('Sillas', 'C�modas y elegantes, perfectas para cualquier tipo de evento.'),
	('Velas', 'Complemento perfecto para crear una atm�sfera acogedora.'),
	('Bola disco', 'A�ade un toque de diversi�n y energ�a a tu evento con nuestra bola disco.');
INSERT INTO ExistenciaServicio (CantidadTotal, IdServicio)
VALUES
	(350, 1),
	(375, 2),
	(1500, 3),
	(1000, 4),
	(15, 5);
INSERT INTO Evento (Nombre, Descripcion, EstadoEvento, CantidadAsistentes, FechaReserva, Servicios, IdItinerario, IdResponsable, IdOrganizador, IdTipoEvento, IdSalon)
VALUES
	('Boda Hern�ndez-Dominguez', 'Celebraci�n de matrimonio de se�or Juan Hern�ndez y Luisa Dominguez', 'Programado', 150, '2024-01-15', 1, 1, 1, 1, 1, 16),
	('Cumplea�os Don Pedro', 'Celebraci�n de cumplea�os No. 30 se�or Don Pedro', 'Programado', 75, '2024-01-01', 0, 2, 2, 2, 2, 19);
INSERT INTO Solicita (Detalle, Cantidad, IdEvento, IdExistencia)
VALUES
	('Prestamo de mesas', 10, 1, 1),
	('Prestamo de sillas', 100, 1, 3);