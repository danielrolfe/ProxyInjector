# ProxyInjector
.NET Proxy Injector - Implements IWebProxy so that the DLL can be dropped into the same folder as your application and with some config changes will provide proxy configuration including credentials allowing the application to run behind a proxy.

I built this to use in conjunction with Sitecore Install Assistant (SIA) but it should work with any .NET application. Currently it does not support use behind a proxy so this DLL and the config changes below will work around this.

After downloading the Sitecore 9.2 (or greater) install, modify the setup.exe.config and add the following config. Copy the DLL built by the code in this repo to the same folder as the setup.exe and run as administrator.

```xml
<system.net>
<defaultProxy enabled="true" useDefaultCredentials="false">
<module type = "ProxyInjector.ProxyInjector, ProxyInjector" />
</defaultProxy>
</system.net>
```
