namespace oop_lab2;

public class DataStructures
{
    public List<Shape> listShapes = new List<Shape>();
    public Queue<Shape> queueShapes = new Queue<Shape>();
    public Stack<Shape> stackShapes = new Stack<Shape>();

    public void AddShapeToList(Shape shape)
    {
        listShapes.Add(shape);
    }

    public void AddShapeToQueue(Shape shape)
    {
        queueShapes.Enqueue(shape);
    }

    public void AddShapeToStack(Shape shape)
    {
        stackShapes.Push(shape);
    }

    public void AddShape(Shape shape)
    {
        listShapes.Add(shape);
        queueShapes.Enqueue(shape);
        stackShapes.Push(shape);
    }

    public void DisplayDataStructures(int input)
    {
        switch (input)
        {
            case 1:
                Console.WriteLine("\nФигуры в списке: \n");
                listShapes.ForEach(listShapes => listShapes.DisplayInfo());
                break;
            case 2:
                Console.WriteLine("\nФигуры в очереди: \n");
                foreach (var shape in queueShapes)
                {
                    shape.DisplayInfo();
                }
                break;
            case 3:
                Console.WriteLine("\nФигуры в стеке: \n");
                foreach (var shape in stackShapes)
                {
                    shape.DisplayInfo();
                }
                break;
        }
       
    }
}