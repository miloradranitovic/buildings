CREATE TABLE [dbo].[BuildingIncome] (
    [Id]         UNIQUEIDENTIFIER NULL,
    [BuildingId] UNIQUEIDENTIFIER NULL,
    [PaymentId]  UNIQUEIDENTIFIER NULL,
    [CreatedAt]  DATETIME         CONSTRAINT [DF_BuildingPayment_CreatedAt] DEFAULT (getutcdate()) NULL
);

