//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;


namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open existing Spreadsheets
            Spreadsheet document1 = new Spreadsheet();
	document1.LoadFromFile("input.xls");

            // Get first cell value
            object value1 = document1.Worksheet(0).Cell("A1").Value;
            // Get another cell value
            object value2 = document1.Worksheet(0).Cell("B1").Value;

            // Swap them
            object value3;
            value3 = value2;
            value2 = value1;
            value1 = value3;

            document1.Worksheet(0).Cell("A1").Value = value1;
            document1.Worksheet(0).Cell("B1").Value = value2;

            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            // Save document
            document1.SaveAs("Output.xls");

            // Close Spreadsheet
            document1.Close();

            // open generated XLS document in default program
            Process.Start("Output.xls");

        }
    }
}
