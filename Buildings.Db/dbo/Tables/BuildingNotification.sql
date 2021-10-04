CREATE TABLE [dbo].[BuildingNotification] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [BuildingId] UNIQUEIDENTIFIER NOT NULL,
    [Title]      NVARCHAR (100)   NOT NULL,
    [Body]       NVARCHAR (255)   NOT NULL,
    [CreatedAt]  DATETIME         CONSTRAINT [DF_BuildingNotification_CreatedAt] DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_BuildingNotification] PRIMARY KEY CLUSTERED ([Id] ASC)
);

