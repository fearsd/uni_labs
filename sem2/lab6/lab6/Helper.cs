using System.Text.Encodings.Web;
using System.Text.Json;

namespace lab6;

class Helper
{
    private string prefix = @"..\..\..\";
    public int[] WindowSize { get; set; }
    public Figure[] figures { get; set; }
    private string SaveFile { get ; set; }
    private Figure? choosedFigure { get; set; }
    public Helper(int[] windowSize)
    {
        WindowSize = windowSize;
        SaveFile = "save.json";
        figures = new Figure[] {};
    }
    private int[] GetRandomCenter()
    {
        Random rnd = new Random();
        return new int[] { rnd.Next(0, WindowSize[0]), rnd.Next(0, WindowSize[1]) };
    }
    private int GetRandomSize()
    {
        Random rnd = new Random();
        int m = rnd.Next(50, 150);
        return m % 2 == 0 ? m : m + 1;
    }
    private int[] GetRandomRGB()
    {
        Random rnd = new Random();
        int max = 256;
        return new int[] { rnd.Next(0, max), rnd.Next(0, max), rnd.Next(0, max) };
    }

    public void NewFigure()
    {
        Random rnd = new Random();
        int n = rnd.Next(0, 3);
        Figure f;
        switch (n)
        {
            case 0:
                f = new Square(GetRandomCenter(), GetRandomRGB(), GetRandomSize());
                break;
            case 1:
                f = new Circle(GetRandomCenter(), GetRandomRGB(), GetRandomSize());
                break;
            case 2:
                f = new Triangle(GetRandomCenter(), GetRandomRGB(), GetRandomSize());
                break;
            default:
                f = new Triangle(GetRandomCenter(), GetRandomRGB(), GetRandomSize());
                break;
        }
        figures = figures.Append(f).ToArray();
    }

    public void SaveFigures()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(figures, options);
        string filePath = Path.Combine(prefix, SaveFile);
        File.WriteAllText(filePath, jsonString);
    }
    public void LoadFigures()
    {
        Erase();
        string filePath = Path.Combine(prefix, SaveFile);
        string jsonString = File.ReadAllText(filePath);
        FigureSerializer[] _figures = JsonSerializer.Deserialize<FigureSerializer[]>(jsonString);
        foreach (var item in _figures)
        {
            switch (item.Name)
            {
                case "Квадрат":
                    figures = figures.Append(new Square(item.Center, item.RGB, item.Size)).ToArray();
                    break;
                case "Круг":
                    figures = figures.Append(new Circle(item.Center, item.RGB, item.Size)).ToArray();
                    break;
                case "Треугольник":
                    figures = figures.Append(new Triangle(item.Center, item.RGB, item.Size)).ToArray();
                    break;
            }
        }
    }
    public void ChooseFigure(MouseEventArgs e)
    {
        int[] point = new int[] { e.X, e.Y };
        foreach (var item in figures)
        {
            if (item.isPointInFigure(point))
            {
                choosedFigure = item;
                return;
            }
        }
        choosedFigure = null;
    }
    public void DrawFigures(Graphics g)
    {
        foreach (var item in figures)
        {
            item.Draw(g);
        }
        if (choosedFigure != null)
        {
            choosedFigure.Choose(g);
        }
    }
    public void Erase()
    {
        figures = new Figure[] { };
        choosedFigure = null;
    }
}

class FigureSerializer
{
    public int[] Center { get; set; }
    public int[] RGB { get; set; }
    public int Size { get; set; }
    public string Name { get; set; }
}
