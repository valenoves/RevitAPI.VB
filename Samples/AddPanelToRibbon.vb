Imports Autodesk.Revit.UI
Imports Autodesk.Revit.DB
Imports System.Windows.Media.Imaging


Public Class AddPanelToRibbon
    Implements Autodesk.Revit.UI.IExternalApplication

    Public Function OnStartup(ByVal application As UIControlledApplication) As Result Implements IExternalApplication.OnStartup
        Dim Myribbon As RibbonPanel
        Myribbon = application.CreateRibbonPanel("NewRibbonPanel")


        Dim pushButton As PushButton = Myribbon.AddItem(New PushButtonData("HelloWorld", "HelloWorld", "C:\SamplesAPI\HelloWorld1\HelloWorld1\bin\Debug\HelloWorld1.dll", "HelloWorld1.Class1"))

        Dim uriImage As Uri
        uriImage = New Uri("C:\Program Files\Autodesk\Revit Content 2015 English\Help\en-US\WBH\images\GUID-D90F42BA-B68D-40D5-9CED-90E96EBF3133-low.png")
        Dim largeImage As BitmapImage
        largeImage = New BitmapImage(uriImage)
        pushButton.LargeImage = largeImage


        Return Result.Succeeded
    End Function

    Public Function OnShutdown(ByVal application As UIControlledApplication) As Result Implements IExternalApplication.OnShutdown
        Return Result.Succeeded
    End Function

End Class
