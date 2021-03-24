CREATE TABLE [dbo].[tblCustomer] (
    [CustomerNo]  INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (50) NULL,
    [Surname]     VARCHAR (50) NULL,
    [Email]       VARCHAR (50) NULL,
    [HouseNo]     INT  NULL,
    [Street]      VARCHAR (50) NULL,
    [Town]        VARCHAR (50) NULL,
    [PostCode]    VARCHAR (9)  NULL,
    [DateOfBirth] DATE         NULL,
    [Active]      BIT          NULL,
    PRIMARY KEY CLUSTERED ([CustomerNo] ASC)
);

