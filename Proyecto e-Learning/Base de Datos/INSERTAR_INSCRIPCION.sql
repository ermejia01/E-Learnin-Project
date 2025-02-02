USE ELEARNING
GO

CREATE PROCEDURE INSERTAR_INSCRIPCIONES
(
	@ENVIADO		BIT,
	@ID_USUARIO		INT,
	@ID_CURSO		INT
)
AS 
BEGIN
	DECLARE
		@ESTADO VARCHAR(40),
		@FECHA_INSCRIPCION DATETIME,
		@IDGEN INT

	SELECT @FECHA_INSCRIPCION = GETDATE()

	IF @ENVIADO = 0
	BEGIN
		SELECT @ESTADO = 'Inscrito'
		INSERT INTO INSCRIPCIONES(ID_USUARIO, ID_CURSO,ESTADO,FECHA_INSCRIPCION) 
		VALUES ( @ID_USUARIO,@ID_CURSO, @ESTADO, @FECHA_INSCRIPCION)

		SELECT @IDGEN = @@IDENTITY

		SELECT @IDGEN

	END
	ELSE
	BEGIN
		SELECT -1
	END
END