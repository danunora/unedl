USE [ExamenCertificacion]
GO

/****** Object:  Table [dbo].[Preguntas]    Script Date: 1/25/2019 8:40:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Preguntas](
	[PreguntaID] [nchar](10) NOT NULL,
	[TipoPregunta] [nchar](10) NULL,
	[Pregunta] [nchar](10) NULL,
	[Respuesta1] [nchar](10) NULL,
	[Respuesta2] [nchar](10) NULL,
	[Respuesta3] [nchar](10) NULL,
	[Respuesta4] [nchar](10) NULL,
	[Correcta] [nchar](10) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[PreguntaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

