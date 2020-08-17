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
* [Database table](#database-table)
* [License](#license)


Setup
======

Describes setup process for development and production sides.


Development
------

1. Contents of `HCNetSDK.zip` are unzipped under `VideoAudioExtractor\bin\Debug\bin`
2. Download ffmpeg windows build: [https://ffmpeg.zeranoe.com/builds/](https://ffmpeg.zeranoe.com/builds/)
3. Unzip ffmpeg anywhere you like. Example `C:\ffmpeg`
4. Open system environmental variable editor and add `C:\ffmpeg\bin` to your `System variables` -> `Path` 
but with your unzip location including `\bin` since ffmpeg executable is under that folder.
5. For me only after system restart ffmpeg started to work. Try with shell `ffmpeg` if runs without errors.
6. Create config.xml: `...\VideoAudioExtractor\bin\Debug\netcoreapp3.1\config.xml` 
and use config.xml section example filled with your details.
7. Run application.


Production
------ 

1. Download latest release from releases section `HikvisionVideoAudioExtractor_...zip`
2. Unzip it anywhere you want.
3. Configure `config.xml` under `/HikvisionVideoAudioExtractor/netcoreapp3.1/` folder.
4. Download ffmpeg windows build: [https://ffmpeg.zeranoe.com/builds/](https://ffmpeg.zeranoe.com/builds/)
5. Unzip ffmpeg anywhere you like. Example `C:\ffmpeg`
6. Open system environmental variable editor and add `C:\ffmpeg\bin` to your `System variables` -> `Path` 
but with your unzip location including `\bin` since ffmpeg executable is under that folder.
7. For me only after system restart ffmpeg started to work. Try with shell `ffmpeg` if runs without errors.
8. Start using extractor via running `VideoAudioExtractor.exe`

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
        <extractVoiceOnly>true</extractVoiceOnly>
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
`extractVoiceOnly` => This enabled looks only for voice containing recordings and extracts them. 
`audioExportPath` => Open intelligence output/audio folder or any other if used with some other purpose.   
`cameraName` => Camera name, meant to be same as Open-Intelligence config.ini specified camera name.


Database table
======

If you run it without Open Intelligence then you need one table on your PostgreSQL database.
```sql
create table recordings
(
	id bigserial not null
		constraint recordings_pkey
			primary key,
	camera_name varchar(255),
	file_name varchar(255),
	start_time timestamp with time zone,
	end_time timestamp with time zone,
	"createdAt" timestamp with time zone default now(),
	"updatedAt" timestamp with time zone default now()
);

alter table recordings owner to postgres;
```
Insert one line into database having some `end_time` so process uses it as base for recording lookup.


License
============
See LICENSE file.

