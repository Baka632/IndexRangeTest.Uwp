# IndexRangeTest.Uwp
This is a sample project for using IndexRange in UWP (even in Windows 10 Mobile)

# Key steps
1. Set ```TargetPlatformVersion``` to 16299 (Windows 10 Fall Creators Update)
2. Modify ```Package.appxmanifest```, add a new ```TargetDeviceFamily``` in Dependencies, like this:
```
<Dependencies>
  <TargetDeviceFamily Name="Windows.Universal" MinVersion="10.0.0.0" MaxVersionTested="10.0.0.0" />
  <!-- Modify MinVersion to suit your need-->
  <TargetDeviceFamily Name="Windows.Mobile" MinVersion="10.0.10240.0" MaxVersionTested="10.0.10240.0" />

</Dependencies>
```

Note: make sure you don't use apis/libraries that don't support your system version.

By doing these steps, these problems can't be warned in compile-time.