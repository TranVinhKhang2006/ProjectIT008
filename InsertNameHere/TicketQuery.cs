
using System;
using System.ComponentModel.Design;

namespace InsertNameHere.Models
{
    public class Ticket : IIdentifiable
    {
        public long Price;
        public string BusID, Departure, Arrival;
        public DateTime CreatedAt, ExDate, DptDate, ArrDate;
        public bool Used = false;

        public Ticket(long _Price)
        {
            this.Price = _Price;
        }

        public bool CheckExDate()
        {
            if (DateTime.Now >= ExDate)
            {
                return false;
            }
            return true;
        }

        public override void Adjust()
        {
            // some stat to adjust
        }


    }
}