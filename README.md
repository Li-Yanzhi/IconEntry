## IconEntry(Entry with Icon) for Xamarin Forms

Add a pretty icon for your Entry control.

![IconEntry Screenshot](./art/Screenshot.png)

### Usage

In your iOS, Android, and Windows UWP projects call:
```
Xamarin.Forms.Init();//platform specific init
IconEntryRenderer.Init();
```

In you UWP projects, you should first merge the ResourceDictionary defined in plugin library into App.xaml.

```xaml
<Application
    x:Class="IconEntrySample.UWP.App"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:IconEntrySample.UWP"
    RequestedTheme="Light">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="ms-appx:///IconEntry.FormsPlugin.UWP/IconEntryStyle.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

Then in your Shared/PCL XAML page, add IconEntry control as below: 

```xaml
<StackLayout>
   <ie:IconEntry PlaceHolder="Please input your name" Icon="username.png" x:Name="UserNameEntry" />
   <ie:IconEntry PlaceHolder="Please input your password" Icon="password.png" x:Name="PasswordEntry" />
</StackLayout>
```


**Platform Support**

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Yes|iOS 7+|
|Xamarin.Android|Yes|API 10+|
|Windows 10 UWP|Yes|10+|
