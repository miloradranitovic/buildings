CREATE TABLE [dbo].[BuildingSection] (
    [Id]                      UNIQUEIDENTIFIER NOT NULL,
    [BuildingId]              UNIQUEIDENTIFIER NOT NULL,
    [BuildingSectionTypeId]   UNIQUEIDENTIFIER NOT NULL,
    [Number]                  VARCHAR (10)     NOT NULL,
    [SizeM2]                  SMALLINT         NOT NULL,
    [OwnerFirstName]          NVARCHAR (50)    NOT NULL,
    [OwnerLastName]           NVARCHAR (50)    NOT NULL,
    [OwnerEmail]              VARCHAR (255)    NULL,
    [DifferentInvoiceAddress] NVARCHAR (255)   NULL,
    [Rented]                  BIT              CONSTRAINT [DF_BuildingSection_UnderRent] DEFAULT ((0)) NOT NULL,
    [MembersCount]            SMALLINT         CONSTRAINT [DF_BuildingSection_MembersCount] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Apartment] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([BuildingId]) REFERENCES [dbo].[Building] ([Id]),
    CONSTRAINT [FK__BuildingS__Build__49C3F6B7] FOREIGN KEY ([BuildingSectionTypeId]) REFERENCES [dbo].[BuildingSectionType] ([Id])
);

