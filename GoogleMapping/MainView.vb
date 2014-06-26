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
        map.CenterLatitude = 40.42951
        map.CenterLongitude = -86.87892
        map.MarkerOptions = {
            New MapMarker(40.42951, -86.87892, "green", "TRI-US REHABILITATION CENTER",
                "1", "1 TRI-US REHABILITATION CENTER (7) <br/>1700 WILSON ST<br/> LAFAYETTE "),
            New MapMarker(40.43385, -86.84887, "red", "HOME RUN BALL PARK",
                "8", "8 HOME RUN BALL PARK (8) <br/>1676 PINE LANE<br/> LAFAYETTE ")
        }
        browser.DocumentText = map.GetHtml()
    End Sub

    Private Sub scriptObj_ErrorOccurred() Handles scriptObj.ErrorOccurred
        mainStatLbl.Text = "Error: " + scriptObj.ErrorMessage
    End Sub

    Private Sub scriptObj_GeocodePositionUpdated() Handles scriptObj.GeocodePositionUpdated
        mainStatLbl.Text = "New Position: " + CStr(scriptObj.GeocodeLat) + ", " + CStr(scriptObj.GeocodeLng)
    End Sub

    Private Sub mainTbShowMapForDirectionsBtn_Click(sender As Object, e As EventArgs) Handles mainTbShowMapForDirectionsBtn.Click
        browser.DocumentText = My.Resources.GoogleMapsHtml
    End Sub
End Class
