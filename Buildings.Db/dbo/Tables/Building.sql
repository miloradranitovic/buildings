CREATE TABLE [dbo].[Building] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [City]             NVARCHAR (50)    NOT NULL,
    [County]           NVARCHAR (50)    NOT NULL,
    [PostNumber]       VARCHAR (10)     NOT NULL,
    [Street]           NVARCHAR (100)   NOT NULL,
    [StreetNumber]     VARCHAR (10)     NOT NULL,
    [TaxNumber]        VARCHAR (50)     NOT NULL,
    [PersonalNumber]   VARCHAR (50)     NOT NULL,
    [AccountId]        UNIQUEIDENTIFIER NOT NULL,
    [HasElevator]      BIT              NOT NULL,
    [ConstructionYear] SMALLINT         NOT NULL,
    [GovernanceTypeId] UNIQUEIDENTIFIER NOT NULL,
    [Email]            VARCHAR (150)    NOT NULL,
    CONSTRAINT [PK_Building] PRIMARY KEY CLUSTERED ([Id] ASC)
);

