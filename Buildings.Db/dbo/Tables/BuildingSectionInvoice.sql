CREATE TABLE [dbo].[BuildingSectionInvoice] (
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [BuildingSectionId] UNIQUEIDENTIFIER NULL,
    [InvoiceId]         UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_BuildingSectionInvoice] PRIMARY KEY CLUSTERED ([Id] ASC)
);

