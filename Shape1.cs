namespace Homework3
{
	public class Shape
	{
		public double area;
		public string name;

		public Shape ()
		{
			area = 0;
			name = "";
	    }

		public virtual void Area()
		{

			Console.WriteLine($"The area of {name} is equal to {area} ");
		}
	}

	public class Circle : Shape
	{
		private double _radius;

		public Circle (double r)
        {
			_radius = r;
			name = "circle";
        }

		public override void Area()
		{
			area = Math.PI * Math.Pow(_radius, 2);
			base.Area();
		}
	}

	public class Triangle : Shape
	{
		private double _base;
		private double _hieght;

		public Triangle(double a, double h)
		{
			_base = a;
			_hieght = h;
			name = "triangle";
		}

		public override void Area()
		{
			area = 0.5*_base*_hieght;
			base.Area();
		}
	}

	public class Trapezoid : Shape
	{
		private double _side1;
		private double _side2;
		private double _hieght;

		public Trapezoid(double side1, double side2, double h)
		{
			_side1 = side1;
			_side2 = side2;
			_hieght = h;
			name = "trapezoid";
		}

		public override void Area()
		{
			area = 0.5 * (_side1+_side2) * _hieght;
			base.Area();
		}
	}

}