CREATE TABLE [dbo].[Building] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [Code]          VARCHAR (4)  NOT NULL,
    [Name]          VARCHAR (50) NOT NULL,
    [StreetAddress] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

