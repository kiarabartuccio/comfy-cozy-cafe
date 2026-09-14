@echo off
setlocal
cd /d "%~dp0"

set "CAFE_MSBUILD="
for /f "usebackq tokens=*" %%i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe 2^>nul`) do set "CAFE_MSBUILD=%%i"

if not defined CAFE_MSBUILD (
    echo Visual Studio Build Tools were not found.
    echo Opening the solution in Visual Studio...
    start "" "Comfy Cozy Cafe.sln"
    exit /b 0
)

echo Building Comfy Cozy Cafe...
"%CAFE_MSBUILD%" "Comfy Cozy Cafe.sln" /restore /t:Build /p:Configuration=Debug /m
if errorlevel 1 (
    echo.
    echo Build failed. Open the solution in Visual Studio to view the errors.
    pause
    exit /b 1
)

echo Starting Comfy Cozy Cafe...
start "" "Comfy Cozy Cafe\bin\Debug\Comfy Cozy Cafe.exe"
endlocal
