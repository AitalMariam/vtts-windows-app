param([string]$msg, [string]$brench = "master")

if (!$msg) { 
Write-Host "Parameter : msg is null" 
exit
}

echo "-"
write-host "(- Code synchronization with master-)" -foreground "magenta"
echo "-"
git status


echo "-"
write-host "(- syn GenericWinFormProject-)" -foreground "magenta"
echo "-"
cd .\GenericWinFormProject
git status
git add .
git commit -m "$msg"
git push
cd ..

echo "-"
echo "--GenericWinFormTest ynchronization with master--"
echo "-"

cd .\GenericWinFormTest
git status
git add .
git commit -m "$msg"
git push
cd ..

echo "-"
echo "----Commit & Push--"
echo "-"
git status
git add .
git commit -m "$msg"
git push