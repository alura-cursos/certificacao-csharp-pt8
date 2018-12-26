DROP TABLE [dbo].[Diretores];
GO
CREATE TABLE [dbo].[Diretores] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Nome] VARCHAR (255) NOT NULL
);
GO
DROP TABLE [dbo].[Filmes];
GO
CREATE TABLE [dbo].[Filmes] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [DiretorId] INT           NOT NULL,
    [Titulo]    VARCHAR (255) NOT NULL,
    [Ano]       INT           NOT NULL,
    [Minutos]   INT           NOT NULL
);
GO