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

#ifndef _DataSet_HEADER_
#define _DataSet_HEADER_

/*! \file DataSet.h This file provides access to the DataSet data.
 */

#include "AffymetrixBaseTypes.h"
#include "DataSetHeader.h"
#include "DataException.h"
#include <string>
#include <fstream>

#ifdef WIN32
#include <windows.h>
#endif

namespace affymetrix_calvin_io
{

// forward declare
class GenericData;

/*! This class provides methods to access the data of a DataSet. */
class DataSet
{
public:
	/*! Constructor
	 *	@param fileName The name of the generic file to access.
	 *	@param header The DataSetHeader of the DataSet to access.
	 *	@param handle A handle to the file mapping object
	 */
	DataSet(const std::string& fileName, const affymetrix_calvin_io::DataSetHeader& header, void* handle);

public:
	/*! Method to release memory held by this object.  Closes object before deleting. */
	void Delete();

	/*! Method to open the DataSet to access the data.
	 *	@return true if successful
	 */
	bool Open();

	/*! Method to close the DataSet. */
	void Close();

	/*! Method to get a reference to the DataSetHeader
	 *	@return A reference to the DataSetHeader.
	 */
	const affymetrix_calvin_io::DataSetHeader& Header() { return header; }

	/*! Return the number of rows in the DataSet. */
	int32_t Rows() { return header.GetRowCnt(); }

	/*! Return the number of columns in the DataSet. */
	int32_t Cols() { return header.GetColumnCnt(); }

	/*! Determines if the DataSet is open
	 *	@return true if the DataSet is open
	 */
	bool IsOpen() { return (data != 0); }

	/*! Provides access to single data elements
	 *	@param row Row index.
	 *	@param col Column index.
	 *	@param value Reference to the data type to fill with the data.
	 *	@exception affymetrix_calvin_exceptions::DataSetNotOpenException The file is not memory-mapped.
	 */
	void GetData(int32_t row, int32_t col, u_int8_t& value);

	void GetData(int32_t row, int32_t col, int8_t& value);

	void GetData(int32_t row, int32_t col, u_int16_t& value);

	void GetData(int32_t row, int32_t col, int16_t& value);

	void GetData(int32_t row, int32_t col, u_int32_t& value);

	void GetData(int32_t row, int32_t col, int32_t& value);

	void GetData(int32_t row, int32_t col, float& value);

	void GetData(int32_t row, int32_t col, std::string& value);

	void GetData(int32_t row, int32_t col, std::wstring& value);

	/*! Provides access to multiple data elements in the same column.
	 *	If count elements could not be read, it is not considered an error.  The vector
	 *	is filled with only the data that could be read.
	 *	@param col Column index.
	 *	@param startRow Row index of the data to be inserted into the vector at [0].
	 *	@param count Number of elements to retrieve. -1 indicates to read all
	 *	@param value Reference to the data type to fill with the data.
	 *	@exception affymetrix_calvin_exceptions::DataSetNotOpenException The file is not memory-mapped.
	 */

	void GetData(int32_t col, int32_t startRow, int32_t count, Uint8Vector& values);

	void GetData(int32_t col, int32_t startRow, int32_t count, Int8Vector& values);

	void GetData(int32_t col, int32_t startRow, int32_t count, Uint16Vector& values);

	void GetData(int32_t col, int32_t startRow, int32_t count, Int16Vector& values);

	void GetData(int32_t col, int32_t startRow, int32_t count, Uint32Vector& values);

	void GetData(int32_t col, int32_t startRow, int32_t count, Int32Vector& values);

	void GetData(int32_t col, int32_t startRow, int32_t count, FloatVector& values);

	void GetData(int32_t col, int32_t startRow, int32_t count, std::vector<std::string>& values);

	void GetData(int32_t col, int32_t startRow, int32_t count, WStringVector& values);

	/*! Provides access to multiple data elements in the same column.
	 *	The caller is responsible for allocating the storage to which count element values can be written.
	 *	If count elements could not be read, it is not considered an error.  The array
	 *	is filled with only the data that could be read.
	 *	@param col Column index.
	 *	@param startRow Row index of the data to be inserted into the vector at [0].
	 *	@param count Number of elements to retrieve. -1 indicates to read all
	 *	@param value Reference to the data type to fill with the data.
	 *	@return Number of elements read.
	 *	@exception affymetrix_calvin_exceptions::DataSetNotOpenException The file is not memory-mapped.
	*/

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, u_int8_t* values);

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, int8_t* values);

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, u_int16_t* values);

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, int16_t* values);

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, u_int32_t* values);

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, int32_t* values);

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, float* values);

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, std::string* values);

	int32_t GetDataRaw(int32_t col, int32_t startRow, int32_t count, std::wstring* values);

	/*! Check that the requested data matches the type of data in the column and that row and column are in bounds.
	 *	@param row Row index to check.
	 *	@param col Column index to check.
	 *	@param type Column type to check.
	 *	@exception affymetrix_calvin_exceptions::DataSetNotOpenException The file is not memory-mapped.
	 *	@exception affymetrix_calvin_exceptions::ColumnIndexOutOfBoundsException The column index is out-of-bounds.
	 *	@exception affymetrix_calvin_exceptions::RowIndexOutOfBoundsException The row index is out-of-bounds.
	 *	@exception affymetrix_calvin_exceptions::UnexpectedColumnTypeException The column type does not match the type requested.
	 */
	void CheckRowColumnAndType(int32_t row, int32_t col, affymetrix_calvin_io::DataSetColumnTypes type);

	// Figure out how to present a row of data

//protected:

	/*! Return the bytes per row.
	 *	@return Bytes in a row.
	 */
	int32_t BytesPerRow() { return columnByteOffsets[header.GetColumnCnt()]; }

protected:
	/*! Destructor. */
	~DataSet();


	/*! Close the memory mapped file. */
	void UnmapFile();

	/*! Map a part of the file.
	 *	@param start File position to start mapping.
	 *	@param btyes Number of bytes to map.
	 */
//	bool MapData(u_int32_t start, u_int32_t bytes);

	/*! Returns the address of a data element given a row and column.
	 *	@param row Row index
	 *	@param col Column index
	 *	@return pointer to the data element
	 *	@exception affymetrix_calvin_exceptions::DataSetNotOpenException The file is not memory-mapped.
	 */
//	char* FilePosition(int32_t row, int32_t col);

	/*! Returns the address of a data element given a row and column.  Ensures that data from rowStart
	 *	to rowCount+rowStart are mapped unless that is larger than the mapped window.
	 *	@param rowStart Row index
	 *	@param col Column index
	 *	@param rowCount The number of rows to ensure are mapped starting at rowStart
	 *	@return Pointer to the data element at rowStart
	 *	@exception affymetrix_calvin_exceptions::DataSetNotOpenException The file is not memory-mapped.
	 */
	char* FilePosition(int32_t rowStart, int32_t col, int32_t rowCount=1);

	/*! Updates the columnByteOffsets member. */
	void UpdateColumnByteOffsets();

	/*! Computes the index of the row after last to read.
	 *	@param startRow Row index of the data to be inserted into the vector at [0].
	 *	@param count Number of elements to be retrieved. -1 indicates read to the last element.
	 *	@return Index of row after the last row to read.
	 */
	int32_t ComputeEndRow(int32_t startRow, int32_t count);

	/*!	Clears and resizes the vector
	 *	@param values Reference to a vector to clear and resize.
	 *	@param size Target size of the vector
	 */
	template<typename T> void ClearAndSizeVector(std::vector<T>& values, u_int32_t size);

	/*! Platform specific memory-mapping method */
#ifdef WIN32
	bool MapDataWin32(u_int32_t start, u_int32_t bytes);
#else
	bool MapDataPosix(u_int32_t start, u_int32_t bytes);
#endif

protected:
	/*! name of the file containing the data dataGroup.  */
	std::string fileName;

	/*! copy of the DataSetHeader */
	affymetrix_calvin_io::DataSetHeader header;

	/*! pointer to the mapped data, doesn't account for allocation granularity. */
	void*	mappedData;

	/*! pointer to the mapped data, allocation granularity has been accounted for. */
	char*	data;

	/*! Array of column byte offsets.  Updated when the file is opened.
	 *  There are columns + 1 elements
	 */
	std::vector<int32_t> columnByteOffsets;

#ifdef WIN32
	/*! Handle returned by CreateFileMapping */
	HANDLE fileMapHandle;
	/*! Maximum size of the view to map */
	static const u_int32_t MaxViewSize = 200*1024*1024;	// 200MB
#else
	FILE *fp;
#endif

	/*! Byte offset to the start of the view */
	u_int32_t mapStart;
	/*! Number of bytes mapped to the view */
	u_int32_t mapLen;

	/*! Indicates if the file has been opened. */
//	bool fileOpen;

	/*! Indicates if the file has been successfully mapped. */
//	bool fileMapped;
};

}

#endif // _DataSet_HEADER_