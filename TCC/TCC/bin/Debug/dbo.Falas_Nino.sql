CREATE TABLE [dbo].[Falas_Nino] (
    [Capitulos] INT           NOT NULL,
    [Cenas]     INT           NOT NULL,
    [Num_Fala]  INT           NOT NULL,
    [Falas]     VARCHAR (MAX) NOT NULL,
    [ID_usuario] NCHAR(10) NULL, 
    [Nome_Personagem] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([Capitulos] ASC)
);

