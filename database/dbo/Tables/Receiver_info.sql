CREATE TABLE [dbo].[Receiver_info] (
    [Receiver_id]       INT           NOT NULL,
    [First_name]        NVARCHAR (10) NOT NULL,
    [Last_name]         NVARCHAR (20) NOT NULL,
    [Birth_date]        DATE          NOT NULL,
    [Blood_type]        NVARCHAR (3)  NOT NULL,
    [Organ_id]          INT           NOT NULL,
    [City]              NVARCHAR (15) NOT NULL,
    [Address]           NVARCHAR (20) NOT NULL,
    [Hospital_id]       INT           NOT NULL,
    [Registration_date] DATE          NOT NULL,
    [Operation_date]    DATE          NULL,
    [Organ_status]      NVARCHAR (15) NOT NULL,
    [Priority]          NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_Receiver_info] PRIMARY KEY CLUSTERED ([Receiver_id] ASC, [Organ_id] ASC),
    CONSTRAINT [CK_Birth_date2] CHECK ([Birth_date]<=getdate()),
    CONSTRAINT [CK_Registration_date] CHECK ([Registration_date]<getdate()),
    CONSTRAINT [FK_Receiver_Hospital] FOREIGN KEY ([Hospital_id]) REFERENCES [dbo].[Hospital_info] ([Hospital_id]),
    CONSTRAINT [FK_Receiver_Organ] FOREIGN KEY ([Organ_id]) REFERENCES [dbo].[Organ_donation] ([Organ_id])
);


GO
CREATE NONCLUSTERED INDEX [idx_RLast_name]
    ON [dbo].[Receiver_info]([Last_name] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_RBlood_type]
    ON [dbo].[Receiver_info]([Blood_type] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_ROrrgan_status]
    ON [dbo].[Receiver_info]([Organ_status] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_RPriority]
    ON [dbo].[Receiver_info]([Priority] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_RRegistrration]
    ON [dbo].[Receiver_info]([Registration_date] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_ROperation]
    ON [dbo].[Receiver_info]([Operation_date] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_RCity]
    ON [dbo].[Receiver_info]([City] ASC);

