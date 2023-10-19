using Domain.Entities;
using NetArchTest.Rules;
using WebAPI.Controllers;

namespace UnitTests;

[TestFixture]
public class Tests
{
    [Test]
    public void Domain_HasNoDependencies_ReturnTrue()
    {
        var result = Types
            .InAssembly(typeof(WordType).Assembly)
            .ShouldNot()
            .HaveDependencyOnAny("Application", "Infrastructure")
            .GetResult();
    }

    [Test]
    public void Presentation_DoesNotReferenceInfra_ReturnTrue()
    {
        var result = Types
            .InAssembly(typeof(WordController).Assembly)
            .ShouldNot()
            .HaveDependencyOnAny("Application", "Infrastructure")
            .GetResult();
    }
}