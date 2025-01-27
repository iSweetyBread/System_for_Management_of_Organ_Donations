CREATE TABLE [dbo].[Blood_donor_info] (
    [Bdonor_id]      INT           NOT NULL,
    [First_name]     NVARCHAR (10) NOT NULL,
    [Last_name]      NVARCHAR (20) NOT NULL,
    [Birth_date]     DATE          NOT NULL,
    [Blood_type]     NVARCHAR (3)  NOT NULL,
    [Donation_count] INT           NOT NULL,
    [City]           NVARCHAR (15) NOT NULL,
    [Address]        NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_Blood_donor_info] PRIMARY KEY CLUSTERED ([Bdonor_id] ASC),
    CONSTRAINT [CK_Birth_date1] CHECK ([Birth_date]<getdate())
);


GO
CREATE NONCLUSTERED INDEX [idx_BLast_name]
    ON [dbo].[Blood_donor_info]([Last_name] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_BCity]
    ON [dbo].[Blood_donor_info]([City] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_BBlood_type]
    ON [dbo].[Blood_donor_info]([Blood_type] ASC);

