USE [ExamenCertificacion]
GO

INSERT INTO [dbo].[Preguntas]
           ([PreguntaID]
           ,[TipoPregunta]
           ,[Pregunta]
           ,[Respuesta1]
           ,[Respuesta2]
           ,[Respuesta3]
           ,[Respuesta4]
           ,[Correcta])
     VALUES
           (<PreguntaID, nchar(10),>
           ,<TipoPregunta, nchar(10),>
           ,<Pregunta, nchar(10),>
           ,<Respuesta1, nchar(10),>
           ,<Respuesta2, nchar(10),>
           ,<Respuesta3, nchar(10),>
           ,<Respuesta4, nchar(10),>
           ,<Correcta, nchar(10),>)
GO

