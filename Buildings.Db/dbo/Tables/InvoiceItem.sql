CREATE TABLE [dbo].[InvoiceItem] (
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [InvoiceId]         UNIQUEIDENTIFIER NOT NULL,
    [Amount]            MONEY            NOT NULL,
    [InvoiceItemTypeId] UNIQUEIDENTIFIER NOT NULL,
    [Comment]           NVARCHAR (50)    NULL,
    CONSTRAINT [PK_InvoiceItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__InvoiceIt__Invoi__66603565] FOREIGN KEY ([InvoiceItemTypeId]) REFERENCES [dbo].[InvoiceItemType] ([Id]),
    CONSTRAINT [FK__InvoiceIt__Invoi__6754599E] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[Invoice] ([Id])
);

