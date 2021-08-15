#pragma once

#include <stdint.h>


#define NULL_DFLT			= NULL

#ifdef _WIN64
typedef long long B1INT;
typedef unsigned long long B1UINT;

#else
typedef long B1INT;
typedef unsigned long B1UINT;
#endif


#include <stdint.h>
#ifndef _UTF_TYPES
	typedef unsigned char	UTF8;	
#ifdef _LINUX
	typedef wchar_t	UTF32;	
	typedef uint16_t UTF16;
#else
	typedef uint32_t  UTF32;
	typedef wchar_t	UTF16;
#endif
	#define _UTF_TYPES
#endif


typedef void					*Ptr;
typedef unsigned char			*CORE_Ptr;
typedef const unsigned char		*CORE_CPtr;
typedef void					*CORE_Instance;

enum XBool
{
	xb_false,
	xb_true,
	xb_default
};

#define	Bool2XBool(b)			((b) ? xb_true : xb_false)

typedef long					SBOErr;
#define noErr					0

#define EMPTY_STR				_T("")
