CREATE TABLE [dbo].[VendingMachine] (
    [Id]                   INT          IDENTITY (1, 1) NOT NULL,
    [Name]                 VARCHAR (50) NOT NULL,
    [LocationId]           INT          NOT NULL,
    [VendingMachineTypeId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_VendingMachine_Location] FOREIGN KEY ([LocationId]) REFERENCES [dbo].[Location] ([Id]),
    CONSTRAINT [FK_VendingMachine_VendingMachineType] FOREIGN KEY ([VendingMachineTypeId]) REFERENCES [dbo].[VendingMachineType] ([Id])
);

