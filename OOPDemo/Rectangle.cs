namespace OOPDemo
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }


        public double GetArea()
        {
            var area = _length * _width;
            return area;
        }

        public double GetParameter()
        {
            var parameter = (_length * 2) + (_width * 2);
            return parameter;
        }

        public void EnglargeByFactor(double factor)
        {
            //Enlage length
            _length *= factor;

            //Enlarge width
            _width *= factor;
        }

        public void ShrinkByFactor(double factor)
        {
            //Shrink length
            _length /= factor;

            //Shrink width
            _width /= factor;
        }

        public static double GetAreaStatic(double length, double width)
        {
            return length * width;
        }
    }
}