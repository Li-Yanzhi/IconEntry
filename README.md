## IconEntry(Entry with Icon) for Xamarin Forms

Add a pretty icon for your Entry control.

![IconEntry Screenshot](./art/Screenshot.png)

### Usage

```xaml
<StackLayout>
   <ie:IconEntry PlaceHolder="Please input your name" Icon="username.png" />
   <ie:IconEntry PlaceHolder="Please input your password" Icon="password.png" />
</StackLayout>
```

**Platform Support**

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Yes|iOS 7+|
|Xamarin.Android|Yes|API 10+|
|Windows 10 UWP|Yes|10+|

**UWP Project**

In UWP Project, you should first merge the ResourceDictionary defined in plugin library into App.xaml.

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
