CREATE TABLE [dbo].[BuildingSectionPayment] (
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [BuildingSectionId] UNIQUEIDENTIFIER NULL,
    [PaymentId]         UNIQUEIDENTIFIER NULL,
    [CreatedAt]         DATETIME         CONSTRAINT [DF_BuildingSectionPayment_CreatedAt] DEFAULT (getutcdate()) NULL,
    CONSTRAINT [PK_BuildingSectionPayment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__BuildingS__Build__114A936A] FOREIGN KEY ([BuildingSectionId]) REFERENCES [dbo].[BuildingSection] ([Id])
);

