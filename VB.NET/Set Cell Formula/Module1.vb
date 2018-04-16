'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()

        ' add new worksheet
        Dim Sheet As Worksheet = document.Workbook.Worksheets.Add("FormulaDemo")

        ' headers to indicate purpose of the column
        Sheet.Cell("A1").Value = "Formula (as text)"
        ' set A column width
        Sheet.Columns(0).Width = 250

        Sheet.Cell("B1").Value = "Formula (calculated)"
        ' set B column width
        Sheet.Columns(1).Width = 250

        ' write formula as text 
        Sheet.Cell("A2").Value = "7*3+2"
        ' write formula as formula
        Sheet.Cell("B2").Value = "=7*3+2"


        ' remove output file if already exists
        If File.Exists("Output.xls") Then
            File.Delete("Output.xls")
        End If

        ' Save document
        document.SaveAs("Output.xls")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xls")

    End Sub

End Module
