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
