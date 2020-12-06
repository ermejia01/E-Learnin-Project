USE [ELEARNING]
GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CURSOS]    Script Date: 5/12/2020 09:00:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[MOSTRAR_TEMAS]
AS
BEGIN
	SELECT
		T.ID_TEMA,
		T.NOMBRE_TEMA AS TEMA,
		CU.NOMBRE_CURSO AS CURSO,
		CA.NOMBRE_CAT AS CATEGORIA
	FROM TEMAS T
	 JOIN 	CURSOS  CU ON T.ID_CURSO=CU.ID_CURSO AND T.ID_CATEGORIA =  CU.ID_CATEGORIA 
	 JOIN	CATEGORIAS CA ON CA.ID_CATEGORIA =  CU.ID_CATEGORIA 

END
go
MOSTRAR_TEMAS


