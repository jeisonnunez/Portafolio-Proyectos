#ifndef _SBO_TYPES_H_
	#define _SBO_TYPES_H_

#include <tchar.h>

typedef long SBOErr;


enum ArrayOffset
{
	ao_Invalid	=		0,

	ao_Main		=		1,

	ao_Arr1		=		12,
	ao_Arr2		=		13,
	ao_Arr3		=		14,
	ao_Arr4		=		15,
	ao_Arr5		=		16,
	ao_Arr6		=		17,
	ao_Arr7		=		18,
	ao_Arr8		=		19,
	ao_Arr9		=		20,
	ao_Arr10	=		21,
	ao_Arr11	=		22,
	ao_Arr12	=		23,
	ao_Arr13	=		24,
};

enum BusinessFlow
{
	bf_None = 0,
	bf_Cancel = 1,
	bf_Close = 2,
	bf_Create = 3,
	bf_Delete = 4,
	bf_UndoCancel = 5,
	bf_Update = 6,
	bf_Upgrade = 7,
};

enum ObjectMethod
{
	om_None,
	om_AutoComplete = 1,
	om_Cancel,
	om_CanUpdate,
	om_CheckDelete,
	om_Close,
	om_Create,
	om_CreateDefaults,
	om_Delete,
	om_GetNextSerial,
	om_InitData,
	om_InitFlow,
	om_IsValid,
	om_OpenObjFiles,
	om_PutSignature,
	om_SetBaseLineProc,
	om_UndoCancel,
	om_Update,
	om_Upgrade,
	om_YearTransfer,
};

enum WarningLevel
{
	wl_Error = 'E',
	wl_Note	= 'N',
	wl_Warning = 'W',
	wl_Success = 'S',
};

#endif
