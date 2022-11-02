USE [ExamenRAD]
GO

/****** Object:  StoredProcedure [dbo].[SP_SUCURSALES]    Script Date: 1/11/2022 21:32:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_SUCURSALES]

@OPCION INT,
@ID INT,
@SUCURSAL VARCHAR(50),
@DIRECCION VARCHAR(100),
@TELEFONO VARCHAR(10)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	
	IF @OPCION = 1

INSERT INTO SUCURSALES(SUCURSAL, DIRECCION, TELEFONO)
VALUES(@SUCURSAL, @DIRECCION, @TELEFONO)

IF @OPCION = 2

UPDATE SUCURSALES
SET  SUCURSAL = @SUCURSAL, DIRECCION = @DIRECCION, TELEFONO = @TELEFONO
WHERE ID = @ID

IF @OPCION = 3

DELETE FROM SUCURSALES
WHERE  ID = @ID


IF @OPCION = 4
SELECT * FROM SUCURSALES 
WHERE  ID = @ID


IF @OPCION = 5
SELECT * FROM SUCURSALES

    -- 
END
GO

