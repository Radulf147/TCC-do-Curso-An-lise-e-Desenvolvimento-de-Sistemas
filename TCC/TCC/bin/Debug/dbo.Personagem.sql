CREATE TABLE [dbo].[Personagem] (
    [ID_Usuario] NVARCHAR (50) NOT NULL,
    [Nome]         NVARCHAR (50) NOT NULL,
    [Idade]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Usuario] ASC)
);

