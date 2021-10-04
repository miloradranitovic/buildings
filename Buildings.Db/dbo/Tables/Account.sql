CREATE TABLE [dbo].[Account] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [Number]          VARCHAR (20)     NOT NULL,
    [Balance]         MONEY            NOT NULL,
    [StartingBalance] MONEY            NOT NULL,
    [CreatedAt]       DATETIME         NOT NULL,
    [ModifiedAt]      DATETIME         NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([Id] ASC)
);

