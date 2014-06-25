Public Class MapMarker
    Public Sub New()
    End Sub

    Public Sub New(lat As Double, lng As Double, color As String, titleText As String, labelHtml As String, infoHtml As String)
        Me.Latitude = lat
        Me.Longitude = lng
        Me.Color = color
        Me.TitleText = titleText
        Me.LabelHtml = labelHtml
        Me.InfoHtml = infoHtml
    End Sub

    Public Property Latitude As Double
    Public Property Longitude As Double
    Public Property Color As String
    Public Property TitleText As String
    Public Property LabelHtml As String
    Public Property InfoHtml As String

    Public Function GetJs() As String
        Dim format = "createFixedMarkerOptions({1},{2},'{3}',{0}'{4}',{0}'{5}',{0}'{6}')"
        Dim js = String.Format(format,
            Environment.NewLine,
            Me.Latitude,
            Me.Longitude,
            Me.Color,
            Me.TitleText.Replace("'", "\'"),
            Me.LabelHtml.Replace("'", "\'"),
            Me.InfoHtml.Replace("'", "\'"))
        Return js
    End Function
End Class
