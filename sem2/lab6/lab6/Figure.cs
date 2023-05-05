namespace lab6;
abstract class Figure
{
    public int[] Center { get; set; }
    public int[] RGB { get; set; }
    public int Size { get; set; }
    public string Name { get; set; }

    public Figure(int[] center, int[] rgb, int size)
    {
        Center = center;
        RGB = rgb;
        Size = size;
    }

    public override string ToString()
    {
        return $"{Name}, Площадь - {Area()}";
    }

    protected int[] GetUpperLeftPoint()
    {
        int midSize = (int)Math.Floor((decimal)(Size / 2));
        int x0 = Center[0];
        int y0 = Center[1];
        return new int[] { x0 - midSize, y0 - midSize };
    }

    public abstract double Area();
    public abstract void Draw(Graphics g);
    public abstract bool isPointInFigure(int[] point);
    public void Choose(Graphics g)
    {
        var font = new Font("Arial", 10);
        var brush = new SolidBrush(Color.Black);
        g.DrawString(ToString(), font, brush, Center[0], Center[1]);
    }
}

class Square : Figure
{
    public Square(int[] center, int[] rgb, int size) : base(center, rgb, size)
    {
        Name = "Квадрат";
    }
    public override double Area()
    {
        return Math.Pow(Size, 2);
    }
    public override bool isPointInFigure(int[] point)
    {
        int midSize = (int)Math.Floor((decimal)(Size / 2));
        int x0 = Center[0];
        int y0 = Center[1];
        int x1 = point[0];
        int y1 = point[1];
        return x0 - midSize <= x1
            && y0 - midSize <= y1
            && x0 + midSize >= x1
            && y0 + midSize >= y1;
    }

    public override void Draw(Graphics g)
    {
        int[] p = GetUpperLeftPoint();
        g.DrawRectangle(new Pen(Color.FromArgb(RGB[0], RGB[1], RGB[2])), p[0], p[1], Size, Size);
    }

}


class Circle : Figure
{
    public Circle(int[] center, int[] rgb, int size) : base(center, rgb, size)
    {
        Name = "Круг";
    }
    public override double Area()
    {
        return Math.PI * Math.Pow(Size, 2) / 4;
    }
    public override bool isPointInFigure(int[] point)
    {
        int midSize = (int)Math.Floor((decimal)(Size / 2));
        int x0 = Center[0];
        int y0 = Center[1];
        int x1 = point[0];
        int y1 = point[1];
        return Math.Pow((x1 - x0), 2) + Math.Pow((y1 - y0), 2) <= Math.Pow(midSize, 2);
    }
    public override void Draw(Graphics g)
    {
        int[] p = GetUpperLeftPoint();
        g.DrawEllipse(new Pen(Color.FromArgb(RGB[0], RGB[1], RGB[2])), p[0], p[1], Size, Size);
    }
}


class Triangle : Figure
{
    public Triangle(int[] center, int[] rgb, int size) : base(center, rgb, size)
    {
        Name = "Треугольник";
    }
    public override double Area()
    {
        return 0.5 * Math.Pow(Size, 2);
    }

    private double AreaByPoints(int x1, int y1, int x2,
                               int y2, int x3, int y3)
    {
        return Math.Abs((x1 * (y2 - y3) +
                         x2 * (y3 - y1) +
                         x3 * (y1 - y2)) / 2.0);
    }
    private int[,] GetVertexes()
    {
        int midSize = (int)Math.Floor((decimal)(Size / 2));
        int x_center = Center[0];
        int y_center = Center[1];
        int x1 = x_center;
        int y1 = y_center - midSize;
        int x2 = x_center - midSize;
        int y2 = y_center + midSize;
        int x3 = x_center + midSize;
        int y3 = y_center + midSize;
        return new int[,] { { x1, y1 }, { x2, y2 }, { x3, y3 } };
    }

    public override bool isPointInFigure(int[] point)
    {
        int x = point[0];
        int y = point[1];
        int[,] vertexes = GetVertexes();

        double A = Area();

        double A1 = AreaByPoints(x, y, vertexes[1, 0], vertexes[1, 1], vertexes[2, 0], vertexes[2, 1]);
        double A2 = AreaByPoints(vertexes[0, 0], vertexes[0, 1], x, y, vertexes[2, 0], vertexes[2, 1]);
        double A3 = AreaByPoints(vertexes[0, 0], vertexes[0, 1], vertexes[1, 0], vertexes[1, 1], x, y);

        return A >= A1 + A2 + A3;
    }

    public override void Draw(Graphics g)
    {
        int[,] vertexes = GetVertexes();
        g.DrawLine(new Pen(Color.FromArgb(RGB[0], RGB[1], RGB[2])), vertexes[0, 0], vertexes[0, 1], vertexes[1, 0], vertexes[1, 1]);
        g.DrawLine(new Pen(Color.FromArgb(RGB[0], RGB[1], RGB[2])), vertexes[0, 0], vertexes[0, 1], vertexes[2, 0], vertexes[2, 1]);
        g.DrawLine(new Pen(Color.FromArgb(RGB[0], RGB[1], RGB[2])), vertexes[1, 0], vertexes[1, 1], vertexes[2, 0], vertexes[2, 1]);
    }

}