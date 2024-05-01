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