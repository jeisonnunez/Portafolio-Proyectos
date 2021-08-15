// SboCondition.h: interface for the CSboCondition class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(__SBO_CONDITION_H_INCLUDED__)
#define		 __SBO_CONDITION_H_INCLUDED__

enum QRYOpType
{
	qot_None		=	0,
	qot_EQ		=		1,
	qot_GT		=		2,
	qot_LT		=		3,
	qot_GE		=		4,
	qot_LE		=		5,
	qot_NE		=		6,

	qot_CONTAIN	=		7,
	qot_NOT_CONTAIN	=	8,
	qot_START	=		9,
	qot_END		=		10,
	qot_IN		=		11,
	qot_NOT_IN	=		12,

	qot_IS_NULL		=	13,
	qot_NOT_NULL	=	14,
	qot_EXISTS		=	15,
	qot_NOT_EXISTS	=	16,
};

enum QRYRelType
{
	qrt_None		=	0,
	qrt_AND			=	98,
	qrt_OR			=	99,
};


class CSboCondition
{
public:
	CSboCondition ();
	~CSboCondition ();
	CSboCondition (const CSboCondition &scSrc);
	void Copy(const CSboCondition &scSrc);
	void Clear ();
	
	bool SetStaticCondVal(const wchar_t *pwcNewVal);
	bool SetColAlias(const wchar_t *pwcNewVal);
	bool SetCompareColAlias(const wchar_t *pwcNewVal);

public:
	long		m_lBracketsOpen;
	long		m_lBracketsClose;
	wchar_t		m_wszColAlias[11];
	QRYOpType	m_enumOperation;
	wchar_t		m_wszStaticCondVal[256];
	bool		m_bDoColComparison;
	wchar_t		m_wszCompareColAlias[11];
	QRYRelType	m_enumRelationship;
};
#endif // !defined(__SBO_CONDITION_H_INCLUDED__)
