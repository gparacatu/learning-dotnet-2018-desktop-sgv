USE [master]
GO
/****** Object:  Database [db_sgv]    Script Date: 13/07/2017 11:51:48 ******/
CREATE DATABASE [db_sgv]
GO
ALTER DATABASE [db_sgv] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_sgv].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_sgv] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_sgv] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_sgv] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_sgv] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_sgv] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_sgv] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_sgv] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_sgv] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_sgv] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_sgv] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_sgv] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_sgv] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_sgv] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_sgv] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_sgv] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_sgv] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_sgv] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_sgv] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [db_sgv] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_sgv] SET  MULTI_USER 
GO
ALTER DATABASE [db_sgv] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_sgv] SET ENCRYPTION ON
GO
ALTER DATABASE [db_sgv] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_sgv] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 7), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 10, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO
USE [db_sgv]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_diagramobjects]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE FUNCTION [dbo].[fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
	
GO
/****** Object:  Table [dbo].[tblPessoa]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoa](
	[IDPessoa] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoaTipo] [int] NOT NULL,
	[IDStatus] [int] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_tblPessoa] PRIMARY KEY CLUSTERED 
(
	[IDPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPessoaFisica]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoaFisica](
	[IDPessoaFisica] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Cpf] [varchar](11) NOT NULL,
	[Rg] [varchar](20) NULL,
	[Rua] [varchar](50) NOT NULL,
	[Numero] [int] NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Telefone] [varchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[DataNascimento] [date] NOT NULL,
	[Cep] [varchar](9) NULL,
 CONSTRAINT [PK_tblPessoaFisica] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFisica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPessoaJuridica]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoaJuridica](
	[IDPessoaJuridica] [int] NOT NULL,
	[NomeFantasia] [varchar](50) NULL,
	[RazaoSocial] [varchar](50) NOT NULL,
	[Cnpj] [varchar](14) NOT NULL,
	[Rua] [varchar](50) NOT NULL,
	[Numero] [int] NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Telefone] [varchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[InscricaoEstadual] [varchar](20) NULL,
	[Logo] [varchar](300) NULL,
	[Cep] [varchar](9) NULL,
 CONSTRAINT [PK_tblPessoaJuridica] PRIMARY KEY CLUSTERED 
(
	[IDPessoaJuridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPessoaTipo]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoaTipo](
	[IDPessoaTipo] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblPessoaTipo] PRIMARY KEY CLUSTERED 
(
	[IDPessoaTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  View [dbo].[uvwPessoaFisicaJuridica]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[uvwPessoaFisicaJuridica]
AS
SELECT	 tblPessoa.IDPessoa AS ID,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.NomeFantasia ELSE tblPessoaFisica.Nome END AS Nome,
		 tblPessoaTipo.Descricao,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.Cnpj ELSE tblPessoaFisica.Cpf END AS CPFCNPJ,
		 tblPessoa.DataCadastro,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.Rua ELSE tblPessoaFisica.Rua END AS Rua,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.Numero ELSE tblPessoaFisica.Numero END AS Numero,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.Bairro ELSE tblPessoaFisica.Bairro END AS Bairro,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.Cidade ELSE tblPessoaFisica.Cidade END AS Cidade,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.Telefone ELSE tblPessoaFisica.Telefone END AS Telefone,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.Email ELSE tblPessoaFisica.Email END AS Email,
		 tblPessoaFisica.DataNascimento,	
		 tblPessoaJuridica.RazaoSocial,
		 tblPessoaJuridica.Logo,
		 CASE WHEN tblPessoa.IDPessoaTipo = 1 THEN TblPessoaJuridica.InscricaoEstadual ELSE tblPessoaFisica.Rg END AS RGINSCRICAO	  
FROM tblPessoa
JOIN tblPessoaTipo ON tblPessoa.IDPessoaTipo = tblPessoaTipo.IDPessoaTipo  
LEFT JOIN tblPessoaFisica ON tblPessoa.IDPessoa = tblPessoaFisica.IDPessoaFisica
LEFT JOIN tblPessoaJuridica ON tblPessoa.IDPessoa = tblPessoaJuridica.IDPessoaJuridica
GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [sysname] NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON),
 CONSTRAINT [UK_principal_name] UNIQUE NONCLUSTERED 
(
	[principal_id] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblCaixa]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCaixa](
	[IDCaixa] [int] IDENTITY(1,1) NOT NULL,
	[IDUsuario] [int] NOT NULL,
	[valorTotal] [decimal](18, 2) NOT NULL,
	[Status] [nchar](1) NOT NULL,
	[valorInicial] [decimal](18, 2) NOT NULL,
	[dataAbertura] [datetime] NOT NULL,
	[valorSangria] [decimal](18, 2) NOT NULL,
	[dataFechamento] [datetime] NULL,
	[valorFechamento] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tblCaixa] PRIMARY KEY CLUSTERED 
(
	[IDCaixa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblCaixaRetirada]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCaixaRetirada](
	[IDCaixa] [int] NOT NULL,
	[Descricao] [varchar](300) NOT NULL,
	[valorRetirada] [decimal](18, 2) NOT NULL,
	[dataRetirada] [datetime] NOT NULL
)

GO
/****** Object:  Table [dbo].[tblCaixaSuprimento]    Script Date: 13/07/2017 11:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCaixaSuprimento](
	[IDCaixa] [int] NOT NULL,
	[Descricao] [varchar](300) NOT NULL,
	[valorSuprimento] [decimal](18, 2) NOT NULL,
	[dataRetirada] [datetime] NOT NULL
)

GO
/****** Object:  Table [dbo].[tblEstoque]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoque](
	[IDProduto] [int] NOT NULL,
	[IDPessoaFilial] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tblEstoque] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC,
	[IDPessoaFilial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblEstoqueMovimentacao]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoqueMovimentacao](
	[IDMovimentacao] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoaFilial] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[EntradaSaida] [char](1) NOT NULL,
	[DataHora] [datetime] NOT NULL,
 CONSTRAINT [PK_tblEstoqueMovimentacao] PRIMARY KEY CLUSTERED 
(
	[IDMovimentacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblEstoqueReservado]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoqueReservado](
	[IDProduto] [int] NOT NULL,
	[IDPessoaFilial] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tblEstoqueReservado] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC,
	[IDPessoaFilial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblFilial]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFilial](
	[IDPessoaFilial] [int] NOT NULL,
	[IDStatus] [int] NOT NULL,
 CONSTRAINT [PK_Filial] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFilial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblFormaPagamento]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFormaPagamento](
	[IDPagamento] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](250) NOT NULL,
	[IDFilial] [int] NOT NULL,
	[IDStatus] [int] NOT NULL,
 CONSTRAINT [PK_tblFormaPagamento] PRIMARY KEY CLUSTERED 
(
	[IDPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblOperacao]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOperacao](
	[IDOperacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblOperacao] PRIMARY KEY CLUSTERED 
(
	[IDOperacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPedido]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedido](
	[IDPedido] [int] IDENTITY(1,1) NOT NULL,
	[IDOperacao] [int] NOT NULL,
	[IDSituacao] [int] NOT NULL,
	[DataHora] [datetime] NOT NULL,
	[IDPessoaEmitente] [int] NOT NULL,
	[IDPessoaDestinatario] [int] NOT NULL,
	[ValorTotalComDesconto] [decimal](18, 2) NOT NULL,
	[PorcentagemDesconto] [decimal](18, 2) NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[IDCaixa] [int] NOT NULL,
	[IDPagamento] [int] NOT NULL,
 CONSTRAINT [PK_tblPedido] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPedidoCompra]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedidoCompra](
	[IDPedido] [int] IDENTITY(1,1) NOT NULL,
	[IDOperacao] [int] NOT NULL,
	[IDSituacao] [int] NOT NULL,
	[DataHora] [datetime] NOT NULL,
	[IDPessoaEmitente] [int] NOT NULL,
	[IDPessoaDestinatario] [int] NOT NULL,
	[ValorTotalComDesconto] [decimal](18, 2) NOT NULL,
	[PorcentagemDesconto] [decimal](18, 2) NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[IDPagamento] [int] NOT NULL,
 CONSTRAINT [PK_tblPedidoCompra] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPedidoCompraItem]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedidoCompraItem](
	[IDPedido] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [decimal](18, 2) NOT NULL,
	[PercentualDesconto] [decimal](5, 2) NOT NULL,
	[ValorDesconto] [decimal](18, 2) NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[ValorTotalComDesconto] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblPedidoCompraItem] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC,
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPedidoItem]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedidoItem](
	[IDPedido] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [decimal](18, 2) NOT NULL,
	[PercentualDesconto] [decimal](5, 2) NOT NULL,
	[ValorDesconto] [decimal](18, 2) NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[ValorTotalComDesconto] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblPedidoItem] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC,
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPessoaCliente]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoaCliente](
	[IDPessoaCliente] [int] NOT NULL,
	[IDStatus] [int] NOT NULL,
 CONSTRAINT [PK_tblPessoaCliente] PRIMARY KEY CLUSTERED 
(
	[IDPessoaCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPessoaFornecedor]    Script Date: 13/07/2017 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoaFornecedor](
	[IDPessoaFornecedor] [int] NOT NULL,
	[IDStatus] [int] NOT NULL,
 CONSTRAINT [PK_tblPessoaFornecedor] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblPrecoTipo]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPrecoTipo](
	[IDTipo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblPrecoTipo] PRIMARY KEY CLUSTERED 
(
	[IDTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblProduto]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduto](
	[IDProduto] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[IDCategoria] [int] NOT NULL,
	[IDStatus] [int] NOT NULL,
	[Foto] [varchar](300) NULL,
	[PrecoCusto] [decimal](18, 2) NOT NULL,
	[PrecoVenda] [decimal](18, 2) NOT NULL,
	[IDPessoaFilial] [int] NULL,
 CONSTRAINT [PK_tblProduto] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblProdutoCategoria]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProdutoCategoria](
	[IDCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblProdutoCategoria] PRIMARY KEY CLUSTERED 
(
	[IDCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblProdutoPrecoCustoHistorico]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProdutoPrecoCustoHistorico](
	[IDProduto] [int] NOT NULL,
	[PrecoCustoAnterior] [decimal](18, 2) NULL,
	[PrecoCustoNovo] [decimal](18, 2) NULL,
	[DataHoraAlteracao] [datetime] NOT NULL,
	[IDPessoaFilial] [int] NULL
)

GO
/****** Object:  Table [dbo].[tblProdutoPrecoVendaHistorico]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProdutoPrecoVendaHistorico](
	[IDProduto] [int] NOT NULL,
	[PrecoVendaAnterior] [decimal](18, 2) NULL,
	[PrecoVendaNovo] [decimal](18, 2) NULL,
	[DataHoraAlteracao] [datetime] NOT NULL,
	[IDPessoaFilial] [int] NULL
)

GO
/****** Object:  Table [dbo].[tblSituacao]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSituacao](
	[IDSituacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[IDOperacao] [int] NOT NULL,
 CONSTRAINT [PK_tblSituacao] PRIMARY KEY CLUSTERED 
(
	[IDSituacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblStatus]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStatus](
	[IDStatus] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblStatus] PRIMARY KEY CLUSTERED 
(
	[IDStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[PapelParede] [varchar](300) NULL,
	[Acesso] [int] NOT NULL,
	[IDStatus] [int] NOT NULL,
	[IDPessoaFilial] [int] NOT NULL,
	[IDPessoa] [int] NOT NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
ALTER TABLE [dbo].[tblCaixa] ADD  CONSTRAINT [DF_tblCaixa_valorTotal]  DEFAULT ((0)) FOR [valorTotal]
GO
ALTER TABLE [dbo].[tblCaixa] ADD  CONSTRAINT [DF_tblCaixa_valorInicial]  DEFAULT ((0)) FOR [valorInicial]
GO
ALTER TABLE [dbo].[tblCaixa] ADD  CONSTRAINT [DF_tblCaixa_dataAbertura]  DEFAULT (getdate()) FOR [dataAbertura]
GO
ALTER TABLE [dbo].[tblCaixa] ADD  CONSTRAINT [DF_tblCaixa_valorSangria]  DEFAULT ((0)) FOR [valorSangria]
GO
ALTER TABLE [dbo].[tblCaixa] ADD  CONSTRAINT [DF_tblCaixa_dataFechamento]  DEFAULT ('2000-01-01 00:00:00.000') FOR [dataFechamento]
GO
ALTER TABLE [dbo].[tblCaixa] ADD  CONSTRAINT [DF_tblCaixa_valorFechamento]  DEFAULT ((0)) FOR [valorFechamento]
GO
ALTER TABLE [dbo].[tblCaixaRetirada] ADD  CONSTRAINT [DF_tblCaixaRetirada_dataRetirada]  DEFAULT (getdate()) FOR [dataRetirada]
GO
ALTER TABLE [dbo].[tblCaixaSuprimento] ADD  CONSTRAINT [DF_tblCaixaSuprimento_dataRetirada]  DEFAULT (getdate()) FOR [dataRetirada]
GO
ALTER TABLE [dbo].[tblEstoque] ADD  CONSTRAINT [DF_tblEstoque_Quantidade]  DEFAULT ((0)) FOR [Quantidade]
GO
ALTER TABLE [dbo].[tblEstoqueMovimentacao] ADD  CONSTRAINT [DF_tblEstoqueMovimentacao_DataHora]  DEFAULT (getdate()) FOR [DataHora]
GO
ALTER TABLE [dbo].[tblFilial] ADD  CONSTRAINT [DF_tblFilial_IDStatus]  DEFAULT ((1)) FOR [IDStatus]
GO
ALTER TABLE [dbo].[tblPedido] ADD  CONSTRAINT [DF_tblPedido_DataHora]  DEFAULT (getdate()) FOR [DataHora]
GO
ALTER TABLE [dbo].[tblPedido] ADD  CONSTRAINT [DF_tblPedido_ValorDesconto]  DEFAULT ((0)) FOR [PorcentagemDesconto]
GO
ALTER TABLE [dbo].[tblPedido] ADD  CONSTRAINT [DF_tblPedido_ValorTotal]  DEFAULT ((0)) FOR [ValorTotal]
GO
ALTER TABLE [dbo].[tblPedidoCompra] ADD  CONSTRAINT [DF_tblPedidoCompra_DataHora]  DEFAULT (getdate()) FOR [DataHora]
GO
ALTER TABLE [dbo].[tblPedidoCompra] ADD  CONSTRAINT [DF_tblPedidoCompra_PorcentagemDesconto]  DEFAULT ((0)) FOR [PorcentagemDesconto]
GO
ALTER TABLE [dbo].[tblPedidoCompra] ADD  CONSTRAINT [DF_tblPedidoCompra_ValorTotal]  DEFAULT ((0)) FOR [ValorTotal]
GO
ALTER TABLE [dbo].[tblPedidoCompraItem] ADD  CONSTRAINT [DF_tblPedidoCompraItem_ValorUnitario]  DEFAULT ((0)) FOR [ValorUnitario]
GO
ALTER TABLE [dbo].[tblPedidoCompraItem] ADD  CONSTRAINT [DF_tblPedidoCompraItem_PercentualDesconto]  DEFAULT ((0)) FOR [PercentualDesconto]
GO
ALTER TABLE [dbo].[tblPedidoCompraItem] ADD  CONSTRAINT [DF_tblPedidoCompraItem_ValorDesconto]  DEFAULT ((0)) FOR [ValorDesconto]
GO
ALTER TABLE [dbo].[tblPedidoCompraItem] ADD  CONSTRAINT [DF_tblPedidoCompraItem_ValorTotal]  DEFAULT ((0)) FOR [ValorTotal]
GO
ALTER TABLE [dbo].[tblPedidoItem] ADD  CONSTRAINT [DF_tblPedidoItem_ValorUnitario]  DEFAULT ((0)) FOR [ValorUnitario]
GO
ALTER TABLE [dbo].[tblPedidoItem] ADD  CONSTRAINT [DF_tblPedidoItem_PercentualDesconto]  DEFAULT ((0)) FOR [PercentualDesconto]
GO
ALTER TABLE [dbo].[tblPedidoItem] ADD  CONSTRAINT [DF_tblPedidoItem_ValorDesconto]  DEFAULT ((0)) FOR [ValorDesconto]
GO
ALTER TABLE [dbo].[tblPedidoItem] ADD  CONSTRAINT [DF_tblPedidoItem_ValorTotal]  DEFAULT ((0)) FOR [ValorTotal]
GO
ALTER TABLE [dbo].[tblPessoa] ADD  CONSTRAINT [DF_tblPessoa_DataCadastro]  DEFAULT (getdate()) FOR [DataCadastro]
GO
ALTER TABLE [dbo].[tblPessoaCliente] ADD  CONSTRAINT [DF_tblPessoaCliente_IDStatus]  DEFAULT ((1)) FOR [IDStatus]
GO
ALTER TABLE [dbo].[tblPessoaFornecedor] ADD  CONSTRAINT [DF_tblPessoaFornecedor_IDStatus]  DEFAULT ((1)) FOR [IDStatus]
GO
ALTER TABLE [dbo].[tblProduto] ADD  CONSTRAINT [DF_tblProduto_PrecoCusto]  DEFAULT ((0)) FOR [PrecoCusto]
GO
ALTER TABLE [dbo].[tblProduto] ADD  CONSTRAINT [DF_tblProduto_PrecoVenda]  DEFAULT ((0)) FOR [PrecoVenda]
GO
ALTER TABLE [dbo].[tblProdutoPrecoCustoHistorico] ADD  CONSTRAINT [DF_tblProdutoPrecoCustoHistorico_PrecoCustoAnterior]  DEFAULT ((0)) FOR [PrecoCustoAnterior]
GO
ALTER TABLE [dbo].[tblProdutoPrecoCustoHistorico] ADD  CONSTRAINT [DF_tblProdutoPrecoCustoHistorico_PrecoCustoNovo]  DEFAULT ((0)) FOR [PrecoCustoNovo]
GO
ALTER TABLE [dbo].[tblProdutoPrecoCustoHistorico] ADD  CONSTRAINT [DF_tblProdutoPrecoCustoHistorico_DataHoraAlteracao]  DEFAULT (getdate()) FOR [DataHoraAlteracao]
GO
ALTER TABLE [dbo].[tblProdutoPrecoVendaHistorico] ADD  CONSTRAINT [DF_tblProdutoPrecoHistorico_PrecoVendaAnterior]  DEFAULT ((0)) FOR [PrecoVendaAnterior]
GO
ALTER TABLE [dbo].[tblProdutoPrecoVendaHistorico] ADD  CONSTRAINT [DF_tblProdutoPrecoHistorico_PrecoVendaNovo]  DEFAULT ((0)) FOR [PrecoVendaNovo]
GO
ALTER TABLE [dbo].[tblProdutoPrecoVendaHistorico] ADD  CONSTRAINT [DF_tblProdutoPrecoHistorico_DataHoraAlteracao]  DEFAULT (getdate()) FOR [DataHoraAlteracao]
GO
ALTER TABLE [dbo].[tblCaixa]  WITH CHECK ADD  CONSTRAINT [FK_tblCaixa_tblUsuario] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[tblUsuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[tblCaixa] CHECK CONSTRAINT [FK_tblCaixa_tblUsuario]
GO
ALTER TABLE [dbo].[tblCaixaRetirada]  WITH CHECK ADD  CONSTRAINT [FK_tblCaixaRetirada_tblCaixa] FOREIGN KEY([IDCaixa])
REFERENCES [dbo].[tblCaixa] ([IDCaixa])
GO
ALTER TABLE [dbo].[tblCaixaRetirada] CHECK CONSTRAINT [FK_tblCaixaRetirada_tblCaixa]
GO
ALTER TABLE [dbo].[tblCaixaSuprimento]  WITH CHECK ADD  CONSTRAINT [FK_tblCaixaSuprimento_tblCaixa] FOREIGN KEY([IDCaixa])
REFERENCES [dbo].[tblCaixa] ([IDCaixa])
GO
ALTER TABLE [dbo].[tblCaixaSuprimento] CHECK CONSTRAINT [FK_tblCaixaSuprimento_tblCaixa]
GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_Filial] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_Filial]
GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblProduto]
GO
ALTER TABLE [dbo].[tblEstoqueMovimentacao]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueMovimentacao_tblFilial] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblEstoqueMovimentacao] CHECK CONSTRAINT [FK_tblEstoqueMovimentacao_tblFilial]
GO
ALTER TABLE [dbo].[tblEstoqueMovimentacao]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueMovimentacao_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblEstoqueMovimentacao] CHECK CONSTRAINT [FK_tblEstoqueMovimentacao_tblProduto]
GO
ALTER TABLE [dbo].[tblEstoqueReservado]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueReservado_tblEstoque] FOREIGN KEY([IDProduto], [IDPessoaFilial])
REFERENCES [dbo].[tblEstoque] ([IDProduto], [IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblEstoqueReservado] CHECK CONSTRAINT [FK_tblEstoqueReservado_tblEstoque]
GO
ALTER TABLE [dbo].[tblFilial]  WITH CHECK ADD  CONSTRAINT [FK_tblFilial_tblStatus] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[tblStatus] ([IDStatus])
GO
ALTER TABLE [dbo].[tblFilial] CHECK CONSTRAINT [FK_tblFilial_tblStatus]
GO
ALTER TABLE [dbo].[tblFormaPagamento]  WITH CHECK ADD  CONSTRAINT [FK_tblFormaPagamento_tblFilial] FOREIGN KEY([IDFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblFormaPagamento] CHECK CONSTRAINT [FK_tblFormaPagamento_tblFilial]
GO
ALTER TABLE [dbo].[tblFormaPagamento]  WITH CHECK ADD  CONSTRAINT [FK_tblFormaPagamento_tblStatus] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[tblStatus] ([IDStatus])
GO
ALTER TABLE [dbo].[tblFormaPagamento] CHECK CONSTRAINT [FK_tblFormaPagamento_tblStatus]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblCaixa] FOREIGN KEY([IDCaixa])
REFERENCES [dbo].[tblCaixa] ([IDCaixa])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblCaixa]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblFormaPagamento] FOREIGN KEY([IDPagamento])
REFERENCES [dbo].[tblFormaPagamento] ([IDPagamento])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblFormaPagamento]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblOperacao] FOREIGN KEY([IDOperacao])
REFERENCES [dbo].[tblOperacao] ([IDOperacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblOperacao]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblPessoa_Destinatario] FOREIGN KEY([IDPessoaDestinatario])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblPessoa_Destinatario]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblPessoa_Emitente] FOREIGN KEY([IDPessoaEmitente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblPessoa_Emitente]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblSituacao] FOREIGN KEY([IDSituacao])
REFERENCES [dbo].[tblSituacao] ([IDSituacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblSituacao]
GO
ALTER TABLE [dbo].[tblPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoCompra_tblFormaPagamento] FOREIGN KEY([IDPagamento])
REFERENCES [dbo].[tblFormaPagamento] ([IDPagamento])
GO
ALTER TABLE [dbo].[tblPedidoCompra] CHECK CONSTRAINT [FK_tblPedidoCompra_tblFormaPagamento]
GO
ALTER TABLE [dbo].[tblPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoCompra_tblOperacao] FOREIGN KEY([IDOperacao])
REFERENCES [dbo].[tblOperacao] ([IDOperacao])
GO
ALTER TABLE [dbo].[tblPedidoCompra] CHECK CONSTRAINT [FK_tblPedidoCompra_tblOperacao]
GO
ALTER TABLE [dbo].[tblPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoCompra_tblPessoa] FOREIGN KEY([IDPessoaEmitente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPedidoCompra] CHECK CONSTRAINT [FK_tblPedidoCompra_tblPessoa]
GO
ALTER TABLE [dbo].[tblPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoCompra_tblPessoa1] FOREIGN KEY([IDPessoaDestinatario])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPedidoCompra] CHECK CONSTRAINT [FK_tblPedidoCompra_tblPessoa1]
GO
ALTER TABLE [dbo].[tblPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoCompra_tblSituacao] FOREIGN KEY([IDSituacao])
REFERENCES [dbo].[tblSituacao] ([IDSituacao])
GO
ALTER TABLE [dbo].[tblPedidoCompra] CHECK CONSTRAINT [FK_tblPedidoCompra_tblSituacao]
GO
ALTER TABLE [dbo].[tblPedidoCompraItem]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoCompraItem_tblPedidoCompra] FOREIGN KEY([IDPedido])
REFERENCES [dbo].[tblPedidoCompra] ([IDPedido])
GO
ALTER TABLE [dbo].[tblPedidoCompraItem] CHECK CONSTRAINT [FK_tblPedidoCompraItem_tblPedidoCompra]
GO
ALTER TABLE [dbo].[tblPedidoCompraItem]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoCompraItem_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblPedidoCompraItem] CHECK CONSTRAINT [FK_tblPedidoCompraItem_tblProduto]
GO
ALTER TABLE [dbo].[tblPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoItem_tblPedido] FOREIGN KEY([IDPedido])
REFERENCES [dbo].[tblPedido] ([IDPedido])
GO
ALTER TABLE [dbo].[tblPedidoItem] CHECK CONSTRAINT [FK_tblPedidoItem_tblPedido]
GO
ALTER TABLE [dbo].[tblPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoItem_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblPedidoItem] CHECK CONSTRAINT [FK_tblPedidoItem_tblProduto]
GO
ALTER TABLE [dbo].[tblPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoa_tblPessoaTipo] FOREIGN KEY([IDPessoaTipo])
REFERENCES [dbo].[tblPessoaTipo] ([IDPessoaTipo])
GO
ALTER TABLE [dbo].[tblPessoa] CHECK CONSTRAINT [FK_tblPessoa_tblPessoaTipo]
GO
ALTER TABLE [dbo].[tblPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoa_tblStatus] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[tblStatus] ([IDStatus])
GO
ALTER TABLE [dbo].[tblPessoa] CHECK CONSTRAINT [FK_tblPessoa_tblStatus]
GO
ALTER TABLE [dbo].[tblPessoaCliente]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaCliente_tblPessoa] FOREIGN KEY([IDPessoaCliente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPessoaCliente] CHECK CONSTRAINT [FK_tblPessoaCliente_tblPessoa]
GO
ALTER TABLE [dbo].[tblPessoaCliente]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaCliente_tblStatus] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[tblStatus] ([IDStatus])
GO
ALTER TABLE [dbo].[tblPessoaCliente] CHECK CONSTRAINT [FK_tblPessoaCliente_tblStatus]
GO
ALTER TABLE [dbo].[tblPessoaFisica]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaFisica_tblPessoa] FOREIGN KEY([IDPessoaFisica])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPessoaFisica] CHECK CONSTRAINT [FK_tblPessoaFisica_tblPessoa]
GO
ALTER TABLE [dbo].[tblPessoaFornecedor]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaFornecedor_tblPessoa] FOREIGN KEY([IDPessoaFornecedor])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPessoaFornecedor] CHECK CONSTRAINT [FK_tblPessoaFornecedor_tblPessoa]
GO
ALTER TABLE [dbo].[tblPessoaFornecedor]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaFornecedor_tblStatus] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[tblStatus] ([IDStatus])
GO
ALTER TABLE [dbo].[tblPessoaFornecedor] CHECK CONSTRAINT [FK_tblPessoaFornecedor_tblStatus]
GO
ALTER TABLE [dbo].[tblPessoaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaJuridica_tblPessoa] FOREIGN KEY([IDPessoaJuridica])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPessoaJuridica] CHECK CONSTRAINT [FK_tblPessoaJuridica_tblPessoa]
GO
ALTER TABLE [dbo].[tblProduto]  WITH CHECK ADD  CONSTRAINT [FK_tblProduto_tblFilial] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblProduto] CHECK CONSTRAINT [FK_tblProduto_tblFilial]
GO
ALTER TABLE [dbo].[tblProduto]  WITH CHECK ADD  CONSTRAINT [FK_tblProduto_tblProdutoCategoria] FOREIGN KEY([IDCategoria])
REFERENCES [dbo].[tblProdutoCategoria] ([IDCategoria])
GO
ALTER TABLE [dbo].[tblProduto] CHECK CONSTRAINT [FK_tblProduto_tblProdutoCategoria]
GO
ALTER TABLE [dbo].[tblProduto]  WITH CHECK ADD  CONSTRAINT [FK_tblProduto_tblStatus] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[tblStatus] ([IDStatus])
GO
ALTER TABLE [dbo].[tblProduto] CHECK CONSTRAINT [FK_tblProduto_tblStatus]
GO
ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tblUsuario_tblFilial] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_tblUsuario_tblFilial]
GO
ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tblUsuario_tblPessoa] FOREIGN KEY([IDPessoa])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_tblUsuario_tblPessoa]
GO
ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tblUsuario_tblStatus] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[tblStatus] ([IDStatus])
GO
ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_tblUsuario_tblStatus]
GO
/****** Object:  StoredProcedure [dbo].[sp_alterdiagram]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_alterdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_creatediagram]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_creatediagram]
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_dropdiagram]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_dropdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_helpdiagramdefinition]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_helpdiagramdefinition]
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_helpdiagrams]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_helpdiagrams]
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_renamediagram]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_renamediagram]
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_upgraddiagrams]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_upgraddiagrams]
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
	
GO
/****** Object:  StoredProcedure [dbo].[uspCaixaAbertoConsultarPorUsuario]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCaixaAbertoConsultarPorUsuario]
@IDUSUARIO INT
AS
BEGIN
--BEGIN TRY

	--VERIFICA SE EXISTE ALGUM CAIXA ABERTO PARA ESSE FUNCIONARIO
	--IF(NOT EXISTS(SELECT IDCaixa FROM tblCaixa WHERE IDUsuario = @IDUSUARIO AND Status = 'A'))
	--RAISERROR('Não existe um caixa aberto para esse usuário.',14,1);

	SELECT * FROM tblCaixa WHERE IDUsuario = @IDUSUARIO AND Status = 'A';

--END TRY
--BEGIN CATCH

	SELECT ERROR_MESSAGE() AS RETORNO;

--END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspCaixaAbrir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCaixaAbrir]
@IDUSUARIO INT,
@VALORINICIAL DECIMAL (18,2)
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	--VERIFICA SE EXISTE ALGUM CAIXA ABERTO PARA ESSE FUNCIONARIO
	IF(EXISTS(SELECT IDCaixa FROM tblCaixa WHERE IDUsuario = @IDUSUARIO AND Status = 'A'))
	RAISERROR('Já existe um caixa aberto para esse usuário.',14,1);

	INSERT INTO tblCaixa (IDUsuario, valorTotal, Status, valorInicial) VALUES (@IDUSUARIO, @VALORINICIAL, 'A', @VALORINICIAL);

	SELECT @@IDENTITY AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspCaixaFechamentoRelatorio]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCaixaFechamentoRelatorio]
@IDCAIXA AS INT
AS
BEGIN

	SELECT Caixa.IDCaixa, Pessoa.Nome AS Responsavel, Caixa.dataAbertura, Caixa.dataFechamento, Caixa.valorInicial, Caixa.valorTotal, Caixa.valorFechamento, Caixa.valorSangria
	FROM tblCaixa AS Caixa
	JOIN tblUsuario AS Usuario ON Usuario.IDUsuario = Caixa.IDUsuario
	JOIN uvwPessoaFisicaJuridica AS Pessoa ON Pessoa.ID = Usuario.IDPessoa
	WHERE IDCaixa = @IDCAIXA

END



GO
/****** Object:  StoredProcedure [dbo].[uspCaixaFechamentoRelatorioItensPedidos]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCaixaFechamentoRelatorioItensPedidos]
@IDPEDIDO AS INT
AS
BEGIN

	SELECT Produto.Nome AS Produto, PedidoItem.Quantidade, PedidoItem.ValorUnitario, PedidoItem.PercentualDesconto, PedidoItem.ValorDesconto, PedidoItem.ValorTotal, PedidoItem.ValorTotalComDesconto
	FROM tblPedidoItem AS PedidoItem
	JOIN tblProduto AS Produto ON Produto.IDProduto = PedidoItem.IDProduto
	WHERE PedidoItem.IDPedido = @IDPEDIDO

END



GO
/****** Object:  StoredProcedure [dbo].[uspCaixaFechamentoRelatorioPedidos]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCaixaFechamentoRelatorioPedidos]
@IDCAIXA AS INT
AS
BEGIN

	SELECT Pedido.IDPedido, Pedido.DataHora, Emitente.Nome AS Emitente, Destinatario.Nome AS Destinatario, Pedido.ValorTotal,Pedido.ValorTotalComDesconto, Pedido.PorcentagemDesconto, Pagamento.Descricao AS Pagamento
	FROM tblPedido Pedido JOIN uvwPessoaFisicaJuridica AS Emitente ON Emitente.ID = Pedido.IDPessoaEmitente
	JOIN uvwPessoaFisicaJuridica AS Destinatario ON Destinatario.ID = Pedido.IDPessoaDestinatario
	JOIN tblFormaPagamento AS Pagamento ON Pagamento.IDPagamento = Pedido.IDPagamento
	WHERE Pedido.IDCaixa = @IDCAIXA

END



GO
/****** Object:  StoredProcedure [dbo].[uspCaixaFechar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCaixaFechar]
@IDUSUARIO INT,
@IDCAIXA INT,
@VALORSANGRIA DECIMAL (18,2),
@VALORFECHAMENTO DECIMAL (18,2)
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	--VERIFICA SE EXISTE ALGUM CAIXA ABERTO PARA ESSE FUNCIONARIO
	IF(NOT EXISTS(SELECT IDCaixa FROM tblCaixa WHERE IDUsuario = @IDUSUARIO AND Status = 'A' AND IDCaixa = @IDCAIXA))
	RAISERROR('Não existe um caixa aberto com esse ID para esse usuário.',14,1);

	UPDATE tblCaixa SET valorSangria = @VALORSANGRIA, 
						valorFechamento = @VALORFECHAMENTO,
						dataFechamento = GETDATE(),
						Status = 'F'
						WHERE IDCaixa = @IDCAIXA
						

	SELECT @IDCAIXA AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspCaixaRelatorioPorDataAbertura]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspCaixaRelatorioPorDataAbertura]
@DATAINICIAL AS DATETIME,
@DATAFINAL AS DATETIME
AS
BEGIN

	SELECT Caixa.IDCaixa, Pessoa.Nome AS Responsavel, Caixa.dataAbertura, Caixa.dataFechamento, Caixa.valorInicial, Caixa.valorTotal, Caixa.valorFechamento, Caixa.valorSangria, Pedido.IDPedido, Pedido.DataHora, Emitente.Nome AS Emitente, Destinatario.Nome AS Destinatario, Pedido.ValorTotal AS ValorTotalPedido,Pedido.ValorTotalComDesconto AS ValorTotalComDescontoPedido, Pedido.PorcentagemDesconto, Pagamento.Descricao AS Pagamento
	FROM tblCaixa AS Caixa
	JOIN tblPedido Pedido ON Pedido.IDCaixa = Caixa.IDCaixa
	JOIN tblUsuario AS Usuario ON Usuario.IDUsuario = Caixa.IDUsuario
	JOIN uvwPessoaFisicaJuridica AS Pessoa ON Pessoa.ID = Usuario.IDPessoa
	JOIN uvwPessoaFisicaJuridica AS Emitente ON Emitente.ID = Pedido.IDPessoaEmitente
	JOIN uvwPessoaFisicaJuridica AS Destinatario ON Destinatario.ID = Pedido.IDPessoaDestinatario
	JOIN tblFormaPagamento AS Pagamento ON Pagamento.IDPagamento = Pedido.IDPagamento
	WHERE CAST(Caixa.dataAbertura AS DATE) BETWEEN @DATAINICIAL AND @DATAFINAL ORDER BY Caixa.IDCaixa ASC

END



GO
/****** Object:  StoredProcedure [dbo].[uspCaixaRetirar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCaixaRetirar]
@IDUSUARIO INT,
@IDCAIXA INT,
@VALORRETIRADA DECIMAL (18,2),
@DESCRICAORETIRADA VARCHAR(300)
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	--VERIFICA SE EXISTE ALGUM CAIXA ABERTO PARA ESSE FUNCIONARIO
	IF(NOT EXISTS(SELECT IDCaixa FROM tblCaixa WHERE IDUsuario = @IDUSUARIO AND Status = 'A' AND IDCaixa = @IDCAIXA))
	RAISERROR('Não existe um caixa aberto para esse usuário.',14,1);

	--VERIFICA SE EXISTE O VALOR A SER RETIRADO EM CAIXA
	DECLARE @VALORTOTALEMCAIXA AS DECIMAL(18,2) = (SELECT valorTotal FROM tblCaixa WHERE IDUsuario = @IDUSUARIO AND Status = 'A' AND IDCaixa = @IDCAIXA);
	IF(@VALORRETIRADA > @VALORTOTALEMCAIXA)
	RAISERROR('O valor solicitado para retirada é maior que o valor em caixa. Solicite um valor menor.',14,1);
	

	INSERT INTO tblCaixaRetirada (IDCaixa, valorRetirada, Descricao) VALUES (@IDCAIXA, @VALORRETIRADA, @DESCRICAORETIRADA)

	UPDATE tblCaixa SET valorTotal = valorTotal-@VALORRETIRADA WHERE IDCaixa = @IDCAIXA;					
						

	SELECT @@IDENTITY AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspCaixaSuprimento]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCaixaSuprimento]
@IDUSUARIO INT,
@IDCAIXA INT,
@VALORSUPRIMENTO DECIMAL (18,2),
@DESCRICAOSUPRIMENTO VARCHAR(300)
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	--VERIFICA SE EXISTE ALGUM CAIXA ABERTO PARA ESSE FUNCIONARIO
	IF(NOT EXISTS(SELECT IDCaixa FROM tblCaixa WHERE IDUsuario = @IDUSUARIO AND Status = 'A' AND IDCaixa = @IDCAIXA))
	RAISERROR('Não existe um caixa aberto para esse usuário.',14,1);

	--VERIFICA SE O VALOR É POSITIVO	
	IF(@VALORSUPRIMENTO <= 0)
	RAISERROR('O valor do suprimento precisa ser maior que ZERO.',14,1);
	

	INSERT INTO tblCaixaSuprimento (IDCaixa, valorSuprimento, Descricao) VALUES (@IDCAIXA, @VALORSUPRIMENTO, @DESCRICAOSUPRIMENTO)

	UPDATE tblCaixa SET valorTotal = valorTotal+@VALORSUPRIMENTO WHERE IDCaixa = @IDCAIXA;					
						

	SELECT @@IDENTITY AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteAlterar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspClienteAlterar]
@IDPessoaCliente AS INT,
@IDSTATUS AS INT
AS

BEGIN
BEGIN TRY
BEGIN TRAN
		
	IF(NOT EXISTS(SELECT IDPessoaCliente FROM tblPessoaCliente WHERE IDPessoaCliente = @IDPessoaCliente))
		RAISERROR('Erro ao alterar. Cliente não existe!', 14, 1);

		UPDATE tblPessoaCliente SET IDStatus = @IDSTATUS WHERE IDPessoaCliente = @IDPessoaCliente

		SELECT @IDPessoaCliente AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorIdNome]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspClienteConsultarPorIdNome]
@IDPessoaCliente AS INT = NULL,
@Nome AS VARCHAR(50) = NULL
AS
BEGIN

IF @IDPessoaCliente = -1 SET @IDPessoaCliente = NULL;

	SELECT Pes.ID AS IDCliente,
		   Pes.Nome,
		   Pes.Descricao AS Tipo,
		   Pes.CPFCNPJ,
		   Pes.DataCadastro,
		   Pes.Rua,
		   Pes.Numero,
		   Pes.Bairro,
		   Pes.Cidade,
		   Pes.Telefone,
		   Pes.Email,
		   STATUS.Descricao AS STATUS
	FROM tblPessoaCliente AS CLI JOIN uvwPessoaFisicaJuridica AS Pes ON CLI.IDPessoaCliente = Pes.ID
	LEFT JOIN tblStatus STATUS ON STATUS.IDStatus = CLI.IDStatus
	WHERE (@IDPessoaCliente IS NULL OR CLI.IDPessoaCliente = @IDPessoaCliente) AND (@Nome IS NULL OR Pes.Nome LIKE '%'+@Nome+'%') 

END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorIdNomeVenda]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteConsultarPorIdNomeVenda]
@IDPessoaCliente AS INT = NULL,
@Nome AS VARCHAR(50) = NULL
AS
BEGIN

IF @IDPessoaCliente = -1 SET @IDPessoaCliente = NULL;

	SELECT Pes.ID AS IDCliente,
		   Pes.Nome,
		   Pes.Descricao AS Tipo,
		   Pes.CPFCNPJ,
		   Pes.DataCadastro,
		   Pes.Rua,
		   Pes.Numero,
		   Pes.Bairro,
		   Pes.Cidade,
		   Pes.Telefone,
		   Pes.Email,
		   STATUS.Descricao AS STATUS
	FROM tblPessoaCliente AS CLI JOIN uvwPessoaFisicaJuridica AS Pes ON CLI.IDPessoaCliente = Pes.ID
	LEFT JOIN tblStatus STATUS ON STATUS.IDStatus = CLI.IDStatus
	WHERE (@IDPessoaCliente IS NULL OR CLI.IDPessoaCliente = @IDPessoaCliente) AND (@Nome IS NULL OR Pes.Nome LIKE '%'+@Nome+'%') AND (CLI.IDStatus = 1)

END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspClienteInserir]
@IDPessoaCliente AS INT
AS

BEGIN
BEGIN TRY
BEGIN TRAN
		
	IF(EXISTS(SELECT IDPessoaCliente FROM tblPessoaCliente WHERE IDPessoaCliente = @IDPessoaCliente))
		RAISERROR('Erro ao cadastrar esse cliente. Essa pessoa já é um Cliente!', 14, 1);

		INSERT INTO tblPessoaCliente (IDPessoaCliente) VALUES (@IDPessoaCliente);

		SELECT @IDPessoaCliente AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueConsultarPorNomeCodigoProduto]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspEstoqueConsultarPorNomeCodigoProduto]
@IDPessoaFilial AS INT = NULL,
@IDProduto AS INT = NULL,
@Nome AS VARCHAR(50) = NULL
AS
BEGIN

	SELECT Prod.IDProduto,
		   Prod.Nome,
		   Estoque.Quantidade,
		   pes.ID AS IDFilial,
		   Pes.Nome AS Filial,
		   Status.Descricao
		   FROM tblEstoque AS Estoque JOIN tblProduto AS Prod ON Estoque.IDProduto = Prod.IDProduto
	LEFT JOIN uvwPessoaFisicaJuridica AS Pes ON Estoque.IDPessoaFilial = Pes.ID
	LEFT JOIN tblStatus AS Status ON Prod.IDStatus = Status.IDStatus
	WHERE (Estoque.IDPessoaFilial = coalesce(@IDPessoaFilial, Estoque.IDPessoaFilial))  AND (Prod.IDProduto = coalesce(@IDProduto, Prod.IDProduto)) AND (Prod.Nome LIKE '%' + coalesce(@Nome, Prod.Nome)+'%');

END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueDisponivel]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspEstoqueDisponivel]
@IDProduto AS INT,
@IDFilial AS INT

AS
BEGIN
BEGIN TRY

		DECLARE @NOMEPRODUTO VARCHAR(50),
				@QUANTIDADERESERVADA INT = 0,
				@QUANTIDADEESTOQUE INT = 0,
				@QUANTIDADEDISPONIVEL INT = 0,
				@FILIAL VARCHAR(50),
				@FILIALTIPO VARCHAR(50)
		
		IF(EXISTS((SELECT Nome FROM tblProduto AS PRODUTO JOIN tblEstoque AS ESTOQUE ON PRODUTO.IDProduto = ESTOQUE.IDProduto WHERE PRODUTO.IDProduto = @IDProduto AND ESTOQUE.IDPessoaFilial = @IDFilial)))
		BEGIN
		SET @NOMEPRODUTO = (SELECT Nome FROM tblProduto AS PRODUTO JOIN tblEstoque AS ESTOQUE ON PRODUTO.IDProduto = ESTOQUE.IDProduto WHERE PRODUTO.IDProduto = @IDProduto AND ESTOQUE.IDPessoaFilial = @IDFilial);
		END
		ELSE
		BEGIN
		RAISERROR('Produto não encontrado no estoque.',14,1);
		END

		IF(EXISTS((SELECT Quantidade FROM tblEstoque AS ESTOQUE WHERE ESTOQUE.IDPessoaFilial = @IDFilial AND ESTOQUE.IDProduto = @IDProduto)))
		SET @QUANTIDADEESTOQUE = (SELECT Quantidade FROM tblEstoque AS ESTOQUE WHERE ESTOQUE.IDPessoaFilial = @IDFilial AND ESTOQUE.IDProduto = @IDProduto);
		
		IF(EXISTS((SELECT Quantidade FROM tblEstoqueReservado AS RESERVADO WHERE RESERVADO.IDPessoaFilial = @IDFilial AND RESERVADO.IDProduto = @IDProduto AND Quantidade >= 0)))
		BEGIN
		SET @QUANTIDADERESERVADA = (SELECT Quantidade FROM tblEstoqueReservado AS RESERVADO WHERE RESERVADO.IDPessoaFilial = @IDFilial AND RESERVADO.IDProduto = @IDProduto);
		END
		ELSE
		BEGIN
		SET @QUANTIDADERESERVADA = 0;
		--RAISERROR('ERRO AO CONSULTAR ESTOQUE RESERVADO. ESTOQUE RESERVADO NÃO PODE SER MENOR QUE ZERO! ENTRE EM CONTATO COM O SUPORTE TÉCNICO.',14,1);
		END
		IF(EXISTS((SELECT Nome FROM uvwPessoaFisicaJuridica AS FILIAL WHERE FILIAL.ID = @IDFilial)))
		SET @FILIAL = (SELECT Nome FROM uvwPessoaFisicaJuridica AS FILIAL WHERE FILIAL.ID = @IDFilial);
		
		IF(EXISTS((SELECT Descricao FROM tblPessoaTipo AS TIPO WHERE TIPO.IDPessoaTipo = @IDFilial)))
		SET @FILIALTIPO = (SELECT Descricao FROM tblPessoaTipo AS TIPO WHERE TIPO.IDPessoaTipo = @IDFilial);

		SET @QUANTIDADEDISPONIVEL = COALESCE(@QUANTIDADEESTOQUE,0) - COALESCE(@QUANTIDADERESERVADA,0);

		
		SELECT  @NOMEPRODUTO AS Produto,
				@QUANTIDADEESTOQUE AS QuantidadeEstoque,
				@QUANTIDADERESERVADA AS QuantidadeReservada,
				@QUANTIDADEDISPONIVEL AS QuantidadeDisponivel,
				@FILIAL AS Filial,
				@FILIALTIPO AS TipoFilial

END TRY
BEGIN CATCH	
	SELECT ERROR_MESSAGE() AS RETORNO;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueManter]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspEstoqueManter]
@IDProduto AS INT,
@IDPessoaFilial AS INT,
@Quantidade AS INT
AS

BEGIN
BEGIN TRY
BEGIN TRAN

	IF(EXISTS(SELECT IDProduto FROM tblEstoque WHERE IDProduto = @IDProduto AND IDPessoaFilial = @IDPessoaFilial))
	BEGIN
		UPDATE tblEstoque SET Quantidade = Quantidade + @Quantidade WHERE IDProduto = @IDProduto AND IDPessoaFilial = @IDPessoaFilial; 
	END
	ELSE
	BEGIN
		INSERT INTO tblEstoque (IDProduto, IDPessoaFilial, Quantidade) VALUES (@IDProduto, @IDPessoaFilial, @Quantidade);
	END

	DECLARE @EntradaSaida AS CHAR(1);
	IF(@Quantidade < 0)
	BEGIN
		SET @EntradaSaida = 'S';
	END
	ELSE
	BEGIN
		SET @EntradaSaida = 'E';
	END

	INSERT INTO tblEstoqueMovimentacao (IDPessoaFilial, IDProduto, Quantidade, EntradaSaida) VALUES (@IDPessoaFilial, @IDProduto, @Quantidade, @EntradaSaida);
	
	SELECT @IDProduto AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH
	
	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueManterReservado]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspEstoqueManterReservado]
@IDProduto AS INT,
@IDPessoaFilial AS INT,
@Quantidade AS INT

AS
BEGIN
BEGIN TRY
BEGIN TRAN
	
	IF(EXISTS(SELECT IDProduto FROM tblEstoqueReservado WHERE IDProduto = @IDProduto AND IDPessoaFilial = @IDPessoaFilial))
	BEGIN
		UPDATE tblEstoqueReservado SET Quantidade = Quantidade + @Quantidade WHERE IDProduto = @IDProduto AND IDPessoaFilial = @IDPessoaFilial;
	END
	ELSE
	BEGIN
		INSERT INTO tblEstoqueReservado (IDProduto, IDPessoaFilial, Quantidade) VALUES (@IDProduto, @IDPessoaFilial, @Quantidade);
	END

	SELECT @IDProduto AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH
	
	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueMovimentacaoConsultarPorFilial]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspEstoqueMovimentacaoConsultarPorFilial]
@Filial AS INT
AS
BEGIN

	SELECT MOV.IDMovimentacao,
		   Filial.ID AS IDFilial,	
		   Filial.Nome AS Filial,
		   PROD.IDProduto,
		   PROD.Nome AS Produto,
		   MOV.Quantidade,
		   MOV.EntradaSaida,
		   MOV.DataHora	
	FROM tblEstoqueMovimentacao AS MOV 
	JOIN uvwPessoaFisicaJuridica AS Filial ON MOV.IDPessoaFilial = Filial.ID
	LEFT JOIN tblProduto AS PROD ON MOV.IDProduto = PROD.IDProduto
	WHERE Filial.ID = @Filial;

END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueReservadoConsulta]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspEstoqueReservadoConsulta]
@Filial AS INT
AS
BEGIN

	SELECT EST.Quantidade,PROD.IDProduto, PROD.Nome AS Produto,FILIAL.ID AS IDFilial, FILIAL.Nome AS Filial FROM tblEstoqueReservado AS EST
	JOIN tblProduto AS PROD ON EST.IDProduto = PROD.IDProduto
	LEFT JOIN uvwPessoaFisicaJuridica AS FILIAL ON EST.IDPessoaFilial = FILIAL.ID
	WHERE EST.IDPessoaFilial = @Filial;

END
GO
/****** Object:  StoredProcedure [dbo].[uspFilialAlterar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspFilialAlterar]
@IDPessoaFilial AS INT,
@IDSTATUS AS INT
AS

BEGIN
BEGIN TRY
BEGIN TRAN
		
	IF(NOT EXISTS(SELECT IDPessoaFilial FROM tblFilial WHERE IDPessoaFilial = @IDPessoaFilial))
		RAISERROR('Erro ao alterar. Filial não existe!', 14, 1);

		UPDATE tblFilial SET IDStatus = @IDSTATUS WHERE IDPessoaFilial = @IDPessoaFilial

		SELECT @IDPessoaFilial AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspFilialConsultaPorNomeCodigo]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspFilialConsultaPorNomeCodigo]
@IDPessoaFilial AS INT = NULL,
@Nome AS VARCHAR(50) = NULL
AS
BEGIN
	
	IF @IDPessoaFilial = -1 SET @IDPessoaFilial = NULL;
	SELECT Pes.ID AS IDFilial,
		   Pes.Nome,
		   Pes.Descricao AS Tipo,
		   Pes.CPFCNPJ,
		   Pes.DataCadastro,
		   Pes.Rua,
		   Pes.Numero,
		   Pes.Bairro,
		   Pes.Cidade,
		   Pes.Telefone,
		   Pes.Email,
		   STATUS.Descricao AS Status
	FROM tblFilial AS filial JOIN uvwPessoaFisicaJuridica AS Pes ON filial.IDPessoaFilial = Pes.ID
	LEFT JOIN tblStatus STATUS ON STATUS.IDStatus = filial.IDStatus
	WHERE (@IDPessoaFilial IS NULL OR filial.IDPessoaFilial = @IDPessoaFilial) AND (@Nome IS NULL OR Pes.Nome LIKE '%'+@Nome+'%') 

END
GO
/****** Object:  StoredProcedure [dbo].[uspFilialInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspFilialInserir]
@IDPessoaFilial AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	IF(EXISTS(SELECT IDPessoaFilial FROM tblFilial WHERE IDPessoaFilial = @IDPessoaFilial))
	RAISERROR('Erro ao cadastrar nova filial. Essa pessoa já é uma Filial!', 14, 1);


	INSERT INTO tblFilial (IDPessoaFilial) VALUES (@IDPessoaFilial);

	SELECT @IDPessoaFilial AS Retorno;
	

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspFormaPagamentoAlterarStatus]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFormaPagamentoAlterarStatus]
@DESCRICAO AS VARCHAR(250),
@IDFILIAL AS INT,
@STATUS AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	IF(NOT EXISTS(SELECT Descricao FROM tblFormaPagamento WHERE IDFilial = @IDFILIAL AND Descricao = @DESCRICAO))
	RAISERROR('Não existe uma forma de pagamento cadastrada com essa descrição.',14,1);

	UPDATE tblFormaPagamento SET IDStatus = @STATUS WHERE IDFilial = @IDFILIAL AND Descricao = @DESCRICAO;

	DECLARE @IDPAGAMENTO INT = (SELECT IDPagamento FROM tblFormaPagamento WHERE IDFilial = @IDFILIAL AND Descricao = @DESCRICAO);

	SELECT @IDPAGAMENTO AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspFormaPagamentoConsultarPorFilial]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFormaPagamentoConsultarPorFilial]
@IDFILIAL AS INT
AS

BEGIN
	IF(@IDFILIAL = -1)
	BEGIN
		SELECT * FROM tblFormaPagamento
	END
	ELSE
	BEGIN
	SELECT * FROM tblFormaPagamento WHERE IDFilial = @IDFILIAL;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspFormaPagamentoConsultarVendaFilial]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspFormaPagamentoConsultarVendaFilial]
@IDFILIAL AS INT
AS
BEGIN
	
	SELECT * FROM tblFormaPagamento WHERE IDFilial = @IDFILIAL AND IDStatus = 1;

END
GO
/****** Object:  StoredProcedure [dbo].[uspFormaPagamentoInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFormaPagamentoInserir]
@DESCRICAO AS VARCHAR(250),
@IDFILIAL AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	IF(EXISTS(SELECT Descricao FROM tblFormaPagamento WHERE IDFilial = @IDFILIAL AND Descricao = @DESCRICAO))
	RAISERROR('Já existe uma forma de pagamento cadastrada com essa descrição.',14,1);

	INSERT INTO tblFormaPagamento (Descricao, IDFilial, IDStatus) VALUES (@DESCRICAO, @IDFILIAL, 1);

	SELECT @@IDENTITY AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspFornecedorAlterar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspFornecedorAlterar]
@IDPessoaFornecedor AS INT,
@IDSTATUS AS INT
AS

BEGIN
BEGIN TRY
BEGIN TRAN
		
	IF(NOT EXISTS(SELECT IDPessoaFornecedor FROM tblPessoaFornecedor WHERE IDPessoaFornecedor = @IDPessoaFornecedor))
		RAISERROR('Erro ao alterar. Fornecedor não existe!', 14, 1);

		UPDATE tblPessoaFornecedor SET IDStatus = @IDSTATUS WHERE IDPessoaFornecedor = @IDPessoaFornecedor

		SELECT @IDPessoaFornecedor AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspFornecedorConsultarPorIdNome]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspFornecedorConsultarPorIdNome]
@IDPessoaFornecedor AS INT = NULL,
@Nome AS VARCHAR(50) = NULL
AS
BEGIN
    IF @IDPessoaFornecedor = -1 SET @IDPessoaFornecedor = NULL;
	SELECT Pes.ID AS IDFornecedor,
		   Pes.Nome,
		   Pes.Descricao AS Tipo,
		   Pes.CPFCNPJ,
		   Pes.DataCadastro,
		   Pes.Rua,
		   Pes.Numero,
		   Pes.Bairro,
		   Pes.Cidade,
		   Pes.Telefone,
		   Pes.Email,
		   STATUS.Descricao AS Status
	FROM tblPessoaFornecedor AS FORN JOIN uvwPessoaFisicaJuridica AS Pes ON FORN.IDPessoaFornecedor = Pes.ID
	LEFT JOIN tblStatus STATUS ON STATUS.IDStatus = FORN.IDStatus
	WHERE (@IDPessoaFornecedor IS NULL OR FORN.IDPessoaFornecedor = @IDPessoaFornecedor) AND (@Nome IS NULL OR Pes.Nome LIKE '%'+@Nome+'%') 

END
GO
/****** Object:  StoredProcedure [dbo].[uspFornecedorInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspFornecedorInserir]
@IDPessoaFornecedor AS INT

AS
BEGIN
BEGIN TRY
BEGIN TRAN
	
	IF(EXISTS(SELECT IDPessoaFornecedor FROM tblPessoaFornecedor WHERE IDPessoaFornecedor = @IDPessoaFornecedor))
		RAISERROR('Erro ao cadastrar fornecedor. Essa pessoa já é um fornecedor!', 14, 1);

	INSERT INTO tblPessoaFornecedor (IDPessoaFornecedor) VALUES (@IDPessoaFornecedor);

	SELECT @IDPessoaFornecedor AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspLoginConsulta]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspLoginConsulta]
@USUARIO AS VARCHAR(50),
@SENHA AS VARCHAR(50)
AS
BEGIN


	IF(NOT EXISTS(SELECT * FROM tblUsuario WHERE Login = @USUARIO AND Senha = @SENHA))
	RAISERROR('Usuário ou senha incorreto.',14,1);

	DECLARE @IDUSUARIOLOGADO INT = (SELECT IDUsuario FROM tblUsuario AS USU WHERE Login = @USUARIO AND Senha = @SENHA);
	
	SELECT * FROM tblUsuario AS USU WHERE Login = @USUARIO AND Senha = @SENHA;

	SELECT @IDUSUARIOLOGADO AS RETORNO;


END
GO
/****** Object:  StoredProcedure [dbo].[uspOperacaoConsultar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspOperacaoConsultar]
AS
BEGIN

	SELECT * FROM tblOperacao;

END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoCompraConsultarPorData]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[uspPedidoCompraConsultarPorData]
@DATAINICIAL AS DATE,
@DATAFINAL AS DATE
AS
BEGIN

	SELECT PEDI.IDPedido,
		   OPE.Descricao AS Operacao,
		   SITU.Descricao AS Situacao,
		   PEDI.DataHora, 
		   PES.Nome AS Emitente, 
		   PESD.Nome AS Destinatario
		   
	FROM tblPedidoCompra AS PEDI JOIN tblOperacao AS OPE ON PEDI.IDOperacao = OPE.IDOperacao
	LEFT JOIN tblSituacao AS SITU ON PEDI.IDSituacao = SITU.IDSituacao
	LEFT JOIN uvwPessoaFisicaJuridica AS PES ON PEDI.IDPessoaEmitente = PES.ID
	LEFT JOIN uvwPessoaFisicaJuridica AS PESD ON PEDI.IDPessoaDestinatario = PESD.ID 
	WHERE CAST(PEDI.DataHora AS DATE) BETWEEN @DATAINICIAL AND @DATAFINAL;
END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoCompraConsultarPorIdOperacaoSituacaoDataEmitenteDestinatario]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[uspPedidoCompraConsultarPorIdOperacaoSituacaoDataEmitenteDestinatario]
@IDPedido AS INT = NULL,
@NomeOperacao AS VARCHAR(50) = NULL,
@NomeSituacao AS VARCHAR(50) = NULL,
@NomePessoaEmitente AS VARCHAR(50) = NULL,
@NomePessoaDestinatario AS VARCHAR(50) = NULL
AS
BEGIN

	SELECT PEDI.IDPedido,
		   OPE.IDOperacao,
		   OPE.Descricao AS Operacao,
		   SITU.IDSituacao,
		   SITU.Descricao AS Situacao,
		   PEDI.DataHora,
		   PES.ID AS IDPessoaEmitente, 
		   PES.Nome AS Emitente,
		   PESD.ID AS IDPessoaDestinatario, 
		   PESD.Nome AS Destinatario,
		   ITEM.Quantidade,
		   PROD.Nome AS Produto,
		   ITEM.ValorUnitario,
		   ITEM.PercentualDesconto,
		   ITEM.ValorDesconto,
		   ITEM.ValorTotal

	FROM tblPedidoCompra AS PEDI JOIN tblOperacao AS OPE ON PEDI.IDOperacao = OPE.IDOperacao
	LEFT JOIN tblSituacao AS SITU ON PEDI.IDSituacao = SITU.IDSituacao
	LEFT JOIN uvwPessoaFisicaJuridica AS PES ON PEDI.IDPessoaEmitente = PES.ID
	LEFT JOIN uvwPessoaFisicaJuridica AS PESD ON PEDI.IDPessoaDestinatario = PESD.ID 
	LEFT JOIN tblPedidoCompraItem AS ITEM ON PEDI.IDPedido = ITEM.IDPedido
	LEFT JOIN tblProduto AS PROD ON ITEM.IDProduto = PROD.IDProduto
	WHERE (PEDI.IDPedido = COALESCE(@IDPedido, PEDI.IDPedido))
	AND (OPE.Descricao LIKE '%'+ COALESCE(@NomeOperacao, OPE.Descricao) +'%')
	AND (SITU.Descricao LIKE '%'+ COALESCE(@NomeSituacao, SITU.Descricao) +'%')
	AND (PES.Nome LIKE '%'+ COALESCE(@NomePessoaEmitente, PES.Nome) +'%')
	AND (PESD.Nome LIKE '%'+ COALESCE(@NomePessoaDestinatario, PESD.Nome) +'%')	

END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoCompraInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPedidoCompraInserir]
@IDOperacao AS INT,
@IDSituacao AS INT,
@IDPessoaEmitente AS INT,
@IDPessoaDestinatario AS INT,
@ValorTotalComDesconto AS DECIMAL(18,2),
@PorcentagemDesconto AS DECIMAL(18,2),
@ValorTotal AS DECIMAL(18,2),
@IDPAGAMENTO AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	
	INSERT INTO tblPedidoCompra(IDOperacao, IDSituacao, IDPessoaEmitente, IDPessoaDestinatario, ValorTotalComDesconto, PorcentagemDesconto, ValorTotal, IDPagamento) 
		VALUES (@IDOperacao, @IDSituacao, @IDPessoaEmitente, @IDPessoaDestinatario, @ValorTotalComDesconto, @PorcentagemDesconto, @ValorTotal, @IDPAGAMENTO);
		
	SELECT @@IDENTITY AS Retorno; 

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoCompraItemInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[uspPedidoCompraItemInserir]
@IDPedido AS INT,
@IDProduto AS INT,
@Quantidade AS INT,
@ValorUnitario AS DECIMAL(18,2),
@PercentualDesconto AS DECIMAL(5,2),
@ValorDesconto AS DECIMAL (18,2),
@ValorTotal AS DECIMAL (18,2),
@ValorTotalComDesconto AS DECIMAL (18,2)
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	
	IF(EXISTS(SELECT IDPedido FROM tblPedidoCompraItem WHERE IDPedido = @IDPedido AND IDProduto = @IDProduto))
	BEGIN
		UPDATE tblPedidoCompraItem SET Quantidade = Quantidade + @Quantidade, ValorTotal = @ValorTotal, ValorTotalComDesconto = @ValorTotalComDesconto WHERE IDPedido = @IDPedido AND IDProduto = @IDProduto;
	END
	ELSE
	BEGIN
		INSERT INTO tblPedidoCompraItem (IDPedido, IDProduto, Quantidade, ValorUnitario, PercentualDesconto, ValorDesconto, ValorTotal, ValorTotalComDesconto) 
			VALUES (@IDPedido, @IDProduto, @Quantidade, @ValorUnitario, @PercentualDesconto, @ValorDesconto, @ValorTotal, @ValorTotalComDesconto);
	END

	SELECT @IDPedido AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH
	
	ROLLBACK TRAN;
	DELETE FROM tblPedidoCompra WHERE IDPedido = @IDPedido;
	SELECT ERROR_MESSAGE() AS Retorno;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoConsultarPorData]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPedidoConsultarPorData]
@DATAINICIAL AS DATE,
@DATAFINAL AS DATE
AS
BEGIN

	SELECT PEDI.IDPedido,
		   OPE.Descricao AS Operacao,
		   SITU.Descricao AS Situacao,
		   PEDI.DataHora, 
		   PES.Nome AS Emitente, 
		   PESD.Nome AS Destinatario
		   
	FROM tblPedido AS PEDI JOIN tblOperacao AS OPE ON PEDI.IDOperacao = OPE.IDOperacao
	LEFT JOIN tblSituacao AS SITU ON PEDI.IDSituacao = SITU.IDSituacao
	LEFT JOIN uvwPessoaFisicaJuridica AS PES ON PEDI.IDPessoaEmitente = PES.ID
	LEFT JOIN uvwPessoaFisicaJuridica AS PESD ON PEDI.IDPessoaDestinatario = PESD.ID 
	WHERE CAST(PEDI.DataHora AS DATE) BETWEEN @DATAINICIAL AND @DATAFINAL;
END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoConsultarPorIdOperacaoSituacaoDataEmitenteDestinatario]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPedidoConsultarPorIdOperacaoSituacaoDataEmitenteDestinatario]
@IDPedido AS INT = NULL,
@NomeOperacao AS VARCHAR(50) = NULL,
@NomeSituacao AS VARCHAR(50) = NULL,
@NomePessoaEmitente AS VARCHAR(50) = NULL,
@NomePessoaDestinatario AS VARCHAR(50) = NULL
AS
BEGIN

	SELECT PEDI.IDPedido,
		   OPE.IDOperacao,
		   OPE.Descricao AS Operacao,
		   SITU.IDSituacao,
		   SITU.Descricao AS Situacao,
		   PEDI.DataHora,
		   PES.ID AS IDPessoaEmitente, 
		   PES.Nome AS Emitente,
		   PESD.ID AS IDPessoaDestinatario, 
		   PESD.Nome AS Destinatario,
		   ITEM.Quantidade,
		   PROD.Nome AS Produto,
		   ITEM.ValorUnitario,
		   ITEM.PercentualDesconto,
		   ITEM.ValorDesconto,
		   ITEM.ValorTotal

	FROM tblPedido AS PEDI JOIN tblOperacao AS OPE ON PEDI.IDOperacao = OPE.IDOperacao
	LEFT JOIN tblSituacao AS SITU ON PEDI.IDSituacao = SITU.IDSituacao
	LEFT JOIN uvwPessoaFisicaJuridica AS PES ON PEDI.IDPessoaEmitente = PES.ID
	LEFT JOIN uvwPessoaFisicaJuridica AS PESD ON PEDI.IDPessoaDestinatario = PESD.ID 
	LEFT JOIN tblPedidoItem AS ITEM ON PEDI.IDPedido = ITEM.IDPedido
	LEFT JOIN tblProduto AS PROD ON ITEM.IDProduto = PROD.IDProduto
	WHERE (PEDI.IDPedido = COALESCE(@IDPedido, PEDI.IDPedido))
	AND (OPE.Descricao LIKE '%'+ COALESCE(@NomeOperacao, OPE.Descricao) +'%')
	AND (SITU.Descricao LIKE '%'+ COALESCE(@NomeSituacao, SITU.Descricao) +'%')
	AND (PES.Nome LIKE '%'+ COALESCE(@NomePessoaEmitente, PES.Nome) +'%')
	AND (PESD.Nome LIKE '%'+ COALESCE(@NomePessoaDestinatario, PESD.Nome) +'%')	

END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPedidoInserir]
@IDOperacao AS INT,
@IDSituacao AS INT,
@IDPessoaEmitente AS INT,
@IDPessoaDestinatario AS INT,
@ValorTotalComDesconto AS DECIMAL(18,2),
@PorcentagemDesconto AS DECIMAL(18,2),
@IDCAIXA AS INT,
@ValorTotal AS DECIMAL(18,2),
@IDPAGAMENTO AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	
	INSERT INTO tblPedido (IDOperacao, IDSituacao, IDPessoaEmitente, IDPessoaDestinatario, ValorTotalComDesconto, PorcentagemDesconto, ValorTotal, IDCaixa, IDPagamento) 
		VALUES (@IDOperacao, @IDSituacao, @IDPessoaEmitente, @IDPessoaDestinatario, @ValorTotalComDesconto, @PorcentagemDesconto, @ValorTotal, @IDCAIXA, @IDPAGAMENTO);


	IF(NOT EXISTS(SELECT IDCaixa FROM tblCaixa WHERE IDCaixa = @IDCAIXA AND Status = 'A'))
	RAISERROR('Não existe um caixa aberto para essa venda. É necessário abrir um caixa para realizar a venda.',14,1)

	UPDATE tblCaixa SET valorTotal = valorTotal + @ValorTotalComDesconto
			WHERE IDCaixa = @IDCAIXA;
		
	SELECT @@IDENTITY AS Retorno; 

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoItemInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPedidoItemInserir]
@IDPedido AS INT,
@IDProduto AS INT,
@Quantidade AS INT,
@ValorUnitario AS DECIMAL(18,2),
@PercentualDesconto AS DECIMAL(5,2),
@ValorDesconto AS DECIMAL (18,2),
@ValorTotal AS DECIMAL (18,2),
@ValorTotalComDesconto AS DECIMAL (18,2)
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	
	IF(EXISTS(SELECT IDPedido FROM tblPedidoItem WHERE IDPedido = @IDPedido AND IDProduto = @IDProduto))
	BEGIN
		UPDATE tblPedidoItem SET Quantidade = Quantidade + @Quantidade, ValorTotal = @ValorTotal, ValorTotalComDesconto = @ValorTotalComDesconto WHERE IDPedido = @IDPedido AND IDProduto = @IDProduto;
	END
	ELSE
	BEGIN
		INSERT INTO tblPedidoItem (IDPedido, IDProduto, Quantidade, ValorUnitario, PercentualDesconto, ValorDesconto, ValorTotal, ValorTotalComDesconto) 
			VALUES (@IDPedido, @IDProduto, @Quantidade, @ValorUnitario, @PercentualDesconto, @ValorDesconto, @ValorTotal, @ValorTotalComDesconto);
	END

	SELECT @IDPedido AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH
	
	ROLLBACK TRAN;
	DELETE FROM tblPedido WHERE IDPedido = @IDPedido;
	SELECT ERROR_MESSAGE() AS Retorno;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaFisicaAlterar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaFisicaAlterar]
@IDPessoa AS INT,
@Nome AS VARCHAR(50),
@Cpf AS VARCHAR(11),
@Rg AS VARCHAR(20),
@Rua AS VARCHAR(50),
@Numero AS INT,
@Bairro AS VARCHAR(50),
@Cidade AS VARCHAR(50),
@Telefone AS VARCHAR(50),
@Email AS VARCHAR(50),
@DataNascimento AS DATE,
@CEP AS VARCHAR(9)
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	UPDATE tblPessoaFisica
	SET
		Nome = @Nome,
		Cpf = @Cpf,
		Rg = @Rg,
		Rua = @Rua,
		Numero = @Numero,
		Bairro = @Bairro,
		Cidade = @Cidade,
		Telefone = @Telefone,
		Email = @Email,
		DataNascimento = @DataNascimento,
		Cep = @CEP
		WHERE IDPessoaFisica = @IDPessoa;
		
	SELECT @IDPessoa AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaFisicaConsultarPorCpfNome]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaFisicaConsultarPorCpfNome]
@NOMECPF AS VARCHAR(50)
AS
BEGIN

SELECT * FROM tblPessoaFisica WHERE (Nome LIKE '%'+COALESCE(@NOMECPF, Nome)+'%') OR (Cpf LIKE '%'+COALESCE(@NOMECPF, Cpf)+'%')

END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaFisicaInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaFisicaInserir]
@Nome AS VARCHAR(50),
@Cpf AS VARCHAR(11),
@Rg AS VARCHAR(20),
@Rua AS VARCHAR(50),
@Numero AS INT,
@Bairro AS VARCHAR(50),
@Cidade AS VARCHAR(50),
@Telefone AS VARCHAR(50),
@Email AS VARCHAR(50),
@DataNascimento AS DATE,
@CEP AS VARCHAR(9),
@TIPOCLIENTE AS VARCHAR(50) = NULL,
@TIPOFORNECEDOR AS VARCHAR(50) =NULL,
@TIPOFILIAL AS VARCHAR(50) = NULL
AS
BEGIN
--CONTROLE DE EXCEÇÃO
	BEGIN TRY

	--CONTROLE DE TRANSAÇÃO
	BEGIN TRAN

	--FAZ UMA VERIFICAÇÃO PARA SABER SE O CPF JÁ EXISTE
	IF(EXISTS(SELECT IDPessoaFisica FROM tblPessoaFisica WHERE Cpf = @Cpf))
	BEGIN
	--SE EXISTIR GERA UMA EXCEÇÃO E VAI PARA O CATCH
	RAISERROR('CPF já existe!', 14, 1);
	END;

	--CRIAR VARIAVEL PARA RECEBER O ID DA PESSOA FISICA
	DECLARE @IDPessoa AS INT;

	-- INSERIR DADOS NA TABELA PESSOA, QUE É A PRIMARIA DE PESSOA FISICA
	INSERT INTO tblPessoa (IDPessoaTipo, IDStatus) VALUES (2, 1);

	SET @IDPessoa = @@IDENTITY;

	--INSERIR DADOS NA TABELA PESSOA FISICA
	INSERT INTO tblPessoaFisica (IDPessoaFisica, Nome, Cpf, Rg, Rua, Numero, Bairro, Cidade, Telefone, Email, DataNascimento, Cep) VALUES (@IDPessoa, @Nome, @Cpf, @Rg, @Rua, @Numero, @Bairro, @Cidade, @Telefone, @Email, @DataNascimento, @CEP);

	--VERIFICA O TIPO DE PESSOA E CADASTRA NO TIPO
	IF(@TIPOCLIENTE = 'Cliente')
	BEGIN
		INSERT INTO tblPessoaCliente(IDPessoaCliente) VALUES (@IDPessoa);
	END;

	IF(@TIPOFORNECEDOR = 'Fornecedor')
	BEGIN
		INSERT INTO tblPessoaFornecedor (IDPessoaFornecedor) VALUES (@IDPessoa);
	END;

	IF(@TIPOFILIAL = 'Filial')
	BEGIN
		INSERT INTO tblFilial (IDPessoaFilial) VALUES (@IDPessoa);
	END;

	---SE TODOS OS TIPOS FOREM NULOS GERA UM ERRO E NAO CADASTRA
	IF((@TIPOCLIENTE = NULL) AND (@TIPOFILIAL = NULL) AND (@TIPOFORNECEDOR = NULL))
	BEGIN
		RAISERROR('É necessário selecionar uma classificação para a pessoa.',14,1);
	END;

	SELECT @IDPessoa AS Retorno;
	COMMIT TRAN

	END TRY
	BEGIN CATCH
	--CASO DE ALGUM ERRO, DESFAZ A TRANSAÇÃO.
	ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno;

	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaJuridicaAlterar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaJuridicaAlterar]
@IDPessoa AS INT,
@NomeFantasia AS VARCHAR(50),
@RazaoSocial AS VARCHAR(50),
@Cnpj AS VARCHAR(14),
@Rua AS VARCHAR(50),
@Numero AS INT,
@Bairro AS VARCHAR(50),
@Cidade AS VARCHAR(50),
@Telefone AS VARCHAR(50),
@Email AS VARCHAR(50),
@Logo AS VARCHAR(300),
@InscricaoEstadual AS VARCHAR(20),
@CEP AS VARCHAR(9)
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	UPDATE tblPessoaJuridica SET
								NomeFantasia = @NomeFantasia,
								RazaoSocial = @RazaoSocial,
								Cnpj = @Cnpj,
								Rua = @Rua,
								Numero = @Numero,
								Bairro = @Bairro,
								Cidade = @Cidade,
								Telefone = @Telefone,
								Email = @Email,
								InscricaoEstadual = @InscricaoEstadual,
								Logo = @Logo,
								Cep = @CEP
								WHERE IDPessoaJuridica = @IDPessoa;

	SELECT @IDPessoa AS RETORNO

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaJuridicaConsultarPorCnpjNomeFantasia]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaJuridicaConsultarPorCnpjNomeFantasia]
@NOMECNPJ AS VARCHAR(50) = NULL
AS
BEGIN

	SELECT * FROM tblPessoaJuridica WHERE (NomeFantasia LIKE+'%'+COALESCE(@NOMECNPJ, NomeFantasia)+'%') OR (Cnpj LIKE+'%'+COALESCE(@NOMECNPJ, Cnpj)+'%');

END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaJuridicaConsultarPorIDPessoa]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaJuridicaConsultarPorIDPessoa]
@IDPESSOA AS INT
AS
BEGIN

	SELECT * FROM tblPessoaJuridica WHERE IDPessoaJuridica = @IDPessoa;

END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaJuridicaInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaJuridicaInserir]
@NomeFantasia AS VARCHAR(50),
@RazaoSocial AS VARCHAR(50),
@Cnpj AS VARCHAR(14),
@Rua AS VARCHAR(50),
@Numero AS INT,
@Bairro AS VARCHAR(50),
@Cidade AS VARCHAR(50),
@Telefone AS VARCHAR(50),
@Email AS VARCHAR(50),
@Logo AS VARCHAR(300),
@InscricaoEstadual AS VARCHAR(20),
@CEP AS VARCHAR(9),
@TIPOCLIENTE AS VARCHAR(50) = NULL,
@TIPOFORNECEDOR AS VARCHAR(50) =NULL,
@TIPOFILIAL AS VARCHAR(50) = NULL
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	DECLARE @IDPessoa AS INT;

	INSERT INTO tblPessoa (IDPessoaTipo, IDStatus) VALUES (1, 1);

	SET @IDPessoa = @@IDENTITY;

	INSERT INTO tblPessoaJuridica (IDPessoaJuridica, NomeFantasia, RazaoSocial, Cnpj, Rua, Numero, Bairro, Cidade, Telefone, Email, InscricaoEstadual, Logo,  Cep)
		VALUES (@IDPessoa, @NomeFantasia, @RazaoSocial, @Cnpj, @Rua, @Numero, @Bairro, @Cidade, @Telefone, @Email, @InscricaoEstadual, @Logo, @CEP);

		--VERIFICA O TIPO DE PESSOA E CADASTRA NO TIPO
	IF(@TIPOCLIENTE = 'Cliente')
	BEGIN
		INSERT INTO tblPessoaCliente(IDPessoaCliente) VALUES (@IDPessoa);
	END;

	IF(@TIPOFORNECEDOR = 'Fornecedor')
	BEGIN
		INSERT INTO tblPessoaFornecedor (IDPessoaFornecedor) VALUES (@IDPessoa);
	END;

	IF(@TIPOFILIAL = 'Filial')
	BEGIN
		INSERT INTO tblFilial (IDPessoaFilial) VALUES (@IDPessoa);
	END;

	---SE TODOS OS TIPOS FOREM NULOS GERA UM ERRO E NAO CADASTRA
	IF((@TIPOCLIENTE = NULL) AND (@TIPOFILIAL = NULL) AND (@TIPOFORNECEDOR = NULL))
	BEGIN
		RAISERROR('É necessário selecionar uma classificação para a pessoa.',14,1);
	END;

	SELECT @IDPessoa AS Retorno;
	
COMMIT TRAN

END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaTipoConsultar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaTipoConsultar]
AS
BEGIN

	SELECT * FROM tblPessoaTipo;

END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoAlterar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoAlterar]
@IDProduto AS INT,
@IDCategoria AS INT,
@IDStatus AS INT,
@PrecoCusto AS DECIMAL(18,2)=0,
@PrecoVenda AS DECIMAL(18,2)=0,
@Foto AS VARCHAR(300) = NULL,
@IDFilial AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	--VERIFICA SE ALTEROU O PREÇO E COLOCA NO HISTORICO
	DECLARE @PRECOCUSTOANTERIOR DECIMAL(18,2);
	SET @PRECOCUSTOANTERIOR = (SELECT PrecoCusto FROM tblProduto WHERE IDProduto = @IDProduto AND IDPessoaFilial = @IDFilial);
	
	DECLARE @PRECOVENDAANTERIOR DECIMAL(18,2);
	SET @PRECOVENDAANTERIOR = (SELECT PrecoVenda FROM tblProduto WHERE IDProduto = @IDProduto AND IDPessoaFilial = @IDFilial);
 
	IF(NOT EXISTS(SELECT IDProduto FROM tblProduto WHERE IDProduto = @IDProduto AND PrecoCusto = @PrecoCusto AND IDPessoaFilial = @IDFilial))
	INSERT INTO tblProdutoPrecoCustoHistorico (IDProduto, PrecoCustoAnterior, PrecoCustoNovo, IDPessoaFilial) VALUES (@IDProduto, @PRECOCUSTOANTERIOR, @PrecoCusto, @IDFilial); 

	IF(NOT EXISTS(SELECT IDProduto FROM tblProduto WHERE IDProduto = @IDProduto AND PrecoVenda = @PrecoVenda AND IDPessoaFilial = @IDFilial))
	INSERT INTO tblProdutoPrecoVendaHistorico (IDProduto, PrecoVendaAnterior, PrecoVendaNovo, IDPessoaFilial) VALUES (@IDProduto, @PRECOVENDAANTERIOR, @PrecoVenda, @IDFilial); 


	UPDATE tblProduto SET	
					  IDCategoria = @IDCategoria,
					  IDStatus = @IDStatus,
					  Foto = @Foto,
					  PrecoCusto = @PrecoCusto,
					  PrecoVenda = @PrecoVenda,
					  IDPessoaFilial = @IDFilial
					  WHERE IDProduto = @IDProduto;

	
		
	SELECT @IDProduto AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoAtualizaCusto]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspProdutoAtualizaCusto]
@IDPRODUTO AS INT,
@VALORCUSTO AS DECIMAL(18,2)
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	
	IF(NOT EXISTS(SELECT IDProduto FROM tblProduto WHERE IDProduto = @IDPRODUTO))
	RAISERROR('Produto não existe!', 14,1);

	UPDATE tblProduto SET PrecoCusto = @VALORCUSTO WHERE IDProduto = @IDPRODUTO;

	SELECT @IDPRODUTO AS RETORNO;


COMMIT TRAN
END TRY
BEGIN CATCH
	
	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoCategoriaAlterar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoCategoriaAlterar]
@CODIGO AS INT,
@DESCRICAO AS VARCHAR(50)

AS

BEGIN
BEGIN TRY
BEGIN TRAN
	
	UPDATE tblProdutoCategoria SET Descricao = @DESCRICAO WHERE IDCategoria = @CODIGO;

	SELECT @CODIGO AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoCategoriaConsultar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoCategoriaConsultar]
@NOME AS VARCHAR(50) = NULL
AS
BEGIN

	SELECT * FROM tblProdutoCategoria WHERE Descricao LIKE '%'+COALESCE(@NOME, Descricao)+'%';

END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoCategoriaExcluir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoCategoriaExcluir]
@CODIGO AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	DELETE FROM tblProdutoCategoria WHERE IDCategoria = @CODIGO;

	SELECT @CODIGO AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoCategoriaInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoCategoriaInserir]
@DESCRICAO AS VARCHAR(50)
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	IF(EXISTS(SELECT Descricao FROM tblProdutoCategoria where Descricao = @DESCRICAO))
	RAISERROR('Produto já existe.',14,1);

	INSERT INTO tblProdutoCategoria (Descricao) VALUES (@DESCRICAO);

	SELECT @@IDENTITY AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoConsultarPorIdNomeFilial]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoConsultarPorIdNomeFilial]
@IDProduto AS INT = NULL,
@NomeCategoria AS VARCHAR(50) = NULL,
@IDFilial AS INT = NULL

AS
BEGIN
	IF @IDProduto = -1 SET @IDProduto = NULL;
	SELECT PROD.IDProduto,
		   PROD.Nome,
		   PROD.PrecoCusto,
		   PROD.PrecoVenda,
		   ESTO.Quantidade,
		   CAT.IDCategoria,
		   CAT.Descricao AS Categoria,
		   STA.IDStatus,
		   STA.Descricao AS Status,
		   PROD.Foto,
		   PROD.IDPessoaFilial AS Filial		   
	FROM tblProduto AS PROD JOIN tblProdutoCategoria CAT ON PROD.IDCategoria = CAT.IDCategoria
	LEFT JOIN tblStatus STA ON PROD.IDStatus = STA.IDStatus
	LEFT JOIN tblEstoque ESTO ON ESTO.IDProduto = PROD.IDProduto
	WHERE (PROD.IDPessoaFilial = @IDFilial) AND(PROD.IDStatus = 1) AND(PROD.IDProduto = COALESCE(@IDProduto, PROD.IDProduto))
	AND ((PROD.Nome LIKE '%'+COALESCE(@NomeCategoria, PROD.Nome)+'%') OR (CAT.Descricao LIKE '%'+COALESCE(@NomeCategoria, CAT.Descricao)+'%'));
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoExcluir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoExcluir]
@CODIGO AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	DELETE FROM tblProduto WHERE IDProduto = @CODIGO;

	SELECT @CODIGO AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoInserir]
@Nome AS VARCHAR(50),
@IDCategoria AS INT,
@IDStatus AS INT,
@PrecoCusto AS DECIMAL(18,2),
@PrecoVenda AS DECIMAL(18,2),
@Foto AS VARCHAR(300) = NULL,
@IDFilial AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	
	IF(EXISTS(SELECT IDProduto FROM tblProduto WHERE Nome = @Nome AND IDPessoaFilial = @IDFilial))
		RAISERROR('Erro ao cadastrar produto. Já existe um produto cadastrado com esse nome!',14,1);

	INSERT INTO tblProduto (Nome, IDCategoria, IDStatus, Foto, PrecoCusto, PrecoVenda, IDPessoaFilial) VALUES (@Nome, @IDCategoria, @IDStatus, @Foto, @PrecoCusto, @PrecoVenda, @IDFilial);
	
	DECLARE @IDPRODUTO INT = @@IDENTITY;
	
	INSERT INTO tblEstoque (IDProduto, IDPessoaFilial) VALUES (@IDPRODUTO, @IDFilial);
	

	SELECT @IDPRODUTO AS Retorno;

COMMIT TRAN
END TRY
BEGIN CATCH
	
	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoPrecoConsultarPorIdNome]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoPrecoConsultarPorIdNome]
@IDProduto AS INT = NULL,
@Nome AS VARCHAR(50) = NULL
AS
BEGIN

	SELECT PROD.IDProduto,
		   PROD.Nome,
		   PRECO.Preco AS Valor,
		   TIPO.IDTipo,
		   TIPO.Descricao AS TipoPreco	
	FROM tblProdutoPreco AS PRECO 
	JOIN tblProduto AS PROD ON PRECO.IDProduto = PROD.IDProduto
	LEFT JOIN tblPrecoTipo AS TIPO ON PRECO.IDTipo = TIPO.IDTipo  
	WHERE (PRECO.IDProduto = COALESCE(@IDProduto, PRECO.IDProduto))
	AND (PROD.Nome LIKE +'%'+COALESCE(@Nome, PROD.Nome)+'%');

END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoPrecoInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspProdutoPrecoInserir]
@IDPRODUTO AS INT,
@PRECO AS DECIMAL(18,2),
@IDTIPO AS INT

AS
BEGIN
BEGIN TRY
BEGIN TRAN
	IF(EXISTS(SELECT IDProduto FROM tblProdutoPreco WHERE IDProduto = @IDPRODUTO AND IDTipo = @IDTIPO))
	BEGIN
		UPDATE tblProdutoPreco SET Preco = @PRECO WHERE IDProduto = @IDPRODUTO AND IDTipo = @IDTIPO;
		SELECT @IDPRODUTO AS Retorno;
	END
	ELSE
	BEGIN
		INSERT INTO tblProdutoPreco (IDProduto, Preco, IDTipo) VALUES (@IDPRODUTO, @PRECO, @IDTIPO);
		SELECT @IDPRODUTO AS Retorno;
	END 
		
COMMIT TRAN
END TRY
BEGIN CATCH
	
	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS Retorno;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspRelatorioComprasData]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspRelatorioComprasData]
@DATAINICIAL AS DATETIME,
@DATAFINAL AS DATETIME

AS
BEGIN

	SELECT Pedido.IDPedido, Pedido.DataHora, Emitente.Nome AS Emitente, Destinatario.Nome AS Destinatario, Pedido.ValorTotal,Pedido.ValorTotalComDesconto, Pedido.PorcentagemDesconto, Pagamento.Descricao AS Pagamento, Produto.Nome AS Produto, PedidoItem.Quantidade, PedidoItem.ValorUnitario, PedidoItem.PercentualDesconto, PedidoItem.ValorDesconto, PedidoItem.ValorTotal AS ValorTotalItem, PedidoItem.ValorTotalComDesconto AS ValorTotalComDescontoItem
	FROM tblPedidoCompra Pedido
	JOIN tblPedidoCompraItem AS PedidoItem ON PedidoItem.IDPedido = PEDIDO.IDPedido
	JOIN tblProduto AS Produto ON Produto.IDProduto = PedidoItem.IDProduto
	JOIN uvwPessoaFisicaJuridica AS Emitente ON Emitente.ID = Pedido.IDPessoaEmitente
	JOIN uvwPessoaFisicaJuridica AS Destinatario ON Destinatario.ID = Pedido.IDPessoaDestinatario
	JOIN tblFormaPagamento AS Pagamento ON Pagamento.IDPagamento = Pedido.IDPagamento
	WHERE CAST(Pedido.DataHora AS DATE) BETWEEN @DATAINICIAL AND @DATAFINAL  ORDER BY Pedido.IDPedido ASC

END
GO
/****** Object:  StoredProcedure [dbo].[uspRelatorioItensVendas]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspRelatorioItensVendas]
@IDPEDIDO AS INT
AS
BEGIN

	SELECT Produto.Nome AS Produto, PedidoItem.Quantidade, PedidoItem.ValorUnitario, PedidoItem.PercentualDesconto, PedidoItem.ValorDesconto, PedidoItem.ValorTotal, PedidoItem.ValorTotalComDesconto
	FROM tblPedidoItem AS PedidoItem
	JOIN tblProduto AS Produto ON Produto.IDProduto = PedidoItem.IDProduto
	WHERE PedidoItem.IDPedido = @IDPEDIDO

END



GO
/****** Object:  StoredProcedure [dbo].[uspRelatorioPessoasNome]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspRelatorioPessoasNome]
@NOME AS VARCHAR(50)
AS
BEGIN

SELECT * FROM uvwPessoaFisicaJuridica WHERE Nome LIKE '%'+@NOME+'%';

END
GO
/****** Object:  StoredProcedure [dbo].[uspRelatorioVendasData]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspRelatorioVendasData]
@DATAINICIAL AS DATETIME,
@DATAFINAL AS DATETIME

AS
BEGIN

	SELECT Pedido.IDPedido, Pedido.DataHora, Emitente.Nome AS Emitente, Destinatario.Nome AS Destinatario, Pedido.ValorTotal,Pedido.ValorTotalComDesconto, Pedido.PorcentagemDesconto, Pagamento.Descricao AS Pagamento, Produto.Nome AS Produto, PedidoItem.Quantidade, PedidoItem.ValorUnitario, PedidoItem.PercentualDesconto, PedidoItem.ValorDesconto, PedidoItem.ValorTotal AS ValorTotalItem, PedidoItem.ValorTotalComDesconto AS ValorTotalComDescontoItem
	FROM tblPedido Pedido
	JOIN tblPedidoItem AS PedidoItem ON PedidoItem.IDPedido = PEDIDO.IDPedido
	JOIN tblProduto AS Produto ON Produto.IDProduto = PedidoItem.IDProduto
	JOIN uvwPessoaFisicaJuridica AS Emitente ON Emitente.ID = Pedido.IDPessoaEmitente
	JOIN uvwPessoaFisicaJuridica AS Destinatario ON Destinatario.ID = Pedido.IDPessoaDestinatario
	JOIN tblFormaPagamento AS Pagamento ON Pagamento.IDPagamento = Pedido.IDPagamento
	WHERE CAST(Pedido.DataHora AS DATE) BETWEEN @DATAINICIAL AND @DATAFINAL  ORDER BY Pedido.IDPedido ASC

END
GO
/****** Object:  StoredProcedure [dbo].[uspSituacaoConsultar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspSituacaoConsultar]
AS
BEGIN

	SELECT SIT.*, OPE.Descricao FROM tblSituacao SIT JOIN tblOperacao OPE ON SIT.IDOperacao = OPE.IDOperacao;

END
GO
/****** Object:  StoredProcedure [dbo].[uspStatusConsultar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspStatusConsultar]
AS
BEGIN

	SELECT * FROM tblStatus;
END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioAlterar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspUsuarioAlterar]
@IDPessoa AS INT,
@SENHA AS VARCHAR(50),
@ACESSO AS INT,
@IDSTATUS AS INT,
@IDPESSOAFILIAL AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	IF(NOT EXISTS(SELECT IDUsuario FROM tblUsuario WHERE IDPessoa = @IDPessoa AND IDPessoaFilial = @IDPESSOAFILIAL))
	RAISERROR('Usuário não existe para essa filial.',14,1);

	UPDATE tblUsuario SET
	 Senha = @SENHA,
	 Acesso = @ACESSO,
	 IDStatus = @IDSTATUS,
	 IDPessoaFilial = @IDPESSOAFILIAL
	WHERE IDPessoa = @IDPessoa	
	
		
	SELECT @IDPessoa AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH
		
		ROLLBACK TRAN;
		SELECT ERROR_MESSAGE() AS RETORNO;


END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioAlterarImagemFundo]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUsuarioAlterarImagemFundo]
@IDUSUARIO AS INT,
@PAPELDEPAREDE AS VARCHAR(300)
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	IF(NOT EXISTS(SELECT IDUsuario FROM tblUsuario WHERE IDUsuario = @IDUSUARIO))
	RAISERROR('Não foi possível localizar o usuário.',14,1);

	UPDATE tblUsuario SET PapelParede = @PAPELDEPAREDE WHERE IDUsuario = @IDUSUARIO;

	SELECT @IDUSUARIO AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioAlterarStatus]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUsuarioAlterarStatus]
@IDUSUARIO AS INT,
@STATUS AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	IF(NOT EXISTS(SELECT IDUsuario FROM tblUsuario WHERE IDUsuario = @IDUSUARIO))
	RAISERROR('USUÁRIO NÃO EXISTE.',14,1);

	UPDATE tblUsuario SET IDStatus = @STATUS WHERE IDUsuario = @IDUSUARIO;

	SELECT @IDUSUARIO AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH

	ROLLBACK TRAN;
	SELECT ERROR_MESSAGE() AS RETORNO;

END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioBuscarImagemFundo]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUsuarioBuscarImagemFundo]
@IDUSUARIO AS INT
AS
BEGIN
BEGIN TRY


	IF(NOT EXISTS(SELECT IDUsuario FROM tblUsuario WHERE IDUsuario = @IDUSUARIO))
	RAISERROR('Não foi possível localizar o usuário.',14,1);

	DECLARE @PAPELDEPAREDE AS VARCHAR(300) = (SELECT PapelParede FROM tblUsuario WHERE IDUsuario = @IDUSUARIO);

	SELECT @PAPELDEPAREDE AS RETORNO;


END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE() AS RETORNO;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioConsultar]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspUsuarioConsultar]
@IDPessoa AS INT,
@IDFILIAL AS INT

AS
BEGIN
	IF(@IDPessoa = -1)
	BEGIN
	SELECT USUARIO.*, STATUS.Descricao AS StatusDescricao, PES.Nome AS NOME, PESFI.RazaoSocial AS UsuarioFilial  FROM tblUsuario USUARIO
	 JOIN tblStatus STATUS ON USUARIO.IDStatus = STATUS.IDStatus
	 LEFT JOIN uvwPessoaFisicaJuridica PESFI ON PESFI.ID = USUARIO.IDPessoaFilial
	 LEFT JOIN uvwPessoaFisicaJuridica PES ON PES.ID = USUARIO.IDPessoa 
	 WHERE USUARIO.IDPessoaFilial = @IDFILIAL
	END
	ELSE
	BEGIN
	SELECT USUARIO.*, STATUS.Descricao AS StatusDescricao, PES.Nome AS NOME, PESFI.RazaoSocial AS UsuarioFilial  FROM tblUsuario USUARIO
	 JOIN tblStatus STATUS ON USUARIO.IDStatus = STATUS.IDStatus
	 LEFT JOIN uvwPessoaFisicaJuridica PESFI ON PESFI.ID = USUARIO.IDPessoaFilial
	 LEFT JOIN uvwPessoaFisicaJuridica PES ON PES.ID = USUARIO.IDPessoa 
	 WHERE USUARIO.IDPessoa = @IDPessoa AND USUARIO.IDPessoaFilial = @IDFILIAL
	END
	

END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioInserir]    Script Date: 13/07/2017 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspUsuarioInserir]
@LOGIN AS VARCHAR(50),
@SENHA AS VARCHAR(50),
@IDPESSOA AS INT,
@IDPESSOAFILIAL AS INT,
@ACESSO AS INT,
@IDSTATUS AS INT
AS
BEGIN
BEGIN TRY
BEGIN TRAN

	IF(EXISTS(SELECT IDPessoa FROM tblUsuario WHERE IDPessoa = @IDPESSOA AND IDPessoaFilial = @IDPESSOAFILIAL))
	BEGIN
	DECLARE @USUSARIO AS VARCHAR(50) = (SELECT Login FROM tblUsuario WHERE IDPessoa = @IDPESSOA);
	RAISERROR('Já existe um usuário cadastrado para essa pessoa: @LOGIN.',14,1);
	END

	INSERT INTO tblUsuario (Login, Senha, Acesso, IDStatus, IDPessoaFilial, IDPessoa) VALUES (@LOGIN, @SENHA, @ACESSO, @IDSTATUS, @IDPESSOAFILIAL, @IDPESSOA);
		
	SELECT @@IDENTITY AS RETORNO;

COMMIT TRAN
END TRY
BEGIN CATCH
		
		ROLLBACK TRAN;
		SELECT ERROR_MESSAGE() AS RETORNO;


END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [db_sgv] SET  READ_WRITE 
GO
