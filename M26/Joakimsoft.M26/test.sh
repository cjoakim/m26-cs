#!/bin/bash

echo '========== Building Project ...'
dotnet build

cd ../Joakimsoft.M26.Tests/

echo '========== Building Tests ...'
dotnet build

echo '========== Executing Tests ...'
dotnet test

cd ../Joakimsoft.M26/
