﻿
using System;
using API.Entities.Interfaces;

namespace API.Entities
{
    /// <summary>
    /// Represents the progress a single user has on a given Volume. Progress is realistically tracked against the Volume's chapters.
    /// </summary>
    public class AppUserProgress : IEntityDate
    {
        public int Id { get; set; }
        public int PagesRead { get; set; }
        public int VolumeId { get; set; }
        public int SeriesId { get; set; }
        public int ChapterId { get; set; }
        
        // Relationships
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}