CREATE TABLE [dbo].[Invoice] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [AccountId]      UNIQUEIDENTIFIER NOT NULL,
    [Title]          NVARCHAR (50)    NOT NULL,
    [IssuerUserId]   UNIQUEIDENTIFIER NOT NULL,
    [IssueDate]      DATETIME         NOT NULL,
    [DueDate]        DATETIME         NOT NULL,
    [InvoiceStateId] UNIQUEIDENTIFIER NOT NULL,
    [CreatedAt]      DATETIME         NOT NULL,
    CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([IssuerUserId]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK__Invoice__Account__02FC7413] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Account] ([Id]),
    CONSTRAINT [FK__Invoice__Invoice__32AB8735] FOREIGN KEY ([InvoiceStateId]) REFERENCES [dbo].[InvoiceState] ([Id])
);

