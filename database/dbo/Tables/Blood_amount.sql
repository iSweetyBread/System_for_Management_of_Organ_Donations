CREATE TABLE [dbo].[Blood_amount] (
    [Place_id] INT NOT NULL,
    [A+]       INT NOT NULL,
    [A-]       INT NOT NULL,
    [B+]       INT NOT NULL,
    [B-]       INT NOT NULL,
    [AB+]      INT NOT NULL,
    [AB-]      INT NOT NULL,
    [O+]       INT NOT NULL,
    [O-]       INT NOT NULL,
    CONSTRAINT [PK_Blood_amount] PRIMARY KEY CLUSTERED ([Place_id] ASC),
    CONSTRAINT [FK_BloodAmount_Bank] FOREIGN KEY ([Place_id]) REFERENCES [dbo].[Bank_info] ([Place_id])
);


GO
CREATE NONCLUSTERED INDEX [idx_Place]
    ON [dbo].[Blood_amount]([Place_id] ASC);

