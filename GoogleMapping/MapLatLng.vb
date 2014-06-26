Public Class MapLatLng

    Property Lat As Double?
    Property Lng As Double?

    Public Sub New()

    End Sub

    Public Sub New(lat As Double?, lng As Double?)
        Me.Lat = lat
        Me.Lng = lng
    End Sub

    Public Function GetJs() As String
        Return "createLatLng(" + Lat.GetValueOrDefault().ToString() + ", " + Lng.GetValueOrDefault().ToString() + ")"
    End Function

End Class
