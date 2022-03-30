CREATE TABLE [dbo].[Personal Info]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Adress] NVARCHAR(200) NOT NULL, 
    [gsm] INT NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Misc] NVARCHAR(MAX) NULL, 
    [FirstQuality] NVARCHAR(50) NOT NULL, 
    [SecondQuality] NVARCHAR(50) NOT NULL, 
    [ThirdQuality] NVARCHAR(50) NOT NULL, 
    [FirstFault] NVARCHAR(50) NOT NULL, 
    [SecondFault] NVARCHAR(50) NOT NULL, 
    [ThirdFault] NVARCHAR(50) NOT NULL, 
    [LastDegree] NVARCHAR(50) NULL 
)