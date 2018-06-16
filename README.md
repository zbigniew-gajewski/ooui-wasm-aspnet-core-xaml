# ooui-wasm-aspnet-core-xaml
An simple example of the usage of [Ooui](https://github.com/praeclarum/Ooui) [Wasm](https://github.com/praeclarum/Ooui/wiki/Xamarin.Forms-with-Web-Assembly) framework with AspNetCore server and XAML based views.

The example is based on a great [Ooui Framework](https://github.com/praeclarum/Ooui) and its [Ooui.Wasm](https://github.com/praeclarum/Ooui/wiki/Xamarin.Forms-with-Web-Assembly) part. The only difference is that the application is hosted with AspNetCore server (instead of [dotnet-serve](https://github.com/natemcmaster/dotnet-serve)), XAML based views (instead of hard coded UI controls) and binding (simiple MVVM).

The solution consists of two projects:

* **OouiTestWeb** - Asp Net Core application (host server)
* **OouiTestXamlApp** - 'client siede' app where UI is composed using XAML views (Xamarin.Forms)

Both projects are independend (there is no reference between them). Insead of wwwroot folder, configuration of the server takes output from \OouiTestXamlApp\bin\Debug\netstandard2.0\dist folder(see post Setup.cs -> Configure method).

## How to use it

* git clone https://github.com/zbigniew-gajewski/ooui-wasm-aspnet-core-xaml.git
* open OouiTest.sln in **Visual Studio 2017**
* in Visual Studio (right click):
  * restore nuget packages
  * rebuild solution
* from command line:
  * **cd** *cd ooui-wasm-aspnet-core-xaml\OouiTestWeb*
  * **dotnet run** - see the **[port]** server is listening on (shoul be 52222)
* in ***OouiTestXamlApp*** project change the UI and build OouiTestXamlApp project only (server side will not compile since it is running all the time)
* run the browser and go to: ***localhost:[port]***

You can keep server running and browser opened. Just refresh browser each time the client application will finish successful compilation.
