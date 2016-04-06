CREATE TABLE [dbo].[check_pos] (
    [num_pos]  INT             NOT NULL,
    [id_check] INT             NOT NULL,
    [quant]    FLOAT (53)      NOT NULL,
    [summ_pos] DECIMAL (19, 2) NOT NULL,
    [id_good]  INT             NOT NULL,
    CONSTRAINT [PK_check_pos] PRIMARY KEY CLUSTERED ([num_pos] ASC, [id_check] ASC),
    CONSTRAINT [FK_check_pos_check_head] FOREIGN KEY ([id_check]) REFERENCES [dbo].[check_head] ([id_check]),
    CONSTRAINT [FK_check_pos_goods] FOREIGN KEY ([id_good]) REFERENCES [dbo].[goods] ([id_good])
);

