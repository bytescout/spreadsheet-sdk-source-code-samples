## How to convert XLSX to SQL server in VB.NET using ByteScout Spreadsheet SDK

### Write code in VB.NET to convert XLSX to SQL server with this step-by-step tutorial

This sample source code below will demonstrate you how to convert XLSX to SQL server in VB.NET. ByteScout Spreadsheet SDK is the SDK component for writing, reading, modifying and calculating Excel and CSV spreadsheets. Can calculate and reculculate formulas with Excel installed. You may import or export data to and from CSV, XML, JSON. Supports export to databases, arrays, streams and you can use it to convert XLSX to SQL server with VB.NET.

This code snippet below for ByteScout Spreadsheet SDK works best when you need to quickly convert XLSX to SQL server in your VB.NET application. In order to implement the functionality, you should copy and paste this code for VB.NET below into your code editor with your app, compile and run your application. Further enhancement of the code will make it more vigorous.

Download free trial version of ByteScout Spreadsheet SDK from our website with this and other source code samples for VB.NET.

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

##### ****ExportToSQLServer.VS2005.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{10E449F0-55BE-4158-87AA-1F81BC8933B6}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ExportToSQLServer</RootNamespace>
    <AssemblyName>ExportToSQLServer</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.Spreadsheet, Version=2.2.0.307, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Content Include="Hello_world.xlsx">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ExportToSQLServer.VS2008.vbproj:**
    
```
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{10E449F0-55BE-4158-87AA-1F81BC8933B6}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ExportToSQLServer</RootNamespace>
    <AssemblyName>ExportToSQLServer</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.Spreadsheet, Version=2.2.0.307, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Content Include="Hello_world.xlsx">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ExportToSQLServer.VS2010.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{10E449F0-55BE-4158-87AA-1F81BC8933B6}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ExportToSQLServer</RootNamespace>
    <AssemblyName>ExportToSQLServer</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.Spreadsheet, Version=2.2.0.307, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Content Include="Hello_world.xlsx">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports Bytescout.Spreadsheet
Imports System.Data.SqlClient

Class Program
    Friend Shared Sub Main(args As String())
        Try
            ' MODIFY THE CONNECTION STRING WITH YOUR CREDENTIALS!!!
            Dim connectionString As String = "Data Source=localhost;Initial Catalog=master;Integrated Security=true;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Drop test database if exists
                ExecuteQueryWithoutResult(connection, "IF DB_ID ('XlsxTests') IS NOT NULL DROP DATABASE XlsxTests")
                ' Create empty database
                ExecuteQueryWithoutResult(connection, "CREATE DATABASE XlsxTests")
                ' Switch to created database
                ExecuteQueryWithoutResult(connection, "USE XlsxTests")
                ' Create a table for XLSX data
                ExecuteQueryWithoutResult(connection, "CREATE TABLE XlsxTest (Name VARCHAR(40), FullName VARCHAR(255))")

                ' Load XLSX document
                Using document As New Spreadsheet()
                    document.LoadFromFile("Hello_world.xlsx")
                    Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

                    For row As Integer = 0 To worksheet.UsedRangeRowMax
                        Dim insertCommand As [String] = String.Format("INSERT XlsxTest VALUES('{0}','{1}')", worksheet.Cell(row, 0).Value, worksheet.Cell(row, 1).Value)
                        ExecuteQueryWithoutResult(connection, insertCommand)
                    Next
                End Using

                ' Check the data successfully exported
                Using command As New SqlCommand("SELECT * from XlsxTest", connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader IsNot Nothing Then
                        Console.WriteLine()
                        Console.WriteLine("Exported XLSX data:")
                        Console.WriteLine()

                        While reader.Read()
                            Console.WriteLine([String].Format("{0}  |  {1}", reader(0), reader(1)))
                        End While
                    End If
                End Using

                Console.WriteLine()
                Console.WriteLine("Press any key.")
                Console.ReadKey()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.ReadKey()
        End Try
    End Sub

    Private Shared Sub ExecuteQueryWithoutResult(connection As SqlConnection, query As String)
        Using command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class

```

<!-- code block end -->