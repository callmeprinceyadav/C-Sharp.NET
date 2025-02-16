
class StockPortfolio
{
    List<Stock> myStocks = new List<Stock>();

    // Add a stock
    public void AddStock(string stockName, int stockCount, double stockPrice)
    {
        myStocks.Add(new Stock(stockName, stockCount, stockPrice));
    }

    // Remove a stock
    public void DeleteStock(string stockName)
    {
        myStocks.RemoveAll(s => s.name == stockName);
    }

    // Calculate total value
    public void calculateTotalPortfolioValue()
    {
        double total = 0;
        foreach (var stock in myStocks)
        {
            total += stock.count * stock.price;
        }
        Console.WriteLine("Total Portfolio : $" + total);
    }

    class Stock
    {
        public string name;
        public int count;
        public double price;

        public Stock(string name, int count, double price)
        {
            this.name = name;
            this.count = count;
            this.price = price;
        }
    }
}

class SmartHomeSystem
{
    List<string> devicesInHouse = new List<string>();

    // Add a device to the house
    public void addDevice(string deviceName)
    {
        devicesInHouse.Add(deviceName);
    }

    // Remove a device from the house
    public void removedevice(string deviceName)
    {
        devicesInHouse.Remove(deviceName);
    }

    // Turn all devices on/off
    public void Turnoffon
    (string action)
    {
        foreach (var device in devicesInHouse)
        {
            Console.WriteLine(device + action);
        }
    }
}

class TaskSchedule
{
    Queue<Task> taskQueue = new Queue<Task>();

    // Add a task
    public void addTaskToQueue(string taskName, int priority)
    {
        taskQueue.Enqueue(new Task(taskName, priority));
    }

    // Execute tasks based on priority
    public void executeAllTasks()
    {
        List<Task> sortedTasks = new List<Task>(taskQueue);
        sortedTasks.Sort((a, b) => a.priority.CompareTo(b.priority));

        foreach (var task in sortedTasks)
        {
            Console.WriteLine(task.name);
        }
    }

    class Task
    {
        public string name;
        public int priority;

        public Task(string name, int priority)
        {
            this.name = name;
            this.priority = priority;
        }
    }
}



class Program
{
    static void Main()
    {
        // Stock Portfolio Stuff
        StockPortfolio myPortfolio = new StockPortfolio();
        myPortfolio.AddStock("Apple", 10, 150);
        myPortfolio.AddStock("Tesla", 5, 700);
        myPortfolio.calculateTotalPortfolioValue();
        myPortfolio.DeleteStock("Apple");
        myPortfolio.calculateTotalPortfolioValue();

        // Smart Home Stuff
        SmartHomeSystem myHome = new SmartHomeSystem();
        myHome.addDevice("Light");
        myHome.addDevice("Fan");
        myHome.Turnoffon
        ("on");
        myHome.removedevice
("Fan");
        myHome.Turnoffon
        ("off");

        // Task Scheduler Stuff
        TaskSchedule myTaskList = new TaskSchedule();
        myTaskList.addTaskToQueue("Wash dishes", 1);
        myTaskList.addTaskToQueue("Study", 3);
        myTaskList.addTaskToQueue("Take out trash", 2);
        myTaskList.executeAllTasks();

        // Blockchain Stuff
        

        // Music Playlist Stuff
        
    }
}
