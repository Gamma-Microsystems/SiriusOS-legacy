@echo off
:: WARNING WINDOWS SCRIPT IS LESS TESTED THAN FOR LINUX
:: If you have any problems with building report it on https://github.com/gamma63/SiriusOS/issues
cls
set NVER=6.0

cd sirius
dotnet build
xcopy bin\cosmos\Debug\net%NVER%\sirius.bin ..\sysroot\
cd ..

cd sirpe
dotnet build
xcopy bin\cosmos\Debug\net%NVER%\sirpe.bin ..\sysroot\
cd ..

:: TODO: Add packaging to .iso commands here

echo Done!
pause