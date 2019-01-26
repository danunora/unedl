-- Ejemplo1
-- use ExamenCertificacion
--select * from dbo.Preguntas;

-- Ejemplo2
-- SELECT * FROM sys.tables  
-- WHERE object_id = 1973582069;

-- Ejemplo3
-- sp_help Preguntas

-- Ejemplo4
--bulk insert Preguntas2 from 'c:\temp\Template_Archivo_Preguntas.csv'
--with 
--(
--firstrow=2,
--fieldterminator=',',
--rowterminator='\n'
--)

-- select * from Preguntas2