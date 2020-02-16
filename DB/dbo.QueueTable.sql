CREATE TABLE [dbo].[Queue]
(
	[Id] INT NOT NULL identity(1,1) PRIMARY KEY,
	[UserID] INT NOT NULL,
	[QueueDate] Datetime NOT NULL,
	[InsertDate] Datetime NOT NULL


)
GO

ALTER TABLE [dbo].[Queue]   ADD  CONSTRAINT [FK1_Queue_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([Id])
GO

