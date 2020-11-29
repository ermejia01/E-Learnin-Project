USE [ELEARNING]
GO

/****** Object:  StoredProcedure [dbo].[MOSTRAR_CONTENIDOS]    Script Date: 28/11/2020 22:54:59 ******/
DROP PROCEDURE [dbo].[MOSTRAR_CONTENIDOS]
GO

/****** Object:  StoredProcedure [dbo].[MOSTRAR_CONTENIDOS]    Script Date: 28/11/2020 22:54:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[MOSTRAR_CONTENIDOS]
AS
BEGIN
	SELECT
		CO.ID_CONTENIDO AS CODIGO,
		CO.DESCRIPCION,
		CO.TIPO,
		CO.ID_CATEGORIA,
		CA.NOMBRE_CAT,
		CO.ID_CURSO,
		CU.NOMBRE_CURSO,
		CO.ID_TEMA,
		TE.NOMBRE_TEMA,
		CO.ARCHIVO
	FROM
				CONTENIDOS CO
	LEFT JOIN	CATEGORIAS CA ON CA.ID_CATEGORIA = CO.ID_CATEGORIA
	LEFT JOIN	CURSOS CU ON CU.ID_CATEGORIA = CO.ID_CATEGORIA AND CU.ID_CURSO = CO.ID_CURSO
	LEFT JOIN	TEMAS TE ON TE.ID_CATEGORIA = CO.ID_CATEGORIA AND TE.ID_CURSO = CO.ID_CURSO AND TE.ID_TEMA = CO.ID_TEMA
END
GO


