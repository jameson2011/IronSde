@echo off
cls


.paket\paket.exe restore
if errorlevel 1 (
  exit /b %errorlevel%
)


SET TARGET="All"

IF NOT [%1]==[] (set TARGET="%1")


".\packages\FAKE\tools\Fake.exe" "build.fsx" "target=%TARGET%" --removeLegacyFakeWarning
