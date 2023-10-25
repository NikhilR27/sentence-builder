using Application.Words.Queries;
using MediatR;

namespace UnitTests;

[TestFixture]
public class HandlerTests
{
    [Test]
    public void QueriesAndCommands_ShouldEach_HaveMatchingHandler()
    {
        var assembly = typeof(GetWordTypesQuery).Assembly;
        var requestTypes = assembly.GetTypes().Where(IsRequest).ToList();
        var handlerType = assembly.GetTypes().Where(IsIRequestHandler).ToList();

        foreach (var requestType in requestTypes)
        {
            Assert.That(IsHandlerForRequest(handlerType, requestType), Is.True);
        }
    }

    private static bool IsRequest(Type type)
    {
        return typeof(IBaseRequest).IsAssignableFrom(type);
    }

    private static bool IsIRequestHandler(Type type)
    {
        return type.GetInterfaces().Any(interfaceType =>
            interfaceType.IsGenericType && interfaceType.GetGenericTypeDefinition() == typeof(IRequestHandler<,>));
    }

    private static bool IsHandlerForRequest(List<Type> handlerType, Type requestType)
    {
        return handlerType.Any(h => h.GetInterfaces().Any(i => i.GenericTypeArguments.Any(ta => ta == requestType)));
    }
}