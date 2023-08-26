using lctp.infra.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lctp.infra
{
    public class Settings
    {
        private IConfiguration _configuration;
        public required string Secret { get; set; }
        public Settings(IConfiguration configuration)
        {
            _configuration = configuration;
            Secret = _configuration["SecretToken"];
        }
    }
}