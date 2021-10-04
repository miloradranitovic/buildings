CREATE TABLE [dbo].[InvoiceItemType] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] NVARCHAR (50)    NULL,
    CONSTRAINT [PK_InvoiceItemType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

