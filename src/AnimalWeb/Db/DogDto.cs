using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalWeb.Db
{
    public class DogDto
    {
        public int DogId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int TargetClickCount { get; set; }

        public int CurrentClickCount { get; set; }

        public string SadImg { get; set; }

        public string HappyImg { get; set; }

        public string SponsorLogo { get; set; }

        public int Bowls { get; set; }
    }
}
