﻿namespace FormsPinViewSampleFSharp.Core

open FormsPinViewSampleFSharp.Core.Views
open Xamarin.Forms
open Xamarin.Forms.Xaml

[<assembly: XamlCompilation(XamlCompilationOptions.Compile)>]
do ()

type App() =
    inherit Application()
    do
        let rootPage = NavigationPage(MainPage())
        let nextPage = PinAuthPage()
        rootPage.Navigation.PushAsync nextPage |> ignore
        base.MainPage <- rootPage

    override this.OnStart() =
        System.Diagnostics.Debug.WriteLine "OnStart"

    override this.OnSleep() =
        System.Diagnostics.Debug.WriteLine "OnSleep"

    override this.OnResume() =
        System.Diagnostics.Debug.WriteLine "OnResume"