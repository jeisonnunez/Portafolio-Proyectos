// SboBusinessObject.h: interface for the CSboBusinessObject class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_SBOBUSINESSOBJECT_H__9905B425_0CAB_4DE7_B107_CD01758543AD__INCLUDED_)
#define AFX_SBOBUSINESSOBJECT_H__9905B425_0CAB_4DE7_B107_CD01758543AD__INCLUDED_

#include "SboBusinessObjectBase.h"

class CSboBusinessObject:public CSboBusinessObjectBase
{
public:
	CSboBusinessObject (uintptr_t lSystemHandle);
	virtual ~CSboBusinessObject ();
	


	CSboBusinessObject				*CreateBusinessObject (const wchar_t *id);
	
	SBOErr							AutoComplete ();
	SBOErr							Cancel ();
	SBOErr							CanDelete ();
	SBOErr							Close ();
	SBOErr							Add (bool doAutoComplete = false);
	SBOErr							CreateDefaults ();
	SBOErr							Delete ();
	SBOErr							InitData (); // 
	SBOErr							IsValid ();
	SBOErr							GetByKey (const wchar_t *keyStr, long keyNum = 1);
	SBOErr							UndoCancel ();
	SBOErr							Update (bool doAutoComplete = false);
	SBOErr							Upgrade ();
									
	CSboDataAccessGate				GetDAG (ArrayOffset ao = ao_Main);
	CSboDataAccessGate				GetDAG (const wchar_t *objectId, ArrayOffset ao = ao_Main);
									
	SBOErr							GetValue (const wchar_t *alias, wchar_t *value, long maxLen = -1, ArrayOffset ao = ao_Main, long line = 0);
	SBOErr							GetValue (long colIndex, wchar_t *value, long maxLen = -1, ArrayOffset ao = ao_Main, long line = 0);

	long							GetValueLength (const wchar_t *alias, ArrayOffset ao = ao_Main, long line = 0);
	long							GetValueLength (long colIndex, ArrayOffset ao = ao_Main, long line = 0);
	
	SBOErr							SetValue (const wchar_t *alias, const wchar_t *value, ArrayOffset ao = ao_Main, long line = 0);
	SBOErr							SetValue (long colIndex, const wchar_t *value, ArrayOffset ao = ao_Main, long line = 0);

	SBOErr							SetErrorField (const wchar_t *alias);
	SBOErr							SetErrorField (long colIndex);

	void							GetMessageString (wchar_t *message, long maxLen = -1);

	void							SetErrorArray (ArrayOffset ao);

	void							SetSilentMode (bool silent);

	void							Message (const wchar_t *str, WarningLevel type);
	void							DisplayError (SBOErr sboErr);
	BusinessFlow					GetCurrentFlow ();

	virtual SBOErr					OnAutoComplete ();
	virtual SBOErr					OnCancel ();
	virtual SBOErr					OnCanDelete ();
	virtual SBOErr					OnClose ();
	virtual SBOErr					OnAdd ();
	virtual SBOErr					OnCreateDefaults ();
	virtual SBOErr					OnDelete ();
	virtual SBOErr					OnInitData ();
	virtual SBOErr					OnIsValid ();
	virtual	SBOErr					OnGetByKey ();
	virtual SBOErr					OnUndoCancel ();
	virtual SBOErr					OnUpdate ();
	virtual SBOErr					OnUpgrade (long fromVersion, long toVersion);
	
	virtual SBOErr					AddYearTransferCondition(const CSboCondition &scConditionToAdd);
	virtual SBOErr					ClearAllYearTransferConditions();

	virtual SBOErr					OnYearTransfer (unsigned long companyRef);

private:
	virtual	CSboBusinessObjectBase	*Clone (uintptr_t lSystemHandle) = 0;
	virtual	void					Destroy () = 0;
	void							Copy(const CSboBusinessObject &sboSrc);

public:
	virtual SBOErr					AddArchivingCondition(const CSboCondition &scConditionToAdd);
	virtual SBOErr					ClearArchivingConditions();
	virtual SBOErr					OnCanArchive (const wchar_t* archivePeriod, const unsigned long lResRef);
	virtual SBOErr					GetArchiveDateCol(long* outArcDateCol);

private:
};

long GetSboUdoApiLibVersion();

#endif // !defined(AFX_SBOBUSINESSOBJECT_H__9905B425_0CAB_4DE7_B107_CD01758543AD__INCLUDED_)
