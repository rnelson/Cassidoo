#!/usr/bin/env ksh
TESTNAME=$1
dotnet test --nologo --filter FullyQualifiedName~$TESTNAME -v:detailed --consoleLoggerParameters:ErrorsOnly