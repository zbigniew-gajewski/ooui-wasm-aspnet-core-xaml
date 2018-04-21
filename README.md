# ooui-wasm-aspnet-core-xaml
An simple example of the usage of [Ooui](https://github.com/praeclarum/Ooui) [Wasm](https://github.com/praeclarum/Ooui/wiki/Xamarin.Forms-with-Web-Assembly) framework with AspNetCore server and using XAML based views.

The example is based on a great [Ooui Framework](https://github.com/praeclarum/Ooui) and its [Ooui.Wasm](https://github.com/praeclarum/Ooui/wiki/Xamarin.Forms-with-Web-Assembly) part. The only difference is that the application is hosted with AspNetCore server (instead of [dotnet-serve](https://github.com/natemcmaster/dotnet-serve)), XAML based views (instead of hard coded UI controls) and binding (simiple MVVM).

The solution consists of two projects:

* **OouiTestWeb** - Asp Net Core application (host server)
* **OouiTestXamlApp** - 'client siede' app where UI is composed using XAML views (Xamarin.Forms)

Both projects are independend (there is no reference between them).
The idea is to copy necessary files from OouiTestXamlApp project to OouiTestWeb\wwwroot folder after each build of OouiTestXamlApp (see post built events). To be able to serve Ooui.Wasm on AspNetCore server, some simple changes have been made in Startup class (see Configure method).

## How to use it

* git clone https://github.com/zbigniew-gajewski/ooui-wasm-aspnet-core-xaml.git
* open OouiTest.sln in **Visual Studio 2017**
* in Visual Studio (right click):
  * restore nuget packages
  * rebuild solution
* from command line:
  * **cd** *ooui-wasm-aspnet-core-xaml-test*
  * **cd** *OouiTestWeb*
  * **dotnet run**
* in ***OouiTestXamlApp*** project change the UI and build OouiTestXamlApp project only (server side will not compile since it is running all the time)
* run the browser and go to: ***localhost:60112***

You can keep server running and browser opened. Just refresh browser each time the client application will finish successful compilation.
