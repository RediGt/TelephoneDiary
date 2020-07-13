CREATE TABLE [dbo].[Contacts] (
    [FirstName] VARCHAR (50)   NOT NULL,
    [LastName]  VARCHAR (50)   NOT NULL,
    [Mobile]    VARCHAR (50)   NOT NULL,
    [Email]     VARCHAR(50) NULL,
    [Category]  VARCHAR(50) NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Mobile] ASC)
);

