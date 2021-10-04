CREATE TABLE [dbo].[BuildingOutcome] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [BuildingId] UNIQUEIDENTIFIER NOT NULL,
    [PaymentId]  UNIQUEIDENTIFIER NOT NULL,
    [CreatedAt]  DATETIME         CONSTRAINT [DF_BuildingOutcome_CreatedAt] DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_BuildingOutcome] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__BuildingO__Build__4F47C5E3] FOREIGN KEY ([BuildingId]) REFERENCES [dbo].[Building] ([Id]),
    CONSTRAINT [FK__BuildingO__Payme__503BEA1C] FOREIGN KEY ([PaymentId]) REFERENCES [dbo].[Payment] ([Id])
);

