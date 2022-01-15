CREATE TABLE [dbo].[Books]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NULL, 
    [Year] INT NULL, 
    [ISBN] NVARCHAR(50) NULL UNIQUE,
    [Summary] NVARCHAR(250) NULL, 
    [Image] NVARCHAR(50) NULL, 
    [Price] DECIMAL(18, 2) NULL, 
    [AuthorId] INT NULL, 
    CONSTRAINT [FK_Books_ToAuthors] FOREIGN KEY ([AuthorId]) REFERENCES [Authors]([Id])
)
