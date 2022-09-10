CREATE TABLE [dbo].[Table] (
    [accountNo] INT          NOT NULL,
    [name]      VARCHAR (50) NOT NULL,
    [mail]      VARCHAR (50) NOT NULL,
    [phone]     NUMERIC (10) NOT NULL,
    [pinCode] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([accountNo] ASC),
    UNIQUE NONCLUSTERED ([mail] ASC)
);

