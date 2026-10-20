

using WestCoastEducation2.InterFaces;

namespace WestCoastEducation2.Models;

public abstract class Person : IDisplayable
{
public string FirstName {get; set;}
public string LastName {get; set;}
public string Phone {get; set;}
public string PersonalNumber {get; set;}
public string Address {get; set;}
public string PostalCode {get; set;}
public string City {get; set;}

protected Person (
        string firstName,
        string lastName,
        string phone,
        string personalNumber,
        string address,
        string postalCode,
        string city
    )
    {
        FirstName=firstName;
        LastName=lastName;
        Phone=phone;
        PersonalNumber=personalNumber;
        Address=address;
        PostalCode=postalCode;
        City=city;
    }
    public virtual string GetInfo()
    {
        return $"{FirstName} {LastName} PhonNumber: {Phone} Address: {Address} {PostalCode} {City} ";

    }
    public override string ToString() => GetInfo();

}
