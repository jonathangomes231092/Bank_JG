CREATE TABLE [dbo].[Bank_Clientes](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [User] [varchar](20) NOT NULL,
    [Email] [varchar](50) NOT NULL,
    [Password] [varchar](100) NOT NULL, -- O tamanho do campo para a senha pode variar
    PRIMARY KEY CLUSTERED
    (
        [Id] ASC
    ) 
) ON [PRIMARY]

