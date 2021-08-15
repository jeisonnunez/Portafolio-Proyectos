
#include "SboBusinessObject.h"
#include "string"
#include "MyUDO.h"
#include "SboCondition.h"


#define MEAL_PRICE	32


/*****************************************************************************************/
/*****************************************************************************************/
CSboBusinessObject *CreateObject (uintptr_t systemHandle)
{
	return new CMyUDO (systemHandle);
}
/*****************************************************************************************/
/*****************************************************************************************/
TCHAR* InvokeMethod(CSboBusinessObject * refObj, const TCHAR* sInput)
{
	CMyUDO* myObj = (CMyUDO*)refObj;

	return _T("Updated");
}
/*****************************************************************************************/
/*****************************************************************************************/
CMyUDO::CMyUDO (uintptr_t systemHandle) : CSboBusinessObject (systemHandle)
{
}

/*****************************************************************************************/
/*****************************************************************************************/
CMyUDO::~CMyUDO ()
{
}

/*****************************************************************************************/
/*****************************************************************************************/
void CMyUDO::Destroy()
{
	delete this;
}

/*****************************************************************************************/
/*****************************************************************************************/
/*									Virtual Functions									 */
/*****************************************************************************************/
/*****************************************************************************************/

SBOErr CMyUDO::GetArchiveDateCol(long* outArcDateCol)
{
	*outArcDateCol = 12; 	// creation date of the document
	return CSboBusinessObject::GetArchiveDateCol(outArcDateCol);
}

long GetUDOVersion()
{
	return 880000;
}


SBOErr CMyUDO::OnCanArchive(const wchar_t* archivePeriod, const unsigned long lResRef)
{
	SBOErr sboErr = 0;
	ClearArchivingConditions();
	
	return CSboBusinessObject::OnCanArchive(archivePeriod, lResRef);
}



SBOErr	CMyUDO::OnAdd ()
{
	long	lErr, lMealCount;
	TCHAR	tcPrice[128];

	//calculate price of meals
	CSboDataAccessGate dagMOR1 = GetDAG (ao_Arr1);
	lMealCount = dagMOR1.GetRecordsCount();
	swprintf (tcPrice, _T("%d"), lMealCount * MEAL_PRICE);

	//set the price
	lErr = SetValue (_T("U_Price"), tcPrice, ao_Main, 0);

	//call father class OnAdd function
	SBOErr sboErr = CSboBusinessObject::OnAdd ();
	if (sboErr)
	{
		return sboErr;
	}

	return 0;
}

SBOErr	CMyUDO::OnUpdate ()
{

	SBOErr sboErr = CSboBusinessObject::OnUpdate ();
	if (sboErr)
	{
		return sboErr;
	}

	return 0;
}

SBOErr	CMyUDO::OnCancel ()
{

	SBOErr sboErr = CSboBusinessObject::OnCancel ();
	if (sboErr)
	{
		return sboErr;
	}

	return 0;
}


SBOErr	CMyUDO::OnClose ()
{
	SBOErr sboErr = CSboBusinessObject::OnClose ();
	if (sboErr)
	{
		return sboErr;
	}

	return 0;
}

SBOErr	CMyUDO::OnDelete ()
{

	SBOErr sboErr = CSboBusinessObject::OnDelete ();
	if (sboErr)
	{
		return sboErr;
	}

	return 0;
}
