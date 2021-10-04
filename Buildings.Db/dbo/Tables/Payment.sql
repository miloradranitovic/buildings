CREATE TABLE [dbo].[Payment] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Date]      DATETIME         NOT NULL,
    [InvoiceId] UNIQUEIDENTIFIER NOT NULL,
    [Amount]    MONEY            NOT NULL,
    [CreatedAt] DATETIME         CONSTRAINT [DF_Payment_CreatedAt] DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Payment__Invoice__0A9D95DB] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[Invoice] ([Id])
);

