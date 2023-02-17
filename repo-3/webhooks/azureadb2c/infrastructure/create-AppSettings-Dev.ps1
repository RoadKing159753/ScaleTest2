$prevPwd = $PWD; Set-Location -ErrorAction Stop -LiteralPath $PSScriptRoot

. "./../../../infrastructure/scripts/create-appSettings.ps1"

$APPCONFIG_NAME = "apetitoAppSettings-development"; 
$KEYVAULT_NAME = "apetitoKeyVault-dev";

CreateSettingWithExistingKeyVaultEntry "apetito:meinapetito:webhooks:azureadb2c:api:AzureADB2C:AppRegistration:PortalManagement:ClientID" "apetito-AzureADB2C-AppRegistration-PortalManagement-ClientId"
CreateSettingWithExistingKeyVaultEntry "apetito:meinapetito:webhooks:azureadb2c:api:AzureADB2C:AppRegistration:PortalManagement:ClientSecret" "apetito-AzureADB2C-AppRegistration-PortalManagement-ClientSecret"
CreateSettingWithExistingKeyVaultEntry "apetito:meinapetito:webhooks:azureadb2c:api:AzureADB2C:AppRegistration:PortalApi:ObjectId" "apetito-AzureADB2C-AppRegistration-PortalApi-ObjectId"
CreateSettingWithExistingKeyVaultEntry "apetito:meinapetito:webhooks:azureadb2c:api:AzureADB2C:TenantID" "apetito-AzureADB2C-TenantId"
CreateSettingWithExistingKeyVaultEntry "apetito:meinapetito:webhooks:azureadb2c:api:AzureADB2C:Domain" "apetito-AzureADB2C-Domain"

CreateSettingWithExistingKeyVaultEntry "apetito:meinapetito:webhooks:azureadb2c:api:meinapetito:secret" "apetito-meinapetito-portal-api-AzureADB2C-PostRegistrationWebhook-Secret"


$prevPwd | Set-Location