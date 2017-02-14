param([string]$msg, [string]$brench = "master")
$Tab = [char]9

if (!$msg) { 
Write-Host "Parameter : msg is null" 
exit
}

echo "-"
write-host "(- Code synchronization with master-)" -foreground "magenta"
echo "-"

echo "[vtts git status ]:"
git status
Start-Sleep -s 5

echo "-"
echo "[-- syn GenericWinFormProject --]"
echo "-"
cd .\GenericWinFormProject
git status
git add .
git commit -m "$msg"
git push
Start-Sleep -s 5
cd ..

echo "-"
echo "--GenericWinFormTest ynchronization with master--"
echo "-"

cd .\GenericWinFormTest
git status
git add .
git commit -m "$msg"
git push
Start-Sleep -s 5
cd ..

echo "-"
echo "----Commit & Push--"
echo "-"
git status
git add .
git commit -m "$msg"
git push
Start-Sleep -s 5