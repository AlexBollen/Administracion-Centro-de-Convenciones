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

CREATE PROC ListarSalones
AS
SELECT * FROM Salon ORDER BY IdSalon ASC
GO

CREATE PROC ListarOrganizadores
AS
SELECT o.IdOrganizador,
		organizador.NombrePersona as NombreOrganizador
FROM Organizador o 
INNER JOIN Persona organizador ON o.IdOrganizador=organizador.IdPersona
GO

CREATE PROC ListarTipoEvento
AS
SELECT * FROM TipoEvento ORDER BY IdTipoEvento ASC
GO

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

CREATE PROC InsertarPersona
@NombrePersona VARCHAR(100),
@IdPersona INT OUTPUT
AS BEGIN
	INSERT INTO Persona (NombrePersona)
	VALUES (@NombrePersona);

	SET @IdPersona = SCOPE_IDENTITY();
END;
GO

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
