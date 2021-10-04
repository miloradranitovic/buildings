CREATE TABLE [dbo].[BuildingSectionType] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] NVARCHAR (50)    NULL,
    CONSTRAINT [PK_BuildingSectionType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

