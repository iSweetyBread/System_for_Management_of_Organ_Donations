CREATE TABLE [dbo].[Donor_info] (
    [Donor_id]   INT           NOT NULL,
    [First_name] NVARCHAR (10) NOT NULL,
    [Last_name]  NVARCHAR (20) NOT NULL,
    [Birth_date] DATE          NOT NULL,
    [Blood_type] NVARCHAR (3)  NOT NULL,
    [City]       NVARCHAR (15) NOT NULL,
    [Address]    NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_Donor_info] PRIMARY KEY CLUSTERED ([Donor_id] ASC),
    CONSTRAINT [CK_Birth_date] CHECK ([Birth_date]<getdate())
);


GO
CREATE NONCLUSTERED INDEX [idx_DLast_name]
    ON [dbo].[Donor_info]([Last_name] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_DCity]
    ON [dbo].[Donor_info]([City] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_DBlood_type]
    ON [dbo].[Donor_info]([Blood_type] ASC);

