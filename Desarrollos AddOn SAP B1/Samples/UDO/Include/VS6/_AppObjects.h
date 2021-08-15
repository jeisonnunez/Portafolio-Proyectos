#ifndef _APPOBJECTS_H_
	#define _APPOBJECTS_H_

/****************************		Constants		*********************************/
/***************************************/
/****	Object Numbers definitions	****/
//{{OWIZ_DEFINE(LAST_USED_OBJ)
#define		LAST_USED_OBJ		222
//}}OWIZ_DEFINE

//{{OWIZ_DEFINE(APA_LAST_USED_OBJ)
#define		APA_LAST_USED_OBJ	240
//}}OWIZ_DEFINE

//{{OWIZ_DEFINE(CEE_LAST_USED_OBJ)
#define		CEE_LAST_USED_OBJ	270
//}}OWIZ_DEFINE

/*************************************************************/
/* Object Type Constants (Entries to the Objects Functions Grid) */
//Non Objects
#define		INV5V	-1937L	// User Dag INV5V - Withholding tax lines
#define		SEWU	-14L	// Early Watch Alert Service - User
#define		EWAX	-13L	// Early Watch Alert Service - Extended 
#define		RTYP	-12L	// Document Type List
#define		RDFL	-11L	// Document Standards
#define		CCRC	-10L	// Create Company
#define		OPB		-9L		// Open Balance
#define		BTX		-8L		// Batch auxiliary Object
#define		SRX		-7L		// Serial auxiliary Object
#define		SQR		-6L
#define		PRM		-5L
#define		CFL		-4L
#define		GUO		-3L
#define		TMP		-2L		// Temporary Object
#define		NOB		-1L		// Not an Object

#define		ACT		1L		// Accounts
#define		CRD		2L		// Cards
#define		DSC		3L		// Discount Codes
#define		ITM		4L		// Items
#define		VTG		5L		// Vat groups#
#define		PLN		6L		// Price List Names
#define		SPP		7L		// Special Prices
#define		ITG		8L		// Item Groups
#define		RTM		9L		// Rates matching
#define		CRG		10L		// Card payment groups
#define		CPR		11L		// Contact persons

#define		USR		12L		// Users

#define		INV		13L		// Invoices
#define		RIN		14L		// Revert Invoices
#define		DLN		15L		// Delivery Notes
#define		RDN		16L		// Revert Delivery Notes
#define		RDR		17L		// Orders
#define		PCH		18L		// Purchases
#define		RPC		19L		// Revert Purchases
#define		PDN		20L		// Purchase Delivery Notes
#define		RPD		21L		// Revert Purchase Delivery Notes
#define		POR		22L		// Purchase Orders
#define		QUT		23L		// Quotations
#define		RCT		24L		// Receipts
#define		DPS		25L		// Deposits

#define		MTH		26L		// Match History
#define		CHH		27L		// Checks History
#define		BTF		28L		// Journal Batches
#define		BTD		29L		// Journal Batches Directory
#define		JDT		30L		// Journal Transactions

#define		ITW		31L		// Item - Warehouse accumulators
#define		ADP		32L		// Printing Administration

#define		CLG		33L		// Contact Log
#define		RCR		34L		// Recurring Transactions
#define		NNM		35L		// Objects Next Serial Number
#define		CRC		36L		// Credit Cards
#define		CRN		37L		// Currency Codes
#define		IDX		38L		// Index (Madad)
#define		ADM		39L		// Administration
#define		CTG		40L		// Credit Terms
#define		PRF		41L		// Form Preferences
#define		BNK		42L		// Bank pages

#define		MRC		43L		// Firm groups (Marca)

#define		CQG		44L		// Card query groups
#define		TRC		45L		// Ttansaction codes
#define		VPM		46L		// Payment to vendor
#define		SRL		47L		// Serial numbers

#define		ALC		48L		// Import expenses
#define		SHP		49L		// Shipment types 
#define		LGT		50L		// Length units
#define		WGT		51L		// Weight units

#define		ITB		52L		// Item groups
#define		SLP		53L		// Sales person
#define		FLT		54L		// Reports filter
#define		TRT		55L		// Transaction types
#define		ARG		56L		// Arancel (custom) groups
#define		CHO		57L		// Checks paid to vendors (Outgoing checks)
#define		INM		58L		// Inventory match
#define		IGN		59L		// Inventory General Entry
#define		IGE		60L		// Inventory General Exit

#define		PRC		61L		// Profit Center
#define		OCR		62L		// Overhead cost rate
#define		PRJ		63L		// Project

#define		WHS		64L		// Warehouses Codes & Names
#define		COG		65L		// Commission groups
#define		ITT		66L		// Item Tree links
#define		WTR		67L		// Warehouses Transfers
#define		WKO		68L		// Work Orders

#define		IPF		69L		// Import file

#define		CRP		70L		// Credit pay systems
#define		CDT		71L		// Credit Due Terms
#define		CRH		72L		// Credit History
#define		SCN		73L		// Substitutional catalog num
#define		CRV		74L		// Credit Payments
#define		RTT		75L		// Index & currency rates
#define		DPT		76L		// Deposit Temporary
#define		BGT		77L		// Budget
#define		BGD		78L		// Budget _STR_system
#define		RCN		79L		// Retailer chains
#define		ALT		80L		// Alert templates
#define		ALR		81L		// Alerts pool
#define		AIB		82L		// Alerts In box
#define		AOB		83L		// Alerts Out box
#define		CLS		84L		// Contact log subjects
#define		SPG		85L		// Special prices for groups
#define		SPRG	86L		// Run externals applications
#define		MLS		87L		// Mailing lists
#define		ENT		88L		// Panama - enterada
#define		SAL		89L		// Panama - salida
#define		TRA		90L		// Panama - traspaso
#define		BGS		91L		// Budget Scenario
#define		IRT		92L		// Interest Rates
#define		UDG		93L		// User defaults groups
#define		SRI		94L		// Items serial numbers
#define		FRT		95L		// Finance Reports Template
#define		FRC		96L		// Finance Reports Categories

#define		OPR		97L		// 
#define		OIN		98L		// 
#define		OIR		99L		// 
#define		OSR		100L		// 
#define		OST		101L		// 
#define		OFR		102L		// 

#define		CLT		103L	// Contact log types
#define		CLO		104L	// Contact log locations
#define		ISR		105L		// Internet Service Request
#define		IBT		106L		// Item batch numbers
#define		ALI		107L		// Alternative Items

#define		PRT		108L		// Partners
#define		CMT		109L		// Competitors
#define		UVV		110L		// User valid values
#define		FPR		111L		// Finance period
#define		DRF		112L		// Document draft
#define		SRD		113L		// Internal manage of SRI and IBT

#define		UDC		114L		// User display categories

#define		PVL		115L		// Pelecard Vendors List
#define		DDT		116L		// Deduction at source - Terraces
#define		DDG		117L		// Deduction at source - Groups

#define		UBR		118L		// Users - Branch
#define		UDP		119L		// Users - Departments

#define		WST		120L		// Workflow - Steps
#define		WTM		121L		// Workflow - Templates
#define		WDD		122L		// Workflow - Documants

#define		CHD		123L		// Check out drafts
#define		CINF	124L		// Company info
#define		EXD		125L		// Expenses definition

#define		STA		126L		// Sales Tax Authorities
#define		STT		127L		// Sales Tax Authorities Type	
#define		STC		128L		// Sales Tax Code	

#define		CRY		129L		// Countries
#define		CST		130L		// States
#define		ADF		131L		// Address format
#define		CIN		132L		// Correction Invoice

#define		CDC		133L		//Cash Discount
#define		QCN		134L		// User Querry Category Names

#define		IND		135L		//VAT Indicator EC
#define		DMW		136L		//Data Migrate Wizard Pacages
#define		CSTN	137L		//Station Id

#define		IDC		138L		// Indicator
#define		GSP		139L		// Goods Shipment

#define		PDF		140L		//payment draft
#define		QWZ		141L		// Query Wizard

#define		ASG		142L		// Account Segmantation
#define		ASC		143L		// Account Segmantation Categories
#define		LCT		144L		// Location
#define		TNN		145L		// 1099
#define		CYC		146L		// Cycle
#define		PYM		147L		// Payment Method
#define		TOB		148L		// 1099 Begining Balances
#define		RIT		149L		// Dunning Interest Rate
#define		BPP		150L		// BP Priorities
#define		DUN		151L		// 
#define		UFD		152L		// User Fields - Descr.
#define		UTB		153L		// User Tables
#define		CUMI	154L		// User Menu
#define		PYD		155L		// Payment run
#define		PKL		156L		// 
#define		PWZ		157L		// Payment Wizard
		 
#define		PEX		158L		// Payment Results Table
#define		PYB		159L		// Payment Block
#define		UQR		160L		// Queries
#define		CBI		161L		// Central bank ind

// START - Polish Cluster objects
#define		MRV		162L		// Material revaluation					[was: SST]
#define		CPI		163L		// Correction A/P Invoice				[was: SLT]
#define		CPV		164L		// Correction A/P Invoice Reversal		[was: CTR]
#define		CSI		165L		// Correction A/R Invoice				[was: SCL]
#define		CSV		166L		// Correction A/R Invoice Reversal		[was: SCO]
// END   - Polish Cluster objects

#define		SCS		167L		// Service Call Status
#define		SCT		168L		// Service Call Type
#define		SCP		169L		// Service Call Problem Type
#define		CTT		170L		// Contract Template
#define		HEM		171L		// Employees
#define		HTY		172L		// Employee Types
#define		HST		173L		// Employee Status
#define		HTR		174L		// Termination reason
#define		HED		175L		// Education Types
#define		INS		176L		// Install Base
#define		AGP		177L		// Agent Person
#define		WHT		178L		// Withholding Tax
#define		RFL		179L		// 347, 349 and WT reports previously displayed 
#define		VTR		180L		// 
#define		BOE		181L		// Boe for Payment
#define		BOT		182L		// Bill Of Exchang Transaction
#define		FRM		183L		// File Format
#define		PID		184L		// Period Indicator
#define		DOR		185L		// Doubtful Receivables
#define     HLD		186L		// Holiday Table
#define		CRB		187L		// Bessiness Partner - Bank accounts
#define		SST		188L		// Service Call Solution Status			[was: 162]
#define		SLT		189L		// Service Call Solutions				[was: 163]
#define		CTR		190L		// Service Contracts					[was: 164]
#define		SCL		191L		// Service Call							[was: 165]
#define		SCO		192L		// Service call origin					[was: 166]
#define		UKD		193L		// User Keys Descr
#define		QUE		194L		// Queues
#define		IWZ		195L		// Inflation Wizard
#define		DUT		196L		// Dunning Terms
#define		DWZ		197L		// Dunning Wizard
#define		FCT		198L		// Sales Forecast
#define		MSN		199L		// MRP Scenario
#define		TER		200L		// Territories
#define		OND		201L		// Industries
#define		WOR		202L		// Advanced Work Order
#define		DPI		203L		// Down Payment Incoming
#define		DPO		204L		// Down Payment Outgoing
#define		PKG		205L		// Packages Types
#define		UDO		206L		// Packages Types
#define     DOW     207L        // Data Ownership - Objects
#define     DOX     208L        // Data Ownership - Objects
#define		ADN		209L		// AddOns Admin
#define		HPS		210L		// Employee Position
#define		HTM		211L		// Teams
#define		ORL		212L		// Relationships
#define		RCM		213L		// Order Recommendations
#define		UPT		214L		// User Permission Tree
#define		PDT		215L		// Predefined Text
#define		BOX		216L		// Tax Declaration Box's
#define		CLA		217L		// Activity Status
#define		CHF		218L		// Choose From List Settings
#define		CSHS	219L		// Shamia Search Object
#define		ACP		220L		// Period Category
#define		ATC		221L		// Attachments
#define		GFL		222L		// Grid Filter
#define		LNG		223L		// Languages
#define		MLT		224L		// Multi Language Translation
#define		APA3	225L		// For Tidhar's use
#define		APA4	226L		// For Tidhar's use
#define		APA5	227L		// For Tidhar's use
#define		SDIS	229L		// System Dynamic Strings
#define		SVR		230L		// Saved Reconciliations
#define		DSC1	231L		// House Bank Account
#define		RDOC	232L		// Report Layout Representation
#define		DGP		233L		// Document Generation Parameter Sets
#define		MHD 	234L		// Message Header
//{{OWIZ_INSERT_LOCATION(OBJ_DEFINE)}}
// DO NOT DELETE! Object Wizard will insert additional definitions immediately before the previous line.

/***************************************/
#define		NO_LIMIT			0x00
#define		CREDIT_LIMIT		0x01
#define		OBLIGO_LIMIT		0x02
#define		ADD_DLN_BALANCE		0x40
/***************************************/
#define		ORDERS_LIMIT		0x01
#define		DELIVERY_LIMIT		0x02
#define		SALES_LIMIT			0x40

/****************************		Extended Commands		*********************************/
#define		ooExAutoMode			0x00000001
#define		ooExJoinReport			0x00000002
#define		ooExExpandTransLine		0x00000004
#define		ooExAddToMsgForm		0x00000008
#define		ooExRoundLinesToSum		0x00000010
#define		ooExAddBatchNoClose		0x00000020
#define		ooExAddBatchClose		0x00000040
#define		ooExCloseBatch			0x00000080
#define		ooDontStartSqlTrans		0x00000100
#define		ooCreateTransOnly		0x00000200
#define		ooDontAdvanceAutoKey	0x00000400
#define		ooDontAdvanceNextNum	0x00000800
#define		ooDontCheckTranses		0x00001000

#define		ooDontSetMainFile		0x00002000
#define		ooDontUpdateArrFile		0x00004000
#define		ooDontGetArrayFile		0x00008000

#define		ooDontValidateData1		0x00010000
#define		ooDontValidateData2		0x00020000
#define		ooExInternalAutoMode	0x00040000
#define		ooExDontUpdateBalance	0x00080000

#define		ooExAttachReport		0x00100000
//#define		ooExPrintToScreen		0x00200000 //

#define		ooExUseFillProc			0x00400000

#define		ooDontUpdateBudget		0x00800000
#define		ooImportData			0x01000000

#define		ooDraftDocument			0x02000000
#define		ooDontWriteTrans		0x04000000
#define		ooDeleteOld				0x08000000

#define		ooExTempData1			0x10000000
#define		ooExTempData2			0x20000000
#define		ooExTempData3			0x40000000
#define		ooExTempData4			0x80000000

// Extended Commands 2
#define		ooEx2Write				0x00000001
#define		ooFromServiceCall		0x00000002
#define		ooCallSysBizObjProc		0x00000004
#define		ooDontShowFolioPrint	0x00000008
#define		ooFolioConfirmation		0x00000010
#define		ooFolioAssignment		0x00000020
#define		ooBeforeDocAdded		0x00000040
#define		ooEx2LandedCost			0x00000080
#define		ooExPrintToScreen		0x00000100
#define		ooExPrintToFile			0x00000200
#define		ooExPrintToImage		0x00000400
#define		ooExPrintToXml			0x00000800
#define		ooExPrint				0x00001000
#define		ooFromPickNPack			0x00002000
#define		ooDontAddRecJDT			0x00004000			
#define		ooExtReconcilAdjustment	0x00008000			
#define		ooEx2IgnoreRptCopies	0x00010000
#define		ooEx2IgnoreRptPrinter	0x00020000
#define		ooExTreatAsUpgrade		0x00040000
#define		ooChooseCacelledItems	0x00080000

// DT(Data Transfer) Extended Commands
#define		ooDataFromDT			0x00000001
#define		ooDoAsUpgrade			0x00000002
#define		ooDoNotCheckDates		0x00000004
#define		ooOBServerDT			0x00000008
#define		ooOBServerUpdate		0x00000010
#define		ooUpdatePriceOnly		0x00000020
#define		ooUpdateBOMPriceOnly	0x00000040

/***************************	Warning	Level	********************************/
#define		OOWL_AS_ERROR			1
#define		OOWL_PROMPT_USER		2
#define		OOWL_DISCARD			3

#define		OO_TRANS_RETRIES		6
#define		OO_TRANS_RETRY_TIMEOUT	2		// In Seconds

#undef		LAST_USED_OBJ
#undef		APA_LAST_USED_OBJ
#undef		CEE_LAST_USED_OBJ

#endif
