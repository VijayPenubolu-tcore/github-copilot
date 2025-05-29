using System;

public class Member
{
    // create a method that generates a comment for a member
    public string GenerateComment(string name, string role, DateTime joinDate)
    {
        return $"{name} has been a valuable member of the team since {joinDate.ToString("MMMM dd, yyyy")}. As a {role}, they have consistently demonstrated exceptional skills and dedication.";
    }
}