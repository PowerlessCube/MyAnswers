#nullable enable

int thisCannotBeNull = 4;
// thisCannotBeNull = null; //compile error!

int? thisCouldBeNull = null;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

var address = new Address();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;

var result = address.Street?.Length ?? 3;
Console.WriteLine(result);


class Address
{
  public string? Building;
  public string Street = String.Empty;
  public string City = String.Empty;
  public string Region = String.Empty; 
}