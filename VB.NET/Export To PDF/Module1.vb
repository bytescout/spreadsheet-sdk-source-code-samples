'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()
        ' Open Spreadsheet
        Dim document As New Spreadsheet()
		document.LoadFromFile("SimpleReport.xls")

		' add image
    	document.Workbook.Worksheets(0).Pictures.Add(0, 5, "image.jpg")

        ' remove output file if already exists
        If File.Exists("Output.pdf") Then
            File.Delete("Output.pdf")
        End If

        ' Export to PDF
		document.SaveAsPDF("Output.pdf")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.pdf")

    End Sub

End Module
