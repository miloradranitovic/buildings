CREATE TABLE [dbo].[User] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Username]  VARCHAR (50)     NOT NULL,
    [IsActive]  BIT              CONSTRAINT [DF_User_IsActive] DEFAULT ((1)) NOT NULL,
    [IsDeleted] BIT              CONSTRAINT [DF_User_IsDeleted] DEFAULT ((0)) NOT NULL,
    [CreatedAt] DATETIME         CONSTRAINT [DF_User_CreatedAt] DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
);

