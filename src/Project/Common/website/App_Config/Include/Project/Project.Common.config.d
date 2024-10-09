﻿<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <sc.variable name="rootHostName" value="adaniair" />
    <settings>
      <setting name="Analytics.CookieDomain" value="$(rootHostName)" />
      <setting name="Login.BackgroundImageUrl" value="login/Helixbase_Wallpaper.jpg" />
      <setting name="Login.DisableLicenseInfo" value="false" />
      <setting name="Preview.DefaultSite">
        <patch:attribute name="value" value="adaniair" />
      </setting>
    </settings>
  </sitecore>
</configuration>