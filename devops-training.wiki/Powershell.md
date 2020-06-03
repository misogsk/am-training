## **Prerequisites**
1. [Install Powershell core](https://github.com/PowerShell/PowerShell/releases)
1. [Install Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest)

## **Powershell**
Perform start or stop of Virtual Machine in Azure

1. Open PowerShell
1. Download file StartStop.ps1
1. Start VM 
1. Provide subscription name, VM name, respurce group and action type
 (start/stop string)
1. When prompt login to your account

## **Azure CLI**
### Start VM

1. Open powershell/cmd
2. Type `az login`, in new browser window login to you Azure account
3. Type `az  vm start --resource-group $yourgroupName--name $yourVmName` to start machine

### Stop VM

1. Open powershell/cmd
1. Type `az login`, in new browser window login to you Azure account
1. Type `az  vm stop--resource-group $yourgroupName--name $yourVMName` to stop your machine
