﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using MathLibrary;
using Newtonsoft.Json;
using Point = MathLibrary.Point;

namespace GeometryLibrary
{
    /// <summary>
    /// Class for a drawing containing and drawing different types of curves.
    /// </summary>
    public class Drawing
    {
        private readonly List<Curve> _curves = new List<Curve>();

        public event EventHandler Redraw;

        /// <summary>
        /// The curves of the drawing as <see cref="IReadOnlyList&lt;Point&gt;"/>.
        /// </summary>
        public IReadOnlyList<Curve> Curves => _curves.AsReadOnly();

        /// <summary>
        /// Adds the passed curve to the drawing.
        /// </summary>
        /// <param name="newCurve">The curve to add.</param>
        public void AddCurve(Curve newCurve)
        {
            _curves.Add(newCurve);

            if (Redraw != null)
            {
                Redraw(newCurve, new EventArgs());
            }
        }

        /// <summary>
        /// Removes the curve at the given index from the drawing.
        /// </summary>
        /// <param name="index">The index where the curve will be removed.</param>
        public void RemoveCurve(int index)
        {
            Curve curve = _curves.ElementAt(index);

            _curves.RemoveAt(index);

            if (Redraw != null)
            {
                Redraw(curve, new EventArgs());
            }
        }

        /// <summary>
        /// Draws all contained curves.
        /// </summary>
        /// <param name="g">The graphics context to be used.</param>
        public void Draw(Graphics g)
        {
            foreach (var curve in _curves)
            {
                curve.Draw(g);
            }
        }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="curves">The curves to be contained in the drawing.</param>
        public Drawing(Curve[] curves)
        {
            _curves.AddRange(curves);
        }

        public CurveContainer<Line> GetLines()
        {
            CurveContainer<Line> container = new CurveContainer<Line>();
            container.AddRange(_curves.Where(element => element.GetType() == typeof(Line)).Select(line => line as Line));
            return container;
        }

        public CurveContainer<Circle> GetCircles()
        {
            CurveContainer<Circle> container = new CurveContainer<Circle>();
            container.AddRange(_curves.Where(element => element.GetType() == typeof(Circle)).Select(circle => circle as Circle));
            return container;
        }

        public CurveContainer<Polyline> GetPolylines()
        {
            CurveContainer<Polyline> container = new CurveContainer<Polyline>();
            container.AddRange(_curves.Where(element => element.GetType() == typeof(Polyline)).Select(polyline => polyline as Polyline));
            return container;
        }

        public void RemoveAllCurves()
        {
            var curves =_curves.ToArray();

            _curves.Clear();

            if(Redraw != null)
            {
                Redraw(curves, EventArgs.Empty);
            }
        }

        public void Save(string fileName)
        {
            var serializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.Auto };

            using (TextWriter writer = File.CreateText(fileName))
            {
                serializer.Serialize(writer, _curves);
            }
        }

        public void Load(string fileName)
        {
            var serializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.Auto };

            using (TextReader reader = File.OpenText(fileName))
            {
                _curves.Clear();
                _curves.AddRange(serializer.Deserialize(reader, typeof(List<Curve>)) as List<Curve>);
            }
        }
    }
}
