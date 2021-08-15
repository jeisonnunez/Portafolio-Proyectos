// SboDataAccessGate.h: interface for the CSboDataAccessGate class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_SBODATAACCESSGATE_H__2051848A_AA2C_4CF5_9FD7_106E5976D046__INCLUDED_)
#define AFX_SBODATAACCESSGATE_H__2051848A_AA2C_4CF5_9FD7_106E5976D046__INCLUDED_

class CSboCondition;

#include "SboDataAccessGateBase.h"
#include "SboCondition.h"

class CSboDataAccessGate : public CSboDataAccessGateBase
{
public:
	CSboDataAccessGate (intptr_t systemHandle);
	CSboDataAccessGate (const CSboDataAccessGate& other);
	CSboDataAccessGate& operator= (const CSboDataAccessGate& other);
	~CSboDataAccessGate ();

	void					GetTableName (wchar_t *tableName) const;

	void					SetRecordsCount (long numOfRecs, bool keepData = true);
	long					GetRecordsCount () const;
	long					GetColCount () const;

	SBOErr					GetValue (const wchar_t *alias, wchar_t *value, long maxLen = -1, long rec = 0) const;
	SBOErr					GetValue (long colIndex, wchar_t *value, long maxLen = -1, long rec = 0) const;

	long					GetValueLength (const wchar_t *alias, long rec = 0) const;
	long					GetValueLength (long colIndex, long rec = 0) const;

	SBOErr					SetValue (const wchar_t *alias, const wchar_t *value, long rec = 0);
	SBOErr					SetValue (long colIndex, const wchar_t *value, long rec = 0);

	SBOErr					AddCondition(const CSboCondition &scConditionToAdd);
	SBOErr					ClearAllConditions();
	SBOErr					DoQuery ();

	SBOErr					Update (long rec = -1);
	SBOErr					Insert (long rec = -1);
	SBOErr					Delete (long rec = -1);

	SBOErr					RemoveRecord (long rec = -1);

	CSboDataAccessGate		Clone (bool withData = true);

private:
	void					Destroy();
	long					Create();
};

#endif // !defined(AFX_SBODATAACCESSGATE_H__2051848A_AA2C_4CF5_9FD7_106E5976D046__INCLUDED_)
