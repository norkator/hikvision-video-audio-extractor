# Hikvision video audio extractor

Hikvision recording video audio extractor app component for [Open Intelligence](https://github.com/norkator/open-intelligence)

What it does?
======

Downloads videos from your Hikvision camera, extracts audio from recording, saves audio under 
Open Intelligence output audio folder, keeps record of downloaded files on Open Intelligence 
records table. Repeat process between any given seconds specified at config.xml

To see more look at  [Open Intelligence Repository](https://github.com/norkator/open-intelligence)


Table of contents
=================
* [Setup](#setup)
    * [Development](#development)
    * [Production](#production)
* [Config.xml](#configxml)
* [License](#license)


Setup
======

Describes setup process for development and production sides.


Development
------

1. Contents of `HCNetSDK.zip` are unzipped under `VideoAudioExtractor\bin\Debug\bin`
2. Download ffmpeg windows builds: [https://ffmpeg.zeranoe.com/builds/](https://ffmpeg.zeranoe.com/builds/)
3. Unzip ffmpeg anywhere you like. Example `C:\ffmpeg`
4. Open system environmental variable aditor and add `C:\ffmpeg\bin` to your `System variables` -> `Path` 
but with your unzip location including `\bin` since ffmpeg executable is under that folder.
5. For me only after system restart ffmpeg started to work.


Production
------ 

No instructions since no releases yet.


config.xml
======

Sample config.xml file and options described.

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <appSettings>
        <processSleepSeconds>900</processSleepSeconds>
        <ipAddress>0.0.0.0</ipAddress>
        <port>8000</port>
        <username>camera_user</username>
        <password>camera_password</password>
        <dbConnectionString>Host=localhost;Username=username;Password=password;Database=intelligence</dbConnectionString>
        <outputLocationPath>C:\Users\SomeUser\Example\Path\</outputLocationPath>
        <deleteVideos>true</deleteVideos>
        <audioExportPath>C:\Users\SomeUser\Example\Path\</audioExportPath>
        <cameraName>CameraName</cameraName>
    </appSettings>
</configuration>
```

`processSleepSeconds` => Process run/repeat interval  
`ipAddress` => Hikvision camera ip address  
`port` => Camera port (default 8000)  
`username` => Username for camera, suggest creating unique other than admin.  
`password` => Camera created username password.  
`dbConnectionString` => Open Intelligence postgresql database connection details.  
`outputLocationPath` => Output path for videos downloaded.  
`deleteVideos` => Process main task is to extract audio from video but also video can kept.  
`audioExportPath` => Open intelligence output/audio folder or any other if used with some other purpose.   
`cameraName` => Camera name, meant to be same as Open-Intelligence config.ini specified camera name.


License
============
See LICENSE file.

