OpenCoverDemo
=============

OpenCover is a is a code coverage tool for .NET. It can be used through a command line tool or a Visual Studio plugin.

##Using OpenCover through Visual Studio.
- Install Open Cover https://github.com/sawilde/opencover/releases
- Install Visual Studio UI extension http://visualstudiogallery.msdn.microsoft.com/6950a046-8919-4935-8542-c6f37956f688
- Run unit tests through OpenCover
*After installing the VS plugin there will be a new top level menu for OpenCover*
- After running the tests the coverage results are view-able in the OpenCover results tab

##Using OpenCover from the command line
###nstall nuget packages
- NUnit
- NUnit.Runners
- OpenCover
- ReportGenerator

Create a batch script to run the unit tests and generate the OpenCover report.
```
mkdir .\report
 
REM Run unit tests through OpenCover
.\packages\OpenCover.4.5.2506\OpenCover.Console.exe^
 -target:.\packages\NUnit.Runners.2.6.3\tools\nunit-console.exe^
 "-targetargs:.\Sample.Test\bin\Debug\Sample.Test.dll /noshadow"^
 -register:user^
 -filter:+[*]*^
 -output:.\report\output.xml
 
REM Generate the report.
.\packages\ReportGenerator.1.9.1.0\ReportGenerator.exe^
 -reports:.\report\output.xml^
 -targetdir:.\report^
 -reporttypes:Html,HtmlSummary^
 -filters:-MonitoredUndoTests*
 
REM Open the report
start .\report\index.htm
```

Running the batch file will generate a code coverage report and open the results in a browser tab.
