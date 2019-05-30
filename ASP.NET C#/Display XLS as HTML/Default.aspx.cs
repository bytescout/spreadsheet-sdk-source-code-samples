//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using Bytescout.Spreadsheet;

namespace DisplayXlsAsHtml
{
	public partial class _Default : System.Web.UI.Page
	{
		Spreadsheet _document = null;

		protected void Page_Load(object sender, EventArgs e)
		{
			String inputXlsFile = Server.MapPath("example.xls");

			// Open spreadsheet
			_document = new Spreadsheet();
			_document.LoadFromFile(inputXlsFile);

			Label1.Text = "\"Example.xls\" loaded";

			for (int i = 0; i < _document.Worksheets.Count ; i++)
			{
				DropDownList1.Items.Add(_document.Worksheets[i].Name);
			}
		}

		protected void ButtonGo_Click(object sender, EventArgs e)
		{
			String sheet = DropDownList1.SelectedItem.Text;

			if (!String.IsNullOrEmpty(sheet))
			{
				// Clear HTTP output
				Response.Clear();
				// Set the content type to HTML
				Response.ContentType = "text/HTML";
				// Save selected worksheet to output stream as HTML
				_document.Worksheets[sheet].SaveAsHTML(Response.OutputStream);

				Response.End();
			}
		}
	}
}
