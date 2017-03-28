﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public class WorldRepository : IWorldRepository
    {
        private WorldContext _context;
        private ILogger<WorldRepository> _logger;

        public WorldRepository(WorldContext context, ILogger<WorldRepository> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<Trip> GetAllTrips()
        {

            _logger.LogInformation("Getting All Trips From The Database");
            return _context.Trips.ToList();
        }
    }
}