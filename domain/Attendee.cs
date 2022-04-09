using System.ComponentModel.DataAnnotations;
 
 namespace domain;

public class Attendee
{
    [Key]
    public int AttendeeId {get; set;}
    string? FirstName {get; set;}
    string? LastName {get; set;}
    string? MailAddress {get; set;}
    string? PrimaryPhoneNumber {get; set;}
    string? EmailAddress {get; set;}
    public int Grade {get; set;}
    public string? Gender {get; set;}
    public string? Ethnicity {get; set;}
    //public Session? FirstSession {get; set;}
    //public Session? SecondSession {get; set;}
}