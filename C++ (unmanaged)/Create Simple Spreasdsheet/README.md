## How to create simple spreasdsheet in C++ (unmanaged) with ByteScout Spreadsheet SDK

### How to code in C++ (unmanaged) to create simple spreasdsheet with this step-by-step tutorial

These source code samples are listed and grouped by their programming language and functions they use. ByteScout Spreadsheet SDK is the SDK to create, read, modify and calculate spreadsheets. Formula calculations are supported, import and export to and from JSON, CSV, XML, databases, arrays and you can use it to create simple spreasdsheet with C++ (unmanaged).

This rich sample source code in C++ (unmanaged) for ByteScout Spreadsheet SDK includes the number of functions and options you should do calling the API to create simple spreasdsheet. This C++ (unmanaged) sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Detailed tutorials and documentation are available along with installed ByteScout Spreadsheet SDK if you'd like to dive deeper into the topic and the details of the API.

ByteScout Spreadsheet SDK free trial version is available on our website. C++ (unmanaged) and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Spreadsheet%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Spreadsheet%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nm_7I0PN1TY](https://www.youtube.com/watch?v=nm_7I0PN1TY)




<!-- code block begin -->

##### ****HelloWorld.cpp:**
    
```
// IMPORTANT: Copy ByteScout.Spreadsheet.tlb into the project folder
// HelloWorld.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <windows.h>

#pragma warning (disable: 4278)


#import "c:\windows\system32\stdole2.tlb" rename_namespace("BytescoutSpreadsheet") exclude("GUID", "DISPPARAMS", "EXCEPINFO",  \
	"OLE_XPOS_PIXELS", "OLE_YPOS_PIXELS", "OLE_XSIZE_PIXELS", "OLE_YSIZE_PIXELS", "OLE_XPOS_HIMETRIC",  \
	"OLE_YPOS_HIMETRIC", "OLE_XSIZE_HIMETRIC", "OLE_YSIZE_HIMETRIC", "OLE_XPOS_CONTAINER", \
	"OLE_YPOS_CONTAINER", "OLE_XSIZE_CONTAINER", "OLE_YSIZE_CONTAINER", "OLE_HANDLE", "OLE_OPTEXCLUSIVE", \
	"OLE_CANCELBOOL", "OLE_ENABLEDEFAULTBOOL", "FONTSIZE", "OLE_COLOR")


// To use managed-code servers like the C# server, 
// we have to import the common language runtime:
#import <mscorlib.tlb> raw_interfaces_only
#import <System.tlb> raw_interfaces_only
#import <System.Drawing.tlb> raw_interfaces_only

#import "Bytescout.Spreadsheet.tlb" rename_namespace("BytescoutSpreadsheet") //no_namespace named_guids 
int main(int argc, char* argv[])
{
	// initialize OLE
	HRESULT hr = CoInitialize(NULL);

	// check for errors
	if (FAILED(hr)) {
	MessageBox(0,"OLE initialization errp","error",MB_OK);
	return -1;
	}
	// declare document object

	ISpreadsheet * Doc = NULL;
	CLSID clsid;
		_Worksheets* worksheets = NULL;
		_Worksheet* worksheet = NULL;
			_Cell* cell = NULL;

	// get inuque ID for ISpreadsheet interface
	hr = CLSIDFromProgID(OLESTR("Bytescout.Spreadsheet.Spreadsheet"), &clsid);
	// check for errors
	if (FAILED(hr)) {
	MessageBox(0,"Can't get CLSID for ISpreadsheet interface","error",MB_OK);
	goto Uninit;
	};
	// create Spreadsheet object
	hr = CoCreateInstance(clsid, NULL, CLSCTX_INPROC_SERVER, __uuidof(ISpreadsheet), (LPVOID*)&Doc);
	// check for errors
	if (FAILED(hr)) {
	MessageBox(0,"Can't create Spreadsheet object","error",MB_OK);
	goto Uninit;
	}

	//IWorksheets* worksheets = NULL;
	

	Doc->get_Worksheets(&worksheets);




	worksheet = reinterpret_cast<IWorksheets*>(worksheets)->Add("Sheet 1");



	cell = reinterpret_cast<IWorksheet*>(worksheet)->Cell("A1");

	reinterpret_cast<ICell*>(cell)->PutValueAsHTML("test value");
	
	Doc->SaveAs("output.xls");

	// release PDFDoc object
	Doc->Release();

	// uninitialize OLE libraries
	Uninit:
	CoUninitialize();
	return 0;
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****StdAfx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
//	HelloWorld.pch will be the pre-compiled header
//	stdafx.obj will contain the pre-compiled type information

#include "stdafx.h"

// TODO: reference any additional headers you need in STDAFX.H
// and not in this file

```

<!-- code block end -->    

<!-- code block begin -->

##### ****StdAfx.h:**
    
```
// stdafx.h : include file for standard system include files,
//  or project specific include files that are used frequently, but
//      are changed infrequently
//

#if !defined(AFX_STDAFX_H__59C6B829_CE1C_476C_B7F7_AADB9A4AC838__INCLUDED_)
#define AFX_STDAFX_H__59C6B829_CE1C_476C_B7F7_AADB9A4AC838__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#define WIN32_LEAN_AND_MEAN		// Exclude rarely-used stuff from Windows headers

#include <stdio.h>

// TODO: reference additional headers your program requires here

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_STDAFX_H__59C6B829_CE1C_476C_B7F7_AADB9A4AC838__INCLUDED_)

```

<!-- code block end -->