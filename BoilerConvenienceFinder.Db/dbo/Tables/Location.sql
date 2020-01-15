CREATE TABLE [dbo].[Location] (
    [Id]         INT         IDENTITY (1, 1) NOT NULL,
    [Floor]      VARCHAR (1) NOT NULL,
    [RoomNumber] VARCHAR (5) NULL,
    [BuildingId] INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Location_Building] FOREIGN KEY ([BuildingId]) REFERENCES [dbo].[Building] ([Id])
);

