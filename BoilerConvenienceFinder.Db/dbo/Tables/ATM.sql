CREATE TABLE [dbo].[ATM] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [LocationId] INT          NOT NULL,
    [BankId]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ATM_] FOREIGN KEY ([BankId]) REFERENCES [dbo].[Bank] ([Id]),
    CONSTRAINT [FK_ATM_Location] FOREIGN KEY ([LocationId]) REFERENCES [dbo].[Location] ([Id])
);

