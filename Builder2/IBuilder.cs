using System;
using System.Net.Http.Headers;

namespace Builder2;

interface IBuilder
{
    IBuilder StartUpOperations(string optionalStartUpMessage = " Making a car for you.");
    IBuilder BuildBody(string optionalBodyType = "Steel");
    IBuilder InsertWheels(int optionalNoOfWheels = 4);
    IBuilder AddHeadlights(int optionalNoOfHeadLights = 2);
    IBuilder EndOperations(string optionalEndMessage = "Car construction is completed.");
    Product ConstructCar();
}
