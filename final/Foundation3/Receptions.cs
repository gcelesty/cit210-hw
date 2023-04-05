using System;

public class Receptions : Event
{
    private string _email {get; set;}

    public Receptions(string title, string description, string date, string time, Address address, string eventType, string email) : base(title, description, date, time, address, eventType)
    {
        _email = email;
    }
    public string ReceptionFullDetails()
    {
        return $" \n RSVP to: {_email}";
    }
}