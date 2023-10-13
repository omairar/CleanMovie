using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domain
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Name { get; set; } = String.Empty;

        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        ///Many to Many Realtionship

        public IEnumerable<MovieRental> MovieRentals { get; set; }

    }
}
