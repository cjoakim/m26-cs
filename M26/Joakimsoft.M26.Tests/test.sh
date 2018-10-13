#!/bin/bash

echo 'building...'
dotnet build

echo 'executing tests...'
dotnet test
