CREATE TABLE [dbo].[Technical Skills]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Skill] NVARCHAR(200) NULL, 
    [CV Id] INT NOT NULL, 
    CONSTRAINT [FK_to_CV] FOREIGN KEY ([CV Id]) REFERENCES [Personnal Info]([Id])
)
