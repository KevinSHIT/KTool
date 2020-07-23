@echo off

:: Name: IL Merge Script
:: File: merge.bat
:: Auth: KevinZonda
:: Date: 23/07/2020
:: Desc: A script merge dll & exe
:: Note: Only merge release
:: Refr: https://blog.walterlv.com/post/merge-assemblies-using-ilmerge.html

BuidTool\ILMerge\ILMerge.exe /ndebug /target:winexe /out:KTool\bin\Release\KTool.exe /log KTool\bin\Release\KTool.exe KTool\bin\Release\MaterialSkin.dll /targetplatform:v4
pause