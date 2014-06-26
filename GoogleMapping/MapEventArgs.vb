Public NotInheritable Class MapEventArgs
    Inherits EventArgs

    Property ErrorMessage As String

    Property GeocodeResult As MapLatLng

    Property DirectionsResult As List(Of MapDirectionsStep)

End Class
