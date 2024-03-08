<<<<<<< HEAD
﻿using System;


namespace ExcecoesPersonalizadas01.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn{ get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {
        }

        public Reservation (int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duratation()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out"
                + ", "
                + Duratation()
                + " nights";
        }
    }
}
=======
﻿using System;


namespace ExcecoesPersonalizadas01.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn{ get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {
        }

        public Reservation (int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duratation()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out"
                + ", "
                + Duratation()
                + " nights";
        }
    }
}
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
