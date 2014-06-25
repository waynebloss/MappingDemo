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
    Friend Event ErrorOccurred As EventHandler
    ''' <summary>
    ''' Event that is raised when the mapping javascript changes the Geocoding position.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Event GeocodePositionUpdated As EventHandler

    ''' <summary>
    ''' Contains any error message set by the mapping javascript.
    ''' </summary>
    ''' <remarks></remarks>
    Friend ErrorMessage As String
    ''' <summary>
    ''' Contains any Geocoding Latitude that was set by the mapping javascript.
    ''' </summary>
    ''' <remarks></remarks>
    Friend GeocodeLat As Double
    ''' <summary>
    ''' Contains any Geocoding Longitude that was set by the mapping javascript.
    ''' </summary>
    ''' <remarks></remarks>
    Friend GeocodeLng As Double

#Region "Methods exposed to GoogleMapsHtml Javascript"

    Public Sub setError(errorMessage As String)
        Me.ErrorMessage = errorMessage
        RaiseEvent ErrorOccurred(Me, EventArgs.Empty)
    End Sub

    Public Sub setGeocodePosition(lat As Double, lng As Double)
        Me.GeocodeLat = lat
        Me.GeocodeLng = lng
        RaiseEvent GeocodePositionUpdated(Me, EventArgs.Empty)
    End Sub

#End Region

End Class
