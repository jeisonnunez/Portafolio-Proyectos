    #ifndef __SBOERR_H_
	#define __SBOERR_H_

typedef long SBOErr;

#define dbdError					-1
#define	noErr						0
#define	errNoMsg					-10
#define coreEndOfFile				-39
#define	coreFileNotFound			-43
#define	coreFileBusy				-47
#define	coreFileNotOpened			-50
#define	coreFileCorrupted			-51
#define	coreDivisionByZero			-99
#define	coreOutOfMemory				-100
#define corePrinterError			-101
#define	corePrintCanceled			-103
#define	coreMoneyOverflow			-104
#define coreInvalidPointer			-111
#define coreError					-199
#define coreBadDirectory            -213
#define coreFileExists         	    -214
#define coreInvalidFilePermission	-216
#define coreInvalidPath				-217
#define coreBadPassword				-218
#define coreBadUser					-219
#define coreUpgradePerformed		-221
#define coreNoCurrPeriodErr			-222
#define coreLanguageInitErr			-8020

/* DBM Errors */
#define dbmFirstError           -1000
#define dbmBadColumnType		-1001
#define dbmNotSupported			-1002
#define	dbmAliasNotFound		-1003
#define	dbmValueNotFound		-1004
#define	dbmBadDate				-1005
#define	dbmNoDefaultColumn		-1012
#define	dbmZeroOrBlankValue		-1013
#define	dbmIntegerTooLarge		-1015
#define	dbmBadValue				-1016
#define dbmOtherFileNotRelated	-1022
#define dbmOtherKeyNotInMainKey	-1023
#define dbmArrayRecordNotFound	-1025
#define dbmMustBePositive		-1027
#define dbmMustBeNegative		-1028
#define dbmColumnNotUpdatable	-1029
#define dbmBadNumValue			-1030
#define dbmBadTimeValue			-1031
#define dbmBadMoneyValue		-1032
#define dbmNotUserDataSource	-1033

#define	dbmCannotAllocEnv		-1100
#define	dbmBadConnection		-1101
#define	dbmConnectionNotOpen	-1102
#define	dbmDatabaseExists		-1103
#define	dbmCannotCreateDatabase	-1104

#define dbmInternalError		-1200

#define dbmBadParameters		-2001
#define dbmTooManyTables		-2003
#define dbmTableNotFound		-2004
#define	dbmBadDefinition		-2006
#define dbmBadDAG				-2007
#define dbmBadRecordOffset		-2010
#define	dbmNoColumns			-2013
#define	dbmBadColumnIndex		-2014
#define dbmBadIndexNumber		-2015
#define	dbmBadAlias				-2017
#define dbmAliasAlreadyExists	-2018
#define	dbmBadColumnSize		-2020
#define	dbmBadColumLevel		-2022
#define dbmDAGsNoMatch			-2024
#define	dbmNoKeys				-2025
#define dbmPartialDataFound		-2027
#define dbmNoDataFound			-2028
#define	dbmColumnsNoMatch		-2029
#define	dbmDuplicateKey			-2035
#define dbmRecordLocked			-2038
#define dbmDataWasChanged		-2039
#define dbmEndOfSort			-2045
#define	dbmNotOpenForWrite		-2049
#define dbmNoMatchWithDAG		-2056
#define	dbmBadContainerOffset	-2062
#define dbmLoadExtLibFailed     -2100
#define dbmRowSizeTooLong		-2110 // the size of the table row is over the Sql limit 8K
#define dbmLastError			-2999

//db2 specific errors
#define dbmdb2AttachFailed      -2101
#define dbmdb2CreateDBFailed    -2102
#define dbmdb2DeAttachFailed    -2103
#define dbmdb2BackupFailed      -2104

//sybase specific errors
#define dbmSybaseDeviceCreationFailed    -2200

// QRY errors
#define qryNotDefined			-1
#define qryFirstError			-3000
#define qryColumnNotFound		-3001
#define qryBadVarNum			-3003
#define qryWrongToken			-3004
#define qryTokenAfterEnd		-3005
#define qryUnexpectedEnd		-3006
#define qryQueryTooLong			-3008
#define qryExtraRightPar		-3009
#define qryNoRightPar			-3010
#define qryNoOpcode 			-3012
#define qryNoColInComp			-3013
#define qryBadCondition			-3014
#define qryBadSortList			-3015
#define qryNoString				-3017
#define qryTooManyColumns		-3018
#define qryTooManyIndices		-3019
#define qryTooManyTables		-3020
#define qryRefNotFound			-3021
#define qryBadRangeSet			-3022
#define qryBadParse				-3023
#define qryTwoArraysInQuery		-3024
#define qryVarMissing			-3025
#define qryBadInput				-3026
#define qryProgressAborted		-3027
#define qryBadTableIndex		-3028
#define qryBadQuery				-3032
#define qryEmptyRecord			-3033
#define qryNoImpYet				-3034
#define	qryBadParameter			-3036
#define	qryMissingTableInList	-3037
#define	qryBadOperation			-3040
#define qryBadExpression		-3041
#define qryNameAlreadyExists	-3042
#define	qryTimeExpired			-3044
#define qryBadCallbackNum	 	-3045
#define	qryNoCallback			-3046
#define qryLastError 			-3046

//FORM errors
#define formNoWindow				3001
#define formBadVarNum				3002
#define formTooManyVars				3003
#define formDuplicateUID			3004
#define formInvalidItem				3006
#define formTooManyForms			3007
#define formTooManySavedPtrs		3009
#define formInvalidForm				3012
#define formCantGetMultilineEdit	3015
#define formBadItemType				3016
#define formBadParameters			3017
#define formNoMessageProc			3023
#define formItemNotSelectable		3029
#define formBadValue				3031
#define formItemNotFound			3033
#define formAXCreateFailed			3034
#define formNotUserItem				3035
#define formItemNotEditable			3036
#define formItemFocusFailedNotVisible		3037
#define formItemFocusFailedNotEditable		3038
#define fromCloseAllFormsFailed				3039

// GRID errors
#define gridInvalidGrid				4007
#define gridBadSize					4008
#define gridNoData					4009
#define gridInvalidParams			4011
#define gridNoSuperTitle			4013
#define gridSuperTitle2Exits		4014
#define gridBadItemNum				4015
#define gridBadData					4016
#define gridAlreadyFolded			4017
#define gridAlreadyExpanded			4018
#define gridLineExists				4019
#define gridNotEnoughData			4020
#define gridSuperTitlesExists		4022
#define gridRowNotCollapssible		4027
#define gridRowHasNoCollapseLevel	4028
#define gridInvalidRow				4029
#define gridItemSelectNotSupported	4030
#define gridInvalidColNum			4031
#define gridFocusFailedNotEditable			4032
#define gridFocusFailedNotVisible			4033
#define gridColumnFocusFailedNotEditable	4034

// SBAR
#define sbarNoSuchInfo			8004
#define sbarInfoOcccupied		8005
#define sbarProgressStopped		8007
#define sbarTooManyProgresses	8008
#define sbarNoMessageBar		8006

// GRAPH
#define graphInvalidGraph		5001
#define graphBadItemNum			5002
#define graphBadParameters		5005

// IBAR
#define ibarError				9000

// SCRIPT
#define		scFirstError			-9000
#define		scInvalidType			-9000
#define		scLineTooLarge			-9002
#define		scInvalidTokType		-9003
#define		scInvalidLine			-9004
#define		scInvalidFormType		-9005
#define		scInvalidOperator		-9006
#define		scInvalidScriptCall		-9007
#define		scItemNotValid			-9008
#define		scNotGird				-9009
#define		scUndefinedVar			-9010
#define		scRedefinedVar			-9011
#define		scNotVarOperation		-9012
#define		scIncompatVarType		-9013
#define		scStringTooLong			-9014
#define		scDivByZero				-9015
#define		scFileNotChoosen		-9016
#define		scFileNotOpen			-9017
#define		scSomeDataRead			-9018
#define		scIfNotClosed			-9020
#define		scLoopNotClosed			-9021
#define		scNotCompareThisType	-9022
#define		scLastError				-9022

// Reports
#define	rptFirstError				-6100
#define rptNotValid					-6100
#define rptDuplicateItem			-6101
#define rptBadParameters			-6200
#define rptColNotFound				-6250
#define rptBadVarNum				-6300
#define rptVarNotSet				-6305
#define rptBadStandardIndex			-6350
#define rptBadItemNum				-6370
#define	rptBadItemType				-6373
#define	rptItemFromAnotherPart		-6380
#define rptPassedPageLimit			-6390
#define rptProgressAborted			-6400
#define	rptTooManyPages				-6450
#define	rptNotPageFooter			-6500
#define rptNoQuery           		-6550
#define	rptNotPicture				-6600
#define	rptPrintCanceledByUser		-6650
#define	rptMarginTooLarge			-6651
#define	rptLoadExtLibFailed			-6652
#define	rptLoadExtProcFailed		-6653
#define rptReportTooLongForExport	-6700
#define rptInvalidFieldIDFormat		-6710
#define	rptFieldIDAlreadyExist		-6711
#define rptRecursiveDependency		-6712
#define rptFormulaGrammarError		-6713
#define rptSumItemCanOnlyBeInRepArea	-6714
#define rptNoSums					-6715
#define	rptDataTypeNoSuchMethod		-6716
#define rptFieldDoesnotExist		-6717
#define rptFieldNotEvaluatedYet		-6718
#define rptInvalidParameter			-6719
#define	rptMethodNotSupported		-6720
#define	rptTotalPageLiveAlone		-6721
#define rptRecursiveRelation		-6722
#define rptLastError				-6799

// Prog
#define	progBadProgress					9001
#define	progProgressIsModal				9002
#define	progProgressStopped				9003
#define	progBadParams					9004
#define	progOnlyOneDim					9005
#define	progModalProgressAlreadyOn		9006


//Menus
#define menuNotOwnerDrawn				-11001
#define menuNotSupportedImageType		-11002
#define menuCannotLoadImageFile			-11003

//UI errors
#define uiDuplicateUniqueID				-7502
#define uiInvalidObject					-7503
#define uiFunctionNotSupported			-7002
#define uiCannotSetFocusOnItem			-7653
#define uiSecuritySetFocusFailed		-7654
#define uiFailedLoadXml					-7040
#define uiInvalidFieldValue				-7018

#define dataTableSourceDTEqualToTargetDT		-7751
#define dataTableDuplicateColumnUID				-7752 //4500
#define dataTableInvalidColumnIndex				-7753 //4501
#define dataTableInvalidColumnUid				-7754 //4502
#define dataTableInvalidDAG						-7755 //4503
#define dataTableDuplicateUid					-7756 //4504
#define dataTableInvalidUid						-7757 //4505
#define dataTableInvalidIndex					-7758 //4506
#define dataTableInvalidVaribleNumber			-7759 //4507
#define dataTableInvalidRowIndex				-7760 //4508
#define dataTableInvalidAlias					-7761 //4509
#define dataTableLineExists						-7762 //4510
#define dataTableInvalidItemType				-7763 //4511
#define dataTableNotWritable					-7764 //4512
#define dataTableAlreadyConnectedToGrid			-7765 //4513
#define dataTableAlreadyConnectedToFormItem		-7766 //4514
#define dataTableColumnDataExceedsSize			-7767 //4515
#define dataTableInvalidValueType				-7768

#endif
