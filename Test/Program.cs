using FigureLib;

Console.WriteLine("Choise a figure: 'circle', 'triangle', 'square', 'rectangle'");
var text = Console.ReadLine();
Figure figure;
switch (text.ToLower())
{
    case "circle":
        {
			figure = new Circle();
            figure.Area();
            break; 
        }
    case "triangle":
        {
            int a, b, c;
            try
            {
                Console.Write("Enter a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter b = ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Enter c = ");
                c = int.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0 || c <= 0)
                    throw new Exception("Number <= 0");
                figure = new Triangle(a, b, c);
                figure.Area();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
			break; 
        }
    case "square":
        {
            figure = new Square();
            figure.Area();
            break;
        }
	default:
        {
            Console.WriteLine("Type of figure doesn't find");
            break;
        }
}
Console.ReadLine();
