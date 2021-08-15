#pragma once

#include <tchar.h>
#include "__CORE_TYPES.h"
#include "ArrayOffset.h"

typedef long SBOErr;

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
	bf_YearTransfer = 8,
	bf_CreateDefaults = 9,
	bf_Load = 10,
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
	om_EndSuccessfulFlow,
	om_GetByKey,
	om_CheckIntegrityOnCreate,
	om_CheckIntegrityOnUpdate,
	om_CheckObjectCountLimit,
	om_UserRequest,
	om_CloseDocumentLine,
	om_EndFailedFlow,
	om_UpgradeAlgOnly,
	om_UpdateNum,
	om_UpgradeKeyOnly,
	om_ResetDKeyData,
	om_GeneratePassport
};
