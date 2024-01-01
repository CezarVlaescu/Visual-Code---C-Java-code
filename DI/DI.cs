class Solution
{
    static public void Main(string[] args)
    {
        var container = new DependencyContainer();

        container.AddDependency(typeof(ServiceConsumer));
        container.AddDependency<ServiceConsumer>();
        container.AddDependency<Message>();

        var resolver = new DependencyResolver(container);

        var service = resolver.GetService<Service>();

        service.Print();

        //var a = typeof(ServiceConsumer);
        //var service = Activator.CreateInstance(typeof(Solution)) as Solution;
        //var activator = Activator.CreateInstance(typeof(ServiceConsumer), service) as ServiceConsumer;
        //activator.Print();
    }
}

public class DependencyResolver
{
    private readonly DependencyContainer _dependencyContainer;

    public DependencyResolver(DependencyContainer dependencyContainer) 
    {
        _dependencyContainer = dependencyContainer;
    }

    public T GetService<T>()
    {
        return (T) GetService(typeof(T));
    }

    public object GetService(Type type)
    {
        var dependency = _dependencyContainer.GetDependency(type);

        var constructor = dependency.GetConstructors().Single();
        var parameters = constructor.GetParameters().ToArray();

        if (parameters.Length > 0)
        {
            var parameterImplementations = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                parameterImplementations[i] = GetService(parameters[i].ParameterType);
            }

            return Activator.CreateInstance(dependency, parameterImplementations);
        }

        return Activator.CreateInstance(dependency);
    }
}


public class DependencyContainer // register the services
{
    List<Type> _dependencies;

    public void AddDependency(Type type)
    {
        _dependencies = new List<Type>();
        _dependencies.Add(item: type);
    }

    public void AddDependency<T>()
    {
        _dependencies.Add(typeof(T));
    }

    public Type GetDependency(Type type)
    {
        return _dependencies.First(x => x.Name == type.Name);
    }


}

public class ServiceConsumer
{
    private readonly Service _service;

    public ServiceConsumer(Service service)
    {
        _service = service;
    }

    public void Print() => _service.Print();
}

public class Service
{
    private readonly Message _message;

    public Service(Message message)
    {
        _message = message;
    }
    public void Print() => Console.WriteLine($"Hello {_message.Messages()}");

}

public class Message
{
    public string Messages()
    {
        return "Good job!";
    }
}
