1. Go to portal.azure.com

1. Logon to your account

1. Create resource group named rg$yourSurname$devops

1. Click on Add button

1. Fill in all required fields
![image.png](/.attachments/image-5e289608-0196-4fc8-a7e0-db805bf9fcfd.png)
- In section Plan click on **Create New** and specify new name
- In section Sku and size click **Change size** and choose **Shared D1**

1. Click **Next:Monitoring**
![image.png](/.attachments/image-429d5c65-bb90-4bb3-91c0-aa8cea38c5c9.png)
- In section Application Insights click **Create new**

1. Click **Review and create**
1. Confirm, click **Create**

## **Change code**
1. Go to your new resource
1. Click on **Advaced tools** and **Go**
![image.png](/.attachments/image-0024d7f5-03af-49f0-9363-c8f5349c125b.png)

1. In KUDU console choose **CMD** under **Debug console**
![image.png](/.attachments/image-20dca8b5-6810-4992-877d-38f64286130c.png)
1. Go to site/wwwroot
1. Find file _hostingstart.html_ and click on pencil icon to edit the file
![image.png](/.attachments/image-227cadf8-fd90-4f2d-99bb-063715c64513.png)
1. Delete original content in file
Paste following code snippet

```
<html>
    <b>Hello, $your_name$</b>
</html>
```
1. Click on **Save** button
