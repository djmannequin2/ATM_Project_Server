CREATE TABLE [dbo].[People] (
    [Id]      INT           NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    [Balance] MONEY         NOT NULL,
    [PIN]     CHAR (4)      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

