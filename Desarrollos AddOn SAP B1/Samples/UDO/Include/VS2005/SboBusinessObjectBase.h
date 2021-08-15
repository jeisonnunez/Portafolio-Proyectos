// SboBusinessObjectBase.h: interface for the CSboBusinessObjectBase class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(_SBO_BUSINESS_OBJECT_H_)
#define _SBO_BUSINESS_OBJECT_H_

//
//				CSboBusinessObjectBase
//						  |
//		---------------------------------------
//		|									   |
//	CSboBusinessObjectImp				CSboBusinessObjectObject
//	(In the M400 application).			(In the SboUdoApi lib.
//										 All the partner's UDO class should derieve it).
//

#include "SBO_Types.h"
#include "SboDataAccessGate.h"
#include "ArrayOffset.h"
#include "MessageWarningLevel.h"

class CSboBusinessObjectBase
{
public:
	CSboBusinessObjectBase (intptr_t lSystemHandle) : m_lSystemHandle(lSystemHandle) {}
	virtual ~CSboBusinessObjectBase () {}

	virtual SBOErr					AutoComplete () = 0;
	virtual SBOErr					Cancel () = 0;
	virtual SBOErr					CanDelete () = 0;
	virtual SBOErr					Close () = 0;
	virtual SBOErr					Add (bool doAutoComplete = false) = 0;
	virtual SBOErr					CreateDefaults () = 0;
	virtual SBOErr					Delete () = 0;
	virtual SBOErr					InitData () = 0;
	virtual SBOErr					IsValid () = 0;
	virtual SBOErr					GetByKey (const wchar_t *keyStr, long keyNum = 1) = 0;
	virtual SBOErr					UndoCancel () = 0;
	virtual SBOErr					Update (bool doAutoComplete = false) = 0;
	virtual SBOErr					Upgrade () = 0;

	const wchar_t					*GetID () const { return m_wszID; }

	virtual SBOErr					GetValue (const wchar_t *alias, wchar_t *value, long maxLen = -1, ArrayOffset ao = ao_Main, long line = 0) = 0;
	virtual SBOErr					GetValue (long colIndex, wchar_t *value, long maxLen = -1, ArrayOffset ao = ao_Main, long line = 0) = 0;

	virtual SBOErr					GetValueLength (const wchar_t *alias, ArrayOffset ao = ao_Main, long line = 0) = 0;
	virtual SBOErr					GetValueLength (long colIndex, ArrayOffset ao = ao_Main, long line = 0) = 0;

	virtual SBOErr					SetValue (const wchar_t *alias, const wchar_t *value, ArrayOffset ao = ao_Main, long line = 0) = 0;
	virtual SBOErr					SetValue (long colIndex, const wchar_t *value, ArrayOffset ao = ao_Main, long line = 0) = 0;

	virtual long					SetErrorField (const wchar_t *alias) = 0;
	virtual long					SetErrorField (long colIndex) = 0;

	virtual void					GetMessageString (wchar_t *message, long maxLen = -1) = 0;

	virtual void					SetErrorArray (ArrayOffset ao) = 0;

	virtual void					SetSilentMode (bool silent) = 0;

	virtual void					Message (const wchar_t *str, WarningLevel type) = 0;
	virtual void					DisplayError (SBOErr sboErr) = 0;
	virtual BusinessFlow			GetCurrentFlow () = 0;

	virtual SBOErr					OnAutoComplete () = 0;
	virtual SBOErr					OnCancel () = 0;
	virtual SBOErr					OnCanDelete () = 0;
	virtual SBOErr					OnClose () = 0;
	virtual SBOErr					OnAdd () = 0;
	virtual SBOErr					OnCreateDefaults () = 0;
	virtual SBOErr					OnDelete () = 0;
	virtual SBOErr					OnInitData () = 0;
	virtual SBOErr					OnIsValid () = 0;
	virtual SBOErr					OnGetByKey () = 0;
	virtual SBOErr					OnUndoCancel () = 0;
	virtual SBOErr					OnUpdate () = 0;
	virtual SBOErr					OnUpgrade (long fromVersion, long toVersion) = 0;

	virtual SBOErr					AddYearTransferCondition(const CSboCondition &scConditionToAdd) = 0;
	virtual SBOErr					ClearAllYearTransferConditions() = 0;
	virtual SBOErr					OnYearTransfer (intptr_t lCompanyRef) = 0;

	virtual CSboBusinessObjectBase	*Clone (intptr_t lSystemHandle) = 0;
	virtual void					Destroy () = 0;

	virtual SBOErr					AddArchivingCondition(const CSboCondition &scConditionToAdd) = 0;
	virtual SBOErr					ClearArchivingConditions() = 0;
	virtual SBOErr					OnCanArchive (const wchar_t* archivePeriod, const intptr_t lResRef) = 0;
	virtual SBOErr					GetArchiveDateCol(long* outArcDateCol) = 0;

	intptr_t							m_lSystemHandle;

protected:
	void	Copy(const CSboBusinessObjectBase &rsbobaseSrc);

protected:
#define CSBO_ID_LEN					20L
	wchar_t							m_wszID[CSBO_ID_LEN + 1];
};

#define CSBO_CREATE_PROC_NAME	"CreateObject"
#define CSBO_INVOKE_PROC_NAME	"InvokeMethod"
#define CSBO_GET_VERSION_PROC_NAME	"GetUDOVersion"

#endif // !defined(_SBO_BUSINESS_OBJECT_H_)
