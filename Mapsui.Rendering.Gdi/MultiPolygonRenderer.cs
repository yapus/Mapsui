﻿// Copyright 2005, 2006 - Morten Nielsen (www.iter.dk)
// Copyright 2010 - Paul den Dulk (Geodan) - Adapted SharpMap for Mapsui
//
// This file is part of Mapsui.
// Mapsui is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// Mapsui is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with Mapsui; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

using System.Drawing;
using Mapsui.Geometries;

namespace Mapsui.Rendering.Gdi
{
    class MultiPolygonRenderer
    {
        public static void Render(Graphics graphics, MultiPolygon pols, Brush brush, Pen pen, IViewport viewport)
        {
            foreach (var t in pols.Polygons)
                PolygonRenderer.DrawPolygon(graphics, t, brush, pen, viewport);
        }
    }
}
