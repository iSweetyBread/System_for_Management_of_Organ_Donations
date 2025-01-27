CREATE TABLE [dbo].[Organ_donation] (
    [Organ_id]        INT           NOT NULL,
    [Donor_id]        INT           NOT NULL,
    [Organ]           NVARCHAR (15) NOT NULL,
    [Extraction_date] DATE          NULL,
    [Place_id]        INT           NULL,
    [Status]          NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_Organ_donation] PRIMARY KEY CLUSTERED ([Organ_id] ASC),
    CONSTRAINT [CK_Extraction_date] CHECK ([Extraction_date]<=getdate()),
    CONSTRAINT [FK_Organ_Bank] FOREIGN KEY ([Place_id]) REFERENCES [dbo].[Bank_info] ([Place_id]),
    CONSTRAINT [FK_Organ_Donor] FOREIGN KEY ([Donor_id]) REFERENCES [dbo].[Donor_info] ([Donor_id])
);


GO
CREATE NONCLUSTERED INDEX [idx_Donor]
    ON [dbo].[Organ_donation]([Donor_id] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_Organ]
    ON [dbo].[Organ_donation]([Organ] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_Organ_place]
    ON [dbo].[Organ_donation]([Place_id] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_Status]
    ON [dbo].[Organ_donation]([Status] ASC);

