CREATE TABLE [dbo].[M性別]
(
  性別      TINYINT not null,
  入力コード1  VARCHAR(1),
  入力コード2  VARCHAR(1),
  入力コード3  VARCHAR(1),
  略称      VARCHAR(4),
  名称      VARCHAR(10),
  ホストコード1 VARCHAR(20),
  ホストコード2 VARCHAR(20),
  ホストコード3 VARCHAR(20),
  予備数字1   FLOAT,
  予備数字2   FLOAT,
  予備文字1   VARCHAR(20),
  予備文字2   VARCHAR(20)
)