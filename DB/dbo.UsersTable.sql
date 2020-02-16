CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL Identity(1,1) PRIMARY KEY,
	[Email] varchar(50) NOT NULL,
	[Password] varchar(100) NOT NULL,
	[DisplayName] varchar(100) NOT NULL,
	[Mobile] varchar(20) NOT NULL,
	[LastLogin] datetime NULL
)

