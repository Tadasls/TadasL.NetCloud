﻿namespace WebAppMSSQL.Services.IServices
{
    public interface IJwtService
    {
        string GetJwtToken(int userId, string role);
    }
}