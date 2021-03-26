CREATE TABLE [dbo].[tblOrder] (
    [Order_ID]         INT NOT NULL,
    [Order_Date]       DATE         NULL,
    [Order_Type]       VARCHAR (20) NULL,
    [Order_Cus_ID]     INT          NOT NULL,
    [Order_Product_ID] INT          NOT NULL,
    CONSTRAINT [Order_Cus_ID] FOREIGN KEY ([Order_Cus_ID]) REFERENCES [dbo].[tblCustomer] ([CustomerNo]),
    CONSTRAINT [Order_Product_ID] FOREIGN KEY ([Order_Product_ID]) REFERENCES [dbo].[tblProduct] ([ProductID]),
    CONSTRAINT [PK_tblOrder] PRIMARY KEY CLUSTERED ([Order_ID] ASC)
);

