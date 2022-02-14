namespace HomeWork1
{
    public class Ellipse
    {
        public Point HightEllipsePoint { get; private set; }
        public Point DownEllipsePoint { get; private set; }
        public Point RightEllipsePoint { get; private set; }
        public Point LeftEllipsePoint { get; private set; }

        public Ellipse(Point hightPoint, Point downPoint, Point leftPoint, Point rightPoint)
        {
            HightEllipsePoint = hightPoint;
            DownEllipsePoint = downPoint;
            LeftEllipsePoint = leftPoint;
            RightEllipsePoint = rightPoint;

            if (hightPoint.X < downPoint.X)
            {
                throw new ArgumentException("Верхняя точка эллипса находится ниже низшей точки эллипса");
            }

            if (leftPoint.X > rightPoint.X)
            {
                throw new ArgumentException("Левая точка эллипса находится дальше правой точки эллипса");
            }

            if (hightPoint.X != downPoint.X)
            {
                throw new ArgumentException("Координаты Х у вертикальной оси эллипса не совпадают");
            }

            if (leftPoint.Y != rightPoint.Y)
            {
                throw new ArgumentException("Координаты Y у горизонтальной оси эллипса не совпадают");
            }

            if (leftPoint.Y != ((Math.Abs(hightPoint.Y) - Math.Abs(downPoint.Y)) / 2))
            {
                throw new ArgumentException("Не правильно задана ось X эллипса");
            }

            if (hightPoint.X != ((Math.Abs(rightPoint.X) - Math.Abs(leftPoint.X)) / 2))
            {
                throw new ArgumentException("Не правильно задана ось Y эллипса");
            }




        }

        public double lenghtEllipse()
        {
            double Pi = Math.PI;
            double VerticalRadius = (HightEllipsePoint.Y - DownEllipsePoint.Y) / 2;
            double HorizontalRadius = (RightEllipsePoint.X - LeftEllipsePoint.X) / 2;

            return Pi * (VerticalRadius + HorizontalRadius);
        }

        public double squareEllipse()
        {
            double Pi = Math.PI;
            double VerticalRadius = (HightEllipsePoint.Y - DownEllipsePoint.Y) / 2;
            double HorizontalRadius = (RightEllipsePoint.X - LeftEllipsePoint.X) / 2;

            return Pi * VerticalRadius * HorizontalRadius;
        }

        public int XcoordinateCenter()
        {
            int XCoordinateCenter = (Math.Abs(RightEllipsePoint.X) - Math.Abs(LeftEllipsePoint.X)) / 2;
            
            return XCoordinateCenter;
        }

        public int YcoordinateCenter()
        {
            int YCoordinateCenter = (Math.Abs(HightEllipsePoint.Y) - Math.Abs(DownEllipsePoint.Y)) / 2;

            return YCoordinateCenter;
        }
    }
}
