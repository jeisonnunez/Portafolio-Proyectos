CREATE DATABASE SCV_SAPB111

GO

USE SCV_SAPB111

GO

CREATE TABLE [dbo].[@IDA_COMP_ISLR](
	[Code] [nvarchar](50) NOT NULL primary key,
	[Name] [nvarchar](100) NOT NULL,
	[U_IDA_NroComp] [nvarchar](100) NULL,
	[U_IDA_TipoDoc] [nvarchar](30) NULL,
	[U_IDA_NroControl] [nvarchar](100) NULL,
	[U_IDA_Agente] [nvarchar](100) NULL,
	[U_IDA_TaxIdNo] [nvarchar](100) NULL,
	[U_IDA_CompanyAddress] [nvarchar](254) NULL,
	[U_IDA_CardName] [nvarchar](100) NULL,
	[U_IDA_LicTradNum] [nvarchar](100) NULL,
	[U_IDA_Address] [nvarchar](254) NULL,
	[U_IDA_Phone1] [nvarchar](100) NULL,
	[U_IDA_CardCode] [nvarchar](100) NULL,
	[U_IDA_Ano] [nvarchar](30) NULL,
	[U_IDA_Mes] [nvarchar](30) NULL,
	[U_IDA_CodeRetencion] [nvarchar](30) NULL,
	[U_IDA_ConceptoRet] [nvarchar](250) NULL,
	[U_IDA_NroFactura] [nvarchar](100) NULL,
	[U_IDA_NroND] [nvarchar](100) NULL,
	[U_IDA_NroNC] [nvarchar](100) NULL,
	[U_IDA_FechaContFact] [datetime] NULL,
	[U_IDA_FechaDoc] [datetime] NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_BaseRetencion] [numeric](19, 6) NULL,
	[U_IDA_PrctRetencion] [numeric](19, 6) NULL,
	[U_IDA_Sustraendo] [numeric](19, 6) NULL,
	[U_IDA_ValorRetencion] [numeric](19, 6) NULL,
	[U_IDA_DocTotal] [numeric](19, 6) NULL,
	[U_IDA_TipoTrans] [nvarchar](100) NULL,
	[U_IDA_Periodo] [nvarchar](100) NULL,
	[U_IDA_OfflCode] [nvarchar](30) NULL,
	[U_IDA_Exento] [numeric](19, 6) NULL,
	[U_IDA_DocEntry] [int] NULL,
	[U_IDA_ObjType] [nvarchar](30) NULL,
	[U_IDA_DocSubType] [nvarchar](30) NULL,
	[U_IDA_Status] [nvarchar](30) NULL,
	
 
)
GO
/****** Object:  Table [dbo].[@IDA_COMPROBANTES]    Script Date: 27/2/2020 10:16:02 a. m. ******/

CREATE TABLE [dbo].[@IDA_COMPROBANTES](
	[Code] [nvarchar](50) NOT NULL primary key,
	[Name] [nvarchar](100) NOT NULL,
	[U_IDA_NroControl] [nvarchar](100) NULL,
	[U_IDA_FechaFact] [datetime] NULL,
	[U_IDA_ObjType] [nvarchar](10) NULL,
	[U_IDA_DocEntry] [int] NULL,
	[U_IDA_Alicuota] [nvarchar](10) NULL,
	[U_IDA_IVA] [numeric](19, 6) NULL,
	[U_IDA_BaseImp] [numeric](19, 6) NULL,
	[U_IDA_Retencion] [numeric](19, 6) NULL,
	[U_IDA_Total] [numeric](19, 6) NULL,
	[U_IDA_Exento] [numeric](19, 6) NULL,
	[U_IDA_Fafe] [nvarchar](100) NULL,
	[U_IDA_Factura] [nvarchar](100) NULL,
	[U_IDA_Credito] [nvarchar](100) NULL,
	[U_IDA_Debito] [nvarchar](100) NULL,
	[U_IDA_TipoTran] [nvarchar](100) NULL,
	[U_IDA_CardCode] [nvarchar](100) NULL,
	[U_IDA_CardName] [nvarchar](100) NULL,
	[U_IDA_Agente] [nvarchar](100) NULL,
	[U_IDA_NroComp] [nvarchar](100) NULL,
	[U_IDA_LicTradNum] [nvarchar](100) NULL,
	[U_IDA_TaxIdNo] [nvarchar](100) NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_Row] [int] NULL,
	[U_IDA_Status] [nvarchar](10) NULL,
	[U_IDA_PrcntRet] [numeric](19, 6) NULL,
	[U_IDA_CompanyAddress] [nvarchar](254) NULL,
	[U_IDA_Address] [nvarchar](254) NULL,
	[U_IDA_DocSubType] [nvarchar](10) NULL,
	[U_IDA_Periodo] [nvarchar](10) NULL,
	[U_IDA_Quincena] [nvarchar](10) NULL,
	
 )
GO
CREATE TABLE [dbo].[LICENSE_CONF](
	[Code] [nvarchar](50) NOT NULL primary key,
	[Name] [nvarchar](100) NULL,
	[DocEntry] [int] NOT NULL,
	[Canceled] [char](1) NULL,
	[Object] [nvarchar](20) NULL,
	[LogInst] [int] NULL,
	[UserSign] [int] NULL,
	[Transfered] [char](1) NULL,
	[CreateDate] [datetime] NULL,
	[CreateTime] [smallint] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateTime] [smallint] NULL,
	[DataSource] [char](1) NULL,
	[U_IDA_FileConf] [ntext] NULL,
	[U_IDA_Servidor] [nvarchar](50) NULL,
	[U_IDA_SystemNumber] [nvarchar](50) NULL,
	[U_IDA_InstNumber] [nvarchar](50) NULL,
	[U_IDA_FechaInicio] [datetime] NULL,
	[U_IDA_Vencimiento] [datetime] NULL,
	[U_IDA_HardwareKey] [nvarchar](50) NULL,
	[U_IDA_Lic] [ntext] NULL,
	
)
GO

CREATE TABLE [dbo].[NRO_COMPROBANTE](
	[Code] [nvarchar](50) NOT NULL primary key,	
	[DocEntry] [int] NULL,
	[Canceled] [char](1) NULL,	
	[UserSign] [int] NULL,	
	[CreateDate] [datetime] NULL,	
	[UpdateDate] [datetime] NULL,	
	[NombreSerie] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](100) NULL,
	[TipoSerie] [nvarchar](10) NULL,
	[Inicio] [nvarchar](15) NULL,
	[Siguiente] [nvarchar](15) NULL,
	[Fin] [nvarchar](15) NULL,
	[Activo] [nvarchar](10) NULL,
	
 )
 GO
 CREATE TABLE [dbo].[ODCM](
	[LinkAct_1] [nvarchar](15) NULL,
	[LinkAct_2] [nvarchar](15) NULL,
	[LinkAct_3] [nvarchar](15) NULL,
	[LinkAct_4] [nvarchar](15) NULL,
	[LinkAct_5] [nvarchar](15) NULL,
	[LinkAct_6] [nvarchar](15) NULL,
	[LinkAct_7] [nvarchar](15) NULL,
	
 )

GO
CREATE TABLE [dbo].[OUSR](
	[USERID] [smallint] NOT NULL IDENTITY (1,1) PRIMARY KEY,
	[PASSWORD] [nvarchar](254) NULL,	
	[USER_CODE] [nvarchar](25) NOT NULL,
	[U_NAME] [nvarchar](155) NULL,	
	[Locked] [char](1) NULL,
	[Deleted] [char](1) NULL
 )

GO
CREATE TABLE [dbo].[OITM](
	[ItemCode] [nvarchar](50) NOT NULL PRIMARY KEY,
	[ItemName] [nvarchar](100) NULL,	
	[VATLiable] [char](1) NULL,
	[PrchseItem] [char](1) NULL,
	[SellItem] [char](1) NULL,
	[InvntItem] [char](1) NULL,
	[OnHand] [numeric](19, 6) NULL,
	[IsCommited] [numeric](19, 6) NULL,
	[OnOrder] [numeric](19, 6) NULL,	
	[Canceled] [char](1) NULL,	
	[UserSign] [smallint] NULL,	
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,	
	[Deleted] [char](1) NULL,
	[DocEntry] [int] NULL,
	[StockValue] [numeric](19, 6) NULL,	
	[StockValueSC] [numeric](19, 6) NULL,	
	[StockValueFC] [numeric](19, 6) NULL,	
	[UserSign2] [smallint] NULL,	
	[BalInvntAc] [nvarchar](15),
	[SaleCostAc] [nvarchar](15),
	[RevenuesAc] [nvarchar](15),
	[ExpensesAc] [nvarchar](15)
	CONSTRAINT fk_UserSign FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 )
GO
CREATE TABLE [dbo].[ITM1](
	[ItemCode] [nvarchar](50) NOT NULL  primary key,	
	[Price] [numeric](19, 6) NULL,
	[Currency] [nvarchar](3) NULL,
	[Ovrwritten] [char](1) NULL,
	[Factor] [numeric](19, 6) NULL,
	[LogInstanc] [int] NULL,
	[ObjType] [nvarchar](20) NULL,
	[AddPrice1] [numeric](19, 6) NULL,
	[Currency1] [nvarchar](3) NULL,
	[AddPrice2] [numeric](19, 6) NULL,
	[Currency2] [nvarchar](3) NULL,
	[Ovrwrite1] [char](1) NULL,
	[Ovrwrite2] [char](1) NULL,
	[BasePLNum] [smallint] NULL,
	[UomEntry] [int] NULL,
	[PriceType] [char](1) NULL,
	CONSTRAINT fk_ItemCode FOREIGN KEY ([ItemCode]) REFERENCES [dbo].[OITM] ([ItemCode])
)

GO
CREATE TABLE [dbo].[OACT](
	[AcctCode] [nvarchar](15) NOT NULL PRIMARY KEY,
	[AcctName] [nvarchar](100) NULL,
	[CurrTotal] [numeric](19, 6) NULL,	
	[Finanse] [char](1) NULL,
	[Postable] [char](1) NULL,	
	[Levels] [smallint] NULL,	
	[GrpLine] [int] NULL,
	[FatherNum] [nvarchar](15) NULL,	
	[ActType] [char](1) NULL,	
	[ActCurr] [nvarchar](3) NULL,	
	[SysTotal] [numeric](19, 6) NULL,
	[FcTotal] [numeric](19, 6) NULL,	
	[Advance] [char](1) NULL,
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,	
	[UserSign] [smallint] NULL,
	[LocManTran] [char](1) NULL,	
	[UserSign2] [smallint] NULL,
	[GroupMask] [smallint] NULL,
	CONSTRAINT fk_UserSignOACT FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 )

GO
CREATE TABLE [dbo].[OJDT](
	
	[TransId] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,	
	[TransType] [nvarchar](20) NULL,	
	[RefDate] [datetime] NULL,
	[Memo] [nvarchar](50) NULL,	
	[LocTotal] [numeric](19, 6) NULL,
	[FcTotal] [numeric](19, 6) NULL,
	[SysTotal] [numeric](19, 6) NULL,	
	[DueDate] [datetime] NULL,
	[TaxDate] [datetime] NULL,	
	[FinncPriod] [int] NULL,	
	[UpdateDate] [datetime] NULL,
	[CreateDate] [datetime] NULL,
	[UserSign] [smallint] NULL,
	[UserSign2] [smallint] NULL,	
	[TransCurr] [nvarchar](3) NULL,	
	[BaseRef] [int] NULL,
	[Ref1] [nvarchar](100) null,
	[Ref2] [nvarchar](100) null,
	CONSTRAINT fk_UserSignOJDT FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 
)

GO
CREATE TABLE [dbo].[JDT1](
	[TransId] [int] NOT NULL ,
	[Line_ID] [int] NOT NULL ,
	[Account] [nvarchar](15) NULL,
	[Debit] [numeric](19, 6) NULL,
	[Credit] [numeric](19, 6) NULL,
	[SYSCred] [numeric](19, 6) NULL,
	[SYSDeb] [numeric](19, 6) NULL,
	[FCDebit] [numeric](19, 6) NULL,
	[FCCredit] [numeric](19, 6) NULL,
	[FCCurrency] [nvarchar](3) NULL,
	[DueDate] [datetime] NULL,	
	[ShortName] [nvarchar](15) NULL,	
	[ContraAct] [nvarchar](15) NULL,
	[LineMemo] [nvarchar](50) NULL,	
	[TransType] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[UserSign] [smallint] NULL,	
	[FinncPriod] [int] NULL,
	[BalDueDeb] [numeric](19, 6) NULL,
	[BalDueCred] [numeric](19, 6) NULL,
	[BalFcDeb] [numeric](19, 6) NULL,
	[BalFcCred] [numeric](19, 6) NULL,
	[BalScDeb] [numeric](19, 6) NULL,
	[BalScCred] [numeric](19, 6) NULL,
	[DataSource] [char](1) null,
	[WTSum] [numeric](19, 6) NULL,
	[WTSumFC] [numeric](19, 6) NULL,
	[WTSumSC] [numeric](19, 6) null,
	constraint pk_JDT1 primary key (TransId, Line_ID),
	CONSTRAINT fk_TransId FOREIGN KEY ([TransId]) REFERENCES [dbo].[OJDT] ([TransId]),
	CONSTRAINT fk_UserSignJDT1 FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID]),
	CONSTRAINT fk_AcctCode FOREIGN KEY ([Account]) REFERENCES [dbo].[OACT] ([AcctCode])
 )
GO
/****** Object:  Table [dbo].[OACP]    Script Date: 27/2/2020 10:16:02 a. m. ******/

CREATE TABLE [dbo].[OACP](
	[AbsEntry] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[PeriodCat] [nvarchar](10) NOT NULL,
	[FinancYear] [datetime] NULL,
	[Year] [smallint] NULL,
	[PeriodName] [nvarchar](20) NULL,
	[SubType] [char](1) NULL,
	[PeriodNum] [int] NULL,
	[F_RefDate] [datetime] NULL,
	[T_RefDate] [datetime] NULL,
	[F_DueDate] [datetime] NULL,
	[T_DueDate] [datetime] NULL,
	[F_TaxDate] [datetime] NULL,
	[T_TaxDate] [datetime] NULL,	
	[UpdateDate] [datetime] NULL,
	[UserSign] [smallint] NULL,
	
	)
/****** Object:  Table [dbo].[OACT]    Script Date: 27/2/2020 10:16:02 a. m. ******/


GO
CREATE TABLE [dbo].[OADM](
	[CompnyName] [nvarchar](100) NOT NULL PRIMARY KEY,
	[CompnyAddr] [nvarchar](254) NULL,
	[Country] [nvarchar](3) NULL,
	[PrintHeadr] [nvarchar](100) NULL,
	[Phone1] [nvarchar](20) NULL,
	[Phone2] [nvarchar](20) NULL,
	[Fax] [nvarchar](20) NULL,
	[ZipCode] [int] NULL,
	[E_Mail] [nvarchar](100) NULL,
	[MainCurncy] [nvarchar](3) NULL,
	[SysCurrncy] [nvarchar](3) NULL,
	[TaxIdNum] [nvarchar](32) NULL,
	[RevOffice] [nvarchar](100) NULL,	
	[UpdateDate] [datetime] NULL,
	[UserSign] [smallint] NULL,
	[Name][nvarchar](max) NULL,
	[Image][image] NULL,
	CONSTRAINT fk_UserSignOADM FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
	
 )
GO
CREATE TABLE [dbo].[OCRD](
	[CardCode] [nvarchar](15) NOT NULL PRIMARY KEY,
	[CardName] [nvarchar](100) NULL,
	[CardType] [char](1) NULL,	
	[Address] [nvarchar](100) NULL,
	[ZipCode] [nvarchar](20) NULL,
	[MailAddres] [nvarchar](100) NULL,
	[MailZipCod] [nvarchar](20) NULL,
	[Phone1] [nvarchar](20) NULL,
	[Phone2] [nvarchar](20) NULL,
	[Fax] [nvarchar](20) NULL,
	[CntctPrsn] [nvarchar](90) NULL,	
	[Balance] [numeric](19, 6) NULL,
	[ChecksBal] [numeric](19, 6) NULL,
	[DNotesBal] [numeric](19, 6) NULL,	
	[VatStatus] [char](1) NULL,
	[LicTradNum] [nvarchar](32) NULL,	
	[DNoteBalFC] [numeric](19, 6) NULL,	
	[DNoteBalSy] [numeric](19, 6) NULL,	
	[Currency] [nvarchar](3) NULL,	
	[BalanceSys] [numeric](19, 6) NULL,
	[BalanceFC] [numeric](19, 6) NULL,	
	[E_Mail] [nvarchar](100) NULL,		
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,	
	[UserSign] [smallint] NULL,
	[DebPayAcct] [nvarchar](15) NULL,
	[VatGroup][nvarchar](8) NULL,
	[Deleted] [char] NULL,
	[U_IDA_TipoPersona] [nvarchar](10) NULL,
	[U_IDA_Contribuyente] [nvarchar](10) NULL,
	[U_IDA_Sucursal] [nvarchar](10) NULL,
	[U_IDA_AplicaITF] [nvarchar](10) NULL,
	CONSTRAINT fk_UserSignOCRD FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 )

GO
CREATE TABLE [dbo].[OCRN](
	[CurrCode] [nvarchar](3) NOT NULL PRIMARY KEY,
	[CurrName] [nvarchar](20) NULL,	
	[DocCurrCod] [nvarchar](3) NULL,	
	[Locked] [char](1) NULL,	
	[UserSign] [smallint] NULL,	
	[UserSign2] [smallint] NULL,
	CONSTRAINT fk_UserSignOCRN FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
	
 )

GO
CREATE TABLE [dbo].[OFPR](
	[AbsEntry] [int] NOT NULL IDENTITY (1,1) PRIMARY KEY,
	[Code] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[F_RefDate] [datetime] NULL,
	[T_RefDate] [datetime] NULL,
	[F_DueDate] [datetime] NULL,
	[T_DueDate] [datetime] NULL,
	[F_TaxDate] [datetime] NULL,
	[T_TaxDate] [datetime] NULL,	
	[UserSign] [smallint] NULL,
	[SubNum] [int] NULL,	
	[Category] [nvarchar](10) NULL,	
	[UpdateDate] [datetime] NULL,	
	[PeriodStat] [char](1) NULL,
	[UserSign2] [smallint] NULL,
	
)

GO

CREATE TABLE [dbo].[MONTHS](

	[Code] [nvarchar](2) NOT NULL PRIMARY KEY,
	[Month] [nvarchar](20) NOT NULL

)

CREATE TABLE [dbo].[Alicuotas](

	[Code] [nvarchar](20) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](20) NOT NULL

)

CREATE TABLE [dbo].[OINM](
	[TransSeq] [int] NOT NULL IDENTITY (1,1),	
	[TransType] [int] NULL,
	[CreatedBy] [int] NULL,
	[BASE_REF] [nvarchar](11) NULL,
	[DocLineNum] [int] NULL,
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[Dscription] [nvarchar](100) NULL,
	[InQty] [numeric](19,6) NULL,
	[OutQty] [numeric](19,6) NULL,
	[Price] [numeric](19,6) NULL,
	[Currency] [nvarchar](3) NULL,
	[Rate] [numeric](19,6) NULL,
	[SysRate] [numeric](19,6) NULL,
	[TaxDate] [datetime] NULL,
	[UserSign] [smallint] NULL,
	[CalcPrice] [numeric](19,6) NULL,
	[OpenQty] [numeric](19,6) NULL,
	[CreateDate] [datetime] NULL,
	[Balance] [numeric](19,6) NULL,
	[TransValue] [numeric](19,6) NULL,	
	[InvntAct] [nvarchar](15) NULL,
	[OpenValue] [numeric](19,6) NULL,
	[CostMethod][char] NULL,
	[Type][char] NULL,
	CONSTRAINT fk_AcctCodeOINM FOREIGN KEY ([InvntAct]) REFERENCES [dbo].[OACT] ([AcctCode]),
	CONSTRAINT fk_CardCodeOINM FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignOINM FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
)


CREATE TABLE [dbo].[OPCH](
	[DocEntry] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DocNum] [int] NULL,
	[Max1099] [numeric](19, 6) NULL,
	[DocType] [char](1) NULL,
	[CANCELED] [char](1) NULL,	
	[DocStatus] [char](1) NULL,
	[InvntSttus] [char](1) NULL,	
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,
	[Address] [nvarchar](254) NULL,
	[Address2] [nvarchar](254) NULL,
	[ObjType] [nvarchar](20) NULL,
	[NumAtCard] [nvarchar](100) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFC] [numeric](19, 6) NULL,
	[DocCur] [nvarchar](3) NULL,	
	[DocTotal] [numeric](19, 6) NULL,
	[DocTotalFC] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,	
	[Ref1] [nvarchar](11) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[TransId] [int] NULL,	
	[DocRate] [numeric](19, 6) NULL,
	[SysRate] [numeric](19, 6) NULL,	
	[VatSumSy] [numeric](19, 6) NULL,	
	[DocTotalSy] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,	
	[UpdateDate] [datetime] NULL,	
	[CreateDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[FinncPriod] [int] NULL,
	[UserSign] [smallint] NULL,	
	[VatPaid] [numeric](19, 6) NULL,
	[VatPaidFC] [numeric](19, 6) NULL,
	[VatPaidSys] [numeric](19, 6) NULL,
	[UserSign2] [smallint] NULL,	
	[LicTradNum] [nvarchar](32) NULL,	
	[WTSum] [numeric](19, 6) NULL,
	[WTSumFC] [numeric](19, 6) NULL,
	[WTSumSC] [numeric](19, 6) NULL,	
	[WTApplied] [numeric](19, 6) NULL,
	[WTAppliedF] [numeric](19, 6) NULL,	
	[WTAppliedS] [numeric](19, 6) NULL,	
	[CtlAccount] [nvarchar](15) NULL,	
	[BaseVtAt] [numeric](19, 6) NULL,
	[BaseVtAtSC] [numeric](19, 6) NULL,
	[BaseVtAtFC] [numeric](19, 6) NULL,
	[NnSbVAt] [numeric](19, 6) NULL,
	[NnSbVAtSC] [numeric](19, 6) NULL,
	[NbSbVAtFC] [numeric](19, 6) NULL,	
	[PaidSum] [numeric](19, 6) NULL,
	[PaidSumFc] [numeric](19, 6) NULL,
	[PaidSumSc] [numeric](19, 6) NULL,	
	[NnSbAmnt] [numeric](19,6) NULL,
	[NnSbAmntSC] [numeric](19,6) NULL,
	[NbSbAmntFC] [numeric](19,6) NULL,
	[BaseAmnt] [numeric](19,6) NULL,
	[BaseAmntSC] [numeric](19,6) NULL,
	[BaseAmntFC] [numeric](19,6) NULL,
	[U_IDA_NumControl] [nvarchar](20) NULL,
	[U_IDA_TipoTrans] [nvarchar](10) NULL,
	[U_IDA_CompIVA] [nvarchar](20) NULL,	
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_FechaContComp] [datetime] NULL,
	[U_IDA_MontoCompIVA] [numeric](19, 6) NULL,	
	[U_IDA_RetenTercero] [nvarchar](10) NULL,
	[U_IDA_TipoRet] [nvarchar](10) NULL,
	[U_IDA_Tercero] [nvarchar](100) NULL,	
	[U_IDA_CompISLR] [nvarchar](20) NULL,
	[U_IDA_DateCompISLR] [datetime] NULL,
	[U_IDA_DateContISLR] [datetime] NULL,
	[U_IDA_CodSerie] [nvarchar](10) NULL,
	[U_IDA_Serie] [nvarchar](10) NULL,	
	[U_IDA_Fafe] [nvarchar](30) NULL,	
	[U_IDA_NumExport] [nvarchar](50) NULL,
	[U_IDA_TipoDoc] [nvarchar](20) NULL,
	[U_IDA_NumFile] [nvarchar](50) NULL,
	[U_IDA_NumImport] [nvarchar](50) NULL,	
	[U_IDA_MontoFafe] [numeric](19, 6) NULL,
	[U_IDA_FechaFafe] [datetime] NULL,
	[U_IDA_IsPlanilla] [nvarchar](10) NULL,
	[U_IDA_PagoElectronic] [nvarchar](10) NULL,
	[U_IDA_Alicuota] [nvarchar](10) NULL,	
	[U_IDA_CompMunicipal] [nvarchar](20) NULL,
	[U_IDA_DateCompMun] [datetime] NULL,
	[U_IDA_CorteZ] [nvarchar](100) NULL,
	[U_IDA_SerialImpre] [nvarchar](100) NULL,
	[U_IDA_DocAnulado] [nvarchar](10) NULL,	
	[DocSubType][nvarchar](2) null,
	[DiscPrcnt] [numeric](19, 6) NULL,
	[DiscSum] [numeric](19, 6) NULL,
	[DiscSumFC] [numeric](19, 6) NULL,
	[DiscSumSy] [numeric](19, 6) NULL,
	[DocTime] [smallint] NULL,
	CONSTRAINT fk_CardCodeOPCH FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignOPCH FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 )

GO
CREATE TABLE [dbo].[OPDN](
	[DocEntry] [int] NOT NULL IDENTITY(1,1)  PRIMARY KEY,
	[Max1099] [numeric](19, 6) NULL,
	[DocNum] [int] NULL,
	[DocType] [char](1) NULL,
	[CANCELED] [char](1) NULL,	
	[DocStatus] [char](1) NULL,
	[InvntSttus] [char](1) NULL,	
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,	
	[Address] [nvarchar](254) NULL,
	[Address2] [nvarchar](254) NULL,
	[ObjType] [nvarchar](20) NULL,
	[NumAtCard] [nvarchar](100) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFC] [numeric](19, 6) NULL,
	[DocCur] [nvarchar](3) NULL,	
	[DocTotal] [numeric](19, 6) NULL,
	[DocTotalFC] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,	
	[Ref1] [nvarchar](11) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[TransId] [int] NULL,	
	[DocRate] [numeric](19, 6) NULL,
	[SysRate] [numeric](19, 6) NULL,	
	[VatSumSy] [numeric](19, 6) NULL,	
	[DocTotalSy] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,	
	[UpdateDate] [datetime] NULL,	
	[CreateDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[FinncPriod] [int] NULL,
	[UserSign] [smallint] NULL,	
	[VatPaid] [numeric](19, 6) NULL,
	[VatPaidFC] [numeric](19, 6) NULL,
	[VatPaidSys] [numeric](19, 6) NULL,
	[NnSbAmnt] [numeric](19,6) NULL,
	[NnSbAmntSC] [numeric](19,6) NULL,
	[NbSbAmntFC] [numeric](19,6) NULL,
	[BaseAmnt] [numeric](19,6) NULL,
	[BaseAmntSC] [numeric](19,6) NULL,
	[BaseAmntFC] [numeric](19,6) NULL,
	[UserSign2] [smallint] NULL,	
	[LicTradNum] [nvarchar](32) NULL,	
	[WTSum] [numeric](19, 6) NULL,
	[WTSumFC] [numeric](19, 6) NULL,
	[WTSumSC] [numeric](19, 6) NULL,	
	[WTApplied] [numeric](19, 6) NULL,
	[WTAppliedF] [numeric](19, 6) NULL,	
	[WTAppliedS] [numeric](19, 6) NULL,	
	[CtlAccount] [nvarchar](15) NULL,	
	[BaseVtAt] [numeric](19, 6) NULL,
	[BaseVtAtSC] [numeric](19, 6) NULL,
	[BaseVtAtFC] [numeric](19, 6) NULL,
	[NnSbVAt] [numeric](19, 6) NULL,
	[NnSbVAtSC] [numeric](19, 6) NULL,
	[NbSbVAtFC] [numeric](19, 6) NULL,	
	[PaidSum] [numeric](19, 6) NULL,
	[PaidSumFc] [numeric](19, 6) NULL,
	[PaidSumSc] [numeric](19, 6) NULL,	
	[U_IDA_CodSerie] [nvarchar](10) NULL,
	[U_IDA_Serie] [nvarchar](10) NULL,
	[U_IDA_NumControl] [nvarchar](20) NULL,
	[U_IDA_TipoTrans] [nvarchar](10) NULL,
	[U_IDA_Fafe] [nvarchar](30) NULL,
	[U_IDA_CompIVA] [nvarchar](20) NULL,
	[U_IDA_NumExport] [nvarchar](50) NULL,
	[U_IDA_TipoDoc] [nvarchar](20) NULL,
	[U_IDA_NumFile] [nvarchar](50) NULL,
	[U_IDA_NumImport] [nvarchar](50) NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_FechaContComp] [datetime] NULL,
	[U_IDA_MontoCompIVA] [numeric](19, 6) NULL,
	[U_IDA_MontoFafe] [numeric](19, 6) NULL,
	[U_IDA_FechaFafe] [datetime] NULL,
	[U_IDA_IsPlanilla] [nvarchar](10) NULL,
	[U_IDA_PagoElectronic] [nvarchar](10) NULL,
	[U_IDA_Alicuota] [nvarchar](10) NULL,
	[U_IDA_RetenTercero] [nvarchar](10) NULL,
	[U_IDA_TipoRet] [nvarchar](10) NULL,
	[U_IDA_Tercero] [nvarchar](100) NULL,
	[U_IDA_CompMunicipal] [nvarchar](20) NULL,
	[U_IDA_DateCompMun] [datetime] NULL,
	[U_IDA_CorteZ] [nvarchar](100) NULL,
	[U_IDA_SerialImpre] [nvarchar](100) NULL,
	[U_IDA_DocAnulado] [nvarchar](10) NULL,
	[U_IDA_CompISLR] [nvarchar](20) NULL,
	[U_IDA_DateCompISLR] [datetime] NULL,
	[U_IDA_DateContISLR] [datetime] NULL,
	[DiscPrcnt] [numeric](19, 6) NULL,
	[DiscSum] [numeric](19, 6) NULL,
	[DiscSumFC] [numeric](19, 6) NULL,
	[DiscSumSy] [numeric](19, 6) NULL,
	[DocTime] [smallint] NULL,
	CONSTRAINT fk_CardCodeOPND FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignOPND FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 )
GO

CREATE TABLE [dbo].[ORPC](
	[DocEntry] [int] NOT NULL IDENTITY(1,1)  PRIMARY KEY,
	[DocNum] [int] NULL,
	[Max1099] [numeric](19, 6) NULL,
	[DocType] [char](1) NULL,
	[CANCELED] [char](1) NULL,	
	[DocStatus] [char](1) NULL,
	[InvntSttus] [char](1) NULL,	
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,
	[Address] [nvarchar](254) NULL,
	[Address2] [nvarchar](254) NULL,
	[ObjType] [nvarchar](20) NULL,
	[NumAtCard] [nvarchar](100) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFC] [numeric](19, 6) NULL,
	[NnSbAmnt] [numeric](19,6) NULL,
	[NnSbAmntSC] [numeric](19,6) NULL,
	[NbSbAmntFC] [numeric](19,6) NULL,
	[BaseAmnt] [numeric](19,6) NULL,
	[BaseAmntSC] [numeric](19,6) NULL,
	[BaseAmntFC] [numeric](19,6) NULL,
	[DocCur] [nvarchar](3) NULL,	
	[DocTotal] [numeric](19, 6) NULL,
	[DocTotalFC] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,	
	[Ref1] [nvarchar](11) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[TransId] [int] NULL,	
	[DocRate] [numeric](19, 6) NULL,
	[SysRate] [numeric](19, 6) NULL,	
	[VatSumSy] [numeric](19, 6) NULL,	
	[DocTotalSy] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,	
	[UpdateDate] [datetime] NULL,	
	[CreateDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[FinncPriod] [int] NULL,
	[UserSign] [smallint] NULL,	
	[VatPaid] [numeric](19, 6) NULL,
	[VatPaidFC] [numeric](19, 6) NULL,
	[VatPaidSys] [numeric](19, 6) NULL,
	[UserSign2] [smallint] NULL,	
	[LicTradNum] [nvarchar](32) NULL,	
	[WTSum] [numeric](19, 6) NULL,
	[WTSumFC] [numeric](19, 6) NULL,
	[WTSumSC] [numeric](19, 6) NULL,	
	[WTApplied] [numeric](19, 6) NULL,
	[WTAppliedF] [numeric](19, 6) NULL,	
	[WTAppliedS] [numeric](19, 6) NULL,	
	[CtlAccount] [nvarchar](15) NULL,	
	[BaseVtAt] [numeric](19, 6) NULL,
	[BaseVtAtSC] [numeric](19, 6) NULL,
	[BaseVtAtFC] [numeric](19, 6) NULL,
	[NnSbVAt] [numeric](19, 6) NULL,
	[NnSbVAtSC] [numeric](19, 6) NULL,
	[NbSbVAtFC] [numeric](19, 6) NULL,	
	[PaidSum] [numeric](19, 6) NULL,
	[PaidSumFc] [numeric](19, 6) NULL,
	[PaidSumSc] [numeric](19, 6) NULL,	
	[U_IDA_CodSerie] [nvarchar](10) NULL,
	[U_IDA_Serie] [nvarchar](10) NULL,
	[U_IDA_NumControl] [nvarchar](20) NULL,
	[U_IDA_TipoTrans] [nvarchar](10) NULL,
	[U_IDA_Fafe] [nvarchar](30) NULL,
	[U_IDA_CompIVA] [nvarchar](20) NULL,
	[U_IDA_NumExport] [nvarchar](50) NULL,
	[U_IDA_TipoDoc] [nvarchar](20) NULL,
	[U_IDA_NumFile] [nvarchar](50) NULL,
	[U_IDA_NumImport] [nvarchar](50) NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_FechaContComp] [datetime] NULL,
	[U_IDA_MontoCompIVA] [numeric](19, 6) NULL,
	[U_IDA_MontoFafe] [numeric](19, 6) NULL,
	[U_IDA_FechaFafe] [datetime] NULL,
	[U_IDA_IsPlanilla] [nvarchar](10) NULL,
	[U_IDA_PagoElectronic] [nvarchar](10) NULL,
	[U_IDA_Alicuota] [nvarchar](10) NULL,
	[U_IDA_RetenTercero] [nvarchar](10) NULL,
	[U_IDA_TipoRet] [nvarchar](10) NULL,
	[U_IDA_Tercero] [nvarchar](100) NULL,
	[U_IDA_CompMunicipal] [nvarchar](20) NULL,
	[U_IDA_DateCompMun] [datetime] NULL,
	[U_IDA_CorteZ] [nvarchar](100) NULL,
	[U_IDA_SerialImpre] [nvarchar](100) NULL,
	[U_IDA_DocAnulado] [nvarchar](10) NULL,
	[U_IDA_CompISLR] [nvarchar](20) NULL,
	[U_IDA_DateCompISLR] [datetime] NULL,
	[U_IDA_DateContISLR] [datetime] NULL,
	[DocSubType][nvarchar](2) null,
	[DiscPrcnt] [numeric](19, 6) NULL,
	[DiscSum] [numeric](19, 6) NULL,
	[DiscSumFC] [numeric](19, 6) NULL,
	[DiscSumSy] [numeric](19, 6) NULL,
	[DocTime] [smallint] NULL,
	CONSTRAINT fk_CardCodeORPC FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignORPC FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
)
GO
/****** Object:  Table [dbo].[ORTT]    Script Date: 27/2/2020 10:16:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORTT](
	[RateDate] [datetime] NOT NULL,
	[Currency] [nvarchar](3) NOT NULL ,
	[Rate] [numeric](19, 6) NULL,
	[DataSource] [char](1) NULL,
	[UserSign] [smallint] NULL,
	CONSTRAINT fk_UserSignORTT FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
)
GO

CREATE TABLE [dbo].[OSTA](
	[Code] [nvarchar](8) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](100) NULL,
	[Rate] [numeric](19, 6) NULL,
	[SalesTax] [nvarchar](15) NULL,
	[UserSign] [smallint] NULL,
	[PurchTax] [nvarchar](15) NULL,
	CONSTRAINT fk_UserSignOSTA FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
	
)
GO
/****** Object:  Table [dbo].[OSTC]    Script Date: 27/2/2020 10:16:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OSTC](
	[Code] [nvarchar](8) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](100) NULL,
	[Rate] [numeric](19, 6) NULL,
	[Freight] [char](1) NULL,
	[UserSign] [smallint] NULL,
	[ValidForAR] [char](1) NULL,
	[ValidForAP] [char](1) NULL,	
	[Lock] [char](1) NULL,	
	[UserSign2] [smallint] NULL,
	[UpdateDate] [datetime] NULL,	
	[U_IDA_Alicuota] [nvarchar](20) NULL,
	CONSTRAINT fk_UserSignOSTC FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
)


GO
/****** Object:  Table [dbo].[OSTC]    Script Date: 27/2/2020 10:16:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STC1](
	[STCCode] [nvarchar](8) NOT NULL,
	[Line_ID] [int] NOT NULL,
	[STACode] [nvarchar](8) NULL,
	[EfctivRate] [numeric](19, 6) NULL,	
	constraint pk_STCCode primary key (STCCode, Line_ID),
	CONSTRAINT fk_STACode FOREIGN KEY ([STACode]) REFERENCES [dbo].[OSTA] ([Code])
)


GO

CREATE TABLE [dbo].[OWHT](
	[WTCode] [nvarchar](4) NOT NULL PRIMARY KEY,
	[WTName] [nvarchar](50) NULL,
	[Rate] [numeric](19, 6) NULL,
	[EffecDate] [datetime] NULL,
	[Category] [char](1) NULL,
	[BaseType] [char](1) NULL,
	[PrctBsAmnt] [numeric](19, 6) NULL,	
	[Account] [nvarchar](15) NULL,	
	[UserSign] [smallint] NULL,	
	[Inactive] [char](1) NULL,	
	[U_IDA_TipoRetencion] [nvarchar](20) NULL,
	[U_IDA_BaseMinima] [numeric](19, 6) NULL,
	[U_IDA_Sustraendo] [numeric](19, 6) NULL,
	[Offclcode] [NVARCHAR](15) NULL,
	CONSTRAINT fk_UserSignOWHT FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 )
GO

GO --Linea Factura de Proveedores
CREATE TABLE [dbo].[PCH1](
	[DocEntry] [int] NOT NULL,
	[LineNum] [int] NOT NULL ,	
	[LineStatus] [char](1) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[Dscription] [nvarchar](100) NULL,
	[Quantity] [numeric](19, 6) NULL,	
	[OpenQty] [numeric](19, 6) NULL,
	[Price] [numeric](19, 6) NULL,
	[Currency] [nvarchar](3) NULL,	
	[LineTotal] [numeric](19, 6) NULL,
	[OpenSum] [numeric](19, 6) NULL,
	[OpenSumFC] [numeric](19, 6) NULL,	
	[AcctCode] [nvarchar](15) NULL,	
	[DocDate] [datetime] NULL,	
	[OpenCreQty] [numeric](19, 6) NULL,	
	[BaseCard] [nvarchar](15) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[OpenSumSys] [numeric](19, 6) NULL,
	[InvntSttus] [char](1) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[PriceAfVAT] [numeric](19, 6) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[FinncPriod] [int] NULL,
	[ObjType] [nvarchar](20) NULL,	
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,	
	[Address] [nvarchar](254) NULL,	
	[VatAppld] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[BaseQty] [numeric](19, 6) NULL,
	[BaseOpnQty] [numeric](19, 6) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[WtLiable] [char](1) NULL,	
	[LineVat] [numeric](19, 6) NULL,
	[LineVatlF] [numeric](19, 6) NULL,	
	[StockSum] [numeric](19, 6) NULL,
	[StockSumFc] [numeric](19, 6) NULL,
	[StockSumSc] [numeric](19, 6) NULL,
	[InvQty] [numeric](19, 6) NULL,
	[OpenInvQty] [numeric](19, 6) NULL,
	[GTotal] [numeric](19, 6) NULL,
	[GTotalFC] [numeric](19, 6) NULL,
	[GTotalSC] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[DataSource] [char](1) null,
	[BaseEntry] [INT] NULL,
	constraint pk_PCH1 primary key ([DocEntry], LineNum),
	CONSTRAINT fk_DocEntryPCH1 FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[OPCH] ([DocEntry]),
	CONSTRAINT fk_AcctCodePCH1 FOREIGN KEY ([AcctCode]) REFERENCES [dbo].[OACT] ([AcctCode])
)

GO
CREATE TABLE [dbo].[PDN1](
	[DocEntry] [int] NOT NULL,
	[LineNum] [int] NOT NULL ,	
	[LineStatus] [char](1) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[Dscription] [nvarchar](100) NULL,
	[Quantity] [numeric](19, 6) NULL,	
	[OpenQty] [numeric](19, 6) NULL,
	[Price] [numeric](19, 6) NULL,
	[Currency] [nvarchar](3) NULL,	
	[LineTotal] [numeric](19, 6) NULL,
	[OpenSum] [numeric](19, 6) NULL,
	[OpenSumFC] [numeric](19, 6) NULL,	
	[AcctCode] [nvarchar](15) NULL,	
	[DocDate] [datetime] NULL,	
	[OpenCreQty] [numeric](19, 6) NULL,	
	[BaseCard] [nvarchar](15) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[OpenSumSys] [numeric](19, 6) NULL,
	[InvntSttus] [char](1) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[PriceAfVAT] [numeric](19, 6) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[FinncPriod] [int] NULL,
	[ObjType] [nvarchar](20) NULL,	
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,	
	[Address] [nvarchar](254) NULL,	
	[VatAppld] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[BaseQty] [numeric](19, 6) NULL,
	[BaseOpnQty] [numeric](19, 6) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[WtLiable] [char](1) NULL,	
	[LineVat] [numeric](19, 6) NULL,
	[LineVatlF] [numeric](19, 6) NULL,	
	[StockSum] [numeric](19, 6) NULL,
	[StockSumFc] [numeric](19, 6) NULL,
	[StockSumSc] [numeric](19, 6) NULL,
	[InvQty] [numeric](19, 6) NULL,
	[OpenInvQty] [numeric](19, 6) NULL,
	[GTotal] [numeric](19, 6) NULL,
	[GTotalFC] [numeric](19, 6) NULL,
	[GTotalSC] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[DataSource] [char](1) null,
	constraint pk_PDN1 primary key ([DocEntry], LineNum),
	CONSTRAINT fk_DocEntryPDN1 FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[OPDN] ([DocEntry]),
	CONSTRAINT fk_AcctCodePDN1 FOREIGN KEY ([AcctCode]) REFERENCES [dbo].[OACT] ([AcctCode])
 )

GO
CREATE TABLE [dbo].[RPC1](
	[DocEntry] [int] NOT NULL,
	[LineNum] [int] NOT NULL ,	
	[LineStatus] [char](1) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[Dscription] [nvarchar](100) NULL,
	[Quantity] [numeric](19, 6) NULL,	
	[OpenQty] [numeric](19, 6) NULL,
	[Price] [numeric](19, 6) NULL,
	[Currency] [nvarchar](3) NULL,	
	[LineTotal] [numeric](19, 6) NULL,
	[OpenSum] [numeric](19, 6) NULL,
	[OpenSumFC] [numeric](19, 6) NULL,	
	[AcctCode] [nvarchar](15) NULL,	
	[DocDate] [datetime] NULL,	
	[OpenCreQty] [numeric](19, 6) NULL,	
	[BaseCard] [nvarchar](15) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[OpenSumSys] [numeric](19, 6) NULL,
	[InvntSttus] [char](1) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[PriceAfVAT] [numeric](19, 6) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[FinncPriod] [int] NULL,
	[ObjType] [nvarchar](20) NULL,	
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,	
	[Address] [nvarchar](254) NULL,	
	[VatAppld] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[BaseQty] [numeric](19, 6) NULL,
	[BaseOpnQty] [numeric](19, 6) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[WtLiable] [char](1) NULL,	
	[LineVat] [numeric](19, 6) NULL,
	[LineVatlF] [numeric](19, 6) NULL,	
	[StockSum] [numeric](19, 6) NULL,
	[StockSumFc] [numeric](19, 6) NULL,
	[StockSumSc] [numeric](19, 6) NULL,
	[InvQty] [numeric](19, 6) NULL,
	[OpenInvQty] [numeric](19, 6) NULL,
	[GTotal] [numeric](19, 6) NULL,
	[GTotalFC] [numeric](19, 6) NULL,
	[GTotalSC] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[DataSource] [char](1) null,
	[BaseEntry] [INT] NULL,
	constraint pk_RPC1 primary key ([DocEntry], LineNum),
	CONSTRAINT fk_DocEntryRPC1 FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[ORPC] ([DocEntry]),
	CONSTRAINT fk_AcctCodeRPC1 FOREIGN KEY ([AcctCode]) REFERENCES [dbo].[OACT] ([AcctCode])
 
 )
GO
CREATE TABLE [dbo].[OINV](
	[DocEntry] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DocNum] [int] NULL,
	[Max1099] [numeric](19, 6) NULL,
	[DocType] [char](1) NULL,
	[CANCELED] [char](1) NULL,	
	[DocStatus] [char](1) NULL,
	[InvntSttus] [char](1) NULL,	
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,
	[Address] [nvarchar](254) NULL,
	[Address2] [nvarchar](254) NULL,
	[ObjType] [nvarchar](20) NULL,
	[NumAtCard] [nvarchar](100) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFC] [numeric](19, 6) NULL,
	[DocCur] [nvarchar](3) NULL,	
	[NnSbAmnt] [numeric](19,6) NULL,
	[NnSbAmntSC] [numeric](19,6) NULL,
	[NbSbAmntFC] [numeric](19,6) NULL,
	[BaseAmnt] [numeric](19,6) NULL,
	[BaseAmntSC] [numeric](19,6) NULL,
	[BaseAmntFC] [numeric](19,6) NULL,
	[DocTotal] [numeric](19, 6) NULL,
	[DocTotalFC] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,	
	[Ref1] [nvarchar](11) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[TransId] [int] NULL,	
	[DocRate] [numeric](19, 6) NULL,
	[SysRate] [numeric](19, 6) NULL,	
	[VatSumSy] [numeric](19, 6) NULL,	
	[DocTotalSy] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,	
	[UpdateDate] [datetime] NULL,	
	[CreateDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[FinncPriod] [int] NULL,
	[UserSign] [smallint] NULL,	
	[VatPaid] [numeric](19, 6) NULL,
	[VatPaidFC] [numeric](19, 6) NULL,
	[VatPaidSys] [numeric](19, 6) NULL,
	[UserSign2] [smallint] NULL,	
	[LicTradNum] [nvarchar](32) NULL,	
	[WTSum] [numeric](19, 6) NULL,
	[WTSumFC] [numeric](19, 6) NULL,
	[WTSumSC] [numeric](19, 6) NULL,	
	[WTApplied] [numeric](19, 6) NULL,
	[WTAppliedF] [numeric](19, 6) NULL,	
	[WTAppliedS] [numeric](19, 6) NULL,	
	[CtlAccount] [nvarchar](15) NULL,	
	[BaseVtAt] [numeric](19, 6) NULL,
	[BaseVtAtSC] [numeric](19, 6) NULL,
	[BaseVtAtFC] [numeric](19, 6) NULL,
	[NnSbVAt] [numeric](19, 6) NULL,
	[NnSbVAtSC] [numeric](19, 6) NULL,
	[NbSbVAtFC] [numeric](19, 6) NULL,	
	[PaidSum] [numeric](19, 6) NULL,
	[PaidSumFc] [numeric](19, 6) NULL,
	[PaidSumSc] [numeric](19, 6) NULL,	
	[U_IDA_CodSerie] [nvarchar](10) NULL,
	[U_IDA_Serie] [nvarchar](10) NULL,
	[U_IDA_NumControl] [nvarchar](20) NULL,
	[U_IDA_TipoTrans] [nvarchar](10) NULL,
	[U_IDA_Fafe] [nvarchar](30) NULL,
	[U_IDA_CompIVA] [nvarchar](20) NULL,
	[U_IDA_NumExport] [nvarchar](50) NULL,
	[U_IDA_TipoDoc] [nvarchar](20) NULL,
	[U_IDA_NumFile] [nvarchar](50) NULL,
	[U_IDA_NumImport] [nvarchar](50) NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_FechaContComp] [datetime] NULL,
	[U_IDA_MontoCompIVA] [numeric](19, 6) NULL,
	[U_IDA_MontoFafe] [numeric](19, 6) NULL,
	[U_IDA_FechaFafe] [datetime] NULL,
	[U_IDA_IsPlanilla] [nvarchar](10) NULL,
	[U_IDA_PagoElectronic] [nvarchar](10) NULL,
	[U_IDA_Alicuota] [nvarchar](10) NULL,
	[U_IDA_RetenTercero] [nvarchar](10) NULL,
	[U_IDA_TipoRet] [nvarchar](10) NULL,
	[U_IDA_Tercero] [nvarchar](100) NULL,
	[U_IDA_CompMunicipal] [nvarchar](20) NULL,
	[U_IDA_DateCompMun] [datetime] NULL,
	[U_IDA_CorteZ] [nvarchar](100) NULL,
	[U_IDA_SerialImpre] [nvarchar](100) NULL,
	[U_IDA_DocAnulado] [nvarchar](10) NULL,
	[U_IDA_CompISLR] [nvarchar](20) NULL,
	[U_IDA_DateCompISLR] [datetime] NULL,
	[U_IDA_DateContISLR] [datetime] NULL,
	[DocSubType][nvarchar](2) null,
	[DiscPrcnt] [numeric](19, 6) NULL,
	[DiscSum] [numeric](19, 6) NULL,
	[DiscSumFC] [numeric](19, 6) NULL,
	[DiscSumSy] [numeric](19, 6) NULL,
	[DocTime] [smallint] NULL,
	CONSTRAINT fk_CardCodeOINV FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignOINV FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 )

GO

CREATE TABLE [dbo].[INV1](
	[DocEntry] [int] NOT NULL,
	[LineNum] [int] NOT NULL ,	
	[LineStatus] [char](1) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[Dscription] [nvarchar](100) NULL,
	[Quantity] [numeric](19, 6) NULL,	
	[OpenQty] [numeric](19, 6) NULL,
	[Price] [numeric](19, 6) NULL,
	[Currency] [nvarchar](3) NULL,	
	[LineTotal] [numeric](19, 6) NULL,
	[OpenSum] [numeric](19, 6) NULL,
	[OpenSumFC] [numeric](19, 6) NULL,	
	[AcctCode] [nvarchar](15) NULL,	
	[DocDate] [datetime] NULL,	
	[OpenCreQty] [numeric](19, 6) NULL,	
	[BaseCard] [nvarchar](15) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[OpenSumSys] [numeric](19, 6) NULL,
	[InvntSttus] [char](1) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[PriceAfVAT] [numeric](19, 6) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[FinncPriod] [int] NULL,
	[ObjType] [nvarchar](20) NULL,	
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,	
	[Address] [nvarchar](254) NULL,	
	[VatAppld] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[BaseQty] [numeric](19, 6) NULL,
	[BaseOpnQty] [numeric](19, 6) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[WtLiable] [char](1) NULL,	
	[LineVat] [numeric](19, 6) NULL,
	[LineVatlF] [numeric](19, 6) NULL,	
	[StockSum] [numeric](19, 6) NULL,
	[StockSumFc] [numeric](19, 6) NULL,
	[StockSumSc] [numeric](19, 6) NULL,
	[InvQty] [numeric](19, 6) NULL,
	[OpenInvQty] [numeric](19, 6) NULL,
	[GTotal] [numeric](19, 6) NULL,
	[GTotalFC] [numeric](19, 6) NULL,
	[GTotalSC] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[DataSource] [char](1) null,
	[BaseEntry] [INT] NULL,
	constraint pk_INV1 primary key ([DocEntry], LineNum),
	CONSTRAINT fk_DocEntryINV1 FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[OINV] ([DocEntry]),
	CONSTRAINT fk_AcctCodeINV1 FOREIGN KEY ([AcctCode]) REFERENCES [dbo].[OACT] ([AcctCode])
 )
 GO
CREATE TABLE [dbo].[ORIN](
	[DocEntry] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DocNum] [int] NULL,
	[Max1099] [numeric](19, 6) NULL,
	[DocType] [char](1) NULL,
	[CANCELED] [char](1) NULL,	
	[DocStatus] [char](1) NULL,
	[InvntSttus] [char](1) NULL,	
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,
	[Address] [nvarchar](254) NULL,
	[Address2] [nvarchar](254) NULL,
	[ObjType] [nvarchar](20) NULL,
	[NumAtCard] [nvarchar](100) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFC] [numeric](19, 6) NULL,
	[DocCur] [nvarchar](3) NULL,	
	[NnSbAmnt] [numeric](19,6) NULL,
	[NnSbAmntSC] [numeric](19,6) NULL,
	[NbSbAmntFC] [numeric](19,6) NULL,
	[BaseAmnt] [numeric](19,6) NULL,
	[BaseAmntSC] [numeric](19,6) NULL,
	[BaseAmntFC] [numeric](19,6) NULL,
	[DocTotal] [numeric](19, 6) NULL,
	[DocTotalFC] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,	
	[Ref1] [nvarchar](11) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[TransId] [int] NULL,
	[DocRate] [numeric](19, 6) NULL,
	[SysRate] [numeric](19, 6) NULL,	
	[VatSumSy] [numeric](19, 6) NULL,	
	[DocTotalSy] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,	
	[UpdateDate] [datetime] NULL,	
	[CreateDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[FinncPriod] [int] NULL,
	[UserSign] [smallint] NULL,	
	[VatPaid] [numeric](19, 6) NULL,
	[VatPaidFC] [numeric](19, 6) NULL,
	[VatPaidSys] [numeric](19, 6) NULL,
	[UserSign2] [smallint] NULL,	
	[LicTradNum] [nvarchar](32) NULL,	
	[WTSum] [numeric](19, 6) NULL,
	[WTSumFC] [numeric](19, 6) NULL,
	[WTSumSC] [numeric](19, 6) NULL,	
	[WTApplied] [numeric](19, 6) NULL,
	[WTAppliedF] [numeric](19, 6) NULL,	
	[WTAppliedS] [numeric](19, 6) NULL,	
	[CtlAccount] [nvarchar](15) NULL,	
	[BaseVtAt] [numeric](19, 6) NULL,
	[BaseVtAtSC] [numeric](19, 6) NULL,
	[BaseVtAtFC] [numeric](19, 6) NULL,
	[NnSbVAt] [numeric](19, 6) NULL,
	[NnSbVAtSC] [numeric](19, 6) NULL,
	[NbSbVAtFC] [numeric](19, 6) NULL,	
	[PaidSum] [numeric](19, 6) NULL,
	[PaidSumFc] [numeric](19, 6) NULL,
	[PaidSumSc] [numeric](19, 6) NULL,	
	[U_IDA_CodSerie] [nvarchar](10) NULL,
	[U_IDA_Serie] [nvarchar](10) NULL,
	[U_IDA_NumControl] [nvarchar](20) NULL,
	[U_IDA_TipoTrans] [nvarchar](10) NULL,
	[U_IDA_Fafe] [nvarchar](30) NULL,
	[U_IDA_CompIVA] [nvarchar](20) NULL,
	[U_IDA_NumExport] [nvarchar](50) NULL,
	[U_IDA_TipoDoc] [nvarchar](20) NULL,
	[U_IDA_NumFile] [nvarchar](50) NULL,
	[U_IDA_NumImport] [nvarchar](50) NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_FechaContComp] [datetime] NULL,
	[U_IDA_MontoCompIVA] [numeric](19, 6) NULL,
	[U_IDA_MontoFafe] [numeric](19, 6) NULL,
	[U_IDA_FechaFafe] [datetime] NULL,
	[U_IDA_IsPlanilla] [nvarchar](10) NULL,
	[U_IDA_PagoElectronic] [nvarchar](10) NULL,
	[U_IDA_Alicuota] [nvarchar](10) NULL,
	[U_IDA_RetenTercero] [nvarchar](10) NULL,
	[U_IDA_TipoRet] [nvarchar](10) NULL,
	[U_IDA_Tercero] [nvarchar](100) NULL,
	[U_IDA_CompMunicipal] [nvarchar](20) NULL,
	[U_IDA_DateCompMun] [datetime] NULL,
	[U_IDA_CorteZ] [nvarchar](100) NULL,
	[U_IDA_SerialImpre] [nvarchar](100) NULL,
	[U_IDA_DocAnulado] [nvarchar](10) NULL,
	[U_IDA_CompISLR] [nvarchar](20) NULL,
	[U_IDA_DateCompISLR] [datetime] NULL,
	[U_IDA_DateContISLR] [datetime] NULL,
	[DocSubType][nvarchar](2) null,
	[DiscPrcnt] [numeric](19, 6) NULL,
	[DiscSum] [numeric](19, 6) NULL,
	[DiscSumFC] [numeric](19, 6) NULL,
	[DiscSumSy] [numeric](19, 6) NULL,
	[DocTime] [smallint] NULL,
	CONSTRAINT fk_CardCodeORIN FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignORIN FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
 )
GO
CREATE TABLE [dbo].[RIN1](
	[DocEntry] [int] NOT NULL,
	[LineNum] [int] NOT NULL ,	
	[LineStatus] [char](1) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[Dscription] [nvarchar](100) NULL,
	[Quantity] [numeric](19, 6) NULL,	
	[OpenQty] [numeric](19, 6) NULL,
	[Price] [numeric](19, 6) NULL,
	[Currency] [nvarchar](3) NULL,	
	[LineTotal] [numeric](19, 6) NULL,
	[OpenSum] [numeric](19, 6) NULL,
	[OpenSumFC] [numeric](19, 6) NULL,	
	[AcctCode] [nvarchar](15) NULL,	
	[DocDate] [datetime] NULL,	
	[OpenCreQty] [numeric](19, 6) NULL,	
	[BaseCard] [nvarchar](15) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[OpenSumSys] [numeric](19, 6) NULL,
	[InvntSttus] [char](1) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[PriceAfVAT] [numeric](19, 6) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[FinncPriod] [int] NULL,
	[ObjType] [nvarchar](20) NULL,	
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,	
	[Address] [nvarchar](254) NULL,	
	[VatAppld] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[BaseQty] [numeric](19, 6) NULL,
	[BaseOpnQty] [numeric](19, 6) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[WtLiable] [char](1) NULL,	
	[LineVat] [numeric](19, 6) NULL,
	[LineVatlF] [numeric](19, 6) NULL,	
	[StockSum] [numeric](19, 6) NULL,
	[StockSumFc] [numeric](19, 6) NULL,
	[StockSumSc] [numeric](19, 6) NULL,
	[InvQty] [numeric](19, 6) NULL,
	[OpenInvQty] [numeric](19, 6) NULL,
	[GTotal] [numeric](19, 6) NULL,
	[GTotalFC] [numeric](19, 6) NULL,
	[GTotalSC] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[DataSource] [char](1) null,
	[BaseEntry] [INT] NULL,
	constraint pk_RIN1 primary key ([DocEntry], LineNum),
	CONSTRAINT fk_DocEntryRIN1 FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[ORIN] ([DocEntry]),
	CONSTRAINT fk_AcctCodeRIN1 FOREIGN KEY ([AcctCode]) REFERENCES [dbo].[OACT] ([AcctCode])
 )

 GO
 CREATE TABLE [dbo].[ODLN](
	[DocEntry] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DocNum] [int] NULL,
	[Max1099] [numeric](19, 6) NULL,
	[DocType] [char](1) NULL,
	[CANCELED] [char](1) NULL,	
	[DocStatus] [char](1) NULL,
	[InvntSttus] [char](1) NULL,	
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,	
	[Address] [nvarchar](254) NULL,
	[Address2] [nvarchar](254) NULL,
	[ObjType] [nvarchar](20) NULL,
	[NumAtCard] [nvarchar](100) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFC] [numeric](19, 6) NULL,
	[DocCur] [nvarchar](3) NULL,	
	[NnSbAmnt] [numeric](19,6) NULL,
	[NnSbAmntSC] [numeric](19,6) NULL,
	[NbSbAmntFC] [numeric](19,6) NULL,
	[BaseAmnt] [numeric](19,6) NULL,
	[BaseAmntSC] [numeric](19,6) NULL,
	[BaseAmntFC] [numeric](19,6) NULL,
	[DocTotal] [numeric](19, 6) NULL,
	[DocTotalFC] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,	
	[Ref1] [nvarchar](11) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[TransId] [int] NULL,
	[DocRate] [numeric](19, 6) NULL,
	[SysRate] [numeric](19, 6) NULL,	
	[VatSumSy] [numeric](19, 6) NULL,	
	[DocTotalSy] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,	
	[UpdateDate] [datetime] NULL,	
	[CreateDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[FinncPriod] [int] NULL,
	[UserSign] [smallint] NULL,	
	[VatPaid] [numeric](19, 6) NULL,
	[VatPaidFC] [numeric](19, 6) NULL,
	[VatPaidSys] [numeric](19, 6) NULL,
	[UserSign2] [smallint] NULL,	
	[LicTradNum] [nvarchar](32) NULL,	
	[WTSum] [numeric](19, 6) NULL,
	[WTSumFC] [numeric](19, 6) NULL,
	[WTSumSC] [numeric](19, 6) NULL,	
	[WTApplied] [numeric](19, 6) NULL,
	[WTAppliedF] [numeric](19, 6) NULL,	
	[WTAppliedS] [numeric](19, 6) NULL,	
	[CtlAccount] [nvarchar](15) NULL,	
	[BaseVtAt] [numeric](19, 6) NULL,
	[BaseVtAtSC] [numeric](19, 6) NULL,
	[BaseVtAtFC] [numeric](19, 6) NULL,
	[NnSbVAt] [numeric](19, 6) NULL,
	[NnSbVAtSC] [numeric](19, 6) NULL,
	[NbSbVAtFC] [numeric](19, 6) NULL,	
	[PaidSum] [numeric](19, 6) NULL,
	[PaidSumFc] [numeric](19, 6) NULL,
	[PaidSumSc] [numeric](19, 6) NULL,	
	[U_IDA_CodSerie] [nvarchar](10) NULL,
	[U_IDA_Serie] [nvarchar](10) NULL,
	[U_IDA_NumControl] [nvarchar](20) NULL,
	[U_IDA_TipoTrans] [nvarchar](10) NULL,
	[U_IDA_Fafe] [nvarchar](30) NULL,
	[U_IDA_CompIVA] [nvarchar](20) NULL,
	[U_IDA_NumExport] [nvarchar](50) NULL,
	[U_IDA_TipoDoc] [nvarchar](20) NULL,
	[U_IDA_NumFile] [nvarchar](50) NULL,
	[U_IDA_NumImport] [nvarchar](50) NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_FechaContComp] [datetime] NULL,
	[U_IDA_MontoCompIVA] [numeric](19, 6) NULL,
	[U_IDA_MontoFafe] [numeric](19, 6) NULL,
	[U_IDA_FechaFafe] [datetime] NULL,
	[U_IDA_IsPlanilla] [nvarchar](10) NULL,
	[U_IDA_PagoElectronic] [nvarchar](10) NULL,
	[U_IDA_Alicuota] [nvarchar](10) NULL,
	[U_IDA_RetenTercero] [nvarchar](10) NULL,
	[U_IDA_TipoRet] [nvarchar](10) NULL,
	[U_IDA_Tercero] [nvarchar](100) NULL,
	[U_IDA_CompMunicipal] [nvarchar](20) NULL,
	[U_IDA_DateCompMun] [datetime] NULL,
	[U_IDA_CorteZ] [nvarchar](100) NULL,
	[U_IDA_SerialImpre] [nvarchar](100) NULL,
	[U_IDA_DocAnulado] [nvarchar](10) NULL,
	[U_IDA_CompISLR] [nvarchar](20) NULL,
	[U_IDA_DateCompISLR] [datetime] NULL,
	[U_IDA_DateContISLR] [datetime] NULL,
	[DiscPrcnt] [numeric](19, 6) NULL,
	[DiscSum] [numeric](19, 6) NULL,
	[DiscSumFC] [numeric](19, 6) NULL,
	[DiscSumSy] [numeric](19, 6) NULL,
	[DocTime] [smallint] NULL,
	CONSTRAINT fk_CardCodeODLN FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignODLN FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID])
	
	
)
GO
	CREATE TABLE [dbo].[DLN1](
	[DocEntry] [int] NOT NULL,
	[LineNum] [int] NOT NULL ,	
	[LineStatus] [char](1) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[Dscription] [nvarchar](100) NULL,
	[Quantity] [numeric](19, 6) NULL,	
	[OpenQty] [numeric](19, 6) NULL,
	[Price] [numeric](19, 6) NULL,
	[Currency] [nvarchar](3) NULL,	
	[LineTotal] [numeric](19, 6) NULL,
	[OpenSum] [numeric](19, 6) NULL,
	[OpenSumFC] [numeric](19, 6) NULL,	
	[AcctCode] [nvarchar](15) NULL,	
	[DocDate] [datetime] NULL,	
	[OpenCreQty] [numeric](19, 6) NULL,	
	[BaseCard] [nvarchar](15) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[OpenSumSys] [numeric](19, 6) NULL,
	[InvntSttus] [char](1) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[PriceAfVAT] [numeric](19, 6) NULL,	
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[FinncPriod] [int] NULL,
	[ObjType] [nvarchar](20) NULL,	
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,	
	[Address] [nvarchar](254) NULL,	
	[VatAppld] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[BaseQty] [numeric](19, 6) NULL,
	[BaseOpnQty] [numeric](19, 6) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[WtLiable] [char](1) NULL,	
	[LineVat] [numeric](19, 6) NULL,
	[LineVatlF] [numeric](19, 6) NULL,	
	[StockSum] [numeric](19, 6) NULL,
	[StockSumFc] [numeric](19, 6) NULL,
	[StockSumSc] [numeric](19, 6) NULL,
	[InvQty] [numeric](19, 6) NULL,
	[OpenInvQty] [numeric](19, 6) NULL,
	[GTotal] [numeric](19, 6) NULL,
	[GTotalFC] [numeric](19, 6) NULL,
	[GTotalSC] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[DataSource] [char](1) null,
	constraint pk_DLN1 primary key ([DocEntry], LineNum),
	CONSTRAINT fk_DocEntryDLN1 FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[ODLN] ([DocEntry]),
	CONSTRAINT fk_AcctCodeDLN1 FOREIGN KEY ([AcctCode]) REFERENCES [dbo].[OACT] ([AcctCode])
 )

 GO 

 CREATE TABLE [dbo].[PCH5]
(
	[AbsEntry] [int] NOT NULL,
	[WTCode] [nvarchar](4) NOT NULL ,	
	[Rate] [numeric](19, 6) NULL,
	[BaseAmnt] [numeric](19, 6) NULL,
	[BaseAmntSC] [numeric](19, 6) NULL,
	[BaseAmntFC] [numeric](19, 6) NULL,
	[TaxbleAmnt] [numeric](19, 6) NULL,
	[TaxbleAmntSC] [numeric](19, 6) NULL,
	[TaxbleAmntFC] [numeric](19, 6) NULL,	
	[WTAmnt] [numeric](19, 6) NULL,
	[WTAmntSC] [numeric](19, 6) NULL,
	[WTAmntFC] [numeric](19, 6) NULL,
	[ApplAmnt] [numeric](19, 6) NULL,
	[ApplAmntSC] [numeric](19, 6) NULL,
	[ApplAmntFC] [numeric](19, 6) NULL,
	[Category] [char](1) NULL,
	[Account] [nvarchar](15) NULL,	
	[Type] [char](1) NULL,
	[BaseType] [char](1) NULL,	
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[ObjType][nvarchar](20) NULL,
	CONSTRAINT fk_DocEntryPCH5 FOREIGN KEY ([AbsEntry]) REFERENCES [dbo].[OPCH] ([DocEntry]),
	CONSTRAINT fk_WTCodeOWHT FOREIGN KEY ([WTCode]) REFERENCES [dbo].[OWHT] ([WTCode])
 )

 GO 

 CREATE TABLE [dbo].[INV5]
(
	[AbsEntry] [int] NOT NULL,
	[WTCode] [nvarchar](4) NOT NULL ,	
	[Rate] [numeric](19, 6) NULL,
	[BaseAmnt] [numeric](19, 6) NULL,
	[BaseAmntSC] [numeric](19, 6) NULL,
	[BaseAmntFC] [numeric](19, 6) NULL,
	[TaxbleAmnt] [numeric](19, 6) NULL,
	[TaxbleAmntSC] [numeric](19, 6) NULL,
	[TaxbleAmntFC] [numeric](19, 6) NULL,	
	[WTAmnt] [numeric](19, 6) NULL,
	[WTAmntSC] [numeric](19, 6) NULL,
	[WTAmntFC] [numeric](19, 6) NULL,
	[ApplAmnt] [numeric](19, 6) NULL,
	[ApplAmntSC] [numeric](19, 6) NULL,
	[ApplAmntFC] [numeric](19, 6) NULL,
	[Category] [char](1) NULL,
	[Account] [nvarchar](15) NULL,	
	[Type] [char](1) NULL,
	[BaseType] [char](1) NULL,	
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[ObjType][nvarchar](20) NULL,
	CONSTRAINT fk_DocEntryINV5 FOREIGN KEY ([AbsEntry]) REFERENCES [dbo].[OINV] ([DocEntry]),
	CONSTRAINT fk_WTCodeOWHT1 FOREIGN KEY ([WTCode]) REFERENCES [dbo].[OWHT] ([WTCode])
 )

 GO 

  CREATE TABLE [dbo].[RPC5]
(
	[AbsEntry] [int] NOT NULL,
	[WTCode] [nvarchar](4) NOT NULL ,	
	[Rate] [numeric](19, 6) NULL,
	[BaseAmnt] [numeric](19, 6) NULL,
	[BaseAmntSC] [numeric](19, 6) NULL,
	[BaseAmntFC] [numeric](19, 6) NULL,
	[TaxbleAmnt] [numeric](19, 6) NULL,
	[TaxbleAmntSC] [numeric](19, 6) NULL,
	[TaxbleAmntFC] [numeric](19, 6) NULL,	
	[WTAmnt] [numeric](19, 6) NULL,
	[WTAmntSC] [numeric](19, 6) NULL,
	[WTAmntFC] [numeric](19, 6) NULL,
	[ApplAmnt] [numeric](19, 6) NULL,
	[ApplAmntSC] [numeric](19, 6) NULL,
	[ApplAmntFC] [numeric](19, 6) NULL,
	[Category] [char](1) NULL,
	[Account] [nvarchar](15) NULL,	
	[Type] [char](1) NULL,
	[BaseType] [char](1) NULL,	
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[ObjType][nvarchar](20) NULL,
	CONSTRAINT fk_DocEntryRPC5 FOREIGN KEY ([AbsEntry]) REFERENCES [dbo].[ORPC] ([DocEntry]),
	CONSTRAINT fk_WTCodeOWHT2 FOREIGN KEY ([WTCode]) REFERENCES [dbo].[OWHT] ([WTCode])
 )

 GO
 CREATE TABLE [dbo].[RIN5]
(
	[AbsEntry] [int] NOT NULL,
	[WTCode] [nvarchar](4) NOT NULL ,	
	[Rate] [numeric](19, 6) NULL,
	[BaseAmnt] [numeric](19, 6) NULL,
	[BaseAmntSC] [numeric](19, 6) NULL,
	[BaseAmntFC] [numeric](19, 6) NULL,
	[TaxbleAmnt] [numeric](19, 6) NULL,
	[TaxbleAmntSC] [numeric](19, 6) NULL,
	[TaxbleAmntFC] [numeric](19, 6) NULL,	
	[WTAmnt] [numeric](19, 6) NULL,
	[WTAmntSC] [numeric](19, 6) NULL,
	[WTAmntFC] [numeric](19, 6) NULL,
	[ApplAmnt] [numeric](19, 6) NULL,
	[ApplAmntSC] [numeric](19, 6) NULL,
	[ApplAmntFC] [numeric](19, 6) NULL,
	[Category] [char](1) NULL,
	[Account] [nvarchar](15) NULL,	
	[Type] [char](1) NULL,
	[BaseType] [char](1) NULL,	
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[ObjType][nvarchar](20) NULL,
	CONSTRAINT fk_DocEntryRIN5 FOREIGN KEY ([AbsEntry]) REFERENCES [dbo].[ORIN] ([DocEntry]),
	CONSTRAINT fk_WTCodeOWHT3 FOREIGN KEY ([WTCode]) REFERENCES [dbo].[OWHT] ([WTCode])
 )
 GO
 CREATE TABLE [dbo].[PDN5]
(
	[AbsEntry] [int] NOT NULL,
	[WTCode] [nvarchar](4) NOT NULL ,	
	[Rate] [numeric](19, 6) NULL,
	[BaseAmnt] [numeric](19, 6) NULL,
	[BaseAmntSC] [numeric](19, 6) NULL,
	[BaseAmntFC] [numeric](19, 6) NULL,
	[TaxbleAmnt] [numeric](19, 6) NULL,
	[TaxbleAmntSC] [numeric](19, 6) NULL,
	[TaxbleAmntFC] [numeric](19, 6) NULL,	
	[WTAmnt] [numeric](19, 6) NULL,
	[WTAmntSC] [numeric](19, 6) NULL,
	[WTAmntFC] [numeric](19, 6) NULL,
	[ApplAmnt] [numeric](19, 6) NULL,
	[ApplAmntSC] [numeric](19, 6) NULL,
	[ApplAmntFC] [numeric](19, 6) NULL,
	[Category] [char](1) NULL,
	[Account] [nvarchar](15) NULL,	
	[Type] [char](1) NULL,
	[BaseType] [char](1) NULL,	
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[ObjType][nvarchar](20) NULL,
	CONSTRAINT fk_DocEntryPDN5 FOREIGN KEY ([AbsEntry]) REFERENCES [dbo].[OPDN] ([DocEntry]),
	CONSTRAINT fk_WTCodeOWHT5 FOREIGN KEY ([WTCode]) REFERENCES [dbo].[OWHT] ([WTCode])
 )

 GO
 CREATE TABLE [dbo].[DLN5]
(
	[AbsEntry] [int] NOT NULL,
	[WTCode] [nvarchar](4) NOT NULL ,	
	[Rate] [numeric](19, 6) NULL,
	[BaseAmnt] [numeric](19, 6) NULL,
	[BaseAmntSC] [numeric](19, 6) NULL,
	[BaseAmntFC] [numeric](19, 6) NULL,
	[TaxbleAmnt] [numeric](19, 6) NULL,
	[TaxbleAmntSC] [numeric](19, 6) NULL,
	[TaxbleAmntFC] [numeric](19, 6) NULL,	
	[WTAmnt] [numeric](19, 6) NULL,
	[WTAmntSC] [numeric](19, 6) NULL,
	[WTAmntFC] [numeric](19, 6) NULL,
	[ApplAmnt] [numeric](19, 6) NULL,
	[ApplAmntSC] [numeric](19, 6) NULL,
	[ApplAmntFC] [numeric](19, 6) NULL,
	[Category] [char](1) NULL,
	[Account] [nvarchar](15) NULL,	
	[Type] [char](1) NULL,
	[BaseType] [char](1) NULL,	
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[ObjType][nvarchar](20) NULL,
	CONSTRAINT fk_DocEntryDLN5 FOREIGN KEY ([AbsEntry]) REFERENCES [dbo].[ODLN] ([DocEntry]),
	CONSTRAINT fk_WTCodeOWHT4 FOREIGN KEY ([WTCode]) REFERENCES [dbo].[OWHT] ([WTCode])
 )

 GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORCT](
	[DocEntry] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DocNum] [int] NOT NULL,
	[DocType] [char](1) NULL,
	[Canceled] [char](1) NULL,	
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,
	[Address] [nvarchar](254) NULL,	
	[CashAcct] [nvarchar](15) NULL,
	[CashSum] [numeric](19, 6) NULL,
	[CashSumFC] [numeric](19, 6) NULL,
	[CreditSum] [numeric](19, 6) NULL,
	[CredSumFC] [numeric](19, 6) NULL,
	[CheckAcct] [nvarchar](15) NULL,
	[CheckSum] [numeric](19, 6) NULL,
	[CheckSumFC] [numeric](19, 6) NULL,
	[TrsfrAcct] [nvarchar](15) NULL,
	[TrsfrSum] [numeric](19, 6) NULL,
	[TrsfrSumFC] [numeric](19, 6) NULL,
	[TrsfrDate] [datetime] NULL,
	[TrsfrRef] [nvarchar](27) NULL,
	[PayNoDoc] [char](1) NULL,
	[NoDocSum] [numeric](19, 6) NULL,
	[NoDocSumFC] [numeric](19, 6) NULL,	
	[DiffCurr] [char](1) NULL,
	[DocRate] [numeric](19, 6) NULL,
	[SysRate] [numeric](19, 6) NULL,
	[DocTotal] [numeric](19, 6) NULL,
	[DocTotalFC] [numeric](19, 6) NULL,
	[Ref1] [nvarchar](11) NULL,	
	[CounterRef] [nvarchar](8) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[TransId] [int] NULL,	
	[CntctCode] [int] NULL,	
	[CashSumSy] [numeric](19, 6) NULL,
	[CredSumSy] [numeric](19, 6) NULL,
	[CheckSumSy] [numeric](19, 6) NULL,
	[TrsfrSumSy] [numeric](19, 6) NULL,
	[NoDocSumSy] [numeric](19, 6) NULL,
	[DocTotalSy] [numeric](19, 6) NULL,
	[ObjType] [nvarchar](20) NULL,	
	[UpdateDate] [datetime] NULL,
	[CreateDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[DataSource] [char](1) NULL,
	[UserSign] [smallint] NULL,	
	[VatGroup] [nvarchar](8) NULL,
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFC] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[FinncPriod] [int] NULL,
	[VatPrcnt] [numeric](19, 6) NULL,		
	[WtCode] [nvarchar](4) NULL,
	[WtSum] [numeric](19, 6) NULL,
	[WtSumFrgn] [numeric](19, 6) NULL,
	[WtSumSys] [numeric](19, 6) NULL,
	[WtAccount] [nvarchar](15) NULL,
	[WtBaseAmnt] [numeric](19, 6) NULL,	
	[BpAct] [nvarchar](15) NULL,
	[BcgSum] [numeric](19, 6) NULL,
	[BcgSumFC] [numeric](19, 6) NULL,
	[BcgSumSy] [numeric](19, 6) NULL,	
	[WtBaseSum] [numeric](19, 6) NULL,
	[WtBaseSumF] [numeric](19, 6) NULL,
	[WtBaseSumS] [numeric](19, 6) NULL,	
	[VatDate] [datetime] NULL,	
	[CancelDate] [datetime] NULL,	
	[UserSign2] [smallint] NULL,	
	[U_IDA_TransIdDebit] [int] NULL,
	[U_IDA_TransIdDebAnu] [int] NULL,
	[U_IDA_CostingCode] [nvarchar](30) NULL,
	[U_NX_IdAsiento] [int] NULL,
	[U_NX_IdND] [int] NULL,
	[U_NX_IdNC] [int] NULL,
	[DocCurr] [nvarchar](3) NULL,
	CONSTRAINT fk_CardCodeORCT FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignORCT FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID]),
	CONSTRAINT fk_AcctCodeORCT FOREIGN KEY ([BpAct]) REFERENCES [dbo].[OACT] ([AcctCode])
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OVPM](
	[DocEntry] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DocNum] [int] NOT NULL,
	[DocType] [char](1) NULL,
	[Canceled] [char](1) NULL,	
	[DocDate] [datetime] NULL,
	[DocDueDate] [datetime] NULL,
	[CardCode] [nvarchar](15) NULL,
	[CardName] [nvarchar](100) NULL,
	[Address] [nvarchar](254) NULL,	
	[CashAcct] [nvarchar](15) NULL,
	[CashSum] [numeric](19, 6) NULL,
	[CashSumFC] [numeric](19, 6) NULL,
	[CreditSum] [numeric](19, 6) NULL,
	[CredSumFC] [numeric](19, 6) NULL,
	[CheckAcct] [nvarchar](15) NULL,
	[CheckSum] [numeric](19, 6) NULL,
	[CheckSumFC] [numeric](19, 6) NULL,
	[TrsfrAcct] [nvarchar](15) NULL,
	[TrsfrSum] [numeric](19, 6) NULL,
	[TrsfrSumFC] [numeric](19, 6) NULL,
	[TrsfrDate] [datetime] NULL,
	[TrsfrRef] [nvarchar](27) NULL,
	[PayNoDoc] [char](1) NULL,
	[NoDocSum] [numeric](19, 6) NULL,
	[NoDocSumFC] [numeric](19, 6) NULL,	
	[DiffCurr] [char](1) NULL,
	[DocRate] [numeric](19, 6) NULL,
	[SysRate] [numeric](19, 6) NULL,
	[DocTotal] [numeric](19, 6) NULL,
	[DocTotalFC] [numeric](19, 6) NULL,
	[Ref1] [nvarchar](11) NULL,	
	[CounterRef] [nvarchar](8) NULL,
	[Comments] [nvarchar](254) NULL,
	[JrnlMemo] [nvarchar](50) NULL,
	[TransId] [int] NULL,	
	[CntctCode] [int] NULL,	
	[CashSumSy] [numeric](19, 6) NULL,
	[CredSumSy] [numeric](19, 6) NULL,
	[CheckSumSy] [numeric](19, 6) NULL,
	[TrsfrSumSy] [numeric](19, 6) NULL,
	[NoDocSumSy] [numeric](19, 6) NULL,
	[DocTotalSy] [numeric](19, 6) NULL,
	[ObjType] [nvarchar](20) NULL,	
	[UpdateDate] [datetime] NULL,
	[CreateDate] [datetime] NULL,	
	[TaxDate] [datetime] NULL,	
	[DataSource] [char](1) NULL,
	[UserSign] [smallint] NULL,	
	[VatGroup] [nvarchar](8) NULL,
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFC] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[FinncPriod] [int] NULL,
	[VatPrcnt] [numeric](19, 6) NULL,		
	[WtCode] [nvarchar](4) NULL,
	[WtSum] [numeric](19, 6) NULL,
	[WtSumFrgn] [numeric](19, 6) NULL,
	[WtSumSys] [numeric](19, 6) NULL,
	[WtAccount] [nvarchar](15) NULL,
	[WtBaseAmnt] [numeric](19, 6) NULL,	
	[BpAct] [nvarchar](15) NULL,
	[BcgSum] [numeric](19, 6) NULL,
	[BcgSumFC] [numeric](19, 6) NULL,
	[BcgSumSy] [numeric](19, 6) NULL,	
	[WtBaseSum] [numeric](19, 6) NULL,
	[WtBaseSumF] [numeric](19, 6) NULL,
	[WtBaseSumS] [numeric](19, 6) NULL,	
	[VatDate] [datetime] NULL,	
	[CancelDate] [datetime] NULL,	
	[UserSign2] [smallint] NULL,	
	[U_IDA_TransIdDebit] [int] NULL,
	[U_IDA_TransIdDebAnu] [int] NULL,
	[U_IDA_CostingCode] [nvarchar](30) NULL,
	[U_NX_IdAsiento] [int] NULL,
	[U_NX_IdND] [int] NULL,
	[U_NX_IdNC] [int] NULL,
	[DocCurr] [nvarchar](3) NULL,
	CONSTRAINT fk_CardCodeOVPM FOREIGN KEY ([CardCode]) REFERENCES [dbo].[OCRD] ([CardCode]),
	CONSTRAINT fk_UserSignOVPM FOREIGN KEY ([UserSign]) REFERENCES [dbo].[OUSR] ([USERID]),
	CONSTRAINT fk_AcctCodeOVPM FOREIGN KEY ([BpAct]) REFERENCES [dbo].[OACT] ([AcctCode])
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RCT2](
	[DocNum] [int] NOT NULL,
	[InvoiceId] [int] NOT NULL,
	[DocEntry] [int] NULL,
	[SumApplied] [numeric](19, 6) NULL,
	[AppliedFC] [numeric](19, 6) NULL,
	[AppliedSys] [numeric](19, 6) NULL,
	[InvType] [nvarchar](20) NULL,
	[DocRate] [numeric](19, 6) NULL,	
	[DocLine] [int] NULL,
	[vatApplied] [numeric](19, 6) NULL,
	[vatAppldFC] [numeric](19, 6) NULL,
	[vatAppldSy] [numeric](19, 6) NULL,
	[selfInv] [char](1) NULL,
	[ObjType] [nvarchar](20) NULL,	
	[BfDcntSum] [numeric](19, 6) NULL,
	[BfDcntSumF] [numeric](19, 6) NULL,
	[BfDcntSumS] [numeric](19, 6) NULL,
	[BfNetDcnt] [numeric](19, 6) NULL,
	[BfNetDcntF] [numeric](19, 6) NULL,
	[BfNetDcntS] [numeric](19, 6) NULL,
	[PaidSum] [numeric](19, 6) NULL,	
	[WtAppld] [numeric](19, 6) NULL,
	[WtAppldFC] [numeric](19, 6) NULL,
	[WtAppldSC] [numeric](19, 6) NULL,	
	[WtInvCatS] [numeric](19, 6) NULL,
	[WtInvCatSF] [numeric](19, 6) NULL,
	[WtInvCatSS] [numeric](19, 6) NULL,	
	[DocTransId] [int] NULL,	
	[baseAbs] [int] NULL,
	[DocSubType] [nvarchar](2) NULL,	
	[U_IDA_CompIVA] [nvarchar](20) NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_MontoCompIVA] [numeric](19, 6) NULL,
	[U_IDA_CompISLR] [nvarchar](20) NULL,
	[U_IDA_DateCompISLR] [datetime] NULL,
	CONSTRAINT fk_DocEntryRCT2 FOREIGN KEY ([DocNum]) REFERENCES [dbo].[ORCT] ([DocEntry]),
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VPM2](
	[DocNum] [int] NOT NULL,
	[InvoiceId] [int] NOT NULL,
	[DocEntry] [int] NULL,
	[SumApplied] [numeric](19, 6) NULL,
	[AppliedFC] [numeric](19, 6) NULL,
	[AppliedSys] [numeric](19, 6) NULL,
	[InvType] [nvarchar](20) NULL,
	[DocRate] [numeric](19, 6) NULL,	
	[DocLine] [int] NULL,
	[vatApplied] [numeric](19, 6) NULL,
	[vatAppldFC] [numeric](19, 6) NULL,
	[vatAppldSy] [numeric](19, 6) NULL,
	[selfInv] [char](1) NULL,
	[ObjType] [nvarchar](20) NULL,	
	[BfDcntSum] [numeric](19, 6) NULL,
	[BfDcntSumF] [numeric](19, 6) NULL,
	[BfDcntSumS] [numeric](19, 6) NULL,
	[BfNetDcnt] [numeric](19, 6) NULL,
	[BfNetDcntF] [numeric](19, 6) NULL,
	[BfNetDcntS] [numeric](19, 6) NULL,
	[PaidSum] [numeric](19, 6) NULL,	
	[WtAppld] [numeric](19, 6) NULL,
	[WtAppldFC] [numeric](19, 6) NULL,
	[WtAppldSC] [numeric](19, 6) NULL,	
	[WtInvCatS] [numeric](19, 6) NULL,
	[WtInvCatSF] [numeric](19, 6) NULL,
	[WtInvCatSS] [numeric](19, 6) NULL,	
	[DocTransId] [int] NULL,	
	[baseAbs] [int] NULL,
	[DocSubType] [nvarchar](2) NULL,	
	[U_IDA_CompIVA] [nvarchar](20) NULL,
	[U_IDA_FechaComp] [datetime] NULL,
	[U_IDA_MontoCompIVA] [numeric](19, 6) NULL,
	[U_IDA_CompISLR] [nvarchar](20) NULL,
	[U_IDA_DateCompISLR] [datetime] NULL,
	CONSTRAINT fk_DocEntryVPM2 FOREIGN KEY ([DocNum]) REFERENCES [dbo].[OVPM] ([DocEntry]),
 )

 SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INV3](
	[DocEntry] [int] NOT NULL,
	[ExpnsCode] [int] NULL,
	[LineTotal] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,
	[Comments] [nvarchar](100) NULL,
	[ObjType] [nvarchar](20) NULL,
	[LogInstanc] [int] NULL,
	[DistrbMthd] [char](1) NULL,
	[TaxStatus] [char](1) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,
	[IsAcquistn] [char](1) NULL,
	[TaxCode] [nvarchar](8) NULL,
	[TaxType] [char](1) NULL,
	[WTLiable] [char](1) NULL,
	[VatApplied] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[EquVatPer] [numeric](19, 6) NULL,
	[EquVatSum] [numeric](19, 6) NULL,
	[EquVatSumF] [numeric](19, 6) NULL,
	[EquVatSumS] [numeric](19, 6) NULL,
	[LineVat] [numeric](19, 6) NULL,
	[LineVatF] [numeric](19, 6) NULL,
	[LineVatS] [numeric](19, 6) NULL,
	[BaseMethod] [char](1) NULL,
	[Stock] [char](1) NULL,
	[LstPchPrce] [char](1) NULL,
	[AnalysRpt] [char](1) NULL,
	[BaseAbsEnt] [int] NULL,
	[BaseType] [int] NULL,
	[BaseRef] [int] NULL,
	[BaseLnNum] [int] NULL,
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[TrgType] [int] NULL,
	[TrgAbsEnt] [int] NULL,
	[StDstr] [numeric](19, 6) NULL,
	[StDstrSC] [numeric](19, 6) NULL,
	[StDstrFC] [numeric](19, 6) NULL,
	[FixCurr] [nvarchar](3) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[OcrCode] [nvarchar](8) NULL,
	[TaxDistMtd] [char](1) NULL,
	[OcrCode2] [nvarchar](8) NULL,
	[OcrCode3] [nvarchar](8) NULL,
	[OcrCode4] [nvarchar](8) NULL,
	[OcrCode5] [nvarchar](8) NULL,
	[Project] [nvarchar](20) NULL,
	[VatGrpSrc] [char](1) NULL,
	[DrawnTotal] [numeric](19, 6) NULL,
	[DrawnFC] [numeric](19, 6) NULL,
	[DrawnSC] [numeric](19, 6) NULL,
	[GrsAmount] [numeric](19, 6) NULL,
	[GrsFC] [numeric](19, 6) NULL,
	[GrsSC] [numeric](19, 6) NULL,
	[BaseTotal] [char](1) NULL,
	[RetReqLC] [numeric](19, 6) NULL,
	[RetReqFC] [numeric](19, 6) NULL,
	[RetReqSC] [numeric](19, 6) NULL,
	[RRVatLC] [numeric](19, 6) NULL,
	[RRVatFC] [numeric](19, 6) NULL,
	[RRVatSC] [numeric](19, 6) NULL,
CONSTRAINT fk_INV3_PRIMARY FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[OINV] ([DocEntry]),
)
GO
/****** Object:  Table [dbo].[PCH3]    Script Date: 15/6/2020 5:30:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PCH3](
	[DocEntry] [int] NOT NULL,
	[ExpnsCode] [int] NULL,
	[LineTotal] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,
	[Comments] [nvarchar](100) NULL,
	[ObjType] [nvarchar](20) NULL,
	[LogInstanc] [int] NULL,
	[DistrbMthd] [char](1) NULL,
	[TaxStatus] [char](1) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,
	[IsAcquistn] [char](1) NULL,
	[TaxCode] [nvarchar](8) NULL,
	[TaxType] [char](1) NULL,
	[WTLiable] [char](1) NULL,
	[VatApplied] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[EquVatPer] [numeric](19, 6) NULL,
	[EquVatSum] [numeric](19, 6) NULL,
	[EquVatSumF] [numeric](19, 6) NULL,
	[EquVatSumS] [numeric](19, 6) NULL,
	[LineVat] [numeric](19, 6) NULL,
	[LineVatF] [numeric](19, 6) NULL,
	[LineVatS] [numeric](19, 6) NULL,
	[BaseMethod] [char](1) NULL,
	[Stock] [char](1) NULL,
	[LstPchPrce] [char](1) NULL,
	[AnalysRpt] [char](1) NULL,
	[BaseAbsEnt] [int] NULL,
	[BaseType] [int] NULL,
	[BaseRef] [int] NULL,
	[BaseLnNum] [int] NULL,
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[TrgType] [int] NULL,
	[TrgAbsEnt] [int] NULL,
	[StDstr] [numeric](19, 6) NULL,
	[StDstrSC] [numeric](19, 6) NULL,
	[StDstrFC] [numeric](19, 6) NULL,
	[FixCurr] [nvarchar](3) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[OcrCode] [nvarchar](8) NULL,
	[TaxDistMtd] [char](1) NULL,
	[OcrCode2] [nvarchar](8) NULL,
	[OcrCode3] [nvarchar](8) NULL,
	[OcrCode4] [nvarchar](8) NULL,
	[OcrCode5] [nvarchar](8) NULL,
	[Project] [nvarchar](20) NULL,
	[VatGrpSrc] [char](1) NULL,
	[DrawnTotal] [numeric](19, 6) NULL,
	[DrawnFC] [numeric](19, 6) NULL,
	[DrawnSC] [numeric](19, 6) NULL,
	[GrsAmount] [numeric](19, 6) NULL,
	[GrsFC] [numeric](19, 6) NULL,
	[GrsSC] [numeric](19, 6) NULL,
	[BaseTotal] [char](1) NULL,
	[RetReqLC] [numeric](19, 6) NULL,
	[RetReqFC] [numeric](19, 6) NULL,
	[RetReqSC] [numeric](19, 6) NULL,
	[RRVatLC] [numeric](19, 6) NULL,
	[RRVatFC] [numeric](19, 6) NULL,
	[RRVatSC] [numeric](19, 6) NULL,
CONSTRAINT fk_PCH3_PRIMARY FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[OPCH] ([DocEntry]),
)
GO
/****** Object:  Table [dbo].[RIN3]    Script Date: 15/6/2020 5:30:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RIN3](
	[DocEntry] [int] NOT NULL,
	[ExpnsCode] [int] NULL,
	[LineTotal] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,
	[Comments] [nvarchar](100) NULL,
	[ObjType] [nvarchar](20) NULL,
	[LogInstanc] [int] NULL,
	[DistrbMthd] [char](1) NULL,
	[TaxStatus] [char](1) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,
	[IsAcquistn] [char](1) NULL,
	[TaxCode] [nvarchar](8) NULL,
	[TaxType] [char](1) NULL,
	[WTLiable] [char](1) NULL,
	[VatApplied] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[EquVatPer] [numeric](19, 6) NULL,
	[EquVatSum] [numeric](19, 6) NULL,
	[EquVatSumF] [numeric](19, 6) NULL,
	[EquVatSumS] [numeric](19, 6) NULL,
	[LineVat] [numeric](19, 6) NULL,
	[LineVatF] [numeric](19, 6) NULL,
	[LineVatS] [numeric](19, 6) NULL,
	[BaseMethod] [char](1) NULL,
	[Stock] [char](1) NULL,
	[LstPchPrce] [char](1) NULL,
	[AnalysRpt] [char](1) NULL,
	[BaseAbsEnt] [int] NULL,
	[BaseType] [int] NULL,
	[BaseRef] [int] NULL,
	[BaseLnNum] [int] NULL,
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[TrgType] [int] NULL,
	[TrgAbsEnt] [int] NULL,
	[StDstr] [numeric](19, 6) NULL,
	[StDstrSC] [numeric](19, 6) NULL,
	[StDstrFC] [numeric](19, 6) NULL,
	[FixCurr] [nvarchar](3) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[OcrCode] [nvarchar](8) NULL,
	[TaxDistMtd] [char](1) NULL,
	[OcrCode2] [nvarchar](8) NULL,
	[OcrCode3] [nvarchar](8) NULL,
	[OcrCode4] [nvarchar](8) NULL,
	[OcrCode5] [nvarchar](8) NULL,
	[Project] [nvarchar](20) NULL,
	[VatGrpSrc] [char](1) NULL,
	[DrawnTotal] [numeric](19, 6) NULL,
	[DrawnFC] [numeric](19, 6) NULL,
	[DrawnSC] [numeric](19, 6) NULL,
	[GrsAmount] [numeric](19, 6) NULL,
	[GrsFC] [numeric](19, 6) NULL,
	[GrsSC] [numeric](19, 6) NULL,
	[BaseTotal] [char](1) NULL,
	[RetReqLC] [numeric](19, 6) NULL,
	[RetReqFC] [numeric](19, 6) NULL,
	[RetReqSC] [numeric](19, 6) NULL,
	[RRVatLC] [numeric](19, 6) NULL,
	[RRVatFC] [numeric](19, 6) NULL,
	[RRVatSC] [numeric](19, 6) NULL,
CONSTRAINT fk_RIN3_PRIMARY FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[ORIN] ([DocEntry]),
)
GO
/****** Object:  Table [dbo].[RPC3]    Script Date: 15/6/2020 5:30:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPC3](
	[DocEntry] [int] NOT NULL,
	[ExpnsCode] [int] NULL,
	[LineTotal] [numeric](19, 6) NULL,
	[TotalFrgn] [numeric](19, 6) NULL,
	[TotalSumSy] [numeric](19, 6) NULL,
	[PaidToDate] [numeric](19, 6) NULL,
	[PaidFC] [numeric](19, 6) NULL,
	[PaidSys] [numeric](19, 6) NULL,
	[Comments] [nvarchar](100) NULL,
	[ObjType] [nvarchar](20) NULL,
	[LogInstanc] [int] NULL,
	[DistrbMthd] [char](1) NULL,
	[TaxStatus] [char](1) NULL,
	[VatGroup] [nvarchar](8) NULL,
	[VatPrcnt] [numeric](19, 6) NULL,
	[VatSum] [numeric](19, 6) NULL,
	[VatSumFrgn] [numeric](19, 6) NULL,
	[VatSumSy] [numeric](19, 6) NULL,
	[DedVatSum] [numeric](19, 6) NULL,
	[DedVatSumF] [numeric](19, 6) NULL,
	[DedVatSumS] [numeric](19, 6) NULL,
	[IsAcquistn] [char](1) NULL,
	[TaxCode] [nvarchar](8) NULL,
	[TaxType] [char](1) NULL,
	[WTLiable] [char](1) NULL,
	[VatApplied] [numeric](19, 6) NULL,
	[VatAppldFC] [numeric](19, 6) NULL,
	[VatAppldSC] [numeric](19, 6) NULL,
	[EquVatPer] [numeric](19, 6) NULL,
	[EquVatSum] [numeric](19, 6) NULL,
	[EquVatSumF] [numeric](19, 6) NULL,
	[EquVatSumS] [numeric](19, 6) NULL,
	[LineVat] [numeric](19, 6) NULL,
	[LineVatF] [numeric](19, 6) NULL,
	[LineVatS] [numeric](19, 6) NULL,
	[BaseMethod] [char](1) NULL,
	[Stock] [char](1) NULL,
	[LstPchPrce] [char](1) NULL,
	[AnalysRpt] [char](1) NULL,
	[BaseAbsEnt] [int] NULL,
	[BaseType] [int] NULL,
	[BaseRef] [int] NULL,
	[BaseLnNum] [int] NULL,
	[LineNum] [int] NOT NULL,
	[Status] [char](1) NULL,
	[TrgType] [int] NULL,
	[TrgAbsEnt] [int] NULL,
	[StDstr] [numeric](19, 6) NULL,
	[StDstrSC] [numeric](19, 6) NULL,
	[StDstrFC] [numeric](19, 6) NULL,
	[FixCurr] [nvarchar](3) NULL,
	[VatDscntPr] [numeric](19, 6) NULL,
	[OcrCode] [nvarchar](8) NULL,
	[TaxDistMtd] [char](1) NULL,
	[OcrCode2] [nvarchar](8) NULL,
	[OcrCode3] [nvarchar](8) NULL,
	[OcrCode4] [nvarchar](8) NULL,
	[OcrCode5] [nvarchar](8) NULL,
	[Project] [nvarchar](20) NULL,
	[VatGrpSrc] [char](1) NULL,
	[DrawnTotal] [numeric](19, 6) NULL,
	[DrawnFC] [numeric](19, 6) NULL,
	[DrawnSC] [numeric](19, 6) NULL,
	[GrsAmount] [numeric](19, 6) NULL,
	[GrsFC] [numeric](19, 6) NULL,
	[GrsSC] [numeric](19, 6) NULL,
	[BaseTotal] [char](1) NULL,
	[RetReqLC] [numeric](19, 6) NULL,
	[RetReqFC] [numeric](19, 6) NULL,
	[RetReqSC] [numeric](19, 6) NULL,
	[RRVatLC] [numeric](19, 6) NULL,
	[RRVatFC] [numeric](19, 6) NULL,
	[RRVatSC] [numeric](19, 6) NULL,
 CONSTRAINT fk_RPC3_PRIMARY FOREIGN KEY ([DocEntry]) REFERENCES [dbo].[ORPC] ([DocEntry]),
)

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OITR](
	[ReconNum] [int] NOT NULL IDENTITY(1,1),
	[IsCard] [char](1) NULL,
	[ReconType] [nvarchar](2) NULL,
	[ReconDate] [datetime] NULL,
	[Total] [numeric](19, 6) NULL,
	[ReconCurr] [nvarchar](3) NULL,
	[Canceled] [char](1) NULL,
	[CancelAbs] [int] NULL,
	[IsSystem] [char](1) NULL,
	[InitObjTyp] [nvarchar](20) NULL,
	[InitObjAbs] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateTime] [smallint] NULL,
	[DataSource] [char](1) NULL,
	[UserSign] [smallint] NULL,
	[ReconRule1] [nvarchar](2) NULL,
	[ReconRule2] [nvarchar](2) NULL,
	[ReconRule3] [nvarchar](2) NULL,
	[IsMultiBP] [char](1) NULL,
	[VersionNum] [nvarchar](11) NULL,
	[OldMatNum] [int] NULL,
	[ReconJEId] [int] NULL,
	[BuildDesc] [nvarchar](50) NULL,
	[BPLId] [int] NULL,
	[BPLName] [nvarchar](100) NULL,
	[VATRegNum] [nvarchar](32) NULL,
	[IsElectr] [char](1) NULL,
	[CreateTS] [int] NULL,
	[UpdateTS] [int] NULL,
	[ObjType] [nvarchar](20) NULL,
	constraint pk_OITR primary key (ReconNum),

	)

GO
/****** Object:  Table [dbo].[ITR1]    Script Date: 27/6/2020 3:18:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITR1](
	[ReconNum] [int] NOT NULL,
	[LineSeq] [int] NOT NULL,
	[ShortName] [nvarchar](15) NULL,
	[TransId] [int] NULL,
	[TransRowId] [int] NULL,
	[SrcObjTyp] [nvarchar](20) NULL,
	[SrcObjAbs] [int] NULL,
	[ReconSum] [numeric](19, 6) NULL,
	[ReconSumFC] [numeric](19, 6) NULL,
	[ReconSumSC] [numeric](19, 6) NULL,
	[FrgnCurr] [nvarchar](3) NULL,
	[SumMthCurr] [numeric](19, 6) NULL,
	[IsCredit] [char](1) NULL,
	[Account] [nvarchar](15) NULL,
	[CashDisSum] [numeric](19, 6) NULL,
	[WTSum] [numeric](19, 6) NULL,
	[WTSumFC] [numeric](19, 6) NULL,
	[WTSumSC] [numeric](19, 6) NULL,
	[ExpSum] [numeric](19, 6) NULL,
	[ExpSumFC] [numeric](19, 6) NULL,
	[ExpSumSC] [numeric](19, 6) NULL,
	[netBefDisc] [numeric](19, 6) NULL,
	[MIEntry] [int] NULL,
	[MIType] [nvarchar](20) NULL,
	[InstID] [int] NULL,
	constraint pk_ITR1 primary key (ReconNum, LineSeq),
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddUser]
@User nvarchar(20), 
@Password nvarchar(max),
@FullName nvarchar(20),
@Locked char
AS

BEGIN

INSERT INTO OUSR (U_NAME, USER_CODE, PASSWORD, Locked) values (@FullName, @User, @Password, @Locked)

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SocietyDates]
@Society nvarchar(max), 
@UpdateDate datetime,
@User smallint
AS

BEGIN

INSERT INTO OADM(CompnyName,UpdateDate,UserSign) values (@Society,@UpdateDate,@User)

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetUserCode]
@User nvarchar(25)
AS

BEGIN

SELECT USERID FROM OUSR WHERE USER_CODE=@User

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddPeriods]
@PeriodCat nvarchar(10), 
@FinancYear datetime,
@Year smallint, 
@PeriodName nvarchar(20), 
@SubType char(1),
@PeriodNum int, 
@F_RefDate datetime, 
@T_RefDate datetime, 
@F_DueDate datetime, 
@T_DueDate datetime, 
@F_TaxDate datetime, 
@T_TaxDate datetime,  
@UpdateDate datetime, 
@UserSign smallint 
AS

BEGIN

INSERT INTO OACP(PeriodCat,FinancYear,Year,PeriodName,SubType, PeriodNum, F_RefDate, T_RefDate, F_DueDate,T_DueDate, F_TaxDate, T_TaxDate, UpdateDate, UserSign ) values (@PeriodCat,@FinancYear,@Year,@PeriodName,@SubType,@PeriodNum,@F_RefDate,@T_RefDate,@F_DueDate,@T_DueDate,@F_TaxDate,@T_TaxDate,@UpdateDate,@UserSign)

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddSubPeriods]
@Code nvarchar(20), 
@Name nvarchar(20),
@F_RefDate datetime, 
@T_RefDate datetime, 
@F_DueDate datetime, 
@T_DueDate datetime, 
@F_TaxDate datetime, 
@T_TaxDate datetime,  
@UserSign smallint,
@SubNum int,
@Category nvarchar(10),
@UpdateDate datetime,
@PeriodStat char,
@UserSign2 smallint
AS

BEGIN

INSERT INTO OFPR(Code,Name,F_RefDate, T_RefDate, F_DueDate,T_DueDate, F_TaxDate, T_TaxDate, UserSign, SubNum, Category, UpdateDate, PeriodStat, UserSign2 ) values (@Code,@Name,@F_RefDate,@T_RefDate,@F_DueDate,@T_DueDate,@F_TaxDate,@T_TaxDate,@UserSign, @SubNum,@Category,@UpdateDate,@PeriodStat,@UserSign2)

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddUpdateCurency]

@OldCurrCode nvarchar(3),
@CurrCode nvarchar(3), 
@CurrName nvarchar(20),
@DocCurrCod nvarchar(3), 
@UserSign smallint,
@Locked char(1)

AS

BEGIN

IF EXISTS (SELECT * FROM OCRN WHERE CurrCode=@OldCurrCode)
BEGIN
UPDATE OCRN SET CurrCode=@CurrCode, CurrName=@CurrName, DocCurrCod=@DocCurrCod, UserSign2=@UserSign WHERE CurrCode=@OldCurrCode
END
ELSE
BEGIN
INSERT INTO OCRN(CurrCode,CurrName,DocCurrCod, UserSign, Locked) VALUES (@CurrCode,@CurrName,@DocCurrCod,@UserSign,@Locked)
END
END


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteCurency]
@CurrCode nvarchar(3)
AS

BEGIN

DECLARE @CurrencyOJDT int
DECLARE @CurrencyJDT1 int
DECLARE @CurrencyOCRD int
DECLARE @CurrencyOPCH int
DECLARE @CurrencyPCH1 int
DECLARE @CurrencyOINV int
DECLARE @CurrencyINV1 int
DECLARE @CurrencyORPC int
DECLARE @CurrencyRPC1 int
DECLARE @CurrencyORIN int
DECLARE @CurrencyRIN1 int
DECLARE @CurrencyOPDN int
DECLARE @CurrencyPDN1 int
DECLARE @CurrencyODLN int
DECLARE @CurrencyDLN1 int
DECLARE @CurrencyMainCurrency int
DECLARE @CurrencySysCurrency int
DECLARE @CurrencyOACT int
DECLARE @Result int

SET @CurrencyOJDT = (SELECT COUNT(TransCurr) FROM OJDT WHERE TransCurr=@CurrCode)
SET @CurrencyJDT1 = (SELECT COUNT(FCCurrency) FROM JDT1 WHERE FCCurrency=@CurrCode)
SET @CurrencyOCRD = (SELECT COUNT(Currency) FROM OCRD WHERE Currency=@CurrCode)
SET @CurrencyOPCH = (SELECT COUNT(DocCur) FROM OPCH WHERE DocCur=@CurrCode)
SET @CurrencyPCH1 = (SELECT COUNT(Currency) FROM PCH1 WHERE Currency=@CurrCode)
SET @CurrencyOINV = (SELECT COUNT(DocCur) FROM ORIN WHERE DocCur=@CurrCode)
SET @CurrencyINV1 = (SELECT COUNT(Currency) FROM INV1 WHERE Currency=@CurrCode)
SET @CurrencyORPC = (SELECT COUNT(DocCur) FROM ORPC WHERE DocCur=@CurrCode)
SET @CurrencyRPC1 = (SELECT COUNT(Currency) FROM RPC1 WHERE Currency=@CurrCode)
SET @CurrencyORIN = (SELECT COUNT(DocCur) FROM ORIN WHERE DocCur=@CurrCode)
SET @CurrencyRIN1 = (SELECT COUNT(Currency) FROM RIN1 WHERE Currency=@CurrCode)
SET @CurrencyOPDN = (SELECT COUNT(DocCur) FROM OPDN WHERE DocCur=@CurrCode)
SET @CurrencyPDN1 = (SELECT COUNT(Currency) FROM PDN1 WHERE Currency=@CurrCode)
SET @CurrencyODLN = (SELECT COUNT(DocCur) FROM ODLN WHERE DocCur=@CurrCode)
SET @CurrencyDLN1 = (SELECT COUNT(Currency) FROM DLN1 WHERE Currency=@CurrCode)
SET @CurrencyMainCurrency = (SELECT COUNT(MainCurncy) FROM OADM WHERE MainCurncy=@CurrCode)
SET @CurrencySysCurrency = (SELECT COUNT(SysCurrncy) FROM OADM WHERE SysCurrncy=@CurrCode)
SET @CurrencyOACT = (SELECT COUNT(ActCurr) FROM OACT WHERE ActCurr=@CurrCode)

SET @Result=@CurrencyDLN1+@CurrencyINV1+@CurrencyJDT1+@CurrencyMainCurrency+@CurrencyOACT+@CurrencyOCRD+@CurrencyODLN+@CurrencyOINV+@CurrencyOJDT+@CurrencyOPCH+@CurrencyOPDN+@CurrencyORIN+@CurrencyORPC+@CurrencyPCH1+@CurrencyPDN1+@CurrencyRIN1+@CurrencyRPC1+@CurrencySysCurrency

IF (@Result=0)
BEGIN
DELETE FROM OCRN WHERE CurrCode=@CurrCode
END
END

GO
/****** Object:  StoredProcedure [dbo].[AddSubPeriods]    Script Date: 29/3/2020 5:11:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateSubPeriods]
@OldCode nvarchar(20), 
@Code nvarchar(20), 
@Name nvarchar(20),
@F_RefDate datetime, 
@T_RefDate datetime, 
@F_DueDate datetime, 
@T_DueDate datetime, 
@F_TaxDate datetime, 
@T_TaxDate datetime,  
@UpdateDate datetime,
@PeriodStat char,
@UserSign2 smallint
AS

BEGIN

UPDATE OFPR SET Code=@Code, Name=@Name,F_RefDate=@F_RefDate, T_RefDate=@T_RefDate, F_DueDate=@F_DueDate,T_DueDate=@T_DueDate, F_TaxDate=@F_TaxDate, T_TaxDate=@T_TaxDate, UserSign2=@UserSign2,UpdateDate=@UpdateDate, PeriodStat=@PeriodStat WHERE Code=@OldCode

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetFinancYear]
@Category nvarchar(20)
AS

BEGIN

SELECT DISTINCT FinancYear FROM OACP T0 LEFT JOIN OFPR T1 ON T0.Year=T1.Category WHERE T1.Category=@Category

END

GO
/****** Object:  StoredProcedure [dbo].[UpdateSociety]    Script Date: 6/4/2020 6:05:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateSociety]
@CompnyName nvarchar(100), 
@CompnyAddr nvarchar(254),
@Country nvarchar(3), 
@PrintHeadr nvarchar(100), 
@Phone1 nvarchar(20), 
@Phone2 nvarchar(20), 
@ZipCode int,
@Fax nvarchar(20), 
@E_Mail nvarchar(100),  
@MainCurncy nvarchar(3),
@SysCurrncy nvarchar(3),
@TaxIdNum nvarchar(32),
@RevOffice nvarchar(100),
@UpdateDate datetime,
@UserSign smallint
AS

BEGIN

UPDATE OADM SET CompnyName=@CompnyName,CompnyAddr=@CompnyAddr,ZipCode=@ZipCode,Country=@Country, E_Mail=@E_Mail, PrintHeadr=@PrintHeadr,Phone1=@Phone1, Phone2=@Phone2, Fax=@Fax, MainCurncy=@MainCurncy,SysCurrncy=@SysCurrncy, TaxIdNum=@TaxIdNum, RevOffice=@RevOffice, UpdateDate=@UpdateDate, UserSign=@UserSign

END

GO
/****** Object:  StoredProcedure [dbo].[AddUpdateNroComprobante]    Script Date: 6/4/2020 6:06:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddUpdateNroComprobante]
@OldCode nvarchar(50),
@Code nvarchar(50), 
@NombreSerie nvarchar(50),
@Descripcion nvarchar(100), 
@UserSign smallint,
@TipoSerie nvarchar(10),
@Inicio nvarchar(15),
@Siguiente nvarchar(15),
@Fin nvarchar(15),
@Activo nvarchar(10),
@UpdateDate datetime

AS

BEGIN

IF EXISTS (SELECT * FROM NRO_COMPROBANTE WHERE Code=@OldCode)
BEGIN
UPDATE NRO_COMPROBANTE SET Code=@Code, NombreSerie=@NombreSerie, Descripcion=@Descripcion, UserSign=@UserSign, TipoSerie=@TipoSerie, Inicio=@Inicio, Siguiente=@Siguiente, Fin=@Fin, Activo=@Activo, UpdateDate=@UpdateDate WHERE Code=@OldCode
END
ELSE
BEGIN
INSERT INTO NRO_COMPROBANTE(Code,NombreSerie,Descripcion, UserSign, TipoSerie, Inicio, Siguiente, Fin, Activo, UpdateDate, Canceled) VALUES (@Code,@NombreSerie,@Descripcion,@UserSign,@TipoSerie, @Inicio, @Siguiente, @Fin, @Activo, @UpdateDate, 'N')
END
END


GO
/****** Object:  StoredProcedure [dbo].[AddUpdateNroComprobante]    Script Date: 6/4/2020 6:06:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddAccountFirstLevels]
@UserSign smallint
AS

BEGIN
INSERT INTO OACT(AcctCode,AcctName,CurrTotal,Finanse,Postable,Levels,GrpLine,ActType,SysTotal,FcTotal,Advance,CreateDate,UserSign,LocManTran, FatherNum, GroupMask) VALUES ('100000000000000','Activos',0,'N','N',1,1,'N',0,0,'Y',GETDATE(),@UserSign,'N','0',1)
INSERT INTO OACT(AcctCode,AcctName,CurrTotal,Finanse,Postable,Levels,GrpLine,ActType,SysTotal,FcTotal,Advance,CreateDate,UserSign,LocManTran, FatherNum, GroupMask) VALUES ('200000000000000','Pasivos',0,'N','N',1,1,'N',0,0,'Y',GETDATE(),@UserSign,'N','0',2)
INSERT INTO OACT(AcctCode,AcctName,CurrTotal,Finanse,Postable,Levels,GrpLine,ActType,SysTotal,FcTotal,Advance,CreateDate,UserSign,LocManTran, FatherNum, GroupMask) VALUES ('300000000000000','Patrimonio',0,'N','N',1,1,'N',0,0,'Y',GETDATE(),@UserSign,'N','0',3)
INSERT INTO OACT(AcctCode,AcctName,CurrTotal,Finanse,Postable,Levels,GrpLine,ActType,SysTotal,FcTotal,Advance,CreateDate,UserSign,LocManTran, FatherNum, GroupMask) VALUES ('400000000000000','Ingresos',0,'N','N',1,1,'N',0,0,'Y',GETDATE(),@UserSign,'N','0',4)
INSERT INTO OACT(AcctCode,AcctName,CurrTotal,Finanse,Postable,Levels,GrpLine,ActType,SysTotal,FcTotal,Advance,CreateDate,UserSign,LocManTran, FatherNum, GroupMask) VALUES ('500000000000000','Gastos',0,'N','N',1,1,'N',0,0,'Y',GETDATE(),@UserSign,'N','0',5)
INSERT INTO OACT(AcctCode,AcctName,CurrTotal,Finanse,Postable,Levels,GrpLine,ActType,SysTotal,FcTotal,Advance,CreateDate,UserSign,LocManTran, FatherNum, GroupMask) VALUES ('600000000000000','Gastos Operacionales',0,'N','N',1,1,'N',0,0,'Y',GETDATE(),@UserSign,'N','0',6)
INSERT INTO OACT(AcctCode,AcctName,CurrTotal,Finanse,Postable,Levels,GrpLine,ActType,SysTotal,FcTotal,Advance,CreateDate,UserSign,LocManTran, FatherNum, GroupMask) VALUES ('700000000000000','Otros Ingresos',0,'N','N',1,1,'N',0,0,'Y',GETDATE(),@UserSign,'N','0',7)
INSERT INTO OACT(AcctCode,AcctName,CurrTotal,Finanse,Postable,Levels,GrpLine,ActType,SysTotal,FcTotal,Advance,CreateDate,UserSign,LocManTran, FatherNum, GroupMask) VALUES ('800000000000000','Otros Gastos',0,'N','N',1,1,'N',0,0,'Y',GETDATE(),@UserSign,'N','0',8)

END

GO
/****** Object:  StoredProcedure [dbo].[AddUpdateNroComprobante]    Script Date: 6/4/2020 6:06:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddCurencyBasic]
@UserSign smallint
AS

BEGIN
INSERT INTO OCRN(CurrCode,CurrName, DocCurrCod,Locked,UserSign) VALUES ('USD','Dolar Americano','USD','N',@UserSign)
INSERT INTO OCRN(CurrCode,CurrName, DocCurrCod,Locked,UserSign) VALUES ('EUR','Euros','EUR','N',@UserSign)
INSERT INTO OCRN(CurrCode,CurrName, DocCurrCod,Locked,UserSign) VALUES ('VES','Bolivar Sobernano','VES','N',@UserSign)

END

GO
/****** Object:  StoredProcedure [dbo].[AddUpdateNroComprobante]    Script Date: 6/4/2020 6:06:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddRetencionImpuesto]
@UserSign smallint
AS

BEGIN
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C01', 'C-Retenci�n IVA 75%', CAST(75.000000 AS Numeric(19, 6)),GETDATE(),'P','V', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','IVA', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C02', 'C-Retenci�n IVA 100%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','V', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','IVA', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C03', 'C-Honorarios profesionales PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C04', 'C-Honorarios profesionales PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C05', 'C-Honorarios Profesionales PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C06', 'C-Honorarios Profesionales PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C07', 'C-Preparadores de Animales PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C08', 'C-Preparadores de Animales PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C09', 'C-Honorarios Prof. En Clinicas PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C10', 'C-Honorarios Prof. En Clinicas PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C11', 'C-Comisiones Enajenaci�n Inmuebles PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C12', 'C-Comisiones Enajenaci�n Inmuebles PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C13', 'C-Comisiones Enajenaci�n Inmuebles PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C14', 'C-Comisiones Enajenaci�n Inmuebles PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C15', 'C-Comisiones Mercantiles PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C16', 'C-Comisiones Mercantiles PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C17', 'C-Comisiones Mercantiles PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C18', 'C-Comisiones Mercantiles PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C19', 'C-Intereses ART N� 27 #2 L.I.S.R. PNND 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C20', 'C-Intereses ART N� 27 #2 L.I.S.R. PNNR  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C21', 'C-Intereses ART N� 53 Par 1� PJND 4.95%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(4.950000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C22', 'C-Intereses PNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C23', 'C-Intereses PJND 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C24', 'C-Intereses PNNR  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C25', 'C-Intereses PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C26', 'C-Agencias de Noticias internacional PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C27', 'C-Fletes y Gastos de Transporte Internac. PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C28', 'C-Fletes en el Pa�s a Emp. Internac. PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C29', 'C-Exhibici�n de Pel�culas ART 27 #15 PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C30', 'C-Exhibici�n de Pel�culas ART 27 #15 PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C31', 'C-Regal�as ART 27 #16 PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C32', 'C-Regal�as ART 27 #16 PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C33', 'C-Asistenc�a T�cnica ART 27 #16 PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C34', 'C-Asistenc�a T�cnica ART 27 #16 PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C35', 'C-Servicios Tecnol�gicos PJND 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C36', 'C-Servicios Tecnol�gicos PNNR  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C37', 'C-Primas de Seguro-Reaseg. ART27 #18 PJND 10%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(10.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C38', 'C-Ganancias S/Juegos y Apuestas PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C39', 'C-Ganancias S/Juegos y Apuestas PNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C40', 'C-Ganancias S/Juegos y Apuestas PJND 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C41', 'C-Ganancias S/Juegos y Apuestas PJD 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C42', 'C-Premios Lot. E Hip. ART 65 y 66 PNNR 16%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(16.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C43', 'C-Premios Lot. E Hip. ART 65 y 66 PNR 16%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(16.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C44', 'C-Premios Lot. E Hip. ART 65 y 66 PJND 16%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(16.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C45', 'C-Premios Lot. E Hip. ART 65 y 66 PJD 16%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(16.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C46', 'C-Premios de Animales de Carrera PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C47', 'C-Premios de Animales de Carrera PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C48', 'C-Premios de Animales de Carrera PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C49', 'C-Premios de Animales de Carrera PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C50', 'C-Servicios (Incluye Suministro Bienes) PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C51', 'C-Servicios (Incluye Suministro Bienes) PNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(4166.670000 AS Numeric(19, 6)), CAST(41.670000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C52', 'C-Servicios (Incluye Suministro Bienes) PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C53', 'C-Servicios (Incluye Suministro Bienes) PJD 2%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(2.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C54', 'C-Arrendamiento de Bienes Inmuebles PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C55', 'C-Arrendamiento de Bienes Inmuebles PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C56', 'C-Arrendamiento de Bienes Inmuebles PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C57', 'C-Arrendamiento de Bienes Inmuebles PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C58', 'C-Arrendamiento de Bienes Muebles PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C59', 'C-Arrendamiento de Bienes Muebles PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C60', 'C-Arrendamiento de Bienes Muebles PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C61', 'C-Arrendamiento de Bienes Muebles PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C62', 'C-Pagos de Tarjeta de Cr�dito PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C63', 'C-Pagos de Tarjeta de Cr�dito PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C64', 'C-Pagos de Tarjeta de Cr�dito PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C65', 'C-Pagos de Tarjeta de Cr�dito PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C66', 'C-Venta de Gasolina con T. Cr�dito PNNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C67', 'C-Venta de Gasolina con T. Cr�dito PJND 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C68', 'C-Fletes y Gastos de Transporte Nacional PNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C69', 'C-Fletes y Gastos de Transporte Nacional PJD 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C70', 'C-Pago de Emp. De Seguro a Corredores PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C71', 'C-Pago de Emp. De Seguro a Corredores PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C72', 'C-Pago Rep. Bienes y Atenc. Hosp Aseg. PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C73', 'C-Pago Rep. Bienes y Atenc. Hosp Aseg. PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C74', 'C-Venta de Fondos de Comercio PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C75', 'C-Venta de Fondos de Comercio PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C76', 'C-Venta de Fondos de Comercio PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C77', 'C-Venta de Fondos de Comercio PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C78', 'C-Publicidad y Propaganda PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C79', 'C-Publicidad y Propaganda PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C80', 'C-Publicidad y Propaganda PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C81', 'C-Publicidad y Propaganda Radio PJD 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C82', 'C-Venta de Acciones en Bolsa PNNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C83', 'C-Venta de Acciones en Bolsa PNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C84', 'C-Venta de Acciones en Bolsa PJND 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C85', 'C-Venta de Acciones en Bolsa PJD 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C86', 'C-Venta de Acciones Fuera de Bolsa PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C87', 'C-Venta de Acciones Fuera de Bolsa PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C88', 'C-Venta de Acciones Fuera de Bolsa PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('C89', 'C-Venta de Acciones Fuera de Bolsa PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'P','N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))

INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P01', 'P- Similares Sueldos y Salarios FAS', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I','N', CAST(10.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P02', 'P-Retenci�n IVA 75%', CAST(75.000000 AS Numeric(19, 6)),GETDATE(),'I','V', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','IVA', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P03', 'P-Retenci�n IVA 100%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'V', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','IVA', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P04', 'P-Honorarios profesionales PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P05', 'P-Honorarios profesionales PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P06', 'P-Honorarios Profesionales PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(4166.670000 AS Numeric(19, 6)), CAST(125.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P07', 'P-Honorarios Profesionales PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P08', 'P-Preparadores de Animales PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P09', 'P-Preparadores de Animales PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P10', 'P-Honorarios Prof. En Clinicas PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P11', 'P-Honorarios Prof. En Clinicas PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P12', 'P-Comisiones Enajenaci�n Inmuebles PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P13', 'P-Comisiones Enajenaci�n Inmuebles PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P14', 'P-Comisiones Enajenaci�n Inmuebles PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P15', 'P-Comisiones Enajenaci�n Inmuebles PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P16', 'P-Comisiones Mercantiles PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P17', 'P-Comisiones Mercantiles PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(4166.670000 AS Numeric(19, 6)), CAST(125.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P18', 'P-Comisiones Mercantiles PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P19', 'P-Comisiones Mercantiles PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P20', 'P-Intereses ART N� 27 #2 L.I.S.R. PNND 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))

INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P21', 'P-Intereses ART N� 27 #2 L.I.S.R. PNNR  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P22', 'P-Intereses ART N� 53 Par 1� PJND 4.95%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(4.950000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P23', 'P-Intereses PNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P24', 'P-Intereses PJND 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P25', 'P-Intereses PNNR  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P26', 'P-Intereses PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P27', 'P-Agencias de Noticias internacional PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P28', 'P-Fletes y Gastos de Transporte Internac. PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P29', 'P-Fletes en el Pa�s a Emp. Internac. PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P30', 'P-Exhibici�n de Pel�culas ART 27 #15 PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P31', 'P-Exhibici�n de Pel�culas ART 27 #15 PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P32', 'P-Regal�as ART 27 #16 PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P33', 'P-Regal�as ART 27 #16 PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P34', 'P-Asistenc�a T�cnica ART 27 #16 PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P35', 'P-Asistenc�a T�cnica ART 27 #16 PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P36', 'P-Servicios Tecnol�gicos PJND 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P37', 'P-Servicios Tecnol�gicos PNNR  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P38', 'P-Primas de Seguro-Reaseg. ART27 #18 PJND 10%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(10.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P39', 'P-Ganancias S/Juegos y Apuestas PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P40', 'P-Ganancias S/Juegos y Apuestas PNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P41', 'P-Ganancias S/Juegos y Apuestas PJND 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P42', 'P-Ganancias S/Juegos y Apuestas PJD 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P43', 'P-Premios Lot. E Hip. ART 65 y 66 PNNR 16%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(16.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P44', 'P-Premios Lot. E Hip. ART 65 y 66 PNR 16%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(16.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P45', 'P-Premios Lot. E Hip. ART 65 y 66 PJND 16%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(16.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P46', 'P-Premios Lot. E Hip. ART 65 y 66 PJD 16%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(16.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P47', 'P-Premios de Animales de Carrera PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P48', 'P-Premios de Animales de Carrera PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P49', 'P-Premios de Animales de Carrera PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P50', 'P-Premios de Animales de Carrera PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P51', 'P-Servicios (Incluye Suministro Bienes) PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P52', 'P-Servicios (Incluye Suministro Bienes) PNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(4166.670000 AS Numeric(19, 6)), CAST(41.670000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P53', 'P-Servicios (Incluye Suministro Bienes) PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P54', 'P-Servicios (Incluye Suministro Bienes) PJD 2%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(2.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P55', 'P-Arrendamiento de Bienes Inmuebles PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P56', 'P-Arrendamiento de Bienes Inmuebles PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(4166.670000 AS Numeric(19, 6)), CAST(125.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P57', 'P-Arrendamiento de Bienes Inmuebles PJND  T2', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(100.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P58', 'P-Arrendamiento de Bienes Inmuebles PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P59', 'P-Arrendamiento de Bienes Muebles PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P60', 'P-Arrendamiento de Bienes Muebles PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(4166.670000 AS Numeric(19, 6)), CAST(125.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P61', 'P-Arrendamiento de Bienes Muebles PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P62', 'P-Arrendamiento de Bienes Muebles PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P63', 'P-Pagos de Tarjeta de Cr�dito PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P64', 'P-Pagos de Tarjeta de Cr�dito PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P65', 'P-Pagos de Tarjeta de Cr�dito PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P66', 'P-Pagos de Tarjeta de Cr�dito PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P67', 'P-Venta de Gasolina con T. Cr�dito PNNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P68', 'P-Venta de Gasolina con T. Cr�dito PJND 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P69', 'P-Fletes y Gastos de Transporte Nacional PNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(4166.670000 AS Numeric(19, 6)), CAST(41.670000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P70', 'P-Fletes y Gastos de Transporte Nacional PJD 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P71', 'P-Pago de Emp. De Seguro a Corredores PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P72', 'P-Pago de Emp. De Seguro a Corredores PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P73', 'P-Pago Rep. Bienes y Atenc. Hosp Aseg. PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P74', 'P-Pago Rep. Bienes y Atenc. Hosp Aseg. PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P75', 'P-Venta de Fondos de Comercio PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P76', 'P-Venta de Fondos de Comercio PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P77', 'P-Venta de Fondos de Comercio PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P78', 'P-Venta de Fondos de Comercio PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P79', 'P-Publicidad y Propaganda PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(4166.670000 AS Numeric(19, 6)), CAST(125.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P80', 'P-Publicidad y Propaganda PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P81', 'P-Publicidad y Propaganda PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P82', 'P-Publicidad y Propaganda Radio PJD 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P83', 'P-Venta de Acciones en Bolsa PNNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P84', 'P-Venta de Acciones en Bolsa PNR 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P85', 'P-Venta de Acciones en Bolsa PJND 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P86', 'P-Venta de Acciones en Bolsa PJD 1%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(1.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P87', 'P-Venta de Acciones Fuera de Bolsa PNNR 34%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(34.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P88', 'P-Venta de Acciones Fuera de Bolsa PNR 3%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(3.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P89', 'P-Venta de Acciones Fuera de Bolsa PJND 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))
INSERT INTO OWHT ([WTCode], [WTName], [Rate], [EffecDate], [Category], [BaseType], [PrctBsAmnt], [Account],[UserSign], [Inactive], [U_IDA_TipoRetencion], [U_IDA_BaseMinima], [U_IDA_Sustraendo]) VALUES ('P90', 'P-Venta de Acciones Fuera de Bolsa PJD 5%', CAST(100.000000 AS Numeric(19, 6)),GETDATE(),'I', 'N', CAST(5.000000 AS Numeric(19, 6)), NULL,@UserSign, 'N','ISLR', CAST(0.000000 AS Numeric(19, 6)), CAST(0.000000 AS Numeric(19, 6)))

END

GO
/****** Object:  StoredProcedure [dbo].[AddUpdateNroComprobante]    Script Date: 6/4/2020 6:06:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddUpdateTaxHolding]

@OldWtCode nvarchar(4), 
@Wt_Code nvarchar(4), 
@Wt_Name nvarchar(50),
@Rate numeric(19,6), 
@EffecDate datetime,
@Category char(1),
@BaseType char(1),
@PrctBsAmnt numeric(19,6), 
@Account nvarchar(15),
@UserSign smallint,
@Inactive char(1),
@U_IDA_TipoRetencion nvarchar(20),
@U_IDA_BaseMinima numeric(19,6), 
@U_IDA_Sustraendo numeric(19,6)

AS

BEGIN

IF EXISTS (SELECT * FROM OWHT WHERE WtCode=@OldWtCode)
BEGIN
UPDATE OWHT SET WTCode=@Wt_Code, WtName=@Wt_Name, Rate=@Rate, EffecDate=@EffecDate, Category=@Category, BaseType=@BaseType, PrctBsAmnt=@PrctBsAmnt, Account=@Account, UserSign=@UserSign, Inactive=@Inactive, U_IDA_TipoRetencion=@U_IDA_TipoRetencion,  U_IDA_BaseMinima=@U_IDA_BaseMinima,  U_IDA_Sustraendo=@U_IDA_Sustraendo WHERE WtCode=@OldWtCode
END
ELSE
BEGIN
INSERT INTO OWHT(WTCode,WTName,Rate, EffecDate,Category,BaseType, PrctBsAmnt, Account, UserSign, Inactive, U_IDA_TipoRetencion, U_IDA_BaseMinima, U_IDA_Sustraendo) VALUES (@Wt_Code,@Wt_Name,@Rate,@EffecDate,@Category, @BaseType, @PrctBsAmnt, @Account, @UserSign, @Inactive, @U_IDA_TipoRetencion, @U_IDA_BaseMinima, @U_IDA_Sustraendo)
END
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteNroComprobante]
@Code nvarchar(50)
AS

BEGIN
DELETE FROM NRO_COMPROBANTE WHERE Code=@Code
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddClasesImpuestos]

@UserSign smallint
AS

BEGIN
INSERT INTO OSTA(Code,Name,Rate,UserSign) VALUES ('IVA_12', 'IVA 12', CAST(12.000000 AS Numeric(19, 6)), @UserSign)
INSERT INTO OSTA(Code,Name,Rate,UserSign) VALUES ('IVA_16', 'IVA 16', CAST(16.000000 AS Numeric(19, 6)), @UserSign)
INSERT INTO OSTA(Code,Name,Rate,UserSign) VALUES ('IVA_22', 'IVA 22', CAST(22.000000 AS Numeric(19, 6)), @UserSign)
INSERT INTO OSTA(Code,Name,Rate,UserSign) VALUES ('IVA_7', 'IVA 7', CAST(7.000000 AS Numeric(19, 6)), @UserSign)
INSERT INTO OSTA(Code,Name,Rate,UserSign) VALUES ('IVA_8', 'IVA 8', CAST(8.000000 AS Numeric(19, 6)), @UserSign)
INSERT INTO OSTA(Code,Name,Rate,UserSign) VALUES ('IVA_9', 'IVA 9', CAST(9.000000 AS Numeric(19, 6)), @UserSign)
INSERT INTO OSTA(Code,Name,Rate,UserSign) VALUES ('IVA_Exe', 'IVA Exento', CAST(0.000000 AS Numeric(19, 6)), @UserSign)
END

/****** Object:  StoredProcedure [dbo].[AddUpdateNroComprobante]    Script Date: 6/4/2020 6:06:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddUpdateClasesImpuestos]
@Code nvarchar(8), 
@Name nvarchar(100),
@Rate numeric(19,6), 
@SalesTax nvarchar(15),
@PurchTax nvarchar(15),
@UserSign smallint

AS

BEGIN

IF EXISTS (SELECT * FROM OSTA WHERE Code=@Code)
BEGIN
UPDATE OSTA SET Name=@Name, Rate=@Rate, SalesTax=@SalesTax, PurchTax=@PurchTax, UserSign=@UserSign WHERE Code=@Code
END
ELSE
BEGIN
INSERT INTO OSTA(Code,Name,Rate, SalesTax,PurchTax,UserSign) VALUES (@Code,@Name,@Rate,@SalesTax,@PurchTax, @UserSign)
END
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteClaseImpuesto]
@Code nvarchar(8)
AS
BEGIN
DECLARE @ClaseImpuestoORCD int
DECLARE @ClaseImpuestoPCH1 int
DECLARE @ClaseImpuestoINV1 int
DECLARE @ClaseImpuestoRPC1 int
DECLARE @ClaseImpuestoRIN1 int
DECLARE @ClaseImpuestoPDN1 int
DECLARE @ClaseImpuestoDLN1 int

DECLARE @Result int

SET @ClaseImpuestoORCD = (SELECT COUNT(VatGroup) FROM OCRD WHERE VatGroup=@Code)
SET @ClaseImpuestoPCH1 = (SELECT COUNT(VatGroup) FROM PCH1 WHERE VatGroup=@Code)
SET @ClaseImpuestoINV1 = (SELECT COUNT(VatGroup) FROM INV1 WHERE VatGroup=@Code)
SET @ClaseImpuestoRPC1 = (SELECT COUNT(VatGroup) FROM RPC1 WHERE VatGroup=@Code)
SET @ClaseImpuestoRIN1 = (SELECT COUNT(VatGroup) FROM RIN1 WHERE VatGroup=@Code)
SET @ClaseImpuestoPDN1 = (SELECT COUNT(VatGroup) FROM PDN1 WHERE VatGroup=@Code)
SET @ClaseImpuestoDLN1 = (SELECT COUNT(VatGroup) FROM DLN1 WHERE VatGroup=@Code)


SET @Result=@ClaseImpuestoORCD+ @ClaseImpuestoPCH1+@ClaseImpuestoINV1+@ClaseImpuestoRPC1+@ClaseImpuestoRIN1+@ClaseImpuestoPDN1+@ClaseImpuestoDLN1

IF (@Result=0)
BEGIN
DELETE FROM OSTA WHERE Code=@Code
END
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddCodigosFiscales]

@UserSign smallint

AS

BEGIN

INSERT INTO OSTC(Code, Name, Rate, Freight, UserSign, ValidForAP, ValidForAR, Lock, UpdateDate,U_IDA_Alicuota) VALUES ('IVA_12','IVA 12',CAST(12.000000 AS Numeric(19, 6)),'N',@UserSign,'Y','Y','Y',GETDATE(),'GENERAL')
INSERT INTO OSTC(Code, Name, Rate, Freight, UserSign, ValidForAP, ValidForAR, Lock, UpdateDate,U_IDA_Alicuota) VALUES ('IVA_16','IVA 16',CAST(16.000000 AS Numeric(19, 6)),'Y',@UserSign,'Y','Y','N',GETDATE(),'GENERAL')
INSERT INTO OSTC(Code, Name, Rate, Freight, UserSign, ValidForAP, ValidForAR, Lock, UpdateDate,U_IDA_Alicuota) VALUES ('IVA_22','IVA 22',CAST(22.000000 AS Numeric(19, 6)),'Y',@UserSign,'Y','Y','N',GETDATE(),'ADICIONAL')
INSERT INTO OSTC(Code, Name, Rate, Freight, UserSign, ValidForAP, ValidForAR, Lock, UpdateDate,U_IDA_Alicuota) VALUES ('IVA_7','IVA 7',CAST(7.000000 AS Numeric(19, 6)),'Y',@UserSign,'Y','Y','N',GETDATE(),'GENERAL_E2')
INSERT INTO OSTC(Code, Name, Rate, Freight, UserSign, ValidForAP, ValidForAR, Lock, UpdateDate,U_IDA_Alicuota) VALUES ('IVA_8','IVA 8',CAST(8.000000 AS Numeric(19, 6)),'Y',@UserSign,'Y','Y','N',GETDATE(),'REDUCIDA')
INSERT INTO OSTC(Code, Name, Rate, Freight, UserSign, ValidForAP, ValidForAR, Lock, UpdateDate,U_IDA_Alicuota) VALUES ('IVA_9','IVA 9',CAST(9.000000 AS Numeric(19, 6)),'Y',@UserSign,'Y','Y','N',GETDATE(),'GENERAL_E1')
INSERT INTO OSTC(Code, Name, Rate, Freight, UserSign, ValidForAP, ValidForAR, Lock, UpdateDate,U_IDA_Alicuota) VALUES ('IVA_EXE','IVA Exento',CAST(0.000000 AS Numeric(19, 6)),'Y',@UserSign,'Y','Y','N',GETDATE(),'EXENTO')

INSERT INTO STC1(STCCode, Line_ID, EfctivRate, STACode) VALUES ('IVA_12',0,CAST(12.000000 AS Numeric(19, 6)),'IVA_12')
INSERT INTO STC1(STCCode, Line_ID, EfctivRate, STACode) VALUES ('IVA_16',0,CAST(16.000000 AS Numeric(19, 6)),'IVA_16')
INSERT INTO STC1(STCCode, Line_ID, EfctivRate, STACode) VALUES ('IVA_22',0,CAST(22.000000 AS Numeric(19, 6)),'IVA_22')
INSERT INTO STC1(STCCode, Line_ID, EfctivRate, STACode) VALUES ('IVA_7',0,CAST(7.000000 AS Numeric(19, 6)),'IVA_7')
INSERT INTO STC1(STCCode, Line_ID, EfctivRate, STACode) VALUES ('IVA_8',0,CAST(8.000000 AS Numeric(19, 6)),'IVA_8')
INSERT INTO STC1(STCCode, Line_ID, EfctivRate, STACode) VALUES ('IVA_9',0,CAST(9.000000 AS Numeric(19, 6)),'IVA_9')
INSERT INTO STC1(STCCode, Line_ID, EfctivRate, STACode) VALUES ('IVA_EXE',0,CAST(0.000000 AS Numeric(19, 6)),'IVA_EXE')

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddMonth]

AS

BEGIN

INSERT INTO MONTHS(Code, Month) VALUES ('01','Enero')
INSERT INTO MONTHS(Code, Month) VALUES ('02','Febrero')
INSERT INTO MONTHS(Code, Month) VALUES ('03','Marzo')
INSERT INTO MONTHS(Code, Month) VALUES ('04','Abril')
INSERT INTO MONTHS(Code, Month) VALUES ('05','Mayo')
INSERT INTO MONTHS(Code, Month) VALUES ('06','Junio')
INSERT INTO MONTHS(Code, Month) VALUES ('07','Julio')
INSERT INTO MONTHS(Code, Month) VALUES ('08','Agosto')
INSERT INTO MONTHS(Code, Month) VALUES ('09','Septiembre')
INSERT INTO MONTHS(Code, Month) VALUES ('10','Octubre')
INSERT INTO MONTHS(Code, Month) VALUES ('11','Noviembre')
INSERT INTO MONTHS(Code, Month) VALUES ('12','Diciembre')

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddUpdateTipoCambio]

@RateDate datetime,
@Rate numeric(19,6),
@Currency nvarchar(3),
@UserSign smallint

AS

BEGIN

IF EXISTS (SELECT * FROM ORTT WHERE RateDate=@RateDate AND Currency=@Currency)
BEGIN
UPDATE ORTT SET Rate=@Rate, Currency=@Currency, UserSign=@UserSign WHERE RateDate=@RateDate AND Currency=@Currency
END
ELSE
BEGIN
INSERT INTO ORTT(RateDate,Rate,Currency, UserSign) VALUES (@RateDate,@Rate,@Currency,@UserSign)
END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddAlicuota]

AS

BEGIN

INSERT INTO Alicuotas(Code, Name) VALUES ('GENERAL','GENERAL')
INSERT INTO Alicuotas(Code, Name) VALUES ('REDUCIDA','REDUCIDA')
INSERT INTO Alicuotas(Code, Name) VALUES ('ADICIONAL','ADICIONAL')
INSERT INTO Alicuotas(Code, Name) VALUES ('EXENTO','EXENTO')
INSERT INTO Alicuotas(Code, Name) VALUES ('GENERAL_E1','GENERAL_E1')
INSERT INTO Alicuotas(Code, Name) VALUES ('GENERAL_E2','GENERAL_E2')

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindCodigosFiscales]

@Code nvarchar(8),
@Name nvarchar(100),
@U_IDA_Alicuota nvarchar(20),
@ValidForAR char(1),
@ValidForAP char(1),
@Lock char(1)

AS

BEGIN

SELECT * FROM OSTC WHERE Code LIKE  @Code + '%' OR Name LIKE @Name + '%' OR U_IDA_Alicuota LIKE @U_IDA_Alicuota + '%' OR ValidForAR LIKE @ValidForAR + '%' OR ValidForAP LIKE @ValidForAP + '%' OR Lock LIKE @Lock + '%'

END

GO
/****** Object:  StoredProcedure [dbo].[NextCodigoFiscal]    Script Date: 12/4/2020 7:16:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousCodigoFiscal]

@Code nvarchar(8)

AS

BEGIN

DECLARE @Result nvarchar(8)

SET @Result=(SELECT Previous
FROM
    (Select Code,LAG(Code) over (order by Code) Previous
      from OSTC) AS NextQueryCodigoFiscal
 Where Code=@Code)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OSTC WHERE Code=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OSTC ORDER BY Code DESC
 END

END

GO
/****** Object:  StoredProcedure [dbo].[NextCodigoFiscal]    Script Date: 12/4/2020 7:16:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextCodigoFiscal]

@Code nvarchar(8)

AS

BEGIN

DECLARE @Result nvarchar(8)

SET @Result=(SELECT Siguiente
FROM
    (Select Code,LEAD(Code) over (order by Code) Siguiente
      from OSTC) AS NextQueryCodigoFiscal
 Where Code=@Code)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OSTC WHERE Code=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OSTC ORDER BY Code 
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LastCodigoFiscal]

AS

BEGIN

SELECT TOP 1 * FROM OSTC ORDER BY Code DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstCodigoFiscal]

AS

BEGIN

SELECT TOP 1 * FROM OSTC ORDER BY Code 
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetSociety]

AS

BEGIN

SELECT CompnyName FROM OADM

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddCodigoFiscal]

@Code nvarchar(8),
@Name nvarchar(100),
@Rate numeric(19,6),
@UserSign smallint,
@ValidForAR char(1),
@ValidForAP char(1),
@Lock char(1),
@UpdateDate datetime,
@U_IDA_Alicuota nvarchar(20)

AS

BEGIN

INSERT INTO OSTC(Code,Name,Rate,UserSign,ValidForAR, ValidForAP, Lock, UpdateDate, U_IDA_Alicuota) VALUES (@Code,@Name,@Rate,@UserSign,@ValidForAP,@ValidForAR,@Lock,@UpdateDate,@U_IDA_Alicuota)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateCodigoFiscal]

@Code nvarchar(8),
@Name nvarchar(100),
@Rate numeric(19,6),
@UserSign smallint,
@ValidForAR char(1),
@ValidForAP char(1),
@Lock char(1),
@UpdateDate datetime,
@U_IDA_Alicuota nvarchar(20)

AS

BEGIN

UPDATE OSTC SET Code=@Code, Name=@Name, Rate=@Rate, UserSign2=@UserSign, ValidForAR=@ValidForAR, ValidForAP=@ValidForAP, Lock=@Lock, UpdateDate=@UpdateDate, U_IDA_Alicuota=@U_IDA_Alicuota WHERE Code=@Code

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindUsuarios]

@User_code nvarchar(25),
@User_name nvarchar (155),
@Locked char(1)

AS

BEGIN

SELECT * FROM OUSR WHERE USER_CODE LIKE  @User_code + '%' OR U_NAME LIKE @User_name + '%' OR Locked LIKE @Locked + '%'

END

GO
/****** Object:  StoredProcedure [dbo].[NextCodigoFiscal]    Script Date: 12/4/2020 7:16:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousUser]

@USERID smallint

AS

BEGIN

DECLARE @Result smallint

SET @Result=(SELECT Previous
FROM
    (Select USERID,LAG(USERID) over (order by USERID) Previous
      from OUSR) AS NextQueryUser
 Where USERID=@USERID)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OUSR WHERE USERID=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OUSR ORDER BY USERID DESC
 END

END

GO
/****** Object:  StoredProcedure [dbo].[NextCodigoFiscal]    Script Date: 12/4/2020 7:16:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextUser]

@USERID smallint

AS

BEGIN

DECLARE @Result smallint

SET @Result=(SELECT Siguiente
FROM
    (Select USERID,LEAD(USERID) over (order by USERID) Siguiente
      from OUSR) AS NextQueryUser
 Where USERID=@USERID)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OUSR WHERE USERID=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OUSR ORDER BY USERID
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LastUser]

AS

BEGIN

SELECT TOP 1 * FROM OUSR ORDER BY USERID DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstUser]

AS

BEGIN

SELECT TOP 1 * FROM OUSR ORDER BY USERID
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateUser]

@UserID smallint,
@User nvarchar(25),
@FullName nvarchar (155),
@Locked char(1)

AS

BEGIN

UPDATE OUSR SET USER_CODE=@User, U_NAME=@FullName, Locked=@Locked WHERE USERID=@UserID

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePasswordUser]

@UserID smallint,
@PASSWORD nvarchar(254)

AS

BEGIN

UPDATE OUSR SET PASSWORD=@PASSWORD WHERE USERID=@UserID

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAccount]

@AcctCode nvarchar(15)

AS

BEGIN

SELECT * FROM OACT WHERE AcctCode=@AcctCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateAccount]

@AcctCode nvarchar(15),
@AcctName nvarchar(100),
@ActCurr nvarchar(3),
@LocManTran char(1),
@UserSign smallint,
@ActType char(1),
@CreateDate datetime

AS

BEGIN

UPDATE OACT SET AcctCode=@AcctCode, AcctName=@AcctName, LocManTran=@LocManTran, UserSign=@UserSign, ActType=@ActType, ActCurr=@ActCurr, UpdateDate=@CreateDate WHERE AcctCode=@AcctCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertAccount]

@AcctCode nvarchar(15),
@AcctName nvarchar(100),
@ActCurr nvarchar(3),
@UserSign smallint,
@CreateDate datetime,
@Postable char(1),
@FatherNum nvarchar(15), 
@LocManTran char(1),
@ActType char(1),
@CurrTotal numeric(19,6),
@Finanse char(1),
@Levels smallint,
@SysTotal numeric(19,6),
@FcTotal numeric(19,6),
@Advance char(1),
@GroupMask smallint

AS

BEGIN

INSERT INTO OACT (AcctCode,AcctName,UserSign,CreateDate,Postable,FatherNum, ActType,ActCurr,LocManTran, CurrTotal,Finanse,Levels,SysTotal,FcTotal,Advance,GroupMask) VALUES(@AcctCode,@AcctName,@UserSign,@CreateDate,@Postable,@FatherNum,@ActType,@ActCurr,@LocManTran,@CurrTotal,@Finanse,@Levels,@SysTotal,@FcTotal,@Advance,@GroupMask)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindFatherNum]

@AcctCode nvarchar(15)

AS

BEGIN

SELECT FatherNum FROM OACT WHERE AcctCode=@AcctCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateAccountTratar]

@AcctCode nvarchar(15),
@AcctName nvarchar(100),
@UserSign smallint,
@CreateDate datetime,
@FatherNum nvarchar(15),
@Postable char(1)

AS

BEGIN

UPDATE OACT SET AcctCode=@AcctCode, AcctName=@AcctName, UserSign=@UserSign, UpdateDate=@CreateDate, FatherNum=@FatherNum, Postable=@Postable WHERE AcctCode=@AcctCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastBusinessPartner]

AS

BEGIN

SELECT TOP 1 * FROM OCRD ORDER BY CardCode DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstBusinessPartner]

AS

BEGIN

SELECT TOP 1 * FROM OCRD ORDER BY CardCode
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousBusinessPartner]

@CardCode nvarchar(15)

AS

BEGIN

DECLARE @Result nvarchar(15)

SET @Result=(SELECT Previous
FROM
    (Select CardCode,LAG(CardCode) over (order by CardCode) Previous
      from OCRD) AS NextQueryBP
 Where CardCode=@CardCode)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OCRD WHERE CardCode=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OCRD ORDER BY CardCode DESC
 END

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextBusinessPartner]

@CardCode nvarchar(15)

AS

BEGIN

DECLARE @Result nvarchar(15)

SET @Result=(SELECT Siguiente
FROM
    (Select CardCode,LEAD(CardCode) over (order by CardCode) Siguiente
      from OCRD) AS NextQueryBP
 Where CardCode=@CardCode)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OCRD WHERE CardCode=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OCRD ORDER BY CardCode
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindBusinessPartner]

@CardCode nvarchar(15),
@CardName nvarchar (100),
@CardType char(1),
@LicTradNum nvarchar(32),
@Currency nvarchar(3),
@TipoPersona nvarchar(10),
@Sucursal nvarchar(10),
@Contribuyente nvarchar(10),
@AplicaITF nvarchar(10)

AS

BEGIN

SELECT * FROM OCRD WHERE CardCode LIKE  @CardCode + '%' OR CardName LIKE @CardName + '%' OR CardType LIKE @CardType + '%' OR LicTradNum LIKE @LicTradNum + '%' OR Currency LIKE @Currency + '%' OR U_IDA_TipoPersona LIKE @TipoPersona + '%' OR U_IDA_Contribuyente LIKE @Contribuyente + '%' OR U_IDA_Sucursal LIKE @Sucursal + '%' OR U_IDA_AplicaITF LIKE @AplicaITF + '%'

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertBusinessPartner]

@CardCode nvarchar(15),
@CardName nvarchar (100),
@CardType char(1),
@LicTradNum nvarchar(32),
@Currency nvarchar(3),
@TipoPersona nvarchar(10),
@Sucursal nvarchar(10),
@Contribuyente nvarchar(10),
@AplicaITF nvarchar(10),
@Balance numeric(19,6),
@BalanceSys numeric(19,6),
@BalanceFC numeric(19,6),
@DNotesBal numeric(19,6),
@DNoteBalSy numeric(19,6),
@DNoteBalFC numeric(19,6),
@Phone1 nvarchar(20),
@Phone2 nvarchar(20),
@Fax nvarchar(20),
@E_Mail nvarchar(100),
@MailAddress nvarchar(100),
@CntctPrsn nvarchar(90),
@VatGroup nvarchar(8),
@Address nvarchar(100),
@DebPayAcct nvarchar(15),
@UpdateDate datetime,
@UserSign smallint,
@Deleted char(1)

AS

BEGIN

INSERT INTO OCRD (CardCode,CardName,CardType,LicTradNum,Currency,U_IDA_TipoPersona,U_IDA_Sucursal,U_IDA_Contribuyente,U_IDA_AplicaITF, Balance, Phone1,Phone2,Fax,E_Mail,MailAddres,CntctPrsn, VatGroup, Address, DebPayAcct, CreateDate, UserSign, Deleted, BalanceSys, BalanceFC, DNotesBal, DNoteBalSy, DNoteBalFC) VALUES(@CardCode,@CardName,@CardType,@LicTradNum,@Currency,@TipoPersona, @Sucursal, @Contribuyente, @AplicaITF, @Balance, @Phone1, @Phone2, @Fax, @E_Mail,@MailAddress, @CntctPrsn, @VatGroup, @Address, @DebPayAcct, @UpdateDate,@UserSign,@Deleted,  @BalanceSys, @BalanceFC, @DNotesBal, @DNoteBalSy, @DNoteBalFC)

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateBusinessPartner]

@OldCardCode nvarchar(15),
@CardCode nvarchar(15),
@CardName nvarchar (100),
@CardType char(1),
@LicTradNum nvarchar(32),
@Currency nvarchar(3),
@TipoPersona nvarchar(10),
@Sucursal nvarchar(10),
@Contribuyente nvarchar(10),
@AplicaITF nvarchar(10),
@Phone1 nvarchar(20),
@Phone2 nvarchar(20),
@Fax nvarchar(20),
@E_Mail nvarchar(100),
@MailAddress nvarchar(100),
@CntctPrsn nvarchar(90),
@VatGroup nvarchar(8),
@Address nvarchar(100),
@DebPayAcct nvarchar(15),
@UpdateDate datetime,
@UserSign smallint

AS

BEGIN

UPDATE OCRD SET CardCode=@CardCode, CardName=@CardName, CardType=@CardType, LicTradNum=@LicTradNum, Currency=@Currency, U_IDA_TipoPersona=@TipoPersona, U_IDA_Contribuyente=@Contribuyente, U_IDA_AplicaITF=@AplicaITF, U_IDA_Sucursal=@Sucursal, Phone1=@Phone1, Phone2=@Phone2, Fax=@Fax, E_Mail=@E_Mail, MailAddres=@MailAddress, CntctPrsn=@CntctPrsn, VatGroup=@VatGroup, DebPayAcct=@DebPayAcct, Address=@Address, UserSign=@UserSign, UpdateDate=@UpdateDate WHERE CardCode=@OldCardCode

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAccountAsociada]

AS

BEGIN

SELECT AcctCode, AcctName FROM OACT WHERE LocManTran='Y' AND Postable='Y'

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindCodigosFiscalesActivos]

AS

BEGIN

SELECT Code,Rate FROM OSTC WHERE Lock='N'

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAccountNoAsociada]

AS

BEGIN

SELECT AcctCode, AcctName FROM OACT WHERE LocManTran='N' AND Postable='Y'

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastItem]

AS

BEGIN

SELECT TOP 1 * FROM OITM ORDER BY ItemCode DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstItem]

AS

BEGIN

SELECT TOP 1 * FROM OITM ORDER BY ItemCode
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousItem]

@ItemCode nvarchar(50)

AS

BEGIN

DECLARE @Result nvarchar(50)

SET @Result=(SELECT Previous
FROM
    (Select ItemCode,LAG(ItemCode) over (order by ItemCode) Previous
      from OITM) AS NextQueryItem
 Where ItemCode=@ItemCode)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OITM WHERE ItemCode=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OITM ORDER BY ItemCode DESC
 END

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextItem]

@ItemCode nvarchar(50)

AS

BEGIN

DECLARE @Result nvarchar(50)

SET @Result=(SELECT Siguiente
FROM
    (Select ItemCode,LEAD(ItemCode) over (order by ItemCode) Siguiente
      from OITM) AS NextQueryItem
 Where ItemCode=@ItemCode)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OITM WHERE ItemCode=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OITM ORDER BY ItemCode
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindItem]

@ItemCode nvarchar(50),
@ItemName nvarchar (100),
@PrchseItem char(1),
@SellItem char(1),
@InvntItem char(1)

AS

BEGIN

SELECT * FROM OITM WHERE ItemCode LIKE  @ItemCode + '%' OR ItemName LIKE @ItemName + '%' OR PrchseItem LIKE @PrchseItem + '%' OR SellItem LIKE @SellItem + '%' OR InvntItem LIKE @InvntItem + '%' 

END


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertItem]

@ItemCode nvarchar(50),
@ItemName nvarchar (100),
@VatLiable char(1),
@PrchseItem char(1),
@SellItem char(1),
@InvnItem char(1),
@OnHand numeric(19,6),
@IsCommited numeric(19,6),
@OnOrders numeric(19,6),
@Deleted char(1),
@CreateDate datetime,
@StockValue numeric(19,6),
@UserSign int,
@BalInvntAc nvarchar(15),
@ExpensesAc nvarchar(15),
@RevenuesAc nvarchar(15),
@SaleCostAc nvarchar(15)
AS

BEGIN

INSERT INTO OITM (ItemCode,ItemName,VATLiable,PrchseItem,SellItem,InvntItem,OnHand,IsCommited,OnOrder, Deleted,CreateDate,StockValue,UserSign,BalInvntAc,ExpensesAc,RevenuesAc,SaleCostAc) VALUES(@ItemCode,@ItemName,@VatLiable,@PrchseItem,@SellItem,@InvnItem, @OnHand, @IsCommited, @OnOrders, @Deleted, @CreateDate, @StockValue, @UserSign,@BalInvntAc,@ExpensesAc,@RevenuesAc,@SaleCostAc)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateItem]

@OldItemCode nvarchar(50),
@ItemCode nvarchar(50),
@ItemName nvarchar (100),
@VatLiable char(1),
@PrchseItem char(1),
@SellItem char(1),
@InvnItem char(1),
@UpdateDate datetime,
@UserSign int,
@BalInvntAc nvarchar(15),
@ExpensesAc nvarchar(15),
@RevenuesAc nvarchar(15),
@SaleCostAc nvarchar(15)
AS

BEGIN

UPDATE OITM SET ItemCode=@ItemCode, ItemName=@ItemName, VATLiable=@VatLiable, PrchseItem=@PrchseItem, SellItem=@SellItem, InvntItem=@InvnItem, UpdateDate=@UpdateDate, UserSign2=@UserSign, BalInvntAc=@BalInvntAc, ExpensesAc=@ExpensesAc,RevenuesAc=@RevenuesAc,SaleCostAc=@SaleCostAc WHERE ItemCode=@OldItemCode

END


GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteBusinessPartner]
@CardCode nvarchar(15)
AS

BEGIN

DECLARE @CardCodeOPCH int
DECLARE @CardCodeOINV int
DECLARE @CardCodeODLN int
DECLARE @CardCodeORPC int
DECLARE @CardCodeOPDN int
DECLARE @CardCodeORIN int
DECLARE @CardCodeJDT1 int
DECLARE @Result int

SET @CardCodeOPCH = (SELECT COUNT(CardCode) FROM OPCH WHERE CardCode=@CardCode)
SET @CardCodeOINV = (SELECT COUNT(CardCode) FROM OINV WHERE CardCode=@CardCode)
SET @CardCodeODLN = (SELECT COUNT(CardCode) FROM ODLN WHERE CardCode=@CardCode)
SET @CardCodeORPC = (SELECT COUNT(CardCode) FROM ORPC WHERE CardCode=@CardCode)
SET @CardCodeOPDN = (SELECT COUNT(CardCode) FROM OPDN WHERE CardCode=@CardCode)
SET @CardCodeORIN = (SELECT COUNT(CardCode) FROM ORIN WHERE CardCode=@CardCode)
SET @CardCodeJDT1 = (SELECT COUNT(ShortName) FROM JDT1 WHERE ShortName=@CardCode)

SET @Result=@CardCodeOPCH+@CardCodeOINV+@CardCodeODLN+@CardCodeORPC+@CardCodeOPDN+@CardCodeORIN+@CardCodeJDT1

IF (@Result=0)
BEGIN
DELETE FROM OCRD WHERE CardCode=@CardCode
END
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteItem]
@ItemCode nvarchar(50)
AS

BEGIN

DECLARE @ItemCodePCH1 int
DECLARE @ItemCodeINV1 int
DECLARE @ItemCodeDLN1 int
DECLARE @ItemCodeRPC1 int
DECLARE @ItemCodePDN1 int
DECLARE @ItemCodeRIN1 int
DECLARE @Result int

SET @ItemCodePCH1 = (SELECT COUNT(ItemCode) FROM PCH1 WHERE ItemCode=@ItemCode)
SET @ItemCodeINV1 = (SELECT COUNT(ItemCode) FROM INV1 WHERE ItemCode=@ItemCode)
SET @ItemCodeDLN1 = (SELECT COUNT(ItemCode) FROM DLN1 WHERE ItemCode=@ItemCode)
SET @ItemCodeRPC1 = (SELECT COUNT(ItemCode) FROM RPC1 WHERE ItemCode=@ItemCode)
SET @ItemCodePDN1 = (SELECT COUNT(ItemCode) FROM PDN1 WHERE ItemCode=@ItemCode)
SET @ItemCodeRIN1 = (SELECT COUNT(ItemCode) FROM RIN1 WHERE ItemCode=@ItemCode)

SET @Result=@ItemCodePCH1+@ItemCodeINV1+@ItemCodeDLN1+@ItemCodeRPC1+@ItemCodePDN1+@ItemCodeRIN1

IF (@Result=0)
BEGIN
DELETE FROM OITM WHERE ItemCode=@ItemCode
END
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteCodigoFiscal]
@Code nvarchar(8)
AS

BEGIN

DECLARE @Freight char(1)

SET @Freight=(SELECT Freight FROM OSTC WHERE Code=@Code)

IF (@Freight='Y')
BEGIN
DELETE FROM STC1 WHERE STCCode=@Code
DELETE FROM OSTC WHERE Code=@Code
END
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteUser]
@USER_CODE nvarchar(25)
AS

BEGIN
DECLARE @UserSign smallint
DECLARE @UserOCRD int
DECLARE @UserOPCH int
DECLARE @UserOJDT int
DECLARE @UserJDT1 int
DECLARE @UserOACP int
DECLARE @UserOACT int
DECLARE @UserOADM int
DECLARE @UserOCRN int
DECLARE @UserODLN int
DECLARE @UserOFPR int
DECLARE @UserOINV int
DECLARE @UserOITM int
DECLARE @UserOPDN int
DECLARE @UserORIN int
DECLARE @UserORPC int
DECLARE @UserORTT int
DECLARE @UserOSTA int
DECLARE @UserOSTC int
DECLARE @UserOWHT int
DECLARE @Result int

SET @UserSign=(SELECT USERID FROM OUSR WHERE USER_CODE=@USER_CODE)

SET @UserOCRD = (SELECT COUNT(UserSign) FROM OCRD WHERE UserSign=@UserSign)
SET @UserOPCH = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OPCH WHERE UserSign=@UserSign)
SET @UserOJDT = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OJDT WHERE UserSign=@UserSign)
SET @UserJDT1 = (SELECT COUNT(UserSign) FROM JDT1 WHERE UserSign=@UserSign)
SET @UserOACP = (SELECT COUNT(UserSign) FROM OACP WHERE UserSign=@UserSign)
SET @UserOACT = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OACT WHERE UserSign=@UserSign)
SET @UserOADM = (SELECT COUNT(UserSign) FROM OADM WHERE UserSign=@UserSign)
SET @UserOCRN = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OCRN WHERE UserSign=@UserSign)
SET @UserODLN = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM ODLN WHERE UserSign=@UserSign)
SET @UserOFPR = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OFPR WHERE UserSign=@UserSign)
SET @UserOINV = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OINV WHERE UserSign=@UserSign)
SET @UserOITM = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OITM WHERE UserSign=@UserSign)
SET @UserOPDN = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OPDN WHERE UserSign=@UserSign)
SET @UserORIN = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM ORIN WHERE UserSign=@UserSign)
SET @UserORPC = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM ORPC WHERE UserSign=@UserSign)
SET @UserORTT = (SELECT COUNT(UserSign) FROM ORTT WHERE UserSign=@UserSign)
SET @UserOSTA = (SELECT COUNT(UserSign) FROM OSTA WHERE UserSign=@UserSign)
SET @UserOSTC = (SELECT COUNT(UserSign) + COUNT(UserSign2) FROM OSTC WHERE UserSign=@UserSign)
SET @UserOWHT = (SELECT COUNT(UserSign) FROM OSTA WHERE UserSign=@UserSign)

SET @Result=@UserOCRD+@UserOPCH+@UserOJDT+@UserOACP+@UserOACT+@UserOADM+@UserOCRN+@UserODLN+@UserOFPR+@UserOINV+@UserOITM+@UserOPDN+@UserORIN+@UserORPC+@UserORTT+@UserOSTA+@UserOSTC+@UserOWHT

IF (@Result=0)
BEGIN
DELETE FROM OUSR WHERE USER_CODE=@USER_CODE
END
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastJournalEntry]

AS

BEGIN

SELECT TOP 1 * FROM OJDT ORDER BY TransId DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstJournalEntry]

AS

BEGIN

SELECT TOP 1 * FROM OJDT ORDER BY TransId
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousJournalEntry]

@TransId int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select TransId,LAG(TransId) over (order by TransId) Previous
      from OJDT) AS PreviousQueryJournalEntry
 Where TransId=@TransId)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OJDT WHERE TransId=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OJDT ORDER BY TransId DESC
 END

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextJournalEntry]

@TransId int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select TransId,LEAD(TransId) over (order by TransId) Siguiente
      from OJDT) AS NextQueryJournalEntry
 Where TransId=@TransId)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OJDT WHERE TransId=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OJDT ORDER BY TransId
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindJournalEntryLines]

@TransId int

AS

BEGIN

SELECT TransId,Line_ID, Account,Debit,Credit,SYSCred,SYSDeb,FCDebit,FCCredit,ShortName,LineMemo,UserSign,DataSource, FCCurrency, ContraAct FROM JDT1 WHERE TransId=@TransId
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertJournalEntry]

@RefDate datetime,
@TaxDate datetime,
@DueDate datetime,
@Memo nvarchar(50),
@Ref1 nvarchar(100),
@Ref2 nvarchar(100),
@CreateDate datetime,
@UserSign int,
@TransCurr nvarchar(3),
@BaseRef int,
@FinncPriod int,
@LocTotal numeric(19,6),
@SysTotal numeric(19,6),
@FcTotal numeric(19,6),
@TransType nvarchar(20)

AS

BEGIN

INSERT INTO OJDT (RefDate,TaxDate,DueDate,Memo,Ref1,Ref2,CreateDate,UserSign, TransCurr, BaseRef, FinncPriod, LocTotal, SysTotal, FcTotal, TransType) VALUES(@RefDate,@TaxDate,@DueDate,@Memo,@Ref1, @Ref2, @CreateDate, @UserSign,@TransCurr, @BaseRef, @FinncPriod, @LocTotal, @SysTotal, @FcTotal,@TransType)

END


GO
/****** Object:  StoredProcedure [dbo].[FindPeriodCode]    Script Date: 25/4/2020 5:16:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPeriodCode]

@RefDate datetime

AS

BEGIN

SELECT AbsEntry FROM OFPR WHERE @RefDate BETWEEN F_RefDate AND T_RefDate
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindRate]

@RateDate datetime

AS

BEGIN

SELECT Rate FROM ORTT WHERE RateDate=@RateDate AND Currency=(SELECT SysCurrncy FROM OADM)
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindMainSysCurrency]
AS

BEGIN

SELECT MainCurncy, SysCurrncy FROM OADM 
 
END


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindExistFCCurrency]

@FCCurrency nvarchar(3)

AS

BEGIN

SELECT CurrCode FROM OCRN WHERE CurrCode=@FCCurrency AND CurrCode<>(SELECT MainCurncy FROM OADM)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindRateFC]

@RateDate datetime,
@Currency nvarchar(3)

AS

BEGIN

SELECT Rate FROM ORTT WHERE RateDate=@RateDate AND Currency=@Currency
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectTransId]

AS

DECLARE @TransId int

BEGIN

SET @TransId =(SELECT (SELECT DISTINCT TOP 1 TransId FROM OJDT ORDER BY TransId DESC) + 1 AS TransId)

IF(@TransId IS NULL)
BEGIN 
SELECT 1 AS TransId
END
ELSE
BEGIN
SELECT @TransId AS TransId
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertJournalEntryLines]

@TransId int,
@LineId int,
@RefDate datetime,
@TaxDate datetime,
@DueDate datetime,
@Account nvarchar(15),
@ShortName nvarchar(15),
@LineMemo nvarchar(50),
@TransType nvarchar(20),
@Debit numeric (19,6),
@Credit numeric (19,6),
@SysCred numeric (19,6),
@SysDeb numeric (19,6),
@FCDebit numeric (19,6),
@FCCredit numeric (19,6),
@BalDueDeb numeric (19,6),
@BalDueCred numeric (19,6),
@BalFcDeb numeric (19,6),
@BalFcCred numeric (19,6),
@BalScCred numeric (19,6),
@BalScDeb numeric (19,6),
@UserSign int,
@FinncPriod int,
@FCCurrency nvarchar(3),
@DataSource char(1),
@ContraAct nvarchar(15)

AS

BEGIN

INSERT INTO JDT1 (TransId,Line_ID,RefDate,DueDate,TaxDate,Account,ShortName,LineMemo,TransType, Debit, Credit, FCDebit, FCCredit, SYSDeb, SYSCred, BalDueDeb, BalDueCred, BalFcDeb, BalFcCred,BalScDeb, BalScCred, UserSign, FinncPriod, FCCurrency, DataSource, ContraAct) VALUES(@TransId,@LineId,@RefDate,@DueDate,@TaxDate,@Account,@ShortName,@LineMemo,@TransType, @Debit, @Credit, @FCDebit, @FCCredit, @SysDeb, @SysCred,@BalDueDeb, @BalDueCred, @BalFcDeb, @BalFcCred,@BalScDeb, @BalScCred, @UserSign, @FinncPriod, @FCCurrency, @DataSource,@ContraAct)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateDebitCreditAccount]

@AcctCode nvarchar(15),
@CurrTotal numeric(19,6),
@SysTotal numeric(19,6),
@FcTotal numeric(19,6)

AS

BEGIN

UPDATE OACT SET CurrTotal=(CurrTotal+@CurrTotal), SysTotal=(SysTotal+@SysTotal), FcTotal=(FcTotal+@FcTotal) WHERE AcctCode=@AcctCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectBaseRef]

AS

DECLARE @BaseRef int

BEGIN

SET @BaseRef =(SELECT (SELECT DISTINCT TOP 1 BaseRef FROM OJDT ORDER BY BaseRef DESC) + 1 AS BaseRef)

IF(@BaseRef IS NULL)
BEGIN 
SELECT 1 AS BaseRef
END
ELSE
BEGIN
SELECT @BaseRef AS BaseRef
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAcctName]

@AcctCode nvarchar(15)

AS

BEGIN

DECLARE @AcctName nvarchar(50)

SET @AcctName=(SELECT TOP 1 AcctName AS 'AcctName' FROM OACT WHERE AcctCode=@AcctCode)

IF(@AcctName IS NULL)
BEGIN
SELECT TOP 1 CardName AS 'AcctName' FROM OCRD WHERE CardCode=@AcctCode
END
ELSE
BEGIN
SELECT @AcctName
END
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindJournalEntry]

@TransId int,
@RefDate datetime, 
@TaxDate datetime,
@DueDate datetime,
@Memo nvarchar(50),
@Ref1 nvarchar(100),
@Ref2 nvarchar(100)

AS

BEGIN

SELECT TransId,RefDate,TaxDate,DueDate, Memo,TransType,Ref1,Ref2, BaseRef FROM OJDT WHERE TransId LIKE CAST(@TransId AS nvarchar)+ '%' OR RefDate LIKE CAST(@RefDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DueDate LIKE CAST(@DueDate AS NVARCHAR) + '%' OR Memo LIKE @Memo + '%' OR Ref1 LIKE @Ref1 + '%' OR Ref2 LIKE @Ref2 + '%'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateJournalEntry]

@TransId int,
@TaxDate datetime, 
@DueDate datetime,
@Memo nvarchar(50),
@Ref1 nvarchar(100),
@Ref2 nvarchar(100),
@UserSign smallint,
@UpdateDate datetime

AS

BEGIN

UPDATE OJDT SET TaxDate=@TaxDate, DueDate=@DueDate, Memo=@Memo, Ref1=@Ref1, Ref2=@Ref2, UserSign2=@UserSign, UpdateDate=@UpdateDate WHERE TransId=@TransId

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateJournalEntryLines]

@TransId int,
@LineId int,
@TaxDate datetime, 
@DueDate datetime,
@LineMemo nvarchar(50),
@UserSign smallint

AS

BEGIN

UPDATE JDT1 SET TaxDate=@TaxDate, DueDate=@DueDate, LineMemo=@LineMemo, UserSign=@UserSign WHERE TransId=@TransId AND Line_ID=@LineId

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumOPCH]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM OPCH ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindSuppliers]

AS

BEGIN

SELECT * FROM OCRD WHERE CardType='S'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindBusinessPartnerCurrency]

@CardCode nvarchar(15)

AS

DECLARE @Currency nvarchar(3)

BEGIN

SET @Currency=(SELECT Currency FROM OCRD WHERE CardCode=@CardCode)

IF(@Currency='##')
BEGIN 
SELECT CurrCode, CurrName FROM OCRN
END
ELSE
BEGIN
SELECT CurrCode, CurrName FROM OCRN WHERE CurrCode=@Currency
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPurchaseInvoice]

@DocNum int,
@DocType char(1),
@Canceled char(1),
@DocStatus char(1),
@InvntSttus char(1),
@DocDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@Address2 nvarchar(254),
@TaxDate datetime,
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@VatSum numeric (19,6),
@VatSumFC numeric (19,6),
@VatSumSy numeric (19,6),
@UserSign int,
@UpdateDate datetime,
@FinncPriod int,
@DocCurr nvarchar(3),
@DocTotal numeric (19,6),
@DocTotalFC numeric (19,6),
@DocTotalSy numeric (19,6),
@ObjType nvarchar(20),
@LicTradNum nvarchar(32),
@TransId int,
@VatPaid numeric (19,6),
@VatPaidFC numeric (19,6),
@VatPaidSys numeric (19,6),
@PaidToDate numeric (19,6),
@PaidSum numeric (19,6),
@PaidSumFc numeric (19,6),
@PaidSumSc numeric (19,6),
@WtApplied numeric (19,6),
@WtAppliedF numeric (19,6),
@WtAppliedS numeric (19,6),
@WtSum numeric (19,6),
@WtSumFC numeric (19,6),
@WtSumSC numeric (19,6),
@SysRate numeric (19,6),
@DocRate numeric (19,6),
@CtlAccount nvarchar(15),
@BaseAmnt numeric (19,6),
@BaseAmntFC numeric (19,6),
@BaseAmntSC numeric (19,6),
@DocSubType nvarchar(2),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10)

AS

BEGIN

INSERT INTO OPCH (DocNum,DocType,CANCELED,DocStatus,InvntSttus,DocDate,DocDueDate,CardCode,CardName, Address2, TaxDate, Comments, JrnlMemo, VatSum, VatSumFC,VatSumSy, UserSign, FinncPriod, DocCur, DocTotal, DocTotalFC, DocTotalSy, ObjType, LicTradNum, TransId, VatPaid, VatPaidFC, VatPaidSys, PaidToDate, PaidSum,PaidSumSc, PaidSumFc, WTApplied, WTAppliedF, WTAppliedS, WTSum, WTSumFC, WTSumSC, SysRate, DocRate, CtlAccount, BaseAmnt, BaseAmntFC, BaseAmntSC, DocSubType, NumAtCard, U_IDA_NumControl, U_IDA_TipoTrans, UpdateDate) VALUES(@DocNum,@DocType,@Canceled,@DocStatus,@InvntSttus,@DocDate,@DocDueDate,@CardCode,@CardName, @Address2, @TaxDate, @Comments, @JrnlMemo, @VatSum, @VatSumFC,@VatSumSy, @UserSign, @FinncPriod, @DocCurr, @DocTotal, @DocTotalFC, @DocTotalSy, @ObjType, @LicTradNum, @TransId, @VatPaid, @VatPaidFC, @VatPaidSys, @PaidToDate, @PaidSum,@PaidSumSc, @PaidSumFc, @WtApplied, @WtAppliedF, @WtAppliedS, @WtSum, @WtSumFC, @WtSumSC, @SysRate, @DocRate, @CtlAccount, @BaseAmnt, @BaseAmntFC, @BaseAmntSC, @DocSubType, @NumAtCard, @NumControl, @TipoTrans, @UpdateDate)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindHoldingTax]

AS

BEGIN

SELECT WTCode,WTName,Rate,EffecDate, Category, BaseType, PrctBsAmnt, Account, U_IDA_BaseMinima,U_IDA_Sustraendo FROM OWHT WHERE Inactive='N'

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindTaxRate]

@Code nvarchar(8)

AS

BEGIN

SELECT Rate FROM OSTC WHERE Code=@Code

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindItemPurchase]

AS

BEGIN

SELECT ItemCode, ItemName, OnHand FROM OITM WHERE PrchseItem='Y'

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPurchaseInvoiceLines]

@DocEntry int,
@LineNum int,
@LineStatus char(1),
@ItemCode nvarchar(50),
@Dscription nvarchar(100),
@Quantity numeric (19,6),
@OpenQty numeric (19,6),
@InvQty numeric (19,6),
@OpenInvQty numeric (19,6),
@Price numeric (19,6),
@Currency nvarchar(3),
@LineTotal numeric (19,6),
@AcctCode nvarchar(15),
@DocDate datetime,
@BaseCard nvarchar(15),
@TotalSumSy numeric (19,6),
@TotalFrgn numeric (19,6),
@VatSum numeric (19,6),
@VatSumFrgn numeric (19,6),
@VatSumSy numeric (19,6),
@VatGroup nvarchar(8),
@VatPrcnt numeric (19,6),
@FinncPriod int,
@ObjType nvarchar(20),
@Address nvarchar(254),
@GTotal numeric (19,6),
@GTotalFC numeric (19,6),
@GTotalSC numeric (19,6),
@StockSum numeric (19,6),
@StockSumFc numeric (19,6),
@StockSumSc numeric (19,6),
@InvntSttus char(1),
@WtLiable char(1),
@DataSource char(1)

AS

BEGIN

INSERT INTO PCH1 (DocEntry,LineNum,LineStatus,ItemCode,Dscription,Quantity,OpenQty,InvQty,OpenInvQty,Price,Currency, LineTotal, TotalSumSy, TotalFrgn, VatSum, VatSumFrgn,VatSumSy, VatGroup,VatPrcnt, FinncPriod, ObjType, Address, GTotal, GTotalFC, GTotalSC, StockSum,StockSumFc,StockSumSc, InvntSttus, WtLiable, AcctCode, DocDate, BaseCard, DataSource) VALUES(@DocEntry,@LineNum,@LineStatus,@ItemCode,@Dscription,@Quantity,@OpenQty,@InvQty,@OpenInvQty,@Price,@Currency, @LineTotal, @TotalSumSy, @TotalFrgn, @VatSum, @VatSumFrgn,@VatSumSy, @VatGroup,@VatPrcnt, @FinncPriod, @ObjType, @Address, @GTotal, @GTotalFC, @GTotalSC, @StockSum,@StockSumFc,@StockSumSc, @InvntSttus, @WtLiable,  @AcctCode, @DocDate, @BaseCard, @DataSource)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindDocEntryOPCH]

@DocNum int

AS

BEGIN

SELECT DocEntry FROM OPCH WHERE DocNum=@DocNum

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertTaxHoldingOPCH]

@AbsEntry int,
@WTCode nvarchar(4),
@Rate numeric (19,6),
@TaxbleAmnt numeric (19,6),
@TaxbleAmntSC numeric (19,6),
@TaxbleAmntFC numeric (19,6),
@WTAmnt numeric (19,6),
@WTAmntSC numeric (19,6),
@WTAmntFC numeric (19,6),
@Category char(1),
@Account nvarchar(15),
@Type char(1),
@BaseType char(1),
@LineNum int,
@Status char(1),
@ObjType nvarchar(20),
@BaseAmnt numeric (19,6),
@BaseAmntSC numeric (19,6),
@BaseAmntFC numeric (19,6)

AS

BEGIN

INSERT INTO PCH5 (AbsEntry,WTCode,Rate,TaxbleAmnt,TaxbleAmntFC,TaxbleAmntSC,WTAmnt,WTAmntFC,WTAmntSC,Category,Account,Type, BaseType,LineNum, Status, ObjType,BaseAmnt, BaseAmntFC,BaseAmntSC) VALUES(@AbsEntry,@WTCode,@Rate,@TaxbleAmnt,@TaxbleAmntFC,@TaxbleAmntSC,@WTAmnt,@WTAmntFC,@WTAmntSC,@Category,@Account,@Type, @BaseType,@LineNum, @Status, @ObjType,@BaseAmnt, @BaseAmntFC,@BaseAmntSC)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindTaxAccountOPCH]

@TaxCode nvarchar(8)

AS

BEGIN

SELECT PurchTax FROM OSTA WHERE Code=@TaxCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateDebitCreditAccountBusinessPartner]

@CardCode nvarchar(15),
@Balance numeric(19,6),
@BalanceSys numeric(19,6),
@BalanceFC numeric(19,6)

AS

BEGIN

UPDATE OCRD SET Balance=(Balance+@Balance), BalanceSys=(BalanceSys+@BalanceSys), BalanceFC=(BalanceFC+@BalanceFC) WHERE CardCode=@CardCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateDebitItem]

@ItemCode nvarchar(50),
@StockValue numeric(19,6),
@StockValueFC numeric(19,6),
@StockValueSC numeric(19,6),
@Quantity numeric(19,6)

AS

BEGIN

UPDATE OITM SET StockValue=(StockValue+@StockValue), StockValueFC=(StockValueFC+@StockValueFC), StockValueSC=(StockValueSC+@StockValueSC), OnHand=(OnHand+@Quantity) WHERE ItemCode=@ItemCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextPurchaseInvoice]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select DocNum,LEAD(DocNum) over (order by DocNum) Siguiente
      from OPCH) AS NextQueryPurchaseInvoice
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OPCH WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OPCH ORDER BY DocNum
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchaseInvoiceLines]

@DocEntry int

AS

BEGIN

SELECT DocEntry,ItemCode,Dscription,Quantity,Price,Currency,LineTotal,TotalSumSy,TotalFrgn,DocDate,VatGroup,VatPrcnt,WtLiable,AcctCode, VatSum, VatSumSy, VatSumFrgn, GTotal, GTotalFC, GTotalSC, DataSource FROM PCH1 WHERE DocEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetCurrencyName]

@CurrCode nvarchar(20)

AS

BEGIN

SELECT CurrName FROM OCRN WHERE CurrCode=@CurrCode
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindRetencionImpuesto]

@DocEntry int

AS

BEGIN

SELECT WTCode,Rate,TaxbleAmnt,TaxbleAmntSC,TaxbleAmntFC,WTAmnt,WTAmntSC,WTAmntFC,Category,Account,Type,BaseType,LineNum,BaseAmnt, BaseAmntSC, BaseAmntFC FROM PCH5 WHERE AbsEntry=@DocEntry ORDER BY LineNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindWTName]

@WTCode nvarchar(4)

AS

BEGIN

SELECT WTName FROM OWHT WHERE WTCode=@WTCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousPurchaseInvoice]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select DocNum,LAG(DocNum) over (order by DocNum) Previous
      from OPCH) AS PreviousQueryPurchase
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OPCH WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OPCH ORDER BY DocNum DESC
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstPurchaseInvoice]

AS

BEGIN

SELECT TOP 1 * FROM OPCH ORDER BY DocNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastPurchaseInvoice]

AS

BEGIN

SELECT TOP 1 * FROM OPCH ORDER BY DocNum DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchase]

@DocNum int,
@DocDate datetime, 
@TaxDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@NumAtCard nvarchar(100),
@NumControl nvarchar(100),
@TipoTrans nvarchar(10),
@Comments nvarchar(254)

AS

BEGIN

SELECT * FROM OPCH WHERE DocNum LIKE CAST(@DocNum AS nvarchar)+ '%' OR DocDate LIKE CAST(@DocDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DocDueDate LIKE CAST(@DocDueDate AS NVARCHAR) + '%' OR CardCode LIKE @CardCode + '%' OR CardName LIKE @CardName + '%' OR NumAtCard LIKE @NumAtCard + '%' OR U_IDA_NumControl LIKE @NumControl + '%' OR U_IDA_TipoTrans LIKE @TipoTrans + '%' OR Comments LIKE @Comments + '%'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePurchase]

@DocNum int,
@DocEntry datetime, 
@TaxDate datetime,
@DocDueDate nvarchar(50),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10),
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@LicTradNum nvarchar(32),
@UserSign smallint,
@UpdateDate datetime,
@DocSubType nvarchar(2)

AS

BEGIN

UPDATE OPCH SET TaxDate=@TaxDate, DocDueDate=@DocDueDate, NumAtCard=@NumAtCard, U_IDA_NumControl=@NumControl, U_IDA_TipoTrans=@TipoTrans, Comments=@Comments, JrnlMemo=@JrnlMemo, LicTradNum=@LicTradNum, UserSign2=@UserSign, UpdateDate=@UpdateDate WHERE DocEntry=@DocEntry AND DocSubType=@DocSubType

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePurchaseCreditNote]

@DocNum int,
@DocEntry datetime, 
@TaxDate datetime,
@DocDueDate nvarchar(50),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10),
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@LicTradNum nvarchar(32),
@UserSign smallint,
@UpdateDate datetime

AS

BEGIN

UPDATE ORPC SET TaxDate=@TaxDate, DocDueDate=@DocDueDate, NumAtCard=@NumAtCard, U_IDA_NumControl=@NumControl, U_IDA_TipoTrans=@TipoTrans, Comments=@Comments, JrnlMemo=@JrnlMemo, LicTradNum=@LicTradNum, UserSign2=@UserSign, UpdateDate=@UpdateDate WHERE DocEntry=@DocEntry

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumORPC]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM ORPC ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchaseCreditNote]

@DocNum int,
@DocDate datetime, 
@TaxDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@NumAtCard nvarchar(100),
@NumControl nvarchar(100),
@TipoTrans nvarchar(10),
@Comments nvarchar(254)

AS

BEGIN

SELECT * FROM ORPC WHERE DocNum LIKE CAST(@DocNum AS nvarchar)+ '%' OR DocDate LIKE CAST(@DocDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DocDueDate LIKE CAST(@DocDueDate AS NVARCHAR) + '%' OR CardCode LIKE @CardCode + '%' OR CardName LIKE @CardName + '%' OR NumAtCard LIKE @NumAtCard + '%' OR U_IDA_NumControl LIKE @NumControl + '%' OR U_IDA_TipoTrans LIKE @TipoTrans + '%' OR Comments LIKE @Comments + '%'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstPurchaseCreditNote]

AS

BEGIN

SELECT TOP 1 * FROM ORPC ORDER BY DocNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastPurchaseCreditNote]

AS

BEGIN

SELECT TOP 1 * FROM ORPC ORDER BY DocNum DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousPurchaseCreditNote]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select DocNum,LAG(DocNum) over (order by DocNum) Previous
      from ORPC) AS PreviousQueryPurchaseCreditLine
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM ORPC WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM ORPC ORDER BY DocNum DESC
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextPurchaseCreditNote]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select DocNum,LEAD(DocNum) over (order by DocNum) Siguiente
      from ORPC) AS NextQueryPurchaseCreditNote
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM ORPC WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM ORPC ORDER BY DocNum
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindRetencionImpuestoORPC]

@DocEntry int

AS

BEGIN

SELECT WTCode,Rate,TaxbleAmnt,TaxbleAmntSC,TaxbleAmntFC,WTAmnt,WTAmntSC,WTAmntFC,Category,Account,Type,BaseType,LineNum,BaseAmnt, BaseAmntSC, BaseAmntFC FROM RPC5 WHERE AbsEntry=@DocEntry ORDER BY LineNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertTaxHoldingORPC]

@AbsEntry int,
@WTCode nvarchar(4),
@Rate numeric (19,6),
@TaxbleAmnt numeric (19,6),
@TaxbleAmntSC numeric (19,6),
@TaxbleAmntFC numeric (19,6),
@WTAmnt numeric (19,6),
@WTAmntSC numeric (19,6),
@WTAmntFC numeric (19,6),
@Category char(1),
@Account nvarchar(15),
@Type char(1),
@BaseType char(1),
@LineNum int,
@Status char(1),
@ObjType nvarchar(20),
@BaseAmnt numeric (19,6),
@BaseAmntSC numeric (19,6),
@BaseAmntFC numeric (19,6)

AS

BEGIN

INSERT INTO RPC5 (AbsEntry,WTCode,Rate,TaxbleAmnt,TaxbleAmntFC,TaxbleAmntSC,WTAmnt,WTAmntFC,WTAmntSC,Category,Account,Type, BaseType,LineNum, Status, ObjType,BaseAmnt, BaseAmntFC,BaseAmntSC) VALUES(@AbsEntry,@WTCode,@Rate,@TaxbleAmnt,@TaxbleAmntFC,@TaxbleAmntSC,@WTAmnt,@WTAmntFC,@WTAmntSC,@Category,@Account,@Type, @BaseType,@LineNum, @Status, @ObjType,@BaseAmnt, @BaseAmntFC,@BaseAmntSC)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchaseCreditNoteLines]

@DocEntry int

AS

BEGIN

SELECT DocEntry,ItemCode,Dscription,Quantity,Price,Currency,LineTotal,TotalSumSy,TotalFrgn,DocDate,VatGroup,VatPrcnt,WtLiable,AcctCode, VatSum, VatSumSy, VatSumFrgn, GTotal, GTotalFC, GTotalSC, DataSource FROM RPC1 WHERE DocEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPurchaseCreditNote]

@DocNum int,
@DocType char(1),
@Canceled char(1),
@DocStatus char(1),
@InvntSttus char(1),
@DocDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@Address2 nvarchar(254),
@TaxDate datetime,
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@VatSum numeric (19,6),
@VatSumFC numeric (19,6),
@VatSumSy numeric (19,6),
@UserSign int,
@UpdateDate datetime,
@FinncPriod int,
@DocCurr nvarchar(3),
@DocTotal numeric (19,6),
@DocTotalFC numeric (19,6),
@DocTotalSy numeric (19,6),
@ObjType nvarchar(20),
@LicTradNum nvarchar(32),
@TransId int,
@VatPaid numeric (19,6),
@VatPaidFC numeric (19,6),
@VatPaidSys numeric (19,6),
@PaidToDate numeric (19,6),
@PaidSum numeric (19,6),
@PaidSumFc numeric (19,6),
@PaidSumSc numeric (19,6),
@WtApplied numeric (19,6),
@WtAppliedF numeric (19,6),
@WtAppliedS numeric (19,6),
@WtSum numeric (19,6),
@WtSumFC numeric (19,6),
@WtSumSC numeric (19,6),
@SysRate numeric (19,6),
@DocRate numeric (19,6),
@CtlAccount nvarchar(15),
@BaseAmnt numeric (19,6),
@BaseAmntFC numeric (19,6),
@BaseAmntSC numeric (19,6),
@DocSubType nvarchar(2),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10)

AS

BEGIN

INSERT INTO ORPC (DocNum,DocType,CANCELED,DocStatus,InvntSttus,DocDate,DocDueDate,CardCode,CardName, Address2, TaxDate, Comments, JrnlMemo, VatSum, VatSumFC,VatSumSy, UserSign, FinncPriod, DocCur, DocTotal, DocTotalFC, DocTotalSy, ObjType, LicTradNum, TransId, VatPaid, VatPaidFC, VatPaidSys, PaidToDate, PaidSum,PaidSumSc, PaidSumFc, WTApplied, WTAppliedF, WTAppliedS, WTSum, WTSumFC, WTSumSC, SysRate, DocRate, CtlAccount, BaseAmnt, BaseAmntFC, BaseAmntSC, DocSubType, NumAtCard, U_IDA_NumControl, U_IDA_TipoTrans, UpdateDate) VALUES(@DocNum,@DocType,@Canceled,@DocStatus,@InvntSttus,@DocDate,@DocDueDate,@CardCode,@CardName, @Address2, @TaxDate, @Comments, @JrnlMemo, @VatSum, @VatSumFC,@VatSumSy, @UserSign, @FinncPriod, @DocCurr, @DocTotal, @DocTotalFC, @DocTotalSy, @ObjType, @LicTradNum, @TransId, @VatPaid, @VatPaidFC, @VatPaidSys, @PaidToDate, @PaidSum,@PaidSumSc, @PaidSumFc, @WtApplied, @WtAppliedF, @WtAppliedS, @WtSum, @WtSumFC, @WtSumSC, @SysRate, @DocRate, @CtlAccount, @BaseAmnt, @BaseAmntFC, @BaseAmntSC, @DocSubType, @NumAtCard, @NumControl, @TipoTrans, @UpdateDate)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPurchaseCreditNoteLines]

@DocEntry int,
@LineNum int,
@LineStatus char(1),
@ItemCode nvarchar(50),
@Dscription nvarchar(100),
@Quantity numeric (19,6),
@OpenQty numeric (19,6),
@InvQty numeric (19,6),
@OpenInvQty numeric (19,6),
@Price numeric (19,6),
@Currency nvarchar(3),
@LineTotal numeric (19,6),
@AcctCode nvarchar(15),
@DocDate datetime,
@BaseCard nvarchar(15),
@TotalSumSy numeric (19,6),
@TotalFrgn numeric (19,6),
@VatSum numeric (19,6),
@VatSumFrgn numeric (19,6),
@VatSumSy numeric (19,6),
@VatGroup nvarchar(8),
@VatPrcnt numeric (19,6),
@FinncPriod int,
@ObjType nvarchar(20),
@Address nvarchar(254),
@GTotal numeric (19,6),
@GTotalFC numeric (19,6),
@GTotalSC numeric (19,6),
@StockSum numeric (19,6),
@StockSumFc numeric (19,6),
@StockSumSc numeric (19,6),
@InvntSttus char(1),
@WtLiable char(1),
@DataSource char(1)

AS

BEGIN

INSERT INTO RPC1 (DocEntry,LineNum,LineStatus,ItemCode,Dscription,Quantity,OpenQty,InvQty,OpenInvQty,Price,Currency, LineTotal, TotalSumSy, TotalFrgn, VatSum, VatSumFrgn,VatSumSy, VatGroup,VatPrcnt, FinncPriod, ObjType, Address, GTotal, GTotalFC, GTotalSC, StockSum,StockSumFc,StockSumSc, InvntSttus, WtLiable, AcctCode, DocDate, BaseCard, DataSource) VALUES(@DocEntry,@LineNum,@LineStatus,@ItemCode,@Dscription,@Quantity,@OpenQty,@InvQty,@OpenInvQty,@Price,@Currency, @LineTotal, @TotalSumSy, @TotalFrgn, @VatSum, @VatSumFrgn,@VatSumSy, @VatGroup,@VatPrcnt, @FinncPriod, @ObjType, @Address, @GTotal, @GTotalFC, @GTotalSC, @StockSum,@StockSumFc,@StockSumSc, @InvntSttus, @WtLiable,  @AcctCode, @DocDate, @BaseCard, @DataSource)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateCreditItem]

@ItemCode nvarchar(50),
@StockValue numeric(19,6),
@StockValueFC numeric(19,6),
@StockValueSC numeric(19,6),
@Quantity numeric(19,6)

AS

BEGIN

UPDATE OITM SET StockValue=(StockValue-@StockValue), StockValueFC=(StockValueFC-@StockValueFC), StockValueSC=(StockValueSC-@StockValueSC), OnHand=(OnHand-@Quantity) WHERE ItemCode=@ItemCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumOPCHND]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM OPCH WHERE DocSubType='DM' ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchaseND]

@DocNum int,
@DocDate datetime, 
@TaxDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@NumAtCard nvarchar(100),
@NumControl nvarchar(100),
@TipoTrans nvarchar(10),
@Comments nvarchar(254)

AS

BEGIN

SELECT * FROM OPCH WHERE (DocNum LIKE CAST(@DocNum AS nvarchar)+ '%' OR DocDate LIKE CAST(@DocDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DocDueDate LIKE CAST(@DocDueDate AS NVARCHAR) + '%' OR CardCode LIKE @CardCode + '%' OR CardName LIKE @CardName + '%' OR NumAtCard LIKE @NumAtCard + '%' OR U_IDA_NumControl LIKE @NumControl + '%' OR U_IDA_TipoTrans LIKE @TipoTrans + '%' OR Comments LIKE @Comments + '%') AND DocSubType='DM'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousPurchaseInvoiceND]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select DocNum, LAG(DocNum) over (order by DocNum) Previous
      from OPCH) AS PreviousQueryPurchase
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OPCH WHERE DocNum=@Result AND DocSubType='DM'
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OPCH WHERE DocSubType='DM' ORDER BY DocNum DESC
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstPurchaseInvoiceND]

AS

BEGIN

SELECT TOP 1 * FROM OPCH WHERE DocSubType='DM' ORDER BY DocNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastPurchaseInvoiceND]

AS

BEGIN

SELECT TOP 1 * FROM OPCH WHERE DocSubType='DM' ORDER BY DocNum DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextPurchaseInvoiceND]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select DocNum,LEAD(DocNum) over (order by DocNum) Siguiente
      from OPCH) AS NextQueryPurchaseInvoice
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OPCH WHERE DocNum=@Result AND DocSubType='DM'
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OPCH WHERE DocSubType='DM' ORDER BY DocNum
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindDocEntryOPCHND]

@DocNum int

AS

BEGIN

SELECT DocEntry FROM OPCH WHERE DocNum=@DocNum AND DocSubType='DM'

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumOPDN]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM OPDN ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousEntradaMercancia]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select DocNum, LAG(DocNum) over (order by DocNum) Previous
      from OPDN) AS PreviousQueryEntradaMercancia
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OPDN WHERE DocNum=@Result 
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OPDN ORDER BY DocNum DESC
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstEntradaMercancia]

AS

BEGIN

SELECT TOP 1 * FROM OPDN ORDER BY DocNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastEntradaMercancia]

AS

BEGIN

SELECT TOP 1 * FROM OPDN ORDER BY DocNum DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextEntradaMercancia]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select DocNum,LEAD(DocNum) over (order by DocNum) Siguiente
      from OPDN) AS NextQueryEntradaMercancia
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OPDN WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OPDN ORDER BY DocNum
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertEntradaMercanciaLines]

@DocEntry int,
@LineNum int,
@LineStatus char(1),
@ItemCode nvarchar(50),
@Dscription nvarchar(100),
@Quantity numeric (19,6),
@OpenQty numeric (19,6),
@InvQty numeric (19,6),
@OpenInvQty numeric (19,6),
@Price numeric (19,6),
@Currency nvarchar(3),
@LineTotal numeric (19,6),
@AcctCode nvarchar(15),
@DocDate datetime,
@BaseCard nvarchar(15),
@TotalSumSy numeric (19,6),
@TotalFrgn numeric (19,6),
@VatSum numeric (19,6),
@VatSumFrgn numeric (19,6),
@VatSumSy numeric (19,6),
@VatGroup nvarchar(8),
@VatPrcnt numeric (19,6),
@FinncPriod int,
@ObjType nvarchar(20),
@Address nvarchar(254),
@GTotal numeric (19,6),
@GTotalFC numeric (19,6),
@GTotalSC numeric (19,6),
@StockSum numeric (19,6),
@StockSumFc numeric (19,6),
@StockSumSc numeric (19,6),
@InvntSttus char(1),
@WtLiable char(1),
@DataSource char(1)

AS

BEGIN

INSERT INTO PDN1 (DocEntry,LineNum,LineStatus,ItemCode,Dscription,Quantity,OpenQty,InvQty,OpenInvQty,Price,Currency, LineTotal, TotalSumSy, TotalFrgn, VatSum, VatSumFrgn,VatSumSy, VatGroup,VatPrcnt, FinncPriod, ObjType, Address, GTotal, GTotalFC, GTotalSC, StockSum,StockSumFc,StockSumSc, InvntSttus, WtLiable, AcctCode, DocDate, BaseCard, DataSource) VALUES(@DocEntry,@LineNum,@LineStatus,@ItemCode,@Dscription,@Quantity,@OpenQty,@InvQty,@OpenInvQty,@Price,@Currency, @LineTotal, @TotalSumSy, @TotalFrgn, @VatSum, @VatSumFrgn,@VatSumSy, @VatGroup,@VatPrcnt, @FinncPriod, @ObjType, @Address, @GTotal, @GTotalFC, @GTotalSC, @StockSum,@StockSumFc,@StockSumSc, @InvntSttus, @WtLiable,  @AcctCode, @DocDate, @BaseCard, @DataSource)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertEntradaMercancia]

@DocNum int,
@DocType char(1),
@Canceled char(1),
@DocStatus char(1),
@InvntSttus char(1),
@DocDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@Address2 nvarchar(254),
@TaxDate datetime,
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@VatSum numeric (19,6),
@VatSumFC numeric (19,6),
@VatSumSy numeric (19,6),
@UserSign int,
@UpdateDate datetime,
@FinncPriod int,
@DocCurr nvarchar(3),
@DocTotal numeric (19,6),
@DocTotalFC numeric (19,6),
@DocTotalSy numeric (19,6),
@ObjType nvarchar(20),
@LicTradNum nvarchar(32),
@TransId int,
@VatPaid numeric (19,6),
@VatPaidFC numeric (19,6),
@VatPaidSys numeric (19,6),
@PaidToDate numeric (19,6),
@PaidSum numeric (19,6),
@PaidSumFc numeric (19,6),
@PaidSumSc numeric (19,6),
@WtApplied numeric (19,6),
@WtAppliedF numeric (19,6),
@WtAppliedS numeric (19,6),
@WtSum numeric (19,6),
@WtSumFC numeric (19,6),
@WtSumSC numeric (19,6),
@SysRate numeric (19,6),
@DocRate numeric (19,6),
@CtlAccount nvarchar(15),
@BaseAmnt numeric (19,6),
@BaseAmntFC numeric (19,6),
@BaseAmntSC numeric (19,6),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10)

AS

BEGIN

INSERT INTO OPDN(DocNum,DocType,CANCELED,DocStatus,InvntSttus,DocDate,DocDueDate,CardCode,CardName, Address2, TaxDate, Comments, JrnlMemo, VatSum, VatSumFC,VatSumSy, UserSign, FinncPriod, DocCur, DocTotal, DocTotalFC, DocTotalSy, ObjType, LicTradNum, TransId, VatPaid, VatPaidFC, VatPaidSys, PaidToDate, PaidSum,PaidSumSc, PaidSumFc, WTApplied, WTAppliedF, WTAppliedS, WTSum, WTSumFC, WTSumSC, SysRate, DocRate, CtlAccount, BaseAmnt, BaseAmntFC, BaseAmntSC, NumAtCard, U_IDA_NumControl, U_IDA_TipoTrans, UpdateDate) VALUES(@DocNum,@DocType,@Canceled,@DocStatus,@InvntSttus,@DocDate,@DocDueDate,@CardCode,@CardName, @Address2, @TaxDate, @Comments, @JrnlMemo, @VatSum, @VatSumFC,@VatSumSy, @UserSign, @FinncPriod, @DocCurr, @DocTotal, @DocTotalFC, @DocTotalSy, @ObjType, @LicTradNum, @TransId, @VatPaid, @VatPaidFC, @VatPaidSys, @PaidToDate, @PaidSum,@PaidSumSc, @PaidSumFc, @WtApplied, @WtAppliedF, @WtAppliedS, @WtSum, @WtSumFC, @WtSumSC, @SysRate, @DocRate, @CtlAccount, @BaseAmnt, @BaseAmntFC, @BaseAmntSC, @NumAtCard, @NumControl, @TipoTrans, @UpdateDate)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateEntradaMercancia]

@DocNum int,
@DocEntry datetime, 
@TaxDate datetime,
@DocDueDate nvarchar(50),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10),
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@LicTradNum nvarchar(32),
@UserSign smallint,
@UpdateDate datetime

AS

BEGIN

UPDATE OPDN SET TaxDate=@TaxDate, DocDueDate=@DocDueDate, NumAtCard=@NumAtCard, U_IDA_NumControl=@NumControl, U_IDA_TipoTrans=@TipoTrans, Comments=@Comments, JrnlMemo=@JrnlMemo, LicTradNum=@LicTradNum, UserSign2=@UserSign, UpdateDate=@UpdateDate WHERE DocEntry=@DocEntry

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindRetencionImpuestoOPDN]

@DocEntry int

AS

BEGIN

SELECT WTCode,Rate,TaxbleAmnt,TaxbleAmntSC,TaxbleAmntFC,WTAmnt,WTAmntSC,WTAmntFC,Category,Account,Type,BaseType,LineNum,BaseAmnt, BaseAmntSC, BaseAmntFC FROM PDN5 WHERE AbsEntry=@DocEntry ORDER BY LineNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertTaxHoldingOPDN]

@AbsEntry int,
@WTCode nvarchar(4),
@Rate numeric (19,6),
@TaxbleAmnt numeric (19,6),
@TaxbleAmntSC numeric (19,6),
@TaxbleAmntFC numeric (19,6),
@WTAmnt numeric (19,6),
@WTAmntSC numeric (19,6),
@WTAmntFC numeric (19,6),
@Category char(1),
@Account nvarchar(15),
@Type char(1),
@BaseType char(1),
@LineNum int,
@Status char(1),
@ObjType nvarchar(20),
@BaseAmnt numeric (19,6),
@BaseAmntSC numeric (19,6),
@BaseAmntFC numeric (19,6)

AS

BEGIN

INSERT INTO PDN5 (AbsEntry,WTCode,Rate,TaxbleAmnt,TaxbleAmntFC,TaxbleAmntSC,WTAmnt,WTAmntFC,WTAmntSC,Category,Account,Type, BaseType,LineNum, Status, ObjType,BaseAmnt, BaseAmntFC,BaseAmntSC) VALUES(@AbsEntry,@WTCode,@Rate,@TaxbleAmnt,@TaxbleAmntFC,@TaxbleAmntSC,@WTAmnt,@WTAmntFC,@WTAmntSC,@Category,@Account,@Type, @BaseType,@LineNum, @Status, @ObjType,@BaseAmnt, @BaseAmntFC,@BaseAmntSC)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindDocEntryOPDN]

@DocNum int

AS

BEGIN

SELECT DocEntry FROM OPDN WHERE DocNum=@DocNum

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumOINV]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM OINV ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindSalesInvoiceLines]

@DocEntry int

AS

BEGIN

SELECT DocEntry,ItemCode,Dscription,Quantity,Price,Currency,LineTotal,TotalSumSy,TotalFrgn,DocDate,VatGroup,VatPrcnt,WtLiable,AcctCode, VatSum, VatSumSy, VatSumFrgn, GTotal, GTotalFC, GTotalSC, DataSource FROM INV1 WHERE DocEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindSales]

@DocNum int,
@DocDate datetime, 
@TaxDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@NumAtCard nvarchar(100),
@NumControl nvarchar(100),
@TipoTrans nvarchar(10),
@Comments nvarchar(254)

AS

BEGIN

SELECT * FROM OINV WHERE DocNum LIKE CAST(@DocNum AS nvarchar)+ '%' OR DocDate LIKE CAST(@DocDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DocDueDate LIKE CAST(@DocDueDate AS NVARCHAR) + '%' OR CardCode LIKE @CardCode + '%' OR CardName LIKE @CardName + '%' OR NumAtCard LIKE @NumAtCard + '%' OR U_IDA_NumControl LIKE @NumControl + '%' OR U_IDA_TipoTrans LIKE @TipoTrans + '%' OR Comments LIKE @Comments + '%'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertSalesInvoice]

@DocNum int,
@DocType char(1),
@Canceled char(1),
@DocStatus char(1),
@InvntSttus char(1),
@DocDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@Address2 nvarchar(254),
@TaxDate datetime,
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@VatSum numeric (19,6),
@VatSumFC numeric (19,6),
@VatSumSy numeric (19,6),
@UserSign int,
@UpdateDate datetime,
@FinncPriod int,
@DocCurr nvarchar(3),
@DocTotal numeric (19,6),
@DocTotalFC numeric (19,6),
@DocTotalSy numeric (19,6),
@ObjType nvarchar(20),
@LicTradNum nvarchar(32),
@TransId int,
@VatPaid numeric (19,6),
@VatPaidFC numeric (19,6),
@VatPaidSys numeric (19,6),
@PaidToDate numeric (19,6),
@PaidSum numeric (19,6),
@PaidSumFc numeric (19,6),
@PaidSumSc numeric (19,6),
@WtApplied numeric (19,6),
@WtAppliedF numeric (19,6),
@WtAppliedS numeric (19,6),
@WtSum numeric (19,6),
@WtSumFC numeric (19,6),
@WtSumSC numeric (19,6),
@SysRate numeric (19,6),
@DocRate numeric (19,6),
@CtlAccount nvarchar(15),
@BaseAmnt numeric (19,6),
@BaseAmntFC numeric (19,6),
@BaseAmntSC numeric (19,6),
@DocSubType nvarchar(2),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10)

AS

BEGIN

INSERT INTO OINV (DocNum,DocType,CANCELED,DocStatus,InvntSttus,DocDate,DocDueDate,CardCode,CardName, Address2, TaxDate, Comments, JrnlMemo, VatSum, VatSumFC,VatSumSy, UserSign, FinncPriod, DocCur, DocTotal, DocTotalFC, DocTotalSy, ObjType, LicTradNum, TransId, VatPaid, VatPaidFC, VatPaidSys, PaidToDate, PaidSum,PaidSumSc, PaidSumFc, WTApplied, WTAppliedF, WTAppliedS, WTSum, WTSumFC, WTSumSC, SysRate, DocRate, CtlAccount, BaseAmnt, BaseAmntFC, BaseAmntSC, DocSubType, NumAtCard, U_IDA_NumControl, U_IDA_TipoTrans, UpdateDate) VALUES(@DocNum,@DocType,@Canceled,@DocStatus,@InvntSttus,@DocDate,@DocDueDate,@CardCode,@CardName, @Address2, @TaxDate, @Comments, @JrnlMemo, @VatSum, @VatSumFC,@VatSumSy, @UserSign, @FinncPriod, @DocCurr, @DocTotal, @DocTotalFC, @DocTotalSy, @ObjType, @LicTradNum, @TransId, @VatPaid, @VatPaidFC, @VatPaidSys, @PaidToDate, @PaidSum,@PaidSumSc, @PaidSumFc, @WtApplied, @WtAppliedF, @WtAppliedS, @WtSum, @WtSumFC, @WtSumSC, @SysRate, @DocRate, @CtlAccount, @BaseAmnt, @BaseAmntFC, @BaseAmntSC, @DocSubType, @NumAtCard, @NumControl, @TipoTrans, @UpdateDate)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstSalesInvoice]

AS

BEGIN

SELECT TOP 1 * FROM OINV ORDER BY DocNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastSalesInvoice]

AS

BEGIN

SELECT TOP 1 * FROM OINV ORDER BY DocNum DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousSalesInvoice]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select DocNum, LAG(DocNum) over (order by DocNum) Previous
      from OINV) AS PreviousQueryOINV
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OINV WHERE DocNum=@Result 
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OINV ORDER BY DocNum DESC
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextSalesInvoice]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select DocNum,LEAD(DocNum) over (order by DocNum) Siguiente
      from OINV) AS NextQueryOINV
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OINV WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OINV ORDER BY DocNum
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindRetencionImpuestoSales]

@DocEntry int

AS

BEGIN

SELECT WTCode,Rate,TaxbleAmnt,TaxbleAmntSC,TaxbleAmntFC,WTAmnt,WTAmntSC,WTAmntFC,Category,Account,Type,BaseType,LineNum,BaseAmnt, BaseAmntSC, BaseAmntFC FROM INV5 WHERE AbsEntry=@DocEntry ORDER BY LineNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertSalesInvoiceLines]

@DocEntry int,
@LineNum int,
@LineStatus char(1),
@ItemCode nvarchar(50),
@Dscription nvarchar(100),
@Quantity numeric (19,6),
@OpenQty numeric (19,6),
@InvQty numeric (19,6),
@OpenInvQty numeric (19,6),
@Price numeric (19,6),
@Currency nvarchar(3),
@LineTotal numeric (19,6),
@AcctCode nvarchar(15),
@DocDate datetime,
@BaseCard nvarchar(15),
@TotalSumSy numeric (19,6),
@TotalFrgn numeric (19,6),
@VatSum numeric (19,6),
@VatSumFrgn numeric (19,6),
@VatSumSy numeric (19,6),
@VatGroup nvarchar(8),
@VatPrcnt numeric (19,6),
@FinncPriod int,
@ObjType nvarchar(20),
@Address nvarchar(254),
@GTotal numeric (19,6),
@GTotalFC numeric (19,6),
@GTotalSC numeric (19,6),
@StockSum numeric (19,6),
@StockSumFc numeric (19,6),
@StockSumSc numeric (19,6),
@InvntSttus char(1),
@WtLiable char(1),
@DataSource char(1)


AS

BEGIN

INSERT INTO INV1 (DocEntry,LineNum,LineStatus,ItemCode,Dscription,Quantity,OpenQty,InvQty,OpenInvQty,Price,Currency, LineTotal, TotalSumSy, TotalFrgn, VatSum, VatSumFrgn,VatSumSy, VatGroup,VatPrcnt, FinncPriod, ObjType, Address, GTotal, GTotalFC, GTotalSC, StockSum,StockSumFc,StockSumSc, InvntSttus, WtLiable, AcctCode, DocDate, BaseCard, DataSource) VALUES(@DocEntry,@LineNum,@LineStatus,@ItemCode,@Dscription,@Quantity,@OpenQty,@InvQty,@OpenInvQty,@Price,@Currency, @LineTotal, @TotalSumSy, @TotalFrgn, @VatSum, @VatSumFrgn,@VatSumSy, @VatGroup,@VatPrcnt, @FinncPriod, @ObjType, @Address, @GTotal, @GTotalFC, @GTotalSC, @StockSum,@StockSumFc,@StockSumSc, @InvntSttus, @WtLiable,  @AcctCode, @DocDate, @BaseCard, @DataSource)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertTaxHoldingOINV]

@AbsEntry int,
@WTCode nvarchar(4),
@Rate numeric (19,6),
@TaxbleAmnt numeric (19,6),
@TaxbleAmntSC numeric (19,6),
@TaxbleAmntFC numeric (19,6),
@WTAmnt numeric (19,6),
@WTAmntSC numeric (19,6),
@WTAmntFC numeric (19,6),
@Category char(1),
@Account nvarchar(15),
@Type char(1),
@BaseType char(1),
@LineNum int,
@Status char(1),
@ObjType nvarchar(20),
@BaseAmnt numeric (19,6),
@BaseAmntSC numeric (19,6),
@BaseAmntFC numeric (19,6)

AS

BEGIN

INSERT INTO INV5 (AbsEntry,WTCode,Rate,TaxbleAmnt,TaxbleAmntFC,TaxbleAmntSC,WTAmnt,WTAmntFC,WTAmntSC,Category,Account,Type, BaseType,LineNum, Status, ObjType,BaseAmnt, BaseAmntFC,BaseAmntSC) VALUES(@AbsEntry,@WTCode,@Rate,@TaxbleAmnt,@TaxbleAmntFC,@TaxbleAmntSC,@WTAmnt,@WTAmntFC,@WTAmntSC,@Category,@Account,@Type, @BaseType,@LineNum, @Status, @ObjType,@BaseAmnt, @BaseAmntFC,@BaseAmntSC)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindDocEntryOINV]

@DocNum int

AS

BEGIN

SELECT DocEntry FROM OINV WHERE DocNum=@DocNum

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateSales]

@DocNum int,
@DocEntry datetime, 
@TaxDate datetime,
@DocDueDate nvarchar(50),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10),
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@LicTradNum nvarchar(32),
@UserSign smallint,
@UpdateDate datetime,
@DocSubType nvarchar(2)

AS

BEGIN

UPDATE OINV SET TaxDate=@TaxDate, DocDueDate=@DocDueDate, NumAtCard=@NumAtCard, U_IDA_NumControl=@NumControl, U_IDA_TipoTrans=@TipoTrans, Comments=@Comments, JrnlMemo=@JrnlMemo, LicTradNum=@LicTradNum, UserSign2=@UserSign, UpdateDate=@UpdateDate WHERE DocEntry=@DocEntry AND DocSubType=@DocSubType

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumOINVND]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM OINV WHERE DocSubType='DM' ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindSalesND]

@DocNum int,
@DocDate datetime, 
@TaxDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@NumAtCard nvarchar(100),
@NumControl nvarchar(100),
@TipoTrans nvarchar(10),
@Comments nvarchar(254)

AS

BEGIN

SELECT * FROM OINV WHERE (DocNum LIKE CAST(@DocNum AS nvarchar)+ '%' OR DocDate LIKE CAST(@DocDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DocDueDate LIKE CAST(@DocDueDate AS NVARCHAR) + '%' OR CardCode LIKE @CardCode + '%' OR CardName LIKE @CardName + '%' OR NumAtCard LIKE @NumAtCard + '%' OR U_IDA_NumControl LIKE @NumControl + '%' OR U_IDA_TipoTrans LIKE @TipoTrans + '%' OR Comments LIKE @Comments + '%') AND DocSubType='DM'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousSalesInvoiceND]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select DocNum, LAG(DocNum) over (order by DocNum) Previous
      from OINV) AS PreviousQuerySales
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OINV WHERE DocNum=@Result AND DocSubType='DM'
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OINV WHERE DocSubType='DM' ORDER BY DocNum DESC
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstSalesInvoiceND]

AS

BEGIN

SELECT TOP 1 * FROM OINV WHERE DocSubType='DM' ORDER BY DocNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastSalesInvoiceND]

AS

BEGIN

SELECT TOP 1 * FROM OINV WHERE DocSubType='DM' ORDER BY DocNum DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextSalesInvoiceND]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select DocNum,LEAD(DocNum) over (order by DocNum) Siguiente
      from OINV) AS NextQuerySalesInvoice
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OINV WHERE DocNum=@Result AND DocSubType='DM'
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OINV WHERE DocSubType='DM' ORDER BY DocNum
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindDocEntryOINVND]

@DocNum int

AS

BEGIN

SELECT DocEntry FROM OINV WHERE DocNum=@DocNum AND DocSubType='DM'

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindCustomer]

AS

BEGIN

SELECT * FROM OCRD WHERE CardType='C'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumORIN]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM ORIN ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindSalesCreditNoteLines]

@DocEntry int

AS

BEGIN

SELECT DocEntry,ItemCode,Dscription,Quantity,Price,Currency,LineTotal,TotalSumSy,TotalFrgn,DocDate,VatGroup,VatPrcnt,WtLiable,AcctCode, VatSum, VatSumSy, VatSumFrgn, GTotal, GTotalFC, GTotalSC, DataSource FROM RIN1 WHERE DocEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindSalesCreditNote]

@DocNum int,
@DocDate datetime, 
@TaxDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@NumAtCard nvarchar(100),
@NumControl nvarchar(100),
@TipoTrans nvarchar(10),
@Comments nvarchar(254)

AS

BEGIN

SELECT * FROM ORIN WHERE DocNum LIKE CAST(@DocNum AS nvarchar)+ '%' OR DocDate LIKE CAST(@DocDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DocDueDate LIKE CAST(@DocDueDate AS NVARCHAR) + '%' OR CardCode LIKE @CardCode + '%' OR CardName LIKE @CardName + '%' OR NumAtCard LIKE @NumAtCard + '%' OR U_IDA_NumControl LIKE @NumControl + '%' OR U_IDA_TipoTrans LIKE @TipoTrans + '%' OR Comments LIKE @Comments + '%'
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertSalesCreditNote]

@DocNum int,
@DocType char(1),
@Canceled char(1),
@DocStatus char(1),
@InvntSttus char(1),
@DocDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@Address2 nvarchar(254),
@TaxDate datetime,
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@VatSum numeric (19,6),
@VatSumFC numeric (19,6),
@VatSumSy numeric (19,6),
@UserSign int,
@UpdateDate datetime,
@FinncPriod int,
@DocCurr nvarchar(3),
@DocTotal numeric (19,6),
@DocTotalFC numeric (19,6),
@DocTotalSy numeric (19,6),
@ObjType nvarchar(20),
@LicTradNum nvarchar(32),
@TransId int,
@VatPaid numeric (19,6),
@VatPaidFC numeric (19,6),
@VatPaidSys numeric (19,6),
@PaidToDate numeric (19,6),
@PaidSum numeric (19,6),
@PaidSumFc numeric (19,6),
@PaidSumSc numeric (19,6),
@WtApplied numeric (19,6),
@WtAppliedF numeric (19,6),
@WtAppliedS numeric (19,6),
@WtSum numeric (19,6),
@WtSumFC numeric (19,6),
@WtSumSC numeric (19,6),
@SysRate numeric (19,6),
@DocRate numeric (19,6),
@CtlAccount nvarchar(15),
@BaseAmnt numeric (19,6),
@BaseAmntFC numeric (19,6),
@BaseAmntSC numeric (19,6),
@DocSubType nvarchar(2),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10)

AS

BEGIN

INSERT INTO ORIN(DocNum,DocType,CANCELED,DocStatus,InvntSttus,DocDate,DocDueDate,CardCode,CardName, Address2, TaxDate, Comments, JrnlMemo, VatSum, VatSumFC,VatSumSy, UserSign, FinncPriod, DocCur, DocTotal, DocTotalFC, DocTotalSy, ObjType, LicTradNum, TransId, VatPaid, VatPaidFC, VatPaidSys, PaidToDate, PaidSum,PaidSumSc, PaidSumFc, WTApplied, WTAppliedF, WTAppliedS, WTSum, WTSumFC, WTSumSC, SysRate, DocRate, CtlAccount, BaseAmnt, BaseAmntFC, BaseAmntSC, DocSubType, NumAtCard, U_IDA_NumControl, U_IDA_TipoTrans, UpdateDate) VALUES(@DocNum,@DocType,@Canceled,@DocStatus,@InvntSttus,@DocDate,@DocDueDate,@CardCode,@CardName, @Address2, @TaxDate, @Comments, @JrnlMemo, @VatSum, @VatSumFC,@VatSumSy, @UserSign, @FinncPriod, @DocCurr, @DocTotal, @DocTotalFC, @DocTotalSy, @ObjType, @LicTradNum, @TransId, @VatPaid, @VatPaidFC, @VatPaidSys, @PaidToDate, @PaidSum,@PaidSumSc, @PaidSumFc, @WtApplied, @WtAppliedF, @WtAppliedS, @WtSum, @WtSumFC, @WtSumSC, @SysRate, @DocRate, @CtlAccount, @BaseAmnt, @BaseAmntFC, @BaseAmntSC, @DocSubType, @NumAtCard, @NumControl, @TipoTrans, @UpdateDate)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LastSalesCreditNote]

AS

BEGIN

SELECT TOP 1 * FROM ORIN ORDER BY DocNum DESC
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateSalesCreditNote]

@DocNum int,
@DocEntry datetime, 
@TaxDate datetime,
@DocDueDate nvarchar(50),
@NumAtCard nvarchar(100),
@NumControl nvarchar(20),
@TipoTrans nvarchar(10),
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@LicTradNum nvarchar(32),
@UserSign smallint,
@UpdateDate datetime

AS

BEGIN

UPDATE ORIN SET TaxDate=@TaxDate, DocDueDate=@DocDueDate, NumAtCard=@NumAtCard, U_IDA_NumControl=@NumControl, U_IDA_TipoTrans=@TipoTrans, Comments=@Comments, JrnlMemo=@JrnlMemo, LicTradNum=@LicTradNum, UserSign2=@UserSign, UpdateDate=@UpdateDate WHERE DocEntry=@DocEntry

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindRetencionImpuestoORIN]

@DocEntry int

AS

BEGIN

SELECT WTCode,Rate,TaxbleAmnt,TaxbleAmntSC,TaxbleAmntFC,WTAmnt,WTAmntSC,WTAmntFC,Category,Account,Type,BaseType,LineNum,BaseAmnt, BaseAmntSC, BaseAmntFC FROM RIN5 WHERE AbsEntry=@DocEntry ORDER BY LineNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextSalesCreditNote]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select DocNum,LEAD(DocNum) over (order by DocNum) Siguiente
      from ORIN) AS NextQuerySalesCreditNote
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM ORIN WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM ORIN ORDER BY DocNum
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstSalesCreditNote]

AS

BEGIN

SELECT TOP 1 * FROM ORIN ORDER BY DocNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousSalesCreditNote]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select DocNum,LAG(DocNum) over (order by DocNum) Previous
      from ORIN) AS PreviousQuerySalesCreditLine
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM ORIN WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM ORIN ORDER BY DocNum DESC
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertSalesCreditNoteLines]

@DocEntry int,
@LineNum int,
@LineStatus char(1),
@ItemCode nvarchar(50),
@Dscription nvarchar(100),
@Quantity numeric (19,6),
@OpenQty numeric (19,6),
@InvQty numeric (19,6),
@OpenInvQty numeric (19,6),
@Price numeric (19,6),
@Currency nvarchar(3),
@LineTotal numeric (19,6),
@AcctCode nvarchar(15),
@DocDate datetime,
@BaseCard nvarchar(15),
@TotalSumSy numeric (19,6),
@TotalFrgn numeric (19,6),
@VatSum numeric (19,6),
@VatSumFrgn numeric (19,6),
@VatSumSy numeric (19,6),
@VatGroup nvarchar(8),
@VatPrcnt numeric (19,6),
@FinncPriod int,
@ObjType nvarchar(20),
@Address nvarchar(254),
@GTotal numeric (19,6),
@GTotalFC numeric (19,6),
@GTotalSC numeric (19,6),
@StockSum numeric (19,6),
@StockSumFc numeric (19,6),
@StockSumSc numeric (19,6),
@InvntSttus char(1),
@WtLiable char(1),
@DataSource char(1)

AS

BEGIN

INSERT INTO RIN1 (DocEntry,LineNum,LineStatus,ItemCode,Dscription,Quantity,OpenQty,InvQty,OpenInvQty,Price,Currency, LineTotal, TotalSumSy, TotalFrgn, VatSum, VatSumFrgn,VatSumSy, VatGroup,VatPrcnt, FinncPriod, ObjType, Address, GTotal, GTotalFC, GTotalSC, StockSum,StockSumFc,StockSumSc, InvntSttus, WtLiable, AcctCode, DocDate, BaseCard, DataSource) VALUES(@DocEntry,@LineNum,@LineStatus,@ItemCode,@Dscription,@Quantity,@OpenQty,@InvQty,@OpenInvQty,@Price,@Currency, @LineTotal, @TotalSumSy, @TotalFrgn, @VatSum, @VatSumFrgn,@VatSumSy, @VatGroup,@VatPrcnt, @FinncPriod, @ObjType, @Address, @GTotal, @GTotalFC, @GTotalSC, @StockSum,@StockSumFc,@StockSumSc, @InvntSttus, @WtLiable,  @AcctCode, @DocDate, @BaseCard, @DataSource)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertTaxHoldingORIN]

@AbsEntry int,
@WTCode nvarchar(4),
@Rate numeric (19,6),
@TaxbleAmnt numeric (19,6),
@TaxbleAmntSC numeric (19,6),
@TaxbleAmntFC numeric (19,6),
@WTAmnt numeric (19,6),
@WTAmntSC numeric (19,6),
@WTAmntFC numeric (19,6),
@Category char(1),
@Account nvarchar(15),
@Type char(1),
@BaseType char(1),
@LineNum int,
@Status char(1),
@ObjType nvarchar(20),
@BaseAmnt numeric (19,6),
@BaseAmntSC numeric (19,6),
@BaseAmntFC numeric (19,6)

AS

BEGIN

INSERT INTO RIN5 (AbsEntry,WTCode,Rate,TaxbleAmnt,TaxbleAmntFC,TaxbleAmntSC,WTAmnt,WTAmntFC,WTAmntSC,Category,Account,Type, BaseType,LineNum, Status, ObjType,BaseAmnt, BaseAmntFC,BaseAmntSC) VALUES(@AbsEntry,@WTCode,@Rate,@TaxbleAmnt,@TaxbleAmntFC,@TaxbleAmntSC,@WTAmnt,@WTAmntFC,@WTAmntSC,@Category,@Account,@Type, @BaseType,@LineNum, @Status, @ObjType,@BaseAmnt, @BaseAmntFC,@BaseAmntSC)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindDocEntryORIN]

@DocNum int

AS

BEGIN

SELECT DocEntry FROM ORIN WHERE DocNum=@DocNum

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindDocEntryORPC]

@DocNum int

AS

BEGIN

SELECT DocEntry FROM ORPC WHERE DocNum=@DocNum

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumODLN]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM ODLN ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteAccount]
@AcctCode nvarchar(15)
AS

BEGIN


DECLARE @AcctCodePCH1 int
DECLARE @AcctCodePCH5 int
DECLARE @AcctCodeINV1 int
DECLARE @AcctCodeINV5 int
DECLARE @AcctCodeDLN1 int
DECLARE @AcctCodeDLN5 int
DECLARE @AcctCodeRPC1 int
DECLARE @AcctCodeRPC5 int
DECLARE @AcctCodePDN1 int
DECLARE @AcctCodePDN5 int
DECLARE @AcctCodeRIN1 int
DECLARE @AcctCodeRIN5 int
DECLARE @AcctCodeOCRD int
DECLARE @AcctCodeOWHT int
DECLARE @AcctCodeJDT1 int
DECLARE @AcctCodeOSTASales int
DECLARE @AcctCodeOSTAPurchase int
DECLARE @Result int

SET @AcctCodePCH1 = (SELECT COUNT(AcctCode) FROM PCH1 WHERE AcctCode=@AcctCode)
SET @AcctCodePCH5 = (SELECT COUNT(Account) FROM PCH5 WHERE Account=@AcctCode)
SET @AcctCodeINV1 = (SELECT COUNT(AcctCode) FROM INV1 WHERE AcctCode=@AcctCode)
SET @AcctCodeINV5 = (SELECT COUNT(Account) FROM INV5 WHERE Account=@AcctCode)
SET @AcctCodeDLN1 = (SELECT COUNT(AcctCode) FROM DLN1 WHERE AcctCode=@AcctCode)
SET @AcctCodeDLN5 = (SELECT COUNT(Account) FROM DLN5 WHERE Account=@AcctCode)
SET @AcctCodeRPC1 = (SELECT COUNT(AcctCode) FROM RPC1 WHERE AcctCode=@AcctCode)
SET @AcctCodeRPC5 = (SELECT COUNT(Account) FROM RPC5 WHERE Account=@AcctCode)
SET @AcctCodePDN1 = (SELECT COUNT(AcctCode) FROM PDN1 WHERE AcctCode=@AcctCode)
SET @AcctCodePDN5 = (SELECT COUNT(Account) FROM PDN5 WHERE Account=@AcctCode)
SET @AcctCodeRIN1 = (SELECT COUNT(AcctCode) FROM RIN1 WHERE AcctCode=@AcctCode)
SET @AcctCodeRIN5 = (SELECT COUNT(Account) FROM RIN5 WHERE Account=@AcctCode)
SET @AcctCodeOCRD = (SELECT COUNT(DebPayAcct) FROM OCRD WHERE DebPayAcct=@AcctCode)
SET @AcctCodeOWHT = (SELECT COUNT(Account) FROM OWHT WHERE Account=@AcctCode)
SET @AcctCodeJDT1 = (SELECT COUNT(Account) FROM JDT1 WHERE Account=@AcctCode)
SET @AcctCodeOSTASales = (SELECT COUNT(PurchTax) FROM OSTA WHERE SalesTax=@AcctCode)
SET @AcctCodeOSTAPurchase = (SELECT COUNT(PurchTax) FROM OSTA WHERE PurchTax=@AcctCode)

SET @Result=@AcctCodeDLN1+@AcctCodeDLN5+@AcctCodeINV1+@AcctCodeINV5+@AcctCodeJDT1+@AcctCodeOCRD+@AcctCodeOSTAPurchase+@AcctCodeOSTASales+@AcctCodeOWHT+@AcctCodePCH1+@AcctCodePCH5+@AcctCodePDN1+@AcctCodePDN5+@AcctCodeRIN1+@AcctCodeRIN5+@AcctCodeRPC1+@AcctCodeRPC5

IF (@Result=0)
BEGIN
DELETE FROM OACT WHERE AcctCode=@AcctCode
END
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PreviousPaymentMade]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Previous
FROM
    (Select DocNum,LAG(DocNum) over (order by DocNum) Previous
      from OVPM) AS PreviousPaymentMade
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OVPM WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OVPM ORDER BY DocNum DESC
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NextPaymentMade]

@DocNum int

AS

BEGIN

DECLARE @Result int

SET @Result=(SELECT Siguiente
FROM
    (Select DocNum,LEAD(DocNum) over (order by DocNum) Siguiente
      from OVPM) AS NextQueryPaymentMade
 Where DocNum=@DocNum)

 IF(@Result<>'')
 BEGIN
 SELECT * FROM OVPM WHERE DocNum=@Result
 END
 ELSE
 IF(@Result IS NULL)
 BEGIN
 SELECT TOP 1 * FROM OVPM ORDER BY DocNum
 END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FirstPaymentMade]

AS

BEGIN

DECLARE @Query int

SET @Query=(SELECT COUNT(*) FROM OVPM)

IF(@Query>0)
BEGIN
SELECT TOP 1 * FROM OVPM ORDER BY DocNum
END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LastPaymentMade]

AS

BEGIN

DECLARE @Query int

SET @Query=(SELECT COUNT(*) FROM OVPM)

IF(@Query>0)
BEGIN
SELECT TOP 1 * FROM OVPM ORDER BY DocNum DESC
END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchaseInvoiceBusinessPartner]

@CardCode nvarchar(15)

AS

BEGIN

SELECT DocNum,ObjType,CAST(CONVERT(nvarchar,DocDate,103)AS nvarchar) AS 'DocDate', DocCur, CAST(DocTotalSy AS decimal (19,2)) AS 'DocTotalSy', CAST(PaidSys AS decimal (19,2)) AS 'PaidSys',
CASE 
			WHEN DocCur=(SELECT MainCurncy FROM OADM) THEN CAST(DocTotal AS decimal (19,2))
			ELSE CAST(DocTotalFC AS decimal (19,2))
			END AS 'DocTotal',
CASE 
			WHEN DocCur=(SELECT MainCurncy FROM OADM) THEN CAST(DocTotalFC AS decimal (19,2))
			ELSE CAST(DocTotal AS decimal (19,2))
			END AS 'DocTotalFrgn',	
CASE 
			WHEN DocCur=(SELECT MainCurncy FROM OADM) THEN CAST(PaidToDate AS decimal (19,2))
			ELSE CAST(PaidFC AS decimal (19,2))
			END AS 'Paid',
CASE 
			WHEN DocCur=(SELECT MainCurncy FROM OADM) THEN CAST(PaidFC AS decimal (19,2))
			ELSE CAST(PaidToDate AS decimal (19,2))
			END AS 'PaidFC'	
FROM OPCH
WHERE CardCode=@CardCode AND DocStatus='O'

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectDocNumOVPM]

AS

DECLARE @DocNum int

BEGIN

SET @DocNum =(SELECT (SELECT DISTINCT TOP 1 DocNum FROM OVPM ORDER BY DocNum DESC) + 1 AS DocNum)

IF(@DocNum IS NULL)
BEGIN 
SELECT 1 AS DocNum
END
ELSE
BEGIN
SELECT @DocNum AS DocNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPayment]

@DocNum int,
@DocDate datetime, 
@TaxDate datetime,
@DocDueDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@Address nvarchar(254),
@CounterRef nvarchar(8),
@JrnlMemo nvarchar(50),
@TransId int

AS

BEGIN

DECLARE @Query int

SET @Query=(SELECT COUNT(*) FROM OVPM WHERE DocNum LIKE CAST(@DocNum AS nvarchar)+ '%' OR DocDate LIKE CAST(@DocDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DocDueDate LIKE CAST(@DocDueDate AS NVARCHAR) + '%' OR CardCode LIKE @CardCode + '%' OR CardName LIKE @CardName + '%' OR Address LIKE @Address + '%' OR CounterRef LIKE @CounterRef + '%' OR JrnlMemo LIKE @JrnlMemo + '%' OR TransId LIKE CAST(@TransId AS nvarchar) + '%')

IF(@Query>0)
BEGIN
SELECT * FROM OVPM WHERE DocNum LIKE CAST(@DocNum AS nvarchar)+ '%' OR DocDate LIKE CAST(@DocDate AS nvarchar) + '%' OR TaxDate LIKE CAST(@TaxDate AS nvarchar)+ '%' OR DocDueDate LIKE CAST(@DocDueDate AS NVARCHAR) + '%' OR CardCode LIKE @CardCode + '%' OR CardName LIKE @CardName + '%' OR Address LIKE @Address + '%' OR CounterRef LIKE @CounterRef + '%' OR JrnlMemo LIKE @JrnlMemo + '%' OR TransId LIKE CAST(@TransId AS nvarchar) + '%'
END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPaymentMadeLines]

@DocEntry int

AS

BEGIN

SELECT DocNum FROM VPM2 WHERE DocNum=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDocumentAccount]

@DocNum int

AS

BEGIN

SELECT CtlAccount FROM OPCH WHERE DocNum=@DocNum

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPaymentMade]

@DocNum int,
@DocDate datetime,
@TaxDate datetime,
@DocDueDate datetime,
@Comments nvarchar(254),
@DocType char(1),
@Canceled char(1),
@UserSign int,
@UpdateDate datetime,
@FinncPriod int,
@Address nvarchar(254),
@ObjType nvarchar(20),
@CardCode nvarchar(15),
@CardName nvarchar(100),
@JrnlMemo nvarchar(50),
@DocCurr nvarchar(3),
@DocTotal numeric (19,6),
@DocTotalFC numeric (19,6),
@DocTotalSy numeric (19,6),
@TransId int,
@SysRate numeric (19,6),
@DocRate numeric (19,6),
@BpAct nvarchar(15),
@CashAcct nvarchar(15),
@CashSum numeric (19,6),
@CashSumFC numeric (19,6),
@CashSumSy numeric (19,6),
@TrsfrAcct nvarchar(15),
@TrsfrSum numeric (19,6),
@TrsfrSumFC numeric (19,6),
@TrsfrSumSy numeric (19,6),
@TrsfrDate datetime,
@TrsfrRef nvarchar(27),
@CheckAcct nvarchar (15),
@CheckSum numeric (19,6),
@CheckSumFC numeric (19,6),
@CheckSumSy numeric (19,6),
@PayNoDoc char(1),
@NoDocSum numeric (19,6),
@NoDocSumFC numeric (19,6),
@NoDocSumSy numeric (19,6),
@CounterRef nvarchar(8)

AS

BEGIN

INSERT INTO OVPM (DocNum,DocDate,TaxDate,DocDueDate,Comments,DocType,Canceled,UserSign,UpdateDate, FinncPriod,Address, ObjType, CardCode,CardName,JrnlMemo, DocCurr, DocTotal, DocTotalFC,DocTotalSy,TransId,SysRate,DocRate,BpAct,CashAcct,CashSum,CashSumFC,CashSumSy,TrsfrAcct,TrsfrSum,TrsfrSumFC,TrsfrSumSy,TrsfrDate,TrsfrRef,CheckAcct,CheckSum,CheckSumSy,CheckSumFC,PayNoDoc,NoDocSum,NoDocSumFC,NoDocSumSy,CounterRef ) VALUES(@DocNum,@DocDate,@TaxDate,@DocDueDate,@Comments,@DocType,@Canceled,@UserSign,@UpdateDate, @FinncPriod,@Address, @ObjType, @CardCode,@CardName,@JrnlMemo, @DocCurr, @DocTotal, @DocTotalFC,@DocTotalSy,@TransId,@SysRate,@DocRate,@BpAct,@CashAcct,@CashSum,@CashSumFC,@CashSumSy,@TrsfrAcct,@TrsfrSum,@TrsfrSumFC,@TrsfrSumSy,@TrsfrDate,@TrsfrRef,@CheckAcct,@CheckSum,@CheckSumSy,@CheckSumFC,@PayNoDoc,@NoDocSum,@NoDocSumFC,@NoDocSumSy,@CounterRef) 

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPaymentMadeLines]

@DocNum int,
@InvoiceId int,
@DocEntry int,
@SumApplied numeric (19,6),
@AppliedFC numeric (19,6),
@AppliedSys numeric (19,6),
@VatApplied numeric (19,6),
@VatAppldFC numeric (19,6),
@VatAppldSy numeric (19,6),
@WtInvCatS numeric (19,6),
@WtInvCatSF numeric (19,6),
@WtInvCatSS numeric (19,6),
@InvType nvarchar(20),
@ObjType nvarchar(20),
@DocSubType nvarchar(2),
@DocTransId int,
@DocRate numeric (19,6),
@U_IDA_CompIVA nvarchar(20),
@U_IDA_FechaComp datetime,
@U_IDA_MontoCompIVA numeric (19,6),
@U_IDA_CompISLR nvarchar(20),
@U_IDA_DateCompISLR datetime

AS

BEGIN

INSERT INTO VPM2 (DocNum,InvoiceId,DocEntry,SumApplied,AppliedFC,AppliedSys,vatApplied,vatAppldFC,vatAppldSy, WtInvCatS,WtInvCatSF,WtInvCatSS,InvType,ObjType,DocSubType,DocTransId,DocRate,U_IDA_CompIVA,U_IDA_FechaComp,U_IDA_MontoCompIVA,U_IDA_CompISLR,U_IDA_DateCompISLR) VALUES(@DocNum,@InvoiceId,@DocEntry,@SumApplied,@AppliedFC,@AppliedSys,@vatApplied,@vatAppldFC,@vatAppldSy, @WtInvCatS,@WtInvCatSF,@WtInvCatSS,@InvType,@ObjType,@DocSubType,@DocTransId,@DocRate,@U_IDA_CompIVA,@U_IDA_FechaComp,@U_IDA_MontoCompIVA,@U_IDA_CompISLR,@U_IDA_DateCompISLR) 

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchaseSpecific]

@DocNum int

AS

BEGIN

SELECT * FROM OPCH WHERE DocNum=@DocNum
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletePaymentMade]

@DocNum int

AS

BEGIN

DECLARE @CON INT

SET @CON=@DocNum-1

DELETE FROM OVPM WHERE DocNum=@DocNum

DBCC CHECKIDENT ('OVPM', RESEED, @CON)
DBCC CHECKIDENT ('OVPM', RESEED, @CON)
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePaymentMadePurchase]

@DocEntry int,
@PaidToDate numeric (19,6),
@PaidFC numeric (19,6),
@PaidSys numeric (19,6),
@PaidSum numeric (19,6),
@PaidSumFc numeric (19,6),
@PaidSumSc numeric (19,6)


AS

BEGIN

UPDATE OPCH SET PaidToDate=@PaidToDate, PaidFC=@PaidFC, PaidSys=@PaidSys, PaidSum=@PaidSum, PaidSumFc=@PaidSumFc, PaidSumSc=@PaidSumSc, DocStatus='C' WHERE DocEntry=@DocEntry

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchaseInvoiceBusinessPartnerSpecific]

@DocEntry int

AS

BEGIN

select	T0.[DocNum],
		T0.[DocDate],
		T0.[ObjType], 
		T0.[DocCur], 
		T0.[DocTotalSy],
		T0.[PaidSys],
		T1.[U_IDA_CompIVA],
		T1.[U_IDA_FechaComp],
		T1.[U_IDA_MontoCompIVA],
		T1.[U_IDA_DateCompISLR],
		T1.[U_IDA_CompISLR],
		CASE 
			WHEN T0.[DocCur]=(SELECT MainCurncy FROM OADM) THEN CAST(T0.[DocTotal] AS decimal (19,2))
			ELSE CAST(T0.[DocTotalFC] AS decimal (19,2))
			END AS 'DocTotal',
CASE 
			WHEN T0.[DocCur]=(SELECT MainCurncy FROM OADM) THEN CAST(T0.[DocTotalFC] AS decimal (19,2))
			ELSE CAST(T0.[DocTotal] AS decimal (19,2))
			END AS 'DocTotalFrgn',	
CASE 
			WHEN T0.[DocCur]=(SELECT MainCurncy FROM OADM) THEN CAST(T0.[PaidToDate] AS decimal (19,2))
			ELSE CAST(T0.[PaidFC] AS decimal (19,2))
			END AS 'Paid',
CASE 
			WHEN T0.[DocCur]=(SELECT MainCurncy FROM OADM) THEN CAST([PaidFC] AS decimal (19,2))
			ELSE CAST(T0.[PaidToDate] AS decimal (19,2))
			END AS 'PaidFC'
		from [OPCH] T0
	    INNER JOIN [VPM2] T1 ON T1.[DocEntry]=T0.[DocEntry]
		WHERE T0.[DocEntry]=@DocEntry

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindPurchaseInvoiceSupplierSpecific]

@DocEntry int

AS

BEGIN

select	T0.[DocNum],
		T0.[DocDate],
		T0.[ObjType], 
		T0.[DocCur], 
		T0.[DocTotalSy],
		T0.[PaidSys],
		T1.[U_IDA_CompIVA],
		T1.[U_IDA_FechaComp],
		T1.[U_IDA_MontoCompIVA],
		T1.[U_IDA_DateCompISLR],
		T1.[U_IDA_CompISLR],
		CASE 
			WHEN T0.[DocCur]=(SELECT MainCurncy FROM OADM) THEN CAST(T0.[DocTotal] AS decimal (19,2))
			ELSE CAST(T0.[DocTotalFC] AS decimal (19,2))
			END AS 'DocTotal',
CASE 
			WHEN T0.[DocCur]=(SELECT MainCurncy FROM OADM) THEN CAST(T0.[DocTotalFC] AS decimal (19,2))
			ELSE CAST(T0.[DocTotal] AS decimal (19,2))
			END AS 'DocTotalFrgn',	
CASE 
			WHEN T0.[DocCur]=(SELECT MainCurncy FROM OADM) THEN CAST(T0.[PaidToDate] AS decimal (19,2))
			ELSE CAST(T0.[PaidFC] AS decimal (19,2))
			END AS 'Paid',
CASE 
			WHEN T0.[DocCur]=(SELECT MainCurncy FROM OADM) THEN CAST([PaidFC] AS decimal (19,2))
			ELSE CAST(T0.[PaidToDate] AS decimal (19,2))
			END AS 'PaidFC'
		from [OPCH] T0
	    INNER JOIN [VPM2] T1 ON T1.[DocEntry]=T0.[DocEntry]
		WHERE T1.[DocNum]=@DocEntry

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAllAccount]

AS

BEGIN

SELECT AcctCode,AcctName FROM OACT ORDER BY  GroupMask, Levels, AcctCode 

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAccountBalance]

@AcctCode nvarchar(15),
@F_RefDate datetime,
@T_RefDate datetime

AS

BEGIN

DECLARE @Date datetime

SET @Date=(SELECT TOP 1 CONVERT(nvarchar,RefDate,23)AS nvarchar FROM JDT1 Order BY RefDate)

IF(@F_RefDate IS NULL)
BEGIN

SELECT T1.[AcctCode],
T1.[AcctName], 
SUM(T0.[Debit]) AS 'Debit',
SUM(T0.[Credit]) AS 'Credit',
SUM(T0.Debit - T0.Credit) AS 'Saldo',
SUM(T0.[SYSDeb]) AS 'SYSDeb',
SUM(T0.[SYSCred]) AS 'SYSCred',
SUM(T0.SYSDeb - T0.SYSCred) AS 'SaldoSYS',
SUM(T0.[FCDebit]) AS 'FCDebit',
SUM(T0.[FCCredit]) AS 'FCCredit', 
SUM(T0.FCDebit-T0.FCCredit) AS 'FCSaldo',
CASE 
			WHEN (SELECT COUNT(DISTINCT FCCurrency) FROM JDT1 WHERE FCCurrency<>(SELECT MainCurncy FROM OADM))=1
			THEN (SELECT DISTINCT TOP 1 FCCurrency FROM JDT1 WHERE FCCurrency<>(SELECT MainCurncy FROM OADM))
			ELSE (SELECT '****')
			END AS 'FCCurrency'
FROM JDT1 T0 INNER JOIN OACT T1 ON T0.[Account] = T1.[AcctCode]
WHERE T0.[Account] = @AcctCode AND CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)>=@Date AND CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar) <= @T_RefDate
GROUP BY T1.[AcctCode], T1.[AcctName]
END
ELSE
BEGIN

SELECT T1.[AcctCode],
T1.[AcctName], 
SUM(T0.[Debit]) AS 'Debit', 
SUM(T0.[Credit]) AS 'Credit', 
SUM(T0.Debit - T0.Credit) AS 'Saldo',
SUM(T0.[SYSDeb]) AS 'SYSDeb', 
SUM(T0.[SYSCred]) AS 'SYSCred',  
SUM(T0.SYSDeb - T0.SYSCred) AS 'SaldoSYS',
SUM(T0.[FCDebit]) AS 'FCDebit',
SUM(T0.[FCCredit]) AS 'FCCredit',
SUM(T0.FCDebit-T0.FCCredit) AS 'FCSaldo',
CASE 
			WHEN (SELECT COUNT(DISTINCT FCCurrency) FROM JDT1 WHERE FCCurrency<>(SELECT MainCurncy FROM OADM))=1
			THEN (SELECT DISTINCT TOP 1 FCCurrency FROM JDT1 WHERE FCCurrency<>(SELECT MainCurncy FROM OADM))
			ELSE (SELECT '****')
			END AS 'FCCurrency'
FROM JDT1 T0 INNER JOIN OACT T1 ON T0.[Account] = T1.[AcctCode]
WHERE T0.[Account] = @AcctCode AND CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)>=@F_RefDate AND CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar) <= @T_RefDate
GROUP BY T1.[AcctCode], T1.[AcctName]
END


END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAccountLibroMayor]

@AcctCode nvarchar(15),
@F_RefDate datetime,
@T_RefDate datetime

AS

BEGIN

DECLARE @Date datetime

SET @Date=(SELECT TOP 1 CONVERT(nvarchar,RefDate,23)AS nvarchar FROM JDT1 Order BY RefDate)

IF(@F_RefDate IS NULL)

BEGIN
SELECT

CAST(CONVERT(nvarchar,T0.[RefDate],103)AS nvarchar) AS 'RefDate',CAST(CONVERT(nvarchar,T0.[DueDate],103)AS nvarchar) AS 'DueDate',CAST(CONVERT(nvarchar,T0.[TaxDate],103)AS nvarchar) AS 'TaxDate',T0.BaseRef,T1.TransType,T0.TransId ,T0.Memo,
ContraAct=(CASE WHEN T2.AcctName IS NULL THEN t3.CardCode else  T2.AcctCode  end ),
AcctName=(CASE WHEN T2.AcctName IS NULL THEN t3.CardName else  T2.AcctName  end ),

T1.Debit, T1.Credit, T1.Debit-T1.Credit AS 'Saldo', T1.SYSDeb, T1.SYSCred, T1.SYSDeb-T1.SYSCred AS 'SaldoSYS', T1.FCDebit,T1.FCCredit, T1.FCDebit-T1.FCCredit AS 'FCSaldo',T1.FCCurrency
from OJDT T0
inner join JDT1 T1 on T0.TransId =T1.TransId
left outer Join OACT T2 ON T2.AcctCode=T1.ContraAct
left outer join OCRD t3 on t3.CardCode=T1.ContraAct
Where CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)>=@Date and CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)<=@T_RefDate AND T1.[Account]=@AcctCode

order by T0.TransId ,t1.Line_ID
END
ELSE
BEGIN
SELECT

CAST(CONVERT(nvarchar,T0.[RefDate],103)AS nvarchar) AS 'RefDate',CAST(CONVERT(nvarchar,T0.[DueDate],103)AS nvarchar) AS 'DueDate',CAST(CONVERT(nvarchar,T0.[TaxDate],103)AS nvarchar) AS 'TaxDate',T0.BaseRef,T1.TransType,T0.TransId ,T0.Memo,
ContraAct=(CASE WHEN T2.AcctName IS NULL THEN t3.CardCode else  T2.AcctCode  end ),
AcctName=(CASE WHEN T2.AcctName IS NULL THEN t3.CardName else  T2.AcctName  end ),

T1.Debit, T1.Credit, T1.Debit-T1.Credit AS 'Saldo', T1.SYSDeb, T1.SYSCred, T1.SYSDeb-T1.SYSCred AS 'SaldoSYS', T1.FCDebit,T1.FCCredit, T1.FCDebit-T1.FCCredit AS 'FCSaldo',T1.FCCurrency
from OJDT T0
inner join JDT1 T1 on T0.TransId =T1.TransId
left outer Join OACT T2 ON T2.AcctCode=T1.ContraAct
left outer join OCRD t3 on t3.CardCode=T1.ContraAct
Where CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)>=@F_RefDate and CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)<=@T_RefDate AND T1.[Account]=@AcctCode

order by T0.TransId ,t1.Line_ID
END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindTransIdLD]

@AcctCode nvarchar(15),
@F_RefDate datetime,
@T_RefDate datetime

AS

BEGIN

DECLARE @Date datetime

SET @Date=(SELECT TOP 1 CONVERT(nvarchar,RefDate,23)AS nvarchar FROM JDT1 Order BY RefDate)

IF(@F_RefDate IS NULL)
BEGIN

SELECT

T0.TransId ,CAST(CONVERT(nvarchar,T0.[RefDate],103)AS nvarchar) AS 'RefDate',T0.BaseRef,T0.TransType,T0.Memo

from OJDT T0
inner join JDT1 T1 on T0.TransId =T1.TransId

Where CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)>=@Date and CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)<=@T_RefDate AND T1.[Account]=@AcctCode

order by T0.TransId ,t1.Line_ID

END
ELSE
BEGIN

SELECT

T0.TransId ,CAST(CONVERT(nvarchar,T0.[RefDate],103)AS nvarchar) AS 'RefDate',T0.BaseRef,T0.TransType,T0.Memo

from OJDT T0
inner join JDT1 T1 on T0.TransId =T1.TransId

Where CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)>=@F_RefDate and CAST(CONVERT(nvarchar,T0.[RefDate],23)AS nvarchar)<=@T_RefDate AND T1.[Account]=@AcctCode

order by T0.TransId ,t1.Line_ID

END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindLibroDiario]

@TransId int

AS

BEGIN

SELECT

CAST(CONVERT(nvarchar,T1.[RefDate],103)AS nvarchar) AS 'RefDate',T1.LineMemo,T1.ShortName,
AcctName=(CASE WHEN T2.AcctName IS NULL THEN t3.CardName else T2.AcctName end),
T1.Debit, T1.Credit, T1.Debit-T1.Credit AS 'Saldo', T1.SYSDeb, T1.SYSCred, T1.SYSDeb-T1.SYSCred AS 'SaldoSYS', T1.FCDebit,T1.FCCredit, T1.FCDebit-T1.FCCredit AS 'FCSaldo', T1.FCCurrency
from OJDT T0
inner join JDT1 T1 on T0.TransId =T1.TransId
left outer Join OACT T2 ON T2.AcctCode=T1.ShortName
left outer join OCRD t3 on t3.CardCode=T1.ShortName
Where T1.[TransId]=@TransId

ORDER BY T1.TransId ,t1.Line_ID

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAllItems]

AS

BEGIN

SELECT ItemCode,ItemName FROM OITM ORDER BY ItemCode 

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CalculateBalanceItemE]

@ItemCode nvarchar(50)

AS

BEGIN

SELECT SUM(TransValue) AS 'Value' FROM OINM WHERE ItemCode=@ItemCode AND Type='E';

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertOINM]

@TransType int,
@CreatedBy int,
@BASE_REF nvarchar(11),
@DocLineNum int,
@DocDate datetime,
@DocDueDate datetime, 
@TaxDate datetime,
@CardCode nvarchar(15),
@CardName nvarchar(100),
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@ItemCode nvarchar(50),
@Dscription nvarchar(100),
@InQty numeric(19,6),
@OutQty numeric(19,6),
@Price numeric(19,6),
@Currency nvarchar(3),
@Rate numeric(19,6),
@Type char(1),
@UserSign smallint,
@CalcPrice numeric(19,6),
@OpenQty numeric(19,6),
@CreateDate datetime,
@CostMethod char(1),
@TransValue numeric(19,6),
@OpenValue numeric(19,6),
@InvntAct nvarchar(15),
@Balance numeric(19,6),
@SysRate numeric(19,6)

AS

BEGIN

INSERT INTO OINM (TransType,CreatedBy,BASE_REF,DocLineNum,DocDate,DocDueDate,TaxDate, CardCode, CardName, Comments,JrnlMemo, ItemCode, Dscription, InQty,OutQty,Price, Currency,Rate,Type, UserSign,CalcPrice, OpenQty, CreateDate, CostMethod, TransValue,OpenValue, InvntAct, Balance, SysRate) VALUES (@TransType,@CreatedBy,@BASE_REF,@DocLineNum,@DocDate,@DocDueDate,@TaxDate, @CardCode, @CardName, @Comments,@JrnlMemo, @ItemCode, @Dscription, @InQty,@OutQty,@Price, @Currency,@Rate,@Type, @UserSign,@CalcPrice, @OpenQty, @CreateDate, @CostMethod, @TransValue,@OpenValue, @InvntAct, @Balance, @SysRate)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindQuantityItem]

@ItemCode nvarchar(50)

AS

BEGIN

SELECT (SUM(InQty)-SUM(OutQty)) AS 'Quantity' FROM OINM WHERE ItemCode=@ItemCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindFirstItemTransaccion]

@ItemCode nvarchar(50)

AS

BEGIN

Select Top 1 
*
From
OINM T0
Inner Join
OITM T1 on
T0.Itemcode = T1.Itemcode
Where T0.Type ='E' AND 
T0.Openqty > 0  AND T0.ItemCode=@ItemCode
Order by
T0.TransSeq 


END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateOINMRes]

@TransSeq int,
@Quantity decimal (19,6),
@OpenValue decimal (19,6)

AS

BEGIN

UPDATE OINM SET OpenQty=(OpenQty-@Quantity), OpenValue=(OpenValue-@OpenValue) WHERE TransSeq=@TransSeq

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateOINMSum]

@TransSeq int,
@Quantity decimal (19,6),
@OpenValue decimal (19,6)

AS

BEGIN

UPDATE OINM SET OpenQty=(OpenQty+@Quantity), OpenValue=(OpenValue+@OpenValue) WHERE TransSeq=@TransSeq

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindTaxAccountSales]

@TaxCode nvarchar(8)

AS

BEGIN

SELECT SalesTax FROM OSTA WHERE Code=@TaxCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteSalesInvoice]

@DocEntry int

AS

BEGIN

DECLARE @CON INT

SET @CON=@DocEntry

SET @CON=@CON-1

DELETE FROM OINV WHERE DocEntry=@DocEntry

DBCC CHECKIDENT ('OINV', RESEED, @CON)
DBCC CHECKIDENT ('OINV', RESEED, @CON)
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletePurchaseInvoice]

@DocEntry int

AS

BEGIN

DECLARE @CON INT

SET @CON=@DocEntry

SET @CON=@CON-1

DELETE FROM OPCH WHERE DocEntry=@DocEntry

DBCC CHECKIDENT ('OPCH', RESEED, @CON)
DBCC CHECKIDENT ('OPCH', RESEED, @CON)
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletePurchaseCreditNote]

@DocEntry int

AS

BEGIN

DECLARE @CON INT

SET @CON=@DocEntry

SET @CON=@CON-1

DELETE FROM ORPC WHERE DocEntry=@DocEntry

DBCC CHECKIDENT ('ORPC', RESEED, @CON)
DBCC CHECKIDENT ('ORPC', RESEED, @CON)
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteSalesCreditNote]

@DocEntry int

AS

BEGIN

DECLARE @CON INT

SET @CON=@DocEntry

SET @CON=@CON-1

DELETE FROM OINV WHERE DocEntry=@DocEntry

DBCC CHECKIDENT ('ORIN', RESEED, @CON)
DBCC CHECKIDENT ('ORIN', RESEED, @CON)
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteSalesInvoiceLines]

@DocEntry int

AS

BEGIN

DELETE FROM INV1 WHERE DocEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletePurchaseInvoiceLines]

@DocEntry int

AS

BEGIN

DELETE FROM PCH1 WHERE DocEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletePurchaseCreditNoteLines]

@DocEntry int

AS

BEGIN

DELETE FROM RPC1 WHERE DocEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteSalesCreditNoteLines]

@DocEntry int

AS

BEGIN

DELETE FROM RIN1 WHERE DocEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteSalesInvoiceRetenciones]

@DocEntry int

AS

BEGIN

DELETE FROM INV5 WHERE AbsEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletePurchaseInvoiceRetenciones]

@DocEntry int

AS

BEGIN

DELETE FROM PCH5 WHERE AbsEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletePurchaseCreditNoteRetenciones]

@DocEntry int

AS

BEGIN

DELETE FROM RPC5 WHERE AbsEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteSalesCreditNoteRetenciones]

@DocEntry int

AS

BEGIN

DELETE FROM RIN5 WHERE AbsEntry=@DocEntry
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteJournalEntry]

@TransId int

AS

BEGIN

DECLARE @CON INT

SET @CON=@TransId-1

DELETE FROM OJDT WHERE TransId=@TransId

DBCC CHECKIDENT ('OJDT', RESEED, @CON)
DBCC CHECKIDENT ('OJDT', RESEED, @CON)
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteJournalEntryLines]

@TransId int

AS

BEGIN

DELETE FROM JDT1 WHERE TransId=@TransId

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteOINM]

@DocEntry int

AS

BEGIN

DELETE FROM OINM WHERE CreatedBy=@DocEntry

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteOldRecord]

@TransSeq int,
@TransType int, 
@CreatedBy int,
@BASE_REF nvarchar(11),
@DocLineNum int,
@DocDate datetime, 
@DocDueDate datetime, 
@CardCode nvarchar(15),
@CardName nvarchar(100),
@Comments nvarchar(254),
@JrnlMemo nvarchar(50),
@ItemCode nvarchar(50),
@Dscription nvarchar(100),
@InQty numeric(19,6),
@OutQty numeric(19,6),
@Price numeric(19,6),
@Currency nvarchar(3),
@Rate numeric(19,6),
@TaxDate datetime,
@UserSign smallint,
@CalcPrice numeric(19,6),
@OpenQty numeric(19,6),
@CreateDate datetime,
@Balance numeric(19,6),
@TransValue numeric(19,6),
@InvntAct nvarchar(15),
@OpenValue numeric(19,6),
@CostMethod char(1),
@Type char(1),
@SysRate numeric(19,6)


AS

BEGIN

DECLARE @CON INT

SET @CON=@TransSeq-1

DELETE FROM OINM WHERE TransSeq=@TransSeq

DBCC CHECKIDENT ('OINM', RESEED, @CON)
DBCC CHECKIDENT ('OINM', RESEED, @CON)

INSERT INTO OINM (TransType,CreatedBy,BASE_REF,DocLineNum,DocDate,DocDueDate,CardCode,CardName, Comments,JrnlMemo,ItemCode,Dscription, InQty,OutQty,Price,Currency,Rate, TaxDate,UserSign,CalcPrice,OpenQty,CreateDate,Balance,TransValue, InvntAct,OpenValue,CostMethod,Type,SysRate) VALUES(@TransType,@CreatedBy,@BASE_REF,@DocLineNum,@DocDate,@DocDueDate,@CardCode,@CardName, @Comments,@JrnlMemo,@ItemCode,@Dscription, @InQty,@OutQty,@Price,@Currency,@Rate, @TaxDate,@UserSign,@CalcPrice,@OpenQty,@CreateDate,@Balance,@TransValue, @InvntAct,@OpenValue,@CostMethod,@Type,@SysRate)
 
SET @CON=(SELECT COUNT(*) FROM OINM)

DBCC CHECKIDENT ('OINM', RESEED, @CON)
DBCC CHECKIDENT ('OINM', RESEED, @CON)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindSalesCostAct]

@ItemCode nvarchar(50)

AS

BEGIN

SELECT SaleCostAc FROM OITM WHERE ItemCode=@ItemCode

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindStockAudit]

@ItemCode nvarchar(50),
@F_RefDate datetime,
@T_RefDate datetime

AS

BEGIN

DECLARE @Date datetime

SET @Date=(SELECT TOP 1 CONVERT(nvarchar,DocDate,23)AS nvarchar FROM OINM Order BY DocDate)

IF(@F_RefDate IS NULL)
BEGIN
SELECT 
T0.[ItemCode],
T0.[Dscription],
CAST(CONVERT(nvarchar,T0.[DocDate],103)AS nvarchar) AS 'DocDate',
T0.[BASE_REF],
T0.[TransType],
(T0.[InQty]-T0.[OutQty]) 'Quantity',
T0.[TransValue],
T0.[CalcPrice],
T0.[Balance]
FROM OINM T0 
inner JOIN OITM T1 ON T0.[ItemCode] = T1.[ItemCode] 
WHERE CAST(CONVERT(nvarchar,T0.[DocDate],23)AS nvarchar)>=@Date and CAST(CONVERT(nvarchar,T0.[DocDate],23)AS nvarchar)<=@T_RefDate AND T0.[ItemCode]=@ItemCode
END
ELSE
BEGIN

SELECT 
T0.[ItemCode],
T0.[Dscription],
CAST(CONVERT(nvarchar,T0.[DocDate],103)AS nvarchar) AS 'DocDate',
T0.[BASE_REF],
T0.[TransType],
(T0.[InQty]-T0.[OutQty]) 'Quantity',
T0.[TransValue],
T0.[CalcPrice],
T0.[Balance]
FROM OINM T0 
inner JOIN OITM T1 ON T0.[ItemCode] = T1.[ItemCode] 
WHERE CAST(CONVERT(nvarchar,T0.[DocDate],23)AS nvarchar)>=@F_RefDate and CAST(CONVERT(nvarchar,T0.[DocDate],23)AS nvarchar)<=@T_RefDate AND T0.[ItemCode]=@ItemCode


END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertLogo]

@imgByte image,
@Name nvarchar(max)

AS

BEGIN

UPDATE OADM SET Name=@Name,Image=@imgByte 

END
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BindImage]

AS

BEGIN

SELECT TOP 1 Name,Image FROM OADM 

END

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[O_IDA5] 
(	
)
RETURNS TABLE 


AS
RETURN 
(

			SELECT  * FROM PCH5 K2 (NOLOCK) --WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				UNION ALL
			SELECT  * FROM RPC5 K2 (NOLOCK) --WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType
)
GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_ImpuestoNoDeducible]
(
	@ObjType AS VARCHAR(20),
    @DocEntry AS BIGINT,
    @TaxCode AS VARCHAR(20),
    @Type AS VARCHAR(1)
)
RETURNS DECIMAL(19,6)

AS
BEGIN
	-- Declare the return variable here
	DECLARE @ResultVar AS DECIMAL(19,6)


IF (@Type='C')
BEGIN
	SELECT @ResultVar=ISNULL(SUM(K2.X),0)
	FROM 
	(
		SELECT  VatSum AS 'X' FROM 
		(
			SELECT DocEntry, ObjType,      VatSum FROM PCH1 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType  AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType, (-1)*VatSum FROM RPC1 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType  AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType,      VatSum FROM PCH3 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType  AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType, (-1)* VatSum FROM RPC3 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatGroup=@TaxCode
	
		) K1
		,
		
		(
			SELECT DocEntry, ObjType  FROM OPCH K2 (NOLOCK) WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				UNION ALL
			SELECT  DocEntry, ObjType  FROM ORPC K2 (NOLOCK) WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType
		) K2
		
		WHERE
		K1.DocEntry=K2.DocEntry AND K1.ObjType=K2.ObjType
	) K2

END

	ELSE
		BEGIN
		SELECT @ResultVar=ISNULL(SUM(K2.X),0)
				FROM 
		(
		SELECT  VatSum AS 'X' FROM 
		(
			SELECT DocEntry, ObjType,      VatSum FROM INV1 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND  VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType, (-1)*VatSum FROM RIN1 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType,      VatSum FROM INV3 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType, (-1)* VatSum FROM RIN3 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatGroup=@TaxCode
	
		) K1
		,
		
		(
			SELECT DocEntry, ObjType FROM OINV K2 (NOLOCK) WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				UNION ALL
			SELECT  DocEntry, ObjType FROM ORIN K2 (NOLOCK) WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType
		) K2
		
		WHERE
		K1.DocEntry=K2.DocEntry AND K1.ObjType=K2.ObjType
	) K2
		END





	-- Return the result of the function
	RETURN @ResultVar

END

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[O_IDA] 
(	
  @Periodo AS VARCHAR(10)
)

RETURNS TABLE
WITH ENCRYPTION 
AS
RETURN 
(

			SELECT 
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',


			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'AlicuotaGasto'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'CodigoAlicuotaGasto'
			,
			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'AlicuotaGeneral'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'CodigoAlicuotaGeneral'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'AlicuotaReducida'
			,
			
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'CodigoAlicuotaReducida'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'AlicuotaAdicional'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaAdicional'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaExento'
			,
			H2.U_IDA_TipoPersona AS 'TipoPersona',
			ISNULL(CASE WHEN DocSubType='--' THEN NumAtCard END,'') AS 'NF', 
			ISNULL(CASE WHEN DocSubType<>'--' THEN NumAtCard END,'') AS 'ND', 
			'' AS 'NC',
			'' AS 'FAFE',ISNULL(K2.U_IDA_Serie,'') + ISNULL(K2.U_IDA_NumControl,'') AS 'NroControl',K2.U_IDA_TipoTrans AS 'TipoTran',
			ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',ISNULL(K2.DocDate,'') AS 'FechaComp' ,
			ISNULL(K2.U_IDA_NumImport,'') AS 'NroImportacion', ISNULL(K2.U_IDA_NumFile,'') AS 'ExpedienteImp',
			ISNULL(U_IDA_RetenTercero,'N') AS 'RetencionTercero',
			ISNULL(U_IDA_Tercero,'') AS 'Tercero',
			ISNULL(U_IDA_TipoRet,'') AS 'TipoRet',
			ISNULL(U_IDA_IsPlanilla,'') AS 'IsPlanilla',
			K2.* FROM OPCH K2 (NOLOCK) ,OFPR H1 (NOLOCK)  , OCRD H2 (NOLOCK)  WHERE H1.Name=@Periodo
			AND  K2.DocDate >= H1.F_RefDate AND K2.DocDate <= H1.T_RefDate 
			AND K2.CardCode=H2.CardCode AND H2.U_IDA_TipoPersona<>'PJND' AND  H2.U_IDA_TipoPersona<>'PNNR' AND K2.U_IDA_TipoTrans<>'05'
			 --, [@BKV_RECEIPT] K3 WHERE K2.DocEntry= --K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				
				UNION ALL
				
			SELECT		
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'AlicuotaGasto'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'CodigoAlicuotaGasto'
			,
			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'AlicuotaGeneral'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'CodigoAlicuotaGeneral'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'AlicuotaReducida'
			,
			
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'CodigoAlicuotaReducida'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'AlicuotaAdicional'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaAdicional'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaExento'
			,
			H2.U_IDA_TipoPersona AS 'TipoPersona',
			'' AS 'NF', '' AS 'ND',  NumAtCard AS 'NC',K2.U_IDA_Fafe AS 'FAFE',
			ISNULL(K2.U_IDA_Serie,'') + ISNULL(K2.U_IDA_NumControl,'') AS 'NroControl', U_IDA_TipoTrans  AS 'TipoTran', 
			ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',ISNULL(K2.DocDate,'') 
			AS 'FechaComp' ,
			ISNULL(K2.U_IDA_NumImport,'') AS 'NroImportacion', ISNULL(K2.U_IDA_NumFile,'') AS 'ExpedienteImp',
			ISNULL(U_IDA_RetenTercero,'N') AS 'RetencionTercero',
			ISNULL(U_IDA_Tercero,'') AS 'Tercero',
			ISNULL(U_IDA_TipoRet,'') AS 'TipoRet',
			ISNULL(U_IDA_IsPlanilla,'') AS 'IsPlanilla',
			K2.* FROM ORPC K2 (NOLOCK),OFPR H1 (NOLOCK) , OCRD H2 (NOLOCK) WHERE H1.Name=@Periodo 
			AND K2.DocDate >= H1.F_RefDate AND K2.DocDate <= H1.T_RefDate AND K2.CardCode=H2.CardCode AND H2.U_IDA_TipoPersona<>'PJND' AND  H2.U_IDA_TipoPersona<>'PNNR'
			AND K2.U_IDA_TipoTrans<>'05' --WHERE H1.Name=@Periodo
			--WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType


)

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_BaseImponible]
(
	@ObjType AS VARCHAR(20),
    @DocEntry AS BIGINT,
    @VatPrcnt AS FLOAT,
    @TaxCode AS VARCHAR(20),
    @Type AS VARCHAR(1)
)
RETURNS DECIMAL(19,6)
WITH ENCRYPTION
AS
BEGIN
	-- Declare the return variable here
	DECLARE @ResultVar AS DECIMAL(19,6)


IF (@Type='C')
BEGIN
	SELECT @ResultVar=ISNULL(SUM(K2.X),0)
	FROM 
	(
		SELECT  LineTotal  - (LineTotal * (ISNULL(K2.DiscPrcnt,0))/100) AS 'X' FROM 
		(
			SELECT DocEntry, ObjType,      LineTotal FROM PCH1 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatPrcnt=@VatPrcnt AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType, (-1)*LineTotal FROM RPC1 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatPrcnt=@VatPrcnt AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType,      LineTotal FROM PCH3 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatPrcnt=@VatPrcnt AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType, (-1)* LineTotal FROM RPC3 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatPrcnt=@VatPrcnt AND VatGroup=@TaxCode
	
		) K1
		,
		
		(
			SELECT DocEntry, ObjType , K2.DiscPrcnt FROM OPCH K2 (NOLOCK) WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				UNION ALL
			SELECT  DocEntry, ObjType , K2.DiscPrcnt FROM ORPC K2 (NOLOCK) WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType
		) K2
		
		WHERE
		K1.DocEntry=K2.DocEntry AND K1.ObjType=K2.ObjType
	) K2

END

	ELSE
		BEGIN
		SELECT @ResultVar=ISNULL(SUM(K2.X),0)
				FROM 
		(
		SELECT  LineTotal - (LineTotal * (ISNULL(K2.DiscPrcnt,0))/100) AS 'X' FROM 
		(
			SELECT DocEntry, ObjType,      LineTotal FROM INV1 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatPrcnt=@VatPrcnt AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType, (-1)*LineTotal FROM RIN1 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatPrcnt=@VatPrcnt AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType,      LineTotal FROM INV3 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatPrcnt=@VatPrcnt AND VatGroup=@TaxCode
				UNION ALL
			SELECT DocEntry, ObjType, (-1)* LineTotal FROM RIN3 K1 (NOLOCK) WHERE  K1.DocEntry=@DocEntry AND ObjType=@ObjType AND VatPrcnt=@VatPrcnt AND VatGroup=@TaxCode
	
		) K1
		,
		
		(
			SELECT DocEntry, ObjType, K2.DiscPrcnt FROM OINV K2 (NOLOCK) WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				UNION ALL
			SELECT  DocEntry, ObjType, K2.DiscPrcnt FROM ORIN K2 (NOLOCK) WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType
		) K2
		
		WHERE
		K1.DocEntry=K2.DocEntry AND K1.ObjType=K2.ObjType
	) K2
		END





	-- Return the result of the function
	RETURN @ResultVar

END
GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_LIBRO_COMPRAS]
(	
    @Periodo AS VARCHAR(100)
)
RETURNS TABLE 


AS
RETURN 
(
SELECT  
T0.ObjType,
T0.DocEntry AS 'DocEntry',
T5.CompnyName as 'Agente', 
T5.TaxIdNum AS 'RIF Agente',
T5.CompnyAddr AS 'Direccion Agente',
T0.TaxDate  AS 'Fecha',
ISNULL(T0.FAFE,'') as 'Nro. de Factura Afectada',
--T0.CardName  as 'Nombre o Razon Social'
CASE WHEN T0.RetencionTercero='Y' THEN CASE WHEN T0.TipoRet='IVA' THEN T0.Tercero  WHEN T0.TipoRet='Todas' THEN T0.Tercero ELSE T0.CardName END ELSE T0.CardName END 
as 'Nombre o Razon Social',
CASE WHEN T0.LicTradNum='J-999999999' THEN 'ND' ELSE (CASE WHEN T0.RetencionTercero='Y' THEN CASE WHEN T0.TipoRet='IVA' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName=T0.Tercero AND CardType = 'S') WHEN T0.TipoRet='Todas' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName=T0.Tercero AND CardType = 'S') ELSE T0.LicTradNum  END  ELSE T0.LicTradNum  END) END as 'RIF',

--CASE WHEN T0.LicTradNum='J-999999999' THEN 'ND' ELSE T0.LicTradNum END as 'RIF',
 CASE 
                                WHEN T0.TipoTran='01' THEN '01-Reg' 
                                WHEN T0.TipoTran='02' THEN '02-Comp'
                                WHEN T0.TipoTran='03' THEN '03-Anu' 
                                WHEN T0.TipoTran='04' THEN '04-Aju'
                                END AS 'Tipo Transaccion',
T0.NroComprobante AS 'Nro. Comprobante de IVA',
case T0.NroComprobante when '' then null else T0.FechaComp end AS 'Fecha Comprobante',
T0.NroImportacion AS 'Planilla de importacion',
T0.ExpedienteImp AS 'Expediente de importacion',
T0.NF AS 'Nro. de Factura',
CASE WHEN T0.IsPlanilla='Y' THEN '' ELSE T0.NroControl END AS 'Nro. de Contol',
T0.ND as 'Nro. de Debito' ,
T0.NC as 'Nro. de Credito',
CASE WHEN T0.IsPlanilla='Y' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'C') +dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,0,T0.CodigoAlicuotaExento,'C') +T0.VatSum ELSE
(CASE WHEN T0.ObjType='18' THEN 1 WHEN T0.ObjType='19' THEN (-1) END)* T0.Max1099 END AS 'Total',
CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'C') end  AS 'Base Imponible (GENERAL)',
T0.AlicuotaGeneral AS 'Alicuota (GENERAL)', --12
CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE 
	((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,	
		T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,
						'C') *T0.AlicuotaGeneral)/100) end AS 'IVA (GENERAL)',


						CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE1,T0.CodigoAlicuotaGeneralE1,'C') end  AS 'Base Imponible (GENERAL E1)',
T0.AlicuotaGeneralE1 AS 'Alicuota (GENERAL E1)', --12
CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE 
	((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,	
		T0.AlicuotaGeneralE1,T0.CodigoAlicuotaGeneralE1,
						'C') *T0.AlicuotaGeneralE1)/100) end AS 'IVA (GENERAL E1)',


	CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE2,T0.CodigoAlicuotaGeneralE2,'C') end  AS 'Base Imponible (GENERAL E2)',
T0.AlicuotaGeneralE2 AS 'Alicuota (GENERAL E2)', --12
CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE 
	((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,	
		T0.AlicuotaGeneralE2,T0.CodigoAlicuotaGeneralE2,
						'C') *T0.AlicuotaGeneralE2)/100) end AS 'IVA (GENERAL E2)',


dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaReducida,T0.CodigoAlicuotaReducida,'C') AS 'Base Imponible (REDUCIDA)',

 T0.AlicuotaReducida AS 'Alicuota (REDUCIDA)', --8

CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaReducida,T0.CodigoAlicuotaReducida,'C') *T0.AlicuotaReducida)/100) end AS 'IVA (REDUCIDA)',

--CASE WHEN T0.IsPlanilla='Y' THEN CASE WHEN T0.VatSum=0 THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,'C')  ELSE 0 END ELSE 
dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,T0.CodigoAlicuotaExento,'C') +  
-- se agrego esta funcionalidad para las compras sin derecho a credito fiscal
dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaGasto,T0.CodigoAlicuotaGasto,'C') 
--END 
+ dbo.IDA_ImpuestoNoDeducible(T0.ObjType,T0.DocEntry,T0.CodigoAlicuotaGasto,'C')
AS 'Base Imponible (EXENTA)',

0 AS 'Alicuota (EXENTA)',
((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,T0.CodigoAlicuotaExento,'C') *0)/100) AS 'EXENTO, NO SUJETO',

dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaAdicional,T0.CodigoAlicuotaAdicional,'C') AS 'Base Imponible (ADICIONAL)',
T0.AlicuotaAdicional AS 'Alicuota (ADICIONAL)', --20

((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, t0.AlicuotaAdicional,T0.CodigoAlicuotaAdicional,'C') *t0.AlicuotaAdicional)/100) AS 'IVA (ADICIONAL)',


CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGasto,T0.CodigoAlicuotaGasto,'C') end  AS 'Base Imponible (GASTO)',
T0.AlicuotaGasto AS 'Alicuota (GASTO)', --12

(CASE WHEN T0.ObjType='18' THEN 1 WHEN T0.ObjType='19' THEN (-1) END)* ISNULL(T2.WTAmnt,0)  'Retencion',
CASE WHEN T0.U_IDA_RetenTercero='Y' THEN (CASE WHEN T0.ObjType='18' THEN 1 WHEN T0.ObjType='19' THEN (-1) END)* ISNULL(T2.WTAmnt,0) ELSE 0 END  'RetencionTercero',

(SELECT VatStatus FROM OCRD WHERE CardCode=T0.CardCode) AS 'VatStatus'
, T0.DocDate as 'Fecha Contable' 
, T0.TipoPersona
,CASE WHEN T0.IsPlanilla='Y' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'C') --T0.U_BASE_IMP 
ELSE 0 END AS 'Base Imponible Importacion'
,CASE WHEN T0.IsPlanilla='Y' THEN 
					T0.VatSum	
				ELSE 0 END AS 'IVA Importacion'
, 12 as '% Alicuota IMP'
FROM 
dbo.O_IDA(@Periodo) T0 LEFT OUTER JOIN 
--dbo.O_IDA1() T1, 
dbo.O_IDA5() T2  ON T0.DocEntry=T2.AbsEntry  AND T2.BaseType='V' 
AND T0.ObjType = T2.ObjType  LEFT OUTER JOIN  OWHT T4 (NOLOCK) ON T2.WTCode =T4.WTCode
 , 
OADM T5 (NOLOCK) ,  OFPR T6 (NOLOCK)

WHERE T6.Name=@Periodo--@Periodo 
--T0.DocEntry=T1.DocEntry  AND  
--T0.DocNum=17089 --and
 
 

)


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_ComprobanteARCV] 
(	
  @CardName AS VARCHAR(100),
  @Year AS VARCHAR(100)
)

RETURNS TABLE
WITH ENCRYPTION 
AS
RETURN 
(

SELECT * FROM (
SELECT
             DISTINCT  
                T1.Address ,T1.CardName,T1.DocDate as 'Fecha',replace (T1.LicTradNum,'-','') RifRetenido,
                CASE WHEN LEN(T1.NumAtCard)>10 THEN SUBSTRING(REPLACE(T1.NumAtCard,'-',''),
                (LEN(T1.NumAtCard)-9), LEN(T1.NumAtCard)) ELSE REPLACE(T1.NumAtCard,'-','') END AS 'Numero Factura',
                ISNULL(T1.U_IDA_Serie,'') + ISNULL(T1.U_IDA_NumControl,'NA') NumeroControl,
                T1.BaseAmnt + t1.vatsum AS 'Monto Documento',T3.Offclcode AS 'Codigo Concepto',  T3.WTName as 'Concepto de I.S.L.R',              
               ((T2.WTAmnt + ISNULL(T3.U_IDA_Sustraendo,0)) /(T3.PrctBsAmnt/100)) --AS NUMERIC (10,2)),',','.') 
              
             -- (( t2.TaxbleAmnt) /(T3.PrctBsAmnt/100)) AS 'Cantidad Objeto retencion', 
                --  (( t2.TaxbleAmnt) ) 
				  AS 'Cantidad Objeto retencion', 
                
                T2.WTAmnt AS 'Impuesto Retenido menos sustraendo',
                --(((T2.WTAmnt + ISNULL(T3.U_IDA_Sustraendo,0)) /(T3.PrctBsAmnt/100))) * T3.PrctBsAmnt/100 AS 'Impuesto Retenido menos sustraendo',
                REPLACE(CAST(T3.PrctBsAmnt AS NUMERIC (10,2)),',','.') as 'Tarifa %', 
                T9.CompnyName,T9.CompnyAddr,T9.TaxIdNum
                ,CONVERT(VARCHAR,YEAR(T1.DocDate)) AS 'Year'
				, (SELECT COUNT(*) FROM RPC1 WHERE BaseEntry=T1.DocEntry) AS 'NC'
               
              
                FROM
                OPCH T1, PCH5 T2, OWHT T3, OFPR T4, OADM T9
                WHERE
                T1.DocEntry=T2.AbsEntry AND
                T2.WTCode = T3.WTCode AND
                T3.U_IDA_TipoRetencion= 'ISLR' 
                AND T1.CardCode=@CardName--(SELECT CardCode FROM OCRD WHERE CardName=@CardName AND CardType='S')
                AND YEAR(T1.DocDate)=@Year and t1.U_IDA_TipoTrans<>'05'
) T WHERE T.NC=0
)


GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[O_IDAV] 
(
   @Periodo AS VARCHAR(10)	
)
RETURNS TABLE 
WITH ENCRYPTION 

AS
RETURN 
(

			SELECT 

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',
			
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGasto',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGasto',
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneral',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneral',

					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneralOP',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneralOP',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'AlicuotaReducida',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'CodigoAlicuotaReducida',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'AlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='EXENTO'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaExento',
				'NO' AS 'COMPROBANTE',
				ISNULL(CASE WHEN DocSubType='--' THEN CONVERT(VARCHAR,K2.DocNum) END,'') AS 'NF', 
				ISNULL(CASE WHEN DocSubType<>'--' THEN CONVERT(VARCHAR,K2.DocNum) END,'') AS 'ND', 
				'' AS 'NC',
				K2.U_IDA_Fafe AS 'FAFE',
				ISNULL(K2.U_IDA_Serie,'00')+'-'+ISNULL(ISNULL(K2.U_IDA_NumControl,K2.U_IDA_NumControl),'') AS 'NroControl',
				U_IDA_TipoTrans AS 'TipoTran', 
			
				ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',
			
				K2.U_IDA_FechaComp AS 'FechaComp',
				K2.U_IDA_MontoCompIVA AS 'Retencion',
				1 AS 'Signo',
				K2.U_IDA_FechaContComp AS 'FechaContComp' ,
				ISNULL(K2.U_IDA_NumExport,'') as 'NroExport', 
				K2.U_IDA_NumFile AS 'ExpedienteExport' ,K2.* 
			FROM OINV K2 (NOLOCK), OFPR H1 (NOLOCK)
			WHERE 
				H1.Name=@Periodo AND 
				K2.DocDate >= H1.F_RefDate AND 
				K2.DocDate <= H1.T_RefDate
				AND K2.U_IDA_TipoTrans<>'05'
			 
			UNION ALL
			SELECT 

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGasto',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGasto',
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneral',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneral',
					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneralOP',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneralOP',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'AlicuotaReducida',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'CodigoAlicuotaReducida',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'AlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='EXENTO'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaExento',
				'NO' AS 'COMPROBANTE',
				'' AS 'NF', '' AS 'ND',  
				CONVERT(VARCHAR,K2.DocNum) AS 'NC',
				K2.U_IDA_Fafe AS 'FAFE',
--				ISNULL(K2.U_IDA_ControlNumber,'') AS 'NroControl', 
				ISNULL(K2.U_IDA_Serie,'00')+'-'+ISNULL(ISNULL(K2.U_IDA_NumControl,K2.U_IDA_NumControl),'') AS 'NroControl',
				U_IDA_TipoTrans AS 'TipoTran',
				ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',
				K2.U_IDA_FechaComp AS 'FechaComp',
				K2.U_IDA_MontoCompIVA AS 'Retencion',
				-1 AS 'Signo',
				K2.U_IDA_FechaContComp AS 'FechaContComp' ,
				ISNULL(K2.U_IDA_NumExport,'') as 'NroExport', 
				K2.U_IDA_NumFile AS 'ExpedienteExport', K2.* 
			FROM ORIN K2 (NOLOCK), OFPR H1 (NOLOCK)
			WHERE 
				H1.Name=@Periodo AND 
				K2.DocDate >= H1.F_RefDate AND 
				K2.DocDate <= H1.T_RefDate
				AND K2.U_IDA_TipoTrans<>'05'
			UNION ALL
			SELECT 
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGasto',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGasto',
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneral',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneral',
					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneralOP',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneralOP',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'AlicuotaReducida',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'CodigoAlicuotaReducida',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'AlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='EXENTO'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaExento',
				'SI' AS 'COMPROBANTE',
				'' AS 'NF', 
				'' AS 'ND', 
				'' AS 'NC',

				CONVERT(VARCHAR,K2.DocNum) AS 'FAFE', 
				'' AS 'NroControl',
				U_IDA_TipoTrans AS 'TipoTran', 
				ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',
				K2.U_IDA_FechaComp AS 'FechaComp',
				K2.U_IDA_MontoCompIVA AS 'Retencion',
				1 AS 'Signo',
				K2.U_IDA_FechaContComp AS 'FechaContComp', 
				'' as 'NroExport', 
				'' AS 'ExpedienteExport', K2.* 
			
			FROM OINV K2 (NOLOCK), OFPR H1 (NOLOCK)
--			WHERE H1.Name=@Periodo AND K2.U_IDA_FechaContComp >= H1.F_RefDate AND K2.U_IDA_FechaContComp <= H1.T_RefDate AND 
			WHERE 
				H1.Name=@Periodo AND 
				K2.U_IDA_FechaContComp >= H1.F_RefDate AND 
				K2.U_IDA_FechaContComp <= H1.T_RefDate AND 
				NOT (K2.DocDate >= H1.F_RefDate AND K2.DocDate <= H1.T_RefDate)
			        AND K2.U_IDA_TipoTrans<>'05' AND K2.U_IDA_CompIVA<>'' AND K2.U_IDA_CompIVA IS NOT NULL
			UNION ALL


			SELECT 

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGasto',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGasto',
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneral',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneral',
					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneralOP',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneralOP',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'AlicuotaReducida',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'CodigoAlicuotaReducida',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'AlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='EXENTO'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaExento',
				'SI' AS 'COMPROBANTE',
				'' AS 'NF', 
				'' AS 'ND', 
				'' AS 'NC',
				K2.U_IDA_Fafe AS 'FAFE', 
				'' AS 'NroControl',
				U_IDA_TipoTrans AS 'TipoTran', 
				ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',
				K2.U_IDA_FechaComp AS 'FechaComp',
				K2.U_IDA_MontoCompIVA AS 'Retencion',
				-1 AS 'Signo',
				K2.U_IDA_FechaContComp AS 'FechaContComp', 
				'' as 'NroExport', '' AS 'ExpedienteExport', K2.* 
			
			FROM ORIN K2 (NOLOCK), OFPR H1 (NOLOCK)
--			WHERE H1.Name=@Periodo AND K2.U_IDA_FechaContComp >= H1.F_RefDate AND K2.U_IDA_FechaContComp <= H1.T_RefDate AND 
			WHERE 
				H1.Name=@Periodo AND 
				K2.U_IDA_FechaContComp >= H1.F_RefDate AND 
				K2.U_IDA_FechaContComp <= H1.T_RefDate AND 
				NOT (K2.DocDate >= H1.F_RefDate AND K2.DocDate <= H1.T_RefDate)
                                AND K2.U_IDA_TipoTrans<>'05'
                                AND K2.U_IDA_CompIVA<>'' AND K2.U_IDA_CompIVA IS NOT NULL
)

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_LIBRO_VENTAS]
(	
    @Periodo AS VARCHAR(100)
)
RETURNS TABLE 
WITH ENCRYPTION 

AS
RETURN 
(

SELECT  
T0.DocEntry AS 'DocEntry',
T5.CompnyName as 'Agente', 
T5.TaxIdNum AS 'RIF Agente',
T5.CompnyAddr AS 'Direccion Agente',
--CASE WHEN T0.COMPROBANTE='SI' THEN T0.FechaComp ELSE T0.DocDate END AS 'Fecha',
--EML 20130605 SE CAMBIO NUEVAMENTE DESPUES DE REVISAR EL LIBRO DE VENTAS DE YG OJO EML
--T0.DocDate AS 'Fecha',
CASE WHEN T0.COMPROBANTE='SI' THEN T0.FechaContComp ELSE T0.DocDate END AS 'Fecha',
--ISNULL(T0.FAFE,'') as 'Nro. de Factura Afectada',
--CASE (len(ISNULL(T0.FAFE,''))-9) when '0' then convert(int,substring(CONVERT(char(9),ISNULL(T0.FAFE,'')),2,8)) else ISNULL(T0.FAFE,'') end  AS 'Nro. de Factura Afectada',
CASE (len(ISNULL(T0.FAFE,''))-9) when '0' then convert(VARCHAR,substring(CONVERT(char(9),ISNULL(T0.FAFE,'')),2,8)) else ISNULL(T0.FAFE,'') end  AS 'Nro. de Factura Afectada',

T0.CardName as 'Nombre o Razon Social',
CASE WHEN T0.LicTradNum='J-999999999' THEN 'ND' ELSE T0.LicTradNum END as 'RIF',
CASE WHEN  T0.FechaContComp>=F_RefDate AND T0.FechaContComp<=T_RefDate THEN T0.NroComprobante END AS 'Nro. Comprobante de IVA',
CASE WHEN  T0.FechaContComp>=F_RefDate AND T0.FechaContComp<=T_RefDate THEN CONVERT(DATETIME,T0.FechaComp,112)  END AS 'Fecha Comprobante',
T0.NroExport AS 'Planilla de importacion',
T0.NroExport AS 'Expediente de importacion',
 CASE WHEN T0.U_IDA_DocAnulado='02' THEN 'ANULADO' ELSE CASE 
                                WHEN T0.TipoTran='01' THEN '01-Reg' 
                                WHEN T0.TipoTran='02' THEN '02-Comp'
                                WHEN T0.TipoTran='03' THEN '03-Anu' 
                                WHEN T0.TipoTran='04' THEN '04-Aju'
                                END END AS 'Tipo Transaccion',
T0.NF AS 'Nro. de Factura',
T0.NroControl AS 'Nro. de Contol',
T0.ND as 'Nro. de Debito' ,
T0.NC as 'Nro. de Credito',
T0.FAFE as 'Factura Afectada',
--CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN 
--CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.ObjType='14' THEN (-1)*T0.DocTotal ELSE T0.DocTotal end  end 
--ELSE 0 END  END AS 'Total',
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN 
CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.ObjType='14' THEN (-1)*T0.Max1099 ELSE T0.Max1099 end  end 
ELSE 0 END  END AS 'Total',
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN T0.NroExport <>'' THEN CASE WHEN T0.ObjType='14' THEN (-1)*T0.Max1099 ELSE T0.Max1099 end  ELSE 0 END END AS 'Total EXTERNO', --T0.DocTotal

CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'V') ELSE 0 END END END AS 'Base Imponible (GENERAL)',
T0.AlicuotaGeneral AS 'Alicuota (GENERAL)', --12
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'V') * T0.AlicuotaGeneral)/100)  ELSE 0 END END END AS 'IVA (GENERAL)',



CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE1,T0.CodigoAlicuotaGeneralE1,'V') ELSE 0 END END END AS 'Base Imponible (GENERAL E1)',
T0.AlicuotaGeneralE1 AS 'Alicuota (GENERAL E1)', --12
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE1,T0.CodigoAlicuotaGeneralE1,'V') * T0.AlicuotaGeneralE1)/100)  ELSE 0 END END END AS 'IVA (GENERAL E1)',


CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE2,T0.CodigoAlicuotaGeneralE2,'V') ELSE 0 END END END AS 'Base Imponible (GENERAL E2)',
T0.AlicuotaGeneralE2 AS 'Alicuota (GENERAL E2)', --12
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE2,T0.CodigoAlicuotaGeneralE2,'V') * T0.AlicuotaGeneralE2)/100)  ELSE 0 END END END AS 'IVA (GENERAL E2)',




CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneralOP,'V') ELSE 0 END END END AS 'Base Imponible (GENERAL OP)',
T0.AlicuotaGeneralOP AS 'Alicuota (GENERAL OP)', --12
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'V') * T0.AlicuotaGeneralOP)/100)  ELSE 0 END END END AS 'IVA (GENERAL OP)',

CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaReducida,T0.CodigoAlicuotaReducida,'V') ELSE 0 END END END AS 'Base Imponible (REDUCIDA)',
T0.AlicuotaReducida AS 'Alicuota (REDUCIDA)', -- 8

CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaReducida,T0.CodigoAlicuotaReducida,'V') * T0.AlicuotaReducida)/100) ELSE 0 END END END AS 'IVA (REDUCIDA)',

--dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,'V') AS 'Base Imponible (EXENTA)',
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN 
CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,T0.CodigoAlicuotaExento,'V') end 
ELSE 0 END END AS 'Base Imponible (EXENTA)',
0 AS 'Alicuota (EXENTA)',
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,T0.CodigoAlicuotaExento,'V') *0)/100) END AS 'EXENTO, NO SUJETO',

CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaAdicional,T0.CodigoAlicuotaAdicional,'V') END END AS 'Base Imponible (ADICIONAL)',
T0.AlicuotaAdicional AS 'Alicuota (ADICIONAL)', --20
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaAdicional,T0.CodigoAlicuotaAdicional,'V') * T0.AlicuotaAdicional)/100) END END AS 'IVA (ADICIONAL)'
,
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.FechaContComp>=F_RefDate AND T0.FechaContComp<=T_RefDate THEN CASE WHEN T0.ObjType='14' THEN CASE WHEN T0.U_IDA_MontoCompIVA>0 THEN (-1)* T0.U_IDA_MontoCompIVA ELSE  T0.U_IDA_MontoCompIVA END  ELSE T0.U_IDA_MontoCompIVA  END ELSE 0.00 END  END AS 'Retencion IVA',
T0.DocTime,

--CASE WHEN T0.COMPROBANTE='SI' THEN 'COMPROBANTES OTROS MESES' ELSE CASE 
--WHEN T0.TipoTran='04' THEN 'AJUSTES' ELSE '_'END  END AS 'ID',
--eml 20130605 ojo esto es para agrupar libro de ventas ojo

'_' AS 'ID',
T0.U_IDA_Serie AS 'Serie'

FROM 
dbo.O_IDAV(@Periodo) T0,
--dbo.O_IDAV('2013-01') T0,
--dbo.O_IDA1() T1, 
--dbo.O_IDA5() T2, 
--OWHT T4, 
OADM T5 (NOLOCK), OFPR T6

WHERE 
	T6.Name=@Periodo
--	Name='2013-01'
	
--ORDER BY T0.DocDate, T0.DocTime, T0.U_IDA_NroControl  

)

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[O_IDAV_SEMANAL] 
(
   @Desde AS DATE	,
   @Hasta AS DATE	
)
RETURNS TABLE 
WITH ENCRYPTION 

AS
RETURN 
(

			SELECT 

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',
			
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGasto',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGasto',
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneral',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneral',

					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneralOP',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneralOP',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'AlicuotaReducida',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'CodigoAlicuotaReducida',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'AlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='EXENTO'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaExento',
				'NO' AS 'COMPROBANTE',
				ISNULL(CASE WHEN DocSubType='--' THEN CONVERT(VARCHAR,K2.DocNum) END,'') AS 'NF', 
				ISNULL(CASE WHEN DocSubType<>'--' THEN CONVERT(VARCHAR,K2.DocNum) END,'') AS 'ND', 
				'' AS 'NC',
				K2.U_IDA_Fafe AS 'FAFE',
				ISNULL(K2.U_IDA_Serie,'00')+'-'+ISNULL(ISNULL(K2.U_IDA_NumControl,K2.U_IDA_NumControl),'') AS 'NroControl',
				U_IDA_TipoTrans AS 'TipoTran', 
			
				ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',
			
				K2.U_IDA_FechaComp AS 'FechaComp',
				K2.U_IDA_MontoCompIVA AS 'Retencion',
				1 AS 'Signo',
				K2.U_IDA_FechaContComp AS 'FechaContComp' ,
				ISNULL(K2.U_IDA_NumExport,'') as 'NroExport', 
				K2.U_IDA_NumFile AS 'ExpedienteExport' ,K2.* 
			FROM OINV K2 (NOLOCK) --, OFPR H1 (NOLOCK)
			WHERE 
				--H1.Name=@Periodo AND 
				K2.DocDate >= @Desde AND --H1.F_RefDate AND 
				K2.DocDate <= @Hasta --H1.T_RefDate
				AND K2.U_IDA_TipoTrans<>'05'
			 
			UNION ALL
			SELECT 

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGasto',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGasto',
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneral',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneral',
					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneralOP',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneralOP',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'AlicuotaReducida',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'CodigoAlicuotaReducida',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'AlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='EXENTO'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaExento',
				'NO' AS 'COMPROBANTE',
				'' AS 'NF', '' AS 'ND',  
				CONVERT(VARCHAR,K2.DocNum) AS 'NC',
				K2.U_IDA_Fafe AS 'FAFE',
--				ISNULL(K2.U_IDA_ControlNumber,'') AS 'NroControl', 
				ISNULL(K2.U_IDA_Serie,'00')+'-'+ISNULL(ISNULL(K2.U_IDA_NumControl,K2.U_IDA_NumControl),'') AS 'NroControl',
				U_IDA_TipoTrans AS 'TipoTran',
				ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',
				K2.U_IDA_FechaComp AS 'FechaComp',
				K2.U_IDA_MontoCompIVA AS 'Retencion',
				-1 AS 'Signo',
				K2.U_IDA_FechaContComp AS 'FechaContComp' ,
				ISNULL(K2.U_IDA_NumExport,'') as 'NroExport', 
				K2.U_IDA_NumFile AS 'ExpedienteExport', K2.* 
			FROM ORIN K2 (NOLOCK)--, OFPR H1 (NOLOCK)
			WHERE 
				--H1.Name=@Periodo AND 
				K2.DocDate >= @Desde AND --H1.F_RefDate AND 
				K2.DocDate <= @Hasta --H1.T_RefDate
				AND K2.U_IDA_TipoTrans<>'05'
			UNION ALL
			SELECT 
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGasto',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGasto',
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneral',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneral',
					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneralOP',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneralOP',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'AlicuotaReducida',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'CodigoAlicuotaReducida',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'AlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='EXENTO'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaExento',
				'SI' AS 'COMPROBANTE',
				'' AS 'NF', 
				'' AS 'ND', 
				'' AS 'NC',

				CONVERT(VARCHAR,K2.DocNum) AS 'FAFE', 
				'' AS 'NroControl',
				U_IDA_TipoTrans AS 'TipoTran', 
				ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',
				K2.U_IDA_FechaComp AS 'FechaComp',
				K2.U_IDA_MontoCompIVA AS 'Retencion',
				1 AS 'Signo',
				K2.U_IDA_FechaContComp AS 'FechaContComp', 
				'' as 'NroExport', 
				'' AS 'ExpedienteExport', K2.* 
			
			FROM OINV K2 (NOLOCK)--, OFPR H1 (NOLOCK)
--			WHERE H1.Name=@Periodo AND K2.U_IDA_FechaContComp >= H1.F_RefDate AND K2.U_IDA_FechaContComp <= H1.T_RefDate AND 
			WHERE 
				--H1.Name=@Periodo AND 
				K2.U_IDA_FechaContComp >= @Desde and-- H1.F_RefDate AND 
				K2.U_IDA_FechaContComp <= @hasta--H1.T_RefDate
				 AND NOT (K2.DocDate >= @Desde -- H1.F_RefDate 
				AND K2.DocDate <=@Hasta)-- H1.T_RefDate)
			        AND K2.U_IDA_TipoTrans<>'05' AND K2.U_IDA_CompIVA<>'' AND K2.U_IDA_CompIVA IS NOT NULL
			UNION ALL


			SELECT 

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGasto',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGasto',
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneral',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneral',
					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'AlicuotaGeneralOP',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					U_IDA_Alicuota='GENERAL_OP'--Rate=12--U_IDA_Alicuota='GENERAL'
					)  AS 'CodigoAlicuotaGeneralOP',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'AlicuotaReducida',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='REDUCIDA' --Rate=8	--U_IDA_Alicuota='REDUCIDA'
					)  AS 'CodigoAlicuotaReducida',
				(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'AlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='ADICIONAL'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaAdicional',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAR] = 'Y' and [Lock] = 'N' AND 
				U_IDA_Alicuota='EXENTO'--Rate=20	--U_IDA_Alicuota='ADICIONAL'
					)  AS 'CodigoAlicuotaExento',
				'SI' AS 'COMPROBANTE',
				'' AS 'NF', 
				'' AS 'ND', 
				'' AS 'NC',
				K2.U_IDA_Fafe AS 'FAFE', 
				'' AS 'NroControl',
				U_IDA_TipoTrans AS 'TipoTran', 
				ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',
				K2.U_IDA_FechaComp AS 'FechaComp',
				K2.U_IDA_MontoCompIVA AS 'Retencion',
				-1 AS 'Signo',
				K2.U_IDA_FechaContComp AS 'FechaContComp', 
				'' as 'NroExport', '' AS 'ExpedienteExport', K2.* 
			
			FROM ORIN K2 (NOLOCK)--, OFPR H1 (NOLOCK)
--			WHERE H1.Name=@Periodo AND K2.U_IDA_FechaContComp >= H1.F_RefDate AND K2.U_IDA_FechaContComp <= H1.T_RefDate AND 
			WHERE 
			--	H1.Name=@Periodo AND 
				K2.U_IDA_FechaContComp >= @Desde and --H1.F_RefDate AND 
				K2.U_IDA_FechaContComp <= @Hasta and --H1.T_RefDate AND 
				NOT (K2.DocDate >= @desde --H1.F_RefDate
				 AND K2.DocDate <= @Hasta) --H1.T_RefDate)
                                AND K2.U_IDA_TipoTrans<>'05'
                                AND K2.U_IDA_CompIVA<>'' AND K2.U_IDA_CompIVA IS NOT NULL
)

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_LIBRO_VENTAS_SEMANAL]
(	
    @Desde AS DATE,
	@Hasta AS DATE
)
RETURNS TABLE 
WITH ENCRYPTION 

AS
RETURN 
(

SELECT  
T0.DocEntry AS 'DocEntry',
T5.CompnyName as 'Agente', 
T5.TaxIdNum AS 'RIF Agente',
T5.CompnyAddr AS 'Direccion Agente',
--CASE WHEN T0.COMPROBANTE='SI' THEN T0.FechaComp ELSE T0.DocDate END AS 'Fecha',
--EML 20130605 SE CAMBIO NUEVAMENTE DESPUES DE REVISAR EL LIBRO DE VENTAS DE YG OJO EML
--T0.DocDate AS 'Fecha',
CASE WHEN T0.COMPROBANTE='SI' THEN T0.FechaContComp ELSE T0.DocDate END AS 'Fecha',
--ISNULL(T0.FAFE,'') as 'Nro. de Factura Afectada',
--CASE (len(ISNULL(T0.FAFE,''))-9) when '0' then convert(int,substring(CONVERT(char(9),ISNULL(T0.FAFE,'')),2,8)) else ISNULL(T0.FAFE,'') end  AS 'Nro. de Factura Afectada',
CASE (len(ISNULL(T0.FAFE,''))-9) when '0' then convert(VARCHAR,substring(CONVERT(char(9),ISNULL(T0.FAFE,'')),2,8)) else ISNULL(T0.FAFE,'') end  AS 'Nro. de Factura Afectada',

T0.CardName as 'Nombre o Razon Social',
CASE WHEN T0.LicTradNum='J-999999999' THEN 'ND' ELSE T0.LicTradNum END as 'RIF',
CASE WHEN  T0.FechaContComp>=@Desde AND T0.FechaContComp<=@Hasta 
THEN T0.NroComprobante END AS 'Nro. Comprobante de IVA',
CASE WHEN  T0.FechaContComp>=@Desde AND T0.FechaContComp<=@Hasta 
THEN CONVERT(DATETIME,T0.FechaComp,112)  END AS 'Fecha Comprobante',
T0.NroExport AS 'Planilla de importacion',
T0.NroExport AS 'Expediente de importacion',
 CASE WHEN T0.U_IDA_DocAnulado='02' THEN 'ANULADO' ELSE CASE 
                                WHEN T0.TipoTran='01' THEN '01-Reg' 
                                WHEN T0.TipoTran='02' THEN '02-Comp'
                                WHEN T0.TipoTran='03' THEN '03-Anu' 
                                WHEN T0.TipoTran='04' THEN '04-Aju'
                                END END AS 'Tipo Transaccion',
T0.NF AS 'Nro. de Factura',
T0.NroControl AS 'Nro. de Contol',
T0.ND as 'Nro. de Debito' ,
T0.NC as 'Nro. de Credito',
T0.FAFE as 'Factura Afectada',
--CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN 
--CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.ObjType='14' THEN (-1)*T0.DocTotal ELSE T0.DocTotal end  end 
--ELSE 0 END  END AS 'Total',
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN 
CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.ObjType='14' THEN (-1)*T0.Max1099 ELSE T0.Max1099 end  end 
ELSE 0 END  END AS 'Total',
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN T0.NroExport <>'' THEN CASE WHEN T0.ObjType='14' THEN (-1)*T0.Max1099 ELSE T0.Max1099 end  ELSE 0 END END AS 'Total EXTERNO', --T0.DocTotal

CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'V') ELSE 0 END END END AS 'Base Imponible (GENERAL)',
T0.AlicuotaGeneral AS 'Alicuota (GENERAL)', --12
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'V') * T0.AlicuotaGeneral)/100)  ELSE 0 END END END AS 'IVA (GENERAL)',



CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE1,T0.CodigoAlicuotaGeneralE1,'V') ELSE 0 END END END AS 'Base Imponible (GENERAL E1)',
T0.AlicuotaGeneralE1 AS 'Alicuota (GENERAL E1)', --12
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE1,T0.CodigoAlicuotaGeneralE1,'V') * T0.AlicuotaGeneralE1)/100)  ELSE 0 END END END AS 'IVA (GENERAL E1)',


CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE2,T0.CodigoAlicuotaGeneralE2,'V') ELSE 0 END END END AS 'Base Imponible (GENERAL E2)',
T0.AlicuotaGeneralE2 AS 'Alicuota (GENERAL E2)', --12
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE2,T0.CodigoAlicuotaGeneralE2,'V') * T0.AlicuotaGeneralE2)/100)  ELSE 0 END END END AS 'IVA (GENERAL E2)',




CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneralOP,'V') ELSE 0 END END END AS 'Base Imponible (GENERAL OP)',
T0.AlicuotaGeneralOP AS 'Alicuota (GENERAL OP)', --12
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'V') * T0.AlicuotaGeneralOP)/100)  ELSE 0 END END END AS 'IVA (GENERAL OP)',

CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaReducida,T0.CodigoAlicuotaReducida,'V') ELSE 0 END END END AS 'Base Imponible (REDUCIDA)',
T0.AlicuotaReducida AS 'Alicuota (REDUCIDA)', -- 8

CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaReducida,T0.CodigoAlicuotaReducida,'V') * T0.AlicuotaReducida)/100) ELSE 0 END END END AS 'IVA (REDUCIDA)',

--dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,'V') AS 'Base Imponible (EXENTA)',
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN T0.NroExport ='' THEN 
CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,T0.CodigoAlicuotaExento,'V') end 
ELSE 0 END END AS 'Base Imponible (EXENTA)',
0 AS 'Alicuota (EXENTA)',
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,T0.CodigoAlicuotaExento,'V') *0)/100) END AS 'EXENTO, NO SUJETO',

CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaAdicional,T0.CodigoAlicuotaAdicional,'V') END END AS 'Base Imponible (ADICIONAL)',
T0.AlicuotaAdicional AS 'Alicuota (ADICIONAL)', --20
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.COMPROBANTE='SI' THEN 0 ELSE ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaAdicional,T0.CodigoAlicuotaAdicional,'V') * T0.AlicuotaAdicional)/100) END END AS 'IVA (ADICIONAL)'
,
CASE WHEN T0.U_IDA_DocAnulado='02' THEN 0 ELSE CASE WHEN  T0.FechaContComp>=@Desde AND T0.FechaContComp<=@Hasta THEN CASE WHEN T0.ObjType='14' THEN CASE WHEN T0.U_IDA_MontoCompIVA>0 THEN (-1)* T0.U_IDA_MontoCompIVA ELSE  T0.U_IDA_MontoCompIVA END  ELSE T0.U_IDA_MontoCompIVA  END ELSE 0.00 END  END AS 'Retencion IVA',
T0.DocTime,

--CASE WHEN T0.COMPROBANTE='SI' THEN 'COMPROBANTES OTROS MESES' ELSE CASE 
--WHEN T0.TipoTran='04' THEN 'AJUSTES' ELSE '_'END  END AS 'ID',
--eml 20130605 ojo esto es para agrupar libro de ventas ojo

'_' AS 'ID',
T0.U_IDA_Serie AS 'Serie'

FROM 
dbo.O_IDAV_SEMANAL(@Desde,@Hasta) T0,
--dbo.O_IDAV('2013-01') T0,
--dbo.O_IDA1() T1, 
--dbo.O_IDA5() T2, 
--OWHT T4, 
OADM T5 (NOLOCK)--, OFPR 

--WHERE 
	--Name=@Periodo
--	Name='2013-01'
	
--ORDER BY T0.DocDate, T0.DocTime, T0.U_IDA_NroControl  

)

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[O_IDA_SEMANAL] 
(	
  @Desde AS DATE,
  @Hasta AS DATE
)

RETURNS TABLE
WITH ENCRYPTION 
AS
RETURN 
(

			SELECT 

			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGastoE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGastoE1',


					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGastoE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGastoE2',




			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',


			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'AlicuotaGasto'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'CodigoAlicuotaGasto'
			,
			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'AlicuotaGeneral'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'CodigoAlicuotaGeneral'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'AlicuotaReducida'
			,
			
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'CodigoAlicuotaReducida'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'AlicuotaAdicional'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaAdicional'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaExento'
			,
			H2.U_IDA_TipoPersona AS 'TipoPersona',
			ISNULL(CASE WHEN DocSubType='--' THEN NumAtCard END,'') AS 'NF', 
			ISNULL(CASE WHEN DocSubType<>'--' THEN NumAtCard END,'') AS 'ND', 
			'' AS 'NC',
			'' AS 'FAFE',ISNULL(K2.U_IDA_Serie,'') + ISNULL(K2.U_IDA_NumControl,'') AS 'NroControl',K2.U_IDA_TipoTrans AS 'TipoTran',
			ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',ISNULL(K2.DocDate,'') AS 'FechaComp' ,
			ISNULL(K2.U_IDA_NumImport,'') AS 'NroImportacion', ISNULL(K2.U_IDA_NumFile,'') AS 'ExpedienteImp',
			ISNULL(U_IDA_RetenTercero,'N') AS 'RetencionTercero',
			ISNULL(U_IDA_Tercero,'') AS 'Tercero',
			ISNULL(U_IDA_TipoRet,'') AS 'TipoRet',
			ISNULL(U_IDA_IsPlanilla,'') AS 'IsPlanilla',
			K2.* FROM OPCH K2 (NOLOCK) --,OFPR H1 (NOLOCK)  
			, OCRD H2 (NOLOCK)  WHERE --H1.Name=@Periodo AND
			  K2.DocDate >= @desde --H1.F_RefDate 
			AND K2.DocDate <= @hasta --H1.T_RefDate 
			AND K2.CardCode=H2.CardCode AND H2.U_IDA_TipoPersona<>'PJND'
			 AND  H2.U_IDA_TipoPersona<>'PNNR' AND K2.U_IDA_TipoTrans<>'05'
			 --, [@BKV_RECEIPT] K3 WHERE K2.DocEntry= --K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				
				UNION ALL
				
			SELECT	
			
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGastoE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGastoE1',


					(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGastoE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GASTO_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGastoE2',	
			(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE1',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E1' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE1',

	(SELECT Rate 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'AlicuotaGeneralE2',
					(SELECT Code 
				FROM OSTC (NOLOCK) 
				WHERE 
					[ValidForAP] = 'Y' and [Lock] = 'N' AND 
					
				U_IDA_Alicuota='GENERAL_E2' --Rate=12	--U_IDA_Alicuota='GASTO'
					)  AS 'CodigoAlicuotaGeneralE2',
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'AlicuotaGasto'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'CodigoAlicuotaGasto'
			,
			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'AlicuotaGeneral'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'CodigoAlicuotaGeneral'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'AlicuotaReducida'
			,
			
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'CodigoAlicuotaReducida'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'AlicuotaAdicional'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaAdicional'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaExento'
			,
			H2.U_IDA_TipoPersona AS 'TipoPersona',
			'' AS 'NF', '' AS 'ND',  NumAtCard AS 'NC',K2.U_IDA_Fafe AS 'FAFE',
			ISNULL(K2.U_IDA_Serie,'') + ISNULL(K2.U_IDA_NumControl,'') AS 'NroControl', U_IDA_TipoTrans  AS 'TipoTran', 
			ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',ISNULL(K2.DocDate,'') 
			AS 'FechaComp' ,
			ISNULL(K2.U_IDA_NumImport,'') AS 'NroImportacion', ISNULL(K2.U_IDA_NumFile,'') AS 'ExpedienteImp',
			ISNULL(U_IDA_RetenTercero,'N') AS 'RetencionTercero',
			ISNULL(U_IDA_Tercero,'') AS 'Tercero',
			ISNULL(U_IDA_TipoRet,'') AS 'TipoRet',
			ISNULL(U_IDA_IsPlanilla,'') AS 'IsPlanilla',
			K2.* FROM ORPC K2 (NOLOCK) --,OFPR H1 (NOLOCK)
			 , OCRD H2 (NOLOCK)
			 WHERE -- H1.Name=@Periodo AND 
			 K2.DocDate >= @Desde
			-- H1.F_RefDate 
			 AND K2.DocDate <= @Hasta--H1.T_RefDate
			  AND K2.CardCode=H2.CardCode AND H2.U_IDA_TipoPersona<>'PJND' AND  H2.U_IDA_TipoPersona<>'PNNR'
			AND K2.U_IDA_TipoTrans<>'05' --WHERE H1.Name=@Periodo
			--WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType


)


GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_LIBRO_COMPRAS_SEMANAL]
(	
    @Desde  AS DATE,--AS VARCHAR(100)
	@Hasta AS DATE
)
RETURNS TABLE 
WITH ENCRYPTION 

AS
RETURN 
(
SELECT  
T0.ObjType,
T0.DocEntry AS 'DocEntry',
T5.CompnyName as 'Agente', 
T5.TaxIdNum AS 'RIF Agente',
T5.CompnyAddr AS 'Direccion Agente',
T0.TaxDate  AS 'Fecha',
ISNULL(T0.FAFE,'') as 'Nro. de Factura Afectada',
--T0.CardName  as 'Nombre o Razon Social'
CASE WHEN T0.RetencionTercero='Y' THEN CASE WHEN T0.TipoRet='IVA' THEN T0.Tercero  WHEN T0.TipoRet='Todas' THEN T0.Tercero ELSE T0.CardName END ELSE T0.CardName END 
as 'Nombre o Razon Social',
CASE WHEN T0.LicTradNum='J-999999999' THEN 'ND' ELSE (CASE WHEN T0.RetencionTercero='Y' THEN CASE WHEN T0.TipoRet='IVA' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName=T0.Tercero AND CardType = 'S') WHEN T0.TipoRet='Todas' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName=T0.Tercero AND CardType = 'S') ELSE T0.LicTradNum  END  ELSE T0.LicTradNum  END) END as 'RIF',

--CASE WHEN T0.LicTradNum='J-999999999' THEN 'ND' ELSE T0.LicTradNum END as 'RIF',
 CASE 
                                WHEN T0.TipoTran='01' THEN '01-Reg' 
                                WHEN T0.TipoTran='02' THEN '02-Comp'
                                WHEN T0.TipoTran='03' THEN '03-Anu' 
                                WHEN T0.TipoTran='04' THEN '04-Aju'
                                END AS 'Tipo Transaccion',
T0.NroComprobante AS 'Nro. Comprobante de IVA',
case T0.NroComprobante when '' then null else T0.FechaComp end AS 'Fecha Comprobante',
T0.NroImportacion AS 'Planilla de importacion',
T0.ExpedienteImp AS 'Expediente de importacion',
T0.NF AS 'Nro. de Factura',
CASE WHEN T0.IsPlanilla='Y' THEN '' ELSE T0.NroControl END AS 'Nro. de Contol',
T0.ND as 'Nro. de Debito' ,
T0.NC as 'Nro. de Credito',
CASE WHEN T0.IsPlanilla='Y' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'C') +dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,0,T0.CodigoAlicuotaExento,'C') +T0.VatSum ELSE
(CASE WHEN T0.ObjType='18' THEN 1 WHEN T0.ObjType='19' THEN (-1) END)* T0.Max1099 END AS 'Total',
CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'C') end  AS 'Base Imponible (GENERAL)',
T0.AlicuotaGeneral AS 'Alicuota (GENERAL)', --12
CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE 
	((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,	
		T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,
						'C') *T0.AlicuotaGeneral)/100) end AS 'IVA (GENERAL)',


						CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE1,T0.CodigoAlicuotaGeneralE1,'C') end  AS 'Base Imponible (GENERAL E1)',
T0.AlicuotaGeneralE1 AS 'Alicuota (GENERAL E1)', --12
CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE 
	((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,	
		T0.AlicuotaGeneralE1,T0.CodigoAlicuotaGeneralE1,
						'C') *T0.AlicuotaGeneralE1)/100) end AS 'IVA (GENERAL E1)',


	CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneralE2,T0.CodigoAlicuotaGeneralE2,'C') end  AS 'Base Imponible (GENERAL E2)',
T0.AlicuotaGeneralE2 AS 'Alicuota (GENERAL E2)', --12
CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE 
	((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,	
		T0.AlicuotaGeneralE2,T0.CodigoAlicuotaGeneralE2,
						'C') *T0.AlicuotaGeneralE2)/100) end AS 'IVA (GENERAL E2)',


dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaReducida,T0.CodigoAlicuotaReducida,'C') AS 'Base Imponible (REDUCIDA)',

 T0.AlicuotaReducida AS 'Alicuota (REDUCIDA)', --8

CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE ((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaReducida,T0.CodigoAlicuotaReducida,'C') *T0.AlicuotaReducida)/100) end AS 'IVA (REDUCIDA)',

--CASE WHEN T0.IsPlanilla='Y' THEN CASE WHEN T0.VatSum=0 THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,'C')  ELSE 0 END ELSE 
dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,T0.CodigoAlicuotaExento,'C') +  
-- se agrego esta funcionalidad para las compras sin derecho a credito fiscal
dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaGasto,T0.CodigoAlicuotaGasto,'C') 
--END 
+ dbo.IDA_ImpuestoNoDeducible(T0.ObjType,T0.DocEntry,T0.CodigoAlicuotaGasto,'C')

-- OJO ESTO ES POR LA NUEVA ALICUOTA ELECTRONICA 
+ dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaGastoE1,T0.CodigoAlicuotaGastoE1,'C')   
+ dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaGastoE2,T0.CodigoAlicuotaGastoE2,'C') 
+ dbo.IDA_ImpuestoNoDeducible(T0.ObjType,T0.DocEntry,T0.CodigoAlicuotaGastoE1,'C')
+ dbo.IDA_ImpuestoNoDeducible(T0.ObjType,T0.DocEntry,T0.CodigoAlicuotaGastoE2,'C')
-- OJO ESTO ES POR LA NUEVA ALICUOTA ELECTRONICA 
AS 'Base Imponible (EXENTA)',

0 AS 'Alicuota (EXENTA)',
((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,T0.CodigoAlicuotaExento,'C') *0)/100) AS 'EXENTO, NO SUJETO',

dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T0.AlicuotaAdicional,T0.CodigoAlicuotaAdicional,'C') AS 'Base Imponible (ADICIONAL)',
T0.AlicuotaAdicional AS 'Alicuota (ADICIONAL)', --20

((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, t0.AlicuotaAdicional,T0.CodigoAlicuotaAdicional,'C') *t0.AlicuotaAdicional)/100) AS 'IVA (ADICIONAL)',


CASE WHEN T0.IsPlanilla='Y' THEN 0 ELSE dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGasto,T0.CodigoAlicuotaGasto,'C') end  AS 'Base Imponible (GASTO)',
T0.AlicuotaGasto AS 'Alicuota (GASTO)', --12

(CASE WHEN T0.ObjType='18' THEN 1 WHEN T0.ObjType='19' THEN (-1) END)* ISNULL(T2.WTAmnt,0)  'Retencion',
CASE WHEN T0.U_IDA_RetenTercero='Y' THEN (CASE WHEN T0.ObjType='18' THEN 1 WHEN T0.ObjType='19' THEN (-1) END)* ISNULL(T2.WTAmnt,0) ELSE 0 END  'RetencionTercero',
T0.DocTime AS 'DocTime',
(SELECT VatStatus FROM OCRD WHERE CardCode=T0.CardCode) AS 'VatStatus'
, T0.DocDate as 'Fecha Contable' 
, T0.TipoPersona
,CASE WHEN T0.IsPlanilla='Y' THEN dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry,T0.AlicuotaGeneral,T0.CodigoAlicuotaGeneral,'C') --T0.U_BASE_IMP 
ELSE 0 END AS 'Base Imponible Importacion'
,CASE WHEN T0.IsPlanilla='Y' THEN 
					T0.VatSum	
				ELSE 0 END AS 'IVA Importacion'
, 12 as '% Alicuota IMP'
FROM 
dbo.O_IDA_SEMANAL(@Desde,@Hasta) T0 LEFT OUTER JOIN 
--dbo.O_IDA1() T1, 
dbo.O_IDA5() T2  ON T0.DocEntry=T2.AbsEntry  AND T2.BaseType='V' 
AND T0.ObjType = T2.ObjType  LEFT OUTER JOIN  OWHT T4 (NOLOCK) ON T2.WTCode =T4.WTCode
 , 
OADM T5 (NOLOCK) --,  OFPR (NOLOCK)

--WHERE Name=@Periodo--@Periodo 
--T0.DocEntry=T1.DocEntry  AND  
--T0.DocNum=17089 --and
 
)

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_ComprobantesIVA] 
(	
  @NroComp AS VARCHAR(MAX)
 
)

RETURNS TABLE

AS
RETURN 
(

 SELECT 
T0.U_IDA_NroComp AS 'COMP',
T0.U_IDA_NroComp AS 'COMP2',
T0.U_IDA_FechaFact AS 'FECHA',
T0.U_IDA_FechaComp AS 'FECHACOMP',
T0.U_IDA_Factura AS 'NroFactura',
T0.U_IDA_NroControl AS 'NroControl',
T0.U_IDA_Credito AS 'NroCredito',
T0.U_IDA_Debito AS 'NroDebito',
T0.U_IDA_TipoTran AS 'TipoTrans',
T0.U_IDA_Total AS 'Total',
CONVERT(DECIMAL(11,2),T0.U_IDA_Alicuota) AS 'Alicuota',
CONVERT(VARCHAR,YEAR(T0.U_IDA_FechaComp)) AS 'Year',
RIGHT('0'+CONVERT(VARCHAR,MONTH(T0.U_IDA_FechaComp)),2) AS 'Month',
*
FROM [@IDA_COMPROBANTES] T0 

       WHERE T0.U_IDA_NroComp=@NroComp AND 
  T0.U_IDA_Status='01'

)

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_ListadoComprobantesIVA] 
(
@FechaD AS DATETIME,
@FechaH AS DATETIME,
@CardCodeD AS VARCHAR(MAX),
@CardCodeH AS VARCHAR(MAX)
)

RETURNS TABLE 


AS
RETURN 
(

	SELECT T0.*,T1.CompnyName FROM [dbo].[@IDA_COMPROBANTES] T0, 
	OADM T1 WHERE T0.U_IDA_CardCode >= 
	@CardCodeD--(SELECT CardName FROM OCRD WHERE CardCode=@CardCodeD) 
	AND T0.U_IDA_CardCode <= @CardCodeH-- (SELECT CardName FROM OCRD WHERE CardCode=@CardCodeH) 
AND T0.U_IDA_FechaFact >= @FechaD
AND  T0.U_IDA_FechaFact <= @FechaH						
AND T0.U_IDA_Status='01'
)


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_ComprobanteISLR_Operacion] 
(	
  @CardCode AS VARCHAR(100),
  @Tipo AS VARCHAR(100),
  @DocNum AS VARCHAR(100)
)

RETURNS TABLE

AS
RETURN 
(
 
         SELECT * FROM 
(

 SELECT 
'01' AS 'Tipo',
 OA.CompnyName AS Nombre_A_Retencion
,OA.TaxIdNum AS RIF_A
,ISNULL(OA.CompnyAddr,'') AS DIRECCION
,CASE WHEN P0.U_IDA_RetenTercero='Y' THEN  CASE WHEN P0.U_IDA_TipoRet='ISLR' THEN P0.U_IDA_Tercero WHEN P0.U_IDA_TipoRet='Todas' THEN P0.U_IDA_Tercero  ELSE P0.CardName END ELSE P0.CardName END AS NOMBRE_PROVEEDOR

,CASE WHEN P0.U_IDA_RetenTercero='Y' THEN  CASE WHEN P0.U_IDA_TipoRet='ISLR' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName = P0.U_IDA_Tercero AND CardType='S') WHEN P0.U_IDA_TipoRet='Todas' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName = P0.U_IDA_Tercero AND CardType='S')  ELSE P0.LicTradNum END ELSE P0.LicTradNum END AS RIF_P

--,P0.LicTradNum AS RIF_P
,ISNULL(P0.Address,'') AS DIRECCION_P
,OC.Phone1 AS TELEFONO
,OC.CardCode AS CARDCODE
--,CONVERT(VARCHAR,DATEPART(YEAR,CONVERT(Varchar,P0.DocDate))) +'-' + CONVERT(VARCHAR,DATEPART(MONTH,CONVERT(Varchar,P0.DocDate)))AS PERIODO
,CONVERT(VARCHAR,DATEPART(YEAR,CONVERT(Varchar,P0.DocDate))) AS ANNO
,CONVERT(VARCHAR,DATEPART(MONTH,CONVERT(Varchar,P0.DocDate))) AS MES 
,W.WTCode AS INDICADOR_RETENCION
,W.WTName AS DESCRIPCION
,CASE WHEN P0.DocSubType = '--' THEN P0.NumAtCard END AS FACTURA
,CASE WHEN P0.DocSubType <> '--' THEN P0.NumAtCard END AS ND
, NULL AS NC
,P0.DocDate AS FECHA_FAC --?
,P0.TaxDate AS FECHA_PAGO--?
--,P5.TaxbleAmnt AS BASE_RETENCION 
--,CAST( P5.Rate AS NUMERIC(19,6))  AS PORCENTAJE_RETENCION
,((P5.WTAmnt + ISNULL(W.U_IDA_Sustraendo,0)) /(W.PrctBsAmnt/100)) AS BASE_RETENCION
,CAST( W.PrctBsAmnt AS NUMERIC(19,6))  AS PORCENTAJE_RETENCION
,CAST( ISNULL(W.U_IDA_Sustraendo,0)AS NUMERIC(19,6)) AS SUSTRAENDO
,CAST(P5.WTAmnt AS NUMERIC(19,6)) AS VALOR_RETENCION
,(isnull(P0.U_IDA_Serie,'00') +' '+ P0.U_IDA_NumControl) AS NUMEROCONTROL
,CAST(P0.Max1099 AS NUMERIC(19,6)) AS 'Total'
,P0.U_IDA_TipoTrans
,(SELECT Code FROM OFPR WHERE AbsEntry = P0.FinncPriod) AS 'Periodo'
,W.OffclCode AS 'OfficialCode'
,
dbo.IDA_BaseImponible(P0.ObjType,P0.DocEntry, 0,(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO'),'C') AS 'Monto Exento'
FROM OPCH P0 , PCH5 P5, OWHT W , OADM OA , OCRD OC

WHERE 
P0.DocEntry=P5.AbsEntry
AND P5.WTCode=W.WTCode
AND W.U_IDA_TipoRetencion='ISLR'
AND OC.CardCode= P0.CardCode
AND
P0.NumAtCard =@DocNum

AND OC.CardCode =  @CardCode
AND P0.U_IDA_TipoTrans<>'05'
UNION ALL



SELECT 
'02' AS 'Tipo',
 OA.CompnyName AS Nombre_A_Retencion
,OA.TaxIdNum AS RIF_A
,ISNULL(OA.CompnyAddr,'') AS DIRECCION
,CASE WHEN P0.U_IDA_RetenTercero='Y' THEN  CASE WHEN P0.U_IDA_TipoRet='ISLR' THEN P0.U_IDA_Tercero WHEN P0.U_IDA_TipoRet='Todas' THEN P0.U_IDA_Tercero  ELSE P0.CardName END ELSE P0.CardName END AS NOMBRE_PROVEEDOR
,CASE WHEN P0.U_IDA_RetenTercero='Y' THEN  CASE WHEN P0.U_IDA_TipoRet='ISLR' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName = P0.U_IDA_Tercero AND CardType='S') WHEN P0.U_IDA_TipoRet='Todas' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName = P0.U_IDA_Tercero AND CardType='S')  ELSE P0.LicTradNum END ELSE P0.LicTradNum END AS RIF_P
--,P0.LicTradNum AS RIF_P
,ISNULL(P0.Address,'') AS DIRECCION_P
,OC.Phone1 AS TELEFONO
,OC.CardCode AS CARDCODE
--,CONVERT(VARCHAR,DATEPART(YEAR,CONVERT(Varchar,P0.DocDate))) +'-' + CONVERT(VARCHAR,DATEPART(MONTH,CONVERT(Varchar,P0.DocDate)))AS PERIODO
,CONVERT(VARCHAR,DATEPART(YEAR,CONVERT(Varchar,P0.DocDate))) AS ANNO
,CONVERT(VARCHAR,DATEPART(MONTH,CONVERT(Varchar,P0.DocDate))) AS MES 
,W.WTCode AS INDICADOR_RETENCION
,W.WTName AS DESCRIPCION
,NULL AS FACTURA
,NULL AS ND
,P0.NumAtCard  AS NC
,P0.DocDate AS FECHA_FAC --?
,P0.TaxDate AS FECHA_PAGO--?
--,-P5.TaxbleAmnt  AS BASE_RETENCION 
--,CAST(P5.Rate AS NUMERIC(19,6)) AS PORCENTAJE_RETENCION
,-1*((P5.WTAmnt + ISNULL(W.U_IDA_Sustraendo,0)) /(W.PrctBsAmnt/100)) AS BASE_RETENCION
,CAST( W.PrctBsAmnt AS NUMERIC(19,6))  AS PORCENTAJE_RETENCION

,CAST(ISNULL(W.U_IDA_Sustraendo,0)AS NUMERIC(19,6)) AS SUSTRAENDO
,CAST(-P5.WTAmnt AS NUMERIC(19,6)) AS VALOR_RETENCION
,(isnull(P0.U_IDA_Serie,'00') +' '+ P0.U_IDA_NumControl) AS NUMEROCONTROL
,CAST(- P0.Max1099 AS NUMERIC(19,6)) AS 'Total'
,P0.U_IDA_TipoTrans
,(SELECT Code FROM OFPR WHERE AbsEntry = P0.FinncPriod) AS 'PERIODO',
W.OffclCode AS 'OfficialCode',
-1*dbo.IDA_BaseImponible(P0.ObjType,P0.DocEntry, 0,(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO'),'C') AS 'Monto Exento'
FROM ORPC P0 , RPC5 P5, OWHT W , OADM OA , OCRD OC

WHERE 
P0.DocEntry=P5.AbsEntry
AND P5.WTCode=W.WTCode
AND W.U_IDA_TipoRetencion='ISLR'
AND OC.CardCode= P0.CardCode AND
P0.NumAtCard =@DocNum
 
AND OC.CardCode = @CardCode
AND P0.U_IDA_TipoTrans<>'05'
)
OO WHERE OO.Tipo =@Tipo

)


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_ComprobanteISLR_Mensual] 
(	
  @CardCode AS VARCHAR(100),
  @Periodo AS VARCHAR(100)
)

RETURNS TABLE

AS
RETURN 
(
 
          (SELECT 
 OA.CompnyName AS Nombre_A_Retencion
,OA.TaxIdNum AS RIF_A
,ISNULL(OA.CompnyAddr,'') AS DIRECCION
,P0.CardName AS NOMBRE_PROVEEDOR
,P0.LicTradNum AS RIF_P
,ISNULL(P0.Address,'') AS DIRECCION_P
,OC.Phone1 AS TELEFONO
,OC.CardCode AS CARDCODE
--,CONVERT(VARCHAR,DATEPART(YEAR,CONVERT(Varchar,P0.DocDate))) +'-' + CONVERT(VARCHAR,DATEPART(MONTH,CONVERT(Varchar,P0.DocDate)))AS PERIODO
,CONVERT(VARCHAR,DATEPART(YEAR,CONVERT(Varchar,P0.DocDate))) AS ANNO
,CONVERT(VARCHAR,DATEPART(MONTH,CONVERT(Varchar,P0.DocDate))) AS MES 
,W.WTCode AS INDICADOR_RETENCION
,W.WTName AS DESCRIPCION
,CASE WHEN P0.DocSubType = '--' THEN P0.NumAtCard END AS FACTURA
,CASE WHEN P0.DocSubType <> '--' THEN P0.NumAtCard END AS ND
, NULL AS NC
,P0.DocDate AS FECHA_FAC --?
,P0.TaxDate AS FECHA_PAGO--?
--,P5.TaxbleAmnt AS BASE_RETENCION
,((P5.WTAmnt + ISNULL(W.U_IDA_Sustraendo,0)) /(W.PrctBsAmnt/100)) AS BASE_RETENCION
 
,CAST(W.PrctBsAmnt AS NUMERIC(19,6))  AS PORCENTAJE_RETENCION
--,CAST(W.Rate AS NUMERIC(10,2))  AS PORCENTAJE_RETENCION
,CAST( ISNULL(W.U_IDA_Sustraendo,0)AS NUMERIC(19,6)) AS SUSTRAENDO
,CAST(P5.WTAmnt AS NUMERIC(19,6)) AS VALOR_RETENCION
,(P0.U_IDA_Serie +' '+ P0.U_IDA_NumControl) AS NUMEROCONTROL
,CAST(P0.Max1099 AS NUMERIC(19,6)) AS 'Total'
,P0.U_IDA_TipoTrans
,(SELECT Code FROM OFPR WHERE AbsEntry = P0.FinncPriod) AS 'Periodo'
,W.OffclCode AS 'OfficialCode'
,
dbo.IDA_BaseImponible(P0.ObjType,P0.DocEntry, 0,(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO'),'C') AS 'Monto Exento'
FROM OPCH P0 , PCH5 P5, OWHT W , OADM OA , OCRD OC

WHERE 
P0.DocEntry=P5.AbsEntry
AND P5.WTCode=W.WTCode
AND W.U_IDA_TipoRetencion='ISLR'
AND OC.CardCode= P0.CardCode
AND (SELECT Code FROM OFPR WHERE AbsEntry=P0.FinncPriod)=@Periodo
AND OC.CardCode = @CardCode
AND P0.U_IDA_TipoTrans<>'05'
)


UNION ALL

(SELECT 
 OA.CompnyName AS Nombre_A_Retencion
,OA.TaxIdNum AS RIF_A
,ISNULL(OA.CompnyAddr,'') AS DIRECCION
,P0.CardName AS NOMBRE_PROVEEDOR
,P0.LicTradNum AS RIF_P
,ISNULL(P0.Address,'') AS DIRECCION_P
,OC.Phone1 AS TELEFONO
,OC.CardCode AS CARDCODE
--,CONVERT(VARCHAR,DATEPART(YEAR,CONVERT(Varchar,P0.DocDate))) +'-' + CONVERT(VARCHAR,DATEPART(MONTH,CONVERT(Varchar,P0.DocDate)))AS PERIODO
,CONVERT(VARCHAR,DATEPART(YEAR,CONVERT(Varchar,P0.DocDate))) AS ANNO
,CONVERT(VARCHAR,DATEPART(MONTH,CONVERT(Varchar,P0.DocDate))) AS MES 
,W.WTCode AS INDICADOR_RETENCION
,W.WTName AS DESCRIPCION
,NULL AS FACTURA
,NULL AS ND
,P0.NumAtCard  AS NC
,P0.DocDate AS FECHA_FAC --?
,P0.TaxDate AS FECHA_PAGO--?
--,-P5.TaxbleAmnt  AS BASE_RETENCION 
,-1*((P5.WTAmnt + ISNULL(W.U_IDA_Sustraendo,0)) /(W.PrctBsAmnt/100)) AS BASE_RETENCION

,CAST(W.PrctBsAmnt AS NUMERIC(19,6))  AS PORCENTAJE_RETENCION
--,CAST(W.Rate AS NUMERIC(10,2))  AS PORCENTAJE_RETENCION
,CAST(ISNULL(W.U_IDA_Sustraendo,0)AS NUMERIC(19,6)) AS SUSTRAENDO
,CAST(-P5.WTAmnt AS NUMERIC(19,6)) AS VALOR_RETENCION
,(P0.U_IDA_Serie +' '+ P0.U_IDA_NumControl) AS NUMEROCONTROL
,CAST(- P0.Max1099 AS NUMERIC(19,6)) AS 'Total'
,P0.U_IDA_TipoTrans
,(SELECT Code FROM OFPR WHERE AbsEntry = P0.FinncPriod) AS 'Periodo'
,W.OffclCode AS 'OfficialCode',
-1*dbo.IDA_BaseImponible(P0.ObjType,P0.DocEntry, 0,(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO'),'C') AS 'Monto Exento'
FROM ORPC P0 , RPC5 P5, OWHT W , OADM OA , OCRD OC

WHERE 
P0.DocEntry=P5.AbsEntry
AND P5.WTCode=W.WTCode
AND W.U_IDA_TipoRetencion='ISLR'
AND OC.CardCode= P0.CardCode
AND (SELECT Code FROM OFPR WHERE AbsEntry=P0.FinncPriod)=@Periodo
AND OC.CardCode = @CardCode
AND P0.U_IDA_TipoTrans<>'05'
)

)


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_ComprobantesISLR] 
(	
  @NroComp AS VARCHAR(MAX)
 
)

RETURNS TABLE
WITH ENCRYPTION 
AS
RETURN 
(

 SELECT 
T0.U_IDA_NroComp AS 'COMP',
T0.U_IDA_NroComp AS 'COMP2',
T0.U_IDA_FechaDoc AS 'FECHA',
T0.U_IDA_FechaComp AS 'FECHACOMP',
T0.U_IDA_NroFactura AS 'NroFactura',
T0.U_IDA_NroControl AS 'NroControl',
T0.U_IDA_NroNC AS 'NroCredito',
T0.U_IDA_NroND AS 'NroDebito',
T0.U_IDA_TipoTrans AS 'TipoTrans',
T0.U_IDA_DocTotal AS 'Total',
CONVERT(VARCHAR,YEAR(T0.U_IDA_FechaComp)) AS 'Year',
RIGHT('0'+CONVERT(VARCHAR,MONTH(T0.U_IDA_FechaComp)),2) AS 'Month',
*
FROM [@IDA_COMP_ISLR] T0 

       WHERE T0.U_IDA_NroComp=@NroComp AND 
  T0.U_IDA_Status='01'

)


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IDA_RETENCION_TXT_IVA_SEMANAL]
(	
	-- Add the parameters for the function here
	
	 @DateTo AS DATETIME

)
RETURNS TABLE 
WITH ENCRYPTION 

AS
RETURN
(
	SELECT Code,Name,
U_IDA_NroControl ,
REPLACE(CONVERT(VARCHAR,U_IDA_FechaFact,111),'/','-') AS 'U_IDA_FechaFact',
U_IDA_ObjType,
U_IDA_DocEntry,

ROUND(CONVERT(DECIMAL(19,2),U_IDA_Alicuota,2),2) AS 'U_IDA_Alicuota',

CASE WHEN U_IDA_ObjType='19' THEN -1* 
ROUND(CONVERT(DECIMAL(19,2),U_IDA_IVA,2),2) 
ELSE ROUND(CONVERT(DECIMAL(19,2),U_IDA_IVA,2),2) END AS 'U_IDA_IVA',

CASE WHEN U_IDA_ObjType='19' THEN -1* 
ROUND(CONVERT(DECIMAL(19,2),U_IDA_BaseImp,2),2) 
ELSE ROUND(CONVERT(DECIMAL(19,2),U_IDA_BaseImp,2),2)  END AS 'U_IDA_BaseImp',

CASE WHEN U_IDA_ObjType='19' THEN -1*  
ROUND(CONVERT(DECIMAL(19,2),U_IDA_Retencion,2),2) 
ELSE ROUND(CONVERT(DECIMAL(19,2),U_IDA_Retencion,2),2) END AS 'U_IDA_Retencion',

CASE WHEN U_IDA_ObjType='19' THEN -1*  ROUND(CONVERT(DECIMAL(19,2),U_IDA_Total,2),2)
ELSE ROUND(CONVERT(DECIMAL(19,2),U_IDA_Total,2),2) END AS 'U_IDA_Total',

CASE WHEN U_IDA_ObjType='19' THEN -1*  ROUND(CONVERT(DECIMAL(19,2),U_IDA_Exento,2),2) 
ELSE ROUND(CONVERT(DECIMAL(19,2),U_IDA_Exento,2),2)  END AS 'U_IDA_Exento',

CASE WHEN REPLACE(U_IDA_Fafe,'-','')='' THEN '0' ELSE ISNULL(U_IDA_Fafe,'0') END AS 'U_IDA_Fafe',
REPLACE(U_IDA_Factura,'-','') AS 'U_IDA_Factura',
REPLACE(U_IDA_Credito,'-','') AS 'U_IDA_Credito',
REPLACE(U_IDA_Debito,'-','') AS 'U_IDA_Debito',
CONCAT('0',U_IDA_TipoTran) AS 'U_IDA_TipoTran',
U_IDA_CardCode,
U_IDA_CardName,
U_IDA_Agente,
U_IDA_NroComp,
REPLACE(U_IDA_LicTradNum,'-','') as 'U_IDA_LicTradNum',
REPLACE(U_IDA_TaxIdNo,'-','') as 'U_IDA_TaxIdNo',  
REPLACE(CONVERT(VARCHAR,U_IDA_FechaComp),'/','-') AS 'U_IDA_FechaComp',
U_IDA_Row,
U_IDA_Status,
U_IDA_PrcntRet,
U_IDA_CompanyAddress,
U_IDA_Address,
U_IDA_DocSubtype,
REPLACE(U_IDA_Periodo,'-','') as 'U_IDA_Periodo',
CASE  
WHEN U_IDA_ObjType='18' THEN 
	( CASE WHEN U_IDA_DocSubType ='--' THEN U_IDA_Factura  ELSE U_IDA_Debito END ) ELSE U_IDA_Credito END AS 'U_IDA_NumAtCard', 'C' AS 'U_IDA_TipoOperacion' , 
	'0' AS 'U_IDA_NroFile' 
	,U_IDA_Quincena FROM [@IDA_COMPROBANTES]
	WHERE 
	convert(varchar,U_IDA_FechaComp,112)>=convert(varchar,DATEADD(day,-7, @DateTo) ,112)
	and
	convert(varchar,U_IDA_FechaComp,112)<=convert(varchar,@DateTo,112)
	--U_IDA_Periodo= (CONVERT(VARCHAR,@Ano)+'-' + CONVERT(VARCHAR,@Mes)) AND U_IDA_Quincena=@Quincena
	AND U_IDA_Status='01' 
)



 

GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[O_ISLR]
(	
    @Periodo AS VARCHAR(100)
)
RETURNS TABLE 


AS
RETURN 
(

select
REPLACE(T9.TaxIdNum,'-','') AS 'RifAgente',  
convert(Varchar(6), T1.DocDate,112) AS 'Periodo', 
REPLACE(T1.LicTradNum,'-','') AS 'RifRetenido', 
REPLACE(T1.NumAtCard,'-','') AS 'NumeroFactura', 
T1.U_IDA_NumControl AS 'NumeroControl',
REPLACE(CONVERT(VARCHAR,T1.DocDate,105),'-','/') AS 'FechaOperacion',
T8.OffclCode AS 'CodigoConcepto', 
T7.TaxbleAmnt AS 'MontoOperacion1', 
--T1.BaseAmnt 'MontoOperacion',
((T7.WTAmnt + ISNULL(T8.U_IDA_Sustraendo,0)) /(T8.PrctBsAmnt/100)) AS 'MontoOperacion',
T7.WTAmnt AS 'Retencion', 
T8.PrctBsAmnt AS 'PorcentajeRetencion'
from OPCH T1, PCH5 T7, OWHT T8, OADM T9, OFPR T0
where
T0.Code = @Periodo and --@Periodo
T1.DocDate >= T0.F_RefDate and
T1.DocDate <= T0.T_RefDate AND
T7.AbsEntry = T1.DocEntry AND
T8.WTCode = T7.WTCode		AND
T8.U_IDA_TipoRetencion = 'ISLR'	AND
T8.Category = 'I'
AND T1.U_IDA_TipoTrans<>'05'
UNION ALL
select
REPLACE(T9.TaxIdNum,'-','') AS 'RifAgente',  
convert(Varchar(6), T1.DocDate,112) AS 'Periodo', 
REPLACE(T1.LicTradNum,'-','') AS 'RifRetenido', 
T1.NumAtCard AS 'NumeroFactura', 
T1.U_IDA_NumControl AS 'NumeroControl',
REPLACE(CONVERT(VARCHAR,T1.DocDate,105),'-','/') AS 'FechaOperacion',
T8.OffclCode AS 'CodigoConcepto', 
-T7.TaxbleAmnt AS 'MontoOperacion1', 
---T1.BaseAmnt 'MontoOperacion',
-((T7.WTAmnt + ISNULL(T8.U_IDA_Sustraendo,0)) /(T8.PrctBsAmnt/100)) AS 'MontoOperacion',
-T7.WTAmnt AS 'Retencion', 
T8.PrctBsAmnt AS 'PorcetajeRetencion'
from ORPC T1 --, RPC1 T2
, RPC5 T7, OWHT T8, OADM T9, OFPR T0
where
T0.Code = @Periodo and --@Periodo
T1.DocDate >= T0.F_RefDate and
T1.DocDate <= T0.T_RefDate AND
--T2.DocEntry = T1.DocEntry AND
--T7.AbsEntry = T2.BaseRef AND
T7.AbsEntry =  T1.DocEntry AND
T8.WTCode = T7.WTCode		AND
T8.U_IDA_TipoRetencion = 'ISLR'	AND
T8.Category = 'I'
AND T1.U_IDA_TipoTrans<>'05'

)

GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[IDA_RETENCION_XML_ISLR]
(	
	-- Add the parameters for the function here
   @Periodo AS VARCHAR(100)
)
RETURNS TABLE 


AS
RETURN 
(
	SELECT 
RifAgente,  
REPLACE(Periodo,'-','') as 'Periodo', 
RifRetenido, 
NumeroFactura, 

NumeroControl,FechaOperacion
,
CodigoConcepto, 
REPLACE(CONVERT(VARCHAR,CONVERT(DECIMAL(12,2),(SUM(MontoOperacion)))),',','.') AS 'MontoOperacion', 
REPLACE(CONVERT(VARCHAR,CONVERT(DECIMAL(12,2),SUM(Retencion))),',','.') AS 'Retencion', 
REPLACE(CONVERT(VARCHAR,CONVERT(DECIMAL(12,2),PorcentajeRetencion)),',','.') 'PorcentajeRetencion'
FROM dbo.[O_ISLR](@Periodo) T0
GROUP BY
RifAgente,  
Periodo, 
RifRetenido, 
NumeroFactura, 
NumeroControl,
FechaOperacion,
CodigoConcepto, 
PorcentajeRetencion
HAVING 
SUM(Retencion) <> 0

)
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerarTXTSemanal]

@DateTo DateTime

AS

BEGIN

SELECT U_IDA_TaxIdNo, U_IDA_Periodo, U_IDA_FechaFact, U_IDA_Factura, U_IDA_TipoOperacion, U_IDA_TipoTran,U_IDA_LicTradNum, U_IDA_NumAtCard, U_IDA_NroControl,U_IDA_Total,U_IDA_BaseImp, U_IDA_Retencion, U_IDA_Fafe,U_IDA_NroComp, U_IDA_Exento,U_IDA_Alicuota,U_IDA_NroFile FROM IDA_RETENCION_TXT_IVA_SEMANAL(convert(varchar,@DateTo,112));

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerarXMLMensual]

@Periodo nvarchar(100)

AS

BEGIN

SELECT * FROM IDA_RETENCION_XML_ISLR(@Periodo)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerateClosePeriodAccount]

@StarDate DateTime,
@EndDate Datetime,
@AcctCode nvarchar(15),
@AcctCodeCierre nvarchar(15),
@AcctCodeArrastre nvarchar(15)

AS

BEGIN

SELECT 

T0.[Account],
T0.[ShortName],
CAST(SUM(T0.[Debit])-SUM(T0.[Credit])AS decimal(19,2)) AS 'SaldoML',
0.00 AS 'SaldoME',
CAST(SUM(T0.[SYSDeb])- SUM(T0.[SYSCred])AS decimal(19,2)) AS 'SaldoMS',
T2.[ActCurr],
T2.[ActType],
T2.[AcctName]

FROM  [dbo].[JDT1] T0  
INNER JOIN [dbo].[OACT] T2 ON T0.[Account]=T2.[AcctCode] 
WHERE T0.[RefDate] >= (@StarDate) AND T0.[RefDate] <= (@EndDate) AND T2.[LocManTran]='N' AND T0.[Account]=@AcctCode AND T0.[Account]<>@AcctCodeArrastre AND T0.[Account]<>@AcctCodeCierre

GROUP BY T0.[Account], T0.[ShortName], T2.[ActCurr], T2.[ActType], T2.[AcctName]
HAVING CAST(SUM(T0.[Debit])-SUM(T0.[Credit])AS decimal(19,2))<>0
ORDER BY T0.[Account], T0.[ShortName]

END


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerateClosePeriodBP]

@StarDate DateTime,
@EndDate Datetime,
@StarBP nvarchar(15),
@EndBP nvarchar(15),
@AcctCodeCierre nvarchar(15),
@AcctCodeArrastre nvarchar(15)

AS

BEGIN

SELECT 
T0.[Account],
T0.[ShortName],
CAST(SUM(T0.[Debit]) - SUM(T0.[Credit])AS decimal(19,2)) AS 'SaldoML',
0.00 AS 'SaldoME',
CAST(SUM(T0.[SYSDeb]) - SUM(T0.[SYSCred])AS decimal(19,2)) AS 'SaldoMS',
T2.[ActCurr],
T2.[ActType],
T1.[CardName] AS 'AcctName'

FROM  [dbo].[JDT1] T0  INNER  JOIN [dbo].[OCRD] T1  ON  T1.[CardCode] = T0.[ShortName]
INNER  JOIN [dbo].[OACT] T2  ON  T2.[AcctCode] = T0.[Account]
WHERE T0.[RefDate] >= (@StarDate) AND T0.[RefDate] <= (@EndDate) AND T0.[Account] <> T0.[ShortName] AND T0.[ShortName] >= (@StarBP) AND T0.[ShortName]<=(@EndBP) AND T2.[LocManTran]='Y' AND T0.[Account]<>@AcctCodeArrastre AND T0.[Account]<>@AcctCodeCierre
GROUP BY T0.[ShortName], T0.[Account], T1.[CardCode], T1.[CardName], T2.[ActCurr], T2.[ActType]

HAVING CAST(SUM(T0.[Debit])-SUM(T0.[Credit])AS decimal(19,2))<>0 ORDER BY T0.[ShortName],T0.[Account]
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindBP]

AS

BEGIN

SELECT * FROM OCRD
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerateExchangeRateDifferenceAccount]

@AccountGanancia nvarchar(15),
@AccountPerdida nvarchar(15),
@RefDate datetime,
@F_DueDate datetime,
@T_DueDate datetime,
@AcctCode nvarchar(15),
@Currency nvarchar(3)

AS

BEGIN

IF(@Currency='##')
BEGIN
SELECT
T0.[Account],
T0.[ShortName],
T2.[AcctName],
CAST(SUM(T0.[FCCredit]-T0.[FCDebit])AS decimal(19,2)) AS 'SaldoME',
CAST(SUM(T0.[Credit]-T0.[Debit]) AS decimal(19,2)) AS 'Saldo',
CAST((SUM(T0.[FCCredit]-T0.[FCDebit])*T3.[Rate])-SUM(T0.[Credit]-T0.[Debit])AS decimal(19,2)) AS 'Diferencia',
T0.[FCCurrency],
T3.[Rate],
ISNULL(T4.[CardType],'N') AS 'Type'
FROM  [dbo].[JDT1] T0  INNER  JOIN [dbo].[OJDT] T1  ON  T1.[TransId] = T0.[TransId]
INNER  JOIN [dbo].[OACT] T2  ON  T2.[AcctCode] = T0.[Account]
LEFT JOIN [dbo].[ORTT] T3 ON T3.[Currency]=T0.[FCCurrency]
LEFT JOIN [dbo].[OCRD] T4 ON T4.[CardCode]=T0.[ShortName]
WHERE T0.[ShortName] = (@AcctCode) AND  T0.[RefDate] <= (@RefDate) AND T3.[RateDate]=@RefDate  AND  T0.[DueDate] >= (@F_DueDate)  AND  T0.[DueDate] <= (@T_DueDate) AND T2.[ActType]='N' AND T0.[Account]<>@AccountGanancia AND T0.[Account]<>@AccountPerdida  GROUP BY T0.[Account], T0.[FCCurrency], T3.[Rate], T4.[CardType], T0.[ShortName], T2.[AcctName] HAVING CAST((SUM(T0.[FCCredit]-T0.[FCDebit])*T3.[Rate])-SUM(T0.[Credit]-T0.[Debit])AS decimal(19,2))<>0

END
ELSE
BEGIN
SELECT
T0.[Account],
T0.[ShortName],
T2.[AcctName],
CAST(SUM(T0.[FCCredit]-T0.[FCDebit]) AS decimal(19,2)) AS 'SaldoME',
CAST(SUM(T0.[Credit]-T0.[Debit])AS decimal(19,2)) AS 'Saldo',
CAST((SUM(T0.[FCCredit]-T0.[FCDebit])*T3.[Rate])-SUM(T0.[Credit]-T0.[Debit])AS decimal(19,2)) AS 'Diferencia',
T0.[FCCurrency],
T3.[Rate],
ISNULL(T4.[CardType],'N') AS 'Type'
FROM  [dbo].[JDT1] T0  INNER  JOIN [dbo].[OJDT] T1  ON  T1.[TransId] = T0.[TransId]
INNER  JOIN [dbo].[OACT] T2  ON  T2.[AcctCode] = T0.[Account]
INNER JOIN [dbo].[ORTT] T3 ON T3.[Currency]=T0.[FCCurrency]
LEFT JOIN [dbo].[OCRD] T4 ON T4.[CardCode]=T0.[ShortName]
WHERE T0.[ShortName] = (@AcctCode) AND T3.[Currency]=@Currency AND T0.[RefDate] <= (@RefDate) AND T3.[RateDate]=@RefDate AND  T0.[DueDate] >= (@F_DueDate)  AND  T0.[DueDate] <= (@T_DueDate) AND T2.[ActType]='N' AND T0.[Account]<>@AccountGanancia AND T0.[Account]<>@AccountPerdida GROUP BY T0.[Account], T0.[FCCurrency], T3.Rate, T4.CardType, T0.ShortName, T2.AcctName HAVING CAST((SUM(T0.[FCCredit]-T0.[FCDebit])*T3.[Rate])-SUM(T0.[Credit]-T0.[Debit])AS decimal(19,2))<>0
END

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerateExchangeRateDifferenceBP]

@SupplierGanancia nvarchar(15),
@SupplierPerdida nvarchar(15),
@CustomerGanancia nvarchar(15),
@CustomerPerdida nvarchar(15),
@RefDate datetime,
@F_DueDate datetime,
@T_DueDate datetime,
@StarBP nvarchar(15),
@EndBP nvarchar(15),
@Currency nvarchar(3)

AS

BEGIN

IF(@Currency='##')
BEGIN
SELECT
T0.[Account],
T0.[ShortName],
T2.[AcctName],
CAST(SUM(T0.[FCCredit]-T0.[FCDebit]) AS decimal(19,2)) AS 'SaldoME',
CAST(SUM(T0.[Credit]-T0.[Debit]) AS decimal(19,2)) AS 'Saldo',
CAST((SUM(T0.[FCCredit]-T0.[FCDebit])*T3.[Rate])-SUM(T0.[Credit]-T0.[Debit]) AS decimal(19,2)) AS 'Diferencia',
T0.[FCCurrency],
T3.[Rate],
ISNULL(T4.[CardType],'N') AS 'Type'
FROM  [dbo].[JDT1] T0  INNER  JOIN [dbo].[OJDT] T1  ON  T1.[TransId] = T0.[TransId]
INNER  JOIN [dbo].[OACT] T2  ON  T2.[AcctCode] = T0.[Account]
INNER JOIN [dbo].[ORTT] T3 ON T3.[Currency]=T0.[FCCurrency]
LEFT JOIN [dbo].[OCRD] T4 ON T4.[CardCode]=T0.[ShortName]
WHERE T0.[ShortName] >= (@StarBP) AND T0.[ShortName]<=(@EndBP) AND T0.[RefDate] <= (@RefDate) AND T3.[RateDate]=@RefDate  AND  T0.[DueDate] >= (@F_DueDate)  AND  T0.[DueDate] <= (@T_DueDate) AND T2.[ActType]='N' AND T0.[Account]<>@SupplierGanancia AND T0.[Account]<>@SupplierGanancia AND T0.[Account]<>@CustomerGanancia AND T0.[Account]<>@CustomerPerdida GROUP BY T0.[Account], T0.[FCCurrency], T3.Rate, T4.CardType, T0.ShortName, T2.AcctName HAVING CAST((SUM(T0.[FCCredit]-T0.[FCDebit])*T3.[Rate])-SUM(T0.[Credit]-T0.[Debit]) AS decimal(19,2))<>0
ORDER BY T0.[ShortName],T0.[Account]

END
ELSE
BEGIN
SELECT
T0.[Account],
T0.[ShortName],
T2.[AcctName],
CAST(SUM(T0.[FCCredit]-T0.[FCDebit]) AS decimal(19,2)) AS 'SaldoME',
CAST(SUM(T0.[Credit]-T0.[Debit]) AS decimal(19,2)) AS 'Saldo',
CAST((SUM(T0.[FCCredit]-T0.[FCDebit])*T3.[Rate])-SUM(T0.[Credit]-T0.[Debit]) AS decimal(19,2)) AS 'Diferencia',
T0.[FCCurrency],
T3.[Rate],
ISNULL(T4.[CardType],'N') AS 'Type'
FROM  [dbo].[JDT1] T0  INNER  JOIN [dbo].[OJDT] T1  ON  T1.[TransId] = T0.[TransId]
INNER  JOIN [dbo].[OACT] T2  ON  T2.[AcctCode] = T0.[Account]
INNER JOIN [dbo].[ORTT] T3 ON T3.[Currency]=T0.[FCCurrency]
LEFT JOIN [dbo].[OCRD] T4 ON T4.[CardCode]=T0.[ShortName]
WHERE T0.[ShortName] >= (@StarBP) AND T0.[ShortName]<=(@EndBP) AND T0.[RefDate] <= (@RefDate) AND T3.[RateDate]=@RefDate AND T3.[Currency]=@Currency AND T0.[DueDate] >= (@F_DueDate)  AND  T0.[DueDate] <= (@T_DueDate) AND T2.[ActType]='N' AND T0.[Account]<>@SupplierGanancia AND T0.[Account]<>@SupplierGanancia AND T0.[Account]<>@CustomerGanancia AND T0.[Account]<>@CustomerPerdida GROUP BY T0.[Account], T0.[FCCurrency], T3.Rate, T4.CardType, T0.ShortName, T2.AcctName HAVING CAST((SUM(T0.[FCCredit]-T0.[FCDebit])*T3.[Rate])-SUM(T0.[Credit]-T0.[Debit])AS decimal(19,2))<>0
ORDER BY T0.[ShortName],T0.[Account]

END
END

GO
GO
/****** Object:  StoredProcedure [dbo].[FindAllAccount]    Script Date: 26/6/2020 1:51:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindAllAccountReal]

AS

BEGIN

SELECT AcctCode,AcctName FROM OACT WHERE ActType='N' ORDER BY  GroupMask, Levels, AcctCode 

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerateExchangeConversionAccount]

@RefDate datetime,
@AcctCode nvarchar(15)

AS

BEGIN

DECLARE @SysCurrency nvarchar(3)

SET @SysCurrency=(SELECT TOP 1 SysCurrncy from OADM)

SELECT
T0.[Account],
T0.[ShortName],
T2.[AcctName],
CAST((SUM(T0.[SYSCred]-T0.[SYSDeb]))AS decimal(19,2)) AS 'SaldoMS',
CAST((SUM(T0.[Credit]-T0.[Debit]))AS decimal(19,2)) AS 'Saldo',
CAST((SUM(T0.[Credit]-T0.[Debit]))/(T3.Rate)AS decimal(19,2)) AS 'SaldoConvertido',
CAST(((SUM(T0.[Credit]-T0.[Debit]))/(T3.Rate)-(SUM(T0.[SYSCred]-T0.[SYSDeb])))AS decimal(19,2)) AS 'Diferencia',
ISNULL(T4.[CardType],'N') AS 'Type'
FROM  [dbo].[JDT1] T0  INNER  JOIN [dbo].[OJDT] T1  ON  T1.[TransId] = T0.[TransId]
LEFT JOIN [dbo].[ORTT] T3 ON T3.[Currency]=@SysCurrency
LEFT  JOIN [dbo].[OACT] T2  ON  T2.[AcctCode] = T0.[Account]
LEFT JOIN [dbo].[OCRD] T4 ON T4.[CardCode]=T0.[ShortName]
WHERE T0.[ShortName] =@AcctCode AND T3.RateDate=(@RefDate) AND  T0.[RefDate] <= (@RefDate) AND  T2.[ActType]='N' AND T2.LocManTran='N' GROUP BY T0.Account, T0.ShortName, T2.AcctName, T3.Rate, T4.CardType HAVING CAST(((SUM(T0.[Credit]-T0.[Debit]))/t3.Rate)-(SUM(T0.[SYSCred]-T0.[SYSDeb])) AS decimal(19,2))<>0

END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerateExchangeConversionBP]

@RefDate datetime,
@StarBP nvarchar(15),
@EndBP nvarchar(15)


AS

BEGIN

DECLARE @SysCurrency nvarchar(3)

SET @SysCurrency=(SELECT TOP 1 SysCurrncy from OADM)

SELECT
T0.[Account],
T0.[ShortName],
T2.[AcctName],
CAST((SUM(T0.[SYSCred]-T0.[SYSDeb])) AS decimal(19,2)) AS 'SaldoMS',
CAST((SUM(T0.[Credit]-T0.[Debit])) AS decimal(19,2)) AS 'Saldo',
CAST((SUM(T0.[Credit]-T0.[Debit]))/(T3.Rate) AS decimal(19,2)) AS 'SaldoConvertido',
CAST(((SUM(T0.[Credit]-T0.[Debit]))/(T3.Rate)-(SUM(T0.[SYSCred]-T0.[SYSDeb]))) AS decimal(19,2)) AS 'Diferencia',
T4.[CardType] AS 'Type'
FROM  [dbo].[JDT1] T0  INNER  JOIN [dbo].[OJDT] T1  ON  T1.[TransId] = T0.[TransId]
INNER  JOIN [dbo].[OACT] T2  ON  T2.[AcctCode] = T0.[Account]
INNER JOIN [dbo].[ORTT] T3 ON T3.[Currency]=@SysCurrency
LEFT JOIN [dbo].[OCRD] T4 ON T4.[CardCode]=T0.[ShortName]
WHERE T0.[ShortName] >= (@StarBP) AND T0.[ShortName]<=(@EndBP) AND T0.[RefDate] <= (@RefDate) AND T3.[RateDate]=@RefDate AND T2.[ActType]='N' AND T2.LocManTran='Y' GROUP BY T0.[Account], T3.Rate, T4.CardType, T0.ShortName, T2.AcctName HAVING CAST(((SUM(T0.[Credit]-T0.[Debit]))/(T3.Rate)-(SUM(T0.[SYSCred]-T0.[SYSDeb]))) AS decimal(19,2))<>0
ORDER BY T0.[ShortName],T0.[Account]

END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerateInternalReconciliation]	


@SN nvarchar(15),
@T_RefDate datetime,
@F_RefDate datetime
AS

BEGIN
SELECT T0.[TransId],
T0.[Line_ID],
T0.[TransType],
CAST(CONVERT(nvarchar,T0.[RefDate],103)AS nvarchar) AS 'RefDate',
CAST(SUM(T0.[Debit]-T0.[Credit]) AS decimal(19,2)) AS 'Importe',
CAST(SUM(T0.[BalDueDeb]-T0.[BalDueCred]) AS decimal(19,2)) AS 'SaldoVencido',
CAST(SUM(T0.[BalDueDeb]-T0.[BalDueCred]) AS decimal(19,2)) AS 'ImporteReconciliar',
CAST(SUM(T0.BalFcDeb-T0.BalFcCred) AS decimal(19,2)) AS 'SaldoME',
CAST(SUM(T0.BalScDeb-T0.BalScCred) AS decimal(19,2)) AS 'SaldoMS',
T0.[LineMemo],
T0.[Account],
T0.[ShortName],
T0.[FCCurrency],
T0.[FinncPriod],
T0.[WTSum],
T0.[WTSumFC],
T0.[WTSumSC],
T1.[BaseRef]
FROM  [dbo].[JDT1] T0  INNER  JOIN [dbo].[OJDT] T1  ON  T1.[TransId] = T0.[TransId]					
WHERE (T0.[ShortName] = @SN) AND CONVERT(varchar, T0.[RefDate], 23) >=@F_RefDate  AND CONVERT(varchar, T0.[RefDate], 23) <=@T_RefDate  
GROUP BY T0.[TransId], T0.[TransType], T0.[RefDate], T0.[Account],T0.[FCCurrency], T0.[Line_ID], T0.[FinncPriod], T0.[ShortName], T0.[LineMemo], T1.[BaseRef],T0.[WTSum],T0.[WTSumFC],T0.[WTSumSC]
HAVING (SUM(T0.[BalDueDeb]-T0.[BalDueCred])<>0) 
ORDER BY T0.[RefDate],T0.[TransId]

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectReconNum]

AS

DECLARE @ReconNum int

BEGIN

SET @ReconNum =(SELECT (SELECT DISTINCT TOP 1 ReconNum FROM OITR ORDER BY ReconNum DESC) + 1 AS ReconNum)

IF(@ReconNum IS NULL)
BEGIN 
SELECT 1 AS ReconNum
END
ELSE
BEGIN
SELECT @ReconNum AS ReconNum
END
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertReconciliationInternal]

@IsCard char(1),
@ReconType nvarchar(2),
@ReconDate datetime,
@Total numeric(19,6),
@ReconCurr nvarchar(3),
@CancelAbs int,
@Canceled char(1),
@IsSystem char(1),
@InitObjTyp nvarchar(20),
@InitObjAbs int,
@CreateDate datetime,
@UserSign smallint,
@ReconJEId int,
@ObjType nvarchar(20)

AS

BEGIN

INSERT INTO OITR (IsCard,ReconType,ReconDate,Total,ReconCurr,CancelAbs,Canceled,IsSystem, InitObjTyp, InitObjAbs, CreateDate, UserSign, ReconJEId,ObjType) VALUES (@IsCard,@ReconType,@ReconDate,@Total,@ReconCurr,@CancelAbs,@Canceled,@IsSystem, @InitObjTyp, @InitObjAbs, @CreateDate, @UserSign, @ReconJEId,@ObjType)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertReconciliationInternalLines]

@ReconNum int,
@LineSeq int,
@TransId int,
@Account nvarchar(15),
@ShortName nvarchar(15),
@TransRowId int,
@SrcObjTyp nvarchar(20),
@SrcObjAbs int,
@ReconSum numeric (19,6),
@ReconSumFC numeric (19,6),
@ReconSumSC numeric (19,6),
@FrgnCurr nvarchar(3),
@SumMthCurr numeric (19,6),
@IsCredit char(1),
@WTSum numeric (19,6),
@WTSumFC numeric (19,6),
@WTSumSC numeric (19,6),
@ExpSum numeric (19,6),
@ExpSumFC numeric (19,6),
@ExpSumSC numeric (19,6)

AS

BEGIN

INSERT INTO ITR1 (ReconNum,LineSeq,TransId,Account,ShortName,TransRowId,SrcObjTyp,SrcObjAbs,ReconSum, ReconSumFC, ReconSumSC, FrgnCurr, SumMthCurr, IsCredit , WTSum, WTSumFC, WTSumSC, ExpSum, ExpSumFC,ExpSumSC) VALUES(@ReconNum,@LineSeq,@TransId,@Account,@ShortName,@TransRowId,@SrcObjTyp,@SrcObjAbs,@ReconSum,@ReconSumFC, @ReconSumSC, @FrgnCurr, @SumMthCurr, @IsCredit , @WTSum, @WTSumFC, @WTSumSC, @ExpSum, @ExpSumFC,@ExpSumSC)

END


GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ReconciliationInternalDiference]
(	
	@ReconNum int
)
RETURNS TABLE 
AS
RETURN
(

SELECT 
Account,
ShortName,

CASE 
			WHEN IsCredit='D' THEN ReconSum
			WHEN IsCredit='C' THEN ReconSum*(-1)
			END AS 'ReconSumTrans',
CASE 
			WHEN IsCredit='D' THEN ReconSumSC
			WHEN IsCredit='C' THEN ReconSumSC*(-1)
			END AS 'ReconSumTransSC'

FROM ITR1 WHERE ReconNum=@ReconNum
)

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ExecuteFuncionReconciliationInternalDiference]

@ReconNum int

AS

BEGIN

SELECT SUM(ReconSumTransSC) AS 'ReconSumTransSC' FROM [dbo].[ReconciliationInternalDiference](@ReconNum) GROUP BY ShortName

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetReconciliationInternalDiferenceLines]

@ReconNum int

AS

BEGIN
SELECT 
    Account, ShortName, SUM(ReconSumTrans) AS 'ReconSum', SUM(ReconSumTransSC) AS 'ReconSumSC'
FROM 
    dbo.ReconciliationTableTest(@ReconNum) GROUP BY Account,ShortName

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateJournalEntryLinesReconciliation]

@TransId int,
@Account nvarchar(15),
@ShortName nvarchar(15),
@TransRowId int,
@ReconSum numeric (19,6),
@ReconSumFC numeric (19,6),
@ReconSumSC numeric (19,6),
@IsCredit char(1),
@WTSum numeric (19,6),
@WTSumFC numeric (19,6),
@WTSumSC numeric (19,6)


AS

BEGIN

IF(@IsCredit='D')
BEGIN
UPDATE JDT1 SET Debit=Debit-@ReconSum, FCDebit=FCDebit-@ReconSumFC, SYSDeb=SYSDeb-@ReconSumSC WHERE Line_ID=@TransRowId AND TransId=@TransId AND Account=@Account AND ShortName=@ShortName
END

IF(@IsCredit='C')
BEGIN
UPDATE JDT1 SET Credit=Credit-@ReconSum, FCCredit=FCCredit-@ReconSumFC, SYSCred=SYSCred-@ReconSumSC WHERE Line_ID=@TransRowId AND TransId=@TransId AND Account=@Account AND ShortName=@ShortName
END

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerateReconciliacionesAnteriores]

@DesdeSN nvarchar(15),
@HastaSN nvarchar(15),
@F_ReconDate datetime,
@T_ReconDate datetime,
@F_NroRecon int,
@T_NroRecon int

AS

BEGIN


SELECT
T0.[ReconNum],
T0.[IsCard],
T0.[Canceled],
T0.[IsSystem],
T0.[InitObjAbs],
T0.[InitObjTyp],
T0.[ObjType],
T0.[Total],
T0.[ReconType],
CAST(CONVERT(nvarchar,T0.[ReconDate],103)AS nvarchar) AS 'ReconDate',
CAST(CONVERT(nvarchar,T0.[CreateDate],103)AS nvarchar) AS 'CreateDate',
T0.[CancelAbs],
T0.[ReconJEId],
T0.[ReconCurr]
FROM  [dbo].[OITR] T0
WHERE T0.[ReconDate]>= (@F_ReconDate)  AND  T0.[ReconDate] <= (@T_ReconDate) AND T0.[ReconNum] IN (
SELECT
T0.[ReconNum]

FROM  [dbo].[ITR1] T0
WHERE T0.[ReconNum] >= (@F_NroRecon) AND T0.[ReconNum]<=(@T_NroRecon) AND T0.[ShortName] >= (@DesdeSN)  AND  T0.[ShortName] <= (@HastaSN)
GROUP BY T0.[ReconNum]

)
ORDER BY T0.[ReconNum]


END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindReconciliacionesAnterioresLines]

@ReconNum int

AS

BEGIN

SELECT 
T0.ReconNum,
T0.LineSeq,
T0.SrcObjTyp,
T0.ShortName,
T0.TransId,
T0.TransRowId,
T0.Account,
T0.SrcObjAbs,
T0.FrgnCurr,
T1.ReconCurr,
CASE 
			WHEN T0.IsCredit='D' THEN T0.ReconSum
			WHEN T0.IsCredit='C' THEN T0.ReconSum*(-1)
			END AS 'ReconSum',
CASE 
			WHEN T0.IsCredit='D' THEN T0.ReconSumSC
			WHEN T0.IsCredit='C' THEN T0.ReconSumSC*(-1)
			END AS 'ReconSumSC',		
CASE 
			WHEN T0.IsCredit='D' THEN T0.ReconSumFC
			WHEN T0.IsCredit='C' THEN T0.ReconSumFC*(-1)
			END AS 'ReconSumFC',
T0.WTSum,
T0.WTSumFC,
T0.WTSumSC
FROM ITR1 T0 INNER JOIN OITR T1 
ON T0.[ReconNum]=T1.[ReconNum]


WHERE T0.ReconNum=@ReconNum

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindJournalEntrySpecific]

@TransId int

AS

BEGIN

SELECT * FROM OJDT WHERE TransId = @TransId
 
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateItem]    Script Date: 8/7/2020 1:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateDeterminacionCuentasMayor]

@LinkAct_1 nvarchar(15),
@LinkAct_2 nvarchar(15),
@LinkAct_3 nvarchar(15),
@LinkAct_4 nvarchar(15),
@LinkAct_5 nvarchar(15),
@LinkAct_6 nvarchar(15),
@LinkAct_7 nvarchar(15)

AS

BEGIN

UPDATE ODCM SET LinkAct_1=@LinkAct_1, LinkAct_2=@LinkAct_2, LinkAct_3=@LinkAct_3, LinkAct_4=@LinkAct_4, LinkAct_5=@LinkAct_5, LinkAct_6=@LinkAct_6, LinkAct_7=@LinkAct_7

END

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[O_IDA1] 
(	
)
RETURNS TABLE

 
AS
RETURN 
(

			SELECT  DocEntry, ObjType, VatPrcnt,VatGroup,WTLiable FROM PCH1 K2 (NOLOCK) --WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				UNION ALL
			SELECT  DocEntry, ObjType, VatPrcnt,VatGroup,WTLiable  FROM RPC1 K2 (NOLOCK)--WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType
				UNION ALL
			SELECT  DocEntry, ObjType, VatPrcnt,VatGroup,WTLiable  FROM PCH3 K2 (NOLOCK)			
				UNION ALL
			SELECT  DocEntry, ObjType, VatPrcnt,VatGroup,WTLiable  FROM RPC3 K2 (NOLOCK)
			
)
GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[O_IDAR] 
(	
)

RETURNS TABLE 


AS
RETURN 
(

			SELECT 
			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'AlicuotaGasto'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'CodigoAlicuotaGasto'
			,
			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'AlicuotaGeneral'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'CodigoAlicuotaGeneral'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'AlicuotaReducida'
			,
			
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'CodigoAlicuotaReducida'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'AlicuotaAdicional'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaAdicional'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaExento'
			,
			
			H2.U_IDA_TipoPersona AS 'TipoPersona',
			ISNULL(CASE WHEN DocSubType='--' THEN NumAtCard END,'') AS 'NF', 
			ISNULL(CASE WHEN DocSubType<>'--' THEN NumAtCard END,'') AS 'ND', 
			'' AS 'NC',
			'' AS 'FAFE',ISNULL(K2.U_IDA_Serie,'') + ISNULL(K2.U_IDA_NumControl,'') AS 'NroControl',K2.U_IDA_TipoTrans AS 'TipoTran',
			ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',ISNULL(K2.DocDate,'') AS 'FechaComp' ,
			ISNULL(K2.U_IDA_NumFile,'') AS 'NroImportacion', ISNULL(K2.U_IDA_NumFile,'') AS 'ExpedienteImp',
			ISNULL(U_IDA_RetenTercero,'N') AS 'RetencionTercero',
			ISNULL(U_IDA_Tercero,'') AS 'Tercero',
			ISNULL(U_IDA_TipoRet,'') AS 'TipoRet',
			ISNULL(K2.U_IDA_CompMunicipal,'') AS 'CompMunicipal',K2.* FROM OPCH K2 (NOLOCK) ,OFPR H1 (NOLOCK)  , OCRD H2 (NOLOCK)  WHERE --H1.Name=@Periodo
		--	AND 
			 K2.DocDate >= H1.F_RefDate AND K2.DocDate <= H1.T_RefDate AND K2.CardCode=H2.CardCode
			 --, [@BKV_RECEIPT] K3 WHERE K2.DocEntry= --K2.DocEntry=@DocEntry AND ObjType=@ObjType 
				
				UNION ALL
			SELECT 
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'AlicuotaGasto'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GASTO') -- Rate=12  )-- U_IDA_Alicuota='GASTO') 
 AS 'CodigoAlicuotaGasto'
			,
			
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'AlicuotaGeneral'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='GENERAL') -- Rate=12  )-- U_IDA_Alicuota='GENERAL') 
 AS 'CodigoAlicuotaGeneral'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'AlicuotaReducida'
			,
			
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='REDUCIDA')-- Rate = 8 )--U_IDA_Alicuota='REDUCIDA') 
 AS 'CodigoAlicuotaReducida'
			,
			(SELECT Rate FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'AlicuotaAdicional'
			,
			(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='ADICIONAL')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaAdicional'
			,
				(SELECT Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO')--Rate=20 )--U_IDA_Alicuota='ADICIONAL') 
 AS 'CodigoAlicuotaExento'
			,
			
			H2.U_IDA_TipoPersona AS 'TipoPersona',
			'' AS 'NF', '' AS 'ND',  NumAtCard AS 'NC',K2.U_IDA_Fafe AS 'FAFE',
			ISNULL(K2.U_IDA_Serie,'') + ISNULL(K2.U_IDA_NumControl,'') AS 'NroControl', U_IDA_TipoTrans  AS 'TipoTran', 
			ISNULL(K2.U_IDA_CompIVA,'') AS 'NroComprobante',ISNULL(K2.DocDate,'') 
			AS 'FechaComp' ,
			ISNULL(K2.U_IDA_NumFile,'') AS 'NroImportacion', ISNULL(K2.U_IDA_NumFile,'') AS 'ExpedienteImp',
			ISNULL(U_IDA_RetenTercero,'N') AS 'RetencionTercero',
			ISNULL(U_IDA_Tercero,'') AS 'Tercero',
			ISNULL(U_IDA_TipoRet,'') AS 'TipoRet',
			ISNULL(K2.U_IDA_CompMunicipal,'') AS 'CompMunicipal',K2.* FROM ORPC K2 (NOLOCK),OFPR H1 (NOLOCK) , OCRD H2 (NOLOCK) WHERE --H1.Name=@Periodo 
			--AND 
			K2.DocDate >= H1.F_RefDate AND K2.DocDate <= H1.T_RefDate AND K2.CardCode=H2.CardCode
			--WHERE H1.Name=@Periodo
			--WHERE K2.DocEntry=@DocEntry AND ObjType=@ObjType

)


GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenerarComprobanteIVA] 
	-- Add the parameters for the stored procedure here
 @Card1 AS VARCHAR(100),
 @Card2 AS VARCHAR(100),
 @Quincena AS VARCHAR(100),
 @Mes AS VARCHAR(100),
 @Ano AS VARCHAR(100),
 @Tipo AS VARCHAR(100)


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


DECLARE @Siguiente AS BIGINT
DECLARE @Row AS BIGINT
DECLARE @NroComprobante AS BIGINT
DECLARE @NroComprobanteIni AS BIGINT
DECLARE @Nro AS BIGINT

IF (@Tipo<>'03')

BEGIN

IF EXISTS (SELECT * FROM sysobjects WHERE name='COMP_IVA_TEMP') 
BEGIN
DROP TABLE COMP_IVA_TEMP
END

SET @NroComprobante=0

--- INSERTAR COMPROBANTES EN LA TABLA DE COMPROBANTES---  dbo.[@IDA_COMPROBANTES]
SELECT @Siguiente=U_IDA_Siguiente FROM dbo.[@IDA_NRO_COMPROBANTE] WHERE U_IDA_TipoSerie='IVA' AND U_IDA_Activo='Y'

--INSERT INTO dbo.[@IDA_COMPROBANTES]

SELECT --(CONVERT(VARCHAR,RT2.U_IDA_DocEntry)+CONVERT(VARCHAR,RT2.U_IDA_ObjType)) + RT2.U_IDA_Row 
 CONVERT(BIGINT,ISNULL((SELECT MAX(CONVERT(BIGINT,Code)) FROM dbo.[@IDA_COMPROBANTES]),0))+ CONVERT(BIGINT,ROW_NUMBER() OVER ( ORDER BY RT2.U_IDA_DocEntry))  AS 'Code'
,
--(CONVERT(VARCHAR,RT2.U_IDA_DocEntry)+CONVERT(VARCHAR,RT2.U_IDA_ObjType)) + RT2.U_IDA_Row 
 CONVERT(BIGINT,ISNULL((SELECT MAX(CONVERT(BIGINT,Code)) FROM dbo.[@IDA_COMPROBANTES]),0))+ CONVERT(BIGINT,ROW_NUMBER() OVER ( ORDER BY RT2.U_IDA_DocEntry))   AS 'Name'
,RT2.U_IDA_NroControl,RT2.U_IDA_FechaFact
,RT2.U_IDA_ObjType,RT2.U_IDA_DocEntry,RT2.U_IDA_Alicuota,RT2.U_IDA_IVA,
RT2.U_IDA_BaseImp,U_IDA_Retencion,((U_IDA_Total) + (CASE WHEN RT2.U_IDA_Row=1 THEN dbo.IDA_BaseImponible(RT2.U_IDA_ObjType,RT2.U_IDA_DocEntry, 0,(SELECT TOP 1 Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO'),'C') ELSE 0 END )) AS  'U_IDA_Total'--,U_IDA_Total
 ,CASE WHEN RT2.U_IDA_Row=1 THEN dbo.IDA_BaseImponible(RT2.U_IDA_ObjType,RT2.U_IDA_DocEntry, 0,(SELECT TOP 1 Code FROM OSTC (NOLOCK) WHERE 
[ValidForAP] = 'Y' and [Lock] = 'N' AND U_IDA_Alicuota='EXENTO'),'C') ELSE 0 END AS 'U_IDA_Exento'--'Exento B' 
,
U_IDA_Fafe,U_IDA_Factura,U_IDA_Credito,U_IDA_Debito,U_IDA_TipoTran,U_IDA_CardCode,
U_IDA_CardName,U_IDA_Agente,U_IDA_NroComp,U_IDA_LicTradNum,U_IDA_TaxIdNo,U_IDA_FechaComp,U_IDA_Row
,'01' AS 'U_IDA_Status', U_IDA_PrcntRet, U_IDA_CompanyAddress,U_IDA_Address,U_IDA_DocSubType,  
(CONVERT(VARCHAR,@Ano)+'-' + CONVERT(VARCHAR,@Mes)) AS 'U_IDA_Periodo', @Quincena AS 'U_IDA_Quincena'
INTO COMP_IVA_TEMP FROM 
(SELECT CONVERT(VARCHAR,ROW_NUMBER() OVER ( PARTITION by RT.U_IDA_DocEntry ORDER BY RT.U_IDA_DocEntry)) AS 'U_IDA_Row',* FROM (

SELECT  

DISTINCT
CONVERT(VARCHAR,YEAR(GETDATE()))+RIGHT('0'+CONVERT(VARCHAR,MONTH(GETDATE())),2)+
+RIGHT('00000000'+CONVERT(VARCHAR,(CASE WHEN @Tipo='01' THEN 
	CONVERT(VARCHAR, DENSE_RANK() over (ORDER BY T0.CardCode) + @Siguiente - 1 )
ELSE
	CONVERT(VARCHAR, DENSE_RANK() over (ORDER BY T0.CardCode, T0.DocEntry, T0.ObjType, T0.DocSubType) + @Siguiente - 1 )
END )),8) --+ @Siguiente - 1 
 AS 'U_IDA_NroComp',
--CONVERT(VARCHAR,GETDATE(),112) 
T0.DocDate AS 'U_IDA_FechaComp',
T0.ObjType AS 'U_IDA_ObjType' ,
T0.DocSubType AS 'U_IDA_DocSubType',
T5.CompnyName as 'U_IDA_Agente', 
T5.TaxIdNum AS 'U_IDA_TaxIdNo',
T0.NF AS 'U_IDA_Factura',
T0.ND as 'U_IDA_Debito' ,
T0.NC as 'U_IDA_Credito',
ISNULL(T5.CompnyAddr,'') AS 'U_IDA_CompanyAddress',
T0.FAFE as 'U_IDA_Fafe',
T0.DocEntry AS 'U_IDA_DocEntry',
--T0.DocDate,
--T0.CardName as 'Sujeto Retenido',
CASE WHEN T0.RetencionTercero='Y' THEN CASE WHEN T0.TipoRet='IVA' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName=T0.Tercero AND CardType = 'S') WHEN T0.TipoRet='Todas' THEN (SELECT TOP 1 LicTradNum FROM OCRD WHERE CardName=T0.Tercero AND CardType = 'S') ELSE T0.LicTradNum  END  ELSE T0.LicTradNum  END as 'U_IDA_LicTradNum',
CASE WHEN T0.RetencionTercero='Y' THEN [dbo].[IDA_DireccionTercero](T0.Tercero) ELSE ISNULL(T0.Address,'') END AS 'U_IDA_Address',
T0.CardCode AS 'U_IDA_CardCode',
CASE WHEN T0.RetencionTercero='Y' THEN CASE WHEN T0.TipoRet='IVA' THEN T0.Tercero  WHEN T0.TipoRet='Todas' THEN T0.Tercero ELSE T0.CardName END ELSE T0.CardName END AS 'U_IDA_CardName',
T1.VatPrcnt AS 'U_IDA_Alicuota',
T1.TaxCode AS 'U_IDA_CodigoAlicuota',
T0.TaxDate AS 'U_IDA_FechaFact',
T0.NroControl  AS 'U_IDA_NroControl',
T0.U_IDA_TipoTrans AS 'U_IDA_TipoTran',
--T2.WTAmnt*T1.VatPrcnt/dbo.IDA_PrcntTotal(T0.ObjType,T0.DocEntry) AS 'Retencion',
--(((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T1.VatPrcnt,'C') *T1.VatPrcnt)/100)  * T4.PrctBsAmnt )/100 AS 'U_IDA_Retencion',
(((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T1.VatPrcnt,T1.TaxCode,'C') *T1.VatPrcnt)/100)  * T4.Rate )/100 AS 'U_IDA_Retencion',
((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T1.VatPrcnt,T1.TaxCode,'C') *T1.VatPrcnt)/100) AS 'U_IDA_IVA',
--T4.PrctBsAmnt AS 'U_IDA_PrcntRet',
T4.Rate AS 'U_IDA_PrcntRet',
dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T1.VatPrcnt,T1.TaxCode,'C') AS 'U_IDA_BaseImp',
--dbo.IDA_PrcntTotal(T0.ObjType,T0.DocEntry) as 'r',
--t1.VatPrcnt,
--dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, 0,'C') AS 'Exento A',

dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T1.VatPrcnt,T1.TaxCode,'C')+ 
((dbo.IDA_BaseImponible(T0.ObjType,T0.DocEntry, T1.VatPrcnt,T1.TaxCode,'C') *T1.VatPrcnt)/100) 
 AS 'U_IDA_Total'  -- base imponible + iva + excento
FROM 
dbo.O_IDAR() T0,
dbo.O_IDA1() T1, 
dbo.O_IDA5() T2, 
OWHT T4, 
OADM T5
WHERE 
T0.DocEntry=T1.DocEntry  AND 
T0.DocEntry=T2.AbsEntry  AND
T0.ObjType = T1.ObjType AND
T0.ObjType = T2.ObjType AND
T2.BaseType='V' AND 
T1.VatPrcnt>0 AND T0.TipoTran<>'05' AND --T0.U_IDA_TipoTrans<>'05' AND
--T0.DocNum=17089 and
dbo.IDA_Quincena(@Quincena,@Ano,@Mes,T0.DocDate)='TRUE' AND
T4.WTCode=T2.WTCode AND 
T4.U_IDA_TipoRetencion='IVA' 
AND 
(
	(T0.CardCode >= @Card1 OR @Card1='') AND 
	(T0.CardCode <= @Card2 OR @Card2='')
)
--AND (T0.U_IDA_CompIVA IS NULL OR T0.U_IDA_CompIVA='')
AND (T0.NroComprobante IS NULL OR T0.NroComprobante='')
) RT
) RT2

ORDER BY CONVERT(BIGINT,RT2.U_IDA_DocEntry)--RT2.U_IDA_Row)--RT2.Row)

INSERT INTO dbo.[@IDA_COMPROBANTES]  
SELECT * FROM COMP_IVA_TEMP
----- FIN INSERTAR COMPROBANTES-----

----- OBTENER COMPROBANTES DESDE - HASTA

SELECT @NroComprobante=MAX(RT2.Nro),
 @NroComprobanteIni =MIN(RT2.Nro)
FROM (

SELECT U_IDA_NroComp AS 'Nro' FROM COMP_IVA_TEMP
) 
 RT2
----   ASIGNAR COMPROBANTE FACTURA

UPDATE OPCH SET U_IDA_CompIVA= RT2.Nro
, U_IDA_FechaComp=RT2.U_IDA_FechaComp
FROM 
OPCH,
(
SELECT U_IDA_FechaComp, U_IDA_DocEntry AS 'DocEntry' , U_IDA_DocSubType,
U_IDA_NroComp AS 'Nro' FROM COMP_IVA_TEMP WHERE U_IDA_ObjType='18'
) RT2
WHERE OPCH.DocEntry=RT2.DocEntry AND OPCH.DocSubtype=RT2.U_IDA_DocSubType

------ FIN ASIGNAR COMPROBANTE FACTURA


---- ASIGNAR COMPROBANTE  NC

UPDATE ORPC SET U_IDA_CompIVA= RT2.Nro
, U_IDA_FechaComp=RT2.U_IDA_FechaComp
FROM 
ORPC,
(
SELECT U_IDA_FechaComp, U_IDA_DocEntry AS 'DocEntry' , 
U_IDA_NroComp AS 'Nro' FROM COMP_IVA_TEMP WHERE U_IDA_ObjType='19'
) RT2
WHERE ORPC.DocEntry=RT2.DocEntry 

------ FIN ASIGNAR COMPROBANTE NOTA DE CREDITO



--- ACTUALIZAR NRO DE COMPROBANTE TABLA [@IDA_NRO_COMPROBANTE]


IF (@NroComprobante<>0)
BEGIN
DECLARE @NroSig AS BIGINT
SET @NroSig=CONVERT(BIGINT,RIGHT(@NroComprobante,8))
UPDATE [@IDA_NRO_COMPROBANTE] SET U_IDA_Siguiente=@NroSig + 1 WHERE U_IDA_TipoSerie='IVA' AND U_IDA_Activo='Y'


SELECT 'Se Asignaron los Comprobantes Desde: '+ CONVERT(VARCHAR,@NroComprobanteIni) 
+ ' Hasta: ' + CONVERT(VARCHAR,@NroComprobante)
--------------------------------------------------------------   
END
 ELSE
 BEGIN
 SELECT 'No existen documentos para los parametros seleccionados'
 END


END
ELSE
BEGIN
 SELECT 'Los comprobantes de retencion de IVA solo pueden generar por Operacion o Quincenal'
END

END
GO

GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IDA_AnularComprobanteIVA] 
 @Desde AS VARCHAR(100),
 @Hasta AS VARCHAR(100)


AS
BEGIN
	SET NOCOUNT ON;

UPDATE [@IDA_COMPROBANTES] SET U_IDA_Status='02'  
WHERE U_IDA_NroComp>=@Desde
AND U_IDA_NroComp<=@Hasta AND U_IDA_Status='01' 

UPDATE OPCH SET U_IDA_CompIVA='', U_IDA_FechaComp='' WHERE U_IDA_CompIVA>=@Desde 
AND U_IDA_CompIVA<=@Hasta

UPDATE ORPC SET U_IDA_CompIVA='', U_IDA_FechaComp='' WHERE U_IDA_CompIVA>=@Desde 
AND U_IDA_CompIVA<=@Hasta

SELECT 'Fueron anulados los comprobandes desde : ' +@Desde + ' hasta: ' + @Hasta
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateCodigosFiscalesLines]

@STCCode nvarchar(8),
@LineId int,
@STACode nvarchar(8), 
@EfctivRate numeric(19,6)

AS

BEGIN

UPDATE STC1 SET STCCode=@STCCode, Line_ID=@LineId, STACode=@STACode, EfctivRate=@EfctivRate WHERE STCCode=@STCCode AND Line_ID=@LineId

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindCodigosFiscalesLines]

@Code nvarchar(8)

AS

BEGIN

DECLARE @STACode nvarchar(8)

SET @STACode=(SELECT TOP 1 STACode FROM STC1 WHERE STCCode=@Code)

SELECT Code, Name, Rate, PurchTax, SalesTax FROM OSTA WHERE Code=@STACode
 
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertCodigosFiscalesLines]

@STCCode nvarchar(8),
@LineId int,
@STACode nvarchar(8), 
@EfctivRate numeric(19,6)

AS

BEGIN

INSERT INTO STC1 (STCCode,Line_ID,STACode,EfctivRate) VALUES (@STCCode,@LineId,@STACode,@EfctivRate)

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindClasesImpuestos]

AS

BEGIN

SELECT Code,Name, Rate, PurchTax,SalesTax FROM OSTA

END