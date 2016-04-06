CREATE TABLE [dbo].[check_head] (
    [id_check]  INT             IDENTITY (1, 1) NOT NULL,
    [number]    INT             NOT NULL,
    [datetime]  DATETIME        CONSTRAINT [DF_check_head_datetime] DEFAULT (getdate()) NOT NULL,
    [summ]      DECIMAL (19, 2) NOT NULL,
    [direction] INT             NOT NULL,
    CONSTRAINT [PK_check_head] PRIMARY KEY CLUSTERED ([id_check] ASC)
);

