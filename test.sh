#!/usr/bin/env ksh
TESTNAME=$1
dotnet test --filter FullyQualifiedName~$TESTNAME -v:detailed

