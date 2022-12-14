USE [ExamenRAD]
GO

/****** Object:  StoredProcedure [dbo].[SP_EMPLEADOS]    Script Date: 1/11/2022 21:32:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<GISELA>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_EMPLEADOS]

@OPCION INT,
@IDEMPLEADO INT,
@NOMBRE VARCHAR(50),
@TELEFONO VARCHAR(10),
@FEC_INGRESO DATE,
@DIRECCION VARCHAR(100),
@IDSUCURSAL INT,
@NIVELACCESO INT

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @OPCION = 1

INSERT INTO EMPLEADOS(NOMBRE, TELEFONO, FEC_INGRESO, DIRECCION,IDSUCURSAL, NIVELACCESO)
VALUES(@NOMBRE, @TELEFONO, @FEC_INGRESO, @DIRECCION,@IDSUCURSAL, @NIVELACCESO)

IF @OPCION = 2

UPDATE EMPLEADOS 
SET  NOMBRE = @NOMBRE, TELEFONO = @TELEFONO, FEC_INGRESO = @FEC_INGRESO , DIRECCION = @DIRECCION,IDSUCURSAL = @IDSUCURSAL, NIVELACCESO = @NIVELACCESO
WHERE IDEMPLEADO = @IDEMPLEADO

IF @OPCION = 3

DELETE FROM EMPLEADOS
WHERE  IDEMPLEADO = @IDEMPLEADO

IF @OPCION = 4
SELECT * FROM EMPLEADOS
WHERE  IDEMPLEADO = @IDEMPLEADO

IF @OPCION = 5
SELECT * FROM EMPLEADOS

END
GO

