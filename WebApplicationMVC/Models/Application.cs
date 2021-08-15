using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Models
{
    public enum DesireblePosition
    {
        Engineer,
        Manager,
        Worker
    }

    public enum Status
    {
        Waiting,
        Accepted
    }

    public class Application
    {
        [NotMapped]
        public Dictionary<string, string> Validation { get => new Dictionary<string, string>()
        {
            { "asd.png", "ADCJ" },

            { "asd1.png", "ADCJ1" }
        }; }

        private KeyValuePair<string, string> choosed;
        //;/9)"|\\\\\\\\
        public Application()
        {
            choosed = Validation.ElementAt(new Random().Next(0, Validation.Count - 1));
        }

        public int Id { get; set; }

        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearsOfExperience { get; set; }

        public DesireblePosition DesireblePosition { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string FilePath { get; set; }

        public Status Status { get; set; }

        [NotMapped]
        public string ChoosedValue { get; set; }

        [NotMapped]
        public KeyValuePair<string, string> Choosed { get => choosed; set => choosed = value; }

        [NotMapped]
        public IFormFile File { get; set; }

        [NotMapped]
        public /*IFromFile*/IFormFile ChoosedFile { get; set; }
    }
}
