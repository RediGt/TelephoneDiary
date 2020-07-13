CREATE TABLE [dbo].[Table]
(
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Mobile] VARCHAR(50) NOT NULL, 
    [Email] VARBINARY(50) NULL, 
    [Category] VARBINARY(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Mobile])
)
