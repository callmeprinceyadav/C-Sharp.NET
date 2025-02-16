
class ExpressionCheck
{
    public double value;

    public ExpressionCheck(double value)
    {
        this.value = value;
    }

    // Overloading + to add two ExpressionCheck objects
    public static ExpressionCheck operator +(ExpressionCheck a, ExpressionCheck b)
    {
        return new ExpressionCheck(a.value + b.value);
    }

    // Overloading - to subtract two ExpressionCheck objects
    public static ExpressionCheck operator -(ExpressionCheck a, ExpressionCheck b)
    {
        return new ExpressionCheck(a.value - b.value);
    }

    // Overloading * to multiply two ExpressionCheck objects
    public static ExpressionCheck operator *(ExpressionCheck a, ExpressionCheck b)
    {
        return new ExpressionCheck(a.value * b.value);
    }

    // Overloading / to divide two ExpressionCheck objects
    public static ExpressionCheck operator /(ExpressionCheck a, ExpressionCheck b)
    {
        return new ExpressionCheck(a.value / b.value);
    }

    // Printing the result
    public void displayResult()
    {
        Console.WriteLine("Result: " + value);
    }
}

abstract class DatabaseConnector
{
    public abstract void Connect();
}

class SQLConnector : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connected to SQL Database.");
    }
}

class MongoDBConnector : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connected to MongoDB Database.");
    }
}

class FirebaseConnector : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connected to Firebase Database.");
    }
}


abstract class AIModel
{
    public abstract void TrainModel();
}

class BasicAI : AIModel
{
    public override void TrainModel()
    {
        Console.WriteLine("Training Basic AI model with basic data...");
    }
}

class NeuralNet : AIModel
{
    public override void TrainModel()
    {
        Console.WriteLine("Training Neural Network model ");
    }
}

class DeepLearning : AIModel
{
    public override void TrainModel()
    {
        Console.WriteLine("Training Deep Learning ");
    }
}



class Program
{
    static void Main()
    {
        // Expression Evaluator Stuff
        ExpressionCheck num1 = new ExpressionCheck(10);
        ExpressionCheck num2 = new ExpressionCheck(5);
        ExpressionCheck result = num1 + num2;
        result.displayResult();

        // Database Connectors Stuff
        DatabaseConnector sql = new SQLConnector();
        sql.Connect();

        DatabaseConnector mongoDB = new MongoDBConnector();
        mongoDB.Connect();

        DatabaseConnector firebase = new FirebaseConnector();
        firebase.Connect();

        // File Compressor Stuff
        

        // AI Models Stuff
        AIModel basicAI = new BasicAI();
        basicAI.TrainModel();

        AIModel neuralNet = new NeuralNet();
        neuralNet.TrainModel();

        AIModel deepLearning = new DeepLearning();
        deepLearning.TrainModel();

        // Game Physics Stuff
       
    }
}
