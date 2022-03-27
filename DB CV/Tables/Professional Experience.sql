CREATE TABLE [dbo].[Professional Experience]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PeriodBegin] DATE NULL, 
    [PeriodEnd] DATE NULL, 
    [Employer] NVARCHAR(50) NULL, 
    [Position] NVARCHAR(50) NULL, 
    [CV Id] INT NULL, 
    CONSTRAINT [FK_to_CV2] FOREIGN KEY ([CV Id]) REFERENCES [Personnal Info]([Id])
)
