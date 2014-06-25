﻿Public Class MapWithMarkers

    Const DefaultZoomAmount As Integer = 12
    Const DefaultMapType As String = "google.maps.MapTypeId.ROADMAP"

    Property CenterLatitude As Double?
    Property CenterLongitude As Double?
    Property MapType As String
    Property MarkerOptions As IEnumerable(Of MapMarker)
    Property ZoomLevel As Integer?

    Public Function GetHtml() As String
        ' CONSIDER: If center lat/lng was not specified, maybe you'll want to get them from the first marker. - WB
        Dim zoom = Me.ZoomLevel.GetValueOrDefault(DefaultZoomAmount)
        Dim centerLat = Me.CenterLatitude.GetValueOrDefault()
        Dim centerLng = Me.CenterLongitude.GetValueOrDefault()
        Dim mapTypeId = If(Me.MapType, DefaultMapType)
        Dim markersJs = ""
        If Me.MarkerOptions IsNot Nothing Then
            Dim markers = Me.MarkerOptions.Select(Function(mo) mo.GetJs()).ToArray()
            markersJs = String.Join("," + Environment.NewLine, markers)
        End If
        Dim lines As String() = {
            "// Javascript generated by MapWithMarkers.GetHtml:",
            "var map = new MapWithMarkers();",
            "map.centerLat = 40.42951;",
            "map.centerLng = -86.87892;",
            "map.markerOptions = [",
            markersJs,
            "];",
            "map.initialize();"
        }
        Dim js = String.Join(Environment.NewLine, lines)
        Dim html = My.Resources.GoogleMapsHtml.Replace("##JAVASCRIPT-TO-INITIALIZE-MAPPING##", js)
        Return html
    End Function

End Class
