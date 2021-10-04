CREATE TABLE [dbo].[InvoiceState] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [State]       NVARCHAR (20)    NOT NULL,
    [Description] NVARCHAR (100)   NULL,
    CONSTRAINT [PK_InvoiceState] PRIMARY KEY CLUSTERED ([Id] ASC)
);

