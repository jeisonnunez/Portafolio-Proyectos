// SboDataAccessGateBase.h: interface for the CSboDataAccessGateBase class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_SBODATAACCESSGATEBASE_H__7DE5B6D1_3A1A_4D0A_AE24_3AC6E4698167__INCLUDED_)
#define AFX_SBODATAACCESSGATEBASE_H__7DE5B6D1_3A1A_4D0A_AE24_3AC6E4698167__INCLUDED_

class CSboCondition;

class CSboDataAccessGateBase
{
public:
	CSboDataAccessGateBase (intptr_t lSystemHandle);
	CSboDataAccessGateBase (const CSboDataAccessGateBase& other);
	virtual ~CSboDataAccessGateBase ();

	virtual void			GetTableName (wchar_t *tableName) const = 0;
	virtual long			GetRecordsCount () const = 0;
	virtual long			GetColCount () const = 0;

	virtual SBOErr			GetValue (const wchar_t *alias, wchar_t *value, long maxLen = -1, long rec = 0) const = 0;
	virtual SBOErr			GetValue (long colIndex, wchar_t *value, long maxLen = -1, long rec = 0) const = 0;

	virtual long			GetValueLength (const wchar_t *alias, long rec = 0) const = 0;
	virtual long			GetValueLength (long colIndex, long rec = 0) const = 0;

	virtual SBOErr			SetValue (const wchar_t *alias, const wchar_t *value, long rec = 0) = 0;
	virtual SBOErr			SetValue (long colIndex, const wchar_t *value, long rec = 0) = 0;

	virtual SBOErr			AddCondition(const CSboCondition &scConditionToAdd) = 0;
	virtual SBOErr			ClearAllConditions() = 0;
	virtual SBOErr			DoQuery () = 0;

	virtual SBOErr			Update (long rec = -1) = 0;
	virtual SBOErr			Insert (long rec = -1) = 0;
	virtual SBOErr			Delete (long rec = -1) = 0;

	virtual SBOErr			RemoveRecord (long rec = -1) = 0;

protected:
	void					SetHandle(intptr_t lNewHandle);

protected:
	intptr_t				m_lSystemHandle;
};

#endif // !defined(AFX_SBODATAACCESSGATEBASE_H__7DE5B6D1_3A1A_4D0A_AE24_3AC6E4698167__INCLUDED_)
