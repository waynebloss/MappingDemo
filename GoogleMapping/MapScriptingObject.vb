Imports System.Runtime.InteropServices

''' <summary>
''' Class for the object that is exposed to javascript in the WebBrowser control used for mapping.
''' </summary>
''' <remarks></remarks>
<ComVisible(True)>
Public Class MapScriptingObject

    ''' <summary>
    ''' Event that is raised when the mapping javascript has an error.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Event ErrorOccurred As EventHandler(Of MapEventArgs)
    ''' <summary>
    ''' Event that is raised when the mapping javascript changes the Geocoding position.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Event GeocodingCompleted As EventHandler(Of MapEventArgs)
    ''' <summary>
    ''' Event that is raised when the javascript has completed a request for directions.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Event DirectionsCompleted As EventHandler(Of MapEventArgs)

    ''' <summary>
    ''' Contains the results of a request for directions.
    ''' </summary>
    ''' <remarks></remarks>
    Private DirectionsSteps As List(Of MapDirectionsStep)

#Region "Methods exposed to GoogleMapsHtml Javascript"

    Public Sub setError(errorMessage As String)
        Dim e = New MapEventArgs With {.ErrorMessage = errorMessage}
        RaiseEvent ErrorOccurred(Me, e)
    End Sub

    Public Sub setGeocodingResult(lat As Double, lng As Double)
        Dim e = New MapEventArgs With {.GeocodeResult = New MapLatLng(lat, lng)}
        RaiseEvent GeocodingCompleted(Me, e)
    End Sub

    Public Sub setDirectionsResult(instructions As String)
        Dim item = New MapDirectionsStep With {.Instructions = instructions}
        If DirectionsSteps Is Nothing Then
            DirectionsSteps = New List(Of MapDirectionsStep)()
        End If
        DirectionsSteps.Add(item)
    End Sub

    Public Sub setDirectionsCompleted()
        If DirectionsSteps Is Nothing Then Exit Sub

        Dim e = New MapEventArgs With {.DirectionsResult = DirectionsSteps}
        DirectionsSteps = Nothing
        RaiseEvent DirectionsCompleted(Me, e)
    End Sub

#End Region

#Region "Utility Methods for dealing with Javascript"

    Public Shared Function EscapeSingleQuotes(value As String) As String
        Return value.Replace("'", "\'")
    End Function

#End Region

End Class
