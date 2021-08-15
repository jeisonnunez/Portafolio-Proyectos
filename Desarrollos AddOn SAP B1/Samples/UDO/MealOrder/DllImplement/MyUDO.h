#ifndef _CMYUDO_H_
	#define _CMYUDO_H_

class CMyUDO : public CSboBusinessObject
{
public:
	CMyUDO (uintptr_t systemHandle);
	~CMyUDO ();

	virtual	CSboBusinessObjectBase		*Clone (uintptr_t systemHandle) {return new CMyUDO (systemHandle);}
	virtual	void						Destroy ();

	virtual SBOErr                      OnCancel ();
	virtual SBOErr                      OnClose ();
	virtual SBOErr						OnAdd ();
	virtual SBOErr                      OnDelete ();
	virtual SBOErr                      OnUpdate ();
	
	
	



	void								UpdateRoom();
	virtual SBOErr						GetArchiveDateCol(long* outArcDateCol);
	virtual SBOErr						OnCanArchive (const wchar_t* archivePeriod, const unsigned long lResRef);

	//virtual SBOErr					OnInitData ();
};

#endif	//_CMYUDO_H_
