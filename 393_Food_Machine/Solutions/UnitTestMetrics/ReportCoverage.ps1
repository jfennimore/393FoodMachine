﻿cd "C:\Users\Joe\Documents\Visual Studio 2015\Projects\393_Food_Machine"
$targetPath = "C:\Users\Joe\Documents\Visual Studio 2015\Projects\393_Food_Machine\393_Food_Machine\Solutions\UnitTestMetrics\coverage.xml"
$outputPath = "C:\Users\Joe\Documents\Visual Studio 2015\Projects\393_Food_Machine\393_Food_Machine\Solutions\UnitTestMetrics\$(Get-Date -format HH.mm.ss.dd.MM.yyyy)"
New-Item -ItemType folder -Name $outputPath
& .\packages\ReportGenerator.2.5.1\tools\ReportGenerator.exe "-reports:$targetPath" "-targetdir:$outputPath"