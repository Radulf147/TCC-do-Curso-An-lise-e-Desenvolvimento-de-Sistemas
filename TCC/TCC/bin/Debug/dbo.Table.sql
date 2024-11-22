CREATE TABLE [dbo].[Dialogo] (
    [Capitulos]  INT           NOT NULL,
    [Cenas]      INT           NOT NULL,
    [Num_Fala]   INT           NOT NULL,
    [Fala]      VARCHAR (MAX) NOT NULL,
    [Nome_Personagem] VARCHAR(50) NOT NULL, 
    [ID_Usuario] INT NOT NULL IDENTITY, 
    PRIMARY KEY CLUSTERED ([Nome_Personagem])
);

