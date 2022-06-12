using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class StationModel
    {
        [Key]
         public int StationId { get; set; }
        public string StatusStation { get; set; }
    }

