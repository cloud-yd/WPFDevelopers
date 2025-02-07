﻿namespace Microsoft.Expression.Media
{
    internal interface IArcGeometrySourceParameters : IGeometrySourceParameters
    {
        double StartAngle { get; }
        double EndAngle { get; }
        double ArcThickness { get; }
        UnitType ArcThicknessUnit { get; }
    }
}
