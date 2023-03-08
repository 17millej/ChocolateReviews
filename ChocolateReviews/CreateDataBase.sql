CREATE TABLE ChocolateBar
(
	[ChocolateBarID] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(128) NULL, 
    [Price] MONEY NULL
)


CREATE TABLE Users
(
	[UserID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(10) NULL, 
    [LastName] NCHAR(10) NULL
)

CREATE TABLE Reviews
(
	[ReviewID] INT NOT NULL PRIMARY KEY, 
    [ChocolateBarID] INT NULL, 
    [UserID] INT NULL, 
    [Score] INT NULL, 
    [Comment] TEXT NULL
)