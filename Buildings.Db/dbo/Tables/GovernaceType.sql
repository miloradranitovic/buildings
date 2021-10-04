CREATE TABLE [dbo].[GovernaceType] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] NVARCHAR (50)    NULL,
    [CreatedDate] DATETIME         CONSTRAINT [DF_GovernaceType_CreatedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_GovernaceType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

