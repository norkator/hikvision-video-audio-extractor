# hikvision-video-audio-extractor

Hikvision recording video audio extractor app for Open Intelligence

<b>In progress</b>


Setup
======

Development
------

Contents of `HCNetSDK.zip` are unzipped under `VideoAudioExtractor\bin\Debug\bin`

Todo: explain ffmpeg installation process including path variable, restart machine part etc.

ffmpeg windows builds: [https://ffmpeg.zeranoe.com/builds/](https://ffmpeg.zeranoe.com/builds/)

Production
------ 



config.xml
======

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <appSettings>
        <processSleepSeconds>10</processSleepSeconds>
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

Todo: explain contents
