﻿namespace Application.Dto
{
    public class FolderDto
    {
        public int Id { get; set; }   
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public int MoviesCount { get; set; }
    }
}
