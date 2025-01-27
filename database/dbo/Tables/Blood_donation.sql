CREATE TABLE [dbo].[Blood_donation] (
    [Bdonor_id]     INT  NOT NULL,
    [Donation_date] DATE NOT NULL,
    [Amount]        INT  NOT NULL,
    [Place_id]      INT  NOT NULL,
    CONSTRAINT [PK_Blood_donation] PRIMARY KEY CLUSTERED ([Bdonor_id] ASC, [Donation_date] ASC),
    CONSTRAINT [CK_Donation_date] CHECK ([Donation_date]<=getdate()),
    CONSTRAINT [FK_Blood_Bank] FOREIGN KEY ([Place_id]) REFERENCES [dbo].[Bank_info] ([Place_id]),
    CONSTRAINT [FK_Blood_Donor] FOREIGN KEY ([Bdonor_id]) REFERENCES [dbo].[Blood_donor_info] ([Bdonor_id])
);


GO
CREATE NONCLUSTERED INDEX [idx_Bdonor]
    ON [dbo].[Blood_donation]([Bdonor_id] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_BPlace]
    ON [dbo].[Blood_donation]([Place_id] ASC);

