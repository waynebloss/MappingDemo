Public Class MainView

    Public Sub New()

        InitializeComponent()

        ' Code to setup a WebBrowser control for mapping.
        scriptObj = New MapScriptingObject()
        browser.ObjectForScripting = scriptObj

        ' Uncomment one of the following calls for the demo that you want to be the default. - WB

        'mainTbShowMapForGeocodingBtn_Click(mainTbShowMapForGeocodingBtn, EventArgs.Empty)
        'mainTbShowMapWithMarkersBtn_Click(mainTbShowMapWithMarkersBtn, EventArgs.Empty)
        mainTbShowMapForDirectionsBtn_Click(mainTbShowMapForDirectionsBtn, EventArgs.Empty)

    End Sub

    Private WithEvents scriptObj As MapScriptingObject

    Private Sub fileMnuExit_Click(sender As Object, e As EventArgs) Handles fileMnuExit.Click
        Close()
    End Sub

    Private Sub helpMnuAbout_Click(sender As Object, e As EventArgs) Handles helpMnuAbout.Click
        MessageBox.Show(Text)
    End Sub

    Private Sub mainTbShowMapForGeocodingBtn_Click(sender As Object, e As EventArgs) Handles mainTbShowMapForGeocodingBtn.Click
        ' Code to demonstrate geocoding in the WebBrowser control.
        Dim map = New MapForGeocoding()
        map.FindByAddress = "55 Gilbert St N, Tinton Falls, NJ 07701"
        browser.DocumentText = map.GetHtml()
    End Sub

    Private Sub mainTbShowMapWithMarkersBtn_Click(sender As Object, e As EventArgs) Handles mainTbShowMapWithMarkersBtn.Click
        ' Code to demonstrate displaying one or more markers in the WebBrowser control.
        Dim map = New MapWithMarkers()
        map.CenterLatLng = New MapLatLng(40.42951, -86.87892)
        map.MarkerOptions = {
            New MapMarker(40.42951, -86.87892, "green", "TRI-US REHABILITATION CENTER",
                "1", "1 TRI-US REHABILITATION CENTER (7) <br/>1700 WILSON ST<br/> LAFAYETTE "),
            New MapMarker(40.43385, -86.84887, "red", "HOME RUN BALL PARK",
                "8", "8 HOME RUN BALL PARK (8) <br/>1676 PINE LANE<br/> LAFAYETTE ")
        }
        browser.DocumentText = map.GetHtml()
    End Sub

    Private Sub mainTbShowMapForDirectionsBtn_Click(sender As Object, e As EventArgs) Handles mainTbShowMapForDirectionsBtn.Click
        Dim map = New MapForDirections()
        map.OriginLatLng = New MapLatLng(40.153826, -74.22001)
        map.DestinationLatLng = New MapLatLng(40.327374, -74.075921)
        browser.DocumentText = map.GetHtml()
    End Sub

    Private Sub scriptObj_DirectionsCompleted(sender As Object, e As MapEventArgs) Handles scriptObj.DirectionsCompleted
        For Each item In e.DirectionsResult
            Debug.Print(item.Instructions)
        Next
    End Sub

    Private Sub scriptObj_ErrorOccurred(sender As Object, e As MapEventArgs) Handles scriptObj.ErrorOccurred
        mainStatLbl.Text = "Error: " + e.ErrorMessage
    End Sub

    Private Sub scriptObj_GeocodingCompleted(sender As Object, e As MapEventArgs) Handles scriptObj.GeocodingCompleted
        mainStatLbl.Text = "New Position: " + CStr(e.GeocodeResult.Lat) + ", " + CStr(e.GeocodeResult.Lng)
    End Sub

End Class
