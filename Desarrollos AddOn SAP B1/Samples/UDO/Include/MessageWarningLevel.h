#pragma once
/**
* @file MessageWarningLevel.h
* @brief ~
*/

#ifndef MESSAGE_WARNING_LEVEL_H
#define MESSAGE_WARNING_LEVEL_H

enum WarningLevel
{
	OO_ERROR   = 'E',
	OO_NOTE	   = 'N',
	OO_WARNING = 'W',
	OO_SUCCESS = 'S',
	OO_CLEAR   = 'X', // used only in UTL6 Form
	OO_NONE	   = 'O'
};
	
#endif