CREATE TABLE [dbo].[Activity]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(150) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [UserID] INT NOT NULL, 
    [CategoryID] INT NOT NULL, 
    [ProjectID] INT NOT NULL, 
    CONSTRAINT [FK_Activity_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_Activity_ToCategory] FOREIGN KEY ([CategoryID]) REFERENCES [Category]([Id]), 
    CONSTRAINT [FK_Activity_ToProject] FOREIGN KEY ([ProjectID]) REFERENCES [Project]([Id]), 

)
