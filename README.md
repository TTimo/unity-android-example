A Unity3D project embedded in an Android app - example and template

A few weeks ago I was researching how to embbed a Unity3D project into a larger, pre-existing Android application. I was working from some documentation online:

- http://forum.unity3d.com/threads/98315-Using-Unity-Android-In-a-Sub-View
- http://stackoverflow.com/questions/21851341/how-to-add-unityplayer-as-subview-in-android-layout

This is reasonably easy to do, but I didn't find any ready to go sample project and there are a lot of small details to figure out.

Contents:

- UnityProject: the Unity3D project
- UnityAndroidProject: the Android project we export from Unity3D, and configure as a library
- AndroidProject: our larger, pre-existing Android application

The workflow:

- Read the above links and documentation
- Load, explore and modify the Unity3D project
- Export the project to UnityAndroidExport (in Unity3D's Android build settings)

Every time you export from Unity3D you will need to do the following:

- Replace AndroidProject/assets/bin/ with the newly exported UnityAndroidExport/assets/bin/
- Open Eclipse/ADT with your two Android projects, UnityPlayerNativeActivity and AndroidProject
- Edit the settings for UnityPlayerNativeActivity, under the Android settings, make it a Library

