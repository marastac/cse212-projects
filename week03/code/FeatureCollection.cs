public class FeatureCollection
{
    // Una lista de "features", donde cada "feature" representa un terremoto.
    public List<Feature> Features { get; set; }
}

public class Feature
{
    // La propiedad "properties" contiene los detalles de cada terremoto.
    public Properties Properties { get; set; }
}

public class Properties
{
    // La magnitud del terremoto.
    public double? Mag { get; set; }

    // La ubicación del terremoto.
    public string Place { get; set; }
}