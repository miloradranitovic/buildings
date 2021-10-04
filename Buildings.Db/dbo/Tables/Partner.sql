CREATE TABLE [dbo].[Partner] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [Name]           NVARCHAR (50)    NOT NULL,
    [WorkArea]       NVARCHAR (50)    NOT NULL,
    [TaxNumber]      VARCHAR (50)     NOT NULL,
    [PersonalNumber] VARCHAR (50)     NOT NULL,
    [AccountId]      UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]    DATETIME         NOT NULL,
    [CreatedAt]      DATETIME         CONSTRAINT [DF_Partner_CreatedAt] DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_Partner] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Account] ([Id])
);

