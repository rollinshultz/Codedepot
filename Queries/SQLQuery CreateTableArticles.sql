CREATE TABLE [dbo].[Article] (
    [articleID]          INT            IDENTITY (1, 1) NOT NULL,
    [articleTitle]       NVARCHAR (100) NOT NULL,
    [articleDescription] NVARCHAR (MAX) NOT NULL,
    [articlePath]        NVARCHAR (60)  NOT NULL,
    [author]             NVARCHAR (60)  NOT NULL,
    [date]               DATETIME       NOT NULL,
    [rating]             DECIMAL (18)   NULL,
    [language]           NVARCHAR (30)  NULL,
    CONSTRAINT [PK_dbo.Articles] PRIMARY KEY CLUSTERED ([articleID] ASC)
);