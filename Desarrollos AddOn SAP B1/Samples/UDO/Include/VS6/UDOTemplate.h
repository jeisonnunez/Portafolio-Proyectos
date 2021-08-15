#ifndef _CMYUDO_H_
	#define _CMYUDO_H_

class CUDOTemplate : public CSboBusinessObject
{
public:
	CUDOTemplate (unsigned long systemHandle);
	~CUDOTemplate ();

	virtual	CSboBusinessObjectBase	*Clone (unsigned long systemHandle) {return new CUDOTemplate (systemHandle);}
	virtual	void					Destroy ();
	virtual SBOErr					OnAutoComplete ();
	virtual SBOErr					OnCancel ();
	virtual SBOErr					OnCanDelete ();
	virtual SBOErr					OnClose ();
	virtual SBOErr					OnAdd ();
	//virtual SBOErr					OnCreateDefaults ();
	virtual SBOErr					OnDelete ();
	virtual SBOErr					OnInitData ();
		//virtual SBOErr					OnCreateDefaults ();
	virtual SBOErr					OnIsValid ();
	//virtual	SBOErr					OnGetByKey ();
	virtual SBOErr					OnUndoCancel ();
	//virtual SBOErr					OnUpdate ();
	
	SBOErr							Delete ();
		SBOErr							Add (bool doAutoComplete = false);

private:


	FILE	*fpLog;
};

#endif	//_CMYUDO_H_
