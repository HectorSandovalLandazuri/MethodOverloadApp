// See https://aka.ms/new-console-template for more information
var person=new PersonModel("Héctor","Sandoval");
person.GenerateEmail();
Console.WriteLine(person.Email);
person.GenerateEmail("marino.com");
Console.WriteLine(person.Email);
person.GenerateEmail("marino.com",true);
Console.WriteLine(person.Email);

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public PersonModel()
    {

    }
    public PersonModel(string firstName,string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public PersonModel(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public void GenerateEmail()
    {
        GenerateEmail("gmail.com", false);
    }
    public void GenerateEmail(string domain)
    {
        GenerateEmail(domain,false);
    }

    public void GenerateEmail(bool firsInitailMethod)
    {
        GenerateEmail("gmail.com", firsInitailMethod);
    }

    public void GenerateEmail(string domain,bool firsInitailMethod)
    {
        if (firsInitailMethod)
        {
            Email = $"{FirstName.Substring(0, 1)}.{LastName}@{domain}";
        }
        else
        {
            Email = $"{FirstName}.{LastName}@{domain}";
        }
    }


}