cd "C:\Users\Joe\Documents\Visual Studio 2015\Projects\393_Food_Machine"
$targetPath = "C:\Users\Joe\Documents\Visual Studio 2015\Projects\393_Food_Machine\393_Food_Machine\Solutions\UnitTestMetrics\coverage.xml"
$outputPath = "C:\Users\Joe\Documents\Visual Studio 2015\Projects\393_Food_Machine\393_Food_Machine\Solutions\UnitTestMetrics\$(Get-Date -format dd.MM.yyyy_HH.mm.ss)"
New-Item -ItemType directory -Name $outputPath
& .\packages\ReportGenerator.2.5.1\tools\ReportGenerator.exe "-reports:$targetPath" "-targetdir:$outputPath"