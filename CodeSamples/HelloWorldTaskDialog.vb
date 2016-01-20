Imports Autodesk.Revit.UI
Imports Autodesk.Revit.DB
Namespace HelloWorld1
End Namespace

<Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Automatic)> _
Public Class HelloWorldTaskDialog
    Implements IExternalCommand
    Public Function Execute(ByVal commandData As ExternalCommandData, ByRef message As String, ByVal elements As ElementSet) As Result Implements IExternalCommand.Execute


        Dim mainDialog As New TaskDialog("Hello, Revit!")

        mainDialog.Show("Revit", "Hello World")
        Return Autodesk.Revit.UI.Result.Succeeded

    End Function
End Class
