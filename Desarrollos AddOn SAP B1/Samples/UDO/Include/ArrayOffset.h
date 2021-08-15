#ifndef ARRAY_OFFSET_H
#define ARRAY_OFFSET_H

#pragma once

enum ArrayOffset
{
	ao_Invalid	=		0,

	ao_Main		=		1,

	ao_Odd1		=		2,
	ao_Odd2		=		3,
	ao_Odd3		=		4,
	ao_Odd4		=		5,
	ao_Odd5		=		6,
	ao_Odd6		=		7,
	ao_OddMax	=		ao_Odd6,

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
	ao_Arr14	=		25,
	ao_Arr15	=		26,
	ao_Arr16	=		27,
	ao_Arr17	=		28,
	ao_Arr18	=		29,
	ao_Arr19	=		30,
	ao_Arr20	=		31,
	ao_Arr21	=		32,
	ao_Arr22	=		33,
	ao_Arr23	=		34,
	ao_ArrMax	=		ao_Arr23,

	ao_Max		=		ao_Arr23
/*
	ao_Log		=		-ao_Main,
	ao_Log1		=		-ao_Arr1,
	ao_Log2		=		-ao_Arr2,
	ao_Log3		=		-ao_Arr3,
	ao_Log4		=		-ao_Arr4,
	ao_Log5		=		-ao_Arr5,
	ao_Log6		=		-ao_Arr6,
	ao_Log7		=		-ao_Arr7,
	ao_Log8		=		-ao_Arr8,
	ao_Log9		=		-ao_Arr9,
	ao_Log10	=		-ao_Arr10,
	ao_Log11	=		-ao_Arr11,
	ao_Log12	=		-ao_Arr12,
	ao_Log13	=		-ao_Arr13,
*/
};

// This needs to match node relation format in binary GRF file.
enum NodeRelation
{
	NR_Array, NR_Odd
};

inline ArrayOffset ConvertToArrayOffset (NodeRelation nodeRelation, unsigned long nodeNumber)
{
	if (nodeRelation == NR_Array)
	{
		if (nodeNumber == 0)
		{
			return ao_Main;
		}
		else
		{
			return static_cast<ArrayOffset>(ao_Arr1 + nodeNumber - 1);
		}
	}
	else
	{
		return static_cast<ArrayOffset>(ao_Odd1 + nodeNumber - 1);
	}
}

inline bool ConvertFromArrayOffset (ArrayOffset arrayOffset, NodeRelation& nodeRelation, unsigned long& nodeNumber)
{
	if (arrayOffset == ao_Main)
	{
		nodeRelation = NR_Array;
		nodeNumber = 0;

		return true;
	}
	else if (arrayOffset >= ao_Arr1 && arrayOffset <= ao_ArrMax)
	{
		nodeRelation = NR_Array;
		nodeNumber = arrayOffset - ao_Arr1 + 1;

		return true;
	}
	else if (arrayOffset >= ao_Odd1 && arrayOffset <= ao_OddMax)
	{
		nodeRelation = NR_Odd;
		nodeNumber = arrayOffset - ao_Odd1 + 1;

		return true;
	}

	return false;
}

#endif // ARRAY_OFFSET_H
