/////////////////////////////////////////////////////////////////
//
// Copyright (C) 2005 Affymetrix, Inc.
//
// This library is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation; either version 2.1 of the License,
// or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License
// for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library; if not, write to the Free Software Foundation, Inc.,
// 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA 
//
/////////////////////////////////////////////////////////////////

#include "ArrayAttributes.h"

using namespace affymetrix_calvin_array;

/*
 * Initialize the class.
 */
ArrayAttributes::ArrayAttributes()
{
	Clear();
}

/*
 * Clean up.
 */
ArrayAttributes::~ArrayAttributes()
{
	Clear();
}

/*
 * Clears the member variables.
 */
void ArrayAttributes::Clear()
{
	attributes.clear();
	id.clear();
	arrayName.clear();
	arrayBarcode.clear();
	media=CartridgeMedia;
	mediaRow=0;
	mediaCol=0;
	customerBarcode.clear();
	masterFile.clear();
	masterFileId.clear();
	patAssignment = NoAssignment;
	creationDateTime.clear();
	createdBy.clear();
	comment.clear();
}
