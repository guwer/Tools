Param(
	[Parameter(Mandatory=$True)]
    [string]$solutionPath,
    [Parameter(Mandatory=$True)]
    [string]$coverageFileName,
    [Parameter(Mandatory=$True)]
    [string]$coverageFilePath,
    [Parameter(Mandatory=$True)]
    [string]$outputPath
)

#Add to env variables or provide absolute path
CoverageToXml.exe $solutionPath $coverageFileName

#Add to env variables or provide absolute path
ReportGenerator.exe "-reports:$coverageFilePath" "-targetdir:$outputPath" "-assemblyfilters:+*driveservices*;-*test*"