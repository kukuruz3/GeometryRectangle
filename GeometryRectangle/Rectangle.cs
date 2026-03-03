using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryRectangle
{
    public class Rectangle
    {
        private double _x;          // Координата X левого верхнего угла
        private double _y;          // Координата Y левого верхнего угла
        private double _width;     
        private double _height;

        public Rectangle(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ширина должна быть положительным числом");
                _width = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Высота должна быть положительным числом");
                _height = value;
            }
        }
        public double Perimeter
        {
            get { return 2 * (_width + _height); }
        }
        public double Area
        {
            get { return _width * _height; }
        }
        public double Right
        {
            get { return _x + _width; }
        }

        public double Bottom
        {
            get { return _y + _height; }
        }

        public void Move(double deltaX, double deltaY)
        {
            _x += deltaX;
            _y += deltaY;
        }

        public void Resize(double newWidth, double newHeight)
        {
            Width = newWidth;
            Height = newHeight;
        }

        public bool ContainsPoint(double pointX, double pointY)
        {
            return pointX >= _x && pointX <= _x + _width &&
                   pointY >= _y && pointY <= _y + _height;
        }

        public override string ToString()
        {
            return $"Прямоугольник [({_x:F2}, {_y:F2}) - ({Right:F2}, {Bottom:F2})], " +
                   $"Ширина: {_width:F2}, Высота: {_height:F2}, " +
                   $"Периметр: {Perimeter:F2}, Площадь: {Area:F2}";
        }
    }

}

