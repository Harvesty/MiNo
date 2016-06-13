CREATE TABLE [dbo].[Mログイン]
(
  id       SMALLINT not null,
  password VARCHAR(20),
  名称       VARCHAR(80),
  ユーザー権限   TINYINT,
  使用flg    BIT
)
