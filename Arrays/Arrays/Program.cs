using System;
using System.Security.Cryptography.X509Certificates;
public abstract class EmployeeBase
{
    public abstract string Name { get; set; }
    public abstract string Position { get; set; }

    public abstract void GetDetails();
}

public class Manager : EmployeeBase
{
    public override string Name { get; set; }
    public override string Position { get; set; }
    public string Grade { get; set; }


    public override void GetDetails()
    {
        
    }
    public void WhoAreYou()
    {
        
    }


   

}

   
 
