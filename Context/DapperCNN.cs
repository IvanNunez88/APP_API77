﻿namespace APP_API77.Context
{
    public class DapperCNN(IConfiguration _Config)
    {
        public string Connection() => _Config.GetConnectionString("PROD");

    }
}
