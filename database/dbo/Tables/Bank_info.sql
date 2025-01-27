CREATE TABLE [dbo].[Bank_info] (
    [Place_id]     INT           NOT NULL,
    [City]         NVARCHAR (15) NOT NULL,
    [Address]      NVARCHAR (30) NOT NULL,
    [Contact_info] NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_Bank_info] PRIMARY KEY CLUSTERED ([Place_id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [idx_BCity]
    ON [dbo].[Bank_info]([City] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_BPlace]
    ON [dbo].[Bank_info]([Place_id] ASC);

