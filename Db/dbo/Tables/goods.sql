CREATE TABLE [dbo].[goods] (
    [name_good]       VARCHAR (200)   NOT NULL,
    [id_good]         INT             NOT NULL,
    [NDS]             FLOAT (53)      NULL,
    [NSP]             FLOAT (53)      NULL,
    [BarCodeDefault]  VARCHAR (20)    NULL,
    [id_country]      INT             NULL,
    [id_producer]     INT             NULL,
    [id_measure]      INT             NULL,
    [articul]         VARCHAR (30)    NOT NULL,
    [price]           DECIMAL (19, 2) NOT NULL,
    [unused]          INT             NULL,
    [plu]             INT             NULL,
    [min_price]       DECIMAL (19, 2) NULL,
    [last_change]     DATETIME        NULL,
    [id_user_change]  INT             NULL,
    [short_name_good] VARCHAR (50)    NULL,
    [id_type_good]    INT             NULL,
    [remains_rule]    INT             NOT NULL,
    CONSTRAINT [PK_goods] PRIMARY KEY CLUSTERED ([id_good] ASC)
);

