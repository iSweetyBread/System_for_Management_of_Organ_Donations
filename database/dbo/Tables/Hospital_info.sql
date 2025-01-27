CREATE TABLE [dbo].[Hospital_info] (
    [Hospital_id]  INT           NOT NULL,
    [City]         NVARCHAR (15) NOT NULL,
    [Address]      NVARCHAR (30) NOT NULL,
    [Contact_info] NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_Hospital_info] PRIMARY KEY CLUSTERED ([Hospital_id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [idx_HCity]
    ON [dbo].[Hospital_info]([City] ASC);

