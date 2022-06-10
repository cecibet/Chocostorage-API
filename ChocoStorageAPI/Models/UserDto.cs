﻿namespace ChocoStorageAPI.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? Role { get; set; } // admin/employee
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool LoginStatus { get; set; }
    }
}
