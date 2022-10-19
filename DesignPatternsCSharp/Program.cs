// See https://aka.ms/new-console-template for more information
using DesignPatternsCSharp.BuilderPattern;
using DesignPatternsCSharp.BuilderPattern.PromotionExample;
using DesignPatternsCSharp.SingletonPattern;

/// <summary>
/// Builder pattern Implementation
/// </summary>
var ıscıBuilder = new IscilerConcreteBuilder();

var sendPromotion = new SendPromotion();
sendPromotion.Gonder(ıscıBuilder);

ıscıBuilder.Promosyon.ToString();

/// <summary>
/// Singleton Pattern Implementation
/// </summary>
Singleton nesne1 = Singleton.Nesne();
Console.WriteLine(nesne1.GetHashCode());

Singleton nesne2 = Singleton.Nesne();
Console.WriteLine(nesne2.GetHashCode());

A a = new A();
a.ToString();
A b = new A();
b.ToString();



