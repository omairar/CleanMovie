using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime ExpiryTime { get; set; }

        public decimal TotalCost { get; set; }

        //one to Many with Member
        public IEnumerable<Member> Members { get; set; }



        //many to many with MovieReantals
        public IEnumerable<MovieRental> MovieRentals { get; set; }
    }
}
