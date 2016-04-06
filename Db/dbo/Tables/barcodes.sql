CREATE TABLE [dbo].[barcodes] (
    [id_bar_code]       INT          NOT NULL,
    [bar_code_quantity] FLOAT (53)   NULL,
    [bar_code]          VARCHAR (20) NOT NULL,
    [bar_code_price]    MONEY        NULL,
    [id_good]           INT          NULL,
    [Unused]            INT          NULL,
    [ask_quantity]      INT          NULL,
    [ask_serial]        INT          NULL,
    CONSTRAINT [PK_barcodes] PRIMARY KEY CLUSTERED ([id_bar_code] ASC),
    CONSTRAINT [FK_barcodes_goods] FOREIGN KEY ([id_good]) REFERENCES [dbo].[goods] ([id_good])
);

