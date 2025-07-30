using System;
using System.Collections.Generic;

public class FeatureCollection
{
    public List<Feature> Features { get; set; }
}

public class Feature
{
    public FeatureProperties Properties { get; set; }
}

public class FeatureProperties
{
    public DateTime Time { get; set; }
}
