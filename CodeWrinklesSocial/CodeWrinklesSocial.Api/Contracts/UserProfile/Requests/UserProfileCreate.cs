﻿namespace CodeWrinklesSocial.Api.Contracts.UserProfile.Requests
{
    public record UserProfileCreate
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!; 
        public string Title { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DateTime DateOfBirth { get;   set; }
        public string CUrrentCity { get;   set; } = null!;
    }
}
