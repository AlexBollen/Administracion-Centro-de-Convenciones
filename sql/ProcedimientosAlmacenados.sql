-- Creación de procedimientos almacenados

USE CentroConvenciones
GO

-- Procedimiento para listar eventos
CREATE PROC ListarEventos
AS
SELECT	e.IdEvento,
		e.Nombre,
		e.Descripcion,
		e.EstadoEvento,
		e.CantidadAsistentes,
		organizador.NombrePersona as Organizador,
		responsable.NombrePersona as Responsable,
		e.FechaReserva,
		NombreSalon as Salon,
		NombreTipoEvento as TipoEvento
FROM Evento e
INNER JOIN Persona organizador ON e.IdOrganizador=organizador.IdPersona
INNER JOIN Persona responsable ON e.IdResponsable=responsable.IdPersona
INNER JOIN Salon ON e.IdSalon=Salon.IdSalon
INNER JOIN TipoEvento ON e.IdTipoEvento=TipoEvento.IdTipoEvento
GO


-- Procedimiento para listar salones
CREATE PROC ListarSalon
AS
SELECT s.IdSalon,
	s.NombreSalon,
	s.EstadoSalon,
	s.Capacidad,
	s.Descripcion,
	NombreTipoSalon as TipoSalon
FROM Salon s
INNER JOIN TipoSalon ON s.IdTipoSalon= TipoSalon.IdTipoSalon
GO

-- Procedimiento para listar tipos de salones
CREATE PROC ListarTipoSalon
AS
SELECT * FROM TipoSalon ORDER BY IdTipoSalon ASC
GO

-- Procedimiento para listar organizadores
CREATE PROC ListarOrganizadores
AS
SELECT o.IdOrganizador,	
	persona.NombrePersona as NombreOrganizador
FROM Organizador o 
INNER JOIN Persona persona ON o.IdPersona=Persona.IdPersona
GO

-- Procedimiento para listar tipos de evento
CREATE PROC ListarTipoEvento
AS
SELECT * FROM TipoEvento ORDER BY IdTipoEvento ASC
GO

-- Procedimiento para registrar nuevo evento
CREATE PROC InsertarEvento
@Nombre VARCHAR (100),
@Descripcion VARCHAR(150),
@EstadoEvento VARCHAR(75),
@CantidadAsistentes INT,
@FechaReserva DATE,
@IdItinerario INT,
@IdResponsable INT,
@IdOrganizador INT,
@IdTipoEvento INT,
@IdSalon INT
AS
INSERT INTO Evento 
VALUES (@Nombre, @Descripcion, @EstadoEvento, @CantidadAsistentes, @FechaReserva, @IdItinerario, @IdResponsable, @IdOrganizador, @IdTipoEvento, @IdSalon)
GO

-- Procedimiento para registrar nuevo itinerario
CREATE PROC InsertarItinerario
@FechaInicio DATE,
@FechaCulminacion DATE,
@HoraInicio VARCHAR(25),
@HoraCulminacion VARCHAR(25),
@IdItinerario INT OUTPUT
AS
BEGIN
INSERT INTO Itinerario
VALUES (@FechaInicio, @FechaCulminacion, @HoraInicio, @HoraCulminacion);
SET @IdItinerario = SCOPE_IDENTITY();
END;
GO

-- Procedimiento para registrar nueva persona
CREATE PROC InsertarPersona
@NombrePersona VARCHAR(100),
@IdPersona INT OUTPUT
AS BEGIN
	INSERT INTO Persona (NombrePersona)
	VALUES (@NombrePersona);

	SET @IdPersona = SCOPE_IDENTITY();
END;
GO

-- Procedimiento para registrar nuevo responsable
CREATE PROC InsertarResponsable
@NombreComercial VARCHAR(150),
@IdPersona INT,
@IdResponsableOutput INT OUTPUT
AS BEGIN
	INSERT INTO Responsable (NombreComercial, IdPersona)
	VALUES (@NombreComercial, @IdPersona);

	SET @IdResponsableOutput = SCOPE_IDENTITY();
END;
GO

-- Procedimiento para actualizar registro de evento
CREATE PROC ActualizarEvento
@IdEvento INT,
@Nombre VARCHAR(100),
@Descripcion VARCHAR(150),
@EstadoEvento VARCHAR(75),
@CantidadAsistentes INT,
@IdOrganizador INT,
@IdTipoEvento INT,
@IdSalon INT,
@IdItinerario INT,
@FechaInicio DATE,
@FechaCulminacion DATE,
@HoraInicio VARCHAR(25),
@HoraCulminacion VARCHAR(25),
@IdResponsable INT, 
@NombreComercial VARCHAR(150),
@IdPersona INT,
@NombrePersona VARCHAR(100)
AS BEGIN
	UPDATE Evento SET 
	Nombre=@Nombre, 
	Descripcion=@Descripcion, 
	EstadoEvento=@EstadoEvento, 
	CantidadAsistentes=@CantidadAsistentes, 
	IdOrganizador=@IdOrganizador,
	IdTipoEvento=@IdTipoEvento,
	IdSalon=@IdSalon
	WHERE IdEvento=@IdEvento;

	UPDATE Itinerario SET
	FechaInicio=@FechaInicio,
	FechaCulminacion=@FechaCulminacion,
	HoraInicio=@HoraInicio,
	HoraCulminacion=@HoraCulminacion
	WHERE IdItinerario=@IdItinerario;

	UPDATE Responsable SET
	NombreComercial=@NombreComercial
	WHERE IdResponsable=@IdResponsable;

	UPDATE Persona SET
	NombrePersona=@NombrePersona
	WHERE IdPersona=@IdPersona;

END;
GO

-- Procedimiento para listar usuarios
CREATE PROC ListarUsuarios
AS
SELECT	usr.IdUsuario,
		usr.Usuario,
		usr.Nombre,
		usr.Estado,
		NombreRol,
		DireccionDetallada as Direccion,
		Municipio,
		Departamento
FROM Usuario usr
INNER JOIN Rol ON usr.IdRol=Rol.IdRol
INNER JOIN Direccion ON usr.IdDireccion=Direccion.IdDireccion
GO

-- Procedimiento para listar roles
CREATE PROC ListarRoles
AS
SELECT * FROM Rol ORDER BY IdRol ASC
GO

-- Procedimiento para registra nuevo usuario
CREATE PROC InsertarUsuario
@Usuario VARCHAR(50),
@Contrasenia VARCHAR(126),
@Nombre VARCHAR(100),
@Estado BIT,
@IdRol INT,
@IdDireccion INT,
@IdContacto INT
AS
INSERT INTO Usuario 
VALUES (@Usuario, @Contrasenia, @Nombre, @Estado, @IdRol, @IdDireccion, @IdContacto)
GO

-- Procedimiento para registrar nueva direccion
CREATE PROC InsertarDireccion
@DireccionDetallada VARCHAR(150),
@Municipio VARCHAR(50),
@Departamento VARCHAR(50),
@IdDireccionOutput INT OUTPUT
AS
BEGIN
	INSERT INTO Direccion
	VALUES (@DireccionDetallada, @Municipio, @Departamento)

	SET @IdDireccionOutput = SCOPE_IDENTITY();
END;
GO

-- Procedimiento para registrar nuevo contacto
CREATE PROC InsertarContacto
@EstadoContacto BIT,
@Telefono VARCHAR(8),
@Email VARCHAR(100),
@IdContactoOutput INT OUTPUT
AS 
BEGIN
	INSERT INTO Contacto
	VALUES (@EstadoContacto, @Telefono, @Email)

	SET @IdContactoOutput = SCOPE_IDENTITY();
END;
GO

-- Procedimiento para actualizar registro de usuario
CREATE PROC ActualizarUsuario
@IdUsuario INT,
@Usuario VARCHAR(50),
@Contrasenia VARCHAR(126),
@Nombre VARCHAR(100),
@Estado BIT,
@IdRol INT,
@IdDireccion INT,
@DireccionDetallada VARCHAR(150),
@Municipio VARCHAR(50),
@Departamento VARCHAR(50),
@IdContacto INT,
@EstadoContacto BIT,
@Telefono VARCHAR(8),
@Email VARCHAR(100)
AS BEGIN
	UPDATE Usuario SET
	Usuario=@Usuario,
	Contrasenia=@Contrasenia,
	Nombre=@Nombre,
	Estado=@Estado,
	IdRol=@IdRol
	WHERE IdUsuario = @IdUsuario

	UPDATE Direccion SET
	DireccionDetallada=@DireccionDetallada,
	Municipio=@Municipio,
	Departamento=@Departamento
	WHERE IdDireccion=@IdDireccion

	UPDATE Contacto SET
	EstadoContacto=@EstadoContacto,
	Telefono=@Telefono,
	Email=@Email
	WHERE IdContacto=@IdContacto

END;
GO

-- Procedimiento para registrar nuevo salón
Create PROC InsertarSalon
@NombreSalon VARCHAR(100),
@EstadoSalon VARCHAR(75),
@Capacidad INT,
@Descripcion VARCHAR(150),
@IdTipoSalon INT
AS
INSERT INTO Salon 
VALUES (@NombreSalon, @EstadoSalon, @Capacidad, @Descripcion, @IdTipoSalon)
GO

-- Procedimiento para actualizar salón
Create PROC ActualizarSalones
@IdSalon INT,
@NombreSalon VARCHAR(100),
@EstadoSalon VARCHAR(75),
@Capacidad INT,
@Descripcion VARCHAR(150),
@IdTipoSalon INT
AS BEGIN
	UPDATE Salon SET
	NombreSalon=@NombreSalon,
	EstadoSalon=@EstadoSalon,
	Capacidad=@Capacidad,
	Descripcion=@Descripcion,
	IdTipoSalon=@IdTipoSalon
	WHERE IdSalon = @IdSalon
END;
GO

-- Procedimiento para registrar nuevo salón
Create PROC InsertarTipoSalon
@NombreTipoSalon VARCHAR(100),
@ExistenciasTipoSalon INT
AS
INSERT INTO TipoSalon 
VALUES (@NombreTipoSalon, @ExistenciasTipoSalon)
GO

-- Procedimiento para actualizar salón
Create PROC ActualizarTipoSalones
@IdTipoSalon INT,
@NombreTipoSalon VARCHAR(100),
@ExistenciasTipoSalon INT
AS BEGIN
	UPDATE TipoSalon SET
	NombreTipoSalon=@NombreTipoSalon,
	ExistenciasTipoSalon=@ExistenciasTipoSalon
	WHERE IdTipoSalon = @IdTipoSalon
END;
GO

-- Procedimiento para crear un tipo evento
Create PROC InsertarTipoEvento
@NombreTipoEvento VARCHAR(100),
@Descripcion VARCHAR(150)
AS
INSERT INTO TipoEvento 
VALUES (@NombreTipoEvento, @Descripcion)
GO

-- Procedimiento para actualizar tipo evento
Create PROC ActualizarTipoEvento
@IdTipoEvento INT,
@NombreTipoEvento VARCHAR(100),
@Descripcion VARCHAR(150)
AS BEGIN
	UPDATE TipoEvento SET
	NombreTipoEvento=@NombreTipoEvento,
	Descripcion=@Descripcion
	WHERE IdTipoEvento = @IdTipoEvento
END;
GO

-- Procedimiento para listar organizadores
CREATE PROC InsertarOrganizadores
@Estado BIT,
@IdPersona INT
AS
INSERT INTO Organizador 
VALUES (@Estado, @IdPersona)
GO