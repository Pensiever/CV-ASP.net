﻿CREATE TABLE [dbo].[AppUser]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] VARCHAR(50) NOT NULL,
	[Password] VARBINARY(64) NOT NULL,
	[Salt] VARCHAR(93) NOT NULL
)